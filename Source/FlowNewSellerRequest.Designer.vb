<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlowNewSellerRequest
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
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.lblBusinessOwner = New System.Windows.Forms.Label()
        Me.lblStoreSellerID = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.lblBusinessType = New System.Windows.Forms.Label()
        Me.pcbBusinessLogo = New System.Windows.Forms.PictureBox()
        Me.lblBusinessName = New System.Windows.Forms.Label()
        Me.PanelContent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbBusinessLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContent
        '
        Me.PanelContent.BackColor = System.Drawing.Color.White
        Me.PanelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContent.Controls.Add(Me.lblBusinessOwner)
        Me.PanelContent.Controls.Add(Me.lblStoreSellerID)
        Me.PanelContent.Controls.Add(Me.lblContact)
        Me.PanelContent.Controls.Add(Me.Panel1)
        Me.PanelContent.Controls.Add(Me.lblBusinessType)
        Me.PanelContent.Controls.Add(Me.pcbBusinessLogo)
        Me.PanelContent.Controls.Add(Me.lblBusinessName)
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(0, 0)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(880, 150)
        Me.PanelContent.TabIndex = 1
        '
        'lblBusinessOwner
        '
        Me.lblBusinessOwner.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusinessOwner.Location = New System.Drawing.Point(144, 81)
        Me.lblBusinessOwner.Name = "lblBusinessOwner"
        Me.lblBusinessOwner.Size = New System.Drawing.Size(332, 59)
        Me.lblBusinessOwner.TabIndex = 10
        Me.lblBusinessOwner.Text = "Business Owner"
        '
        'lblStoreSellerID
        '
        Me.lblStoreSellerID.AutoSize = True
        Me.lblStoreSellerID.Location = New System.Drawing.Point(492, 81)
        Me.lblStoreSellerID.Name = "lblStoreSellerID"
        Me.lblStoreSellerID.Size = New System.Drawing.Size(0, 16)
        Me.lblStoreSellerID.TabIndex = 9
        Me.lblStoreSellerID.Visible = False
        '
        'lblContact
        '
        Me.lblContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblContact.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.White
        Me.lblContact.Location = New System.Drawing.Point(451, 2)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(268, 42)
        Me.lblContact.TabIndex = 7
        Me.lblContact.Text = "Contact"
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnApprove)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(721, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(157, 148)
        Me.Panel1.TabIndex = 5
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.White
        Me.btnApprove.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_approval_40__1_
        Me.btnApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApprove.FlatAppearance.BorderSize = 0
        Me.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprove.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.Location = New System.Drawing.Point(15, 28)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(128, 96)
        Me.btnApprove.TabIndex = 1
        Me.btnApprove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'lblBusinessType
        '
        Me.lblBusinessType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusinessType.Location = New System.Drawing.Point(478, 97)
        Me.lblBusinessType.Name = "lblBusinessType"
        Me.lblBusinessType.Size = New System.Drawing.Size(237, 43)
        Me.lblBusinessType.TabIndex = 3
        Me.lblBusinessType.Text = "Business Type"
        '
        'pcbBusinessLogo
        '
        Me.pcbBusinessLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.pcbBusinessLogo.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_conference_50
        Me.pcbBusinessLogo.Location = New System.Drawing.Point(0, 0)
        Me.pcbBusinessLogo.Name = "pcbBusinessLogo"
        Me.pcbBusinessLogo.Size = New System.Drawing.Size(144, 148)
        Me.pcbBusinessLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBusinessLogo.TabIndex = 2
        Me.pcbBusinessLogo.TabStop = False
        '
        'lblBusinessName
        '
        Me.lblBusinessName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusinessName.Location = New System.Drawing.Point(144, 13)
        Me.lblBusinessName.Name = "lblBusinessName"
        Me.lblBusinessName.Size = New System.Drawing.Size(305, 58)
        Me.lblBusinessName.TabIndex = 1
        Me.lblBusinessName.Text = "Business Name"
        '
        'FlowNewSellerRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelContent)
        Me.Name = "FlowNewSellerRequest"
        Me.Size = New System.Drawing.Size(880, 150)
        Me.PanelContent.ResumeLayout(False)
        Me.PanelContent.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pcbBusinessLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContent As Panel
    Friend WithEvents lblStoreSellerID As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnApprove As Button
    Friend WithEvents lblBusinessType As Label
    Friend WithEvents pcbBusinessLogo As PictureBox
    Friend WithEvents lblBusinessName As Label
    Friend WithEvents lblBusinessOwner As Label
End Class
