Imports System.Data.OleDb

Public Class BookIssueInfoPage
    Private Sub BookIssueInfoPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LmsDataSet.Borrow' table. You can move, or remove it, as needed.
        Me.BorrowTableAdapter.Fill(Me.LmsDataSet.Borrow)
        'TODO: This line of code loads data into the 'LmsDataSet.Borrower' table. You can move, or remove it, as needed.
        Me.BorrowerTableAdapter.Fill(Me.LmsDataSet.Borrower)

        cmbSearch.Items.Add("ISBN")
        cmbSearch.Items.Add("Author")
        cmbSearch.Items.Add("Title")

        lblSearchBy.Visible = False
        txtSearch.Visible = False

        btnGoBorrowersInfoPg.Visible = False

        Retrive_B()
    End Sub

    Sub Retrive_B()
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\User\source\repos\Library Management System\lms.accdb'")
            conn.Open()

            Dim strsql As String
            strsql = "Select borrowerID, BorrowerName From Borrower"

            Dim cmd As New OleDbCommand(strsql, conn)
            Dim myReader As OleDbDataReader
            myReader = cmd.ExecuteReader()
            myReader.Read()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Exit this page. Return to menu page
        Me.Close()
        MenuListPage.Show()
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged
        If cmbSearch.SelectedIndex = 0 Then
            lblSearchBy.Text = "ISBN"
        ElseIf cmbSearch.SelectedIndex = 1 Then
            lblSearchBy.Text = "Author"
        ElseIf cmbSearch.SelectedIndex = 2 Then
            lblSearchBy.Text = "Title"
        End If

        lblSearchBy.Visible = True
        txtSearch.Visible = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\User\source\repos\Library Management System\lms.accdb'")
        conn.Open()

        Dim strsql As String

        If cmbSearch.SelectedIndex = 0 Then
            strsql = "select ISBN,Title from Book where ISBN='" + txtSearch.Text + "'"
        ElseIf cmbSearch.SelectedIndex = 1 Then
            strsql = "select ISBN,Title from Book where Author='" + txtSearch.Text + "'"
        ElseIf cmbSearch.SelectedIndex = 2 Then
            strsql = "select ISBN,Title from Book where Title='" + txtSearch.Text + "'"
        End If

        'Get books details
        Dim cmd As New OleDbCommand(strsql, conn)
        Dim myReader As OleDbDataReader
        myReader = cmd.ExecuteReader()
        myReader.Read()

        Try
            'Get book details
            lblISBN.Text = myReader("ISBN")
            lblBookTitle.Text = myReader("Title")
        Catch ex As Exception
            MessageBox.Show("Data Cannot Be Found: " & ex.Message.ToString(),
                            "Search Data: LMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnIssueBook_Click(sender As Object, e As EventArgs) Handles btnIssueBook.Click
        'Insert Data into Database
        Try
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\Library Management System\lms.accdb")
            conn.Open()

            Dim strsql, status As String
            status = "Not Returned"

            Dim issueDate, dueDate, retDate As DateTime
            issueDate = DTPIssueDate.Value.Date
            dueDate = DTPDueDate.Value.Date
            retDate = DTPIssueDate.Value.Date

            strsql = "INSERT INTO Borrow([IssueDate], [DueDate], [ReturnDate], [Status], [ISBN], [BorrowerID]) VALUES (?, ?, ?, ?, ?, ?)"

            Dim cmd As New OleDbCommand(strsql, conn)
            cmd.Parameters.Add(New OleDbParameter("IssueDate", CType(issueDate, Date)))
            cmd.Parameters.Add(New OleDbParameter("DueDate", CType(dueDate, Date)))
            cmd.Parameters.Add(New OleDbParameter("ReturnDate", CType(retDate, Date)))
            cmd.Parameters.Add(New OleDbParameter("Status", CType(status, String)))
            cmd.Parameters.Add(New OleDbParameter("ISBN", CType(lblISBN.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("BorrowerID", CType(BorrowerIDTextBox.Text, String)))

            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Successfully Saved!", "Record Saved: LMS", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox("Error occurred! " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Information, "Issue Book Failed!")
        End Try
    End Sub

    Private Sub btnSearchName_Click(sender As Object, e As EventArgs) Handles btnSearchName.Click
        Try
            Me.BorrowerTableAdapter.FillBy(Me.LmsDataSet.Borrower, txtSearchName.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\User\source\repos\Library Management System\lms.accdb'")
        conn.Open()

        Dim sqlBorrower As String
        sqlBorrower = "Select BR.BorrowerID, BR.BorrowerName From Borrower BR 
                       where BR.BorrowerName='" + txtSearchName.Text + "'"

        'Get Borrower details
        Dim cmdBorrower As New OleDbCommand(sqlBorrower, conn)
        Dim readerBorrower As OleDbDataReader
        readerBorrower = cmdBorrower.ExecuteReader()
        readerBorrower.Read()

        Try
            lblBorrowerID.Text = readerBorrower("BorrowerID")
            lblBorrowerName.Text = readerBorrower("BorrowerName")
        Catch ex As Exception
            MessageBox.Show("Data Cannot Be Found: " & ex.Message.ToString(),
                            "Search Name: LMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("Please Click Button Go To Borrower's Information Page To Add New Borrower",
                            "Help Information: LMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnGoBorrowersInfoPg.Visible = True
        End Try
    End Sub

    Private Sub btnGoBorrowersInfoPg_Click(sender As Object, e As EventArgs) Handles btnGoBorrowersInfoPg.Click
        Me.Close()
        BorrowersInfoPage.Show()
    End Sub
End Class