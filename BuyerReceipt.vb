Imports System.Data.OleDb

Public Class frmBuyerReceipt
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Private Sub pcbClosePayment_Click(sender As Object, e As EventArgs) Handles pcbClosePayment.Click
        Me.Hide()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnPrint.Visible = False
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.PanelBase.Width, Me.PanelBase.Height)
        PanelBase.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.PanelBase.Width, Me.PanelBase.Height))
        e.Graphics.DrawImage(imagebmp, 50, 50)
    End Sub
End Class