<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSellerAddNewService
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
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.btnAddServices = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.flpExistService = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelButton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelButton
        '
        Me.PanelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.PanelButton.Controls.Add(Me.btnAddServices)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelButton.Location = New System.Drawing.Point(0, 501)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(940, 160)
        Me.PanelButton.TabIndex = 0
        '
        'btnAddServices
        '
        Me.btnAddServices.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_372
        Me.btnAddServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddServices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddServices.FlatAppearance.BorderSize = 0
        Me.btnAddServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddServices.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddServices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnAddServices.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_add_32
        Me.btnAddServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddServices.Location = New System.Drawing.Point(15, 53)
        Me.btnAddServices.Name = "btnAddServices"
        Me.btnAddServices.Size = New System.Drawing.Size(181, 88)
        Me.btnAddServices.TabIndex = 2
        Me.btnAddServices.Text = "Add"
        Me.btnAddServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddServices.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAddServices.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.flpExistService)
        Me.Panel1.Controls.Add(Me.PanelButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(940, 661)
        Me.Panel1.TabIndex = 2
        '
        'flpExistService
        '
        Me.flpExistService.AutoScroll = True
        Me.flpExistService.BackColor = System.Drawing.Color.White
        Me.flpExistService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.flpExistService.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpExistService.Location = New System.Drawing.Point(0, 0)
        Me.flpExistService.Name = "flpExistService"
        Me.flpExistService.Size = New System.Drawing.Size(940, 536)
        Me.flpExistService.TabIndex = 4
        '
        'frmSellerAddNewService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSellerAddNewService"
        Me.Size = New System.Drawing.Size(940, 661)
        Me.PanelButton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelButton As Panel
    Friend WithEvents btnAddServices As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents flpExistService As FlowLayoutPanel
End Class
