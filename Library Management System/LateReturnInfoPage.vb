Imports System.Data.OleDb

Public Class LateReturnInfoPage
    Private Sub LateReturnInfoPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LmsDataSet.Book' table. You can move, or remove it, as needed.
        cmbSearch.Items.Add("Borrower's Name")
        cmbSearch.Items.Add("IC Number")
        lblSearchBy.Visible = False
        txtSearch.Visible = False
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged
        If cmbSearch.SelectedIndex = 0 Then
            lblSearchBy.Text = "Borrower's Name"
        Else
            lblSearchBy.Text = "IC Number"
        End If

        lblSearchBy.Visible = True
        txtSearch.Visible = True
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        MenuListPage.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\User\source\repos\Library Management System\lms.accdb'")
        conn.Open()

        Dim sqlSearch, sqlBook As String

        If (cmbSearch.SelectedIndex = 0) Or (cmbSearch.SelectedIndex = 1) Then
            'sqlSearch = "Select BR.BorrowerName, BR.ICNum, BR.HPNum, BK.ISBN, BK.YearPublish, BK.Title, BK.Author," _
            '             & " BK.PublisherName, BO.IssueDate, BO.DueDate, LR.LateRetFines" _
            '             & " from Borrower BR, Borrow BO, Book BK, Late Return Fines LR" _
            '             & " where BR.BorrowerID = BO.BorrowerID" _
            '             & " and BO.ISBN = BK.ISBN" _
            '             & " and LR.BorrowID = BO.BorrowID" _
            '             & " and BR.BorrowerName='" + txtSearch.Text + "' OR BR.ICNum='" + txtSearch.Text + "'"
            sqlSearch = "Select BR.BorrowerName, BR.ICNum, BR.HPNum
                         From Borrower BR, Borrow BO
                         Where BR.BorrowerID = BO.BorrowerID
                         And BO.LateRetStatus = true
                         And (BR.BorrowerName='" + txtSearch.Text + "'
                         OR BR.ICNum='" + txtSearch.Text + "')"
        End If

        sqlBook = "Select BK.ISBN, BK.YearPublish, BK.Title, BK.Author, BK.PublisherName, BO.IssueDate, 
                   BO.DueDate From Book BK, Borrow BO, Borrower BR
                   Where BK.ISBN = BO.ISBN
                   And BR.BorrowerID = BO.BorrowerID
                   And BO.LateRetStatus = true
                   And (BR.BorrowerName='" + txtSearch.Text + "'
                   OR BR.ICNum='" + txtSearch.Text + "')"

        Dim cmdBook As New OleDbCommand(sqlBook, conn)
        Dim cmdSearch As New OleDbCommand(sqlSearch, conn)

        Dim myReader, readerBook As OleDbDataReader
        myReader = cmdSearch.ExecuteReader()
        myReader.Read()
        readerBook = cmdBook.ExecuteReader()
        readerBook.Read()

        Try
            'Borrower's Details
            lblName.Text = myReader("BorrowerName")
            lblIC.Text = myReader("ICNum")
            lblHPNum.Text = myReader("HPNum")

            'Book Details
            lblISBN.Text = readerBook("ISBN")
            lblPubYr.Text = readerBook("YearPublish")
            lblTitle.Text = readerBook("Title")
            lblAuthor.Text = readerBook("Author")
            lblPubNm.Text = readerBook("PublisherName")

            'Date
            lblIssueDate.Text = readerBook("IssueDate")
            lblDueDate.Text = readerBook("DueDate")
        Catch ex As Exception
            MessageBox.Show("Data Cannot Be Found: " & ex.Message.ToString(),
                            "Search Data/Book: LMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim amtFines As Decimal
        amtFines = calcFines()
        lblLateRetFines.Text = amtFines.ToString("C")
        lblTotalFines.Text = amtFines.ToString("C")

        conn.Close()
    End Sub

    Public Function calcFines()
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\User\source\repos\Library Management System\lms.accdb'")
        conn.Open()

        Dim sqlGetDate As String
        Dim amtFines As Decimal = 0
        Dim todayDate As Date = Today.ToString("d")
        Dim duedate As Date
        Dim span As TimeSpan
        Dim intDays As Integer

        sqlGetDate = "Select BO.DueDate From Borrow BO, Borrower BR, Book BK
                      Where BO.BorrowerID = BR.BorrowerID
                      And BO.ISBN = BK.ISBN
                      And BR.BorrowerName='" + lblName.Text + "'
                      And BK.ISBN='" + lblISBN.Text + "'"

        Dim cmdDate As New OleDbCommand(sqlGetDate, conn)
        Dim readerDate As OleDbDataReader
        readerDate = cmdDate.ExecuteReader()
        readerDate.Read()

        duedate = readerDate("DueDate")

        span = todayDate - duedate
        intDays = span.TotalDays.ToString()

        amtFines = intDays * 0.7

        conn.Close()

        Return amtFines
    End Function

    Private Sub btnGenRecipt_Click(sender As Object, e As EventArgs) Handles btnGenRecipt.Click
        'Print Receipt
        'PrintDialog1.Document = PrintDocument1
        'PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        'PrintDialog1.AllowCurrentPage = True

        'If PrintDialog1.ShowDialog = DialogResult.OK Then
        '    PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        '    PrintDocument1.Print()
        'End If

        Dim amtFines, decPayment As Decimal
        amtFines = calcFines()
        decPayment = txtPayment.Text

        Dim todayDate As DateTime
        todayDate = DTPPayment.Value.Date

        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\User\source\repos\Library Management System\lms.accdb'")
        conn.Open()

        Dim sqlPayment, sqlGetBorrowID As String

        sqlGetBorrowID = "Select BO.BorrowID FROM Borrow BO WHERE BO.ISBN='" + lblISBN.Text + "'"
        Dim cmdID As New OleDbCommand(sqlGetBorrowID, conn)
        Dim myReader As OleDbDataReader
        myReader = cmdID.ExecuteReader()
        myReader.Read()

        Dim intBorrowID As Integer
        intBorrowID = myReader("BorrowID")

        sqlPayment = "INSERT INTO LRFines([LateRetFines], [Payment], [DatePayment], [BorrowID])
                      VALUES (?, ?, ?, ?)"

        Dim cmdPayment As New OleDbCommand(sqlPayment, conn)
        cmdPayment.Parameters.Add(New OleDbParameter("LateRetFines", CType(amtFines, Decimal)))
        cmdPayment.Parameters.Add(New OleDbParameter("Payment", CType(decPayment, Decimal)))
        cmdPayment.Parameters.Add(New OleDbParameter("DatePayment", CType(todayDate, Date)))
        cmdPayment.Parameters.Add(New OleDbParameter("BorrowID", CType(intBorrowID, Integer)))

        Try
            cmdPayment.ExecuteNonQuery()
            MessageBox.Show("Payment Record Successfully Saved!", "Successfully Saved!", MessageBoxButtons.OK)
        Catch ex As Exception
            MsgBox("Error On Inserting Payment Record! " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or
                MsgBoxStyle.Information, "Insert Payment Record Failed!")
        End Try
    End Sub
End Class