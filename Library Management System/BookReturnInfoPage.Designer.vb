<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookReturnInfoPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookReturnInfoPage))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSelectItem = New System.Windows.Forms.Button()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRetFines = New System.Windows.Forms.Label()
        Me.lblRetStatus = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblIssueDate = New System.Windows.Forms.Label()
        Me.lblPubName = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblPubYr = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkLBooks = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BorrowerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LmsDataSet = New Library_Management_System.lmsDataSet()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BorrowerTableAdapter = New Library_Management_System.lmsDataSetTableAdapters.BorrowerTableAdapter()
        Me.TableAdapterManager = New Library_Management_System.lmsDataSetTableAdapters.TableAdapterManager()
        Me.lblDummy = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSelectItem)
        Me.GroupBox1.Controls.Add(Me.lblIC)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.chkLBooks)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1146, 555)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Return Information"
        '
        'btnSelectItem
        '
        Me.btnSelectItem.Location = New System.Drawing.Point(248, 366)
        Me.btnSelectItem.Name = "btnSelectItem"
        Me.btnSelectItem.Size = New System.Drawing.Size(210, 65)
        Me.btnSelectItem.TabIndex = 18
        Me.btnSelectItem.Text = "Select Item"
        Me.btnSelectItem.UseVisualStyleBackColor = True
        '
        'lblIC
        '
        Me.lblIC.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIC.Location = New System.Drawing.Point(248, 87)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(268, 40)
        Me.lblIC.TabIndex = 17
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(248, 41)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(268, 40)
        Me.lblName.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "IC Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Borrower's Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblRetFines)
        Me.GroupBox2.Controls.Add(Me.lblRetStatus)
        Me.GroupBox2.Controls.Add(Me.lblDueDate)
        Me.GroupBox2.Controls.Add(Me.lblIssueDate)
        Me.GroupBox2.Controls.Add(Me.lblPubName)
        Me.GroupBox2.Controls.Add(Me.lblAuthor)
        Me.GroupBox2.Controls.Add(Me.lblTitle)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblPubYr)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblISBN)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(548, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(565, 479)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book Details"
        '
        'lblRetFines
        '
        Me.lblRetFines.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblRetFines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRetFines.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetFines.Location = New System.Drawing.Point(230, 417)
        Me.lblRetFines.Name = "lblRetFines"
        Me.lblRetFines.Size = New System.Drawing.Size(268, 36)
        Me.lblRetFines.TabIndex = 26
        '
        'lblRetStatus
        '
        Me.lblRetStatus.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblRetStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRetStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetStatus.Location = New System.Drawing.Point(230, 365)
        Me.lblRetStatus.Name = "lblRetStatus"
        Me.lblRetStatus.Size = New System.Drawing.Size(268, 36)
        Me.lblRetStatus.TabIndex = 25
        '
        'lblDueDate
        '
        Me.lblDueDate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblDueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.Location = New System.Drawing.Point(230, 317)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(268, 36)
        Me.lblDueDate.TabIndex = 24
        '
        'lblIssueDate
        '
        Me.lblIssueDate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblIssueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIssueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueDate.Location = New System.Drawing.Point(230, 271)
        Me.lblIssueDate.Name = "lblIssueDate"
        Me.lblIssueDate.Size = New System.Drawing.Size(268, 36)
        Me.lblIssueDate.TabIndex = 23
        '
        'lblPubName
        '
        Me.lblPubName.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPubName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPubName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPubName.Location = New System.Drawing.Point(230, 224)
        Me.lblPubName.Name = "lblPubName"
        Me.lblPubName.Size = New System.Drawing.Size(268, 36)
        Me.lblPubName.TabIndex = 22
        '
        'lblAuthor
        '
        Me.lblAuthor.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(230, 176)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(268, 36)
        Me.lblAuthor.TabIndex = 21
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(230, 128)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(268, 36)
        Me.lblTitle.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 418)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 25)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Late Return Fines"
        '
        'lblPubYr
        '
        Me.lblPubYr.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPubYr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPubYr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPubYr.Location = New System.Drawing.Point(230, 80)
        Me.lblPubYr.Name = "lblPubYr"
        Me.lblPubYr.Size = New System.Drawing.Size(268, 36)
        Me.lblPubYr.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 365)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 25)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Late Return Status"
        '
        'lblISBN
        '
        Me.lblISBN.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN.Location = New System.Drawing.Point(230, 33)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(268, 36)
        Me.lblISBN.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Author"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 25)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Due Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ISBN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Publication Year"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 25)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Issue Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 25)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Publisher's Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Title"
        '
        'chkLBooks
        '
        Me.chkLBooks.FormattingEnabled = True
        Me.chkLBooks.Location = New System.Drawing.Point(244, 195)
        Me.chkLBooks.Name = "chkLBooks"
        Me.chkLBooks.Size = New System.Drawing.Size(272, 129)
        Me.chkLBooks.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "List of Books Borrowed"
        '
        'BorrowerBindingSource
        '
        Me.BorrowerBindingSource.DataMember = "Borrower"
        Me.BorrowerBindingSource.DataSource = Me.LmsDataSet
        '
        'LmsDataSet
        '
        Me.LmsDataSet.DataSetName = "lmsDataSet"
        Me.LmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnReturnBook
        '
        Me.btnReturnBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBook.Location = New System.Drawing.Point(327, 771)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(225, 72)
        Me.btnReturnBook.TabIndex = 1
        Me.btnReturnBook.Text = "Return Book"
        Me.btnReturnBook.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(621, 771)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(225, 72)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.lblSearchBy)
        Me.GroupBox3.Controls.Add(Me.cmbSearch)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(24, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1146, 100)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(778, 29)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(171, 57)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(511, 49)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(209, 30)
        Me.txtSearch.TabIndex = 12
        '
        'lblSearchBy
        '
        Me.lblSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBy.Location = New System.Drawing.Point(343, 49)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(185, 25)
        Me.lblSearchBy.TabIndex = 11
        Me.lblSearchBy.Text = "Search By"
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(142, 46)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(157, 33)
        Me.cmbSearch.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 25)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Search By"
        '
        'BorrowerTableAdapter
        '
        Me.BorrowerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.BorrowerTableAdapter = Me.BorrowerTableAdapter
        Me.TableAdapterManager.BorrowTableAdapter = Nothing
        Me.TableAdapterManager.Late_Return_FinesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Library_Management_System.lmsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'lblDummy
        '
        Me.lblDummy.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblDummy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDummy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDummy.Location = New System.Drawing.Point(48, 735)
        Me.lblDummy.Name = "lblDummy"
        Me.lblDummy.Size = New System.Drawing.Size(268, 36)
        Me.lblDummy.TabIndex = 27
        '
        'BookReturnInfoPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1199, 912)
        Me.Controls.Add(Me.lblDummy)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReturnBook)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BookReturnInfoPage"
        Me.Text = "BookReturnInfoPage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkLBooks As CheckedListBox
    Friend WithEvents btnReturnBook As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearchBy As Label
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LmsDataSet As lmsDataSet
    Friend WithEvents BorrowerBindingSource As BindingSource
    Friend WithEvents BorrowerTableAdapter As lmsDataSetTableAdapters.BorrowerTableAdapter
    Friend WithEvents TableAdapterManager As lmsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblBorrowerName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblIC As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblIssueDate As Label
    Friend WithEvents lblPubName As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPubYr As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents lblRetFines As Label
    Friend WithEvents lblRetStatus As Label
    Friend WithEvents btnSelectItem As Button
    Friend WithEvents lblDummy As Label
End Class
