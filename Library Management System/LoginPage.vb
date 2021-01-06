Imports System.Data.OleDb

Public Class LoginPage

    Dim conn As New OleDbConnection
        Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\User10\source\repos\Library-Management-System\Library Management System\bin\Debug\lms.accdb;"

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            conn.ConnectionString = dbProvider & dbSource
        End Sub

        Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
            If txtLoginUsername.Text = Nothing Or txtLoginPassword.Text = Nothing Then
                MessageBox.Show("Please enter your correct credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Using login As New OleDbCommand("SELECT COUNT(*) FROM [User] where [Username] = @Username AND [Password] = @Password", conn)
                login.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtLoginUsername.Text.Trim
                login.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtLoginPassword.Text.Trim

                Dim loginCount = Convert.ToInt32(login.ExecuteScalar())
                If loginCount > 0 Then
                    Me.Hide()
                MenuListPage.Show()
            Else
                    MessageBox.Show("Opps, Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtLoginUsername.Clear()
                    txtLoginPassword.Clear()
                End If
            End Using
        conn.Close()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim startUpForm As Start_Up
        startUpForm = New Start_Up
        Me.Hide()
        startUpForm.Show()
    End Sub
End Class