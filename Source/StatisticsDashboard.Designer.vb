<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatisticsDashboard
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
        Me.PanelOrder = New System.Windows.Forms.Panel()
        Me.lblAvailableOrder = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelTransaction = New System.Windows.Forms.Panel()
        Me.lblTotalTransaction = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelTotalRevenue = New System.Windows.Forms.Panel()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDailyRevenue = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblAvgRating = New System.Windows.Forms.Label()
        Me.pcbStar1 = New System.Windows.Forms.PictureBox()
        Me.pcbStar5 = New System.Windows.Forms.PictureBox()
        Me.pcbStar2 = New System.Windows.Forms.PictureBox()
        Me.pcbStar3 = New System.Windows.Forms.PictureBox()
        Me.pcbStar4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pcbTransaction = New System.Windows.Forms.PictureBox()
        Me.pcbOrder = New System.Windows.Forms.PictureBox()
        Me.PanelOrder.SuspendLayout()
        Me.PanelTransaction.SuspendLayout()
        Me.PanelTotalRevenue.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbStar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelOrder
        '
        Me.PanelOrder.BackColor = System.Drawing.Color.White
        Me.PanelOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelOrder.Controls.Add(Me.pcbOrder)
        Me.PanelOrder.Controls.Add(Me.lblAvailableOrder)
        Me.PanelOrder.Location = New System.Drawing.Point(30, 74)
        Me.PanelOrder.Name = "PanelOrder"
        Me.PanelOrder.Size = New System.Drawing.Size(279, 263)
        Me.PanelOrder.TabIndex = 0
        '
        'lblAvailableOrder
        '
        Me.lblAvailableOrder.AutoSize = True
        Me.lblAvailableOrder.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableOrder.Location = New System.Drawing.Point(115, 210)
        Me.lblAvailableOrder.Name = "lblAvailableOrder"
        Me.lblAvailableOrder.Size = New System.Drawing.Size(33, 38)
        Me.lblAvailableOrder.TabIndex = 7
        Me.lblAvailableOrder.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 38)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Customer Order"
        '
        'PanelTransaction
        '
        Me.PanelTransaction.BackColor = System.Drawing.Color.White
        Me.PanelTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTransaction.Controls.Add(Me.lblTotalTransaction)
        Me.PanelTransaction.Controls.Add(Me.pcbTransaction)
        Me.PanelTransaction.Location = New System.Drawing.Point(315, 74)
        Me.PanelTransaction.Name = "PanelTransaction"
        Me.PanelTransaction.Size = New System.Drawing.Size(286, 263)
        Me.PanelTransaction.TabIndex = 1
        '
        'lblTotalTransaction
        '
        Me.lblTotalTransaction.AutoSize = True
        Me.lblTotalTransaction.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTransaction.Location = New System.Drawing.Point(122, 210)
        Me.lblTotalTransaction.Name = "lblTotalTransaction"
        Me.lblTotalTransaction.Size = New System.Drawing.Size(33, 38)
        Me.lblTotalTransaction.TabIndex = 9
        Me.lblTotalTransaction.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(338, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(239, 38)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Transaction"
        '
        'PanelTotalRevenue
        '
        Me.PanelTotalRevenue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTotalRevenue.Controls.Add(Me.lblTotalRevenue)
        Me.PanelTotalRevenue.Controls.Add(Me.Label2)
        Me.PanelTotalRevenue.Controls.Add(Me.lblDailyRevenue)
        Me.PanelTotalRevenue.Controls.Add(Me.Label1)
        Me.PanelTotalRevenue.Controls.Add(Me.PictureBox1)
        Me.PanelTotalRevenue.Location = New System.Drawing.Point(29, 378)
        Me.PanelTotalRevenue.Name = "PanelTotalRevenue"
        Me.PanelTotalRevenue.Size = New System.Drawing.Size(849, 254)
        Me.PanelTotalRevenue.TabIndex = 1
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.AutoSize = True
        Me.lblTotalRevenue.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRevenue.Location = New System.Drawing.Point(408, 185)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(139, 38)
        Me.lblTotalRevenue.TabIndex = 5
        Me.lblTotalRevenue.Text = "0.00 MYR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 38)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Revenue"
        '
        'lblDailyRevenue
        '
        Me.lblDailyRevenue.AutoSize = True
        Me.lblDailyRevenue.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailyRevenue.Location = New System.Drawing.Point(408, 62)
        Me.lblDailyRevenue.Name = "lblDailyRevenue"
        Me.lblDailyRevenue.Size = New System.Drawing.Size(139, 38)
        Me.lblDailyRevenue.TabIndex = 3
        Me.lblDailyRevenue.Text = "0.00 MYR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Daily Revenue:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(653, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 38)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Overall Rating"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblAvgRating)
        Me.Panel1.Location = New System.Drawing.Point(607, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 263)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.pcbStar1)
        Me.Panel2.Controls.Add(Me.pcbStar5)
        Me.Panel2.Controls.Add(Me.pcbStar2)
        Me.Panel2.Controls.Add(Me.pcbStar3)
        Me.Panel2.Controls.Add(Me.pcbStar4)
        Me.Panel2.Location = New System.Drawing.Point(5, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(276, 194)
        Me.Panel2.TabIndex = 11
        '
        'lblAvgRating
        '
        Me.lblAvgRating.AutoSize = True
        Me.lblAvgRating.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgRating.Location = New System.Drawing.Point(106, 210)
        Me.lblAvgRating.Name = "lblAvgRating"
        Me.lblAvgRating.Size = New System.Drawing.Size(33, 38)
        Me.lblAvgRating.TabIndex = 7
        Me.lblAvgRating.Text = "0"
        '
        'pcbStar1
        '
        Me.pcbStar1.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar1.Location = New System.Drawing.Point(19, 30)
        Me.pcbStar1.Name = "pcbStar1"
        Me.pcbStar1.Size = New System.Drawing.Size(57, 50)
        Me.pcbStar1.TabIndex = 0
        Me.pcbStar1.TabStop = False
        '
        'pcbStar5
        '
        Me.pcbStar5.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar5.Location = New System.Drawing.Point(156, 110)
        Me.pcbStar5.Name = "pcbStar5"
        Me.pcbStar5.Size = New System.Drawing.Size(57, 50)
        Me.pcbStar5.TabIndex = 4
        Me.pcbStar5.TabStop = False
        '
        'pcbStar2
        '
        Me.pcbStar2.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar2.Location = New System.Drawing.Point(108, 30)
        Me.pcbStar2.Name = "pcbStar2"
        Me.pcbStar2.Size = New System.Drawing.Size(57, 50)
        Me.pcbStar2.TabIndex = 1
        Me.pcbStar2.TabStop = False
        '
        'pcbStar3
        '
        Me.pcbStar3.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar3.Location = New System.Drawing.Point(201, 30)
        Me.pcbStar3.Name = "pcbStar3"
        Me.pcbStar3.Size = New System.Drawing.Size(57, 50)
        Me.pcbStar3.TabIndex = 2
        Me.pcbStar3.TabStop = False
        '
        'pcbStar4
        '
        Me.pcbStar4.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar4.Location = New System.Drawing.Point(64, 110)
        Me.pcbStar4.Name = "pcbStar4"
        Me.pcbStar4.Size = New System.Drawing.Size(57, 50)
        Me.pcbStar4.TabIndex = 3
        Me.pcbStar4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.RevenueIcon
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(392, 251)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pcbTransaction
        '
        Me.pcbTransaction.BackColor = System.Drawing.Color.White
        Me.pcbTransaction.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Transaction_Animation
        Me.pcbTransaction.Location = New System.Drawing.Point(3, 3)
        Me.pcbTransaction.Name = "pcbTransaction"
        Me.pcbTransaction.Size = New System.Drawing.Size(278, 194)
        Me.pcbTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbTransaction.TabIndex = 0
        Me.pcbTransaction.TabStop = False
        '
        'pcbOrder
        '
        Me.pcbOrder.BackColor = System.Drawing.Color.White
        Me.pcbOrder.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.packaging_for_delivery
        Me.pcbOrder.Location = New System.Drawing.Point(3, 3)
        Me.pcbOrder.Name = "pcbOrder"
        Me.pcbOrder.Size = New System.Drawing.Size(271, 194)
        Me.pcbOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbOrder.TabIndex = 0
        Me.pcbOrder.TabStop = False
        '
        'frmStatisticsDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PanelTotalRevenue)
        Me.Controls.Add(Me.PanelTransaction)
        Me.Controls.Add(Me.PanelOrder)
        Me.Name = "frmStatisticsDashboard"
        Me.Size = New System.Drawing.Size(915, 650)
        Me.PanelOrder.ResumeLayout(False)
        Me.PanelOrder.PerformLayout()
        Me.PanelTransaction.ResumeLayout(False)
        Me.PanelTransaction.PerformLayout()
        Me.PanelTotalRevenue.ResumeLayout(False)
        Me.PanelTotalRevenue.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.pcbStar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelOrder As Panel
    Friend WithEvents PanelTransaction As Panel
    Friend WithEvents PanelTotalRevenue As Panel
    Friend WithEvents pcbOrder As PictureBox
    Friend WithEvents pcbTransaction As PictureBox
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDailyRevenue As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAvailableOrder As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalTransaction As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAvgRating As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pcbStar1 As PictureBox
    Friend WithEvents pcbStar5 As PictureBox
    Friend WithEvents pcbStar2 As PictureBox
    Friend WithEvents pcbStar3 As PictureBox
    Friend WithEvents pcbStar4 As PictureBox
End Class
