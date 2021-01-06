Imports System.Data.OleDb

Public Class RegistrationPage

    Dim conn As New OleDbConnection
        Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\User10\source\repos\Library-Management-System\Library Management System\bin\Debug\lms.accdb;"

    Private Sub Registration2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            conn.ConnectionString = dbProvider & dbSource
        End Sub

        Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
            If txtStaffName.Text = Nothing Or txtStaffID.Text = Nothing Or txtPhoneNumber.Text = Nothing Or txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
                MessageBox.Show("Please fill in the details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Using cmd As New OleDbCommand("SELECT COUNT(*) FROM [User] WHERE [Username] = @Username OR [Password] = @Password", conn)
                cmd.Parameters.AddWithValue("@StaffID", OleDbType.VarChar).Value = txtStaffID.Text.Trim
                cmd.Parameters.AddWithValue("@StaffName", OleDbType.VarChar).Value = txtStaffName.Text.Trim
                cmd.Parameters.AddWithValue("@HPNum", OleDbType.VarChar).Value = txtPhoneNumber.Text.Trim
                cmd.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUsername.Text.Trim
                cmd.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text.Trim

                Dim count = Convert.ToInt32(cmd.ExecuteScalar)
                If count > 0 Then
                    MessageBox.Show("Opps, this credentials has already been take!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using

            Using create As New OleDbCommand("INSERT INTO [User]([StaffID],[StaffName],[HPNum],[Username],[Password])VALUES(@StaffID,@StaffName,@HPNum,@Username,@Password)", conn)
                create.Parameters.AddWithValue("@StaffID", OleDbType.VarChar).Value = txtStaffID.Text.Trim
                create.Parameters.AddWithValue("@StaffName", OleDbType.VarChar).Value = txtStaffName.Text.Trim
                create.Parameters.AddWithValue("@HPNum", OleDbType.VarChar).Value = txtPhoneNumber.Text.Trim
                create.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUsername.Text.Trim
                create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text.Trim

                If create.ExecuteNonQuery Then
                    MessageBox.Show("Account has been registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtStaffID.Clear()
                    txtStaffName.Clear()
                    txtPhoneNumber.Clear()
                    txtUsername.Clear()
                    txtPassword.Clear()
                End If

                conn.Close()
            End Using
        End Sub

        Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim startUpForm As Start_Up
        startUpForm = New Start_Up
        Me.Hide()
            startUpForm.Show()
        End Sub
    End Class