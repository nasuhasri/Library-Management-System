Public Class MenuListPage
    Private Sub BorrowerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowerDetailsToolStripMenuItem.Click
        Me.Hide()
        BorrowersInfoPage.Show()
    End Sub

    Private Sub BookIssuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookIssuesToolStripMenuItem.Click
        Me.Hide()
        BookIssueInfoPage.Show()
    End Sub

    Private Sub BookReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookReturnToolStripMenuItem.Click
        Me.Hide()
        BookReturnInfoPage.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim startUpForm As Start_Up
        startUpForm = New Start_Up
        Me.Hide()
        startUpForm.Show()
    End Sub

    Private Sub BookDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookDetailsToolStripMenuItem.Click
        Dim bookDetailsForm As BookDetailsPage
        bookDetailsForm = New BookDetailsPage
        Me.Hide()
        bookDetailsForm.Show()
    End Sub
End Class