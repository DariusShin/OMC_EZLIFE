<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParcelCollectingDashboard
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cboWeightUTP = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.flpParcelCollect = New System.Windows.Forms.FlowLayoutPanel()
        Me.pcbEmptyService = New System.Windows.Forms.PictureBox()
        Me.PanelHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpParcelCollect.SuspendLayout()
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.Indigo
        Me.PanelHeader.Controls.Add(Me.btnSearch)
        Me.PanelHeader.Controls.Add(Me.btnReset)
        Me.PanelHeader.Controls.Add(Me.cboWeightUTP)
        Me.PanelHeader.Controls.Add(Me.PictureBox1)
        Me.PanelHeader.Controls.Add(Me.txtSearch)
        Me.PanelHeader.Controls.Add(Me.Label2)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(915, 125)
        Me.PanelHeader.TabIndex = 10
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Indigo
        Me.btnSearch.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_search_40
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(840, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 39)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Indigo
        Me.btnReset.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_sync_40
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(840, 64)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(40, 40)
        Me.btnReset.TabIndex = 7
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'cboWeightUTP
        '
        Me.cboWeightUTP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboWeightUTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWeightUTP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboWeightUTP.FormattingEnabled = True
        Me.cboWeightUTP.Items.AddRange(New Object() {"Filter", "<1kg", "1kg~3kg", ">3kg", "All Weight"})
        Me.cboWeightUTP.Location = New System.Drawing.Point(663, 66)
        Me.cboWeightUTP.Name = "cboWeightUTP"
        Me.cboWeightUTP.Size = New System.Drawing.Size(152, 36)
        Me.cboWeightUTP.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_parcel_100
        Me.PictureBox1.Location = New System.Drawing.Point(3, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtSearch.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(663, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(152, 39)
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.Text = "Search Name"
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Indigo
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(120, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(512, 81)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PARCEL COLLECT"
        '
        'flpParcelCollect
        '
        Me.flpParcelCollect.AutoScroll = True
        Me.flpParcelCollect.BackColor = System.Drawing.Color.MediumPurple
        Me.flpParcelCollect.Controls.Add(Me.pcbEmptyService)
        Me.flpParcelCollect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpParcelCollect.Location = New System.Drawing.Point(0, 125)
        Me.flpParcelCollect.Name = "flpParcelCollect"
        Me.flpParcelCollect.Size = New System.Drawing.Size(915, 475)
        Me.flpParcelCollect.TabIndex = 11
        '
        'pcbEmptyService
        '
        Me.pcbEmptyService.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_114
        Me.pcbEmptyService.Location = New System.Drawing.Point(3, 3)
        Me.pcbEmptyService.Name = "pcbEmptyService"
        Me.pcbEmptyService.Size = New System.Drawing.Size(877, 450)
        Me.pcbEmptyService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbEmptyService.TabIndex = 1
        Me.pcbEmptyService.TabStop = False
        Me.pcbEmptyService.Visible = False
        '
        'frmParcelCollectingDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.flpParcelCollect)
        Me.Controls.Add(Me.PanelHeader)
        Me.Name = "frmParcelCollectingDashboard"
        Me.Size = New System.Drawing.Size(915, 600)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpParcelCollect.ResumeLayout(False)
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents flpParcelCollect As FlowLayoutPanel
    Friend WithEvents cboWeightUTP As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents pcbEmptyService As PictureBox
End Class
