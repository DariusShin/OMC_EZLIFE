<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCarPoolDashboard
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboInOutUTP = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flpCarPool = New System.Windows.Forms.FlowLayoutPanel()
        Me.pcbEmptyService = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.PanelHeader.SuspendLayout()
        Me.flpCarPool.SuspendLayout()
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelHeader.Controls.Add(Me.btnSearch)
        Me.PanelHeader.Controls.Add(Me.PictureBox1)
        Me.PanelHeader.Controls.Add(Me.txtSearch)
        Me.PanelHeader.Controls.Add(Me.btnReset)
        Me.PanelHeader.Controls.Add(Me.cboInOutUTP)
        Me.PanelHeader.Controls.Add(Me.Label1)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(915, 125)
        Me.PanelHeader.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtSearch.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(659, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(152, 39)
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.Text = "Search Name"
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboInOutUTP
        '
        Me.cboInOutUTP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboInOutUTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInOutUTP.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInOutUTP.FormattingEnabled = True
        Me.cboInOutUTP.Items.AddRange(New Object() {"Filter", "In UTP", "Outside UTP"})
        Me.cboInOutUTP.Location = New System.Drawing.Point(659, 67)
        Me.cboInOutUTP.Name = "cboInOutUTP"
        Me.cboInOutUTP.Size = New System.Drawing.Size(152, 40)
        Me.cboInOutUTP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaGreen
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 44.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(196, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 99)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CAR POOL"
        '
        'flpCarPool
        '
        Me.flpCarPool.AutoScroll = True
        Me.flpCarPool.BackColor = System.Drawing.Color.MediumAquamarine
        Me.flpCarPool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.flpCarPool.Controls.Add(Me.pcbEmptyService)
        Me.flpCarPool.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpCarPool.Location = New System.Drawing.Point(0, 125)
        Me.flpCarPool.Name = "flpCarPool"
        Me.flpCarPool.Size = New System.Drawing.Size(915, 475)
        Me.flpCarPool.TabIndex = 1
        '
        'pcbEmptyService
        '
        Me.pcbEmptyService.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_114
        Me.pcbEmptyService.Location = New System.Drawing.Point(3, 3)
        Me.pcbEmptyService.Name = "pcbEmptyService"
        Me.pcbEmptyService.Size = New System.Drawing.Size(879, 451)
        Me.pcbEmptyService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbEmptyService.TabIndex = 0
        Me.pcbEmptyService.TabStop = False
        Me.pcbEmptyService.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSearch.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_search_40
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(828, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 39)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_car_100
        Me.PictureBox1.Location = New System.Drawing.Point(17, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.SeaGreen
        Me.btnReset.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_sync_40
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(828, 65)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(40, 40)
        Me.btnReset.TabIndex = 1
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'frmCarPoolDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.flpCarPool)
        Me.Controls.Add(Me.PanelHeader)
        Me.Name = "frmCarPoolDashboard"
        Me.Size = New System.Drawing.Size(915, 600)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.flpCarPool.ResumeLayout(False)
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cboInOutUTP As ComboBox
    Friend WithEvents btnReset As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents flpCarPool As FlowLayoutPanel
    Friend WithEvents btnSearch As Button
    Friend WithEvents pcbEmptyService As PictureBox
End Class
