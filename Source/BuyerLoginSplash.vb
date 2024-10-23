Imports System.Data.OleDb
Public Class frmBuyerLoginSplash
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim strSql As String

    Dim progress As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerBuyerLogin.Tick
        Label1.Text = "Loading " & progress & "%"
        PanelProgress.Width += 40
        progress += 7
        pcbLoading.Left += 37

        If progress >= 100 Then
            Label1.Text = "Loading 100%"
        End If

        If PanelProgress.Width >= PanelBorder.Width Then
            Label1.Text = "Login Successful..."
            TimerBuyerLogin.Stop()
            TimerBuyerLogin.Enabled = False
            Me.Hide()
        End If
    End Sub

    Private Sub frmBuyerLoginSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        TimerBuyerLogin.Enabled = True
        TimerBuyerLogin.Start()
        Label1.Text = "Loading 0%"
        progress = 0
        PanelProgress.Width = 0

        Try
            'select the username using the global userid
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "Select [Username] from [User] where [User_ID] = '" + frmUserLogin.User_ID + "'"
            cmd = New OleDbCommand(strSql, conn)
            Dim username As String = cmd.ExecuteScalar()

            lblWelcome.Text = "Welcome " & username & " !"
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

End Class