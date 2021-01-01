Imports System.Data.OleDb
Public Class BorrowersInfoPage
    Private Sub Borrowers_Info_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LmsDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.LmsDataSet.Book)
        'TODO: This line of code loads data into the 'LmsDataSet.Borrow' table. You can move, or remove it, as needed.
        Me.BorrowTableAdapter.Fill(Me.LmsDataSet.Borrow)
        'TODO: This line of code loads data into the 'LmsDataSet.Borrower' table. You can move, or remove it, as needed.
        Me.BorrowerTableAdapter.Fill(Me.LmsDataSet.Borrower)
        'TODO: This line of code loads data into the 'LmsDataSet.Borrower' table. You can move, or remove it, as needed.
        Me.BorrowerTableAdapter.Fill(Me.LmsDataSet.Borrower)

        'Clear All Items in Listox
        ListBooksBorrowed.Items.Clear()

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\Library Management System\lms.accdb")

        conn.Open()

        Dim strsql As String

        strsql = "Select BK.Title From Book BK, Borrow B, Borrower BR 
                    Where BK.ISBN = B.ISBN
                    And B.BorrowerID = BR.BorrowerID"

        Dim cmd As New OleDbCommand(strsql, conn)
        Dim myReader As OleDbDataReader

        myReader = cmd.ExecuteReader
        myReader.Read()

        ListBooksBorrowed.Items.Add(myReader("Title"))

        'Count Number of Books in ListBox
        Dim intTitle As Integer = 0

        For Each item In ListBooksBorrowed.Items
            intTitle += 1
        Next

        txtNoBooksBorrowed.Text = intTitle.ToString()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        MenuListPage.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'To search data
        Me.BorrowerTableAdapter.FillBy2(Me.LmsDataSet.Borrower, txtSearch.Text)

        'Clear All Items in Listox
        ListBooksBorrowed.Items.Clear()

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\Library Management System\lms.accdb")

        conn.Open()

        Dim strsql As String

        strsql = "Select BK.Title From Book BK, Borrow B, Borrower BR 
                    Where BK.ISBN = B.ISBN
                    And B.BorrowerID = BR.BorrowerID"

        Dim cmd As New OleDbCommand(strsql, conn)
        Dim myReader As OleDbDataReader

        myReader = cmd.ExecuteReader
        myReader.Read()

        ListBooksBorrowed.Items.Add(myReader("Title"))

        'Count Number of Books in ListBox
        Dim intTitle As Integer = 0

        For Each item In ListBooksBorrowed.Items
            intTitle += 1
        Next

        txtNoBooksBorrowed.Text = intTitle.ToString()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        'TODO
        btnAdd.PerformClick()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        'TODO
        btnDelete.PerformClick()
    End Sub

    Private Sub BorrowerBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles BorrowerBindingNavigatorSaveItem.Click
        'Me.Validate()
        'Me.BorrowerBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.LmsDataSet)
        'TODO

        btnUpdate.PerformClick()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'add New
        'MsgBox("New Button")

        Try
            With btnAdd
                If .Text = "Add New Record" Then
                    BorrowerBindingSource.AddNew()
                    .Text = "Cancel"
                Else
                    RefreshData()
                    .Text = "Add New Record"
                End If
            End With

        Catch ex As Exception
            MsgBox("An Error Occurred: " & ex.Message.ToString(),
                   MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Add New Record Failed!")
        End Try
    End Sub

    Private Sub RefreshData()
        Try
            Me.BorrowerBindingSource.Filter = Nothing
            Me.BorrowerTableAdapter.Fill(Me.LmsDataSet.Borrower)
        Catch ex As Exception
            MsgBox("Refresh Data Error!")
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'update
        'MsgBox("update/save")

        Try
            Dim result As DialogResult
            result = MessageBox.Show("Do you want to save the selected record?", "Save Data: LMS",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (result = DialogResult.Yes) Then
                Validate()
                BorrowerBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.LmsDataSet)

                MessageBox.Show("The record has been successfully saved!",
                            "Save Data: LMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                RefreshData()

                btnAdd.Text = "Add New Record"
            Else
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("Save | Update Failed: " & ex.Message.ToString(),
                            "Save Data: LMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'delete
        'MsgBox("deleet")

        Try
            If MessageBox.Show("Do you want to permanently delete the record?", "Delete Data: LMS",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
                               Windows.Forms.DialogResult.Yes Then

                BorrowerBindingSource.RemoveCurrent()
                BorrowerBindingSource.EndEdit()
                BorrowerTableAdapter.Update(LmsDataSet.Borrower)

                RefreshData()

                MessageBox.Show("The record has been successfully deleted!",
                            "Delete Data: LMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Delete Data Failed: " & ex.Message.ToString(),
                            "Delete Data: LMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Rujukan untuk access database
    'Private Sub loadData_Click(sender As Object, e As EventArgs) Handles loadData.Click
    '    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\Library Management System\lms.accdb")

    '    conn.Open()

    '    Dim strsql As String

    '    strsql = "Select BK.Title From Book BK, Borrow B, Borrower BR 
    '                Where BK.ISBN = B.ISBN
    '                And B.BorrowerID = BR.BorrowerID"

    '    Dim cmd As New OleDbCommand(strsql, conn)

    '    Dim da As New OleDbDataAdapter

    '    da.SelectCommand = cmd

    '    Dim table1 As New DataTable

    '    table1.Clear()
    '    da.Fill(table1)
    '    DataGridView1.DataSource = table1

    '    conn.Close()

    'End Sub
End Class