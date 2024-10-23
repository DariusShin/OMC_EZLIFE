Imports System.Threading
Public Class frmEZLifeSplash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PanelProgress.Width += 17
        If PanelLoading.Width < PanelBase.Width Then
            PanelLoading.Width += 15
        End If

        If PanelProgress.Width >= PanelBorder.Width Then
            Timer1.Stop()
            Timer1.Enabled = False
            Thread.Sleep(700)
            Me.Hide()
            frmUserLogin.Show()
        End If
    End Sub

    Private Sub frmEZLifeSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
        PanelProgress.Width = 0
        PanelLoading.Width = 0
    End Sub
End Class