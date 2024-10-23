Imports System.Data.OleDb

Public Class frmMainMenu
    Dim CurrTime As String
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand

    Public Shared BuyerId As String

    Sub ChangeClickedButtonColor(ByVal TriggerButtonName As String)
        For Each Btn As Button In {btnServices, btnProgress, btnProfile, btnHistory, btnAboutUs, btnFeedback}
            If Btn.Name = TriggerButtonName Then
                Btn.BackColor = Color.FromArgb(56, 103, 214)
            Else
                Btn.BackColor = PanelButton.BackColor
            End If
        Next Btn
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            strSql = "SELECT [Buyer_ID] FROM [Buyer] WHERE [User_ID] = '" + frmUserLogin.User_ID + "'"
            cmd = New OleDbCommand(strSql, conn)
            BuyerId = (cmd.ExecuteScalar()).ToString
            conn.Close()
            'MsgBox(BuyerId)
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        Dim initialCtrl As New frmBuyerServices
        PanelContent.Controls.Add(initialCtrl)
        PanelContent.Dock = DockStyle.Fill
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CurrTime = TimeString
        lblDate.Text = Date.Today
        lblTime.Text = CurrTime
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnServices.Click, btnProfile.Click, btnProgress.Click,
        btnHistory.Click, btnAboutUs.Click, btnFeedback.Click, btnLogOut.Click

        'chnage the color of the clicked button
        If sender.name <> "btnLogOut" Then
            Call ChangeClickedButtonColor(sender.name)
        End If

        Select Case sender.name
            Case "btnServices"
                Dim ursCtrl As New frmBuyerServices
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursCtrl)
                ursCtrl.Dock = DockStyle.Fill
                lblHeader.Text = "Services Dashboard"
            Case "btnProfile"
                Dim ursCtrl As New frmBuyerProfile
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursCtrl)
                ursCtrl.Dock = DockStyle.Fill
                lblHeader.Text = "User Profile"

            Case "btnFeedback"
                Dim ursCtrl As New frmFeedBack
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursCtrl)
                ursCtrl.Dock = DockStyle.Fill
                lblHeader.Text = "User Feedback"
                ursCtrl.txtComment.Text = "This is a Good Application!"
                ursCtrl.txtReceiver.Text = "Admin"

            Case "btnProgress"
                Dim ursCtrl As New frmBuyerProgress
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursCtrl)
                ursCtrl.Dock = DockStyle.Fill
                lblHeader.Text = "User Order Progress"

            Case "btnHistory"
                Dim ursCtrl As New frmBuyerHistory
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursCtrl)
                ursCtrl.Dock = DockStyle.Fill
                lblHeader.Text = "User Order History"
            Case "btnAboutUs"
                Dim ursCtrl As New frmAboutUs
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursCtrl)
                ursCtrl.Dock = DockStyle.Fill
                lblHeader.Text = "About Us"
            Case "btnLogOut"
                MsgBox("Log Out Successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "User Log Out")
                Me.Hide()
                'reset the content of the main menu to initial state
                PanelContent.Controls.Clear()
                Dim dashboard As New frmBuyerServices
                PanelContent.Controls.Add(dashboard)
                dashboard.Dock = DockStyle.Fill
                Call ChangeClickedButtonColor("btnServices")
                Dim BacktoLogin As New frmUserLogin
                BacktoLogin.Show()
        End Select
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles btnServices.MouseEnter, btnProfile.MouseEnter, btnProgress.MouseEnter,
            btnHistory.MouseEnter, btnAboutUs.MouseEnter, btnFeedback.MouseEnter
        'chnage the color of unclicked button when user mouse focused on it
        If sender.backcolor <> Color.FromArgb(56, 103, 214) AndAlso sender.backcolor = PanelButton.BackColor Then
            sender.backcolor = Color.FromArgb(106, 137, 204)
        End If
    End Sub

    Private Sub btnServices_MouseLeave(sender As Object, e As EventArgs) Handles btnServices.MouseLeave, btnProfile.MouseLeave, btnProgress.MouseLeave,
            btnHistory.MouseLeave, btnAboutUs.MouseLeave, btnFeedback.MouseLeave
        'reset the color of the unclicked button to original color
        If sender.backcolor <> Color.FromArgb(56, 103, 214) AndAlso sender.backcolor = Color.FromArgb(106, 137, 204) Then
            sender.backcolor = PanelButton.BackColor
        End If

    End Sub
End Class