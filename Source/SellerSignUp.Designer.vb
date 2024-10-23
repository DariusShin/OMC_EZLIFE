<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSellerSignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSellerSignUp))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBackSignUp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtBusinessName = New System.Windows.Forms.TextBox()
        Me.txtBusinessOwner = New System.Windows.Forms.TextBox()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.txtGmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.OpenFileDialogLogo = New System.Windows.Forms.OpenFileDialog()
        Me.lblMatching = New System.Windows.Forms.Label()
        Me.txtReEnterPassword = New System.Windows.Forms.TextBox()
        Me.lblReEnterPassword1 = New System.Windows.Forms.Label()
        Me.lblReEnterPassword2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnUploadLogo = New System.Windows.Forms.Button()
        Me.pcbHashPassword = New System.Windows.Forms.PictureBox()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pcbBusinessLogo = New System.Windows.Forms.PictureBox()
        Me.mtxtContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.txtNRIC = New System.Windows.Forms.MaskedTextBox()
        Me.lblGmail = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.lblNRIC = New System.Windows.Forms.Label()
        Me.lblBusinessName = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblBusinessType = New System.Windows.Forms.Label()
        Me.lblBusinessOwner = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.ButtonSetControl1 = New OMC_EZLIFE_May2023.ButtonSetControl()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbHashPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBusinessLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(215, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Service Provider Sign Up"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnBackSignUp)
        Me.Panel1.Controls.Add(Me.ButtonSetControl1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 45)
        Me.Panel1.TabIndex = 1
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
        Me.btnBackSignUp.Size = New System.Drawing.Size(79, 45)
        Me.btnBackSignUp.TabIndex = 5
        Me.btnBackSignUp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 62)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Business " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Logo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(131, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Business Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(90, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Business Type :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 460)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Business Owner :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(175, 510)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 28)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "NRIC :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(113, 559)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 28)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Contact No :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(168, 610)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 28)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Gmail :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(132, 661)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 28)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Password :"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUsername.Location = New System.Drawing.Point(293, 252)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(358, 34)
        Me.txtUsername.TabIndex = 0
        '
        'txtBusinessName
        '
        Me.txtBusinessName.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBusinessName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBusinessName.Location = New System.Drawing.Point(293, 303)
        Me.txtBusinessName.Multiline = True
        Me.txtBusinessName.Name = "txtBusinessName"
        Me.txtBusinessName.Size = New System.Drawing.Size(358, 82)
        Me.txtBusinessName.TabIndex = 1
        '
        'txtBusinessOwner
        '
        Me.txtBusinessOwner.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBusinessOwner.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBusinessOwner.Location = New System.Drawing.Point(294, 455)
        Me.txtBusinessOwner.Name = "txtBusinessOwner"
        Me.txtBusinessOwner.Size = New System.Drawing.Size(358, 34)
        Me.txtBusinessOwner.TabIndex = 2
        '
        'cboServiceType
        '
        Me.cboServiceType.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboServiceType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboServiceType.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboServiceType.FormattingEnabled = True
        Me.cboServiceType.Items.AddRange(New Object() {"Car Pool", "Food Order", "Car Rental", "Parcel Collect"})
        Me.cboServiceType.Location = New System.Drawing.Point(294, 402)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(359, 36)
        Me.cboServiceType.TabIndex = 17
        Me.cboServiceType.Tag = ""
        '
        'txtGmail
        '
        Me.txtGmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtGmail.Location = New System.Drawing.Point(294, 604)
        Me.txtGmail.Name = "txtGmail"
        Me.txtGmail.Size = New System.Drawing.Size(358, 34)
        Me.txtGmail.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(294, 655)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(358, 34)
        Me.txtPassword.TabIndex = 7
        '
        'OpenFileDialogLogo
        '
        Me.OpenFileDialogLogo.Filter = "(Image Files)|*.jpg;*.png;*"
        '
        'lblMatching
        '
        Me.lblMatching.AutoSize = True
        Me.lblMatching.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatching.ForeColor = System.Drawing.Color.Red
        Me.lblMatching.Location = New System.Drawing.Point(667, 715)
        Me.lblMatching.Name = "lblMatching"
        Me.lblMatching.Size = New System.Drawing.Size(121, 23)
        Me.lblMatching.TabIndex = 60
        Me.lblMatching.Text = "Not Matching"
        Me.lblMatching.Visible = False
        '
        'txtReEnterPassword
        '
        Me.txtReEnterPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtReEnterPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtReEnterPassword.Location = New System.Drawing.Point(294, 704)
        Me.txtReEnterPassword.Name = "txtReEnterPassword"
        Me.txtReEnterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtReEnterPassword.Size = New System.Drawing.Size(358, 34)
        Me.txtReEnterPassword.TabIndex = 8
        Me.txtReEnterPassword.Visible = False
        '
        'lblReEnterPassword1
        '
        Me.lblReEnterPassword1.AutoSize = True
        Me.lblReEnterPassword1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReEnterPassword1.Location = New System.Drawing.Point(46, 710)
        Me.lblReEnterPassword1.Name = "lblReEnterPassword1"
        Me.lblReEnterPassword1.Size = New System.Drawing.Size(200, 28)
        Me.lblReEnterPassword1.TabIndex = 57
        Me.lblReEnterPassword1.Text = "Re-Enter Password :"
        Me.lblReEnterPassword1.Visible = False
        '
        'lblReEnterPassword2
        '
        Me.lblReEnterPassword2.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblReEnterPassword2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReEnterPassword2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblReEnterPassword2.Location = New System.Drawing.Point(302, 711)
        Me.lblReEnterPassword2.Name = "lblReEnterPassword2"
        Me.lblReEnterPassword2.Size = New System.Drawing.Size(354, 34)
        Me.lblReEnterPassword2.TabIndex = 59
        Me.lblReEnterPassword2.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(302, 662)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(354, 34)
        Me.Label11.TabIndex = 61
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(302, 611)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(354, 34)
        Me.Label12.TabIndex = 62
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(300, 561)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(355, 34)
        Me.Label13.TabIndex = 63
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(301, 513)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(355, 32)
        Me.Label14.TabIndex = 64
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(301, 464)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(355, 32)
        Me.Label15.TabIndex = 65
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(301, 265)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(354, 28)
        Me.Label16.TabIndex = 66
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(301, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(178, 165)
        Me.Label17.TabIndex = 67
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label18.Location = New System.Drawing.Point(301, 411)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(355, 33)
        Me.Label18.TabIndex = 68
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label19.Location = New System.Drawing.Point(301, 330)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(354, 60)
        Me.Label19.TabIndex = 69
        '
        'btnUploadLogo
        '
        Me.btnUploadLogo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUploadLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadLogo.FlatAppearance.BorderSize = 0
        Me.btnUploadLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadLogo.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_uninstalling_updates_40
        Me.btnUploadLogo.Location = New System.Drawing.Point(497, 185)
        Me.btnUploadLogo.Name = "btnUploadLogo"
        Me.btnUploadLogo.Size = New System.Drawing.Size(50, 50)
        Me.btnUploadLogo.TabIndex = 23
        Me.btnUploadLogo.UseVisualStyleBackColor = False
        '
        'pcbHashPassword
        '
        Me.pcbHashPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbHashPassword.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_blind_32
        Me.pcbHashPassword.Location = New System.Drawing.Point(671, 655)
        Me.pcbHashPassword.Name = "pcbHashPassword"
        Me.pcbHashPassword.Size = New System.Drawing.Size(44, 37)
        Me.pcbHashPassword.TabIndex = 22
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
        Me.btnSignUp.Location = New System.Drawing.Point(454, 764)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(165, 53)
        Me.btnSignUp.TabIndex = 9
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
        Me.btnClear.Location = New System.Drawing.Point(170, 764)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 53)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'pcbBusinessLogo
        '
        Me.pcbBusinessLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pcbBusinessLogo.Enabled = False
        Me.pcbBusinessLogo.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_conference_50
        Me.pcbBusinessLogo.Location = New System.Drawing.Point(294, 60)
        Me.pcbBusinessLogo.Name = "pcbBusinessLogo"
        Me.pcbBusinessLogo.Size = New System.Drawing.Size(180, 175)
        Me.pcbBusinessLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBusinessLogo.TabIndex = 11
        Me.pcbBusinessLogo.TabStop = False
        '
        'mtxtContactNo
        '
        Me.mtxtContactNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mtxtContactNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtContactNo.Location = New System.Drawing.Point(294, 556)
        Me.mtxtContactNo.Mask = "900-000 0000"
        Me.mtxtContactNo.Name = "mtxtContactNo"
        Me.mtxtContactNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtxtContactNo.Size = New System.Drawing.Size(358, 34)
        Me.mtxtContactNo.TabIndex = 5
        '
        'txtNRIC
        '
        Me.txtNRIC.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNRIC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNRIC.Location = New System.Drawing.Point(293, 505)
        Me.txtNRIC.Mask = "000000000000"
        Me.txtNRIC.Name = "txtNRIC"
        Me.txtNRIC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNRIC.Size = New System.Drawing.Size(359, 34)
        Me.txtNRIC.TabIndex = 3
        '
        'lblGmail
        '
        Me.lblGmail.AutoSize = True
        Me.lblGmail.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGmail.ForeColor = System.Drawing.Color.Red
        Me.lblGmail.Location = New System.Drawing.Point(667, 612)
        Me.lblGmail.Name = "lblGmail"
        Me.lblGmail.Size = New System.Drawing.Size(67, 23)
        Me.lblGmail.TabIndex = 76
        Me.lblGmail.Text = "*Invalid"
        Me.lblGmail.Visible = False
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.ForeColor = System.Drawing.Color.Red
        Me.lblContactNo.Location = New System.Drawing.Point(667, 564)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(67, 23)
        Me.lblContactNo.TabIndex = 75
        Me.lblContactNo.Text = "*Invalid"
        Me.lblContactNo.Visible = False
        '
        'lblNRIC
        '
        Me.lblNRIC.AutoSize = True
        Me.lblNRIC.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNRIC.ForeColor = System.Drawing.Color.Red
        Me.lblNRIC.Location = New System.Drawing.Point(667, 515)
        Me.lblNRIC.Name = "lblNRIC"
        Me.lblNRIC.Size = New System.Drawing.Size(67, 23)
        Me.lblNRIC.TabIndex = 74
        Me.lblNRIC.Text = "*Invalid"
        Me.lblNRIC.Visible = False
        '
        'lblBusinessName
        '
        Me.lblBusinessName.AutoSize = True
        Me.lblBusinessName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusinessName.ForeColor = System.Drawing.Color.Red
        Me.lblBusinessName.Location = New System.Drawing.Point(667, 335)
        Me.lblBusinessName.Name = "lblBusinessName"
        Me.lblBusinessName.Size = New System.Drawing.Size(67, 23)
        Me.lblBusinessName.TabIndex = 73
        Me.lblBusinessName.Text = "*Invalid"
        Me.lblBusinessName.Visible = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Red
        Me.lblUsername.Location = New System.Drawing.Point(667, 258)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(67, 23)
        Me.lblUsername.TabIndex = 72
        Me.lblUsername.Text = "*Invalid"
        Me.lblUsername.Visible = False
        '
        'lblBusinessType
        '
        Me.lblBusinessType.AutoSize = True
        Me.lblBusinessType.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusinessType.ForeColor = System.Drawing.Color.Red
        Me.lblBusinessType.Location = New System.Drawing.Point(667, 410)
        Me.lblBusinessType.Name = "lblBusinessType"
        Me.lblBusinessType.Size = New System.Drawing.Size(67, 23)
        Me.lblBusinessType.TabIndex = 78
        Me.lblBusinessType.Text = "*Invalid"
        Me.lblBusinessType.Visible = False
        '
        'lblBusinessOwner
        '
        Me.lblBusinessOwner.AutoSize = True
        Me.lblBusinessOwner.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusinessOwner.ForeColor = System.Drawing.Color.Red
        Me.lblBusinessOwner.Location = New System.Drawing.Point(667, 465)
        Me.lblBusinessOwner.Name = "lblBusinessOwner"
        Me.lblBusinessOwner.Size = New System.Drawing.Size(67, 23)
        Me.lblBusinessOwner.TabIndex = 77
        Me.lblBusinessOwner.Text = "*Invalid"
        Me.lblBusinessOwner.Visible = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Red
        Me.lblPassword.Location = New System.Drawing.Point(721, 661)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 23)
        Me.lblPassword.TabIndex = 79
        Me.lblPassword.Text = "*Invalid"
        Me.lblPassword.Visible = False
        '
        'ButtonSetControl1
        '
        Me.ButtonSetControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonSetControl1.Location = New System.Drawing.Point(714, 0)
        Me.ButtonSetControl1.Name = "ButtonSetControl1"
        Me.ButtonSetControl1.Size = New System.Drawing.Size(86, 45)
        Me.ButtonSetControl1.TabIndex = 4
        '
        'frmSellerSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 829)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblBusinessType)
        Me.Controls.Add(Me.lblBusinessOwner)
        Me.Controls.Add(Me.lblGmail)
        Me.Controls.Add(Me.lblContactNo)
        Me.Controls.Add(Me.lblNRIC)
        Me.Controls.Add(Me.lblBusinessName)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtNRIC)
        Me.Controls.Add(Me.mtxtContactNo)
        Me.Controls.Add(Me.lblMatching)
        Me.Controls.Add(Me.txtReEnterPassword)
        Me.Controls.Add(Me.lblReEnterPassword1)
        Me.Controls.Add(Me.lblReEnterPassword2)
        Me.Controls.Add(Me.btnUploadLogo)
        Me.Controls.Add(Me.pcbHashPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtGmail)
        Me.Controls.Add(Me.cboServiceType)
        Me.Controls.Add(Me.txtBusinessOwner)
        Me.Controls.Add(Me.txtBusinessName)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.pcbBusinessLogo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSellerSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SellerSignUp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pcbHashPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBusinessLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonSetControl1 As ButtonSetControl
    Friend WithEvents btnBackSignUp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents pcbBusinessLogo As PictureBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtBusinessName As TextBox
    Friend WithEvents txtBusinessOwner As TextBox
    Friend WithEvents cboServiceType As ComboBox
    Friend WithEvents txtGmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents pcbHashPassword As PictureBox
    Friend WithEvents OpenFileDialogLogo As OpenFileDialog
    Friend WithEvents btnUploadLogo As Button
    Friend WithEvents lblMatching As Label
    Friend WithEvents txtReEnterPassword As TextBox
    Friend WithEvents lblReEnterPassword1 As Label
    Friend WithEvents lblReEnterPassword2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents mtxtContactNo As MaskedTextBox
    Friend WithEvents txtNRIC As MaskedTextBox
    Friend WithEvents lblGmail As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblNRIC As Label
    Friend WithEvents lblBusinessName As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblBusinessType As Label
    Friend WithEvents lblBusinessOwner As Label
    Friend WithEvents lblPassword As Label
End Class
