<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSellerOrder
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVCustomerOrder = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.cellStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cellTransactionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellMatricNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellVillage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellRequestDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellQauntity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CellPaymentAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellPaymentMethod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRowCount = New System.Windows.Forms.Label()
        CType(Me.DGVCustomerOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVCustomerOrder
        '
        Me.DGVCustomerOrder.AllowUserToAddRows = False
        Me.DGVCustomerOrder.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Empty
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Empty
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Empty
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVCustomerOrder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCustomerOrder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVCustomerOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCustomerOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cellStatus, Me.cellTransactionID, Me.cellFullName, Me.cellMatricNo, Me.cellPhone, Me.cellVillage, Me.cellGender, Me.cellRequestDetails, Me.cellQauntity, Me.CellPaymentAmount, Me.cellPaymentMethod})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCustomerOrder.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVCustomerOrder.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGVCustomerOrder.Location = New System.Drawing.Point(0, 0)
        Me.DGVCustomerOrder.Name = "DGVCustomerOrder"
        Me.DGVCustomerOrder.RowHeadersWidth = 51
        Me.DGVCustomerOrder.RowTemplate.Height = 24
        Me.DGVCustomerOrder.Size = New System.Drawing.Size(915, 537)
        Me.DGVCustomerOrder.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Removal_372
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnRefresh.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_refresh_32
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(23, 546)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(214, 90)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'cellStatus
        '
        Me.cellStatus.HeaderText = "Order Status"
        Me.cellStatus.MinimumWidth = 6
        Me.cellStatus.Name = "cellStatus"
        Me.cellStatus.Width = 110
        '
        'cellTransactionID
        '
        Me.cellTransactionID.HeaderText = "TransactionID"
        Me.cellTransactionID.MinimumWidth = 6
        Me.cellTransactionID.Name = "cellTransactionID"
        Me.cellTransactionID.Width = 110
        '
        'cellFullName
        '
        Me.cellFullName.HeaderText = "Full Name"
        Me.cellFullName.MinimumWidth = 6
        Me.cellFullName.Name = "cellFullName"
        Me.cellFullName.Width = 130
        '
        'cellMatricNo
        '
        Me.cellMatricNo.HeaderText = "Matric No"
        Me.cellMatricNo.MinimumWidth = 6
        Me.cellMatricNo.Name = "cellMatricNo"
        Me.cellMatricNo.Width = 120
        '
        'cellPhone
        '
        Me.cellPhone.HeaderText = "Contact No"
        Me.cellPhone.MinimumWidth = 6
        Me.cellPhone.Name = "cellPhone"
        Me.cellPhone.Width = 120
        '
        'cellVillage
        '
        Me.cellVillage.HeaderText = "Village"
        Me.cellVillage.MinimumWidth = 6
        Me.cellVillage.Name = "cellVillage"
        Me.cellVillage.Width = 75
        '
        'cellGender
        '
        Me.cellGender.HeaderText = "Gender"
        Me.cellGender.MinimumWidth = 6
        Me.cellGender.Name = "cellGender"
        Me.cellGender.Width = 75
        '
        'cellRequestDetails
        '
        Me.cellRequestDetails.HeaderText = "Requests"
        Me.cellRequestDetails.MinimumWidth = 6
        Me.cellRequestDetails.Name = "cellRequestDetails"
        Me.cellRequestDetails.Width = 200
        '
        'cellQauntity
        '
        Me.cellQauntity.HeaderText = "Qty"
        Me.cellQauntity.MinimumWidth = 6
        Me.cellQauntity.Name = "cellQauntity"
        Me.cellQauntity.Width = 40
        '
        'CellPaymentAmount
        '
        Me.CellPaymentAmount.HeaderText = "Bill"
        Me.CellPaymentAmount.MinimumWidth = 6
        Me.CellPaymentAmount.Name = "CellPaymentAmount"
        Me.CellPaymentAmount.Width = 115
        '
        'cellPaymentMethod
        '
        Me.cellPaymentMethod.HeaderText = "Payment Method"
        Me.cellPaymentMethod.MinimumWidth = 6
        Me.cellPaymentMethod.Name = "cellPaymentMethod"
        Me.cellPaymentMethod.Width = 125
        '
        'lblRowCount
        '
        Me.lblRowCount.AutoSize = True
        Me.lblRowCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRowCount.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRowCount.ForeColor = System.Drawing.Color.White
        Me.lblRowCount.Location = New System.Drawing.Point(388, 567)
        Me.lblRowCount.Name = "lblRowCount"
        Me.lblRowCount.Size = New System.Drawing.Size(311, 48)
        Me.lblRowCount.TabIndex = 4
        Me.lblRowCount.Text = "Incomplete Order :"
        '
        'frmSellerOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Controls.Add(Me.lblRowCount)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DGVCustomerOrder)
        Me.Name = "frmSellerOrder"
        Me.Size = New System.Drawing.Size(915, 655)
        CType(Me.DGVCustomerOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVCustomerOrder As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents cellStatus As DataGridViewCheckBoxColumn
    Friend WithEvents cellTransactionID As DataGridViewTextBoxColumn
    Friend WithEvents cellFullName As DataGridViewTextBoxColumn
    Friend WithEvents cellMatricNo As DataGridViewTextBoxColumn
    Friend WithEvents cellPhone As DataGridViewTextBoxColumn
    Friend WithEvents cellVillage As DataGridViewTextBoxColumn
    Friend WithEvents cellGender As DataGridViewTextBoxColumn
    Friend WithEvents cellRequestDetails As DataGridViewTextBoxColumn
    Friend WithEvents cellQauntity As DataGridViewTextBoxColumn
    Friend WithEvents CellPaymentAmount As DataGridViewTextBoxColumn
    Friend WithEvents cellPaymentMethod As DataGridViewTextBoxColumn
    Friend WithEvents lblRowCount As Label
End Class
