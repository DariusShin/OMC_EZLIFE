<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEZLifeSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEZLifeSplash))
        Me.PanelBorder = New System.Windows.Forms.Panel()
        Me.PanelProgress = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogo = New System.Windows.Forms.Button()
        Me.PanelBase = New System.Windows.Forms.Panel()
        Me.PanelLoading = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelBorder.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBase.SuspendLayout()
        Me.PanelLoading.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBorder
        '
        Me.PanelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBorder.Controls.Add(Me.PanelProgress)
        Me.PanelBorder.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelBorder.Location = New System.Drawing.Point(3, 444)
        Me.PanelBorder.Name = "PanelBorder"
        Me.PanelBorder.Size = New System.Drawing.Size(595, 32)
        Me.PanelBorder.TabIndex = 5
        '
        'PanelProgress
        '
        Me.PanelProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.PanelProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelProgress.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelProgress.Location = New System.Drawing.Point(3, 3)
        Me.PanelProgress.Name = "PanelProgress"
        Me.PanelProgress.Size = New System.Drawing.Size(38, 24)
        Me.PanelProgress.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.gear2
        Me.PictureBox2.Location = New System.Drawing.Point(544, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "EZ LIFE 2023"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLogo
        '
        Me.btnLogo.BackColor = System.Drawing.Color.Transparent
        Me.btnLogo.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_666
        Me.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLogo.Enabled = False
        Me.btnLogo.FlatAppearance.BorderSize = 0
        Me.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogo.Location = New System.Drawing.Point(0, 0)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(489, 388)
        Me.btnLogo.TabIndex = 9
        Me.btnLogo.UseVisualStyleBackColor = False
        '
        'PanelBase
        '
        Me.PanelBase.BackColor = System.Drawing.Color.Black
        Me.PanelBase.Controls.Add(Me.btnLogo)
        Me.PanelBase.Location = New System.Drawing.Point(54, 50)
        Me.PanelBase.Name = "PanelBase"
        Me.PanelBase.Size = New System.Drawing.Size(489, 389)
        Me.PanelBase.TabIndex = 10
        '
        'PanelLoading
        '
        Me.PanelLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.PanelLoading.Controls.Add(Me.Button1)
        Me.PanelLoading.Location = New System.Drawing.Point(54, 49)
        Me.PanelLoading.Name = "PanelLoading"
        Me.PanelLoading.Size = New System.Drawing.Size(26, 389)
        Me.PanelLoading.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_666
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(489, 389)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PanelBorder)
        Me.Panel1.Controls.Add(Me.PanelLoading)
        Me.Panel1.Controls.Add(Me.PanelBase)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 476)
        Me.Panel1.TabIndex = 12
        '
        'frmEZLifeSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(601, 476)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEZLifeSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEZLifeSplash"
        Me.PanelBorder.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBase.ResumeLayout(False)
        Me.PanelLoading.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBorder As Panel
    Friend WithEvents PanelProgress As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogo As Button
    Friend WithEvents PanelBase As Panel
    Friend WithEvents PanelLoading As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
