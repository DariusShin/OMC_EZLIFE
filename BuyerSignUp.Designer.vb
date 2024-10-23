<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuyerSignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuyerSignUp))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBackSignUp = New System.Windows.Forms.Button()
        Me.ButtonSetControl1 = New OMC_EZLIFE_May2023.ButtonSetControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtGmail = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialogProfile = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtReEnterPassword = New System.Windows.Forms.TextBox()
        Me.lblReEnterPassword1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblReEnterPassword2 = New System.Windows.Forms.Label()
        Me.lblMatching = New System.Windows.Forms.Label()
        Me.btnUploadProfile = New System.Windows.Forms.Button()
        Me.pcbHashPassword = New System.Windows.Forms.PictureBox()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pcbProfilePhoto = New System.Windows.Forms.PictureBox()
        Me.mtxtContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblNRIC = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.lblGmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtNRIC = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbHashPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProfilePhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnBackSignUp)
        Me.Panel1.Controls.Add(Me.ButtonSetControl1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 45)
        Me.Panel1.TabIndex = 2
        '
        'btnBackSignUp
        '
        Me.btnBackSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackSignUp.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBackSignUp.FlatAppearance.BorderSize = 0
        Me.btnBackSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackSignUp.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_u_turn_to_left_40__1_
        Me.btnBackSignUp.Location = New System.Drawing.Point(0, 0)
        Me.btnBackSignUp.Name = "btnBackSignUp"
        Me.btnBackSignUp.Size = New System.Drawing.Size(76, 45)
        Me.btnBackSignUp.TabIndex = 5
        Me.btnBackSignUp.UseVisualStyleBackColor = True
        '
        'ButtonSetControl1
        '
        Me.ButtonSetControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonSetControl1.Location = New System.Drawing.Point(714, 0)
        Me.ButtonSetControl1.Name = "ButtonSetControl1"
        Me.ButtonSetControl1.Size = New System.Drawing.Size(86, 45)
        Me.ButtonSetControl1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(215, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Service Buyer Sign Up"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(296, 564)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(358, 34)
        Me.txtPassword.TabIndex = 5
        '
        'txtGmail
        '
        Me.txtGmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtGmail.Location = New System.Drawing.Point(296, 513)
        Me.txtGmail.Name = "txtGmail"
        Me.txtGmail.Size = New System.Drawing.Size(354, 34)
        Me.txtGmail.TabIndex = 4
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtFullName.Location = New System.Drawing.Point(296, 309)
        Me.txtFullName.Multiline = True
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(354, 82)
        Me.txtFullName.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUsername.Location = New System.Drawing.Point(296, 262)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(354, 34)
        Me.txtUsername.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(120, 563)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 31)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Password :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(157, 513)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 31)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Gmail :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(97, 462)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 31)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Contact No :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(162, 408)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 31)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "NRIC :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 31)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Full Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(111, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 31)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Username :"
        '
        'OpenFileDialogProfile
        '
        Me.OpenFileDialogProfile.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(156, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 62)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Profile " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Photo"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(304, 272)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(350, 28)
        Me.Label11.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(304, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(350, 67)
        Me.Label5.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(305, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 143)
        Me.Label6.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(300, 420)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(354, 27)
        Me.Label12.TabIndex = 49
        '
        'txtReEnterPassword
        '
        Me.txtReEnterPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtReEnterPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtReEnterPassword.Location = New System.Drawing.Point(296, 616)
        Me.txtReEnterPassword.Name = "txtReEnterPassword"
        Me.txtReEnterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtReEnterPassword.Size = New System.Drawing.Size(358, 34)
        Me.txtReEnterPassword.TabIndex = 6
        Me.txtReEnterPassword.Visible = False
        '
        'lblReEnterPassword1
        '
        Me.lblReEnterPassword1.AutoSize = True
        Me.lblReEnterPassword1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReEnterPassword1.Location = New System.Drawing.Point(26, 615)
        Me.lblReEnterPassword1.Name = "lblReEnterPassword1"
        Me.lblReEnterPassword1.Size = New System.Drawing.Size(218, 31)
        Me.lblReEnterPassword1.TabIndex = 50
        Me.lblReEnterPassword1.Text = "Re-Enter Password :"
        Me.lblReEnterPassword1.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(300, 475)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(354, 26)
        Me.Label13.TabIndex = 52
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(300, 521)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(354, 32)
        Me.Label14.TabIndex = 53
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(304, 577)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(354, 26)
        Me.Label15.TabIndex = 54
        '
        'lblReEnterPassword2
        '
        Me.lblReEnterPassword2.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblReEnterPassword2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblReEnterPassword2.Location = New System.Drawing.Point(304, 629)
        Me.lblReEnterPassword2.Name = "lblReEnterPassword2"
        Me.lblReEnterPassword2.Size = New System.Drawing.Size(354, 26)
        Me.lblReEnterPassword2.TabIndex = 55
        Me.lblReEnterPassword2.Visible = False
        '
        'lblMatching
        '
        Me.lblMatching.AutoSize = True
        Me.lblMatching.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatching.ForeColor = System.Drawing.Color.Red
        Me.lblMatching.Location = New System.Drawing.Point(669, 626)
        Me.lblMatching.Name = "lblMatching"
        Me.lblMatching.Size = New System.Drawing.Size(121, 23)
        Me.lblMatching.TabIndex = 56
        Me.lblMatching.Text = "Not Matching"
        Me.lblMatching.Visible = False
        '
        'btnUploadProfile
        '
        Me.btnUploadProfile.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUploadProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadProfile.FlatAppearance.BorderSize = 0
        Me.btnUploadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadProfile.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_uninstalling_updates_40
        Me.btnUploadProfile.Location = New System.Drawing.Point(487, 193)
        Me.btnUploadProfile.Name = "btnUploadProfile"
        Me.btnUploadProfile.Size = New System.Drawing.Size(50, 50)
        Me.btnUploadProfile.TabIndex = 44
        Me.btnUploadProfile.UseVisualStyleBackColor = False
        '
        'pcbHashPassword
        '
        Me.pcbHashPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbHashPassword.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_blind_32
        Me.pcbHashPassword.Location = New System.Drawing.Point(664, 566)
        Me.pcbHashPassword.Name = "pcbHashPassword"
        Me.pcbHashPassword.Size = New System.Drawing.Size(44, 37)
        Me.pcbHashPassword.TabIndex = 43
        Me.pcbHashPassword.TabStop = False
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignUp.FlatAppearance.BorderSize = 0
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_register_32
        Me.btnSignUp.Location = New System.Drawing.Point(445, 672)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(165, 53)
        Me.btnSignUp.TabIndex = 7
        Me.btnSignUp.Text = "SIGN UP"
        Me.btnSignUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSalmon
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_reset_32
        Me.btnClear.Location = New System.Drawing.Point(161, 672)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 53)
        Me.btnClear.TabIndex = 33
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'pcbProfilePhoto
        '
        Me.pcbProfilePhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pcbProfilePhoto.Enabled = False
        Me.pcbProfilePhoto.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.userDefaultImage
        Me.pcbProfilePhoto.Location = New System.Drawing.Point(296, 71)
        Me.pcbProfilePhoto.Name = "pcbProfilePhoto"
        Me.pcbProfilePhoto.Size = New System.Drawing.Size(179, 172)
        Me.pcbProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbProfilePhoto.TabIndex = 32
        Me.pcbProfilePhoto.TabStop = False
        '
        'mtxtContactNo
        '
        Me.mtxtContactNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mtxtContactNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtContactNo.Location = New System.Drawing.Point(296, 462)
        Me.mtxtContactNo.Mask = "000-000 0000"
        Me.mtxtContactNo.Name = "mtxtContactNo"
        Me.mtxtContactNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtxtContactNo.Size = New System.Drawing.Size(354, 34)
        Me.mtxtContactNo.TabIndex = 3
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Red
        Me.lblUsername.Location = New System.Drawing.Point(660, 264)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(67, 23)
        Me.lblUsername.TabIndex = 58
        Me.lblUsername.Text = "*Invalid"
        Me.lblUsername.Visible = False
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.Red
        Me.lblFullName.Location = New System.Drawing.Point(660, 341)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(67, 23)
        Me.lblFullName.TabIndex = 59
        Me.lblFullName.Text = "*Invalid"
        Me.lblFullName.Visible = False
        '
        'lblNRIC
        '
        Me.lblNRIC.AutoSize = True
        Me.lblNRIC.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNRIC.ForeColor = System.Drawing.Color.Red
        Me.lblNRIC.Location = New System.Drawing.Point(660, 416)
        Me.lblNRIC.Name = "lblNRIC"
        Me.lblNRIC.Size = New System.Drawing.Size(67, 23)
        Me.lblNRIC.TabIndex = 60
        Me.lblNRIC.Text = "*Invalid"
        Me.lblNRIC.Visible = False
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.ForeColor = System.Drawing.Color.Red
        Me.lblContactNo.Location = New System.Drawing.Point(660, 471)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(67, 23)
        Me.lblContactNo.TabIndex = 61
        Me.lblContactNo.Text = "*Invalid"
        Me.lblContactNo.Visible = False
        '
        'lblGmail
        '
        Me.lblGmail.AutoSize = True
        Me.lblGmail.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGmail.ForeColor = System.Drawing.Color.Red
        Me.lblGmail.Location = New System.Drawing.Point(660, 520)
        Me.lblGmail.Name = "lblGmail"
        Me.lblGmail.Size = New System.Drawing.Size(67, 23)
        Me.lblGmail.TabIndex = 62
        Me.lblGmail.Text = "*Invalid"
        Me.lblGmail.Visible = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Red
        Me.lblPassword.Location = New System.Drawing.Point(714, 575)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 23)
        Me.lblPassword.TabIndex = 63
        Me.lblPassword.Text = "*Invalid"
        Me.lblPassword.Visible = False
        '
        'txtNRIC
        '
        Me.txtNRIC.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNRIC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNRIC.Location = New System.Drawing.Point(296, 408)
        Me.txtNRIC.Mask = "000000000000"
        Me.txtNRIC.Name = "txtNRIC"
        Me.txtNRIC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNRIC.Size = New System.Drawing.Size(354, 34)
        Me.txtNRIC.TabIndex = 2
        '
        'frmBuyerSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.txtNRIC)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblGmail)
        Me.Controls.Add(Me.lblContactNo)
        Me.Controls.Add(Me.lblNRIC)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.mtxtContactNo)
        Me.Controls.Add(Me.lblMatching)
        Me.Controls.Add(Me.txtReEnterPassword)
        Me.Controls.Add(Me.lblReEnterPassword1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUploadProfile)
        Me.Controls.Add(Me.pcbHashPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtGmail)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.pcbProfilePhoto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblReEnterPassword2)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuyerSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pcbHashPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfilePhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBackSignUp As Button
    Friend WithEvents ButtonSetControl1 As ButtonSetControl
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUploadProfile As Button
    Friend WithEvents pcbHashPassword As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtGmail As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents pcbProfilePhoto As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialogProfile As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtReEnterPassword As TextBox
    Friend WithEvents lblReEnterPassword1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblReEnterPassword2 As Label
    Friend WithEvents lblMatching As Label
    Friend WithEvents mtxtContactNo As MaskedTextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblNRIC As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblGmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtNRIC As MaskedTextBox
End Class
