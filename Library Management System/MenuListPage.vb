Public Class MenuListPage
    Private Sub BorrowerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowerDetailsToolStripMenuItem.Click
        Me.Hide()
        BorrowersInfoPage.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class