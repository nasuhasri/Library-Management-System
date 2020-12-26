Public Class LateReturnInfoPage
    Private Sub LateReturnInfoPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSearch.Items.Add("Borrower's Name")
        cmbSearch.Items.Add("IC Number")
        lblSearchBy.Visible = False
        txtSearch.Visible = False
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged
        If cmbSearch.SelectedIndex = 0 Then
            lblSearchBy.Text = "Borrower's Name"
        Else
            lblSearchBy.Text = "IC Number"
        End If

        lblSearchBy.Visible = True
        txtSearch.Visible = True
    End Sub

    Private Sub btnGenRecipt_Click(sender As Object, e As EventArgs) Handles btnGenRecipt.Click
        'Print Receipt
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowCurrentPage = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub
End Class