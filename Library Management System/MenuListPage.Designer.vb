<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuListPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuListPage))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookIssuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LateReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(598, 324)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BorrowerToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookDetailsToolStripMenuItem, Me.BookIssuesToolStripMenuItem, Me.BookReturnToolStripMenuItem, Me.LateReturnToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BookDetailsToolStripMenuItem
        '
        Me.BookDetailsToolStripMenuItem.Name = "BookDetailsToolStripMenuItem"
        Me.BookDetailsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BookDetailsToolStripMenuItem.Text = "Book Details"
        '
        'BookIssuesToolStripMenuItem
        '
        Me.BookIssuesToolStripMenuItem.Name = "BookIssuesToolStripMenuItem"
        Me.BookIssuesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BookIssuesToolStripMenuItem.Text = "Book Issues"
        '
        'BookReturnToolStripMenuItem
        '
        Me.BookReturnToolStripMenuItem.Name = "BookReturnToolStripMenuItem"
        Me.BookReturnToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BookReturnToolStripMenuItem.Text = "Book Return"
        '
        'LateReturnToolStripMenuItem
        '
        Me.LateReturnToolStripMenuItem.Name = "LateReturnToolStripMenuItem"
        Me.LateReturnToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LateReturnToolStripMenuItem.Text = "Late Return "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BorrowerToolStripMenuItem
        '
        Me.BorrowerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowerDetailsToolStripMenuItem})
        Me.BorrowerToolStripMenuItem.Name = "BorrowerToolStripMenuItem"
        Me.BorrowerToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.BorrowerToolStripMenuItem.Text = "Borrower"
        '
        'BorrowerDetailsToolStripMenuItem
        '
        Me.BorrowerDetailsToolStripMenuItem.Name = "BorrowerDetailsToolStripMenuItem"
        Me.BorrowerDetailsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BorrowerDetailsToolStripMenuItem.Text = "Borrower Details"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserDetailsToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.UserToolStripMenuItem.Text = "User "
        '
        'UserDetailsToolStripMenuItem
        '
        Me.UserDetailsToolStripMenuItem.Name = "UserDetailsToolStripMenuItem"
        Me.UserDetailsToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.UserDetailsToolStripMenuItem.Text = "User Details"
        '
        'MenuListPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 349)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MenuListPage"
        Me.Text = "Menu Lists Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookIssuesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LateReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowerDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserDetailsToolStripMenuItem As ToolStripMenuItem
End Class
