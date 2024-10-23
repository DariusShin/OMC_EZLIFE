<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSellerNewCarPoolService
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSellerNewCarPoolService))
        Me.PanelTab = New System.Windows.Forms.Panel()
        Me.pcbExit = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rbtInUtp = New System.Windows.Forms.RadioButton()
        Me.rbtOutsideUtp = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtServiceName = New System.Windows.Forms.TextBox()
        Me.txtSeatPrice = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboStartPoint = New System.Windows.Forms.ComboBox()
        Me.cboEndPoint = New System.Windows.Forms.ComboBox()
        Me.txtStartPoint = New System.Windows.Forms.TextBox()
        Me.txtEndPoint = New System.Windows.Forms.TextBox()
        Me.cboDayNightStart = New System.Windows.Forms.ComboBox()
        Me.cboHourStart = New System.Windows.Forms.ComboBox()
        Me.cboMinuteStart = New System.Windows.Forms.ComboBox()
        Me.dtpStartOperationDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndOperationDate = New System.Windows.Forms.DateTimePicker()
        Me.cboHourEnd = New System.Windows.Forms.ComboBox()
        Me.cboDayNightEnd = New System.Windows.Forms.ComboBox()
        Me.cboMinuteEnd = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OpenFileDialogCarPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.lblStoreCarPoolID = New System.Windows.Forms.Label()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.pcbCarPhoto = New System.Windows.Forms.PictureBox()
        Me.PanelTab.SuspendLayout()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbCarPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTab
        '
        Me.PanelTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.PanelTab.Controls.Add(Me.pcbExit)
        Me.PanelTab.Controls.Add(Me.lblHeader)
        Me.PanelTab.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTab.Location = New System.Drawing.Point(0, 0)
        Me.PanelTab.Name = "PanelTab"
        Me.PanelTab.Size = New System.Drawing.Size(1019, 50)
        Me.PanelTab.TabIndex = 3
        '
        'pcbExit
        '
        Me.pcbExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pcbExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pcbExit.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_close_48
        Me.pcbExit.Location = New System.Drawing.Point(967, 0)
        Me.pcbExit.Name = "pcbExit"
        Me.pcbExit.Size = New System.Drawing.Size(52, 50)
        Me.pcbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbExit.TabIndex = 12
        Me.pcbExit.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeader.Font = New System.Drawing.Font("Sans Serif Collection", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(1019, 50)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "New Car Pooling Service"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(455, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Service Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(489, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Seat Price :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(455, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Seat Capacity :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(457, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 28)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Starting Point :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(476, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Destination :"
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(109, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(210, 54)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Car Photo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(454, 258)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 28)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Service Area"
        '
        'rbtInUtp
        '
        Me.rbtInUtp.AutoSize = True
        Me.rbtInUtp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtInUtp.Location = New System.Drawing.Point(46, 12)
        Me.rbtInUtp.Name = "rbtInUtp"
        Me.rbtInUtp.Size = New System.Drawing.Size(89, 32)
        Me.rbtInUtp.TabIndex = 18
        Me.rbtInUtp.TabStop = True
        Me.rbtInUtp.Text = "In UTP"
        Me.rbtInUtp.UseVisualStyleBackColor = True
        '
        'rbtOutsideUtp
        '
        Me.rbtOutsideUtp.AutoSize = True
        Me.rbtOutsideUtp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtOutsideUtp.Location = New System.Drawing.Point(229, 12)
        Me.rbtOutsideUtp.Name = "rbtOutsideUtp"
        Me.rbtOutsideUtp.Size = New System.Drawing.Size(141, 32)
        Me.rbtOutsideUtp.TabIndex = 19
        Me.rbtOutsideUtp.TabStop = True
        Me.rbtOutsideUtp.Text = "Outside UTP"
        Me.rbtOutsideUtp.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rbtInUtp)
        Me.Panel1.Controls.Add(Me.rbtOutsideUtp)
        Me.Panel1.Location = New System.Drawing.Point(481, 301)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 58)
        Me.Panel1.TabIndex = 2
        '
        'txtServiceName
        '
        Me.txtServiceName.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtServiceName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceName.Location = New System.Drawing.Point(615, 96)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtServiceName.Size = New System.Drawing.Size(318, 34)
        Me.txtServiceName.TabIndex = 0
        '
        'txtSeatPrice
        '
        Me.txtSeatPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSeatPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeatPrice.Location = New System.Drawing.Point(615, 151)
        Me.txtSeatPrice.Name = "txtSeatPrice"
        Me.txtSeatPrice.Size = New System.Drawing.Size(107, 34)
        Me.txtSeatPrice.TabIndex = 1
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(655, 208)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(79, 34)
        Me.txtQty.TabIndex = 25
        Me.txtQty.Text = "5"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(725, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 31)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "MYR"
        '
        'cboStartPoint
        '
        Me.cboStartPoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboStartPoint.Enabled = False
        Me.cboStartPoint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStartPoint.FormattingEnabled = True
        Me.cboStartPoint.Location = New System.Drawing.Point(623, 382)
        Me.cboStartPoint.Name = "cboStartPoint"
        Me.cboStartPoint.Size = New System.Drawing.Size(153, 36)
        Me.cboStartPoint.TabIndex = 3
        '
        'cboEndPoint
        '
        Me.cboEndPoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboEndPoint.Enabled = False
        Me.cboEndPoint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEndPoint.FormattingEnabled = True
        Me.cboEndPoint.Location = New System.Drawing.Point(620, 445)
        Me.cboEndPoint.Name = "cboEndPoint"
        Me.cboEndPoint.Size = New System.Drawing.Size(153, 36)
        Me.cboEndPoint.TabIndex = 4
        '
        'txtStartPoint
        '
        Me.txtStartPoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtStartPoint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartPoint.Location = New System.Drawing.Point(795, 382)
        Me.txtStartPoint.Name = "txtStartPoint"
        Me.txtStartPoint.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtStartPoint.Size = New System.Drawing.Size(179, 34)
        Me.txtStartPoint.TabIndex = 5
        Me.txtStartPoint.Visible = False
        '
        'txtEndPoint
        '
        Me.txtEndPoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEndPoint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndPoint.Location = New System.Drawing.Point(792, 445)
        Me.txtEndPoint.Name = "txtEndPoint"
        Me.txtEndPoint.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtEndPoint.Size = New System.Drawing.Size(182, 34)
        Me.txtEndPoint.TabIndex = 6
        Me.txtEndPoint.Visible = False
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
        Me.Panel2.Location = New System.Drawing.Point(429, 501)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(578, 237)
        Me.Panel2.TabIndex = 7
        '
        'OpenFileDialogCarPhoto
        '
        Me.OpenFileDialogCarPhoto.FileName = "OpenFileDialog1"
        '
        'lblStoreCarPoolID
        '
        Me.lblStoreCarPoolID.AutoSize = True
        Me.lblStoreCarPoolID.Location = New System.Drawing.Point(54, 57)
        Me.lblStoreCarPoolID.Name = "lblStoreCarPoolID"
        Me.lblStoreCarPoolID.Size = New System.Drawing.Size(0, 16)
        Me.lblStoreCarPoolID.TabIndex = 42
        Me.lblStoreCarPoolID.Visible = False
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnMinus.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_minus_24
        Me.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinus.FlatAppearance.BorderSize = 0
        Me.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinus.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(615, 208)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(40, 34)
        Me.btnMinus.TabIndex = 27
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnPlus.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_plus_24
        Me.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlus.FlatAppearance.BorderSize = 0
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlus.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(730, 208)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(40, 34)
        Me.btnPlus.TabIndex = 26
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'btnAddService
        '
        Me.btnAddService.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddService.FlatAppearance.BorderSize = 0
        Me.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddService.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddService.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_create_document_24
        Me.btnAddService.Location = New System.Drawing.Point(211, 584)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(160, 54)
        Me.btnAddService.TabIndex = 8
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
        Me.btnReset.Location = New System.Drawing.Point(22, 584)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(156, 54)
        Me.btnReset.TabIndex = 21
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
        Me.btnUpload.Location = New System.Drawing.Point(54, 489)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(290, 60)
        Me.btnUpload.TabIndex = 4
        Me.btnUpload.Text = "UPLOAD"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'pcbCarPhoto
        '
        Me.pcbCarPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbCarPhoto.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Default_Car_Photo
        Me.pcbCarPhoto.Location = New System.Drawing.Point(19, 151)
        Me.pcbCarPhoto.Name = "pcbCarPhoto"
        Me.pcbCarPhoto.Size = New System.Drawing.Size(392, 297)
        Me.pcbCarPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCarPhoto.TabIndex = 0
        Me.pcbCarPhoto.TabStop = False
        '
        'frmSellerNewCarPoolService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 750)
        Me.Controls.Add(Me.lblStoreCarPoolID)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtEndPoint)
        Me.Controls.Add(Me.txtStartPoint)
        Me.Controls.Add(Me.cboEndPoint)
        Me.Controls.Add(Me.cboStartPoint)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtSeatPrice)
        Me.Controls.Add(Me.txtServiceName)
        Me.Controls.Add(Me.btnAddService)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.PanelTab)
        Me.Controls.Add(Me.pcbCarPhoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSellerNewCarPoolService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SellerNewCarPoolService"
        Me.PanelTab.ResumeLayout(False)
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcbCarPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcbCarPhoto As PictureBox
    Friend WithEvents PanelTab As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents pcbExit As PictureBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents rbtInUtp As RadioButton
    Friend WithEvents rbtOutsideUtp As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnAddService As Button
    Friend WithEvents txtServiceName As TextBox
    Friend WithEvents txtSeatPrice As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents cboStartPoint As ComboBox
    Friend WithEvents cboEndPoint As ComboBox
    Friend WithEvents txtStartPoint As TextBox
    Friend WithEvents txtEndPoint As TextBox
    Friend WithEvents cboDayNightStart As ComboBox
    Friend WithEvents cboHourStart As ComboBox
    Friend WithEvents cboMinuteStart As ComboBox
    Friend WithEvents dtpStartOperationDate As DateTimePicker
    Friend WithEvents dtpEndOperationDate As DateTimePicker
    Friend WithEvents cboHourEnd As ComboBox
    Friend WithEvents cboDayNightEnd As ComboBox
    Friend WithEvents cboMinuteEnd As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents OpenFileDialogCarPhoto As OpenFileDialog
    Friend WithEvents lblStoreCarPoolID As Label
End Class
