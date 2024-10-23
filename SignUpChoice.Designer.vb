<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSignUpChoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignUpChoice))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonSetControl1 = New OMC_EZLIFE_May2023.ButtonSetControl()
        Me.scSignUpchoice = New System.Windows.Forms.SplitContainer()
        Me.lblBuyer = New System.Windows.Forms.Label()
        Me.lblSeller = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.scSignUpchoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scSignUpchoice.Panel1.SuspendLayout()
        Me.scSignUpchoice.Panel2.SuspendLayout()
        Me.scSignUpchoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ButtonSetControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(832, 45)
        Me.Panel1.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_u_turn_to_left_40__1_
        Me.btnBack.Location = New System.Drawing.Point(0, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(65, 42)
        Me.btnBack.TabIndex = 2
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sans Serif Collection", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(284, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 42)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sign Up Choice"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonSetControl1
        '
        Me.ButtonSetControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonSetControl1.Location = New System.Drawing.Point(746, 0)
        Me.ButtonSetControl1.Name = "ButtonSetControl1"
        Me.ButtonSetControl1.Size = New System.Drawing.Size(86, 45)
        Me.ButtonSetControl1.TabIndex = 0
        '
        'scSignUpchoice
        '
        Me.scSignUpchoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scSignUpchoice.Location = New System.Drawing.Point(0, 45)
        Me.scSignUpchoice.Name = "scSignUpchoice"
        '
        'scSignUpchoice.Panel1
        '
        Me.scSignUpchoice.Panel1.BackColor = System.Drawing.Color.White
        Me.scSignUpchoice.Panel1.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Customers
        Me.scSignUpchoice.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.scSignUpchoice.Panel1.Controls.Add(Me.lblBuyer)
        Me.scSignUpchoice.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        '
        'scSignUpchoice.Panel2
        '
        Me.scSignUpchoice.Panel2.BackColor = System.Drawing.Color.White
        Me.scSignUpchoice.Panel2.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.Services_Provider
        Me.scSignUpchoice.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.scSignUpchoice.Panel2.Controls.Add(Me.lblSeller)
        Me.scSignUpchoice.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.scSignUpchoice.Size = New System.Drawing.Size(832, 508)
        Me.scSignUpchoice.SplitterDistance = 408
        Me.scSignUpchoice.TabIndex = 1
        '
        'lblBuyer
        '
        Me.lblBuyer.AutoSize = True
        Me.lblBuyer.Font = New System.Drawing.Font("Stencil", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuyer.Location = New System.Drawing.Point(47, 442)
        Me.lblBuyer.Name = "lblBuyer"
        Me.lblBuyer.Size = New System.Drawing.Size(315, 42)
        Me.lblBuyer.TabIndex = 0
        Me.lblBuyer.Text = "Services Buyer"
        '
        'lblSeller
        '
        Me.lblSeller.AutoSize = True
        Me.lblSeller.Font = New System.Drawing.Font("Stencil", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeller.Location = New System.Drawing.Point(32, 442)
        Me.lblSeller.Name = "lblSeller"
        Me.lblSeller.Size = New System.Drawing.Size(359, 42)
        Me.lblSeller.TabIndex = 1
        Me.lblSeller.Text = "Services Provider"
        '
        'frmSignUpChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(832, 553)
        Me.Controls.Add(Me.scSignUpchoice)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSignUpChoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUpChoice"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.scSignUpchoice.Panel1.ResumeLayout(False)
        Me.scSignUpchoice.Panel1.PerformLayout()
        Me.scSignUpchoice.Panel2.ResumeLayout(False)
        Me.scSignUpchoice.Panel2.PerformLayout()
        CType(Me.scSignUpchoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scSignUpchoice.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonSetControl1 As ButtonSetControl
    Friend WithEvents scSignUpchoice As SplitContainer
    Friend WithEvents lblBuyer As Label
    Friend WithEvents lblSeller As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBack As Button
End Class
