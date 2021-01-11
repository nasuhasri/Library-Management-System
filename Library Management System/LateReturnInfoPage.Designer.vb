<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LateReturnInfoPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LateReturnInfoPage))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHPNum = New System.Windows.Forms.Label()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblLateRetFines = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblIssueDate = New System.Windows.Forms.Label()
        Me.lblPubNm = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPubYr = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DTPPayment = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnGenRecipt = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblTotalFines = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHPNum)
        Me.GroupBox1.Controls.Add(Me.lblIC)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(39, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1062, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrower's Details"
        '
        'lblHPNum
        '
        Me.lblHPNum.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblHPNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHPNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHPNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHPNum.Location = New System.Drawing.Point(256, 108)
        Me.lblHPNum.Name = "lblHPNum"
        Me.lblHPNum.Size = New System.Drawing.Size(243, 25)
        Me.lblHPNum.TabIndex = 15
        '
        'lblIC
        '
        Me.lblIC.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIC.Location = New System.Drawing.Point(256, 71)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(243, 25)
        Me.lblIC.TabIndex = 14
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(256, 36)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(243, 25)
        Me.lblName.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IC Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Borrower's Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.lblSearchBy)
        Me.GroupBox2.Controls.Add(Me.cmbSearch)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(39, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1062, 88)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(861, 23)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(171, 57)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(594, 38)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(209, 30)
        Me.txtSearch.TabIndex = 12
        '
        'lblSearchBy
        '
        Me.lblSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBy.Location = New System.Drawing.Point(358, 43)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(208, 25)
        Me.lblSearchBy.TabIndex = 11
        Me.lblSearchBy.Text = "Search By"
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(136, 40)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(199, 33)
        Me.cmbSearch.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Search By"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblLateRetFines)
        Me.GroupBox3.Controls.Add(Me.lblDueDate)
        Me.GroupBox3.Controls.Add(Me.lblIssueDate)
        Me.GroupBox3.Controls.Add(Me.lblPubNm)
        Me.GroupBox3.Controls.Add(Me.lblAuthor)
        Me.GroupBox3.Controls.Add(Me.lblTitle)
        Me.GroupBox3.Controls.Add(Me.lblPubYr)
        Me.GroupBox3.Controls.Add(Me.lblISBN)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(39, 317)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1062, 237)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Book Details"
        '
        'lblLateRetFines
        '
        Me.lblLateRetFines.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblLateRetFines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLateRetFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLateRetFines.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLateRetFines.Location = New System.Drawing.Point(740, 139)
        Me.lblLateRetFines.Name = "lblLateRetFines"
        Me.lblLateRetFines.Size = New System.Drawing.Size(286, 25)
        Me.lblLateRetFines.TabIndex = 24
        '
        'lblDueDate
        '
        Me.lblDueDate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblDueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDueDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.Location = New System.Drawing.Point(740, 103)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(286, 25)
        Me.lblDueDate.TabIndex = 23
        '
        'lblIssueDate
        '
        Me.lblIssueDate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblIssueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIssueDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIssueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueDate.Location = New System.Drawing.Point(740, 67)
        Me.lblIssueDate.Name = "lblIssueDate"
        Me.lblIssueDate.Size = New System.Drawing.Size(286, 25)
        Me.lblIssueDate.TabIndex = 22
        '
        'lblPubNm
        '
        Me.lblPubNm.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPubNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPubNm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPubNm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPubNm.Location = New System.Drawing.Point(740, 31)
        Me.lblPubNm.Name = "lblPubNm"
        Me.lblPubNm.Size = New System.Drawing.Size(286, 25)
        Me.lblPubNm.TabIndex = 21
        '
        'lblAuthor
        '
        Me.lblAuthor.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(213, 140)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(243, 25)
        Me.lblAuthor.TabIndex = 20
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(213, 103)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(243, 25)
        Me.lblTitle.TabIndex = 19
        '
        'lblPubYr
        '
        Me.lblPubYr.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPubYr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPubYr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPubYr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPubYr.Location = New System.Drawing.Point(213, 67)
        Me.lblPubYr.Name = "lblPubYr"
        Me.lblPubYr.Size = New System.Drawing.Size(243, 25)
        Me.lblPubYr.TabIndex = 18
        '
        'lblISBN
        '
        Me.lblISBN.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblISBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN.Location = New System.Drawing.Point(213, 32)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(243, 25)
        Me.lblISBN.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(533, 140)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 25)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Late Return Fines"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(533, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 25)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Due Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(533, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 25)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Issue Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(533, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 25)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Publisher's Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Title"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Publication Year"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "ISBN"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotalFines)
        Me.GroupBox4.Controls.Add(Me.DTPPayment)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtPayment)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(39, 581)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1062, 186)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fines Payment"
        '
        'DTPPayment
        '
        Me.DTPPayment.Location = New System.Drawing.Point(213, 122)
        Me.DTPPayment.Name = "DTPPayment"
        Me.DTPPayment.Size = New System.Drawing.Size(286, 30)
        Me.DTPPayment.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 25)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Date Payment"
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(213, 80)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(286, 30)
        Me.txtPayment.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(186, 25)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Borrower's Payment"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 25)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Total Fines"
        '
        'btnGenRecipt
        '
        Me.btnGenRecipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenRecipt.Location = New System.Drawing.Point(244, 792)
        Me.btnGenRecipt.Name = "btnGenRecipt"
        Me.btnGenRecipt.Size = New System.Drawing.Size(199, 75)
        Me.btnGenRecipt.TabIndex = 12
        Me.btnGenRecipt.Text = "Generate Receipt"
        Me.btnGenRecipt.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(615, 792)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(199, 75)
        Me.btnReturn.TabIndex = 13
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblTotalFines
        '
        Me.lblTotalFines.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTotalFines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotalFines.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFines.Location = New System.Drawing.Point(213, 40)
        Me.lblTotalFines.Name = "lblTotalFines"
        Me.lblTotalFines.Size = New System.Drawing.Size(286, 25)
        Me.lblTotalFines.TabIndex = 25
        '
        'LateReturnInfoPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1190, 968)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnGenRecipt)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LateReturnInfoPage"
        Me.Text = "LateReturnInfoPage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearchBy As Label
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DTPPayment As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents btnGenRecipt As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblHPNum As Label
    Friend WithEvents lblIC As Label
    Friend WithEvents lblName As Label
    Friend WithEvents PublisherNameLabel1 As Label
    Friend WithEvents ISBNLabel1 As Label
    Friend WithEvents YearPublishLabel1 As Label
    Friend WithEvents AuthorLabel1 As Label
    Friend WithEvents TitleLabel1 As Label
    Friend WithEvents lblPubNm As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPubYr As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblIssueDate As Label
    Friend WithEvents lblLateRetFines As Label
    Friend WithEvents lblTotalFines As Label
End Class
