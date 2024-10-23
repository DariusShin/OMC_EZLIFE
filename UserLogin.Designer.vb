<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserLogin))
        Me.PanelBackground = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelPassword = New System.Windows.Forms.Panel()
        Me.PanelUsername = New System.Windows.Forms.Panel()
        Me.lblInvalidPassword = New System.Windows.Forms.Label()
        Me.lblInvalidUsername = New System.Windows.Forms.Label()
        Me.TimerChangeImage = New System.Windows.Forms.Timer(Me.components)
        Me.pcbExit = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pcbHashPassword = New System.Windows.Forms.PictureBox()
        Me.pcbImage = New System.Windows.Forms.PictureBox()
        Me.PanelBackground.SuspendLayout()
        Me.PanelLogin.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelPassword.SuspendLayout()
        Me.PanelUsername.SuspendLayout()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHashPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBackground
        '
        Me.PanelBackground.BackColor = System.Drawing.Color.White
        Me.PanelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelBackground.Controls.Add(Me.pcbImage)
        Me.PanelBackground.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelBackground.Location = New System.Drawing.Point(0, 0)
        Me.PanelBackground.Name = "PanelBackground"
        Me.PanelBackground.Size = New System.Drawing.Size(858, 634)
        Me.PanelBackground.TabIndex = 0
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Gray
        Me.txtUsername.Location = New System.Drawing.Point(1, 2)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(272, 32)
        Me.txtUsername.TabIndex = 6
        Me.txtUsername.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword.Location = New System.Drawing.Point(2, 2)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(271, 34)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.Text = "8 to 12 Character"
        '
        'PanelLogin
        '
        Me.PanelLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.PanelLogin.Controls.Add(Me.pcbExit)
        Me.PanelLogin.Controls.Add(Me.PictureBox1)
        Me.PanelLogin.Controls.Add(Me.Panel2)
        Me.PanelLogin.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelLogin.Location = New System.Drawing.Point(848, 0)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(532, 634)
        Me.PanelLogin.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PanelPassword)
        Me.Panel2.Controls.Add(Me.PanelUsername)
        Me.Panel2.Controls.Add(Me.lblInvalidPassword)
        Me.Panel2.Controls.Add(Me.lblInvalidUsername)
        Me.Panel2.Controls.Add(Me.btnSignup)
        Me.Panel2.Controls.Add(Me.btnLogin)
        Me.Panel2.Controls.Add(Me.pcbHashPassword)
        Me.Panel2.Location = New System.Drawing.Point(48, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(437, 522)
        Me.Panel2.TabIndex = 5
        '
        'PanelPassword
        '
        Me.PanelPassword.BackColor = System.Drawing.Color.Transparent
        Me.PanelPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelPassword.Controls.Add(Me.txtPassword)
        Me.PanelPassword.Location = New System.Drawing.Point(88, 238)
        Me.PanelPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelPassword.Name = "PanelPassword"
        Me.PanelPassword.Size = New System.Drawing.Size(276, 38)
        Me.PanelPassword.TabIndex = 19
        '
        'PanelUsername
        '
        Me.PanelUsername.BackColor = System.Drawing.Color.Transparent
        Me.PanelUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelUsername.Controls.Add(Me.txtUsername)
        Me.PanelUsername.Location = New System.Drawing.Point(88, 158)
        Me.PanelUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelUsername.Name = "PanelUsername"
        Me.PanelUsername.Size = New System.Drawing.Size(276, 38)
        Me.PanelUsername.TabIndex = 18
        '
        'lblInvalidPassword
        '
        Me.lblInvalidPassword.AutoSize = True
        Me.lblInvalidPassword.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidPassword.Location = New System.Drawing.Point(248, 220)
        Me.lblInvalidPassword.Name = "lblInvalidPassword"
        Me.lblInvalidPassword.Size = New System.Drawing.Size(114, 16)
        Me.lblInvalidPassword.TabIndex = 17
        Me.lblInvalidPassword.Text = "*Invalid Password"
        Me.lblInvalidPassword.Visible = False
        '
        'lblInvalidUsername
        '
        Me.lblInvalidUsername.AutoSize = True
        Me.lblInvalidUsername.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidUsername.Location = New System.Drawing.Point(248, 139)
        Me.lblInvalidUsername.Name = "lblInvalidUsername"
        Me.lblInvalidUsername.Size = New System.Drawing.Size(117, 16)
        Me.lblInvalidUsername.TabIndex = 16
        Me.lblInvalidUsername.Text = "*Invalid Username"
        Me.lblInvalidUsername.Visible = False
        '
        'TimerChangeImage
        '
        '
        'pcbExit
        '
        Me.pcbExit.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_close_48
        Me.pcbExit.Location = New System.Drawing.Point(491, 3)
        Me.pcbExit.Name = "pcbExit"
        Me.pcbExit.Size = New System.Drawing.Size(41, 38)
        Me.pcbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbExit.TabIndex = 11
        Me.pcbExit.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.PictureBox1.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_666
        Me.PictureBox1.Location = New System.Drawing.Point(170, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_password_32__1_
        Me.PictureBox3.Location = New System.Drawing.Point(27, 238)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(47, 38)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_male_user_32
        Me.PictureBox2.Location = New System.Drawing.Point(27, 156)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'btnSignup
        '
        Me.btnSignup.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnSignup.FlatAppearance.BorderSize = 0
        Me.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignup.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignup.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_register_32
        Me.btnSignup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignup.Location = New System.Drawing.Point(43, 428)
        Me.btnSignup.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(336, 56)
        Me.btnSignup.TabIndex = 13
        Me.btnSignup.Text = "Sign Up As New"
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_login_32
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogin.Location = New System.Drawing.Point(43, 346)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(1)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(336, 55)
        Me.btnLogin.TabIndex = 14
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'pcbHashPassword
        '
        Me.pcbHashPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbHashPassword.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_blind_32
        Me.pcbHashPassword.Location = New System.Drawing.Point(382, 240)
        Me.pcbHashPassword.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.pcbHashPassword.Name = "pcbHashPassword"
        Me.pcbHashPassword.Size = New System.Drawing.Size(34, 34)
        Me.pcbHashPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbHashPassword.TabIndex = 12
        Me.pcbHashPassword.TabStop = False
        '
        'pcbImage
        '
        Me.pcbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcbImage.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.online_Services
        Me.pcbImage.Location = New System.Drawing.Point(0, 0)
        Me.pcbImage.Name = "pcbImage"
        Me.pcbImage.Size = New System.Drawing.Size(858, 634)
        Me.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbImage.TabIndex = 0
        Me.pcbImage.TabStop = False
        '
        'frmUserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1380, 634)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.PanelBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserLogin"
        Me.PanelBackground.ResumeLayout(False)
        Me.PanelLogin.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelPassword.ResumeLayout(False)
        Me.PanelPassword.PerformLayout()
        Me.PanelUsername.ResumeLayout(False)
        Me.PanelUsername.PerformLayout()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHashPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBackground As Panel
    Friend WithEvents pcbImage As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pcbHashPassword As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSignup As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents pcbExit As PictureBox
    Friend WithEvents TimerChangeImage As Timer
    Friend WithEvents lblInvalidPassword As Label
    Friend WithEvents lblInvalidUsername As Label
    Friend WithEvents PanelUsername As Panel
    Friend WithEvents PanelPassword As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
