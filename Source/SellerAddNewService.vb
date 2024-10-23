Imports System.Data.OleDb

Public Class frmSellerAddNewService
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Dim SellerBusinessType As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddServices.Click
        'Check the business type of the current seller
        'Select from database to get the business type where SellerID = user_Id
        'if business type is Car Pooling, show the add new service form of car pooling
        'else if business type is Food Ordering, show the add new service form of food ordering
        'else if business type is Car Rental, show the add new service form of Car Rental
        'else , show the ass new service form of Parcel Collecting
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT [Business Type] FROM [Seller] WHERE [User_ID] = '" + frmUserLogin.User_ID + "'"
            cmd = New OleDbCommand(strSql, conn)
            SellerBusinessType = cmd.ExecuteScalar()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        'check for the Seller business type from the table seller
        If SellerBusinessType IsNot String.Empty Then
            Select Case SellerBusinessType
                Case "Car Pool"
                    Dim newCarPool As New frmSellerNewCarPoolService
                    newCarPool.ShowDialog()
                Case "Food Order"
                    Dim newFoodOrder As New frmSellerNewFoodOrderingService
                    newFoodOrder.ShowDialog()
                Case "Car Rental"
                    Dim newCarRental As New frmSellerNewCarRentalService
                    newCarRental.ShowDialog()
                Case "Parcel Collect"
                    Dim newParcelCollect As New frmSellerNewParcelCollectingService
                    newParcelCollect.ShowDialog()
            End Select
        Else
            MsgBox("You don't have a business type!")
        End If
    End Sub

    Private Sub frmSellerAddNewService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        'check if there is a service of the seller
        Dim RecordCount As Integer
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT COUNT(*) FROM [Service] WHERE [Seller_ID] = '" + frmSellerMainMenu.SellerID + "'"
            cmd = New OleDbCommand(strSql, conn)
            RecordCount = Convert.ToInt32(cmd.ExecuteScalar)
            If RecordCount <= 0 Then
                flpExistService.BackgroundImage = My.Resources.EmptyService
                conn.Close()
                Return
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in counting the reocrd of service")
        End Try
    End Sub
End Class
