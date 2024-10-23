Public Class ButtonSetControl
    Public Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel1.BackColor = Color.Transparent
    End Sub
    Public Sub pcbMinimize_Click(sender As Object, e As EventArgs) Handles pcbMinimize.Click
        For Each frm As Form In Application.OpenForms
            frm.WindowState = FormWindowState.Minimized
        Next frm
    End Sub

    Private Sub pcbClose_Click(sender As Object, e As EventArgs) Handles pcbClose.Click
        Dim response As String
        response = MsgBox("Are you sure to quit?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Reminder")
        If response = MsgBoxResult.Yes Then
            Application.ExitThread()
        End If
    End Sub
End Class
