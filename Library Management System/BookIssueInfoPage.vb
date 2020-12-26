Public Class BookIssueInfoPage
    Private Sub BookIssueInfoPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSearch.Items.Add("ISBN")
        cmbSearch.Items.Add("Author")
        cmbSearch.Items.Add("Title")

        lblSearchBy.Visible = False
        txtSearch.Visible = False
    End Sub

    Private Sub btnIssueBook_Click(sender As Object, e As EventArgs) Handles btnIssueBook.Click
        'Insert Data into Database
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Exit this page. Return to menu page
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
End Class