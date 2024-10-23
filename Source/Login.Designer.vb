<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonSetControl2 = New OMC_EZLIFE_May2023.ButtonSetControl()
        Me.pcbIcon = New System.Windows.Forms.PictureBox()
        Me.pcbHashPassword = New System.Windows.Forms.PictureBox()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pcbLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHashPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 228)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 298)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsername.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Gray
        Me.txtUsername.Location = New System.Drawing.Point(184, 228)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(172, 32)
        Me.txtUsername.TabIndex = 5
        Me.txtUsername.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword.Location = New System.Drawing.Point(184, 295)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(172, 34)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.Text = "8 to 12 Character"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ButtonSetControl2)
        Me.Panel1.Controls.Add(Me.pcbIcon)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 42)
        Me.Panel1.TabIndex = 8
        '
        'ButtonSetControl2
        '
        Me.ButtonSetControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonSetControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSetControl2.Location = New System.Drawing.Point(378, 0)
        Me.ButtonSetControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonSetControl2.Name = "ButtonSetControl2"
        Me.ButtonSetControl2.Size = New System.Drawing.Size(79, 42)
        Me.ButtonSetControl2.TabIndex = 11
        '
        'pcbIcon
        '
        Me.pcbIcon.BackColor = System.Drawing.Color.Transparent
        Me.pcbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.pcbIcon.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources._removal_ai__tmp_648ee6a305f16
        Me.pcbIcon.Location = New System.Drawing.Point(0, 0)
        Me.pcbIcon.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.pcbIcon.Name = "pcbIcon"
        Me.pcbIcon.Size = New System.Drawing.Size(54, 42)
        Me.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbIcon.TabIndex = 4
        Me.pcbIcon.TabStop = False
        '
        'pcbHashPassword
        '
        Me.pcbHashPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbHashPassword.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_blind_32
        Me.pcbHashPassword.Location = New System.Drawing.Point(375, 295)
        Me.pcbHashPassword.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.pcbHashPassword.Name = "pcbHashPassword"
        Me.pcbHashPassword.Size = New System.Drawing.Size(35, 34)
        Me.pcbHashPassword.TabIndex = 11
        Me.pcbHashPassword.TabStop = False
        '
        'btnSignup
        '
        Me.btnSignup.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignup.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignup.Image = CType(resources.GetObject("btnSignup.Image"), System.Drawing.Image)
        Me.btnSignup.Location = New System.Drawing.Point(46, 400)
        Me.btnSignup.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(157, 42)
        Me.btnSignup.TabIndex = 1
        Me.btnSignup.Text = "Sign Up"
        Me.btnSignup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSignup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Yellow
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.Location = New System.Drawing.Point(257, 400)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(153, 42)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'pcbLogo
        '
        Me.pcbLogo.BackgroundImage = CType(resources.GetObject("pcbLogo.BackgroundImage"), System.Drawing.Image)
        Me.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbLogo.Location = New System.Drawing.Point(160, 67)
        Me.pcbLogo.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.pcbLogo.Name = "pcbLogo"
        Me.pcbLogo.Size = New System.Drawing.Size(114, 119)
        Me.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbLogo.TabIndex = 4
        Me.pcbLogo.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(457, 472)
        Me.Controls.Add(Me.pcbHashPassword)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.pcbLogo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pcbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHashPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pcbLogo As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pcbIcon As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSignup As Button
    Friend WithEvents ButtonSetControl2 As ButtonSetControl
    Friend WithEvents pcbHashPassword As PictureBox
End Class
