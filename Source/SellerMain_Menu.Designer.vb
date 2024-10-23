<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSellerMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSellerMainMenu))
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.btnComment = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnAboutUs = New System.Windows.Forms.Button()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.PanelTab = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonSetControl1 = New OMC_EZLIFE_May2023.ButtonSetControl()
        Me.PanelButton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelButton
        '
        Me.PanelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.PanelButton.Controls.Add(Me.btnComment)
        Me.PanelButton.Controls.Add(Me.btnOrder)
        Me.PanelButton.Controls.Add(Me.Panel1)
        Me.PanelButton.Controls.Add(Me.btnLogOut)
        Me.PanelButton.Controls.Add(Me.btnProfile)
        Me.PanelButton.Controls.Add(Me.btnFeedback)
        Me.PanelButton.Controls.Add(Me.btnAboutUs)
        Me.PanelButton.Controls.Add(Me.btnAddService)
        Me.PanelButton.Controls.Add(Me.btnDashboard)
        Me.PanelButton.Controls.Add(Me.PanelLogo)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelButton.Location = New System.Drawing.Point(0, 0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(233, 700)
        Me.PanelButton.TabIndex = 1
        '
        'btnComment
        '
        Me.btnComment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnComment.FlatAppearance.BorderSize = 0
        Me.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComment.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComment.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnComment.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_feedback_32
        Me.btnComment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComment.Location = New System.Drawing.Point(0, 458)
        Me.btnComment.Name = "btnComment"
        Me.btnComment.Size = New System.Drawing.Size(226, 49)
        Me.btnComment.TabIndex = 10
        Me.btnComment.Text = "Comment"
        Me.btnComment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnComment.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrder.FlatAppearance.BorderSize = 0
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrder.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOrder.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_list_32
        Me.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrder.Location = New System.Drawing.Point(0, 399)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(226, 54)
        Me.btnOrder.TabIndex = 9
        Me.btnOrder.Text = "Order"
        Me.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Location = New System.Drawing.Point(4, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 78)
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
        Me.btnLogOut.Location = New System.Drawing.Point(4, 639)
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
        Me.btnProfile.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_manager_32
        Me.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfile.Location = New System.Drawing.Point(0, 285)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(226, 49)
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
        Me.btnFeedback.Location = New System.Drawing.Point(0, 568)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(226, 49)
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
        Me.btnAboutUs.Location = New System.Drawing.Point(0, 513)
        Me.btnAboutUs.Name = "btnAboutUs"
        Me.btnAboutUs.Size = New System.Drawing.Size(226, 49)
        Me.btnAboutUs.TabIndex = 5
        Me.btnAboutUs.Text = "About Us"
        Me.btnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAboutUs.UseVisualStyleBackColor = True
        '
        'btnAddService
        '
        Me.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddService.FlatAppearance.BorderSize = 0
        Me.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddService.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddService.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddService.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_create_document_32
        Me.btnAddService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddService.Location = New System.Drawing.Point(0, 339)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(226, 54)
        Me.btnAddService.TabIndex = 3
        Me.btnAddService.Text = "Service"
        Me.btnAddService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddService.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDashboard.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_analysis_32
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 232)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(226, 47)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Statistics"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.PanelLogo.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_666
        Me.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(233, 127)
        Me.PanelLogo.TabIndex = 0
        '
        'PanelContent
        '
        Me.PanelContent.BackColor = System.Drawing.Color.White
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(233, 50)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(944, 650)
        Me.PanelContent.TabIndex = 3
        '
        'PanelTab
        '
        Me.PanelTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.PanelTab.Controls.Add(Me.lblHeader)
        Me.PanelTab.Controls.Add(Me.ButtonSetControl1)
        Me.PanelTab.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTab.Location = New System.Drawing.Point(233, 0)
        Me.PanelTab.Name = "PanelTab"
        Me.PanelTab.Size = New System.Drawing.Size(944, 50)
        Me.PanelTab.TabIndex = 2
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeader.Font = New System.Drawing.Font("Sans Serif Collection", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(858, 50)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Statistic Dashboard"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ButtonSetControl1
        '
        Me.ButtonSetControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.ButtonSetControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonSetControl1.Location = New System.Drawing.Point(858, 0)
        Me.ButtonSetControl1.Name = "ButtonSetControl1"
        Me.ButtonSetControl1.Size = New System.Drawing.Size(86, 50)
        Me.ButtonSetControl1.TabIndex = 0
        '
        'frmSellerMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 700)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelTab)
        Me.Controls.Add(Me.PanelButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSellerMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SellerMain_Menu"
        Me.PanelButton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelButton As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents btnAddService As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelContent As Panel
    Friend WithEvents PanelTab As Panel
    Friend WithEvents ButtonSetControl1 As ButtonSetControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnOrder As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnComment As Button
End Class
