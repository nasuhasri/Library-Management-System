<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationPage
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
        Me.components = New System.ComponentModel.Container()
        Dim StaffIDLabel1 As System.Windows.Forms.Label
        Dim StaffNameLabel As System.Windows.Forms.Label
        Dim HPNumLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationPage))
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.UserBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LmsDataSet = New Library_Management_System.lmsDataSet()
        Me.UserBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New Library_Management_System.lmsDataSetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New Library_Management_System.lmsDataSetTableAdapters.TableAdapterManager()
        Me.StaffIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.StaffNameTextBox = New System.Windows.Forms.TextBox()
        Me.HPNumTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserDataGridView = New System.Windows.Forms.DataGridView()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HPNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        StaffIDLabel1 = New System.Windows.Forms.Label()
        StaffNameLabel = New System.Windows.Forms.Label()
        HPNumLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserBindingNavigator.SuspendLayout()
        CType(Me.LmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffIDLabel1
        '
        StaffIDLabel1.AutoSize = True
        StaffIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StaffIDLabel1.Location = New System.Drawing.Point(180, 93)
        StaffIDLabel1.Name = "StaffIDLabel1"
        StaffIDLabel1.Size = New System.Drawing.Size(62, 16)
        StaffIDLabel1.TabIndex = 42
        StaffIDLabel1.Text = "Staff ID:"
        '
        'StaffNameLabel
        '
        StaffNameLabel.AutoSize = True
        StaffNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StaffNameLabel.Location = New System.Drawing.Point(180, 51)
        StaffNameLabel.Name = "StaffNameLabel"
        StaffNameLabel.Size = New System.Drawing.Size(88, 16)
        StaffNameLabel.TabIndex = 43
        StaffNameLabel.Text = "Staff Name:"
        '
        'HPNumLabel
        '
        HPNumLabel.AutoSize = True
        HPNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HPNumLabel.Location = New System.Drawing.Point(180, 154)
        HPNumLabel.Name = "HPNumLabel"
        HPNumLabel.Size = New System.Drawing.Size(64, 16)
        HPNumLabel.TabIndex = 44
        HPNumLabel.Text = "HPNum:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(180, 202)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(83, 16)
        UsernameLabel.TabIndex = 45
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(180, 268)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(80, 16)
        PasswordLabel.TabIndex = 46
        PasswordLabel.Text = "Password:"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.DarkCyan
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRegister.Location = New System.Drawing.Point(330, 339)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(93, 34)
        Me.btnRegister.TabIndex = 41
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.DarkCyan
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReturn.Location = New System.Drawing.Point(147, 339)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(93, 34)
        Me.btnReturn.TabIndex = 40
        Me.btnReturn.Text = "RETURN"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'UserBindingNavigatorSaveItem
        '
        Me.UserBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserBindingNavigatorSaveItem.Name = "UserBindingNavigatorSaveItem"
        Me.UserBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UserBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'UserBindingNavigator
        '
        Me.UserBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserBindingNavigator.BindingSource = Me.UserBindingSource
        Me.UserBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserBindingNavigatorSaveItem})
        Me.UserBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserBindingNavigator.Name = "UserBindingNavigator"
        Me.UserBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserBindingNavigator.Size = New System.Drawing.Size(773, 25)
        Me.UserBindingNavigator.TabIndex = 29
        Me.UserBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSubmit.Location = New System.Drawing.Point(508, 339)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(93, 34)
        Me.btnSubmit.TabIndex = 28
        Me.btnSubmit.Text = "SAVE"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(285, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "* exp: ROB200001"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(285, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "* consist of number and letter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(285, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "* 8-12 lengths"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "* consist of number and letter"
        '
        'LmsDataSet
        '
        Me.LmsDataSet.DataSetName = "lmsDataSet"
        Me.LmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserBindingSource1
        '
        Me.UserBindingSource1.DataMember = "User"
        Me.UserBindingSource1.DataSource = Me.LmsDataSet
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.BorrowerTableAdapter = Nothing
        Me.TableAdapterManager.BorrowTableAdapter = Nothing
        Me.TableAdapterManager.Late_Return_FinesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Library_Management_System.lmsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Me.UserTableAdapter
        '
        'StaffIDTextBox1
        '
        Me.StaffIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource1, "StaffID", True))
        Me.StaffIDTextBox1.Location = New System.Drawing.Point(288, 90)
        Me.StaffIDTextBox1.Name = "StaffIDTextBox1"
        Me.StaffIDTextBox1.Size = New System.Drawing.Size(304, 20)
        Me.StaffIDTextBox1.TabIndex = 43
        '
        'StaffNameTextBox
        '
        Me.StaffNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource1, "StaffName", True))
        Me.StaffNameTextBox.Location = New System.Drawing.Point(288, 48)
        Me.StaffNameTextBox.Name = "StaffNameTextBox"
        Me.StaffNameTextBox.Size = New System.Drawing.Size(304, 20)
        Me.StaffNameTextBox.TabIndex = 44
        '
        'HPNumTextBox
        '
        Me.HPNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource1, "HPNum", True))
        Me.HPNumTextBox.Location = New System.Drawing.Point(288, 151)
        Me.HPNumTextBox.Name = "HPNumTextBox"
        Me.HPNumTextBox.Size = New System.Drawing.Size(304, 20)
        Me.HPNumTextBox.TabIndex = 45
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource1, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(288, 199)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(304, 20)
        Me.UsernameTextBox.TabIndex = 46
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource1, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(288, 265)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(304, 20)
        Me.PasswordTextBox.TabIndex = 47
        '
        'UserDataGridView
        '
        Me.UserDataGridView.AllowUserToAddRows = False
        Me.UserDataGridView.AllowUserToDeleteRows = False
        Me.UserDataGridView.AutoGenerateColumns = False
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.StaffNameDataGridViewTextBoxColumn, Me.HPNumDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.UserDataGridView.DataSource = Me.UserBindingSource1
        Me.UserDataGridView.Location = New System.Drawing.Point(115, 404)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.ReadOnly = True
        Me.UserDataGridView.Size = New System.Drawing.Size(542, 239)
        Me.UserDataGridView.TabIndex = 47
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StaffNameDataGridViewTextBoxColumn
        '
        Me.StaffNameDataGridViewTextBoxColumn.DataPropertyName = "StaffName"
        Me.StaffNameDataGridViewTextBoxColumn.HeaderText = "StaffName"
        Me.StaffNameDataGridViewTextBoxColumn.Name = "StaffNameDataGridViewTextBoxColumn"
        Me.StaffNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HPNumDataGridViewTextBoxColumn
        '
        Me.HPNumDataGridViewTextBoxColumn.DataPropertyName = "HPNum"
        Me.HPNumDataGridViewTextBoxColumn.HeaderText = "HPNum"
        Me.HPNumDataGridViewTextBoxColumn.Name = "HPNumDataGridViewTextBoxColumn"
        Me.HPNumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RegistrationPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 687)
        Me.Controls.Add(Me.UserDataGridView)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(HPNumLabel)
        Me.Controls.Add(Me.HPNumTextBox)
        Me.Controls.Add(StaffNameLabel)
        Me.Controls.Add(Me.StaffNameTextBox)
        Me.Controls.Add(StaffIDLabel1)
        Me.Controls.Add(Me.StaffIDTextBox1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.UserBindingNavigator)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistrationPage"
        Me.Text = "RegistrationPage"
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserBindingNavigator.ResumeLayout(False)
        Me.UserBindingNavigator.PerformLayout()
        CType(Me.LmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents UserBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents UserBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LmsDataSet As lmsDataSet
    Friend WithEvents UserBindingSource1 As BindingSource
    Friend WithEvents UserTableAdapter As lmsDataSetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As lmsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffIDTextBox1 As TextBox
    Friend WithEvents StaffNameTextBox As TextBox
    Friend WithEvents HPNumTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UserDataGridView As DataGridView
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HPNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
