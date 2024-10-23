<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuyerReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuyerReceipt))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblStoredServiceID = New System.Windows.Forms.Label()
        Me.pcbClosePayment = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelBase = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblSellerContact = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblBuyerContact = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblReceiptNo = New System.Windows.Forms.Label()
        Me.lblTotalBold = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblCompleteTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPurcahsedTime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltotalPayment = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblServicePrice = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMatricNo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBuyerName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblServiceName = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblServiceSeller = New System.Windows.Forms.Label()
        Me.SaveFileDialogReceipt = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbClosePayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelBase.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblStoredServiceID)
        Me.Panel2.Controls.Add(Me.pcbClosePayment)
        Me.Panel2.Controls.Add(Me.lblHeader)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(495, 45)
        Me.Panel2.TabIndex = 33
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
        Me.pcbClosePayment.Location = New System.Drawing.Point(450, 0)
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
        Me.lblHeader.ForeColor = System.Drawing.Color.Black
        Me.lblHeader.Location = New System.Drawing.Point(134, 3)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(222, 42)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Service Receipt"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Controls.Add(Me.PanelBase)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 640)
        Me.Panel1.TabIndex = 34
        '
        'PanelBase
        '
        Me.PanelBase.BackColor = System.Drawing.Color.White
        Me.PanelBase.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_666
        Me.PanelBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelBase.Controls.Add(Me.Label19)
        Me.PanelBase.Controls.Add(Me.lblSellerContact)
        Me.PanelBase.Controls.Add(Me.btnPrint)
        Me.PanelBase.Controls.Add(Me.Label18)
        Me.PanelBase.Controls.Add(Me.lblBuyerContact)
        Me.PanelBase.Controls.Add(Me.Label17)
        Me.PanelBase.Controls.Add(Me.lblReceiptNo)
        Me.PanelBase.Controls.Add(Me.lblTotalBold)
        Me.PanelBase.Controls.Add(Me.Label16)
        Me.PanelBase.Controls.Add(Me.Label15)
        Me.PanelBase.Controls.Add(Me.Label14)
        Me.PanelBase.Controls.Add(Me.lblPaymentMethod)
        Me.PanelBase.Controls.Add(Me.Label13)
        Me.PanelBase.Controls.Add(Me.Label7)
        Me.PanelBase.Controls.Add(Me.Label6)
        Me.PanelBase.Controls.Add(Me.Label5)
        Me.PanelBase.Controls.Add(Me.Label12)
        Me.PanelBase.Controls.Add(Me.lblCompleteTime)
        Me.PanelBase.Controls.Add(Me.Label1)
        Me.PanelBase.Controls.Add(Me.lblPurcahsedTime)
        Me.PanelBase.Controls.Add(Me.Label2)
        Me.PanelBase.Controls.Add(Me.lblQuantity)
        Me.PanelBase.Controls.Add(Me.Label3)
        Me.PanelBase.Controls.Add(Me.lbltotalPayment)
        Me.PanelBase.Controls.Add(Me.Label4)
        Me.PanelBase.Controls.Add(Me.lblServicePrice)
        Me.PanelBase.Controls.Add(Me.Label10)
        Me.PanelBase.Controls.Add(Me.lblMatricNo)
        Me.PanelBase.Controls.Add(Me.Label9)
        Me.PanelBase.Controls.Add(Me.lblBuyerName)
        Me.PanelBase.Controls.Add(Me.Label8)
        Me.PanelBase.Controls.Add(Me.lblServiceName)
        Me.PanelBase.Controls.Add(Me.Label11)
        Me.PanelBase.Controls.Add(Me.lblServiceSeller)
        Me.PanelBase.Location = New System.Drawing.Point(12, 6)
        Me.PanelBase.Name = "PanelBase"
        Me.PanelBase.Size = New System.Drawing.Size(470, 622)
        Me.PanelBase.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(53, 139)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 25)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Contact No :"
        '
        'lblSellerContact
        '
        Me.lblSellerContact.AutoSize = True
        Me.lblSellerContact.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellerContact.Location = New System.Drawing.Point(177, 139)
        Me.lblSellerContact.Name = "lblSellerContact"
        Me.lblSellerContact.Size = New System.Drawing.Size(25, 25)
        Me.lblSellerContact.TabIndex = 38
        Me.lblSellerContact.Text = "D"
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_txt_24
        Me.btnPrint.Location = New System.Drawing.Point(30, 565)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(136, 49)
        Me.btnPrint.TabIndex = 36
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(52, 268)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 25)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Contact No :"
        '
        'lblBuyerContact
        '
        Me.lblBuyerContact.AutoSize = True
        Me.lblBuyerContact.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuyerContact.Location = New System.Drawing.Point(177, 268)
        Me.lblBuyerContact.Name = "lblBuyerContact"
        Me.lblBuyerContact.Size = New System.Drawing.Size(25, 25)
        Me.lblBuyerContact.TabIndex = 35
        Me.lblBuyerContact.Text = "D"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(64, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 28)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Receipt No :"
        '
        'lblReceiptNo
        '
        Me.lblReceiptNo.AutoSize = True
        Me.lblReceiptNo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptNo.Location = New System.Drawing.Point(204, 12)
        Me.lblReceiptNo.Name = "lblReceiptNo"
        Me.lblReceiptNo.Size = New System.Drawing.Size(26, 28)
        Me.lblReceiptNo.TabIndex = 33
        Me.lblReceiptNo.Text = "D"
        '
        'lblTotalBold
        '
        Me.lblTotalBold.AutoSize = True
        Me.lblTotalBold.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBold.Location = New System.Drawing.Point(308, 569)
        Me.lblTotalBold.Name = "lblTotalBold"
        Me.lblTotalBold.Size = New System.Drawing.Size(143, 38)
        Me.lblTotalBold.TabIndex = 31
        Me.lblTotalBold.Text = "0.00 MYR"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(197, 570)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 38)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Total  :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(0, 548)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(468, 25)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "*********************************************************" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 358)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(157, 25)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Payment Method :"
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.AutoSize = True
        Me.lblPaymentMethod.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentMethod.Location = New System.Drawing.Point(177, 358)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(25, 25)
        Me.lblPaymentMethod.TabIndex = 28
        Me.lblPaymentMethod.Text = "D"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 422)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(468, 25)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "*********************************************************" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(468, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "*********************************************************" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(468, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "*********************************************************" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(468, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "*********************************************************" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 25)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Payment Date  :"
        '
        'lblCompleteTime
        '
        Me.lblCompleteTime.AutoSize = True
        Me.lblCompleteTime.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompleteTime.Location = New System.Drawing.Point(177, 397)
        Me.lblCompleteTime.Name = "lblCompleteTime"
        Me.lblCompleteTime.Size = New System.Drawing.Size(25, 25)
        Me.lblCompleteTime.TabIndex = 22
        Me.lblCompleteTime.Text = "D"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Service Seller :"
        '
        'lblPurcahsedTime
        '
        Me.lblPurcahsedTime.AutoSize = True
        Me.lblPurcahsedTime.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurcahsedTime.Location = New System.Drawing.Point(177, 318)
        Me.lblPurcahsedTime.Name = "lblPurcahsedTime"
        Me.lblPurcahsedTime.Size = New System.Drawing.Size(25, 25)
        Me.lblPurcahsedTime.TabIndex = 21
        Me.lblPurcahsedTime.Text = "D"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Service Name :"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(177, 483)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(25, 25)
        Me.lblQuantity.TabIndex = 20
        Me.lblQuantity.Text = "D"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Buyer Name :"
        '
        'lbltotalPayment
        '
        Me.lbltotalPayment.AutoSize = True
        Me.lbltotalPayment.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalPayment.Location = New System.Drawing.Point(177, 523)
        Me.lbltotalPayment.Name = "lbltotalPayment"
        Me.lbltotalPayment.Size = New System.Drawing.Size(25, 25)
        Me.lbltotalPayment.TabIndex = 19
        Me.lbltotalPayment.Text = "D"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Matric No :"
        '
        'lblServicePrice
        '
        Me.lblServicePrice.AutoSize = True
        Me.lblServicePrice.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicePrice.Location = New System.Drawing.Point(177, 447)
        Me.lblServicePrice.Name = "lblServicePrice"
        Me.lblServicePrice.Size = New System.Drawing.Size(25, 25)
        Me.lblServicePrice.TabIndex = 18
        Me.lblServicePrice.Text = "D"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 447)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 25)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Service Price  :"
        '
        'lblMatricNo
        '
        Me.lblMatricNo.AutoSize = True
        Me.lblMatricNo.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricNo.Location = New System.Drawing.Point(176, 228)
        Me.lblMatricNo.Name = "lblMatricNo"
        Me.lblMatricNo.Size = New System.Drawing.Size(25, 25)
        Me.lblMatricNo.TabIndex = 16
        Me.lblMatricNo.Text = "D"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 523)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 25)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Total Payment :"
        '
        'lblBuyerName
        '
        Me.lblBuyerName.AutoSize = True
        Me.lblBuyerName.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuyerName.Location = New System.Drawing.Point(177, 189)
        Me.lblBuyerName.Name = "lblBuyerName"
        Me.lblBuyerName.Size = New System.Drawing.Size(25, 25)
        Me.lblBuyerName.TabIndex = 15
        Me.lblBuyerName.Text = "D"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(75, 483)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Quantity :"
        '
        'lblServiceName
        '
        Me.lblServiceName.AutoSize = True
        Me.lblServiceName.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceName.Location = New System.Drawing.Point(177, 105)
        Me.lblServiceName.Name = "lblServiceName"
        Me.lblServiceName.Size = New System.Drawing.Size(25, 25)
        Me.lblServiceName.TabIndex = 14
        Me.lblServiceName.Text = "D"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 397)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 25)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Complete Time :"
        '
        'lblServiceSeller
        '
        Me.lblServiceSeller.AutoSize = True
        Me.lblServiceSeller.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceSeller.Location = New System.Drawing.Point(177, 71)
        Me.lblServiceSeller.Name = "lblServiceSeller"
        Me.lblServiceSeller.Size = New System.Drawing.Size(25, 25)
        Me.lblServiceSeller.TabIndex = 13
        Me.lblServiceSeller.Text = "D"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmBuyerReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 685)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuyerReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuyerReceipt"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcbClosePayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PanelBase.ResumeLayout(False)
        Me.PanelBase.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblStoredServiceID As Label
    Friend WithEvents pcbClosePayment As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblCompleteTime As Label
    Friend WithEvents lblPurcahsedTime As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lbltotalPayment As Label
    Friend WithEvents lblServicePrice As Label
    Friend WithEvents lblMatricNo As Label
    Friend WithEvents lblBuyerName As Label
    Friend WithEvents lblServiceName As Label
    Friend WithEvents lblServiceSeller As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PanelBase As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTotalBold As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblReceiptNo As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblBuyerContact As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents lblSellerContact As Label
    Friend WithEvents SaveFileDialogReceipt As SaveFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
