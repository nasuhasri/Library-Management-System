Public Class BookReturnInfoPage
    Private Sub BookReturnInfoPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Example checkedListBox1. Guna database kat sini
        CheckedListBox1.Items.Add("VB.NET")
        CheckedListBox1.Items.Add("Java")
        CheckedListBox1.Items.Add("Python")
        CheckedListBox1.Items.Add("C")
        CheckedListBox1.Items.Add("C#")
        CheckedListBox1.Items.Add("PHP")
        CheckedListBox1.Items.Add("JavaScript")
        CheckedListBox1.Items.Add("Ruby Language")
        CheckedListBox1.Items.Add("Android")
        CheckedListBox1.Items.Add("Perl")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'exit this page and return to the menu list page
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        'click this button to insert the return date data into the database.
    End Sub
End Class