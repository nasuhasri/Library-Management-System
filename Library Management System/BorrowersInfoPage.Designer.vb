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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowersInfoPage))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim TitleLabel As System.Windows.Forms.Label
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BorrowerIDTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LmsDataSet = New Library_Management_System.lmsDataSet()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.HPNumTextBox = New System.Windows.Forms.TextBox()
        Me.ICNumTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerNameTextBox = New System.Windows.Forms.TextBox()
        Me.ListBooksBorrowed = New System.Windows.Forms.ListBox()
        Me.txtNoBooksBorrowed = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.loadData = New System.Windows.Forms.Button()
        Me.BorrowerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BorrowerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.BorrowerTableAdapter = New Library_Management_System.lmsDataSetTableAdapters.BorrowerTableAdapter()
        Me.TableAdapterManager = New Library_Management_System.lmsDataSetTableAdapters.TableAdapterManager()
        Me.BorrowerBorrowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BorrowTableAdapter = New Library_Management_System.lmsDataSetTableAdapters.BorrowTableAdapter()
        Me.BookTableAdapter = New Library_Management_System.lmsDataSetTableAdapters.BookTableAdapter()
        Me.BorrowerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookBorrowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitleListBox = New System.Windows.Forms.ListBox()
        Me.BookBorrowBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        BorrowerNameLabel = New System.Windows.Forms.Label()
        ICNumLabel = New System.Windows.Forms.Label()
        HPNumLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        BorrowerIDLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BorrowerBindingNavigator.SuspendLayout()
        CType(Me.BorrowerBorrowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBorrowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBorrowBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BorrowerNameLabel
        '
        BorrowerNameLabel.AutoSize = True
        BorrowerNameLabel.Location = New System.Drawing.Point(32, 115)
        BorrowerNameLabel.Name = "BorrowerNameLabel"
        BorrowerNameLabel.Size = New System.Drawing.Size(153, 25)
        BorrowerNameLabel.TabIndex = 11
        BorrowerNameLabel.Text = "Borrower Name:"
        '
        'ICNumLabel
        '
        ICNumLabel.AutoSize = True
        ICNumLabel.Location = New System.Drawing.Point(32, 151)
        ICNumLabel.Name = "ICNumLabel"
        ICNumLabel.Size = New System.Drawing.Size(112, 25)
        ICNumLabel.TabIndex = 12
        ICNumLabel.Text = "IC Number:"
        '
        'HPNumLabel
        '
        HPNumLabel.AutoSize = True
        HPNumLabel.Location = New System.Drawing.Point(32, 187)
        HPNumLabel.Name = "HPNumLabel"
        HPNumLabel.Size = New System.Drawing.Size(119, 25)
        HPNumLabel.TabIndex = 13
        HPNumLabel.Text = "HP Number:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(32, 228)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(91, 25)
        AddressLabel.TabIndex = 14
        AddressLabel.Text = "Address:"
        '
        'BorrowerIDLabel
        '
        BorrowerIDLabel.AutoSize = True
        BorrowerIDLabel.Location = New System.Drawing.Point(39, 65)
        BorrowerIDLabel.Name = "BorrowerIDLabel"
        BorrowerIDLabel.Size = New System.Drawing.Size(120, 25)
        BorrowerIDLabel.TabIndex = 15
        BorrowerIDLabel.Text = "Borrower ID:"
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(763, 781)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(94, 44)
        Me.btnReturn.TabIndex = 12
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(617, 781)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 44)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(763, 709)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(94, 44)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(617, 709)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 44)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(286, 709)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(94, 44)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(TitleLabel)
        Me.GroupBox1.Controls.Add(Me.TitleListBox)
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
        Me.GroupBox1.Controls.Add(Me.txtNoBooksBorrowed)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(51, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1042, 383)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrower's Details"
        '
        'BorrowerIDTextBox
        '
        Me.BorrowerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowerBindingSource, "BorrowerID", True))
        Me.BorrowerIDTextBox.Location = New System.Drawing.Point(204, 65)
        Me.BorrowerIDTextBox.Name = "BorrowerIDTextBox"
        Me.BorrowerIDTextBox.Size = New System.Drawing.Size(301, 30)
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
        Me.AddressTextBox.Location = New System.Drawing.Point(204, 228)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(301, 116)
        Me.AddressTextBox.TabIndex = 15
        '
        'HPNumTextBox
        '
        Me.HPNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowerBindingSource, "HPNum", True))
        Me.HPNumTextBox.Location = New System.Drawing.Point(204, 187)
        Me.HPNumTextBox.Name = "HPNumTextBox"
        Me.HPNumTextBox.Size = New System.Drawing.Size(301, 30)
        Me.HPNumTextBox.TabIndex = 14
        '
        'ICNumTextBox
        '
        Me.ICNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowerBindingSource, "ICNum", True))
        Me.ICNumTextBox.Location = New System.Drawing.Point(204, 151)
        Me.ICNumTextBox.Name = "ICNumTextBox"
        Me.ICNumTextBox.Size = New System.Drawing.Size(301, 30)
        Me.ICNumTextBox.TabIndex = 13
        '
        'BorrowerNameTextBox
        '
        Me.BorrowerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowerBindingSource, "BorrowerName", True))
        Me.BorrowerNameTextBox.Location = New System.Drawing.Point(204, 110)
        Me.BorrowerNameTextBox.Name = "BorrowerNameTextBox"
        Me.BorrowerNameTextBox.Size = New System.Drawing.Size(301, 30)
        Me.BorrowerNameTextBox.TabIndex = 12
        '
        'ListBooksBorrowed
        '
        Me.ListBooksBorrowed.FormattingEnabled = True
        Me.ListBooksBorrowed.ItemHeight = 25
        Me.ListBooksBorrowed.Location = New System.Drawing.Point(641, 82)
        Me.ListBooksBorrowed.Name = "ListBooksBorrowed"
        Me.ListBooksBorrowed.Size = New System.Drawing.Size(348, 204)
        Me.ListBooksBorrowed.TabIndex = 11
        '
        'txtNoBooksBorrowed
        '
        Me.txtNoBooksBorrowed.Location = New System.Drawing.Point(886, 329)
        Me.txtNoBooksBorrowed.Name = "txtNoBooksBorrowed"
        Me.txtNoBooksBorrowed.Size = New System.Drawing.Size(72, 30)
        Me.txtNoBooksBorrowed.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(636, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(268, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "List of Books Have Borrowed:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(646, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No of Books Borrowed:"
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "Book"
        Me.BookBindingSource.DataSource = Me.LmsDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(843, 518)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 17
        '
        'loadData
        '
        Me.loadData.Location = New System.Drawing.Point(843, 448)
        Me.loadData.Name = "loadData"
        Me.loadData.Size = New System.Drawing.Size(170, 56)
        Me.loadData.TabIndex = 16
        Me.loadData.Text = "Load Data"
        Me.loadData.UseVisualStyleBackColor = True
        '
        'BorrowerBindingNavigator
        '
        Me.BorrowerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BorrowerBindingNavigator.BindingSource = Me.BorrowerBindingSource
        Me.BorrowerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BorrowerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BorrowerBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BorrowerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BorrowerBindingNavigatorSaveItem})
        Me.BorrowerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BorrowerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BorrowerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BorrowerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BorrowerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BorrowerBindingNavigator.Name = "BorrowerBindingNavigator"
        Me.BorrowerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BorrowerBindingNavigator.Size = New System.Drawing.Size(1140, 27)
        Me.BorrowerBindingNavigator.TabIndex = 13
        Me.BorrowerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BorrowerBindingNavigatorSaveItem
        '
        Me.BorrowerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BorrowerBindingNavigatorSaveItem.Image = CType(resources.GetObject("BorrowerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BorrowerBindingNavigatorSaveItem.Name = "BorrowerBindingNavigatorSaveItem"
        Me.BorrowerBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.BorrowerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(50, 709)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(185, 44)
        Me.txtSearch.TabIndex = 14
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
        'BorrowerBorrowBindingSource
        '
        Me.BorrowerBorrowBindingSource.DataMember = "BorrowerBorrow"
        Me.BorrowerBorrowBindingSource.DataSource = Me.BorrowerBindingSource
        '
        'BorrowTableAdapter
        '
        Me.BorrowTableAdapter.ClearBeforeFill = True
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'BorrowerDataGridView
        '
        Me.BorrowerDataGridView.AllowUserToAddRows = False
        Me.BorrowerDataGridView.AllowUserToDeleteRows = False
        Me.BorrowerDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BorrowerDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.BorrowerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.BorrowerDataGridView.DataSource = Me.BorrowerBindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BorrowerDataGridView.DefaultCellStyle = DataGridViewCellStyle12
        Me.BorrowerDataGridView.Location = New System.Drawing.Point(51, 448)
        Me.BorrowerDataGridView.Name = "BorrowerDataGridView"
        Me.BorrowerDataGridView.ReadOnly = True
        Me.BorrowerDataGridView.RowTemplate.Height = 24
        Me.BorrowerDataGridView.Size = New System.Drawing.Size(753, 220)
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
        '
        'BookBorrowBindingSource
        '
        Me.BookBorrowBindingSource.DataMember = "BookBorrow"
        Me.BookBorrowBindingSource.DataSource = Me.BookBindingSource
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(417, 298)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(55, 25)
        TitleLabel.TabIndex = 16
        TitleLabel.Text = "Title:"
        '
        'TitleListBox
        '
        Me.TitleListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BookBindingSource, "Title", True))
        Me.TitleListBox.DataSource = Me.BookBindingSource1
        Me.TitleListBox.DisplayMember = "Title"
        Me.TitleListBox.FormattingEnabled = True
        Me.TitleListBox.ItemHeight = 25
        Me.TitleListBox.Location = New System.Drawing.Point(478, 298)
        Me.TitleListBox.Name = "TitleListBox"
        Me.TitleListBox.Size = New System.Drawing.Size(120, 79)
        Me.TitleListBox.TabIndex = 17
        Me.TitleListBox.ValueMember = "Title"
        '
        'BookBorrowBindingSource1
        '
        Me.BookBorrowBindingSource1.DataMember = "BookBorrow"
        Me.BookBorrowBindingSource1.DataSource = Me.BookBindingSource
        '
        'BookBindingSource1
        '
        Me.BookBindingSource1.DataMember = "Book"
        Me.BookBindingSource1.DataSource = Me.LmsDataSet
        '
        'BorrowersInfoPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 979)
        Me.Controls.Add(Me.BorrowerDataGridView)
        Me.Controls.Add(Me.loadData)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BorrowerBindingNavigator)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BorrowersInfoPage"
        Me.Text = "Borrowers Information Page"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BorrowerBindingNavigator.ResumeLayout(False)
        Me.BorrowerBindingNavigator.PerformLayout()
        CType(Me.BorrowerBorrowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBorrowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBorrowBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBooksBorrowed As ListBox
    Friend WithEvents txtNoBooksBorrowed As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LmsDataSet As lmsDataSet
    Friend WithEvents BorrowerBindingSource As BindingSource
    Friend WithEvents BorrowerTableAdapter As lmsDataSetTableAdapters.BorrowerTableAdapter
    Friend WithEvents TableAdapterManager As lmsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BorrowerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BorrowerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BorrowerNameTextBox As TextBox
    Friend WithEvents ICNumTextBox As TextBox
    Friend WithEvents HPNumTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BorrowerBorrowBindingSource As BindingSource
    Friend WithEvents BorrowTableAdapter As lmsDataSetTableAdapters.BorrowTableAdapter
    Friend WithEvents loadData As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BorrowerIDTextBox As TextBox
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As lmsDataSetTableAdapters.BookTableAdapter
    Friend WithEvents BorrowerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents BookBorrowBindingSource As BindingSource
    Friend WithEvents TitleListBox As ListBox
    Friend WithEvents BookBindingSource1 As BindingSource
    Friend WithEvents BookBorrowBindingSource1 As BindingSource
End Class
