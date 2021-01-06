Public Class BookDetailsPage
    'this OleDbDataAdapter serves as bridge to our connection and SQL statementts
    Dim da As New OleDb.OleDbDataAdapter
    Dim con As New OleDb.OleDbConnection
    'this is a temporary or imaginary tables in the memory of computer same with the datasets
    Dim dt As New DataTable
    Dim sql As String

    Private Sub BookDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\lms.accdb"

        btnTextBoxFilter.Enabled = False
        txtQuickSearch.Visible = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'we set here our SQL statements
        sql = "SELECT * FROM Book where ISBN='" & txtBookISBN.Text & "'" &
              " OR Title= '" & txtBookTittle.Text & "' OR Author='" & txtBookAuthor.Text & "'"
        Try
            'open the connection
            con.Open()
            'bind the SQL and the connection through OleDBDataAdaoter and stored to da
            da = New OleDb.OleDbDataAdapter(sql, con)
            'and whatever the value of da will be fill into dt our imaginary data table
            da.Fill(dt)
            'get the datasource of datagridview from our data table
            dtgResult.DataSource = dt

        Catch ex As Exception
            'will throw an error if something went wrong.
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        'close connection
        con.Close()
    End Sub

    Private Sub btnQuickSearch_Click(sender As Object, e As EventArgs) Handles btnQuickSearch.Click
        txtQuickSearch.Visible = True
        btnSearch.Enabled = False
        btnTextBoxFilter.Enabled = True
        txtBookTittle.Enabled = False
        txtBookAuthor.Enabled = False
        txtBookISBN.Enabled = False
        Label4.Visible = True
        txtBookAuthor.BackColor = Color.LightSkyBlue
        txtBookTittle.BackColor = Color.LightSkyBlue
        txtBookISBN.BackColor = Color.LightSkyBlue
        dtgResult.DataSource = Nothing
        dtgResult.RefreshEdit()
    End Sub

    Private Sub btnTextBoxFilter_Click(sender As Object, e As EventArgs) Handles btnTextBoxFilter.Click
        txtQuickSearch.Visible = False
        btnSearch.Enabled = True
        btnTextBoxFilter.Enabled = False
        txtBookTittle.Enabled = True
        txtBookAuthor.Enabled = True
        txtBookISBN.Enabled = True
        Label4.Visible = False
        txtBookISBN.BackColor = Color.Yellow
        txtBookTittle.BackColor = Color.Yellow
        txtBookAuthor.BackColor = Color.Yellow
        dtgResult.DataSource = Nothing
        dtgResult.RefreshEdit()
    End Sub

    Private Sub txtQuickSearch_TextChanged(sender As Object, e As EventArgs) Handles txtQuickSearch.TextChanged
        'we set here our SQL statements
        sql = "SELECT * FROM Book WHERE ISBN like '%" & txtQuickSearch.Text & "%' or Author LIKE '%" & txtQuickSearch.Text & "%' or Title LIKE '%" & txtQuickSearch.Text & "%'"

        dt = New DataTable
        Try
            'open the connection
            con.Open()
            'bind the SQL and the connection through OleDBDataAdaoter and stored to da
            da = New OleDb.OleDbDataAdapter(sql, con)
            'and whatever the value of da will be fill into dt our imaginary data table
            da.Fill(dt)
            'get the datasource of datagridview from our data table
            dtgResult.DataSource = dt

        Catch ex As Exception
            'will throw an error if something went wrong.
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        'close connection
        con.Close()
    End Sub

    Private Sub btnBDetailsReturn_Click(sender As Object, e As EventArgs) Handles btnBDetailsReturn.Click
        Dim menuForm As MenuListPage
        menuForm = New MenuListPage
        Me.Hide()
        menuForm.Show()
    End Sub

End Class