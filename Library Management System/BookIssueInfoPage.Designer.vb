﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookIssueInfoPage
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
        Dim BorrowerIDLabel As System.Windows.Forms.Label
        Dim BorrowerNameLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookIssueInfoPage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnIssueBook = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BorrowerNameTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LmsDataSet = New Library_Management_System.lmsDataSet()
        Me.BorrowerIDTextBox = New System.Windows.Forms.TextBox()
        Me.DTPDueDate = New System.Windows.Forms.DateTimePicker()
        Me.DTPIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.BorrowerBorrowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSearchName = New System.Windows.Forms.TextBox()
        Me.btnSearchName = New System.Windows.Forms.Button()
        Me.BorrowerTableAdapter = New Library_Management_System.lmsDataSetTableAdapters.BorrowerTableAdapter()
        Me.BorrowTableAdapter = New Library_Management_System.lmsDataSetTableAdapters.BorrowTableAdapter()
        Me.TableAdapterManager = New Library_Management_System.lmsDataSetTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        BorrowerIDLabel = New System.Windows.Forms.Label()
        BorrowerNameLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerBorrowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BorrowerIDLabel
        '
        BorrowerIDLabel.AutoSize = True
        BorrowerIDLabel.Location = New System.Drawing.Point(16, 55)
        BorrowerIDLabel.Name = "BorrowerIDLabel"
        BorrowerIDLabel.Size = New System.Drawing.Size(120, 25)
        BorrowerIDLabel.TabIndex = 15
        BorrowerIDLabel.Text = "Borrower ID:"
        '
        'BorrowerNameLabel
        '
        BorrowerNameLabel.AutoSize = True
        BorrowerNameLabel.Location = New System.Drawing.Point(18, 101)
        BorrowerNameLabel.Name = "BorrowerNameLabel"
        BorrowerNameLabel.Size = New System.Drawing.Size(153, 25)
        BorrowerNameLabel.TabIndex = 16
        BorrowerNameLabel.Text = "Borrower Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(553, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Issue Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(553, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Due Date"
        '
        'btnIssueBook
        '
        Me.btnIssueBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueBook.Location = New System.Drawing.Point(65, 731)
        Me.btnIssueBook.Name = "btnIssueBook"
        Me.btnIssueBook.Size = New System.Drawing.Size(171, 57)
        Me.btnIssueBook.TabIndex = 5
        Me.btnIssueBook.Text = "Issue Book"
        Me.btnIssueBook.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(281, 722)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(171, 57)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblISBN
        '
        Me.lblISBN.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblISBN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN.Location = New System.Drawing.Point(225, 31)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(247, 32)
        Me.lblISBN.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.lblBookTitle)
        Me.GroupBox1.Controls.Add(Me.lblISBN)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(56, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(974, 126)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Details"
        '
        'lblBookTitle
        '
        Me.lblBookTitle.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBookTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitle.Location = New System.Drawing.Point(225, 75)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(247, 32)
        Me.lblBookTitle.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.lblSearchBy)
        Me.GroupBox2.Controls.Add(Me.cmbSearch)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(56, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(974, 100)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(741, 29)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(171, 57)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(474, 44)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(209, 30)
        Me.txtSearch.TabIndex = 12
        '
        'lblSearchBy
        '
        Me.lblSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBy.Location = New System.Drawing.Point(343, 49)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(103, 25)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Search By"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(BorrowerNameLabel)
        Me.GroupBox3.Controls.Add(Me.BorrowerNameTextBox)
        Me.GroupBox3.Controls.Add(BorrowerIDLabel)
        Me.GroupBox3.Controls.Add(Me.BorrowerIDTextBox)
        Me.GroupBox3.Controls.Add(Me.DTPDueDate)
        Me.GroupBox3.Controls.Add(Me.DTPIssueDate)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(56, 301)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(974, 172)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Borrower's Details"
        '
        'BorrowerNameTextBox
        '
        Me.BorrowerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowerBindingSource, "BorrowerName", True))
        Me.BorrowerNameTextBox.Location = New System.Drawing.Point(199, 98)
        Me.BorrowerNameTextBox.Name = "BorrowerNameTextBox"
        Me.BorrowerNameTextBox.Size = New System.Drawing.Size(170, 30)
        Me.BorrowerNameTextBox.TabIndex = 17
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
        'BorrowerIDTextBox
        '
        Me.BorrowerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowerBindingSource, "BorrowerID", True))
        Me.BorrowerIDTextBox.Location = New System.Drawing.Point(199, 52)
        Me.BorrowerIDTextBox.Name = "BorrowerIDTextBox"
        Me.BorrowerIDTextBox.Size = New System.Drawing.Size(170, 30)
        Me.BorrowerIDTextBox.TabIndex = 16
        '
        'DTPDueDate
        '
        Me.DTPDueDate.Location = New System.Drawing.Point(676, 110)
        Me.DTPDueDate.Name = "DTPDueDate"
        Me.DTPDueDate.Size = New System.Drawing.Size(275, 30)
        Me.DTPDueDate.TabIndex = 15
        '
        'DTPIssueDate
        '
        Me.DTPIssueDate.Location = New System.Drawing.Point(676, 53)
        Me.DTPIssueDate.Name = "DTPIssueDate"
        Me.DTPIssueDate.Size = New System.Drawing.Size(275, 30)
        Me.DTPIssueDate.TabIndex = 14
        '
        'BorrowerBorrowBindingSource
        '
        Me.BorrowerBorrowBindingSource.DataMember = "BorrowerBorrow"
        Me.BorrowerBorrowBindingSource.DataSource = Me.BorrowerBindingSource
        '
        'txtSearchName
        '
        Me.txtSearchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchName.Location = New System.Drawing.Point(550, 737)
        Me.txtSearchName.Multiline = True
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(185, 44)
        Me.txtSearchName.TabIndex = 16
        '
        'btnSearchName
        '
        Me.btnSearchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchName.Location = New System.Drawing.Point(786, 737)
        Me.btnSearchName.Name = "btnSearchName"
        Me.btnSearchName.Size = New System.Drawing.Size(144, 44)
        Me.btnSearchName.TabIndex = 15
        Me.btnSearchName.Text = "Search Name"
        Me.btnSearchName.UseVisualStyleBackColor = True
        '
        'BorrowerTableAdapter
        '
        Me.BorrowerTableAdapter.ClearBeforeFill = True
        '
        'BorrowTableAdapter
        '
        Me.BorrowTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.BorrowerTableAdapter = Me.BorrowerTableAdapter
        Me.TableAdapterManager.BorrowTableAdapter = Me.BorrowTableAdapter
        Me.TableAdapterManager.Late_Return_FinesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Library_Management_System.lmsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.DataGridView1.DataSource = Me.BorrowerBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(80, 479)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(753, 220)
        Me.DataGridView1.TabIndex = 18
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "BorrowerID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Borrower ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "BorrowerName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Borrower Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ICNum"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IC Number"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 120
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "HPNum"
        Me.DataGridViewTextBoxColumn9.HeaderText = "HP Number"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 120
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'BookIssueInfoPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1179, 834)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtSearchName)
        Me.Controls.Add(Me.btnSearchName)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnIssueBook)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "BookIssueInfoPage"
        Me.Text = "Book Issue Information Page"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerBorrowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnIssueBook As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblISBN As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblBookTitle As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSearchBy As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DTPIssueDate As DateTimePicker
    Friend WithEvents DTPDueDate As DateTimePicker
    Friend WithEvents LmsDataSet As lmsDataSet
    Friend WithEvents BorrowerBindingSource As BindingSource
    Friend WithEvents BorrowerTableAdapter As lmsDataSetTableAdapters.BorrowerTableAdapter
    Friend WithEvents BorrowerBorrowBindingSource As BindingSource
    Friend WithEvents BorrowTableAdapter As lmsDataSetTableAdapters.BorrowTableAdapter
    Friend WithEvents TableAdapterManager As lmsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BorrowerNameTextBox As TextBox
    Friend WithEvents BorrowerIDTextBox As TextBox
    Friend WithEvents txtSearchName As TextBox
    Friend WithEvents btnSearchName As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
