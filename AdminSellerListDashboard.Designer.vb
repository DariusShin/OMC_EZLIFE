<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminSellerListDashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminSellerListDashboard))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboBusinessType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusinessOwner = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUploadLogo = New System.Windows.Forms.Button()
        Me.pcbBusinessLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.DGVSeller = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGmail = New System.Windows.Forms.TextBox()
        Me.txtBusinessName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialogBusinessLogo = New System.Windows.Forms.OpenFileDialog()
        Me.txtNRIC = New System.Windows.Forms.MaskedTextBox()
        Me.txtContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbBusinessLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVSeller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtContactNo)
        Me.Panel2.Controls.Add(Me.txtNRIC)
        Me.Panel2.Controls.Add(Me.cboBusinessType)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtBusinessOwner)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnUploadLogo)
        Me.Panel2.Controls.Add(Me.pcbBusinessLogo)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.DGVSeller)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtGmail)
        Me.Panel2.Controls.Add(Me.txtBusinessName)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 700)
        Me.Panel2.TabIndex = 2
        '
        'cboBusinessType
        '
        Me.cboBusinessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBusinessType.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBusinessType.FormattingEnabled = True
        Me.cboBusinessType.Items.AddRange(New Object() {"Car Pool", "Food Order", "Car Rental", "Parcel Collect"})
        Me.cboBusinessType.Location = New System.Drawing.Point(188, 502)
        Me.cboBusinessType.Name = "cboBusinessType"
        Me.cboBusinessType.Size = New System.Drawing.Size(354, 31)
        Me.cboBusinessType.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 502)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 25)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Business Type :"
        '
        'txtBusinessOwner
        '
        Me.txtBusinessOwner.BackColor = System.Drawing.Color.White
        Me.txtBusinessOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusinessOwner.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusinessOwner.Location = New System.Drawing.Point(188, 553)
        Me.txtBusinessOwner.Name = "txtBusinessOwner"
        Me.txtBusinessOwner.ReadOnly = True
        Me.txtBusinessOwner.Size = New System.Drawing.Size(354, 31)
        Me.txtBusinessOwner.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 553)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Business Owner :"
        '
        'btnUploadLogo
        '
        Me.btnUploadLogo.BackColor = System.Drawing.Color.White
        Me.btnUploadLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadLogo.FlatAppearance.BorderSize = 0
        Me.btnUploadLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadLogo.Image = CType(resources.GetObject("btnUploadLogo.Image"), System.Drawing.Image)
        Me.btnUploadLogo.Location = New System.Drawing.Point(853, 483)
        Me.btnUploadLogo.Name = "btnUploadLogo"
        Me.btnUploadLogo.Size = New System.Drawing.Size(47, 50)
        Me.btnUploadLogo.TabIndex = 8
        Me.btnUploadLogo.UseVisualStyleBackColor = False
        '
        'pcbBusinessLogo
        '
        Me.pcbBusinessLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbBusinessLogo.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_conference_50
        Me.pcbBusinessLogo.Location = New System.Drawing.Point(664, 363)
        Me.pcbBusinessLogo.Name = "pcbBusinessLogo"
        Me.pcbBusinessLogo.Size = New System.Drawing.Size(174, 170)
        Me.pcbBusinessLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBusinessLogo.TabIndex = 75
        Me.pcbBusinessLogo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(879, 757)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 70)
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnAddNew)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Location = New System.Drawing.Point(617, 553)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 181)
        Me.Panel1.TabIndex = 73
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(20, 15)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(254, 44)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(20, 124)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 44)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(20, 65)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(118, 44)
        Me.btnAddNew.TabIndex = 1
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(153, 124)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 44)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(153, 65)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(118, 44)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'DGVSeller
        '
        Me.DGVSeller.AllowUserToAddRows = False
        Me.DGVSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSeller.Location = New System.Drawing.Point(30, 19)
        Me.DGVSeller.Name = "DGVSeller"
        Me.DGVSeller.RowHeadersWidth = 51
        Me.DGVSeller.RowTemplate.Height = 24
        Me.DGVSeller.Size = New System.Drawing.Size(932, 320)
        Me.DGVSeller.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(54, 658)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 25)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Contact No :"
        '
        'txtGmail
        '
        Me.txtGmail.BackColor = System.Drawing.Color.White
        Me.txtGmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGmail.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGmail.Location = New System.Drawing.Point(188, 707)
        Me.txtGmail.Name = "txtGmail"
        Me.txtGmail.ReadOnly = True
        Me.txtGmail.Size = New System.Drawing.Size(354, 31)
        Me.txtGmail.TabIndex = 6
        '
        'txtBusinessName
        '
        Me.txtBusinessName.BackColor = System.Drawing.Color.White
        Me.txtBusinessName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusinessName.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusinessName.Location = New System.Drawing.Point(188, 405)
        Me.txtBusinessName.Multiline = True
        Me.txtBusinessName.Name = "txtBusinessName"
        Me.txtBusinessName.ReadOnly = True
        Me.txtBusinessName.Size = New System.Drawing.Size(354, 82)
        Me.txtBusinessName.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(188, 357)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(354, 31)
        Me.txtUsername.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(69, 763)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 25)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 419)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 50)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Business " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(100, 709)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 25)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Gmail :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(107, 604)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 25)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "NRIC :"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(188, 757)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(354, 31)
        Me.txtPassword.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Username :"
        '
        'OpenFileDialogBusinessLogo
        '
        Me.OpenFileDialogBusinessLogo.FileName = "OpenFileDialog1"
        '
        'txtNRIC
        '
        Me.txtNRIC.BackColor = System.Drawing.Color.White
        Me.txtNRIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNRIC.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNRIC.Location = New System.Drawing.Point(188, 602)
        Me.txtNRIC.Mask = "000000000000"
        Me.txtNRIC.Name = "txtNRIC"
        Me.txtNRIC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNRIC.ReadOnly = True
        Me.txtNRIC.Size = New System.Drawing.Size(354, 31)
        Me.txtNRIC.TabIndex = 4
        '
        'txtContactNo
        '
        Me.txtContactNo.BackColor = System.Drawing.Color.White
        Me.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNo.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(188, 656)
        Me.txtContactNo.Mask = "900-000 0000"
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtContactNo.ReadOnly = True
        Me.txtContactNo.Size = New System.Drawing.Size(354, 31)
        Me.txtContactNo.TabIndex = 5
        '
        'frmAdminSellerListDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmAdminSellerListDashboard"
        Me.Size = New System.Drawing.Size(1000, 700)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcbBusinessLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVSeller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnUploadLogo As Button
    Friend WithEvents pcbBusinessLogo As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DGVSeller As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtGmail As TextBox
    Friend WithEvents txtBusinessName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBusinessOwner As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboBusinessType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialogBusinessLogo As OpenFileDialog
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtNRIC As MaskedTextBox
    Friend WithEvents txtContactNo As MaskedTextBox
End Class
