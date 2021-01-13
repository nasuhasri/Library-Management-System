Imports System.Data.OleDb
Public Class BorrowersInfoPage

    Public Shared strTitleBook(10) As String

    Private Sub Borrowers_Info_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LmsDataSet.Book' table. You can move, or remove it, as needed.
        'Me.BookTableAdapter.Fill(Me.LmsDataSet.Book)
        'TODO: This line of code loads data into the 'LmsDataSet.Borrower' table. You can move, or remove it, as needed.
        'Guna untuk keluarkan data dalam BorrowerBindingSource
        Me.BorrowerTableAdapter.Fill(Me.LmsDataSet.Borrower)

        'Clear All Items in Listox
        ListBooksBorrowed.Items.Clear()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        MenuListPage.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'To search data
        'Search data and filter data on BorrowerBindingSource
        Me.BorrowerTableAdapter.FillBy(Me.LmsDataSet.Borrower, txtSearch.Text)

        'Clear All Items in Listox
        ListBooksBorrowed.Items.Clear()

        'Open connection
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\Library Management System\lms.accdb")
        conn.Open()

        Dim strsql As String
        'Get title of book using BorrowerID as condition after user clicked search button
        strsql = "Select BK.Title From Book BK, Borrow BO, Borrower BR 
                  Where BK.ISBN = BO.ISBN
                  And BO.BorrowerID = BR.BorrowerID
                  And BO.BorrowerID='" + BorrowerIDTextBox.Text + "'"

        Dim cmd As New OleDbCommand(strsql, conn)
        Dim myReader As OleDbDataReader
        myReader = cmd.ExecuteReader

        Dim intI As Integer
        Try
            'Read data from db and add into ListBooksBorrowed
            While myReader.Read()
                ListBooksBorrowed.Items.Add(myReader("Title"))
            End While

            'Count how many books in the list then store them too in array variable: strTitleBook(10)
            For intI = 0 To ListBooksBorrowed.Items.Count - 1
                strTitleBook(intI) = ListBooksBorrowed.Items(intI).ToString()
                MessageBox.Show(strTitleBook(intI))
            Next
        Catch ex As Exception
            MessageBox.Show("No Books Borrowed! | Data Cannot Be Found! " & ex.Message.ToString(),
                            "Search Borrower: LMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        'Count Number of Books in ListBox
        Dim intTitle As Integer = 0

        For Each item In ListBooksBorrowed.Items
            intTitle += 1
        Next

        'Total Books 
        lblNumBooks.Text = intTitle.ToString()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)
        btnAdd.PerformClick()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
        btnDelete.PerformClick()
    End Sub

    Private Sub BorrowerBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        'Me.Validate()
        'Me.BorrowerBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.LmsDataSet)
        'TODO

        btnUpdate.PerformClick()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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

    Public Function calcDays()
        'To calc how many days from Today - DueDate
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\User\source\repos\Library Management System\lms.accdb'")
        conn.Open()

        Dim sqlGetDate, sqlReturnStatus, status As String
        Dim amtFines As Decimal = 0
        Dim todayDate As Date = Today.ToString("d")
        Dim duedate, returndate As Date
        Dim span As TimeSpan
        Dim intDays As Integer

        'Get status of record if returned or not returned
        'To get OverDue Days. If returned = ReturnDate - DueDate else Today - DueDate
        sqlReturnStatus = "Select BO.Status FROM Borrow BO, Borrower BR, Book BK
                           Where BO.BorrowerID = BR.BorrowerID
                           And BK.ISBN = BO.ISBN
                           And BK.Title='" + lblTitle.Text + "'
                           And BO.BorrowerID='" + BorrowerIDTextBox.Text + "'"

        Dim cmdStatus As New OleDbCommand(sqlReturnStatus, conn)
        Dim readerStatus As OleDbDataReader
        readerStatus = cmdStatus.ExecuteReader()
        readerStatus.Read()

        status = readerStatus("Status")

        'If status = Returned, get ReturnDate & DueDate, else only get DueDate
        If status = "Returned" Then
            sqlGetDate = "Select BO.ReturnDate, BO.DueDate From Borrow BO, Book BK
                          Where BK.ISBN = BO.ISBN
                          And BK.Title='" + lblTitle.Text + "'
                          And BO.BorrowerID='" + BorrowerIDTextBox.Text + "'"
        ElseIf status = "Not Returned" Then
            sqlGetDate = "Select BO.DueDate From Borrow BO, Book BK
                          Where BK.ISBN = BO.ISBN
                          And BK.Title='" + lblTitle.Text + "'
                          And BO.BorrowerID='" + BorrowerIDTextBox.Text + "'"
        End If

        Dim cmdDate As New OleDbCommand(sqlGetDate, conn)
        Dim readerDate As OleDbDataReader
        readerDate = cmdDate.ExecuteReader()
        readerDate.Read()

        duedate = readerDate("DueDate")

        'Count overdue days
        If status = "Returned" Then
            returndate = readerDate("ReturnDate")
            span = returndate - duedate
        ElseIf status = "Not Returned" Then
            span = todayDate - duedate
        End If

        intDays = span.TotalDays.ToString()
        conn.Close()

        Return intDays
    End Function

    Private Sub ListBooksBorrowed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBooksBorrowed.SelectedIndexChanged
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\User\source\repos\Library Management System\lms.accdb'")
        conn.Open()

        Dim intIndex, intdays As Integer
        Dim strBook, sqlBook As String
        Dim amtFines As Decimal = 0

        For intIndex = 0 To ListBooksBorrowed.Items.Count - 1
            strBook = ListBooksBorrowed.SelectedItem.ToString()
            If strBook = strTitleBook(intIndex) Then
                MessageBox.Show("Hello " + strBook)
            End If
        Next

        'Get all details of books and compare Title with 'strBook' if selected
        sqlBook = "Select BK.ISBN, BK.YearPublish, BK.Title, BK.Author, BK.PublisherName, BO.IssueDate, BO.ReturnDate
                   FROM BOOk BK, Borrow BO
                   Where BK.ISBN = BO.ISBN
                   And BK.Title='" + strBook + "'"

        Dim cmdBooks As New OleDbCommand(sqlBook, conn)
        Dim readerBook As OleDbDataReader
        readerBook = cmdBooks.ExecuteReader()
        readerBook.Read()

        Try
            'Details of books
            lblISBN.Text = readerBook("ISBN")
            lblPubYr.Text = readerBook("YearPublish")
            lblTitle.Text = readerBook("Title")
            lblAuthor.Text = readerBook("Author")
            lblPubName.Text = readerBook("PublisherName")

            'Details of date
            lblDateBorrowed.Text = readerBook("IssueDate")
            lblDateReturned.Text = readerBook("ReturnDate")

            'Details of fines. May get (-)number since Today-DueDate. Refer db
            intdays = calcDays()
            lblOverdueDays.Text = intdays

            amtFines = intdays * 0.7
            lblLateRetFines.Text = amtFines.ToString("C")
        Catch ex As Exception
            MessageBox.Show("Error Occurred!" & ex.Message.ToString())
        End Try
    End Sub
End Class