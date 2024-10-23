<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuyerProgress
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
        Me.flpBuyerOrder = New System.Windows.Forms.FlowLayoutPanel()
        Me.pcbEmptyService = New System.Windows.Forms.PictureBox()
        Me.flpBuyerOrder.SuspendLayout()
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flpBuyerOrder
        '
        Me.flpBuyerOrder.AutoScroll = True
        Me.flpBuyerOrder.BackColor = System.Drawing.Color.White
        Me.flpBuyerOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.flpBuyerOrder.Controls.Add(Me.pcbEmptyService)
        Me.flpBuyerOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpBuyerOrder.Location = New System.Drawing.Point(0, 0)
        Me.flpBuyerOrder.Name = "flpBuyerOrder"
        Me.flpBuyerOrder.Size = New System.Drawing.Size(915, 600)
        Me.flpBuyerOrder.TabIndex = 0
        '
        'pcbEmptyService
        '
        Me.pcbEmptyService.BackColor = System.Drawing.Color.White
        Me.pcbEmptyService.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_114
        Me.pcbEmptyService.Location = New System.Drawing.Point(3, 3)
        Me.pcbEmptyService.Name = "pcbEmptyService"
        Me.pcbEmptyService.Size = New System.Drawing.Size(895, 523)
        Me.pcbEmptyService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbEmptyService.TabIndex = 6
        Me.pcbEmptyService.TabStop = False
        Me.pcbEmptyService.Visible = False
        '
        'frmBuyerProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.flpBuyerOrder)
        Me.Name = "frmBuyerProgress"
        Me.Size = New System.Drawing.Size(915, 600)
        Me.flpBuyerOrder.ResumeLayout(False)
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpBuyerOrder As FlowLayoutPanel
    Friend WithEvents pcbEmptyService As PictureBox
End Class
