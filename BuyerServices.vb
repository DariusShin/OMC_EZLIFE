Public Class frmBuyerServices

    Private Sub pcbCarPool_Click(sender As Object, e As EventArgs) Handles pcbCarPool.Click, pcbFoodOrders.Click, pcbCarRental.Click, pcbOthers.Click
        Select Case sender.name
            Case "pcbCarPool"
                Dim ursctrl_Fop As New frmCarPoolDashboard
                frmUserLogin.BuyerPage.PanelContent.Controls.Clear()
                frmUserLogin.BuyerPage.PanelContent.Controls.Add(ursctrl_Fop)
                ursctrl_Fop.Dock = DockStyle.Fill
            Case "pcbFoodOrders"
                Dim ursctrl_Fop As New frmFoodOrderDashboard
                frmUserLogin.BuyerPage.PanelContent.Controls.Clear()
                frmUserLogin.BuyerPage.PanelContent.Controls.Add(ursctrl_Fop)
                ursctrl_Fop.Dock = DockStyle.Fill
            Case "pcbCarRental"
                Dim ursctrl_Fop As New frmCarRentalDashboard
                frmUserLogin.BuyerPage.PanelContent.Controls.Clear()
                frmUserLogin.BuyerPage.PanelContent.Controls.Add(ursctrl_Fop)
                ursctrl_Fop.Dock = DockStyle.Fill
            Case "pcbOthers"
                Dim ursctrl_Fop As New frmParcelCollectingDashboard
                frmUserLogin.BuyerPage.PanelContent.Controls.Clear()
                frmUserLogin.BuyerPage.PanelContent.Controls.Add(ursctrl_Fop)
                ursctrl_Fop.Dock = DockStyle.Fill
        End Select
    End Sub

    Private Sub lblCarPool_Click(sender As Object, e As EventArgs) Handles lblCarPool.Click, lblFoodOrdering.Click, lblCarRental.Click, lblParcelCollect.Click
        Select Case sender.name
            Case "lblCarPool"
                Dim ursctrl_Fop As New frmCarPoolDashboard
                frmUserLogin.BuyerPage.PanelContent.Controls.Clear()
                frmUserLogin.BuyerPage.PanelContent.Controls.Add(ursctrl_Fop)
                ursctrl_Fop.Dock = DockStyle.Fill
            Case "lblFoodOrdering"
                Dim ursctrl_Fop As New frmFoodOrderDashboard
                frmUserLogin.BuyerPage.PanelContent.Controls.Clear()
                frmUserLogin.BuyerPage.PanelContent.Controls.Add(ursctrl_Fop)
                ursctrl_Fop.Dock = DockStyle.Fill
            Case "lblCarRental"
                Dim ursctrl_Fop As New frmCarRentalDashboard
                frmUserLogin.BuyerPage.PanelContent.Controls.Clear()
                frmUserLogin.BuyerPage.PanelContent.Controls.Add(ursctrl_Fop)
                ursctrl_Fop.Dock = DockStyle.Fill
            Case "lblParcelCollect"
                Dim ursctrl_Fop As New frmParcelCollectingDashboard
                frmUserLogin.BuyerPage.PanelContent.Controls.Clear()
                frmUserLogin.BuyerPage.PanelContent.Controls.Add(ursctrl_Fop)
                ursctrl_Fop.Dock = DockStyle.Fill
        End Select

    End Sub
End Class
