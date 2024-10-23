<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuyerComment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuyerComment))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblStoredServiceID = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pcbClosePayment = New System.Windows.Forms.PictureBox()
        Me.PanelComment = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbClosePayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblStoredServiceID)
        Me.Panel2.Controls.Add(Me.pcbClosePayment)
        Me.Panel2.Controls.Add(Me.lblHeader)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(915, 45)
        Me.Panel2.TabIndex = 34
        '
        'lblStoredServiceID
        '
        Me.lblStoredServiceID.AutoSize = True
        Me.lblStoredServiceID.Location = New System.Drawing.Point(50, 13)
        Me.lblStoredServiceID.Name = "lblStoredServiceID"
        Me.lblStoredServiceID.Size = New System.Drawing.Size(0, 16)
        Me.lblStoredServiceID.TabIndex = 6
        Me.lblStoredServiceID.Visible = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Black
        Me.lblHeader.Location = New System.Drawing.Point(300, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(284, 42)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Comment on Service"
        '
        'pcbClosePayment
        '
        Me.pcbClosePayment.Dock = System.Windows.Forms.DockStyle.Right
        Me.pcbClosePayment.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_close_48
        Me.pcbClosePayment.Location = New System.Drawing.Point(870, 0)
        Me.pcbClosePayment.Name = "pcbClosePayment"
        Me.pcbClosePayment.Size = New System.Drawing.Size(45, 45)
        Me.pcbClosePayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbClosePayment.TabIndex = 5
        Me.pcbClosePayment.TabStop = False
        '
        'PanelComment
        '
        Me.PanelComment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelComment.Location = New System.Drawing.Point(0, 45)
        Me.PanelComment.Name = "PanelComment"
        Me.PanelComment.Size = New System.Drawing.Size(915, 608)
        Me.PanelComment.TabIndex = 35
        '
        'frmBuyerComment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 653)
        Me.Controls.Add(Me.PanelComment)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuyerComment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuyerComment"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcbClosePayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblStoredServiceID As Label
    Friend WithEvents pcbClosePayment As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents PanelComment As Panel
End Class
