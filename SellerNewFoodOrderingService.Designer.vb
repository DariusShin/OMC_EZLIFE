<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSellerNewFoodOrderingService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSellerNewFoodOrderingService))
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtFoodPrice = New System.Windows.Forms.TextBox()
        Me.txtServiceName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtDessert = New System.Windows.Forms.RadioButton()
        Me.rbtFood = New System.Windows.Forms.RadioButton()
        Me.rbtBeverage = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
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
        Me.OpenFileDialogFoodPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.lblStoreFoodOrderID = New System.Windows.Forms.Label()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.pcbExit = New System.Windows.Forms.PictureBox()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.pcbFoodPhoto = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbFoodPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(733, 155)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 31)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "MYR"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(663, 212)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(79, 34)
        Me.txtQty.TabIndex = 44
        Me.txtQty.Text = "1"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFoodPrice
        '
        Me.txtFoodPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFoodPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodPrice.Location = New System.Drawing.Point(623, 155)
        Me.txtFoodPrice.Name = "txtFoodPrice"
        Me.txtFoodPrice.Size = New System.Drawing.Size(107, 34)
        Me.txtFoodPrice.TabIndex = 1
        '
        'txtServiceName
        '
        Me.txtServiceName.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtServiceName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceName.Location = New System.Drawing.Point(623, 100)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtServiceName.Size = New System.Drawing.Size(318, 34)
        Me.txtServiceName.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rbtDessert)
        Me.Panel1.Controls.Add(Me.rbtFood)
        Me.Panel1.Controls.Add(Me.rbtBeverage)
        Me.Panel1.Location = New System.Drawing.Point(489, 305)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 58)
        Me.Panel1.TabIndex = 2
        '
        'rbtDessert
        '
        Me.rbtDessert.AutoSize = True
        Me.rbtDessert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDessert.Location = New System.Drawing.Point(300, 12)
        Me.rbtDessert.Name = "rbtDessert"
        Me.rbtDessert.Size = New System.Drawing.Size(97, 32)
        Me.rbtDessert.TabIndex = 2
        Me.rbtDessert.TabStop = True
        Me.rbtDessert.Text = "Dessert"
        Me.rbtDessert.UseVisualStyleBackColor = True
        '
        'rbtFood
        '
        Me.rbtFood.AutoSize = True
        Me.rbtFood.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFood.Location = New System.Drawing.Point(23, 12)
        Me.rbtFood.Name = "rbtFood"
        Me.rbtFood.Size = New System.Drawing.Size(79, 32)
        Me.rbtFood.TabIndex = 0
        Me.rbtFood.TabStop = True
        Me.rbtFood.Text = "Food"
        Me.rbtFood.UseVisualStyleBackColor = True
        '
        'rbtBeverage
        '
        Me.rbtBeverage.AutoSize = True
        Me.rbtBeverage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtBeverage.Location = New System.Drawing.Point(147, 12)
        Me.rbtBeverage.Name = "rbtBeverage"
        Me.rbtBeverage.Size = New System.Drawing.Size(113, 32)
        Me.rbtBeverage.TabIndex = 1
        Me.rbtBeverage.TabStop = True
        Me.rbtBeverage.Text = "Beverage"
        Me.rbtBeverage.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(462, 262)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 28)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Food Type"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(112, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(241, 54)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Food Photo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(453, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 28)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Stock Quantity :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(497, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 28)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Food Price :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 28)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Service Name :"
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
        Me.lblHeader.TabIndex = 52
        Me.lblHeader.Text = "New Food Ordering Service"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel2.Location = New System.Drawing.Point(435, 409)
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
        'OpenFileDialogFoodPhoto
        '
        Me.OpenFileDialogFoodPhoto.FileName = "OpenFileDialog1"
        '
        'lblStoreFoodOrderID
        '
        Me.lblStoreFoodOrderID.AutoSize = True
        Me.lblStoreFoodOrderID.Location = New System.Drawing.Point(26, 65)
        Me.lblStoreFoodOrderID.Name = "lblStoreFoodOrderID"
        Me.lblStoreFoodOrderID.Size = New System.Drawing.Size(0, 16)
        Me.lblStoreFoodOrderID.TabIndex = 58
        Me.lblStoreFoodOrderID.Visible = False
        '
        'btnAddService
        '
        Me.btnAddService.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddService.FlatAppearance.BorderSize = 0
        Me.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddService.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddService.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_create_document_24
        Me.btnAddService.Location = New System.Drawing.Point(233, 574)
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
        Me.btnReset.Location = New System.Drawing.Point(45, 574)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(153, 54)
        Me.btnReset.TabIndex = 55
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
        Me.btnUpload.Location = New System.Drawing.Point(81, 490)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(290, 60)
        Me.btnUpload.TabIndex = 54
        Me.btnUpload.Text = "UPLOAD"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'pcbExit
        '
        Me.pcbExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pcbExit.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_close_48
        Me.pcbExit.Location = New System.Drawing.Point(949, 0)
        Me.pcbExit.Name = "pcbExit"
        Me.pcbExit.Size = New System.Drawing.Size(52, 50)
        Me.pcbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbExit.TabIndex = 53
        Me.pcbExit.TabStop = False
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
        Me.btnMinus.Location = New System.Drawing.Point(623, 212)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(40, 34)
        Me.btnMinus.TabIndex = 46
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
        Me.btnPlus.Location = New System.Drawing.Point(738, 212)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(40, 34)
        Me.btnPlus.TabIndex = 45
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'pcbFoodPhoto
        '
        Me.pcbFoodPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbFoodPhoto.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Default_Food_Photo
        Me.pcbFoodPhoto.Location = New System.Drawing.Point(29, 155)
        Me.pcbFoodPhoto.Name = "pcbFoodPhoto"
        Me.pcbFoodPhoto.Size = New System.Drawing.Size(376, 305)
        Me.pcbFoodPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFoodPhoto.TabIndex = 33
        Me.pcbFoodPhoto.TabStop = False
        '
        'frmSellerNewFoodOrderingService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 703)
        Me.Controls.Add(Me.lblStoreFoodOrderID)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnAddService)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.pcbExit)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtFoodPrice)
        Me.Controls.Add(Me.txtServiceName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcbFoodPhoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSellerNewFoodOrderingService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SellerNewFoodOrderingService"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbFoodPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As Label
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtFoodPrice As TextBox
    Friend WithEvents txtServiceName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbtFood As RadioButton
    Friend WithEvents rbtBeverage As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pcbFoodPhoto As PictureBox
    Friend WithEvents lblHeader As Label
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
    Friend WithEvents rbtDessert As RadioButton
    Friend WithEvents OpenFileDialogFoodPhoto As OpenFileDialog
    Friend WithEvents lblStoreFoodOrderID As Label
End Class
