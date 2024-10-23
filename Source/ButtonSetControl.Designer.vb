<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ButtonSetControl
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pcbMinimize = New System.Windows.Forms.PictureBox()
        Me.pcbClose = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.pcbMinimize)
        Me.Panel1.Controls.Add(Me.pcbClose)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(81, 42)
        Me.Panel1.TabIndex = 2
        '
        'pcbMinimize
        '
        Me.pcbMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbMinimize.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_minimize_80
        Me.pcbMinimize.Location = New System.Drawing.Point(3, 5)
        Me.pcbMinimize.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.pcbMinimize.Name = "pcbMinimize"
        Me.pcbMinimize.Size = New System.Drawing.Size(32, 32)
        Me.pcbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbMinimize.TabIndex = 0
        Me.pcbMinimize.TabStop = False
        '
        'pcbClose
        '
        Me.pcbClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbClose.Image = Global.OMC_EZLIFE_May2023.My.Resources.Resources.icons8_close_48
        Me.pcbClose.Location = New System.Drawing.Point(49, 5)
        Me.pcbClose.Name = "pcbClose"
        Me.pcbClose.Size = New System.Drawing.Size(32, 32)
        Me.pcbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbClose.TabIndex = 1
        Me.pcbClose.TabStop = False
        '
        'ButtonSetControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ButtonSetControl"
        Me.Size = New System.Drawing.Size(86, 50)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pcbMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pcbClose As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pcbMinimize As PictureBox
End Class
