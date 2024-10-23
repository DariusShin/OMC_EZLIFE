<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuyerLoginSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuyerLoginSplash))
        Me.TimerBuyerLogin = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBorder = New System.Windows.Forms.Panel()
        Me.PanelProgress = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pcbLoading = New System.Windows.Forms.PictureBox()
        Me.PanelBorder.SuspendLayout()
        CType(Me.pcbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerBuyerLogin
        '
        '
        'PanelBorder
        '
        Me.PanelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBorder.Controls.Add(Me.PanelProgress)
        Me.PanelBorder.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelBorder.Location = New System.Drawing.Point(25, 398)
        Me.PanelBorder.Name = "PanelBorder"
        Me.PanelBorder.Size = New System.Drawing.Size(700, 40)
        Me.PanelBorder.TabIndex = 0
        '
        'PanelProgress
        '
        Me.PanelProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelProgress.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelProgress.Location = New System.Drawing.Point(3, 3)
        Me.PanelProgress.Name = "PanelProgress"
        Me.PanelProgress.Size = New System.Drawing.Size(35, 32)
        Me.PanelProgress.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(246, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 62)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Loading..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(177, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(406, 81)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Please Wait..."
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblWelcome.Location = New System.Drawing.Point(125, 272)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(479, 62)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.Text = "Welcome Username!"
        '
        'pcbLoading
        '
        Me.pcbLoading.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_buying_24
        Me.pcbLoading.Location = New System.Drawing.Point(29, 349)
        Me.pcbLoading.Name = "pcbLoading"
        Me.pcbLoading.Size = New System.Drawing.Size(49, 43)
        Me.pcbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbLoading.TabIndex = 4
        Me.pcbLoading.TabStop = False
        '
        'frmBuyerLoginSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(762, 450)
        Me.Controls.Add(Me.pcbLoading)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelBorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuyerLoginSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuyerLoginSplash"
        Me.PanelBorder.ResumeLayout(False)
        CType(Me.pcbLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerBuyerLogin As Timer
    Friend WithEvents PanelBorder As Panel
    Friend WithEvents PanelProgress As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents pcbLoading As PictureBox
End Class
