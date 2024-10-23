<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminFeedbackPage
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
        Me.flpFeedback = New System.Windows.Forms.FlowLayoutPanel()
        Me.pcbEmptyService = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.flpFeedback.SuspendLayout()
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flpFeedback
        '
        Me.flpFeedback.AutoScroll = True
        Me.flpFeedback.BackColor = System.Drawing.Color.White
        Me.flpFeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.flpFeedback.Controls.Add(Me.pcbEmptyService)
        Me.flpFeedback.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpFeedback.Location = New System.Drawing.Point(0, 0)
        Me.flpFeedback.Name = "flpFeedback"
        Me.flpFeedback.Size = New System.Drawing.Size(915, 536)
        Me.flpFeedback.TabIndex = 6
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
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_372
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnRefresh.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_refresh_32
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(137, 542)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(214, 90)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_372
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnDelete.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_delete_32
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(504, 542)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(214, 90)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmAdminFeedbackPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.flpFeedback)
        Me.Name = "frmAdminFeedbackPage"
        Me.Size = New System.Drawing.Size(915, 655)
        Me.flpFeedback.ResumeLayout(False)
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpFeedback As FlowLayoutPanel
    Friend WithEvents pcbEmptyService As PictureBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
End Class
