<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuyerServices
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
        Me.pcbOthers = New System.Windows.Forms.PictureBox()
        Me.pcbFoodOrders = New System.Windows.Forms.PictureBox()
        Me.pcbCarRental = New System.Windows.Forms.PictureBox()
        Me.pcbCarPool = New System.Windows.Forms.PictureBox()
        Me.lblCarPool = New System.Windows.Forms.Label()
        Me.lblFoodOrdering = New System.Windows.Forms.Label()
        Me.lblCarRental = New System.Windows.Forms.Label()
        Me.lblParcelCollect = New System.Windows.Forms.Label()
        CType(Me.pcbOthers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbFoodOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbCarRental, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbCarPool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbOthers
        '
        Me.pcbOthers.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pcbOthers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbOthers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbOthers.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources._23211_receive_order_unscreen
        Me.pcbOthers.Location = New System.Drawing.Point(483, 328)
        Me.pcbOthers.Name = "pcbOthers"
        Me.pcbOthers.Size = New System.Drawing.Size(352, 217)
        Me.pcbOthers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcbOthers.TabIndex = 3
        Me.pcbOthers.TabStop = False
        '
        'pcbFoodOrders
        '
        Me.pcbFoodOrders.BackColor = System.Drawing.Color.White
        Me.pcbFoodOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbFoodOrders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbFoodOrders.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.food2
        Me.pcbFoodOrders.Location = New System.Drawing.Point(483, 31)
        Me.pcbFoodOrders.Name = "pcbFoodOrders"
        Me.pcbFoodOrders.Size = New System.Drawing.Size(352, 252)
        Me.pcbFoodOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbFoodOrders.TabIndex = 2
        Me.pcbFoodOrders.TabStop = False
        '
        'pcbCarRental
        '
        Me.pcbCarRental.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pcbCarRental.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbCarRental.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbCarRental.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.output_onlinegiftools__1_
        Me.pcbCarRental.Location = New System.Drawing.Point(59, 328)
        Me.pcbCarRental.Name = "pcbCarRental"
        Me.pcbCarRental.Size = New System.Drawing.Size(352, 256)
        Me.pcbCarRental.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbCarRental.TabIndex = 1
        Me.pcbCarRental.TabStop = False
        '
        'pcbCarPool
        '
        Me.pcbCarPool.BackColor = System.Drawing.Color.Teal
        Me.pcbCarPool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbCarPool.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbCarPool.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.output_onlinegiftools
        Me.pcbCarPool.Location = New System.Drawing.Point(59, 31)
        Me.pcbCarPool.Name = "pcbCarPool"
        Me.pcbCarPool.Size = New System.Drawing.Size(352, 252)
        Me.pcbCarPool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbCarPool.TabIndex = 0
        Me.pcbCarPool.TabStop = False
        '
        'lblCarPool
        '
        Me.lblCarPool.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lblCarPool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCarPool.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCarPool.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarPool.ForeColor = System.Drawing.Color.White
        Me.lblCarPool.Location = New System.Drawing.Point(59, 246)
        Me.lblCarPool.Name = "lblCarPool"
        Me.lblCarPool.Size = New System.Drawing.Size(352, 54)
        Me.lblCarPool.TabIndex = 4
        Me.lblCarPool.Text = "Car Pooling"
        Me.lblCarPool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodOrdering
        '
        Me.lblFoodOrdering.BackColor = System.Drawing.Color.Tomato
        Me.lblFoodOrdering.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFoodOrdering.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFoodOrdering.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFoodOrdering.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodOrdering.ForeColor = System.Drawing.Color.White
        Me.lblFoodOrdering.Location = New System.Drawing.Point(483, 246)
        Me.lblFoodOrdering.Name = "lblFoodOrdering"
        Me.lblFoodOrdering.Size = New System.Drawing.Size(352, 54)
        Me.lblFoodOrdering.TabIndex = 5
        Me.lblFoodOrdering.Text = "Food Ordering"
        Me.lblFoodOrdering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCarRental
        '
        Me.lblCarRental.BackColor = System.Drawing.Color.SteelBlue
        Me.lblCarRental.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCarRental.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarRental.ForeColor = System.Drawing.Color.White
        Me.lblCarRental.Location = New System.Drawing.Point(59, 545)
        Me.lblCarRental.Name = "lblCarRental"
        Me.lblCarRental.Size = New System.Drawing.Size(352, 54)
        Me.lblCarRental.TabIndex = 6
        Me.lblCarRental.Text = "Car Rental"
        Me.lblCarRental.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParcelCollect
        '
        Me.lblParcelCollect.BackColor = System.Drawing.Color.MediumPurple
        Me.lblParcelCollect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblParcelCollect.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParcelCollect.ForeColor = System.Drawing.Color.White
        Me.lblParcelCollect.Location = New System.Drawing.Point(483, 545)
        Me.lblParcelCollect.Name = "lblParcelCollect"
        Me.lblParcelCollect.Size = New System.Drawing.Size(352, 54)
        Me.lblParcelCollect.TabIndex = 7
        Me.lblParcelCollect.Text = "Parcel Collecting"
        Me.lblParcelCollect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBuyerServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources._removal_ai__tmp_648ee6a305f16
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.lblParcelCollect)
        Me.Controls.Add(Me.lblCarRental)
        Me.Controls.Add(Me.lblFoodOrdering)
        Me.Controls.Add(Me.lblCarPool)
        Me.Controls.Add(Me.pcbOthers)
        Me.Controls.Add(Me.pcbFoodOrders)
        Me.Controls.Add(Me.pcbCarRental)
        Me.Controls.Add(Me.pcbCarPool)
        Me.DoubleBuffered = True
        Me.Name = "frmBuyerServices"
        Me.Size = New System.Drawing.Size(915, 645)
        CType(Me.pcbOthers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbFoodOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbCarRental, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbCarPool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbCarPool As PictureBox
    Friend WithEvents pcbCarRental As PictureBox
    Friend WithEvents pcbFoodOrders As PictureBox
    Friend WithEvents pcbOthers As PictureBox
    Friend WithEvents lblCarPool As Label
    Friend WithEvents lblFoodOrdering As Label
    Friend WithEvents lblCarRental As Label
    Friend WithEvents lblParcelCollect As Label
End Class
