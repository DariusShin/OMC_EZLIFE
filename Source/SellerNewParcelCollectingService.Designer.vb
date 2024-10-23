<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSellerNewParcelCollectingService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSellerNewParcelCollectingService))
        Me.pcbExit = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCollectPrice = New System.Windows.Forms.TextBox()
        Me.txtServiceName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtBothType = New System.Windows.Forms.RadioButton()
        Me.rbtFragile = New System.Windows.Forms.RadioButton()
        Me.rbtNonFragile = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkAllWeight = New System.Windows.Forms.CheckBox()
        Me.chkMore3kg = New System.Windows.Forms.CheckBox()
        Me.chk1kgto3kg = New System.Windows.Forms.CheckBox()
        Me.chkLess1kg = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.txtServiceDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblStoreParcelCollectID = New System.Windows.Forms.Label()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcbExit
        '
        Me.pcbExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pcbExit.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_close_48
        Me.pcbExit.Location = New System.Drawing.Point(949, 0)
        Me.pcbExit.Name = "pcbExit"
        Me.pcbExit.Size = New System.Drawing.Size(52, 50)
        Me.pcbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbExit.TabIndex = 57
        Me.pcbExit.TabStop = False
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
        Me.lblHeader.TabIndex = 56
        Me.lblHeader.Text = "New Parcel Collecting Service"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(714, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(177, 31)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "MYR per parcel"
        '
        'txtCollectPrice
        '
        Me.txtCollectPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCollectPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollectPrice.Location = New System.Drawing.Point(601, 135)
        Me.txtCollectPrice.Name = "txtCollectPrice"
        Me.txtCollectPrice.Size = New System.Drawing.Size(107, 34)
        Me.txtCollectPrice.TabIndex = 1
        '
        'txtServiceName
        '
        Me.txtServiceName.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtServiceName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceName.Location = New System.Drawing.Point(601, 79)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtServiceName.Size = New System.Drawing.Size(318, 34)
        Me.txtServiceName.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rbtBothType)
        Me.Panel1.Controls.Add(Me.rbtFragile)
        Me.Panel1.Controls.Add(Me.rbtNonFragile)
        Me.Panel1.Location = New System.Drawing.Point(450, 241)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 58)
        Me.Panel1.TabIndex = 2
        '
        'rbtBothType
        '
        Me.rbtBothType.AutoSize = True
        Me.rbtBothType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtBothType.Location = New System.Drawing.Point(317, 12)
        Me.rbtBothType.Name = "rbtBothType"
        Me.rbtBothType.Size = New System.Drawing.Size(74, 32)
        Me.rbtBothType.TabIndex = 2
        Me.rbtBothType.TabStop = True
        Me.rbtBothType.Text = "Both"
        Me.rbtBothType.UseVisualStyleBackColor = True
        '
        'rbtFragile
        '
        Me.rbtFragile.AutoSize = True
        Me.rbtFragile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFragile.Location = New System.Drawing.Point(23, 12)
        Me.rbtFragile.Name = "rbtFragile"
        Me.rbtFragile.Size = New System.Drawing.Size(92, 32)
        Me.rbtFragile.TabIndex = 0
        Me.rbtFragile.TabStop = True
        Me.rbtFragile.Text = "Fragile"
        Me.rbtFragile.UseVisualStyleBackColor = True
        '
        'rbtNonFragile
        '
        Me.rbtNonFragile.AutoSize = True
        Me.rbtNonFragile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNonFragile.Location = New System.Drawing.Point(150, 12)
        Me.rbtNonFragile.Name = "rbtNonFragile"
        Me.rbtNonFragile.Size = New System.Drawing.Size(138, 32)
        Me.rbtNonFragile.TabIndex = 1
        Me.rbtNonFragile.TabStop = True
        Me.rbtNonFragile.Text = "Non-Fragile"
        Me.rbtNonFragile.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(424, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 28)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Parcel Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(424, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 28)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Collecting Price :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(441, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 28)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Service Name :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.chkAllWeight)
        Me.Panel2.Controls.Add(Me.chkMore3kg)
        Me.Panel2.Controls.Add(Me.chk1kgto3kg)
        Me.Panel2.Controls.Add(Me.chkLess1kg)
        Me.Panel2.Location = New System.Drawing.Point(450, 368)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(513, 58)
        Me.Panel2.TabIndex = 3
        '
        'chkAllWeight
        '
        Me.chkAllWeight.AutoSize = True
        Me.chkAllWeight.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkAllWeight.Location = New System.Drawing.Point(424, 12)
        Me.chkAllWeight.Name = "chkAllWeight"
        Me.chkAllWeight.Size = New System.Drawing.Size(57, 32)
        Me.chkAllWeight.TabIndex = 3
        Me.chkAllWeight.Text = "All"
        Me.chkAllWeight.UseVisualStyleBackColor = True
        '
        'chkMore3kg
        '
        Me.chkMore3kg.AutoSize = True
        Me.chkMore3kg.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkMore3kg.Location = New System.Drawing.Point(317, 12)
        Me.chkMore3kg.Name = "chkMore3kg"
        Me.chkMore3kg.Size = New System.Drawing.Size(86, 32)
        Me.chkMore3kg.TabIndex = 2
        Me.chkMore3kg.Text = "> 3kg"
        Me.chkMore3kg.UseVisualStyleBackColor = True
        '
        'chk1kgto3kg
        '
        Me.chk1kgto3kg.AutoSize = True
        Me.chk1kgto3kg.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chk1kgto3kg.Location = New System.Drawing.Point(140, 12)
        Me.chk1kgto3kg.Name = "chk1kgto3kg"
        Me.chk1kgto3kg.Size = New System.Drawing.Size(148, 32)
        Me.chk1kgto3kg.TabIndex = 1
        Me.chk1kgto3kg.Text = "< 1kg to 3kg"
        Me.chk1kgto3kg.UseVisualStyleBackColor = True
        '
        'chkLess1kg
        '
        Me.chkLess1kg.AutoSize = True
        Me.chkLess1kg.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkLess1kg.Location = New System.Drawing.Point(23, 12)
        Me.chkLess1kg.Name = "chkLess1kg"
        Me.chkLess1kg.Size = New System.Drawing.Size(86, 32)
        Me.chkLess1kg.TabIndex = 0
        Me.chkLess1kg.Text = "< 1kg"
        Me.chkLess1kg.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(424, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 28)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Parcel Weight"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.dtpEndOperationDate)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cboHourEnd)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cboDayNightEnd)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.cboMinuteEnd)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.cboDayNightStart)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.cboHourStart)
        Me.Panel3.Controls.Add(Me.dtpStartOperationDate)
        Me.Panel3.Controls.Add(Me.cboMinuteStart)
        Me.Panel3.Location = New System.Drawing.Point(429, 454)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(554, 237)
        Me.Panel3.TabIndex = 4
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
        'txtServiceDescription
        '
        Me.txtServiceDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtServiceDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceDescription.Location = New System.Drawing.Point(12, 116)
        Me.txtServiceDescription.Multiline = True
        Me.txtServiceDescription.Name = "txtServiceDescription"
        Me.txtServiceDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtServiceDescription.Size = New System.Drawing.Size(384, 383)
        Me.txtServiceDescription.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 28)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Service Descripton :"
        '
        'btnAddService
        '
        Me.btnAddService.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddService.FlatAppearance.BorderSize = 0
        Me.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddService.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddService.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_create_document_24
        Me.btnAddService.Location = New System.Drawing.Point(215, 564)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(160, 54)
        Me.btnAddService.TabIndex = 6
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
        Me.btnReset.Location = New System.Drawing.Point(27, 564)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(153, 54)
        Me.btnReset.TabIndex = 77
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblStoreParcelCollectID
        '
        Me.lblStoreParcelCollectID.AutoSize = True
        Me.lblStoreParcelCollectID.Location = New System.Drawing.Point(306, 79)
        Me.lblStoreParcelCollectID.Name = "lblStoreParcelCollectID"
        Me.lblStoreParcelCollectID.Size = New System.Drawing.Size(0, 16)
        Me.lblStoreParcelCollectID.TabIndex = 79
        Me.lblStoreParcelCollectID.Visible = False
        '
        'frmSellerNewParcelCollectingService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 703)
        Me.Controls.Add(Me.lblStoreParcelCollectID)
        Me.Controls.Add(Me.btnAddService)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtServiceDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtCollectPrice)
        Me.Controls.Add(Me.txtServiceName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcbExit)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSellerNewParcelCollectingService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SellerNewParcelCollectingService"
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcbExit As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCollectPrice As TextBox
    Friend WithEvents txtServiceName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbtFragile As RadioButton
    Friend WithEvents rbtNonFragile As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbtBothType As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
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
    Friend WithEvents txtServiceDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddService As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents chkAllWeight As CheckBox
    Friend WithEvents chkMore3kg As CheckBox
    Friend WithEvents chk1kgto3kg As CheckBox
    Friend WithEvents chkLess1kg As CheckBox
    Friend WithEvents lblStoreParcelCollectID As Label
End Class
