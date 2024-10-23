<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuyerHistory
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
        Me.flpOrderHistory = New System.Windows.Forms.FlowLayoutPanel()
        Me.dtpCompleteOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelTab = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.PanelTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flpOrderHistory
        '
        Me.flpOrderHistory.AutoScroll = True
        Me.flpOrderHistory.BackColor = System.Drawing.Color.White
        Me.flpOrderHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.flpOrderHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpOrderHistory.Location = New System.Drawing.Point(0, 84)
        Me.flpOrderHistory.Name = "flpOrderHistory"
        Me.flpOrderHistory.Size = New System.Drawing.Size(915, 516)
        Me.flpOrderHistory.TabIndex = 0
        '
        'dtpCompleteOrderDate
        '
        Me.dtpCompleteOrderDate.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCompleteOrderDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCompleteOrderDate.CustomFormat = "MM/dd/yy"
        Me.dtpCompleteOrderDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCompleteOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCompleteOrderDate.Location = New System.Drawing.Point(588, 21)
        Me.dtpCompleteOrderDate.Name = "dtpCompleteOrderDate"
        Me.dtpCompleteOrderDate.Size = New System.Drawing.Size(184, 34)
        Me.dtpCompleteOrderDate.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(389, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 31)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Complete Date :"
        '
        'PanelTab
        '
        Me.PanelTab.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelTab.Controls.Add(Me.PictureBox1)
        Me.PanelTab.Controls.Add(Me.Label2)
        Me.PanelTab.Controls.Add(Me.dtpCompleteOrderDate)
        Me.PanelTab.Controls.Add(Me.btnSearch)
        Me.PanelTab.Controls.Add(Me.Label1)
        Me.PanelTab.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTab.Location = New System.Drawing.Point(0, 0)
        Me.PanelTab.Name = "PanelTab"
        Me.PanelTab.Size = New System.Drawing.Size(915, 84)
        Me.PanelTab.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_history_50
        Me.PictureBox1.Location = New System.Drawing.Point(248, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 67)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "HISTORY"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSearch.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_search_40
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch.Location = New System.Drawing.Point(790, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(36, 34)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'frmBuyerHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.Controls.Add(Me.flpOrderHistory)
        Me.Controls.Add(Me.PanelTab)
        Me.Name = "frmBuyerHistory"
        Me.Size = New System.Drawing.Size(915, 600)
        Me.PanelTab.ResumeLayout(False)
        Me.PanelTab.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpOrderHistory As FlowLayoutPanel
    Friend WithEvents btnSearch As Button
    Friend WithEvents dtpCompleteOrderDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelTab As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
