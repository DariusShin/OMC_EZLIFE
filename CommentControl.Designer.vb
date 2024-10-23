<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommentControl
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.pcbStar1 = New System.Windows.Forms.PictureBox()
        Me.pcbStar5 = New System.Windows.Forms.PictureBox()
        Me.pcbStar2 = New System.Windows.Forms.PictureBox()
        Me.pcbStar3 = New System.Windows.Forms.PictureBox()
        Me.pcbStar4 = New System.Windows.Forms.PictureBox()
        Me.lblCommentID = New System.Windows.Forms.Label()
        Me.lblServiceName = New System.Windows.Forms.Label()
        Me.pcbDeleteComment = New System.Windows.Forms.PictureBox()
        Me.lblMessageType = New System.Windows.Forms.Label()
        CType(Me.pcbStar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbDeleteComment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(21, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(104, 28)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'txtComment
        '
        Me.txtComment.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.Location = New System.Drawing.Point(11, 74)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComment.Size = New System.Drawing.Size(847, 65)
        Me.txtComment.TabIndex = 1
        '
        'pcbStar1
        '
        Me.pcbStar1.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar1.Location = New System.Drawing.Point(607, 11)
        Me.pcbStar1.Name = "pcbStar1"
        Me.pcbStar1.Size = New System.Drawing.Size(30, 30)
        Me.pcbStar1.TabIndex = 5
        Me.pcbStar1.TabStop = False
        '
        'pcbStar5
        '
        Me.pcbStar5.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar5.Location = New System.Drawing.Point(751, 11)
        Me.pcbStar5.Name = "pcbStar5"
        Me.pcbStar5.Size = New System.Drawing.Size(30, 30)
        Me.pcbStar5.TabIndex = 9
        Me.pcbStar5.TabStop = False
        '
        'pcbStar2
        '
        Me.pcbStar2.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar2.Location = New System.Drawing.Point(643, 11)
        Me.pcbStar2.Name = "pcbStar2"
        Me.pcbStar2.Size = New System.Drawing.Size(30, 30)
        Me.pcbStar2.TabIndex = 6
        Me.pcbStar2.TabStop = False
        '
        'pcbStar3
        '
        Me.pcbStar3.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar3.Location = New System.Drawing.Point(679, 11)
        Me.pcbStar3.Name = "pcbStar3"
        Me.pcbStar3.Size = New System.Drawing.Size(30, 30)
        Me.pcbStar3.TabIndex = 7
        Me.pcbStar3.TabStop = False
        '
        'pcbStar4
        '
        Me.pcbStar4.BackgroundImage = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_star_32__2_
        Me.pcbStar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbStar4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbStar4.Location = New System.Drawing.Point(715, 11)
        Me.pcbStar4.Name = "pcbStar4"
        Me.pcbStar4.Size = New System.Drawing.Size(30, 30)
        Me.pcbStar4.TabIndex = 8
        Me.pcbStar4.TabStop = False
        '
        'lblCommentID
        '
        Me.lblCommentID.AutoSize = True
        Me.lblCommentID.Location = New System.Drawing.Point(561, 25)
        Me.lblCommentID.Name = "lblCommentID"
        Me.lblCommentID.Size = New System.Drawing.Size(0, 16)
        Me.lblCommentID.TabIndex = 10
        Me.lblCommentID.Visible = False
        '
        'lblServiceName
        '
        Me.lblServiceName.AutoSize = True
        Me.lblServiceName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceName.Location = New System.Drawing.Point(21, 31)
        Me.lblServiceName.Name = "lblServiceName"
        Me.lblServiceName.Size = New System.Drawing.Size(137, 28)
        Me.lblServiceName.TabIndex = 11
        Me.lblServiceName.Text = "Service Name"
        '
        'pcbDeleteComment
        '
        Me.pcbDeleteComment.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_delete_40
        Me.pcbDeleteComment.Location = New System.Drawing.Point(829, 3)
        Me.pcbDeleteComment.Name = "pcbDeleteComment"
        Me.pcbDeleteComment.Size = New System.Drawing.Size(48, 48)
        Me.pcbDeleteComment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbDeleteComment.TabIndex = 12
        Me.pcbDeleteComment.TabStop = False
        '
        'lblMessageType
        '
        Me.lblMessageType.AutoSize = True
        Me.lblMessageType.Location = New System.Drawing.Point(546, 41)
        Me.lblMessageType.Name = "lblMessageType"
        Me.lblMessageType.Size = New System.Drawing.Size(0, 16)
        Me.lblMessageType.TabIndex = 13
        Me.lblMessageType.Visible = False
        '
        'frmCommentControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblMessageType)
        Me.Controls.Add(Me.pcbDeleteComment)
        Me.Controls.Add(Me.lblServiceName)
        Me.Controls.Add(Me.lblCommentID)
        Me.Controls.Add(Me.pcbStar1)
        Me.Controls.Add(Me.pcbStar5)
        Me.Controls.Add(Me.pcbStar2)
        Me.Controls.Add(Me.pcbStar3)
        Me.Controls.Add(Me.pcbStar4)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "frmCommentControl"
        Me.Size = New System.Drawing.Size(878, 148)
        CType(Me.pcbStar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbDeleteComment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents pcbStar1 As PictureBox
    Friend WithEvents pcbStar5 As PictureBox
    Friend WithEvents pcbStar2 As PictureBox
    Friend WithEvents pcbStar3 As PictureBox
    Friend WithEvents pcbStar4 As PictureBox
    Friend WithEvents lblCommentID As Label
    Friend WithEvents lblServiceName As Label
    Friend WithEvents pcbDeleteComment As PictureBox
    Friend WithEvents lblMessageType As Label
End Class
