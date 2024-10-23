Public Class frmAdminMainMenu
    Dim CurrTime As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CurrTime = TimeString
        lblDate.Text = Date.Today
        lblTime.Text = CurrTime
    End Sub
    Sub ChangeClickedButtonColor(ByVal TriggerButtonName As String)
        For Each Btn As Button In {btnBuyerDashboard, btnSellerDashboard, btnNewSellerRequest, btnFeedback}
            If Btn.Name = TriggerButtonName Then
                Btn.BackColor = Color.FromArgb(18, 137, 167)
            Else
                Btn.BackColor = PanelButton.BackColor
            End If
        Next Btn
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnBuyerDashboard.Click, btnSellerDashboard.Click, btnFeedback.Click,
            btnNewSellerRequest.Click, btnLogOut.Click

        'change the color of the clicked button
        If sender.name <> "btnLogOut" Then
            Call ChangeClickedButtonColor(sender.name)
        End If

        Select Case sender.name
            Case "btnBuyerDashboard"
                lblHeader.Text = "Buyer List Dashboard"
                Dim ursctrl As New frmAdminBuyerListDahsboard
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursctrl)
                ursctrl.Dock = DockStyle.Fill
            Case "btnSellerDashboard"
                lblHeader.Text = "Seller List Dashboard"
                Dim ursctrl As New frmAdminSellerListDashboard
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursctrl)
                ursctrl.Dock = DockStyle.Fill
            Case "btnFeedback"
                lblHeader.Text = "User Feedback"
                Dim ursctrl As New frmAdminFeedbackPage
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursctrl)
                ursctrl.Dock = DockStyle.Fill
            Case "btnNewSellerRequest"
                lblHeader.Text = "New Seller Request"
                Dim ursctrl As New frmAdminNewSellerRequest
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursctrl)
                ursctrl.Dock = DockStyle.Fill
            Case "btnLogOut"
                MsgBox("Log Out Successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Seller Log Out")
                Me.Hide()
                PanelContent.Controls.Clear()
                Call ChangeClickedButtonColor("btnDashboard")
                Dim dashboard As New frmStatisticsDashboard
                PanelContent.Controls.Add(dashboard)
                dashboard.Dock = DockStyle.Fill
                Dim BacktoLogin As New frmUserLogin
                BacktoLogin.Show()
        End Select
    End Sub

    Private Sub frmSellerMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set the initial page in main menu (statistics page)
        Dim InitialCtrl As New frmAdminBuyerListDahsboard
        PanelContent.Controls.Add(InitialCtrl)
        InitialCtrl.Dock = DockStyle.Fill
        btnBuyerDashboard.BackColor = Color.FromArgb(18, 137, 167)
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles btnBuyerDashboard.MouseEnter, btnSellerDashboard.MouseEnter,
            btnNewSellerRequest.MouseEnter, btnFeedback.MouseEnter
        If sender.backcolor <> Color.FromArgb(18, 137, 167) AndAlso sender.backcolor = PanelButton.BackColor Then
            sender.backcolor = Color.FromArgb(0, 192, 192)
        End If
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles btnBuyerDashboard.MouseLeave, btnSellerDashboard.MouseLeave,
            btnNewSellerRequest.MouseLeave, btnFeedback.MouseLeave
        If sender.backcolor <> Color.FromArgb(18, 137, 167) AndAlso sender.backcolor = Color.FromArgb(0, 192, 192) Then
            sender.backcolor = PanelButton.BackColor
        End If
    End Sub

End Class