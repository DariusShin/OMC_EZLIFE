<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSellerNewCarRentalService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSellerNewCarRentalService))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpEndOperationDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboHourEnd = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDayNightEnd = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboMinuteEnd = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboDayNightStart = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboHourStart = New System.Windows.Forms.ComboBox()
        Me.dtpStartOperationDate = New System.Windows.Forms.DateTimePicker()
        Me.cboMinuteStart = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtRentalPrice = New System.Windows.Forms.TextBox()
        Me.txtServiceName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtFullDay = New System.Windows.Forms.RadioButton()
        Me.rbtHourly = New System.Windows.Forms.RadioButton()
        Me.rbtHalfDay = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelHour1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAvailableHours = New System.Windows.Forms.TextBox()
        Me.lblHourly1 = New System.Windows.Forms.Label()
        Me.lblHourly2 = New System.Windows.Forms.Label()
        Me.OpenFileDialogCarPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.lblValidation = New System.Windows.Forms.Label()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.pcbCarPhoto = New System.Windows.Forms.PictureBox()
        Me.pcbExit = New System.Windows.Forms.PictureBox()
        Me.lblStoreCarPoolID = New System.Windows.Forms.Label()
        Me.lblStoreCarRentalID = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbCarPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Sans Serif Collection", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(1001, 50)
        Me.lblHeader.TabIndex = 54
        Me.lblHeader.Text = "New Car Rental Service"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(101, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(210, 54)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Car Photo"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.dtpEndOperationDate)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cboHourEnd)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cboDayNightEnd)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.cboMinuteEnd)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.cboDayNightStart)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.cboHourStart)
        Me.Panel2.Controls.Add(Me.dtpStartOperationDate)
        Me.Panel2.Controls.Add(Me.cboMinuteStart)
        Me.Panel2.Location = New System.Drawing.Point(418, 428)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(554, 237)
        Me.Panel2.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(293, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "End Operation Date and Time"
        '
        'dtpEndOperationDate
        '
        Me.dtpEndOperationDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpEndOperationDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpEndOperationDate.CustomFormat = "MM/dd/yy"
        Me.dtpEndOperationDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndOperationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndOperationDate.Location = New System.Drawing.Point(102, 165)
        Me.dtpEndOperationDate.Name = "dtpEndOperationDate"
        Me.dtpEndOperationDate.Size = New System.Drawing.Size(165, 34)
        Me.dtpEndOperationDate.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(305, 28)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Start Operation Date and Time"
        '
        'cboHourEnd
        '
        Me.cboHourEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboHourEnd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHourEnd.FormattingEnabled = True
        Me.cboHourEnd.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cboHourEnd.Location = New System.Drawing.Point(353, 164)
        Me.cboHourEnd.Name = "cboHourEnd"
        Me.cboHourEnd.Size = New System.Drawing.Size(60, 36)
        Me.cboHourEnd.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 28)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Date :"
        '
        'cboDayNightEnd
        '
        Me.cboDayNightEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboDayNightEnd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDayNightEnd.FormattingEnabled = True
        Me.cboDayNightEnd.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboDayNightEnd.Location = New System.Drawing.Point(485, 164)
        Me.cboDayNightEnd.Name = "cboDayNightEnd"
        Me.cboDayNightEnd.Size = New System.Drawing.Size(60, 36)
        Me.cboDayNightEnd.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 28)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Date :"
        '
        'cboMinuteEnd
        '
        Me.cboMinuteEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboMinuteEnd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMinuteEnd.FormattingEnabled = True
        Me.cboMinuteEnd.Items.AddRange(New Object() {"00", "30"})
        Me.cboMinuteEnd.Location = New System.Drawing.Point(419, 164)
        Me.cboMinuteEnd.Name = "cboMinuteEnd"
        Me.cboMinuteEnd.Size = New System.Drawing.Size(60, 36)
        Me.cboMinuteEnd.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(273, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 28)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Time :"
        '
        'cboDayNightStart
        '
        Me.cboDayNightStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboDayNightStart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDayNightStart.FormattingEnabled = True
        Me.cboDayNightStart.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboDayNightStart.Location = New System.Drawing.Point(485, 62)
        Me.cboDayNightStart.Name = "cboDayNightStart"
        Me.cboDayNightStart.Size = New System.Drawing.Size(60, 36)
        Me.cboDayNightStart.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(273, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 28)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Time :"
        '
        'cboHourStart
        '
        Me.cboHourStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboHourStart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHourStart.FormattingEnabled = True
        Me.cboHourStart.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cboHourStart.Location = New System.Drawing.Point(353, 62)
        Me.cboHourStart.Name = "cboHourStart"
        Me.cboHourStart.Size = New System.Drawing.Size(60, 36)
        Me.cboHourStart.TabIndex = 1
        '
        'dtpStartOperationDate
        '
        Me.dtpStartOperationDate.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartOperationDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStartOperationDate.CustomFormat = "MM/dd/yy"
        Me.dtpStartOperationDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartOperationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartOperationDate.Location = New System.Drawing.Point(102, 63)
        Me.dtpStartOperationDate.Name = "dtpStartOperationDate"
        Me.dtpStartOperationDate.Size = New System.Drawing.Size(165, 34)
        Me.dtpStartOperationDate.TabIndex = 0
        '
        'cboMinuteStart
        '
        Me.cboMinuteStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboMinuteStart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMinuteStart.FormattingEnabled = True
        Me.cboMinuteStart.Items.AddRange(New Object() {"00", "30"})
        Me.cboMinuteStart.Location = New System.Drawing.Point(418, 62)
        Me.cboMinuteStart.Name = "cboMinuteStart"
        Me.cboMinuteStart.Size = New System.Drawing.Size(60, 36)
        Me.cboMinuteStart.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(752, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(163, 31)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "MYR per hour"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(682, 209)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(79, 34)
        Me.txtQty.TabIndex = 66
        Me.txtQty.Text = "5"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRentalPrice
        '
        Me.txtRentalPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRentalPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentalPrice.Location = New System.Drawing.Point(642, 152)
        Me.txtRentalPrice.Name = "txtRentalPrice"
        Me.txtRentalPrice.Size = New System.Drawing.Size(107, 34)
        Me.txtRentalPrice.TabIndex = 1
        '
        'txtServiceName
        '
        Me.txtServiceName.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtServiceName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceName.Location = New System.Drawing.Point(642, 97)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtServiceName.Size = New System.Drawing.Size(318, 34)
        Me.txtServiceName.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rbtFullDay)
        Me.Panel1.Controls.Add(Me.rbtHourly)
        Me.Panel1.Controls.Add(Me.rbtHalfDay)
        Me.Panel1.Location = New System.Drawing.Point(451, 299)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 58)
        Me.Panel1.TabIndex = 2
        '
        'rbtFullDay
        '
        Me.rbtFullDay.AutoSize = True
        Me.rbtFullDay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFullDay.Location = New System.Drawing.Point(319, 12)
        Me.rbtFullDay.Name = "rbtFullDay"
        Me.rbtFullDay.Size = New System.Drawing.Size(103, 32)
        Me.rbtFullDay.TabIndex = 2
        Me.rbtFullDay.TabStop = True
        Me.rbtFullDay.Text = "Full Day"
        Me.rbtFullDay.UseVisualStyleBackColor = True
        '
        'rbtHourly
        '
        Me.rbtHourly.AutoSize = True
        Me.rbtHourly.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtHourly.Location = New System.Drawing.Point(26, 12)
        Me.rbtHourly.Name = "rbtHourly"
        Me.rbtHourly.Size = New System.Drawing.Size(92, 32)
        Me.rbtHourly.TabIndex = 0
        Me.rbtHourly.TabStop = True
        Me.rbtHourly.Text = "Hourly"
        Me.rbtHourly.UseVisualStyleBackColor = True
        '
        'rbtHalfDay
        '
        Me.rbtHalfDay.AutoSize = True
        Me.rbtHalfDay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtHalfDay.Location = New System.Drawing.Point(168, 12)
        Me.rbtHalfDay.Name = "rbtHalfDay"
        Me.rbtHalfDay.Size = New System.Drawing.Size(110, 32)
        Me.rbtHalfDay.TabIndex = 1
        Me.rbtHalfDay.TabStop = True
        Me.rbtHalfDay.Text = "Half-Day"
        Me.rbtHalfDay.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(424, 259)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(190, 28)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Rental Time Frame"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(439, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 28)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Car Seat Capacity :"
        '
        'LabelHour1
        '
        Me.LabelHour1.AutoSize = True
        Me.LabelHour1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHour1.Location = New System.Drawing.Point(490, 158)
        Me.LabelHour1.Name = "LabelHour1"
        Me.LabelHour1.Size = New System.Drawing.Size(137, 28)
        Me.LabelHour1.TabIndex = 60
        Me.LabelHour1.Text = "Rental Price :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(473, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 28)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Service Name :"
        '
        'txtAvailableHours
        '
        Me.txtAvailableHours.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAvailableHours.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableHours.Location = New System.Drawing.Point(705, 377)
        Me.txtAvailableHours.Name = "txtAvailableHours"
        Me.txtAvailableHours.Size = New System.Drawing.Size(90, 34)
        Me.txtAvailableHours.TabIndex = 74
        Me.txtAvailableHours.Text = "1"
        Me.txtAvailableHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAvailableHours.Visible = False
        '
        'lblHourly1
        '
        Me.lblHourly1.AutoSize = True
        Me.lblHourly1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourly1.Location = New System.Drawing.Point(468, 380)
        Me.lblHourly1.Name = "lblHourly1"
        Me.lblHourly1.Size = New System.Drawing.Size(231, 28)
        Me.lblHourly1.TabIndex = 75
        Me.lblHourly1.Text = "Available Rental Hour :"
        Me.lblHourly1.Visible = False
        '
        'lblHourly2
        '
        Me.lblHourly2.AutoSize = True
        Me.lblHourly2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourly2.Location = New System.Drawing.Point(801, 383)
        Me.lblHourly2.Name = "lblHourly2"
        Me.lblHourly2.Size = New System.Drawing.Size(65, 28)
        Me.lblHourly2.TabIndex = 76
        Me.lblHourly2.Text = "hours"
        Me.lblHourly2.Visible = False
        '
        'OpenFileDialogCarPhoto
        '
        Me.OpenFileDialogCarPhoto.FileName = "OpenFileDialog1"
        '
        'lblValidation
        '
        Me.lblValidation.AutoSize = True
        Me.lblValidation.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidation.ForeColor = System.Drawing.Color.Red
        Me.lblValidation.Location = New System.Drawing.Point(872, 388)
        Me.lblValidation.Name = "lblValidation"
        Me.lblValidation.Size = New System.Drawing.Size(113, 23)
        Me.lblValidation.TabIndex = 77
        Me.lblValidation.Text = "*Invalid Input"
        Me.lblValidation.Visible = False
        '
        'btnAddService
        '
        Me.btnAddService.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddService.FlatAppearance.BorderSize = 0
        Me.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddService.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddService.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_create_document_24
        Me.btnAddService.Location = New System.Drawing.Point(208, 584)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(160, 54)
        Me.btnAddService.TabIndex = 4
        Me.btnAddService.Text = "ADD"
        Me.btnAddService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddService.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_reset_32
        Me.btnReset.Location = New System.Drawing.Point(20, 584)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(153, 54)
        Me.btnReset.TabIndex = 71
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpload.FlatAppearance.BorderSize = 0
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_uninstalling_updates_40
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpload.Location = New System.Drawing.Point(46, 486)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(290, 60)
        Me.btnUpload.TabIndex = 70
        Me.btnUpload.Text = "UPLOAD"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnMinus.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_minus_241
        Me.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinus.FlatAppearance.BorderSize = 0
        Me.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinus.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(642, 209)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(40, 34)
        Me.btnMinus.TabIndex = 68
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnPlus.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_plus_241
        Me.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlus.FlatAppearance.BorderSize = 0
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlus.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(757, 209)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(40, 34)
        Me.btnPlus.TabIndex = 67
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'pcbCarPhoto
        '
        Me.pcbCarPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbCarPhoto.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Default_Car_Photo
        Me.pcbCarPhoto.Location = New System.Drawing.Point(12, 158)
        Me.pcbCarPhoto.Name = "pcbCarPhoto"
        Me.pcbCarPhoto.Size = New System.Drawing.Size(385, 297)
        Me.pcbCarPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCarPhoto.TabIndex = 58
        Me.pcbCarPhoto.TabStop = False
        '
        'pcbExit
        '
        Me.pcbExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pcbExit.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_close_48
        Me.pcbExit.Location = New System.Drawing.Point(949, 0)
        Me.pcbExit.Name = "pcbExit"
        Me.pcbExit.Size = New System.Drawing.Size(52, 50)
        Me.pcbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbExit.TabIndex = 55
        Me.pcbExit.TabStop = False
        '
        'lblStoreCarPoolID
        '
        Me.lblStoreCarPoolID.AutoSize = True
        Me.lblStoreCarPoolID.Location = New System.Drawing.Point(500, 343)
        Me.lblStoreCarPoolID.Name = "lblStoreCarPoolID"
        Me.lblStoreCarPoolID.Size = New System.Drawing.Size(0, 16)
        Me.lblStoreCarPoolID.TabIndex = 78
        '
        'lblStoreCarRentalID
        '
        Me.lblStoreCarRentalID.AutoSize = True
        Me.lblStoreCarRentalID.Location = New System.Drawing.Point(25, 64)
        Me.lblStoreCarRentalID.Name = "lblStoreCarRentalID"
        Me.lblStoreCarRentalID.Size = New System.Drawing.Size(0, 16)
        Me.lblStoreCarRentalID.TabIndex = 79
        Me.lblStoreCarRentalID.Visible = False
        '
        'frmSellerNewCarRentalService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 703)
        Me.Controls.Add(Me.lblStoreCarRentalID)
        Me.Controls.Add(Me.lblStoreCarPoolID)
        Me.Controls.Add(Me.lblValidation)
        Me.Controls.Add(Me.lblHourly2)
        Me.Controls.Add(Me.lblHourly1)
        Me.Controls.Add(Me.txtAvailableHours)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnAddService)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtRentalPrice)
        Me.Controls.Add(Me.txtServiceName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelHour1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcbCarPhoto)
        Me.Controls.Add(Me.pcbExit)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSellerNewCarRentalService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SellerNewCarRentalService"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pcbCarPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents pcbExit As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpEndOperationDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cboHourEnd As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboDayNightEnd As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboMinuteEnd As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboDayNightStart As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboHourStart As ComboBox
    Friend WithEvents dtpStartOperationDate As DateTimePicker
    Friend WithEvents cboMinuteStart As ComboBox
    Friend WithEvents btnAddService As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtRentalPrice As TextBox
    Friend WithEvents txtServiceName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbtFullDay As RadioButton
    Friend WithEvents rbtHourly As RadioButton
    Friend WithEvents rbtHalfDay As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelHour1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pcbCarPhoto As PictureBox
    Friend WithEvents txtAvailableHours As TextBox
    Friend WithEvents lblHourly1 As Label
    Friend WithEvents lblHourly2 As Label
    Friend WithEvents OpenFileDialogCarPhoto As OpenFileDialog
    Friend WithEvents lblValidation As Label
    Friend WithEvents lblStoreCarPoolID As Label
    Friend WithEvents lblStoreCarRentalID As Label
End Class
