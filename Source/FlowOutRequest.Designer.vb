<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlowOutAvailableService
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
        Me.lblStore = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblServiceFilter = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnViewMore = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblOperationDateTime = New System.Windows.Forms.Label()
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
        Me.PanelContent.Controls.Add(Me.lblStore)
        Me.PanelContent.Controls.Add(Me.lblQty)
        Me.PanelContent.Controls.Add(Me.lblPrice)
        Me.PanelContent.Controls.Add(Me.lblServiceFilter)
        Me.PanelContent.Controls.Add(Me.Panel1)
        Me.PanelContent.Controls.Add(Me.lblStatus)
        Me.PanelContent.Controls.Add(Me.lblOperationDateTime)
        Me.PanelContent.Controls.Add(Me.pcbBusinessLogo)
        Me.PanelContent.Controls.Add(Me.lblServiceName)
        Me.PanelContent.Controls.Add(Me.pcbStatus)
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(0, 0)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(894, 150)
        Me.PanelContent.TabIndex = 0
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
        Me.lblQty.Location = New System.Drawing.Point(654, 44)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(65, 34)
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
        Me.lblPrice.Location = New System.Drawing.Point(550, 2)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(169, 42)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "50 MYR"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblServiceFilter
        '
        Me.lblServiceFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceFilter.Location = New System.Drawing.Point(413, 100)
        Me.lblServiceFilter.Name = "lblServiceFilter"
        Me.lblServiceFilter.Size = New System.Drawing.Size(306, 42)
        Me.lblServiceFilter.TabIndex = 6
        Me.lblServiceFilter.Text = "Filter"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPay)
        Me.Panel1.Controls.Add(Me.btnViewMore)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(735, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(157, 148)
        Me.Panel1.TabIndex = 5
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.Thistle
        Me.btnPay.FlatAppearance.BorderSize = 0
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_card_payment_30
        Me.btnPay.Location = New System.Drawing.Point(15, 83)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(128, 49)
        Me.btnPay.TabIndex = 1
        Me.btnPay.Text = "Buy"
        Me.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btnViewMore
        '
        Me.btnViewMore.BackColor = System.Drawing.Color.LightSalmon
        Me.btnViewMore.FlatAppearance.BorderSize = 0
        Me.btnViewMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewMore.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewMore.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_search_property_30
        Me.btnViewMore.Location = New System.Drawing.Point(15, 12)
        Me.btnViewMore.Name = "btnViewMore"
        Me.btnViewMore.Size = New System.Drawing.Size(128, 55)
        Me.btnViewMore.TabIndex = 0
        Me.btnViewMore.Text = "View"
        Me.btnViewMore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnViewMore.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(150, 106)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(155, 36)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Preparing..."
        '
        'lblOperationDateTime
        '
        Me.lblOperationDateTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperationDateTime.Location = New System.Drawing.Point(145, 45)
        Me.lblOperationDateTime.Name = "lblOperationDateTime"
        Me.lblOperationDateTime.Size = New System.Drawing.Size(329, 58)
        Me.lblOperationDateTime.TabIndex = 3
        Me.lblOperationDateTime.Text = "20/6/2023 21:35:00 PM"
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
        'FlowOutAvailableService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelContent)
        Me.Name = "FlowOutAvailableService"
        Me.Size = New System.Drawing.Size(894, 150)
        Me.PanelContent.ResumeLayout(False)
        Me.PanelContent.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pcbBusinessLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContent As Panel
    Friend WithEvents pcbStatus As PictureBox
    Friend WithEvents pcbBusinessLogo As PictureBox
    Friend WithEvents lblServiceName As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblOperationDateTime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPay As Button
    Friend WithEvents btnViewMore As Button
    Friend WithEvents lblServiceFilter As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents lblStore As Label
End Class
