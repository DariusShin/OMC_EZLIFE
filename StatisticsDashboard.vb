Imports System.Data.OleDb
Imports System.Data.SqlTypes

Public Class frmStatisticsDashboard
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand

    'declare variable to store the result from database
    Dim totalTransaction As Integer
    Dim IncompleteOrder As Integer
    Dim AvgRating As Single
    Dim totalRevenue As Double
    Dim dailyRevenue As Double
    Private Sub frmStatisticsDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"

        'display the total transaction record (incompleted + completed)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT COUNT(*) FROM [Transaction] INNER JOIN [Service] ON [Transaction].Service_ID = [Service].Service_ID 
                        WHERE [Service].Seller_ID = '" + frmSellerMainMenu.SellerID + "'"
            cmd = New OleDbCommand(strSql, conn)
            totalTransaction = Convert.ToInt32(cmd.ExecuteScalar)
            If lblAvailableOrder.Text = "0" Then
                If totalTransaction > 0 Then
                    lblTotalTransaction.Text = totalTransaction
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in the part of displaying total transaction")
            conn.Close()
        End Try

        'display the avaiable/incompleted customer order (The rowCount of DataGridView in Order page)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT COUNT(*) FROM [Transaction] INNER JOIN [Service] ON [Transaction].Service_ID = [Service].Service_ID 
                        WHERE [Service].Seller_ID = '" + frmSellerMainMenu.SellerID + "' AND [Order Status] = 0"
            cmd = New OleDbCommand(strSql, conn)
            IncompleteOrder = Convert.ToInt32(cmd.ExecuteScalar())
            If IncompleteOrder > 0 Then
                lblAvailableOrder.Text = IncompleteOrder
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in the part of displaying total available/incompleted order")
            conn.Close()
        End Try

        'select the username of the buyer that leave a comment here
        Dim TotalRateScore As Integer = 0
        Dim RecordCount As Integer
        Dim AvgRateScore As Double = 0
        Dim WholeNumberAvg As Double
        Dim DecimalNumberAvg As Double

        'display the average rating point (completed service customer comment)
        'check the recordCount in comment table
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT COUNT(*) FROM [Comment] INNER JOIN [Service] ON [Comment].[Service_ID] = [Service].[Service_ID] WHERE [Service].[Seller_ID] = '" + frmSellerMainMenu.SellerID + "'"
            cmd = New OleDbCommand(strSql, conn)
            RecordCount = Convert.ToInt32(cmd.ExecuteScalar)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in the part of displaying record Count of the seller")
            conn.Close()
        End Try

        'find the total of the rating score

        If RecordCount > 0 Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "SELECT SUM([Rating Score]) FROM [Comment] INNER JOIN [Service] ON [Comment].[Service_ID] = [Service].[Service_ID] WHERE [Service].[Seller_ID] = '" + frmSellerMainMenu.SellerID + "'"
                cmd = New OleDbCommand(strSql, conn)
                TotalRateScore = Convert.ToInt32(cmd.ExecuteScalar)
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error in the part of displaying average rating point of the seller")
                conn.Close()
            End Try

            'compute the average rating score
            AvgRateScore = Math.Round(TotalRateScore / (RecordCount), 2)
            DecimalNumberAvg = AvgRateScore
            lblAvgRating.Text = AvgRateScore

            Do While (DecimalNumberAvg >= 1)
                DecimalNumberAvg -= 1
            Loop
            WholeNumberAvg = Val(lblAvgRating.Text) - DecimalNumberAvg
            'check if decimal number is more than or qual to 0.5
            'if the decimal is more tha or equal to 0.5 then make it become 0.5 (Half star later)
            'if else (less tha 0.5) , it will become 0, no star

            If (1 - DecimalNumberAvg) <= 0.5 Then
                DecimalNumberAvg = 0.5
            End If

            Select Case WholeNumberAvg
                Case 1 'wholenumber is 1
                    pcbStar1.Image = My.Resources.icons8_star_32__3_
                    If DecimalNumberAvg = 0.5 Then
                        pcbStar2.BackgroundImage = My.Resources.icons8_star_half_empty_32
                    End If
                Case 2
                    pcbStar1.BackgroundImage = My.Resources.icons8_star_32__3_
                    pcbStar2.BackgroundImage = My.Resources.icons8_star_32__3_
                    If DecimalNumberAvg = 0.5 Then
                        pcbStar3.BackgroundImage = My.Resources.icons8_star_half_empty_32
                    End If
                Case 3
                    For Each Star As PictureBox In {pcbStar1, pcbStar2, pcbStar3}
                        Star.BackgroundImage = My.Resources.icons8_star_32__3_
                    Next Star
                    If DecimalNumberAvg = 0.5 Then
                        pcbStar4.BackgroundImage = My.Resources.icons8_star_half_empty_32
                    End If
                Case 4
                    For Each Star As PictureBox In {pcbStar1, pcbStar2, pcbStar3, pcbStar4}
                        Star.BackgroundImage = My.Resources.icons8_star_32__3_
                    Next Star
                    If DecimalNumberAvg = 0.5 Then
                        pcbStar5.BackgroundImage = My.Resources.icons8_star_half_empty_32
                    End If
                Case 5
                    For Each Star As PictureBox In {pcbStar1, pcbStar2, pcbStar3, pcbStar4, pcbStar5}
                        Star.BackgroundImage = My.Resources.icons8_star_32__3_
                    Next Star
            End Select
        End If

        'display the total revenue (completed service)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT SUM(Amount) FROM [Transaction] INNER JOIN [Service] ON [Transaction].Service_ID = [Service].Service_ID
                        WHERE [Service].Seller_ID = '" + frmSellerMainMenu.SellerID + "' AND [Order Status] <> 0"
            cmd = New OleDbCommand(strSql, conn)
            If cmd.ExecuteScalar IsNot DBNull.Value Then
                totalRevenue = Convert.ToDouble(cmd.ExecuteScalar)
                If totalRevenue.ToString > 0 Then
                    lblTotalRevenue.Text = Format(totalRevenue, "0.00") & " MYR"
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in the part of displaying the total revenue from transaction ")
            conn.Close()
        End Try
        'display today revenue (Where purchased time = Today)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT SUM(Amount) FROM [Transaction] INNER JOIN [Service] ON [Transaction].Service_ID = [Service].Service_ID
                        WHERE ([Service].Seller_ID = '" + frmSellerMainMenu.SellerID + "') 
                        AND ([Complete Order Time] >= #" & Format(Date.Today, "MM/dd/yyyy HH:mm:ss") & "#) 
                        AND ([Complete Order Time] <= #" & Format(Date.Today.AddDays(1), "MM/dd/yyyy HH:mm:ss") & "#)
                        AND ([Order Status] <> 0)"
            cmd = New OleDbCommand(strSql, conn)
            'MsgBox("Here")
            If cmd.ExecuteScalar IsNot DBNull.Value Then
                dailyRevenue = Convert.ToDouble(cmd.ExecuteScalar)
                If dailyRevenue > 0 Then
                    lblDailyRevenue.Text = Format(dailyRevenue, "0.00") & " MYR"
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in the part of displaying the daily revenue from transaction")
            conn.Close()
        End Try
    End Sub
End Class
