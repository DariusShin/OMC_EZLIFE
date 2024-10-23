<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.PanelTab = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnAboutUs = New System.Windows.Forms.Button()
        Me.btnProgress = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnServices = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.ButtonSetControl2 = New OMC_EZLIFE_May2023.ButtonSetControl()
        Me.PanelButton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelButton
        '
        Me.PanelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.PanelButton.Controls.Add(Me.Panel1)
        Me.PanelButton.Controls.Add(Me.btnLogOut)
        Me.PanelButton.Controls.Add(Me.btnProfile)
        Me.PanelButton.Controls.Add(Me.btnFeedback)
        Me.PanelButton.Controls.Add(Me.btnAboutUs)
        Me.PanelButton.Controls.Add(Me.btnProgress)
        Me.PanelButton.Controls.Add(Me.btnHistory)
        Me.PanelButton.Controls.Add(Me.btnServices)
        Me.PanelButton.Controls.Add(Me.PanelLogo)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelButton.Location = New System.Drawing.Point(0, 0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(230, 700)
        Me.PanelButton.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Location = New System.Drawing.Point(4, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 78)
        Me.Panel1.TabIndex = 8
        '
        'lblDate
        '
        Me.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(23, 48)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(170, 32)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(23, 6)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(170, 32)
        Me.lblTime.TabIndex = 9
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelTab
        '
        Me.PanelTab.BackColor = System.Drawing.Color.Teal
        Me.PanelTab.Controls.Add(Me.ButtonSetControl2)
        Me.PanelTab.Controls.Add(Me.lblHeader)
        Me.PanelTab.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTab.Location = New System.Drawing.Point(230, 0)
        Me.PanelTab.Name = "PanelTab"
        Me.PanelTab.Size = New System.Drawing.Size(897, 50)
        Me.PanelTab.TabIndex = 1
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeader.Font = New System.Drawing.Font("Sans Serif Collection", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(897, 50)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Services Dashboard"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelContent
        '
        Me.PanelContent.BackColor = System.Drawing.Color.White
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(230, 50)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(897, 650)
        Me.PanelContent.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Brown
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLogOut.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_login_32__1_
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(3, 608)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(223, 49)
        Me.btnLogOut.TabIndex = 7
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProfile.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_user_32
        Me.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfile.Location = New System.Drawing.Point(0, 285)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(220, 49)
        Me.btnProfile.TabIndex = 4
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnFeedback
        '
        Me.btnFeedback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFeedback.FlatAppearance.BorderSize = 0
        Me.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFeedback.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeedback.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFeedback.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_letter_with_email_sign_32__1_
        Me.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFeedback.Location = New System.Drawing.Point(0, 510)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(220, 49)
        Me.btnFeedback.TabIndex = 6
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFeedback.UseVisualStyleBackColor = True
        '
        'btnAboutUs
        '
        Me.btnAboutUs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAboutUs.FlatAppearance.BorderSize = 0
        Me.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutUs.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutUs.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAboutUs.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_about_us_32
        Me.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAboutUs.Location = New System.Drawing.Point(0, 455)
        Me.btnAboutUs.Name = "btnAboutUs"
        Me.btnAboutUs.Size = New System.Drawing.Size(220, 49)
        Me.btnAboutUs.TabIndex = 5
        Me.btnAboutUs.Text = "About Us"
        Me.btnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAboutUs.UseVisualStyleBackColor = True
        '
        'btnProgress
        '
        Me.btnProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnProgress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProgress.FlatAppearance.BorderSize = 0
        Me.btnProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgress.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProgress.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProgress.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_status_32
        Me.btnProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgress.Location = New System.Drawing.Point(0, 340)
        Me.btnProgress.Name = "btnProgress"
        Me.btnProgress.Size = New System.Drawing.Size(220, 54)
        Me.btnProgress.TabIndex = 3
        Me.btnProgress.Text = "Progress"
        Me.btnProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProgress.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHistory.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_history_32
        Me.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistory.Location = New System.Drawing.Point(0, 400)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(220, 49)
        Me.btnHistory.TabIndex = 2
        Me.btnHistory.Text = "History"
        Me.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnServices
        '
        Me.btnServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnServices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnServices.FlatAppearance.BorderSize = 0
        Me.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServices.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServices.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnServices.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_tools_32
        Me.btnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnServices.Location = New System.Drawing.Point(0, 232)
        Me.btnServices.Name = "btnServices"
        Me.btnServices.Size = New System.Drawing.Size(220, 47)
        Me.btnServices.TabIndex = 1
        Me.btnServices.Text = "Services"
        Me.btnServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnServices.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelLogo.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_666
        Me.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(230, 126)
        Me.PanelLogo.TabIndex = 0
        '
        'ButtonSetControl2
        '
        Me.ButtonSetControl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ButtonSetControl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSetControl2.Location = New System.Drawing.Point(816, 3)
        Me.ButtonSetControl2.Name = "ButtonSetControl2"
        Me.ButtonSetControl2.Size = New System.Drawing.Size(81, 49)
        Me.ButtonSetControl2.TabIndex = 2
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 700)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelTab)
        Me.Controls.Add(Me.PanelButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main_Menu"
        Me.PanelButton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelButton As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelTab As Panel
    Friend WithEvents PanelContent As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnServices As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnProgress As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents ButtonSetControl2 As ButtonSetControl
    Friend WithEvents btnLogOut As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTime As Label
End Class
