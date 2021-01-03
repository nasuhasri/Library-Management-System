Public Class MenuListPage
    Private Sub BorrowerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowerDetailsToolStripMenuItem.Click
        Me.Hide()
        BorrowersInfoPage.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BookIssuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookIssuesToolStripMenuItem.Click
        Me.Hide()
        BookIssueInfoPage.Show()
    End Sub

    Private Sub BookReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookReturnToolStripMenuItem.Click
        Me.Hide()
        BookReturnInfoPage.Show()
    End Sub
End Class