<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFeedBack
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFeedback = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pcbStar5 = New System.Windows.Forms.PictureBox()
        Me.pcbStar4 = New System.Windows.Forms.PictureBox()
        Me.pcbStar3 = New System.Windows.Forms.PictureBox()
        Me.pcbStar2 = New System.Windows.Forms.PictureBox()
        Me.pcbStar1 = New System.Windows.Forms.PictureBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSentComment = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReceiver = New System.Windows.Forms.TextBox()
        Me.lblInvalidRating = New System.Windows.Forms.Label()
        Me.lblStoredServiceID = New System.Windows.Forms.Label()
        Me.lblInvalidComment = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbStar5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rating :"
        '
        'lblFeedback
        '
        Me.lblFeedback.AutoSize = True
        Me.lblFeedback.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedback.Location = New System.Drawing.Point(37, 214)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(133, 37)
        Me.lblFeedback.TabIndex = 1
        Me.lblFeedback.Text = "Feedback :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pcbStar5)
        Me.Panel1.Controls.Add(Me.pcbStar4)
        Me.Panel1.Controls.Add(Me.pcbStar3)
        Me.Panel1.Controls.Add(Me.pcbStar2)
        Me.Panel1.Controls.Add(Me.pcbStar1)
        Me.Panel1.Location = New System.Drawing.Point(39, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(427, 65)
        Me.Panel1.TabIndex = 2
        '
        'pcbStar5
        '
        Me.pcbStar5.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar5.Location = New System.Drawing.Point(327, 6)
        Me.pcbStar5.Name = "pcbStar5"
        Me.pcbStar5.Size = New System.Drawing.Size(57, 50)
        Me.pcbStar5.TabIndex = 4
        Me.pcbStar5.TabStop = False
        '
        'pcbStar4
        '
        Me.pcbStar4.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar4.Location = New System.Drawing.Point(250, 6)
        Me.pcbStar4.Name = "pcbStar4"
        Me.pcbStar4.Size = New System.Drawing.Size(57, 50)
        Me.pcbStar4.TabIndex = 3
        Me.pcbStar4.TabStop = False
        '
        'pcbStar3
        '
        Me.pcbStar3.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar3.Location = New System.Drawing.Point(175, 6)
        Me.pcbStar3.Name = "pcbStar3"
        Me.pcbStar3.Size = New System.Drawing.Size(57, 50)
        Me.pcbStar3.TabIndex = 2
        Me.pcbStar3.TabStop = False
        '
        'pcbStar2
        '
        Me.pcbStar2.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar2.Location = New System.Drawing.Point(99, 6)
        Me.pcbStar2.Name = "pcbStar2"
        Me.pcbStar2.Size = New System.Drawing.Size(57, 50)
        Me.pcbStar2.TabIndex = 1
        Me.pcbStar2.TabStop = False
        '
        'pcbStar1
        '
        Me.pcbStar1.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar1.Location = New System.Drawing.Point(24, 6)
        Me.pcbStar1.Name = "pcbStar1"
        Me.pcbStar1.Size = New System.Drawing.Size(57, 50)
        Me.pcbStar1.TabIndex = 0
        Me.pcbStar1.TabStop = False
        '
        'txtComment
        '
        Me.txtComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtComment.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.Location = New System.Drawing.Point(39, 254)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComment.Size = New System.Drawing.Size(836, 331)
        Me.txtComment.TabIndex = 3
        Me.txtComment.Text = "This is too Good !"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.LightSalmon
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_reset_32
        Me.btnReset.Location = New System.Drawing.Point(707, 103)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(168, 48)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSentComment
        '
        Me.btnSentComment.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnSentComment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSentComment.FlatAppearance.BorderSize = 0
        Me.btnSentComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSentComment.Font = New System.Drawing.Font("Sans Serif Collection", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSentComment.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_send_32
        Me.btnSentComment.Location = New System.Drawing.Point(707, 40)
        Me.btnSentComment.Name = "btnSentComment"
        Me.btnSentComment.Size = New System.Drawing.Size(168, 48)
        Me.btnSentComment.TabIndex = 4
        Me.btnSentComment.Text = "SEND"
        Me.btnSentComment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSentComment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSentComment.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 37)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "To :"
        '
        'txtReceiver
        '
        Me.txtReceiver.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtReceiver.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiver.Location = New System.Drawing.Point(44, 164)
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.ReadOnly = True
        Me.txtReceiver.Size = New System.Drawing.Size(422, 34)
        Me.txtReceiver.TabIndex = 8
        '
        'lblInvalidRating
        '
        Me.lblInvalidRating.AutoSize = True
        Me.lblInvalidRating.BackColor = System.Drawing.SystemColors.Control
        Me.lblInvalidRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidRating.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidRating.Location = New System.Drawing.Point(151, 17)
        Me.lblInvalidRating.Name = "lblInvalidRating"
        Me.lblInvalidRating.Size = New System.Drawing.Size(156, 20)
        Me.lblInvalidRating.TabIndex = 9
        Me.lblInvalidRating.Text = "*Choose your rating"
        Me.lblInvalidRating.Visible = False
        '
        'lblStoredServiceID
        '
        Me.lblStoredServiceID.AutoSize = True
        Me.lblStoredServiceID.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStoredServiceID.Location = New System.Drawing.Point(542, 166)
        Me.lblStoredServiceID.Name = "lblStoredServiceID"
        Me.lblStoredServiceID.Size = New System.Drawing.Size(0, 37)
        Me.lblStoredServiceID.TabIndex = 10
        Me.lblStoredServiceID.Visible = False
        '
        'lblInvalidComment
        '
        Me.lblInvalidComment.AutoSize = True
        Me.lblInvalidComment.BackColor = System.Drawing.SystemColors.Control
        Me.lblInvalidComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidComment.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidComment.Location = New System.Drawing.Point(191, 222)
        Me.lblInvalidComment.Name = "lblInvalidComment"
        Me.lblInvalidComment.Size = New System.Drawing.Size(137, 20)
        Me.lblInvalidComment.TabIndex = 11
        Me.lblInvalidComment.Text = "*Write something"
        Me.lblInvalidComment.Visible = False
        '
        'frmFeedBack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblInvalidComment)
        Me.Controls.Add(Me.lblStoredServiceID)
        Me.Controls.Add(Me.lblInvalidRating)
        Me.Controls.Add(Me.txtReceiver)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSentComment)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblFeedback)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFeedBack"
        Me.Size = New System.Drawing.Size(915, 600)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pcbStar5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblFeedback As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtComment As TextBox
    Friend WithEvents pcbStar2 As PictureBox
    Friend WithEvents pcbStar1 As PictureBox
    Friend WithEvents pcbStar5 As PictureBox
    Friend WithEvents pcbStar4 As PictureBox
    Friend WithEvents pcbStar3 As PictureBox
    Friend WithEvents btnSentComment As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtReceiver As TextBox
    Friend WithEvents lblInvalidRating As Label
    Friend WithEvents lblStoredServiceID As Label
    Friend WithEvents lblInvalidComment As Label
End Class
