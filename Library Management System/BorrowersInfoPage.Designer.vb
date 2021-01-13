<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BorrowersInfoPage
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
        Dim BorrowerNameLabel As System.Windows.Forms.Label
        Dim ICNumLabel As System.Windows.Forms.Label
        Dim HPNumLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim BorrowerIDLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLateRetFines = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblOverdueDays = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblDateReturned = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblDateBorrowed = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPubName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPubYr = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblNumBooks = New System.Windows.Forms.Label()
        Me.BorrowerIDTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LmsDataSet = New Library_Management_System.lmsDataSet()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.HPNumTextBox = New System.Windows.Forms.TextBox()
        Me.ICNumTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerNameTextBox = New System.Windows.Forms.TextBox()
        Me.ListBooksBorrowed = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.BorrowerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BorrowerTableAdapter = New Library_Management_System.lmsDataSetTableAdapters.BorrowerTableAdapter()
        Me.TableAdapterManager = New Library_Management_System.lmsDataSetTableAdapters.TableAdapterManager()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        BorrowerNameLabel = New System.Windows.Forms.Label()
        ICNumLabel = New System.Windows.Forms.Label()
        HPNumLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        BorrowerIDLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BorrowerNameLabel
        '
        BorrowerNameLabel.AutoSize = True
        BorrowerNameLabel.Location = New System.Drawing.Point(19, 85)
        BorrowerNameLabel.Name = "BorrowerNameLabel"
        BorrowerNameLabel.Size = New System.Drawing.Size(146, 20)
        BorrowerNameLabel.TabIndex = 11
        BorrowerNameLabel.Text = "Borrower Name:"
        '
        'ICNumLabel
        '
        ICNumLabel.AutoSize = True
        ICNumLabel.Location = New System.Drawing.Point(19, 122)
        ICNumLabel.Name = "ICNumLabel"
        ICNumLabel.Size = New System.Drawing.Size(104, 20)
        ICNumLabel.TabIndex = 12
        ICNumLabel.Text = "IC Number:"
        '
        'HPNumLabel
        '
        HPNumLabel.AutoSize = True
        HPNumLabel.Location = New System.Drawing.Point(19, 168)
        HPNumLabel.Name = "HPNumLabel"
        HPNumLabel.Size = New System.Drawing.Size(112, 20)
        HPNumLabel.TabIndex = 13
        HPNumLabel.Text = "HP Number:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(19, 211)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(84, 20)
        AddressLabel.TabIndex = 14
        AddressLabel.Text = "Address:"
        '
        'BorrowerIDLabel
        '
        BorrowerIDLabel.AutoSize = True
        BorrowerIDLabel.Location = New System.Drawing.Point(19, 44)
        BorrowerIDLabel.Name = "BorrowerIDLabel"
        BorrowerIDLabel.Size = New System.Drawing.Size(117, 20)
        BorrowerIDLabel.TabIndex = 15
        BorrowerIDLabel.Text = "Borrower ID:"
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(627, 98)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(169, 54)
        Me.btnReturn.TabIndex = 12
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(427, 98)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(169, 54)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(627, 25)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(169, 53)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(427, 25)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(169, 54)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add New Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(229, 25)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(169, 54)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search By Name"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLateRetFines)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lblOverdueDays)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblDateReturned)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblDateBorrowed)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblPubName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblAuthor)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblTitle)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblPubYr)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblISBN)
        Me.GroupBox1.Controls.Add(Me.lblNumBooks)
        Me.GroupBox1.Controls.Add(BorrowerIDLabel)
        Me.GroupBox1.Controls.Add(Me.BorrowerIDTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(HPNumLabel)
        Me.GroupBox1.Controls.Add(Me.HPNumTextBox)
        Me.GroupBox1.Controls.Add(ICNumLabel)
        Me.GroupBox1.Controls.Add(Me.ICNumTextBox)
        Me.GroupBox1.Controls.Add(BorrowerNameLabel)
        Me.GroupBox1.Controls.Add(Me.BorrowerNameTextBox)
        Me.GroupBox1.Controls.Add(Me.ListBooksBorrowed)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1217, 358)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrower's Details"
        '
        'lblLateRetFines
        '
        Me.lblLateRetFines.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblLateRetFines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLateRetFines.Location = New System.Drawing.Point(991, 303)
        Me.lblLateRetFines.Name = "lblLateRetFines"
        Me.lblLateRetFines.Size = New System.Drawing.Size(200, 20)
        Me.lblLateRetFines.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(819, 304)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(166, 20)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Late Return Fines:"
        '
        'lblOverdueDays
        '
        Me.lblOverdueDays.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblOverdueDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOverdueDays.Location = New System.Drawing.Point(991, 271)
        Me.lblOverdueDays.Name = "lblOverdueDays"
        Me.lblOverdueDays.Size = New System.Drawing.Size(200, 20)
        Me.lblOverdueDays.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(819, 272)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 20)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Overdue Days:"
        '
        'lblDateReturned
        '
        Me.lblDateReturned.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblDateReturned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateReturned.Location = New System.Drawing.Point(991, 241)
        Me.lblDateReturned.Name = "lblDateReturned"
        Me.lblDateReturned.Size = New System.Drawing.Size(200, 20)
        Me.lblDateReturned.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(819, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 20)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Date Returned:"
        '
        'lblDateBorrowed
        '
        Me.lblDateBorrowed.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblDateBorrowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateBorrowed.Location = New System.Drawing.Point(991, 211)
        Me.lblDateBorrowed.Name = "lblDateBorrowed"
        Me.lblDateBorrowed.Size = New System.Drawing.Size(200, 20)
        Me.lblDateBorrowed.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(819, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 20)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Date Borrowed:"
        '
        'lblPubName
        '
        Me.lblPubName.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPubName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPubName.Location = New System.Drawing.Point(991, 182)
        Me.lblPubName.Name = "lblPubName"
        Me.lblPubName.Size = New System.Drawing.Size(200, 20)
        Me.lblPubName.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(819, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 20)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Publisher Name:"
        '
        'lblAuthor
        '
        Me.lblAuthor.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuthor.Location = New System.Drawing.Point(991, 149)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(200, 20)
        Me.lblAuthor.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(819, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Author:"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Location = New System.Drawing.Point(991, 118)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(200, 20)
        Me.lblTitle.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(819, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Title:"
        '
        'lblPubYr
        '
        Me.lblPubYr.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPubYr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPubYr.Location = New System.Drawing.Point(991, 82)
        Me.lblPubYr.Name = "lblPubYr"
        Me.lblPubYr.Size = New System.Drawing.Size(200, 20)
        Me.lblPubYr.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(819, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Year Publication:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(819, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "ISBN:"
        '
        'lblISBN
        '
        Me.lblISBN.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblISBN.Location = New System.Drawing.Point(991, 42)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(200, 22)
        Me.lblISBN.TabIndex = 18
        '
        'lblNumBooks
        '
        Me.lblNumBooks.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblNumBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumBooks.Location = New System.Drawing.Point(731, 281)
        Me.lblNumBooks.Name = "lblNumBooks"
        Me.lblNumBooks.Size = New System.Drawing.Size(49, 30)
        Me.lblNumBooks.TabIndex = 17
        '
        'BorrowerIDTextBox
        '
        Me.BorrowerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowerBindingSource, "BorrowerID", True))
        Me.BorrowerIDTextBox.Location = New System.Drawing.Point(183, 41)
        Me.BorrowerIDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BorrowerIDTextBox.Name = "BorrowerIDTextBox"
        Me.BorrowerIDTextBox.Size = New System.Drawing.Size(301, 27)
        Me.BorrowerIDTextBox.TabIndex = 16
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
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowerBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(183, 208)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(301, 116)
        Me.AddressTextBox.TabIndex = 15
        '
        'HPNumTextBox
        '
        Me.HPNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowerBindingSource, "HPNum", True))
        Me.HPNumTextBox.Location = New System.Drawing.Point(183, 165)
        Me.HPNumTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HPNumTextBox.Name = "HPNumTextBox"
        Me.HPNumTextBox.Size = New System.Drawing.Size(301, 27)
        Me.HPNumTextBox.TabIndex = 14
        '
        'ICNumTextBox
        '
        Me.ICNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowerBindingSource, "ICNum", True))
        Me.ICNumTextBox.Location = New System.Drawing.Point(183, 119)
        Me.ICNumTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ICNumTextBox.Name = "ICNumTextBox"
        Me.ICNumTextBox.Size = New System.Drawing.Size(301, 27)
        Me.ICNumTextBox.TabIndex = 13
        '
        'BorrowerNameTextBox
        '
        Me.BorrowerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowerBindingSource, "BorrowerName", True))
        Me.BorrowerNameTextBox.Location = New System.Drawing.Point(183, 82)
        Me.BorrowerNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BorrowerNameTextBox.Name = "BorrowerNameTextBox"
        Me.BorrowerNameTextBox.Size = New System.Drawing.Size(301, 27)
        Me.BorrowerNameTextBox.TabIndex = 12
        '
        'ListBooksBorrowed
        '
        Me.ListBooksBorrowed.FormattingEnabled = True
        Me.ListBooksBorrowed.ItemHeight = 20
        Me.ListBooksBorrowed.Location = New System.Drawing.Point(519, 68)
        Me.ListBooksBorrowed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBooksBorrowed.Name = "ListBooksBorrowed"
        Me.ListBooksBorrowed.Size = New System.Drawing.Size(261, 164)
        Me.ListBooksBorrowed.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(515, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(262, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "List of Books Have Borrowed:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(521, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No of Books Borrowed:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(15, 35)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(185, 27)
        Me.txtSearch.TabIndex = 14
        '
        'BorrowerDataGridView
        '
        Me.BorrowerDataGridView.AllowUserToAddRows = False
        Me.BorrowerDataGridView.AllowUserToDeleteRows = False
        Me.BorrowerDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BorrowerDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BorrowerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.BorrowerDataGridView.DataSource = Me.BorrowerBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BorrowerDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.BorrowerDataGridView.Location = New System.Drawing.Point(28, 400)
        Me.BorrowerDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BorrowerDataGridView.Name = "BorrowerDataGridView"
        Me.BorrowerDataGridView.ReadOnly = True
        Me.BorrowerDataGridView.RowTemplate.Height = 24
        Me.BorrowerDataGridView.Size = New System.Drawing.Size(1043, 204)
        Me.BorrowerDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BorrowerID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Borrower ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BorrowerName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Borrower Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ICNum"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IC Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "HPNum"
        Me.DataGridViewTextBoxColumn4.HeaderText = "HP Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 250
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.btnReturn)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(28, 636)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(832, 171)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Command Control"
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
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "Book"
        Me.BookBindingSource.DataSource = Me.LmsDataSet
        '
        'BorrowersInfoPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 872)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BorrowerDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "BorrowersInfoPage"
        Me.Text = "Borrowers Information Page"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBooksBorrowed As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LmsDataSet As lmsDataSet
    Friend WithEvents BorrowerBindingSource As BindingSource
    Friend WithEvents BorrowerNameTextBox As TextBox
    Friend WithEvents ICNumTextBox As TextBox
    Friend WithEvents HPNumTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BorrowerIDTextBox As TextBox
    Friend WithEvents BorrowerDataGridView As DataGridView
    Friend WithEvents TitleListBox As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BorrowerTableAdapter As lmsDataSetTableAdapters.BorrowerTableAdapter
    Friend WithEvents TableAdapterManager As lmsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblNumBooks As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents lblPubYr As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents lblDateReturned As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblDateBorrowed As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPubName As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOverdueDays As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblLateRetFines As Label
    Friend WithEvents Label13 As Label
End Class
