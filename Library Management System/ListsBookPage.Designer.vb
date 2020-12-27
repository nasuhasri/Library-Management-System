<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListsBookPage
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstBooks = New System.Windows.Forms.ListBox()
        Me.txtLBookYearTo = New System.Windows.Forms.TextBox()
        Me.txtLBookYearFrom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLBookReturn = New System.Windows.Forms.Button()
        Me.btnLBookSort = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstBooks)
        Me.GroupBox1.Controls.Add(Me.txtLBookYearTo)
        Me.GroupBox1.Controls.Add(Me.txtLBookYearFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(630, 267)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Year Publication"
        '
        'lstBooks
        '
        Me.lstBooks.FormattingEnabled = True
        Me.lstBooks.Location = New System.Drawing.Point(23, 103)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(553, 134)
        Me.lstBooks.TabIndex = 5
        '
        'txtLBookYearTo
        '
        Me.txtLBookYearTo.Location = New System.Drawing.Point(397, 58)
        Me.txtLBookYearTo.Name = "txtLBookYearTo"
        Me.txtLBookYearTo.Size = New System.Drawing.Size(179, 20)
        Me.txtLBookYearTo.TabIndex = 4
        '
        'txtLBookYearFrom
        '
        Me.txtLBookYearFrom.Location = New System.Drawing.Point(94, 56)
        Me.txtLBookYearFrom.Name = "txtLBookYearFrom"
        Me.txtLBookYearFrom.Size = New System.Drawing.Size(179, 20)
        Me.txtLBookYearFrom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(345, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FROM"
        '
        'btnLBookReturn
        '
        Me.btnLBookReturn.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLBookReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLBookReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLBookReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLBookReturn.Location = New System.Drawing.Point(404, 334)
        Me.btnLBookReturn.Name = "btnLBookReturn"
        Me.btnLBookReturn.Size = New System.Drawing.Size(84, 41)
        Me.btnLBookReturn.TabIndex = 5
        Me.btnLBookReturn.Text = "RETURN"
        Me.btnLBookReturn.UseVisualStyleBackColor = False
        '
        'btnLBookSort
        '
        Me.btnLBookSort.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLBookSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLBookSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLBookSort.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLBookSort.Location = New System.Drawing.Point(255, 334)
        Me.btnLBookSort.Name = "btnLBookSort"
        Me.btnLBookSort.Size = New System.Drawing.Size(84, 41)
        Me.btnLBookSort.TabIndex = 4
        Me.btnLBookSort.Text = "SORT"
        Me.btnLBookSort.UseVisualStyleBackColor = False
        '
        'ListsBookPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 398)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLBookReturn)
        Me.Controls.Add(Me.btnLBookSort)
        Me.Name = "ListsBookPage"
        Me.Text = "Lists Book Page"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstBooks As ListBox
    Friend WithEvents txtLBookYearTo As TextBox
    Friend WithEvents txtLBookYearFrom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLBookReturn As Button
    Friend WithEvents btnLBookSort As Button
End Class
