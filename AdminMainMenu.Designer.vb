<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminMainMenu))
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.PanelTab = New System.Windows.Forms.Panel()
        Me.ButtonSetControl2 = New OMC_EZLIFE_May2023.ButtonSetControl()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnNewSellerRequest = New System.Windows.Forms.Button()
        Me.btnSellerDashboard = New System.Windows.Forms.Button()
        Me.btnBuyerDashboard = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
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
        Me.PanelButton.Controls.Add(Me.btnFeedback)
        Me.PanelButton.Controls.Add(Me.btnNewSellerRequest)
        Me.PanelButton.Controls.Add(Me.btnSellerDashboard)
        Me.PanelButton.Controls.Add(Me.btnBuyerDashboard)
        Me.PanelButton.Controls.Add(Me.PanelLogo)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelButton.Location = New System.Drawing.Point(0, 0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(230, 700)
        Me.PanelButton.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Location = New System.Drawing.Point(4, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 78)
        Me.Panel1.TabIndex = 8
        '
        'lblDate
        '
        Me.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(20, 42)
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
        Me.lblTime.Location = New System.Drawing.Point(20, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(170, 32)
        Me.lblTime.TabIndex = 9
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelTab
        '
        Me.PanelTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PanelTab.Controls.Add(Me.ButtonSetControl2)
        Me.PanelTab.Controls.Add(Me.lblHeader)
        Me.PanelTab.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTab.Location = New System.Drawing.Point(230, 0)
        Me.PanelTab.Name = "PanelTab"
        Me.PanelTab.Size = New System.Drawing.Size(940, 50)
        Me.PanelTab.TabIndex = 3
        '
        'ButtonSetControl2
        '
        Me.ButtonSetControl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.ButtonSetControl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSetControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonSetControl2.Location = New System.Drawing.Point(859, 0)
        Me.ButtonSetControl2.Name = "ButtonSetControl2"
        Me.ButtonSetControl2.Size = New System.Drawing.Size(81, 50)
        Me.ButtonSetControl2.TabIndex = 2
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeader.Font = New System.Drawing.Font("Sans Serif Collection", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(940, 50)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Buyer List Dashboard"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PanelContent
        '
        Me.PanelContent.AutoScroll = True
        Me.PanelContent.BackColor = System.Drawing.Color.White
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(230, 50)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(940, 650)
        Me.PanelContent.TabIndex = 4
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Brown
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLogOut.Image = CType(resources.GetObject("btnLogOut.Image"), System.Drawing.Image)
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(3, 616)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(227, 49)
        Me.btnLogOut.TabIndex = 7
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnFeedback
        '
        Me.btnFeedback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFeedback.FlatAppearance.BorderSize = 0
        Me.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFeedback.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeedback.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFeedback.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_feedback_32
        Me.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFeedback.Location = New System.Drawing.Point(3, 404)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(227, 49)
        Me.btnFeedback.TabIndex = 6
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFeedback.UseVisualStyleBackColor = True
        '
        'btnNewSellerRequest
        '
        Me.btnNewSellerRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewSellerRequest.FlatAppearance.BorderSize = 0
        Me.btnNewSellerRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewSellerRequest.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewSellerRequest.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNewSellerRequest.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_new_32
        Me.btnNewSellerRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewSellerRequest.Location = New System.Drawing.Point(3, 349)
        Me.btnNewSellerRequest.Name = "btnNewSellerRequest"
        Me.btnNewSellerRequest.Size = New System.Drawing.Size(227, 49)
        Me.btnNewSellerRequest.TabIndex = 5
        Me.btnNewSellerRequest.Text = "Request"
        Me.btnNewSellerRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewSellerRequest.UseVisualStyleBackColor = True
        '
        'btnSellerDashboard
        '
        Me.btnSellerDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSellerDashboard.FlatAppearance.BorderSize = 0
        Me.btnSellerDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSellerDashboard.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSellerDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSellerDashboard.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_seller_32
        Me.btnSellerDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSellerDashboard.Location = New System.Drawing.Point(3, 289)
        Me.btnSellerDashboard.Name = "btnSellerDashboard"
        Me.btnSellerDashboard.Size = New System.Drawing.Size(227, 54)
        Me.btnSellerDashboard.TabIndex = 3
        Me.btnSellerDashboard.Text = "Seller"
        Me.btnSellerDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSellerDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSellerDashboard.UseVisualStyleBackColor = False
        '
        'btnBuyerDashboard
        '
        Me.btnBuyerDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnBuyerDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuyerDashboard.FlatAppearance.BorderSize = 0
        Me.btnBuyerDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuyerDashboard.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuyerDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuyerDashboard.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_buyer_32
        Me.btnBuyerDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuyerDashboard.Location = New System.Drawing.Point(3, 236)
        Me.btnBuyerDashboard.Name = "btnBuyerDashboard"
        Me.btnBuyerDashboard.Size = New System.Drawing.Size(227, 47)
        Me.btnBuyerDashboard.TabIndex = 1
        Me.btnBuyerDashboard.Text = "Buyer"
        Me.btnBuyerDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuyerDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuyerDashboard.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.Teal
        Me.PanelLogo.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_666
        Me.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(230, 127)
        Me.PanelLogo.TabIndex = 0
        '
        'frmAdminMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1170, 700)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelTab)
        Me.Controls.Add(Me.PanelButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdminMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminMainMenu"
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
    Friend WithEvents btnFeedback As Button
    Friend WithEvents btnNewSellerRequest As Button
    Friend WithEvents btnSellerDashboard As Button
    Friend WithEvents btnBuyerDashboard As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelTab As Panel
    Friend WithEvents ButtonSetControl2 As ButtonSetControl
    Friend WithEvents lblHeader As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PanelContent As Panel
End Class
