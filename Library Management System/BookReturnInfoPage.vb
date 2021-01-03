Imports System.Data.OleDb

Public Class BookReturnInfoPage
    Private Sub BookReturnInfoPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LmsDataSet.Borrower' table. You can move, or remove it, as needed.
        Me.BorrowerTableAdapter.Fill(Me.LmsDataSet.Borrower)
        'Example checkedListBox1. Guna database kat sini
        'CheckedListBox1.Items.Add("VB.NET")
        'CheckedListBox1.Items.Add("Java")
        'CheckedListBox1.Items.Add("Python")
        'CheckedListBox1.Items.Add("C")
        'CheckedListBox1.Items.Add("C#")
        'CheckedListBox1.Items.Add("PHP")
        'CheckedListBox1.Items.Add("JavaScript")
        'CheckedListBox1.Items.Add("Ruby Language")
        'CheckedListBox1.Items.Add("Android")
        'CheckedListBox1.Items.Add("Perl")

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
            'ElseIf cmbSearch.SelectedIndex = 1 Then
            '    strsql = "select ICNum from Borrower where ICNum='" + txtSearch.Text + "'"
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
                        And BR.ICNum='" + lblIC.Text + "'"

        Dim cmdListBook As New OleDbCommand(sqlListBook, conn)
        Dim readerListBook As OleDbDataReader
        readerListBook = cmdListBook.ExecuteReader()
        chkLBooks.Items.Clear()

        Try
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
End Class