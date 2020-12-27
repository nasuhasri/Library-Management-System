<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateBooksPage
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
        Me.btnUpdateReturn = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblDetailsUpdateBook = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboUpdateType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnUpdateReturn
        '
        Me.btnUpdateReturn.BackColor = System.Drawing.Color.DarkCyan
        Me.btnUpdateReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdateReturn.Location = New System.Drawing.Point(412, 338)
        Me.btnUpdateReturn.Name = "btnUpdateReturn"
        Me.btnUpdateReturn.Size = New System.Drawing.Size(83, 45)
        Me.btnUpdateReturn.TabIndex = 9
        Me.btnUpdateReturn.Text = "RETURN"
        Me.btnUpdateReturn.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkCyan
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(266, 338)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(83, 45)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblDetailsUpdateBook
        '
        Me.lblDetailsUpdateBook.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDetailsUpdateBook.Location = New System.Drawing.Point(78, 116)
        Me.lblDetailsUpdateBook.Name = "lblDetailsUpdateBook"
        Me.lblDetailsUpdateBook.Size = New System.Drawing.Size(645, 202)
        Me.lblDetailsUpdateBook.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "UPDATE BY"
        '
        'cboUpdateType
        '
        Me.cboUpdateType.FormattingEnabled = True
        Me.cboUpdateType.Items.AddRange(New Object() {"ISBN", "Author", "Book Tittle", "Year Publication", "Publisher Name", "Book Category"})
        Me.cboUpdateType.Location = New System.Drawing.Point(207, 68)
        Me.cboUpdateType.Name = "cboUpdateType"
        Me.cboUpdateType.Size = New System.Drawing.Size(173, 21)
        Me.cboUpdateType.TabIndex = 5
        '
        'UpdateBooksPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 405)
        Me.Controls.Add(Me.btnUpdateReturn)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblDetailsUpdateBook)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboUpdateType)
        Me.Name = "UpdateBooksPage"
        Me.Text = "Update Books Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdateReturn As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblDetailsUpdateBook As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboUpdateType As ComboBox
End Class
