<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuyerProfile
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtNRIC = New System.Windows.Forms.TextBox()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.txtGmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.OpenFileDialogProfilePhoto = New System.Windows.Forms.OpenFileDialog()
        Me.txtReEnterPassword = New System.Windows.Forms.TextBox()
        Me.lblReEnterPassword1 = New System.Windows.Forms.Label()
        Me.lblMatching = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblReEnterPassword2 = New System.Windows.Forms.Label()
        Me.pcbProfile = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Full Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NRIC "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contact No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 398)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Gmail"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(417, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 28)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtUsername.Enabled = False
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(28, 49)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(333, 40)
        Me.txtUsername.TabIndex = 8
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFullName.Enabled = False
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(27, 133)
        Me.txtFullName.Multiline = True
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(333, 73)
        Me.txtFullName.TabIndex = 9
        '
        'txtNRIC
        '
        Me.txtNRIC.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNRIC.Enabled = False
        Me.txtNRIC.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNRIC.Location = New System.Drawing.Point(26, 249)
        Me.txtNRIC.Name = "txtNRIC"
        Me.txtNRIC.Size = New System.Drawing.Size(267, 37)
        Me.txtNRIC.TabIndex = 10
        '
        'txtContactNo
        '
        Me.txtContactNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtContactNo.Enabled = False
        Me.txtContactNo.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(28, 334)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(265, 37)
        Me.txtContactNo.TabIndex = 11
        '
        'txtGmail
        '
        Me.txtGmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGmail.Enabled = False
        Me.txtGmail.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGmail.Location = New System.Drawing.Point(26, 429)
        Me.txtGmail.Name = "txtGmail"
        Me.txtGmail.Size = New System.Drawing.Size(334, 37)
        Me.txtGmail.TabIndex = 12
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPassword.Enabled = False
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(416, 334)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(321, 37)
        Me.txtPassword.TabIndex = 13
        '
        'OpenFileDialogProfilePhoto
        '
        Me.OpenFileDialogProfilePhoto.Filter = "(Image Files)|*.jpg;*.png;*"
        '
        'txtReEnterPassword
        '
        Me.txtReEnterPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtReEnterPassword.Enabled = False
        Me.txtReEnterPassword.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReEnterPassword.Location = New System.Drawing.Point(416, 429)
        Me.txtReEnterPassword.Name = "txtReEnterPassword"
        Me.txtReEnterPassword.Size = New System.Drawing.Size(321, 37)
        Me.txtReEnterPassword.TabIndex = 19
        Me.txtReEnterPassword.Visible = False
        '
        'lblReEnterPassword1
        '
        Me.lblReEnterPassword1.AutoSize = True
        Me.lblReEnterPassword1.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReEnterPassword1.Location = New System.Drawing.Point(411, 398)
        Me.lblReEnterPassword1.Name = "lblReEnterPassword1"
        Me.lblReEnterPassword1.Size = New System.Drawing.Size(189, 28)
        Me.lblReEnterPassword1.TabIndex = 18
        Me.lblReEnterPassword1.Text = "Re-Enter Password"
        Me.lblReEnterPassword1.Visible = False
        '
        'lblMatching
        '
        Me.lblMatching.AutoSize = True
        Me.lblMatching.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatching.ForeColor = System.Drawing.Color.Red
        Me.lblMatching.Location = New System.Drawing.Point(613, 403)
        Me.lblMatching.Name = "lblMatching"
        Me.lblMatching.Size = New System.Drawing.Size(121, 23)
        Me.lblMatching.TabIndex = 21
        Me.lblMatching.Text = "Not Matching"
        Me.lblMatching.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(511, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 239)
        Me.Label1.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(36, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(332, 34)
        Me.Label8.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(35, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(332, 65)
        Me.Label9.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(35, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(266, 30)
        Me.Label10.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(36, 347)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(265, 32)
        Me.Label11.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(36, 442)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(332, 32)
        Me.Label12.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(429, 347)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(316, 32)
        Me.Label13.TabIndex = 28
        '
        'lblReEnterPassword2
        '
        Me.lblReEnterPassword2.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblReEnterPassword2.Location = New System.Drawing.Point(429, 442)
        Me.lblReEnterPassword2.Name = "lblReEnterPassword2"
        Me.lblReEnterPassword2.Size = New System.Drawing.Size(316, 32)
        Me.lblReEnterPassword2.TabIndex = 29
        Me.lblReEnterPassword2.Visible = False
        '
        'pcbProfile
        '
        Me.pcbProfile.Enabled = False
        Me.pcbProfile.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.userDefaultImage
        Me.pcbProfile.Location = New System.Drawing.Point(485, 18)
        Me.pcbProfile.Name = "pcbProfile"
        Me.pcbProfile.Size = New System.Drawing.Size(260, 250)
        Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbProfile.TabIndex = 7
        Me.pcbProfile.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(749, 608)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 27)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Enabled = False
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_reset_40
        Me.btnReset.Location = New System.Drawing.Point(335, 512)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(199, 58)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_uninstalling_updates_40
        Me.btnUpdate.Location = New System.Drawing.Point(617, 512)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(200, 58)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_edit_40
        Me.btnEdit.Location = New System.Drawing.Point(48, 512)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(188, 58)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'frmBuyerProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pcbProfile)
        Me.Controls.Add(Me.lblMatching)
        Me.Controls.Add(Me.txtReEnterPassword)
        Me.Controls.Add(Me.lblReEnterPassword1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtGmail)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.txtNRIC)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblReEnterPassword2)
        Me.DoubleBuffered = True
        Me.Name = "frmBuyerProfile"
        Me.Size = New System.Drawing.Size(802, 435)
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pcbProfile As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtNRIC As TextBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents txtGmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents OpenFileDialogProfilePhoto As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtReEnterPassword As TextBox
    Friend WithEvents lblReEnterPassword1 As Label
    Friend WithEvents lblMatching As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblReEnterPassword2 As Label
End Class
