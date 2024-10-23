<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowOutRequest1 = New OMC_EZLIFE_May2023.FlowOutAvailableService()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dtpEndOperationDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartOperationDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDisplayServices = New System.Windows.Forms.Button()
        Me.lblDayDifference = New System.Windows.Forms.Label()
        Me.cboHourStart = New System.Windows.Forms.ComboBox()
        Me.cboHourEnd = New System.Windows.Forms.ComboBox()
        Me.cboMinuteStart = New System.Windows.Forms.ComboBox()
        Me.cboMinuteEnd = New System.Windows.Forms.ComboBox()
        Me.cboDayNightStart = New System.Windows.Forms.ComboBox()
        Me.cboDayNightEnd = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDifference = New System.Windows.Forms.Button()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowOutRequest1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(800, 433)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'FlowOutRequest1
        '
        Me.FlowOutRequest1.Location = New System.Drawing.Point(3, 3)
        Me.FlowOutRequest1.Name = "FlowOutRequest1"
        Me.FlowOutRequest1.Size = New System.Drawing.Size(785, 150)
        Me.FlowOutRequest1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'dtpEndOperationDate
        '
        Me.dtpEndOperationDate.CustomFormat = "MM/dd/yy"
        Me.dtpEndOperationDate.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndOperationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndOperationDate.Location = New System.Drawing.Point(13, 12)
        Me.dtpEndOperationDate.Name = "dtpEndOperationDate"
        Me.dtpEndOperationDate.Size = New System.Drawing.Size(108, 39)
        Me.dtpEndOperationDate.TabIndex = 3
        '
        'dtpStartOperationDate
        '
        Me.dtpStartOperationDate.CalendarFont = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartOperationDate.CustomFormat = "MM/dd/yy"
        Me.dtpStartOperationDate.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartOperationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartOperationDate.Location = New System.Drawing.Point(13, 9)
        Me.dtpStartOperationDate.Name = "dtpStartOperationDate"
        Me.dtpStartOperationDate.Size = New System.Drawing.Size(108, 39)
        Me.dtpStartOperationDate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 481)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Start Operation Hours "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 565)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "End Operation Hours"
        '
        'btnDisplayServices
        '
        Me.btnDisplayServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayServices.Location = New System.Drawing.Point(304, 633)
        Me.btnDisplayServices.Name = "btnDisplayServices"
        Me.btnDisplayServices.Size = New System.Drawing.Size(139, 54)
        Me.btnDisplayServices.TabIndex = 7
        Me.btnDisplayServices.Text = "Display"
        Me.btnDisplayServices.UseVisualStyleBackColor = True
        '
        'lblDayDifference
        '
        Me.lblDayDifference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDayDifference.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayDifference.Location = New System.Drawing.Point(195, 703)
        Me.lblDayDifference.Name = "lblDayDifference"
        Me.lblDayDifference.Size = New System.Drawing.Size(294, 43)
        Me.lblDayDifference.TabIndex = 8
        Me.lblDayDifference.Text = "Label3"
        Me.lblDayDifference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboHourStart
        '
        Me.cboHourStart.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHourStart.FormattingEnabled = True
        Me.cboHourStart.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cboHourStart.Location = New System.Drawing.Point(144, 9)
        Me.cboHourStart.Name = "cboHourStart"
        Me.cboHourStart.Size = New System.Drawing.Size(60, 40)
        Me.cboHourStart.TabIndex = 9
        '
        'cboHourEnd
        '
        Me.cboHourEnd.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHourEnd.FormattingEnabled = True
        Me.cboHourEnd.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cboHourEnd.Location = New System.Drawing.Point(144, 11)
        Me.cboHourEnd.Name = "cboHourEnd"
        Me.cboHourEnd.Size = New System.Drawing.Size(60, 40)
        Me.cboHourEnd.TabIndex = 10
        '
        'cboMinuteStart
        '
        Me.cboMinuteStart.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMinuteStart.FormattingEnabled = True
        Me.cboMinuteStart.Items.AddRange(New Object() {"00", "30"})
        Me.cboMinuteStart.Location = New System.Drawing.Point(209, 9)
        Me.cboMinuteStart.Name = "cboMinuteStart"
        Me.cboMinuteStart.Size = New System.Drawing.Size(60, 40)
        Me.cboMinuteStart.TabIndex = 11
        '
        'cboMinuteEnd
        '
        Me.cboMinuteEnd.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMinuteEnd.FormattingEnabled = True
        Me.cboMinuteEnd.Items.AddRange(New Object() {"00", "30"})
        Me.cboMinuteEnd.Location = New System.Drawing.Point(210, 11)
        Me.cboMinuteEnd.Name = "cboMinuteEnd"
        Me.cboMinuteEnd.Size = New System.Drawing.Size(60, 40)
        Me.cboMinuteEnd.TabIndex = 12
        '
        'cboDayNightStart
        '
        Me.cboDayNightStart.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDayNightStart.FormattingEnabled = True
        Me.cboDayNightStart.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboDayNightStart.Location = New System.Drawing.Point(276, 9)
        Me.cboDayNightStart.Name = "cboDayNightStart"
        Me.cboDayNightStart.Size = New System.Drawing.Size(60, 40)
        Me.cboDayNightStart.TabIndex = 13
        '
        'cboDayNightEnd
        '
        Me.cboDayNightEnd.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDayNightEnd.FormattingEnabled = True
        Me.cboDayNightEnd.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboDayNightEnd.Location = New System.Drawing.Point(276, 11)
        Me.cboDayNightEnd.Name = "cboDayNightEnd"
        Me.cboDayNightEnd.Size = New System.Drawing.Size(60, 40)
        Me.cboDayNightEnd.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboDayNightStart)
        Me.Panel1.Controls.Add(Me.cboHourStart)
        Me.Panel1.Controls.Add(Me.cboMinuteStart)
        Me.Panel1.Controls.Add(Me.dtpStartOperationDate)
        Me.Panel1.Location = New System.Drawing.Point(356, 462)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 65)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtpEndOperationDate)
        Me.Panel2.Controls.Add(Me.cboHourEnd)
        Me.Panel2.Controls.Add(Me.cboDayNightEnd)
        Me.Panel2.Controls.Add(Me.cboMinuteEnd)
        Me.Panel2.Location = New System.Drawing.Point(356, 543)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(351, 65)
        Me.Panel2.TabIndex = 16
        '
        'btnDifference
        '
        Me.btnDifference.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDifference.Location = New System.Drawing.Point(104, 633)
        Me.btnDifference.Name = "btnDifference"
        Me.btnDifference.Size = New System.Drawing.Size(139, 54)
        Me.btnDifference.TabIndex = 17
        Me.btnDifference.Text = "Different"
        Me.btnDifference.UseVisualStyleBackColor = True
        '
        'btnStatus
        '
        Me.btnStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatus.Location = New System.Drawing.Point(500, 633)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(139, 54)
        Me.btnStatus.TabIndex = 18
        Me.btnStatus.Text = "Status"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'test1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 759)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.btnDifference)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDayDifference)
        Me.Controls.Add(Me.btnDisplayServices)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "test1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "test1"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dtpStartOperationDate As DateTimePicker
    Friend WithEvents dtpEndOperationDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDisplayServices As Button
    Friend WithEvents lblDayDifference As Label
    Friend WithEvents cboHourStart As ComboBox
    Friend WithEvents cboHourEnd As ComboBox
    Friend WithEvents cboMinuteStart As ComboBox
    Friend WithEvents cboMinuteEnd As ComboBox
    Friend WithEvents cboDayNightStart As ComboBox
    Friend WithEvents cboDayNightEnd As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowOutRequest1 As FlowOutAvailableService
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDifference As Button
    Friend WithEvents btnStatus As Button
End Class
