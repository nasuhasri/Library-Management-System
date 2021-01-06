<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDetailsPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtgResult = New System.Windows.Forms.DataGridView()
        Me.txtQuickSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTextBoxFilter = New System.Windows.Forms.Button()
        Me.btnQuickSearch = New System.Windows.Forms.Button()
        Me.btnBDetailsList = New System.Windows.Forms.Button()
        Me.btnBDetailsReturn = New System.Windows.Forms.Button()
        Me.btnBDetailsDelete = New System.Windows.Forms.Button()
        Me.btnBDetailsUpdate = New System.Windows.Forms.Button()
        Me.txtBookAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookTittle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtBookISBN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBDetailsAdd = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtgResult)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(26, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 162)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULT:"
        '
        'dtgResult
        '
        Me.dtgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgResult.Location = New System.Drawing.Point(6, 19)
        Me.dtgResult.Name = "dtgResult"
        Me.dtgResult.Size = New System.Drawing.Size(628, 137)
        Me.dtgResult.TabIndex = 17
        '
        'txtQuickSearch
        '
        Me.txtQuickSearch.Location = New System.Drawing.Point(162, 187)
        Me.txtQuickSearch.Name = "txtQuickSearch"
        Me.txtQuickSearch.Size = New System.Drawing.Size(227, 22)
        Me.txtQuickSearch.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "QUICK SEARCH:"
        '
        'btnTextBoxFilter
        '
        Me.btnTextBoxFilter.Location = New System.Drawing.Point(433, 21)
        Me.btnTextBoxFilter.Name = "btnTextBoxFilter"
        Me.btnTextBoxFilter.Size = New System.Drawing.Size(201, 34)
        Me.btnTextBoxFilter.TabIndex = 8
        Me.btnTextBoxFilter.Text = "USE TEXT BOX SEARCH"
        Me.btnTextBoxFilter.UseVisualStyleBackColor = True
        '
        'btnQuickSearch
        '
        Me.btnQuickSearch.Location = New System.Drawing.Point(433, 63)
        Me.btnQuickSearch.Name = "btnQuickSearch"
        Me.btnQuickSearch.Size = New System.Drawing.Size(201, 34)
        Me.btnQuickSearch.TabIndex = 7
        Me.btnQuickSearch.Text = "USE QUICK SEARCH"
        Me.btnQuickSearch.UseVisualStyleBackColor = True
        '
        'btnBDetailsList
        '
        Me.btnBDetailsList.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBDetailsList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBDetailsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsList.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBDetailsList.Location = New System.Drawing.Point(422, 456)
        Me.btnBDetailsList.Name = "btnBDetailsList"
        Me.btnBDetailsList.Size = New System.Drawing.Size(110, 36)
        Me.btnBDetailsList.TabIndex = 23
        Me.btnBDetailsList.Text = "LIST BOOKS"
        Me.btnBDetailsList.UseVisualStyleBackColor = False
        '
        'btnBDetailsReturn
        '
        Me.btnBDetailsReturn.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBDetailsReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBDetailsReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBDetailsReturn.Location = New System.Drawing.Point(580, 456)
        Me.btnBDetailsReturn.Name = "btnBDetailsReturn"
        Me.btnBDetailsReturn.Size = New System.Drawing.Size(86, 36)
        Me.btnBDetailsReturn.TabIndex = 22
        Me.btnBDetailsReturn.Text = "RETURN"
        Me.btnBDetailsReturn.UseVisualStyleBackColor = False
        '
        'btnBDetailsDelete
        '
        Me.btnBDetailsDelete.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBDetailsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBDetailsDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBDetailsDelete.Location = New System.Drawing.Point(290, 456)
        Me.btnBDetailsDelete.Name = "btnBDetailsDelete"
        Me.btnBDetailsDelete.Size = New System.Drawing.Size(86, 36)
        Me.btnBDetailsDelete.TabIndex = 21
        Me.btnBDetailsDelete.Text = "DELETE"
        Me.btnBDetailsDelete.UseVisualStyleBackColor = False
        '
        'btnBDetailsUpdate
        '
        Me.btnBDetailsUpdate.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBDetailsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBDetailsUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBDetailsUpdate.Location = New System.Drawing.Point(163, 456)
        Me.btnBDetailsUpdate.Name = "btnBDetailsUpdate"
        Me.btnBDetailsUpdate.Size = New System.Drawing.Size(86, 36)
        Me.btnBDetailsUpdate.TabIndex = 20
        Me.btnBDetailsUpdate.Text = "UPDATE"
        Me.btnBDetailsUpdate.UseVisualStyleBackColor = False
        '
        'txtBookAuthor
        '
        Me.txtBookAuthor.Location = New System.Drawing.Point(137, 99)
        Me.txtBookAuthor.Name = "txtBookAuthor"
        Me.txtBookAuthor.Size = New System.Drawing.Size(252, 22)
        Me.txtBookAuthor.TabIndex = 6
        '
        'txtBookTittle
        '
        Me.txtBookTittle.Location = New System.Drawing.Point(137, 65)
        Me.txtBookTittle.Name = "txtBookTittle"
        Me.txtBookTittle.Size = New System.Drawing.Size(252, 22)
        Me.txtBookTittle.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "AUTHOR:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TITTLE:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(533, 178)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(101, 39)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtBookISBN
        '
        Me.txtBookISBN.Location = New System.Drawing.Point(137, 36)
        Me.txtBookISBN.Name = "txtBookISBN"
        Me.txtBookISBN.Size = New System.Drawing.Size(252, 22)
        Me.txtBookISBN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtQuickSearch)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnTextBoxFilter)
        Me.GroupBox1.Controls.Add(Me.btnQuickSearch)
        Me.GroupBox1.Controls.Add(Me.txtBookAuthor)
        Me.GroupBox1.Controls.Add(Me.txtBookTittle)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtBookISBN)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 223)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH BY:"
        '
        'btnBDetailsAdd
        '
        Me.btnBDetailsAdd.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBDetailsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBDetailsAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBDetailsAdd.Location = New System.Drawing.Point(26, 456)
        Me.btnBDetailsAdd.Name = "btnBDetailsAdd"
        Me.btnBDetailsAdd.Size = New System.Drawing.Size(86, 36)
        Me.btnBDetailsAdd.TabIndex = 19
        Me.btnBDetailsAdd.Text = "ADD"
        Me.btnBDetailsAdd.UseVisualStyleBackColor = False
        '
        'BookDetailsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 510)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnBDetailsList)
        Me.Controls.Add(Me.btnBDetailsReturn)
        Me.Controls.Add(Me.btnBDetailsDelete)
        Me.Controls.Add(Me.btnBDetailsUpdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBDetailsAdd)
        Me.Name = "BookDetailsPage"
        Me.Text = "Book Details Page"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtgResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtgResult As DataGridView
    Friend WithEvents txtQuickSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnTextBoxFilter As Button
    Friend WithEvents btnQuickSearch As Button
    Friend WithEvents btnBDetailsList As Button
    Friend WithEvents btnBDetailsReturn As Button
    Friend WithEvents btnBDetailsDelete As Button
    Friend WithEvents btnBDetailsUpdate As Button
    Friend WithEvents txtBookAuthor As TextBox
    Friend WithEvents txtBookTittle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtBookISBN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBDetailsAdd As Button
End Class
