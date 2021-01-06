Imports System.Data.OleDb
Imports System.TimeSpan

Public Class BookReturnInfoPage
    Private Sub BookReturnInfoPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LmsDataSet.Borrower' table. You can move, or remove it, as needed.
        Me.BorrowerTableAdapter.Fill(Me.LmsDataSet.Borrower)

        lblSearchBy.Visible = False
        txtSearch.Visible = False

        cmbSearch.Items.Add("Name")
        cmbSearch.Items.Add("IC Number")
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged
        If cmbSearch.SelectedIndex = 0 Then
            lblSearchBy.Text = "Name"
        Else
            lblSearchBy.Text = "IC Number"
        End If

        lblSearchBy.Visible = True
        txtSearch.Visible = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\User\source\repos\Library Management System\lms.accdb'")
        conn.Open()

        Dim strsql, sqlListBook As String

        If (cmbSearch.SelectedIndex = 0) Or (cmbSearch.SelectedIndex = 1) Then
            strsql = "select BorrowerName, ICNum from Borrower where BorrowerName='" + txtSearch.Text + "' OR " _
                        & "ICNum='" + txtSearch.Text + "'"
        End If

        Dim cmd As New OleDbCommand(strsql, conn)
        Dim myReader As OleDbDataReader
        myReader = cmd.ExecuteReader()
        myReader.Read()

        Try
            lblName.Text = myReader("BorrowerName")
            lblIC.Text = myReader("ICNum")
        Catch ex As Exception
            MessageBox.Show("Data Cannot Be Found: " & ex.Message.ToString(),
                            "Search Data: LMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        sqlListBook = "Select B.Title From Book B, Borrow BO, Borrower BR 
                        Where B.ISBN = BO.ISBN
                        And BO.BorrowerID = BR.BorrowerID
                        And BR.ICNum='" + lblIC.Text + "'
                        And BR.BorrowerName='" + lblName.Text + "'"

        Dim cmdListBook As New OleDbCommand(sqlListBook, conn)
        Dim readerListBook As OleDbDataReader
        readerListBook = cmdListBook.ExecuteReader()

        Try
            chkLBooks.Items.Clear()
            While readerListBook.Read()
                chkLBooks.Items.Add(readerListBook("Title"))
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        MenuListPage.Show()
    End Sub

    Private Sub btnSelectItem_Click(sender As Object, e As EventArgs) Handles btnSelectItem.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\User\source\repos\Library Management System\lms.accdb'")
        conn.Open()

        Dim sqlBook As String
        Dim amtFines As Decimal = 0

        Dim intIndex As Integer
        For intIndex = 0 To chkLBooks.CheckedItems.Count - 1
            Dim title As String = chkLBooks.CheckedItems(intIndex)
            sqlBook = "Select B.ISBN, B.YearPublish, B.Title, B.Author, B.PublisherName, BO.IssueDate,
                    BO.DueDate, BO.LateRetStatus From Book B, Borrow BO, Borrower BR
                    Where B.ISBN = BO.ISBN
                    And BO.BorrowerID = BR.BorrowerID
                    And BR.ICNum='" + lblIC.Text + "'
                    And B.Title='" + title + "'"

            Dim cmdBook As New OleDbCommand(sqlBook, conn)
            Dim readerBook As OleDbDataReader
            readerBook = cmdBook.ExecuteReader()

            Dim retStatus As Boolean

            While readerBook.Read()
                lblISBN.Text = readerBook("ISBN")
                lblPubYr.Text = readerBook("YearPublish")
                lblTitle.Text = readerBook("Title")
                lblAuthor.Text = readerBook("Author")
                lblPubName.Text = readerBook("PublisherName")
                lblIssueDate.Text = readerBook("IssueDate")
                lblDueDate.Text = readerBook("DueDate")
                retStatus = readerBook("LateRetStatus")

                If retStatus = True Then
                    lblRetStatus.Text = "YES"
                    MessageBox.Show("You have late return fines that need to be settled!", "Return Book Failed: LMS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                    amtFines = 5.0
                    lblRetFines.Text = amtFines.ToString("C")
                Else
                    lblRetStatus.Text = "NO"
                    lblRetFines.Text = amtFines.ToString("C")
                End If
            End While
        Next
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        MessageBox.Show("Are You Sure You Want To Return The Book?")
        Dim ISBN As String
        ISBN = lblISBN.Text

        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\User\source\repos\Library Management System\lms.accdb'")
        conn.Open()

        Dim dateNow As Date = Today

        If String.IsNullOrEmpty(ISBN) Then
            MessageBox.Show("Please Select Book To Be Returned!", "Return Book Failed: LMS",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Try
            Dim sqlDate As String
            sqlDate = "UPDATE Borrow B SET B.ReturnDate='" + dateNow + "' WHERE B.ISBN='" + ISBN + "'"

            Dim cmdDate As New OleDbCommand(sqlDate, conn)
            cmdDate.Parameters.Add(New OleDbParameter("ReturnDate", CType(dateNow, Date)))

            cmdDate.ExecuteNonQuery()
            MessageBox.Show("Book Is Successfully Returned!", "Return Book Success: LMS",
                            MessageBoxButtons.OK)
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Information, "Return Book Failed!")
        End Try

        'Proses Delete Lepas Pulang Buku
        'Try
        '    Dim sqlDeleteRec As String
        '    sqlDeleteRec = "DELETE FROM Borrow B WHERE B.ISBN='" + ISBN + "'"

        '    Dim cmdDel As New OleDbCommand(sqlDeleteRec, conn)

        '    cmdDel.ExecuteNonQuery()
        '    cmdDel.Dispose()
        '    MessageBox.Show("Record Successfully Deleted!", "Delete Record Book Success: LMS",
        '                    MessageBoxButtons.OK)
        'Catch ex As Exception
        '    MessageBox.Show("Delete Records In Table Borrower Failed: " & ex.Message.ToString(),
        '                    "Delete Data: LMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class