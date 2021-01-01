<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowersInfoPage
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBooksBorrowed = New System.Windows.Forms.ListBox()
        Me.txtNoBooksBorrowed = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.txtBorrowersIC = New System.Windows.Forms.TextBox()
        Me.txtBorrowersName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(780, 525)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(94, 44)
        Me.btnReturn.TabIndex = 12
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(615, 525)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 44)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(460, 525)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(94, 44)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(303, 525)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 44)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(152, 525)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(94, 44)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBooksBorrowed)
        Me.GroupBox1.Controls.Add(Me.txtNoBooksBorrowed)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNum)
        Me.GroupBox1.Controls.Add(Me.txtBorrowersIC)
        Me.GroupBox1.Controls.Add(Me.txtBorrowersName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(44, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1042, 455)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrower's Details"
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
        Me.txtNoBooksBorrowed.Location = New System.Drawing.Point(298, 263)
        Me.txtNoBooksBorrowed.Name = "txtNoBooksBorrowed"
        Me.txtNoBooksBorrowed.Size = New System.Drawing.Size(270, 30)
        Me.txtNoBooksBorrowed.TabIndex = 10
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(298, 169)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(270, 77)
        Me.txtAddress.TabIndex = 9
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(298, 125)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(270, 30)
        Me.txtPhoneNum.TabIndex = 8
        '
        'txtBorrowersIC
        '
        Me.txtBorrowersIC.Location = New System.Drawing.Point(298, 82)
        Me.txtBorrowersIC.Name = "txtBorrowersIC"
        Me.txtBorrowersIC.Size = New System.Drawing.Size(270, 30)
        Me.txtBorrowersIC.TabIndex = 7
        '
        'txtBorrowersName
        '
        Me.txtBorrowersName.Location = New System.Drawing.Point(298, 41)
        Me.txtBorrowersName.Name = "txtBorrowersName"
        Me.txtBorrowersName.Size = New System.Drawing.Size(270, 30)
        Me.txtBorrowersName.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(636, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(262, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "List of Books Have Borrowed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No of Books Borrowed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Borrower's IC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Borrower's Name"
        '
        'BorrowersInfoPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 639)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBooksBorrowed As ListBox
    Friend WithEvents txtNoBooksBorrowed As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtBorrowersIC As TextBox
    Friend WithEvents txtBorrowersName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
