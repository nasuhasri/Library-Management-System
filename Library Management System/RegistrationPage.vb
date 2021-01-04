Public Class RegistrationPage
    Private Sub UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserBindingNavigatorSaveItem.Click
        ' Save DataBinding
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LmsDataSet)

        ' Code
        ' btnSubmit.PerformClick()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        ' Code
        ' btnRegister.PerformClick()
    End Sub

    Private Sub RegistrationPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LmsDataSet.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.LmsDataSet.User)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Add new
        ' MsgBox("You pressed save record button")
        Try
            Dim result As DialogResult
            result = MessageBox.Show("Do you want to save the selected record?", "Save Data : Library Project",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If (result = DialogResult.Yes) Then
                Validate()
                UserBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.LmsDataSet)

                MessageBox.Show("The record has been saved successfully.",
                                "Save Data : Library Project", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
            Else
                ' Exit sub
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Save | Update Data Failed: " & ex.Message.ToString(), "Save Data : Library Project", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Add new
        ' MsgBox("You pressed add new record button")

        Try
            With btnRegister
                If .Text = "Add New Record" Then
                    UserBindingSource.AddNew()
                    .Text = "Cancel"
                Else
                    RefreshData()
                    .Text = "Add New Record"
                End If
            End With

            ' To clear all the text box for add new user
            ' One by one but change later
            With StaffNameTextBox
                If (.CanSelect) Then
                    .Text = String.Empty
                    .Select()
                End If
            End With
        Catch ex As Exception
            MsgBox("An Error Occured: " & ex.Message.ToString(),
                    MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Add New Record Failed!")
        End Try
    End Sub

    Private Sub RefreshData()
        Try
            Me.UserBindingSource.Filter = Nothing
            Me.UserTableAdapter.Fill(Me.LmsDataSet.User)
        Catch ex As Exception
            MsgBox("Refresh Data Error!")
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim homepage As Start_Up
        homepage = New Start_Up
        Me.Close()
        homepage.Show()
    End Sub
End Class