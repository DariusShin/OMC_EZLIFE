<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFoodOrderDashboard
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboFoodType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.flpFoodOrder = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pcbEmptyService = New System.Windows.Forms.PictureBox()
        Me.PanelHeader.SuspendLayout()
        Me.flpFoodOrder.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.Coral
        Me.PanelHeader.Controls.Add(Me.btnSearch)
        Me.PanelHeader.Controls.Add(Me.btnReset)
        Me.PanelHeader.Controls.Add(Me.PictureBox1)
        Me.PanelHeader.Controls.Add(Me.txtSearch)
        Me.PanelHeader.Controls.Add(Me.cboFoodType)
        Me.PanelHeader.Controls.Add(Me.Label2)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(915, 125)
        Me.PanelHeader.TabIndex = 9
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
        'cboFoodType
        '
        Me.cboFoodType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboFoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFoodType.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFoodType.FormattingEnabled = True
        Me.cboFoodType.Items.AddRange(New Object() {"Filter", "Food", "Beverage", "Dessert"})
        Me.cboFoodType.Location = New System.Drawing.Point(659, 67)
        Me.cboFoodType.Name = "cboFoodType"
        Me.cboFoodType.Size = New System.Drawing.Size(152, 40)
        Me.cboFoodType.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Coral
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(143, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(487, 93)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "FOOD ORDER"
        '
        'flpFoodOrder
        '
        Me.flpFoodOrder.AutoScroll = True
        Me.flpFoodOrder.BackColor = System.Drawing.Color.LightYellow
        Me.flpFoodOrder.Controls.Add(Me.pcbEmptyService)
        Me.flpFoodOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpFoodOrder.Location = New System.Drawing.Point(0, 125)
        Me.flpFoodOrder.Name = "flpFoodOrder"
        Me.flpFoodOrder.Size = New System.Drawing.Size(915, 475)
        Me.flpFoodOrder.TabIndex = 10
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Coral
        Me.btnSearch.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_search_40
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(828, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 39)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Coral
        Me.btnReset.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_sync_40
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(828, 65)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(40, 40)
        Me.btnReset.TabIndex = 5
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_refreshments_100
        Me.PictureBox1.Location = New System.Drawing.Point(16, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
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
        'frmFoodOrderDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.flpFoodOrder)
        Me.Controls.Add(Me.PanelHeader)
        Me.Name = "frmFoodOrderDashboard"
        Me.Size = New System.Drawing.Size(915, 600)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.flpFoodOrder.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbEmptyService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cboFoodType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents flpFoodOrder As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents pcbEmptyService As PictureBox
End Class
