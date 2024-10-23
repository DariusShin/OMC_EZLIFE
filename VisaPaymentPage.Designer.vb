<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisaPaymentPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisaPaymentPage))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pcbClosePayment = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelVisaCard = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblExpiryYear = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelCardNo = New System.Windows.Forms.Panel()
        Me.lblCardNum4 = New System.Windows.Forms.Label()
        Me.lblCardNum3 = New System.Windows.Forms.Label()
        Me.lblCardNum2 = New System.Windows.Forms.Label()
        Me.lblCardNum1 = New System.Windows.Forms.Label()
        Me.lblExpiryMonth = New System.Windows.Forms.Label()
        Me.lblCardHolder = New System.Windows.Forms.Label()
        Me.pcbCardType = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCardNo1 = New System.Windows.Forms.TextBox()
        Me.txtCardNo2 = New System.Windows.Forms.TextBox()
        Me.txtCardNo3 = New System.Windows.Forms.TextBox()
        Me.txtCardNo4 = New System.Windows.Forms.TextBox()
        Me.txtCardHolder = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboExpiryMonth = New System.Windows.Forms.ComboBox()
        Me.cboExpiryYear = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbtVisa = New System.Windows.Forms.RadioButton()
        Me.rbtMaster = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbClosePayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelVisaCard.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelCardNo.SuspendLayout()
        CType(Me.pcbCardType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.pcbClosePayment)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(880, 45)
        Me.Panel2.TabIndex = 33
        '
        'pcbClosePayment
        '
        Me.pcbClosePayment.Dock = System.Windows.Forms.DockStyle.Right
        Me.pcbClosePayment.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_close_48
        Me.pcbClosePayment.Location = New System.Drawing.Point(835, 0)
        Me.pcbClosePayment.Name = "pcbClosePayment"
        Me.pcbClosePayment.Size = New System.Drawing.Size(45, 45)
        Me.pcbClosePayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbClosePayment.TabIndex = 5
        Me.pcbClosePayment.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(316, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(264, 42)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Visa Card Payment"
        '
        'PanelVisaCard
        '
        Me.PanelVisaCard.BackColor = System.Drawing.Color.LightBlue
        Me.PanelVisaCard.Controls.Add(Me.Panel1)
        Me.PanelVisaCard.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelVisaCard.Location = New System.Drawing.Point(0, 45)
        Me.PanelVisaCard.Name = "PanelVisaCard"
        Me.PanelVisaCard.Size = New System.Drawing.Size(469, 423)
        Me.PanelVisaCard.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Credit_Card_Background
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lblExpiryYear)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.panelCardNo)
        Me.Panel1.Controls.Add(Me.lblExpiryMonth)
        Me.Panel1.Controls.Add(Me.lblCardHolder)
        Me.Panel1.Controls.Add(Me.pcbCardType)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 281)
        Me.Panel1.TabIndex = 0
        '
        'lblExpiryYear
        '
        Me.lblExpiryYear.BackColor = System.Drawing.Color.Transparent
        Me.lblExpiryYear.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpiryYear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblExpiryYear.Location = New System.Drawing.Point(370, 220)
        Me.lblExpiryYear.Name = "lblExpiryYear"
        Me.lblExpiryYear.Size = New System.Drawing.Size(56, 30)
        Me.lblExpiryYear.TabIndex = 7
        Me.lblExpiryYear.Text = "/ 23"
        Me.lblExpiryYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(325, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Expiry Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelCardNo
        '
        Me.panelCardNo.BackColor = System.Drawing.Color.Transparent
        Me.panelCardNo.Controls.Add(Me.lblCardNum4)
        Me.panelCardNo.Controls.Add(Me.lblCardNum3)
        Me.panelCardNo.Controls.Add(Me.lblCardNum2)
        Me.panelCardNo.Controls.Add(Me.lblCardNum1)
        Me.panelCardNo.Location = New System.Drawing.Point(11, 151)
        Me.panelCardNo.Name = "panelCardNo"
        Me.panelCardNo.Size = New System.Drawing.Size(402, 36)
        Me.panelCardNo.TabIndex = 5
        '
        'lblCardNum4
        '
        Me.lblCardNum4.BackColor = System.Drawing.Color.Transparent
        Me.lblCardNum4.Font = New System.Drawing.Font("Sans Serif Collection", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNum4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCardNum4.Location = New System.Drawing.Point(292, 0)
        Me.lblCardNum4.Name = "lblCardNum4"
        Me.lblCardNum4.Size = New System.Drawing.Size(96, 30)
        Me.lblCardNum4.TabIndex = 4
        Me.lblCardNum4.Text = "0000"
        Me.lblCardNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCardNum3
        '
        Me.lblCardNum3.BackColor = System.Drawing.Color.Transparent
        Me.lblCardNum3.Font = New System.Drawing.Font("Sans Serif Collection", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNum3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCardNum3.Location = New System.Drawing.Point(204, 0)
        Me.lblCardNum3.Name = "lblCardNum3"
        Me.lblCardNum3.Size = New System.Drawing.Size(96, 30)
        Me.lblCardNum3.TabIndex = 3
        Me.lblCardNum3.Text = "0000"
        Me.lblCardNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCardNum2
        '
        Me.lblCardNum2.BackColor = System.Drawing.Color.Transparent
        Me.lblCardNum2.Font = New System.Drawing.Font("Sans Serif Collection", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNum2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCardNum2.Location = New System.Drawing.Point(113, 0)
        Me.lblCardNum2.Name = "lblCardNum2"
        Me.lblCardNum2.Size = New System.Drawing.Size(96, 30)
        Me.lblCardNum2.TabIndex = 2
        Me.lblCardNum2.Text = "0000"
        Me.lblCardNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCardNum1
        '
        Me.lblCardNum1.BackColor = System.Drawing.Color.Transparent
        Me.lblCardNum1.Font = New System.Drawing.Font("Sans Serif Collection", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNum1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCardNum1.Location = New System.Drawing.Point(22, 0)
        Me.lblCardNum1.Name = "lblCardNum1"
        Me.lblCardNum1.Size = New System.Drawing.Size(96, 30)
        Me.lblCardNum1.TabIndex = 1
        Me.lblCardNum1.Text = "0000"
        Me.lblCardNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExpiryMonth
        '
        Me.lblExpiryMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblExpiryMonth.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpiryMonth.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblExpiryMonth.Location = New System.Drawing.Point(327, 220)
        Me.lblExpiryMonth.Name = "lblExpiryMonth"
        Me.lblExpiryMonth.Size = New System.Drawing.Size(46, 30)
        Me.lblExpiryMonth.TabIndex = 4
        Me.lblExpiryMonth.Text = "01"
        Me.lblExpiryMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCardHolder
        '
        Me.lblCardHolder.BackColor = System.Drawing.Color.Transparent
        Me.lblCardHolder.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardHolder.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCardHolder.Location = New System.Drawing.Point(15, 237)
        Me.lblCardHolder.Name = "lblCardHolder"
        Me.lblCardHolder.Size = New System.Drawing.Size(315, 30)
        Me.lblCardHolder.TabIndex = 3
        Me.lblCardHolder.Text = "CARD HOLDER"
        Me.lblCardHolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcbCardType
        '
        Me.pcbCardType.BackColor = System.Drawing.Color.Transparent
        Me.pcbCardType.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.visaLogo
        Me.pcbCardType.Location = New System.Drawing.Point(303, 25)
        Me.pcbCardType.Name = "pcbCardType"
        Me.pcbCardType.Size = New System.Drawing.Size(101, 43)
        Me.pcbCardType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbCardType.TabIndex = 2
        Me.pcbCardType.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Credit_Card_Chip
        Me.PictureBox1.Location = New System.Drawing.Point(33, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(484, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 31)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Card Number"
        '
        'txtCardNo1
        '
        Me.txtCardNo1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNo1.Location = New System.Drawing.Point(490, 121)
        Me.txtCardNo1.Name = "txtCardNo1"
        Me.txtCardNo1.Size = New System.Drawing.Size(89, 30)
        Me.txtCardNo1.TabIndex = 0
        '
        'txtCardNo2
        '
        Me.txtCardNo2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNo2.Location = New System.Drawing.Point(585, 121)
        Me.txtCardNo2.Name = "txtCardNo2"
        Me.txtCardNo2.Size = New System.Drawing.Size(89, 30)
        Me.txtCardNo2.TabIndex = 1
        '
        'txtCardNo3
        '
        Me.txtCardNo3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNo3.Location = New System.Drawing.Point(680, 121)
        Me.txtCardNo3.Name = "txtCardNo3"
        Me.txtCardNo3.Size = New System.Drawing.Size(89, 30)
        Me.txtCardNo3.TabIndex = 2
        '
        'txtCardNo4
        '
        Me.txtCardNo4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNo4.Location = New System.Drawing.Point(775, 121)
        Me.txtCardNo4.Name = "txtCardNo4"
        Me.txtCardNo4.Size = New System.Drawing.Size(89, 30)
        Me.txtCardNo4.TabIndex = 3
        '
        'txtCardHolder
        '
        Me.txtCardHolder.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardHolder.Location = New System.Drawing.Point(490, 236)
        Me.txtCardHolder.Name = "txtCardHolder"
        Me.txtCardHolder.Size = New System.Drawing.Size(374, 30)
        Me.txtCardHolder.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(484, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 31)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Card Holder (Full Name)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(475, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 31)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Expiry Date"
        '
        'txtCVV
        '
        Me.txtCVV.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCVV.Location = New System.Drawing.Point(642, 336)
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(76, 30)
        Me.txtCVV.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(636, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 31)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "CVV"
        '
        'cboExpiryMonth
        '
        Me.cboExpiryMonth.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExpiryMonth.FormattingEnabled = True
        Me.cboExpiryMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cboExpiryMonth.Location = New System.Drawing.Point(481, 336)
        Me.cboExpiryMonth.Name = "cboExpiryMonth"
        Me.cboExpiryMonth.Size = New System.Drawing.Size(50, 31)
        Me.cboExpiryMonth.TabIndex = 5
        '
        'cboExpiryYear
        '
        Me.cboExpiryYear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExpiryYear.FormattingEnabled = True
        Me.cboExpiryYear.Items.AddRange(New Object() {"2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033"})
        Me.cboExpiryYear.Location = New System.Drawing.Point(537, 336)
        Me.cboExpiryYear.Name = "cboExpiryYear"
        Me.cboExpiryYear.Size = New System.Drawing.Size(82, 31)
        Me.cboExpiryYear.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(747, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 31)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Type"
        '
        'rbtVisa
        '
        Me.rbtVisa.AutoSize = True
        Me.rbtVisa.Checked = True
        Me.rbtVisa.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtVisa.Location = New System.Drawing.Point(741, 340)
        Me.rbtVisa.Name = "rbtVisa"
        Me.rbtVisa.Size = New System.Drawing.Size(103, 27)
        Me.rbtVisa.TabIndex = 8
        Me.rbtVisa.TabStop = True
        Me.rbtVisa.Text = "Visa Card"
        Me.rbtVisa.UseVisualStyleBackColor = True
        '
        'rbtMaster
        '
        Me.rbtMaster.AutoSize = True
        Me.rbtMaster.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMaster.Location = New System.Drawing.Point(741, 373)
        Me.rbtMaster.Name = "rbtMaster"
        Me.rbtMaster.Size = New System.Drawing.Size(125, 27)
        Me.rbtMaster.TabIndex = 9
        Me.rbtMaster.Text = "Master Card"
        Me.rbtMaster.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PaleGreen
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_reset_32
        Me.btnClear.Location = New System.Drawing.Point(481, 392)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 54)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmVisaPaymentPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(880, 468)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.rbtMaster)
        Me.Controls.Add(Me.rbtVisa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboExpiryYear)
        Me.Controls.Add(Me.cboExpiryMonth)
        Me.Controls.Add(Me.txtCVV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCardHolder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCardNo4)
        Me.Controls.Add(Me.txtCardNo3)
        Me.Controls.Add(Me.txtCardNo2)
        Me.Controls.Add(Me.txtCardNo1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelVisaCard)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVisaPaymentPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VisaPaymentPage"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcbClosePayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVisaCard.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.panelCardNo.ResumeLayout(False)
        CType(Me.pcbCardType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents pcbClosePayment As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelVisaCard As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCardNum1 As Label
    Friend WithEvents pcbCardType As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblExpiryMonth As Label
    Friend WithEvents lblCardHolder As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCardNo1 As TextBox
    Friend WithEvents txtCardNo2 As TextBox
    Friend WithEvents txtCardNo3 As TextBox
    Friend WithEvents txtCardNo4 As TextBox
    Friend WithEvents panelCardNo As Panel
    Friend WithEvents lblCardNum4 As Label
    Friend WithEvents lblCardNum3 As Label
    Friend WithEvents lblCardNum2 As Label
    Friend WithEvents txtCardHolder As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboExpiryMonth As ComboBox
    Friend WithEvents cboExpiryYear As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblExpiryYear As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rbtVisa As RadioButton
    Friend WithEvents rbtMaster As RadioButton
    Friend WithEvents btnClear As Button
End Class
