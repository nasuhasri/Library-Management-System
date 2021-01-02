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

            'While myReader.Read
            '    cmbBorrowerID.Items.Add(myReader.Item("BorrowerID"))
            'End While
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
        Else
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
        Else
            strsql = "select ISBN,Title from Book where Title='" + txtSearch.Text + "'"
        End If

        Dim cmd As New OleDbCommand(strsql, conn)
        Dim myReader As OleDbDataReader
        myReader = cmd.ExecuteReader()
        myReader.Read()

        Try
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

            Dim strsql As String

            'strsql = "INSERT INTO Borrow ([IssueDate], [DueDate], [ReturnDate], [LateRetStatus], [ISBN], [BorrowerID]" _
            '         & "VALUES('" & DTPIssueDate.Value & "','" & DTPDueDate.Value & "','" & DTPIssueDate.Value & "'," _
            '         & "'No'," & "'" & lblISBN.Text & "','" & BorrowerIDTextBox.Text & "')"

            Dim issueDate, dueDate, retDate As DateTime
            issueDate = DTPIssueDate.Value.Date
            dueDate = DTPDueDate.Value.Date
            retDate = DTPIssueDate.Value.Date

            strsql = "INSERT INTO Borrow([IssueDate], [DueDate], [ReturnDate], [ISBN], [BorrowerID]) VALUES (?, ?, ?, ?, ?)"

            Dim cmd As New OleDbCommand(strsql, conn)
            cmd.Parameters.Add(New OleDbParameter("IssueDate", CType(issueDate, Date)))
            cmd.Parameters.Add(New OleDbParameter("DueDate", CType(dueDate, Date)))
            cmd.Parameters.Add(New OleDbParameter("ReturnDate", CType(retDate, Date)))
            cmd.Parameters.Add(New OleDbParameter("ISBN", CType(lblISBN.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("BorrowerID", CType(BorrowerIDTextBox.Text, String)))
            'cmd.Parameters.Add(New OleDbParameter("IssueDate", CType(DTPDueDate.Value, String)))
            'cmd.Parameters.Add("IssueDate", OleDbType.DateTime).Value = DateTimePicker1.Value

            cmd.ExecuteNonQuery()
            MessageBox.Show("Saved")


        Catch ex As Exception
            MsgBox("Error occurred! " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Information, "Issue Book Failed!")
        End Try
    End Sub

    Private Sub btnSearchName_Click(sender As Object, e As EventArgs) Handles btnSearchName.Click
        Me.BorrowerTableAdapter.FillBy3(Me.LmsDataSet.Borrower, txtSearchName.Text)
    End Sub

End Class