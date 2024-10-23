<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FlowOutOrderHistory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.lblStoreSellerID = New System.Windows.Forms.Label()
        Me.lblStoreServiceTypeID = New System.Windows.Forms.Label()
        Me.lblStoreServiceID = New System.Windows.Forms.Label()
        Me.lblStore = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblServiceFilter = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.btnReview = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblCompleteDateTime = New System.Windows.Forms.Label()
        Me.pcbBusinessLogo = New System.Windows.Forms.PictureBox()
        Me.lblServiceName = New System.Windows.Forms.Label()
        Me.pcbStatus = New System.Windows.Forms.PictureBox()
        Me.PanelContent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbBusinessLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContent
        '
        Me.PanelContent.BackColor = System.Drawing.Color.White
        Me.PanelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContent.Controls.Add(Me.lblStoreSellerID)
        Me.PanelContent.Controls.Add(Me.lblStoreServiceTypeID)
        Me.PanelContent.Controls.Add(Me.lblStoreServiceID)
        Me.PanelContent.Controls.Add(Me.lblStore)
        Me.PanelContent.Controls.Add(Me.lblQty)
        Me.PanelContent.Controls.Add(Me.lblPrice)
        Me.PanelContent.Controls.Add(Me.lblServiceFilter)
        Me.PanelContent.Controls.Add(Me.Panel1)
        Me.PanelContent.Controls.Add(Me.lblStatus)
        Me.PanelContent.Controls.Add(Me.lblCompleteDateTime)
        Me.PanelContent.Controls.Add(Me.pcbBusinessLogo)
        Me.PanelContent.Controls.Add(Me.lblServiceName)
        Me.PanelContent.Controls.Add(Me.pcbStatus)
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(0, 0)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(895, 150)
        Me.PanelContent.TabIndex = 2
        '
        'lblStoreSellerID
        '
        Me.lblStoreSellerID.AutoSize = True
        Me.lblStoreSellerID.Location = New System.Drawing.Point(474, 22)
        Me.lblStoreSellerID.Name = "lblStoreSellerID"
        Me.lblStoreSellerID.Size = New System.Drawing.Size(0, 16)
        Me.lblStoreSellerID.TabIndex = 12
        Me.lblStoreSellerID.Visible = False
        '
        'lblStoreServiceTypeID
        '
        Me.lblStoreServiceTypeID.AutoSize = True
        Me.lblStoreServiceTypeID.Location = New System.Drawing.Point(492, 34)
        Me.lblStoreServiceTypeID.Name = "lblStoreServiceTypeID"
        Me.lblStoreServiceTypeID.Size = New System.Drawing.Size(0, 16)
        Me.lblStoreServiceTypeID.TabIndex = 11
        Me.lblStoreServiceTypeID.Visible = False
        '
        'lblStoreServiceID
        '
        Me.lblStoreServiceID.AutoSize = True
        Me.lblStoreServiceID.Location = New System.Drawing.Point(492, 55)
        Me.lblStoreServiceID.Name = "lblStoreServiceID"
        Me.lblStoreServiceID.Size = New System.Drawing.Size(0, 16)
        Me.lblStoreServiceID.TabIndex = 10
        Me.lblStoreServiceID.Visible = False
        '
        'lblStore
        '
        Me.lblStore.AutoSize = True
        Me.lblStore.Location = New System.Drawing.Point(492, 81)
        Me.lblStore.Name = "lblStore"
        Me.lblStore.Size = New System.Drawing.Size(0, 16)
        Me.lblStore.TabIndex = 9
        Me.lblStore.Visible = False
        '
        'lblQty
        '
        Me.lblQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lblQty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.White
        Me.lblQty.Location = New System.Drawing.Point(655, 44)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(43, 34)
        Me.lblQty.TabIndex = 8
        Me.lblQty.Text = "50"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblQty.Visible = False
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(559, 2)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(139, 42)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "50 MYR"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblServiceFilter
        '
        Me.lblServiceFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceFilter.Location = New System.Drawing.Point(442, 100)
        Me.lblServiceFilter.Name = "lblServiceFilter"
        Me.lblServiceFilter.Size = New System.Drawing.Size(240, 42)
        Me.lblServiceFilter.TabIndex = 6
        Me.lblServiceFilter.Text = "Filter"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnReceipt)
        Me.Panel1.Controls.Add(Me.btnReview)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(704, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(189, 148)
        Me.Panel1.TabIndex = 5
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.Silver
        Me.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceipt.FlatAppearance.BorderSize = 0
        Me.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceipt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_receipt_24
        Me.btnReceipt.Location = New System.Drawing.Point(17, 12)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(157, 55)
        Me.btnReceipt.TabIndex = 1
        Me.btnReceipt.Text = "Receipt"
        Me.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReceipt.UseVisualStyleBackColor = False
        '
        'btnReview
        '
        Me.btnReview.BackColor = System.Drawing.Color.Khaki
        Me.btnReview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReview.FlatAppearance.BorderSize = 0
        Me.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReview.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReview.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_feedback_24
        Me.btnReview.Location = New System.Drawing.Point(17, 81)
        Me.btnReview.Name = "btnReview"
        Me.btnReview.Size = New System.Drawing.Size(157, 55)
        Me.btnReview.TabIndex = 0
        Me.btnReview.Text = "Comment"
        Me.btnReview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReview.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(150, 106)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(155, 36)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Completed..."
        '
        'lblCompleteDateTime
        '
        Me.lblCompleteDateTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompleteDateTime.Location = New System.Drawing.Point(145, 45)
        Me.lblCompleteDateTime.Name = "lblCompleteDateTime"
        Me.lblCompleteDateTime.Size = New System.Drawing.Size(329, 58)
        Me.lblCompleteDateTime.TabIndex = 3
        Me.lblCompleteDateTime.Text = "20/6/2023 21:35:00 PM"
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
        'lblServiceName
        '
        Me.lblServiceName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceName.Location = New System.Drawing.Point(144, 12)
        Me.lblServiceName.Name = "lblServiceName"
        Me.lblServiceName.Size = New System.Drawing.Size(332, 42)
        Me.lblServiceName.TabIndex = 1
        Me.lblServiceName.Text = "Service Name"
        '
        'pcbStatus
        '
        Me.pcbStatus.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_black_circle_24
        Me.pcbStatus.Location = New System.Drawing.Point(311, 106)
        Me.pcbStatus.Name = "pcbStatus"
        Me.pcbStatus.Size = New System.Drawing.Size(29, 36)
        Me.pcbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbStatus.TabIndex = 0
        Me.pcbStatus.TabStop = False
        '
        'FlowOutOrderHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelContent)
        Me.Name = "FlowOutOrderHistory"
        Me.Size = New System.Drawing.Size(895, 150)
        Me.PanelContent.ResumeLayout(False)
        Me.PanelContent.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pcbBusinessLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContent As Panel
    Friend WithEvents lblStoreSellerID As Label
    Friend WithEvents lblStoreServiceTypeID As Label
    Friend WithEvents lblStoreServiceID As Label
    Friend WithEvents lblStore As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblServiceFilter As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnReceipt As Button
    Friend WithEvents btnReview As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblCompleteDateTime As Label
    Friend WithEvents pcbBusinessLogo As PictureBox
    Friend WithEvents lblServiceName As Label
    Friend WithEvents pcbStatus As PictureBox
End Class
