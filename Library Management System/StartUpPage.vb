Public Class Start_Up
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim registerForm As RegistrationPage
        registerForm = New RegistrationPage
        Me.Hide()
        registerForm.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginForm As LoginPage
        loginForm = New LoginPage
        Me.Hide()
        loginForm.Show()
    End Sub
End Class