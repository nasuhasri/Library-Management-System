Public Class UserInformationPage
    Private Sub UserInformationPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStfName.Enabled = False
        txtStfHP.Enabled = False
        ' Set to details view.
        ListView1.View = View.Details
        ' Add a column with width 20 And left alignment.
        'ListView1.Columns.Add("File type", 20, HorizontalAlignment.Left)
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'exit this page and return to the menu list page.
    End Sub
End Class