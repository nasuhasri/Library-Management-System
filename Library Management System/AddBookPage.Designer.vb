<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBookPage
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
        Me.txtBookCategory = New System.Windows.Forms.TextBox()
        Me.txtPublisherName = New System.Windows.Forms.TextBox()
        Me.txtYearPublication = New System.Windows.Forms.TextBox()
        Me.txtBookTittle = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddReturn = New System.Windows.Forms.Button()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.lblDetailsBook = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBookCategory)
        Me.GroupBox1.Controls.Add(Me.txtPublisherName)
        Me.GroupBox1.Controls.Add(Me.txtYearPublication)
        Me.GroupBox1.Controls.Add(Me.txtBookTittle)
        Me.GroupBox1.Controls.Add(Me.txtAuthor)
        Me.GroupBox1.Controls.Add(Me.txtISBN)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(647, 354)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Details"
        '
        'txtBookCategory
        '
        Me.txtBookCategory.Location = New System.Drawing.Point(253, 293)
        Me.txtBookCategory.Name = "txtBookCategory"
        Me.txtBookCategory.Size = New System.Drawing.Size(355, 20)
        Me.txtBookCategory.TabIndex = 11
        '
        'txtPublisherName
        '
        Me.txtPublisherName.Location = New System.Drawing.Point(253, 246)
        Me.txtPublisherName.Name = "txtPublisherName"
        Me.txtPublisherName.Size = New System.Drawing.Size(355, 20)
        Me.txtPublisherName.TabIndex = 10
        '
        'txtYearPublication
        '
        Me.txtYearPublication.Location = New System.Drawing.Point(253, 195)
        Me.txtYearPublication.Name = "txtYearPublication"
        Me.txtYearPublication.Size = New System.Drawing.Size(355, 20)
        Me.txtYearPublication.TabIndex = 9
        '
        'txtBookTittle
        '
        Me.txtBookTittle.Location = New System.Drawing.Point(253, 144)
        Me.txtBookTittle.Name = "txtBookTittle"
        Me.txtBookTittle.Size = New System.Drawing.Size(355, 20)
        Me.txtBookTittle.TabIndex = 8
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(253, 94)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(355, 20)
        Me.txtAuthor.TabIndex = 7
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(253, 40)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(355, 20)
        Me.txtISBN.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "BOOK CATEGORY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PUBLISHER NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "AUTHOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "BOOK TITTLE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "YEAR PUBLICATION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN"
        '
        'btnAddReturn
        '
        Me.btnAddReturn.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAddReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAddReturn.Location = New System.Drawing.Point(386, 595)
        Me.btnAddReturn.Name = "btnAddReturn"
        Me.btnAddReturn.Size = New System.Drawing.Size(86, 43)
        Me.btnAddReturn.TabIndex = 7
        Me.btnAddReturn.Text = "RETURN"
        Me.btnAddReturn.UseVisualStyleBackColor = False
        '
        'btnAddBook
        '
        Me.btnAddBook.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAddBook.Location = New System.Drawing.Point(254, 595)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(86, 43)
        Me.btnAddBook.TabIndex = 6
        Me.btnAddBook.Text = "ADD"
        Me.btnAddBook.UseVisualStyleBackColor = False
        '
        'lblDetailsBook
        '
        Me.lblDetailsBook.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDetailsBook.Location = New System.Drawing.Point(42, 415)
        Me.lblDetailsBook.Name = "lblDetailsBook"
        Me.lblDetailsBook.Size = New System.Drawing.Size(650, 167)
        Me.lblDetailsBook.TabIndex = 5
        '
        'AddBookPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 650)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAddReturn)
        Me.Controls.Add(Me.btnAddBook)
        Me.Controls.Add(Me.lblDetailsBook)
        Me.Name = "AddBookPage"
        Me.Text = "Add Book Page"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBookCategory As TextBox
    Friend WithEvents txtPublisherName As TextBox
    Friend WithEvents txtYearPublication As TextBox
    Friend WithEvents txtBookTittle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddReturn As Button
    Friend WithEvents btnAddBook As Button
    Friend WithEvents lblDetailsBook As Label
End Class
