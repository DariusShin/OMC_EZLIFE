<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmServicePayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicePayment))
        Me.PanelPayment = New System.Windows.Forms.Panel()
        Me.txtContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.txtMatricNo = New System.Windows.Forms.MaskedTextBox()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.lblVillage = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblMatricNo = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblServiceSeller = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblServiceName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtRequest = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPaymentAmount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboBlock = New System.Windows.Forms.ComboBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pcbCOD = New System.Windows.Forms.PictureBox()
        Me.pcbVisaMaster = New System.Windows.Forms.PictureBox()
        Me.cboVillage = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblStoredServiceID = New System.Windows.Forms.Label()
        Me.pcbClosePayment = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.PanelPayment.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbCOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbVisaMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbClosePayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPayment
        '
        Me.PanelPayment.AutoScroll = True
        Me.PanelPayment.Controls.Add(Me.txtContactNo)
        Me.PanelPayment.Controls.Add(Me.txtMatricNo)
        Me.PanelPayment.Controls.Add(Me.lblMethod)
        Me.PanelPayment.Controls.Add(Me.lblVillage)
        Me.PanelPayment.Controls.Add(Me.lblContactNo)
        Me.PanelPayment.Controls.Add(Me.lblGender)
        Me.PanelPayment.Controls.Add(Me.lblMatricNo)
        Me.PanelPayment.Controls.Add(Me.lblFullName)
        Me.PanelPayment.Controls.Add(Me.PictureBox1)
        Me.PanelPayment.Controls.Add(Me.Label8)
        Me.PanelPayment.Controls.Add(Me.btnMinus)
        Me.PanelPayment.Controls.Add(Me.btnPlus)
        Me.PanelPayment.Controls.Add(Me.txtQty)
        Me.PanelPayment.Controls.Add(Me.lblServiceSeller)
        Me.PanelPayment.Controls.Add(Me.Label14)
        Me.PanelPayment.Controls.Add(Me.lblServiceName)
        Me.PanelPayment.Controls.Add(Me.Label6)
        Me.PanelPayment.Controls.Add(Me.cboGender)
        Me.PanelPayment.Controls.Add(Me.txtRequest)
        Me.PanelPayment.Controls.Add(Me.txtFullName)
        Me.PanelPayment.Controls.Add(Me.Label4)
        Me.PanelPayment.Controls.Add(Me.Label3)
        Me.PanelPayment.Controls.Add(Me.Label2)
        Me.PanelPayment.Controls.Add(Me.Label1)
        Me.PanelPayment.Controls.Add(Me.txtPaymentAmount)
        Me.PanelPayment.Controls.Add(Me.Label12)
        Me.PanelPayment.Controls.Add(Me.Label11)
        Me.PanelPayment.Controls.Add(Me.cboBlock)
        Me.PanelPayment.Controls.Add(Me.btnConfirm)
        Me.PanelPayment.Controls.Add(Me.btnClear)
        Me.PanelPayment.Controls.Add(Me.btnCancel)
        Me.PanelPayment.Controls.Add(Me.pcbCOD)
        Me.PanelPayment.Controls.Add(Me.pcbVisaMaster)
        Me.PanelPayment.Controls.Add(Me.cboVillage)
        Me.PanelPayment.Controls.Add(Me.Label10)
        Me.PanelPayment.Controls.Add(Me.Label9)
        Me.PanelPayment.Controls.Add(Me.Label5)
        Me.PanelPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPayment.Location = New System.Drawing.Point(0, 0)
        Me.PanelPayment.Name = "PanelPayment"
        Me.PanelPayment.Size = New System.Drawing.Size(982, 700)
        Me.PanelPayment.TabIndex = 0
        '
        'txtContactNo
        '
        Me.txtContactNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtContactNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(282, 489)
        Me.txtContactNo.Mask = "900-000 0000"
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtContactNo.Size = New System.Drawing.Size(310, 34)
        Me.txtContactNo.TabIndex = 4
        '
        'txtMatricNo
        '
        Me.txtMatricNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMatricNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricNo.Location = New System.Drawing.Point(279, 241)
        Me.txtMatricNo.Mask = "00000000"
        Me.txtMatricNo.Name = "txtMatricNo"
        Me.txtMatricNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtMatricNo.Size = New System.Drawing.Size(267, 34)
        Me.txtMatricNo.TabIndex = 1
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMethod.ForeColor = System.Drawing.Color.Red
        Me.lblMethod.Location = New System.Drawing.Point(108, 860)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(67, 23)
        Me.lblMethod.TabIndex = 79
        Me.lblMethod.Text = "*Invalid"
        Me.lblMethod.Visible = False
        '
        'lblVillage
        '
        Me.lblVillage.AutoSize = True
        Me.lblVillage.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVillage.ForeColor = System.Drawing.Color.Red
        Me.lblVillage.Location = New System.Drawing.Point(681, 564)
        Me.lblVillage.Name = "lblVillage"
        Me.lblVillage.Size = New System.Drawing.Size(67, 23)
        Me.lblVillage.TabIndex = 78
        Me.lblVillage.Text = "*Invalid"
        Me.lblVillage.Visible = False
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.ForeColor = System.Drawing.Color.Red
        Me.lblContactNo.Location = New System.Drawing.Point(598, 494)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(67, 23)
        Me.lblContactNo.TabIndex = 77
        Me.lblContactNo.Text = "*Invalid"
        Me.lblContactNo.Visible = False
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Red
        Me.lblGender.Location = New System.Drawing.Point(418, 306)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(67, 23)
        Me.lblGender.TabIndex = 76
        Me.lblGender.Text = "*Invalid"
        Me.lblGender.Visible = False
        '
        'lblMatricNo
        '
        Me.lblMatricNo.AutoSize = True
        Me.lblMatricNo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricNo.ForeColor = System.Drawing.Color.Red
        Me.lblMatricNo.Location = New System.Drawing.Point(552, 249)
        Me.lblMatricNo.Name = "lblMatricNo"
        Me.lblMatricNo.Size = New System.Drawing.Size(67, 23)
        Me.lblMatricNo.TabIndex = 75
        Me.lblMatricNo.Text = "*Invalid"
        Me.lblMatricNo.Visible = False
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.Red
        Me.lblFullName.Location = New System.Drawing.Point(838, 190)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(67, 23)
        Me.lblFullName.TabIndex = 74
        Me.lblFullName.Text = "*Invalid"
        Me.lblFullName.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(858, 1067)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 58)
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(406, 696)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 28)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "MYR"
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
        Me.btnMinus.Location = New System.Drawing.Point(281, 626)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(40, 34)
        Me.btnMinus.TabIndex = 71
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
        Me.btnPlus.Location = New System.Drawing.Point(396, 626)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(40, 34)
        Me.btnPlus.TabIndex = 70
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(321, 626)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(79, 34)
        Me.txtQty.TabIndex = 7
        Me.txtQty.Text = "1"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblServiceSeller
        '
        Me.lblServiceSeller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblServiceSeller.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceSeller.Location = New System.Drawing.Point(282, 76)
        Me.lblServiceSeller.Name = "lblServiceSeller"
        Me.lblServiceSeller.Size = New System.Drawing.Size(556, 32)
        Me.lblServiceSeller.TabIndex = 68
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(49, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(170, 28)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Service Provider :"
        '
        'lblServiceName
        '
        Me.lblServiceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblServiceName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceName.Location = New System.Drawing.Point(282, 135)
        Me.lblServiceName.Name = "lblServiceName"
        Me.lblServiceName.Size = New System.Drawing.Size(556, 32)
        Me.lblServiceName.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 28)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Service Name :"
        '
        'cboGender
        '
        Me.cboGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Sans Serif Collection", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Gender", "Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(279, 301)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(121, 37)
        Me.cboGender.TabIndex = 2
        '
        'txtRequest
        '
        Me.txtRequest.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRequest.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequest.Location = New System.Drawing.Point(282, 359)
        Me.txtRequest.Multiline = True
        Me.txtRequest.Name = "txtRequest"
        Me.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRequest.Size = New System.Drawing.Size(550, 99)
        Me.txtRequest.TabIndex = 3
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(279, 185)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(553, 34)
        Me.txtFullName.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 28)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Request :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 28)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Gender :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 28)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Matric No :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 28)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Full Name :"
        '
        'txtPaymentAmount
        '
        Me.txtPaymentAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPaymentAmount.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.txtPaymentAmount.Location = New System.Drawing.Point(279, 692)
        Me.txtPaymentAmount.Name = "txtPaymentAmount"
        Me.txtPaymentAmount.ReadOnly = True
        Me.txtPaymentAmount.Size = New System.Drawing.Size(121, 36)
        Me.txtPaymentAmount.TabIndex = 8
        Me.txtPaymentAmount.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 701)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(182, 28)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Payment Amount :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(102, 632)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 28)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Quantity :"
        '
        'cboBlock
        '
        Me.cboBlock.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBlock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBlock.FormattingEnabled = True
        Me.cboBlock.Items.AddRange(New Object() {"Block", "A", "B", "C", "D", "E", "F", "G", "H"})
        Me.cboBlock.Location = New System.Drawing.Point(489, 555)
        Me.cboBlock.Name = "cboBlock"
        Me.cboBlock.Size = New System.Drawing.Size(168, 36)
        Me.cboBlock.TabIndex = 6
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_checkmark_40
        Me.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnConfirm.Location = New System.Drawing.Point(703, 1007)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(202, 54)
        Me.btnConfirm.TabIndex = 9
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PaleGreen
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnClear.Location = New System.Drawing.Point(391, 1007)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(202, 54)
        Me.btnClear.TabIndex = 49
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCancel.Location = New System.Drawing.Point(80, 1007)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(202, 54)
        Me.btnCancel.TabIndex = 48
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pcbCOD
        '
        Me.pcbCOD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbCOD.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Cash_On_Delivery
        Me.pcbCOD.Location = New System.Drawing.Point(584, 758)
        Me.pcbCOD.Name = "pcbCOD"
        Me.pcbCOD.Size = New System.Drawing.Size(284, 180)
        Me.pcbCOD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbCOD.TabIndex = 43
        Me.pcbCOD.TabStop = False
        '
        'pcbVisaMaster
        '
        Me.pcbVisaMaster.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pcbVisaMaster.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbVisaMaster.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.VisaMasterCard
        Me.pcbVisaMaster.Location = New System.Drawing.Point(279, 758)
        Me.pcbVisaMaster.Name = "pcbVisaMaster"
        Me.pcbVisaMaster.Size = New System.Drawing.Size(279, 180)
        Me.pcbVisaMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbVisaMaster.TabIndex = 42
        Me.pcbVisaMaster.TabStop = False
        '
        'cboVillage
        '
        Me.cboVillage.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboVillage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVillage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVillage.FormattingEnabled = True
        Me.cboVillage.Items.AddRange(New Object() {"Village", "V1", "V2", "V3", "V4", "V5", "V6"})
        Me.cboVillage.Location = New System.Drawing.Point(282, 555)
        Me.cboVillage.Name = "cboVillage"
        Me.cboVillage.Size = New System.Drawing.Size(168, 36)
        Me.cboVillage.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(122, 564)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 28)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Village :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(78, 489)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 28)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Contact No :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(102, 786)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 56)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Payment " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Method :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Purple
        Me.Panel2.Controls.Add(Me.lblStoredServiceID)
        Me.Panel2.Controls.Add(Me.pcbClosePayment)
        Me.Panel2.Controls.Add(Me.lblHeader)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(982, 45)
        Me.Panel2.TabIndex = 32
        '
        'lblStoredServiceID
        '
        Me.lblStoredServiceID.AutoSize = True
        Me.lblStoredServiceID.Location = New System.Drawing.Point(50, 13)
        Me.lblStoredServiceID.Name = "lblStoredServiceID"
        Me.lblStoredServiceID.Size = New System.Drawing.Size(0, 16)
        Me.lblStoredServiceID.TabIndex = 6
        Me.lblStoredServiceID.Visible = False
        '
        'pcbClosePayment
        '
        Me.pcbClosePayment.Dock = System.Windows.Forms.DockStyle.Right
        Me.pcbClosePayment.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_close_48
        Me.pcbClosePayment.Location = New System.Drawing.Point(937, 0)
        Me.pcbClosePayment.Name = "pcbClosePayment"
        Me.pcbClosePayment.Size = New System.Drawing.Size(45, 45)
        Me.pcbClosePayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbClosePayment.TabIndex = 5
        Me.pcbClosePayment.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(390, 4)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(200, 42)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "User Payment"
        '
        'frmServicePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 700)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelPayment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmServicePayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ServicePayment"
        Me.PanelPayment.ResumeLayout(False)
        Me.PanelPayment.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbCOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbVisaMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcbClosePayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPayment As Panel
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents pcbCOD As PictureBox
    Friend WithEvents pcbVisaMaster As PictureBox
    Friend WithEvents cboVillage As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents cboBlock As ComboBox
    Friend WithEvents pcbClosePayment As PictureBox
    Friend WithEvents txtPaymentAmount As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblServiceName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents txtRequest As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblServiceSeller As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMethod As Label
    Friend WithEvents lblVillage As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblMatricNo As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtContactNo As MaskedTextBox
    Friend WithEvents txtMatricNo As MaskedTextBox
    Friend WithEvents lblStoredServiceID As Label
End Class
