Public Class BorrowersInfoPage
    Private Sub Borrowers_Info_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        MenuListPage.Show()
    End Sub
End Class