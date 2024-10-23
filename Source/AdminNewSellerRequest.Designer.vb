<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminNewSellerRequest
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
        Me.flpNewSellerRequest = New System.Windows.Forms.FlowLayoutPanel()
        Me.pcbEmptyService = New System.Windows.Forms.PictureBox()
        Me.flpNewSellerRequest.SuspendLayout()
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flpNewSellerRequest
        '
        Me.flpNewSellerRequest.Controls.Add(Me.pcbEmptyService)
        Me.flpNewSellerRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpNewSellerRequest.Location = New System.Drawing.Point(0, 0)
        Me.flpNewSellerRequest.Name = "flpNewSellerRequest"
        Me.flpNewSellerRequest.Size = New System.Drawing.Size(1000, 715)
        Me.flpNewSellerRequest.TabIndex = 0
        '
        'pcbEmptyService
        '
        Me.pcbEmptyService.BackColor = System.Drawing.Color.White
        Me.pcbEmptyService.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_114
        Me.pcbEmptyService.Location = New System.Drawing.Point(3, 3)
        Me.pcbEmptyService.Name = "pcbEmptyService"
        Me.pcbEmptyService.Size = New System.Drawing.Size(926, 555)
        Me.pcbEmptyService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbEmptyService.TabIndex = 6
        Me.pcbEmptyService.TabStop = False
        Me.pcbEmptyService.Visible = False
        '
        'frmAdminNewSellerRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.flpNewSellerRequest)
        Me.Name = "frmAdminNewSellerRequest"
        Me.Size = New System.Drawing.Size(1000, 715)
        Me.flpNewSellerRequest.ResumeLayout(False)
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpNewSellerRequest As FlowLayoutPanel
    Friend WithEvents pcbEmptyService As PictureBox
End Class
