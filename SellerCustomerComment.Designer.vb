<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSellerCustomerComment
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
        Me.flpComment = New System.Windows.Forms.FlowLayoutPanel()
        Me.pcbEmptyService = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.flpComment.SuspendLayout()
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flpComment
        '
        Me.flpComment.AutoScroll = True
        Me.flpComment.BackColor = System.Drawing.Color.White
        Me.flpComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.flpComment.Controls.Add(Me.pcbEmptyService)
        Me.flpComment.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpComment.Location = New System.Drawing.Point(0, 0)
        Me.flpComment.Name = "flpComment"
        Me.flpComment.Size = New System.Drawing.Size(915, 536)
        Me.flpComment.TabIndex = 5
        '
        'pcbEmptyService
        '
        Me.pcbEmptyService.BackColor = System.Drawing.Color.White
        Me.pcbEmptyService.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_114
        Me.pcbEmptyService.Location = New System.Drawing.Point(3, 3)
        Me.pcbEmptyService.Name = "pcbEmptyService"
        Me.pcbEmptyService.Size = New System.Drawing.Size(895, 523)
        Me.pcbEmptyService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbEmptyService.TabIndex = 5
        Me.pcbEmptyService.TabStop = False
        Me.pcbEmptyService.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_372
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnDelete.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_delete_32
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(534, 542)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(214, 90)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_372
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnRefresh.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_refresh_32
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(167, 542)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(214, 90)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'frmSellerCustomerComment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.flpComment)
        Me.Name = "frmSellerCustomerComment"
        Me.Size = New System.Drawing.Size(915, 650)
        Me.flpComment.ResumeLayout(False)
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpComment As FlowLayoutPanel
    Friend WithEvents btnDelete As Button
    Friend WithEvents pcbEmptyService As PictureBox
    Friend WithEvents btnRefresh As Button
End Class
