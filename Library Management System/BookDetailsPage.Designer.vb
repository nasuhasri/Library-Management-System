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
        Me.btnBDetailsList = New System.Windows.Forms.Button()
        Me.btnBDetailsReturn = New System.Windows.Forms.Button()
        Me.btnBDetailsDelete = New System.Windows.Forms.Button()
        Me.btnBDetailsUpdate = New System.Windows.Forms.Button()
        Me.btnBDetailsAdd = New System.Windows.Forms.Button()
        Me.lstBookCategory = New System.Windows.Forms.ListBox()
        Me.lstPublisherName = New System.Windows.Forms.ListBox()
        Me.lstAuthor = New System.Windows.Forms.ListBox()
        Me.lstBookTittle = New System.Windows.Forms.ListBox()
        Me.lstYearPublication = New System.Windows.Forms.ListBox()
        Me.lstISBN = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInputSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSearchType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnBDetailsList
        '
        Me.btnBDetailsList.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBDetailsList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBDetailsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsList.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBDetailsList.Location = New System.Drawing.Point(594, 332)
        Me.btnBDetailsList.Name = "btnBDetailsList"
        Me.btnBDetailsList.Size = New System.Drawing.Size(110, 36)
        Me.btnBDetailsList.TabIndex = 29
        Me.btnBDetailsList.Text = "LIST BOOKS"
        Me.btnBDetailsList.UseVisualStyleBackColor = False
        '
        'btnBDetailsReturn
        '
        Me.btnBDetailsReturn.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBDetailsReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBDetailsReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBDetailsReturn.Location = New System.Drawing.Point(759, 332)
        Me.btnBDetailsReturn.Name = "btnBDetailsReturn"
        Me.btnBDetailsReturn.Size = New System.Drawing.Size(86, 36)
        Me.btnBDetailsReturn.TabIndex = 28
        Me.btnBDetailsReturn.Text = "RETURN"
        Me.btnBDetailsReturn.UseVisualStyleBackColor = False
        '
        'btnBDetailsDelete
        '
        Me.btnBDetailsDelete.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBDetailsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBDetailsDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBDetailsDelete.Location = New System.Drawing.Point(460, 332)
        Me.btnBDetailsDelete.Name = "btnBDetailsDelete"
        Me.btnBDetailsDelete.Size = New System.Drawing.Size(86, 36)
        Me.btnBDetailsDelete.TabIndex = 27
        Me.btnBDetailsDelete.Text = "DELETE"
        Me.btnBDetailsDelete.UseVisualStyleBackColor = False
        '
        'btnBDetailsUpdate
        '
        Me.btnBDetailsUpdate.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBDetailsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBDetailsUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBDetailsUpdate.Location = New System.Drawing.Point(328, 332)
        Me.btnBDetailsUpdate.Name = "btnBDetailsUpdate"
        Me.btnBDetailsUpdate.Size = New System.Drawing.Size(86, 36)
        Me.btnBDetailsUpdate.TabIndex = 26
        Me.btnBDetailsUpdate.Text = "UPDATE"
        Me.btnBDetailsUpdate.UseVisualStyleBackColor = False
        '
        'btnBDetailsAdd
        '
        Me.btnBDetailsAdd.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBDetailsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBDetailsAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBDetailsAdd.Location = New System.Drawing.Point(-90, 332)
        Me.btnBDetailsAdd.Name = "btnBDetailsAdd"
        Me.btnBDetailsAdd.Size = New System.Drawing.Size(86, 36)
        Me.btnBDetailsAdd.TabIndex = 25
        Me.btnBDetailsAdd.Text = "ADD"
        Me.btnBDetailsAdd.UseVisualStyleBackColor = False
        '
        'lstBookCategory
        '
        Me.lstBookCategory.FormattingEnabled = True
        Me.lstBookCategory.Location = New System.Drawing.Point(1031, 145)
        Me.lstBookCategory.Name = "lstBookCategory"
        Me.lstBookCategory.Size = New System.Drawing.Size(150, 147)
        Me.lstBookCategory.TabIndex = 24
        '
        'lstPublisherName
        '
        Me.lstPublisherName.FormattingEnabled = True
        Me.lstPublisherName.Location = New System.Drawing.Point(834, 145)
        Me.lstPublisherName.Name = "lstPublisherName"
        Me.lstPublisherName.Size = New System.Drawing.Size(150, 147)
        Me.lstPublisherName.TabIndex = 23
        '
        'lstAuthor
        '
        Me.lstAuthor.FormattingEnabled = True
        Me.lstAuthor.Location = New System.Drawing.Point(636, 145)
        Me.lstAuthor.Name = "lstAuthor"
        Me.lstAuthor.Size = New System.Drawing.Size(150, 147)
        Me.lstAuthor.TabIndex = 22
        '
        'lstBookTittle
        '
        Me.lstBookTittle.FormattingEnabled = True
        Me.lstBookTittle.Location = New System.Drawing.Point(441, 145)
        Me.lstBookTittle.Name = "lstBookTittle"
        Me.lstBookTittle.Size = New System.Drawing.Size(150, 147)
        Me.lstBookTittle.TabIndex = 21
        '
        'lstYearPublication
        '
        Me.lstYearPublication.FormattingEnabled = True
        Me.lstYearPublication.Location = New System.Drawing.Point(242, 145)
        Me.lstYearPublication.Name = "lstYearPublication"
        Me.lstYearPublication.Size = New System.Drawing.Size(150, 147)
        Me.lstYearPublication.TabIndex = 20
        '
        'lstISBN
        '
        Me.lstISBN.FormattingEnabled = True
        Me.lstISBN.Location = New System.Drawing.Point(41, 145)
        Me.lstISBN.Name = "lstISBN"
        Me.lstISBN.Size = New System.Drawing.Size(150, 147)
        Me.lstISBN.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(495, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ISBN/AUTHOR/TITTLE"
        '
        'txtInputSearch
        '
        Me.txtInputSearch.Location = New System.Drawing.Point(759, 86)
        Me.txtInputSearch.Name = "txtInputSearch"
        Me.txtInputSearch.Size = New System.Drawing.Size(313, 20)
        Me.txtInputSearch.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "SEARCH BY"
        '
        'cboSearchType
        '
        Me.cboSearchType.FormattingEnabled = True
        Me.cboSearchType.Items.AddRange(New Object() {"ISBN", "Author", "Tittle"})
        Me.cboSearchType.Location = New System.Drawing.Point(307, 85)
        Me.cboSearchType.Name = "cboSearchType"
        Me.cboSearchType.Size = New System.Drawing.Size(121, 21)
        Me.cboSearchType.TabIndex = 15
        '
        'BookDetailsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 424)
        Me.Controls.Add(Me.btnBDetailsList)
        Me.Controls.Add(Me.btnBDetailsReturn)
        Me.Controls.Add(Me.btnBDetailsDelete)
        Me.Controls.Add(Me.btnBDetailsUpdate)
        Me.Controls.Add(Me.btnBDetailsAdd)
        Me.Controls.Add(Me.lstBookCategory)
        Me.Controls.Add(Me.lstPublisherName)
        Me.Controls.Add(Me.lstAuthor)
        Me.Controls.Add(Me.lstBookTittle)
        Me.Controls.Add(Me.lstYearPublication)
        Me.Controls.Add(Me.lstISBN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInputSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSearchType)
        Me.Name = "BookDetailsPage"
        Me.Text = "Book Details Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBDetailsList As Button
    Friend WithEvents btnBDetailsReturn As Button
    Friend WithEvents btnBDetailsDelete As Button
    Friend WithEvents btnBDetailsUpdate As Button
    Friend WithEvents btnBDetailsAdd As Button
    Friend WithEvents lstBookCategory As ListBox
    Friend WithEvents lstPublisherName As ListBox
    Friend WithEvents lstAuthor As ListBox
    Friend WithEvents lstBookTittle As ListBox
    Friend WithEvents lstYearPublication As ListBox
    Friend WithEvents lstISBN As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInputSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSearchType As ComboBox
End Class
