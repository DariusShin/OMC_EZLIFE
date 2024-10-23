Imports System.Data.OleDb
Public Class frmBuyerHistory
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand

    Dim serviceID As String
    Dim sellerId As String
    Dim serviceTypeId As String
    Dim serviceName As String
    Dim businessName As String
    Dim businessType As String
    Dim serviceFilter As String
    Dim buyerId As String = frmMainMenu.BuyerId
    Dim ServiceImagePath As String = ""
    Dim orderListID() As String = {}

    Private Sub frmBuyerHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        'get the service id for all the Services
        flpOrderHistory.Controls.Clear()
        'to check is there is a record of history
        Dim RecordCount As Integer
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'select all order of user that have been completed by the seller
            strSql = "SELECT COUNT(*) FROM [Transaction] WHERE [Buyer_ID] = '" + buyerId + "' AND [Order Status] <> 0 And ([Complete Order Time] >= #" & Format(Date.Today, "MM/dd/yyyy HH:mm:ss") & "#) 
                                And ([Complete Order Time] <= #" & Format(Date.Today.AddDays(1), "MM/dd/yyyy HH:mm : ss") & "#)"
            cmd = New OleDbCommand(strSql, conn)
            RecordCount = Convert.ToInt32(cmd.ExecuteScalar)
            If RecordCount <= 0 Then
                flpOrderHistory.BackgroundImage = My.Resources.EmptyService
                conn.Close()
                Return
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in cheking the record of transaction count.")
            conn.Close()
        End Try

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'select all order of user that haven't been completed by the seller
            strSql = "SELECT [Service_ID] FROM [Transaction] WHERE [Buyer_ID] = '" + buyerId + "' AND [Order Status] <> 0 And ([Complete Order Time] >= #" & Format(Date.Today, "MM/dd/yyyy HH:mm:ss") & "#) 
                                And ([Complete Order Time] <= #" & Format(Date.Today.AddDays(1), "MM/dd/yyyy HH:mm : ss") & "#)"
            Dim myreader As OleDbDataReader
            cmd = New OleDbCommand(strSql, conn)
            myreader = cmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    'find the serviceID, service name, service seller(INNER JOIN), find the ServiceTypeID(INNER JOIN)
                    'serviceID = myreader("Service_ID").ToString
                    serviceID = serviceID + myreader("Service_ID").ToString + "/"
                End While
                myreader.Close()
            End If

            orderListID = serviceID.Split("/")
            For i = 0 To orderListID.Length - 1 Step 1
                serviceID = orderListID(i)
                'find the sellerId and Service Name
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    strSql = "SELECT * FROM [Service] WHERE [Service_ID] = '" + serviceID + "'"
                    cmd = New OleDbCommand(strSql, conn)
                    Dim myreaderService As OleDbDataReader = cmd.ExecuteReader
                    If myreaderService.HasRows Then
                        While myreaderService.Read()
                            sellerId = myreaderService("Seller_ID").ToString
                            serviceName = myreaderService("Service Name").ToString
                        End While
                        myreaderService.Close()
                    End If
                    'MsgBox(sellerId & serviceName)
                    conn.Close()
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    conn.Close()
                End Try

                'Find the Business Name from the seller table using the ID
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    strSql = "SELECT * FROM [Seller] WHERE [Seller_ID] = '" + sellerId + "'"
                    cmd = New OleDbCommand(strSql, conn)
                    Dim myreaderSeller As OleDbDataReader
                    myreaderSeller = cmd.ExecuteReader()
                    If myreaderSeller.HasRows Then
                        While myreaderSeller.Read()
                            businessName = myreaderSeller("Business Name").ToString
                            businessType = myreaderSeller("Business Type").ToString
                        End While
                        myreaderSeller.Close()
                    End If
                    'MsgBox(businessName & businessType)
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    conn.Close()
                End Try

                'Find the ServiceTypeID (CP/FO/CR/PC) and its service photo from the service id 
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    If businessType = "Car Pool" Then
                        strSql = "SELECT * FROM [Car Pooling Service] WHERE [Service_ID] = '" + serviceID + "' "
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreaderServiceType As OleDbDataReader
                        myreaderServiceType = cmd.ExecuteReader
                        If myreaderServiceType.HasRows Then
                            While myreaderServiceType.Read()
                                serviceTypeId = myreaderServiceType("CarPooling_ID").ToString
                                serviceFilter = myreaderServiceType("Area Available").ToString
                                If myreaderServiceType("Car Photo") IsNot DBNull.Value Then
                                    ServiceImagePath = myreaderServiceType("Car Photo")
                                Else
                                    ServiceImagePath = ""
                                End If
                            End While
                            myreaderServiceType.Close()
                            'MsgBox(serviceTypeId & ServiceImagePath)
                        End If
                    ElseIf businessType = "Food Order" Then
                        strSql = "SELECT * FROM [Food Ordering Service] WHERE [Service_ID] = '" + serviceID + "' "
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreaderServiceType As OleDbDataReader
                        myreaderServiceType = cmd.ExecuteReader
                        If myreaderServiceType.HasRows Then
                            While myreaderServiceType.Read()
                                serviceTypeId = myreaderServiceType("FoodOrdering_ID").ToString
                                serviceFilter = myreaderServiceType("Food Type").ToString
                                If myreaderServiceType("Food Photo") IsNot DBNull.Value Then
                                    ServiceImagePath = myreaderServiceType("Food Photo").ToString
                                Else
                                    ServiceImagePath = ""
                                End If
                            End While
                            myreaderServiceType.Close()
                        End If
                    ElseIf businessType = "Car Rental" Then
                        strSql = "SELECT * FROM [Car Rental Service] WHERE [Service_ID] = '" + serviceID + "' "
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreaderServiceType As OleDbDataReader
                        myreaderServiceType = cmd.ExecuteReader
                        If myreaderServiceType.HasRows Then
                            While myreaderServiceType.Read()
                                serviceTypeId = myreaderServiceType("CarRental_ID").ToString
                                serviceFilter = myreaderServiceType("Time Frame").ToString
                                If myreaderServiceType("Car Photo") IsNot DBNull.Value Then
                                    ServiceImagePath = myreaderServiceType("Car Photo").ToString
                                Else
                                    ServiceImagePath = ""
                                End If
                            End While
                            myreaderServiceType.Close()

                        End If
                    Else
                        strSql = "SELECT * FROM [Parcel Collecting Service] WHERE [Service_ID] = '" + serviceID + "' "
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreaderServiceType As OleDbDataReader
                        myreaderServiceType = cmd.ExecuteReader
                        If myreaderServiceType.HasRows Then
                            While myreaderServiceType.Read()
                                serviceTypeId = myreaderServiceType("ParcelCollecting_ID").ToString
                                serviceFilter = myreaderServiceType("Type").ToString + ":" + myreaderServiceType("Weight").ToString
                                ServiceImagePath = ""
                            End While
                            myreaderServiceType.Close()
                        End If
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    conn.Close()
                End Try

                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    strSql = "Select * FROM [Transaction] 
                                WHERE [Buyer_ID] = '" + buyerId + "' AND [Service_ID] = '" + serviceID + "' 
                                And ([Complete Order Time] >= #" & Format(Date.Today, "MM/dd/yyyy HH:mm:ss") & "#) 
                                And ([Complete Order Time] <= #" & Format(Date.Today.AddDays(1), "MM/dd/yyyy HH:mm : ss") & "#)"
                    cmd = New OleDbCommand(strSql, conn)
                    Dim myreadertransaction As OleDbDataReader
                    myreadertransaction = cmd.ExecuteReader
                    'displaying the existing order
                    If myreadertransaction.HasRows Then
                        While myreadertransaction.Read()
                            'MsgBox("Reading")
                            Dim orderProgressPanel As New FlowOutOrderHistory
                            Dim intcount As Integer = 1
                            With orderProgressPanel
                                .Name = "UProgress" & (intcount)
                                .lblServiceName.Text = serviceName
                                .lblCompleteDateTime.Text = "Complete Time :" + vbNewLine + myreadertransaction("Complete Order Time").ToString
                                .lblStoreServiceID.Text = serviceID
                                .lblStoreServiceTypeID.Text = serviceTypeId
                                .lblStoreSellerID.Text = sellerId
                                .lblServiceFilter.Text = serviceFilter
                                .lblStore.Text = myreadertransaction("Transaction_ID").ToString
                                .lblPrice.Text = myreadertransaction("Amount").ToString + " MYR"
                                .lblQty.Visible = True
                                .lblQty.Text = myreadertransaction("Quantity").ToString
                                If ServiceImagePath <> String.Empty AndAlso ServiceImagePath IsNot DBNull.Value Then
                                    .pcbBusinessLogo.Image = Image.FromFile(ServiceImagePath)
                                Else
                                    If businessType = "Car Pool" Then
                                        .pcbBusinessLogo.Image = My.Resources.Default_Car_Photo
                                    ElseIf businessType = "Food Order" Then
                                        .pcbBusinessLogo.Image = My.Resources.Default_Food_Photo
                                    ElseIf businessType = "Car Rental" Then
                                        .pcbBusinessLogo.Image = My.Resources.Default_Car_Photo
                                    Else
                                        .pcbBusinessLogo.Image = My.Resources.icons8_parcel_100__1_
                                    End If
                                End If
                            End With
                            flpOrderHistory.Controls.Add(orderProgressPanel)
                            intcount += 1
                        End While
                        myreadertransaction.Close()
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    conn.Close()
                End Try
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'MsgBox(dtpCompleteOrderDate.Value.Date)
        'MsgBox(dtpCompleteOrderDate.Value.Date.AddDays(1))

        flpOrderHistory.Controls.Clear()
        'to check is there is a record of history
        Dim RecordCount As Integer
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'select all order of user that haven't been completed by the seller
            strSql = "SELECT COUNT(*) FROM [Transaction] WHERE [Buyer_ID] = '" + buyerId + "' AND [Order Status] <> 0"
            cmd = New OleDbCommand(strSql, conn)
            RecordCount = Convert.ToInt32(cmd.ExecuteScalar)
            If RecordCount <= 0 Then
                flpOrderHistory.BackgroundImage = My.Resources.EmptyService
                conn.Close()
                Return
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in cheking the record of transaction count.")
            conn.Close()
        End Try

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'select all order of user that haven't been completed by the seller
            strSql = "SELECT [Service_ID] FROM [Transaction] WHERE [Buyer_ID] = '" + buyerId + "' AND [Order Status] <> 0"
            Dim myreader As OleDbDataReader
            cmd = New OleDbCommand(strSql, conn)
            myreader = cmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    'find the serviceID, service name, service seller(INNER JOIN), find the ServiceTypeID(INNER JOIN)
                    'serviceID = myreader("Service_ID").ToString
                    serviceID = serviceID + myreader("Service_ID").ToString + "/"
                End While
                myreader.Close()
            End If

            orderListID = serviceID.Split("/")
            For i = 0 To orderListID.Length - 1 Step 1
                serviceID = orderListID(i)
                'find the sellerId and Service Name
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    strSql = "SELECT * FROM [Service] WHERE [Service_ID] = '" + serviceID + "'"
                    cmd = New OleDbCommand(strSql, conn)
                    Dim myreaderService As OleDbDataReader = cmd.ExecuteReader
                    If myreaderService.HasRows Then
                        While myreaderService.Read()
                            sellerId = myreaderService("Seller_ID").ToString
                            serviceName = myreaderService("Service Name").ToString
                        End While
                        myreaderService.Close()
                    End If
                    'MsgBox(sellerId & serviceName)
                    conn.Close()
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    conn.Close()
                End Try

                'Find the Business Name from the seller table using the ID
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    strSql = "SELECT * FROM [Seller] WHERE [Seller_ID] = '" + sellerId + "'"
                    cmd = New OleDbCommand(strSql, conn)
                    Dim myreaderSeller As OleDbDataReader
                    myreaderSeller = cmd.ExecuteReader()
                    If myreaderSeller.HasRows Then
                        While myreaderSeller.Read()
                            businessName = myreaderSeller("Business Name").ToString
                            businessType = myreaderSeller("Business Type").ToString
                        End While
                        myreaderSeller.Close()
                    End If
                    'MsgBox(businessName & businessType)
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    conn.Close()
                End Try

                'Find the ServiceTypeID (CP/FO/CR/PC) and its service photo from the service id 
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    If businessType = "Car Pool" Then
                        strSql = "SELECT * FROM [Car Pooling Service] WHERE [Service_ID] = '" + serviceID + "' "
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreaderServiceType As OleDbDataReader
                        myreaderServiceType = cmd.ExecuteReader
                        If myreaderServiceType.HasRows Then
                            While myreaderServiceType.Read()
                                serviceTypeId = myreaderServiceType("CarPooling_ID").ToString
                                serviceFilter = myreaderServiceType("Area Available").ToString
                                If myreaderServiceType("Car Photo") IsNot DBNull.Value Then
                                    ServiceImagePath = myreaderServiceType("Car Photo")
                                Else
                                    ServiceImagePath = ""
                                End If
                            End While
                            myreaderServiceType.Close()
                            'MsgBox(serviceTypeId & ServiceImagePath)
                        End If
                    ElseIf businessType = "Food Order" Then
                        strSql = "SELECT * FROM [Food Ordering Service] WHERE [Service_ID] = '" + serviceID + "' "
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreaderServiceType As OleDbDataReader
                        myreaderServiceType = cmd.ExecuteReader
                        If myreaderServiceType.HasRows Then
                            While myreaderServiceType.Read()
                                serviceTypeId = myreaderServiceType("FoodOrdering_ID").ToString
                                serviceFilter = myreaderServiceType("Food Type").ToString
                                If myreaderServiceType("Food Photo") IsNot DBNull.Value Then
                                    ServiceImagePath = myreaderServiceType("Food Photo").ToString
                                Else
                                    ServiceImagePath = ""
                                End If
                            End While
                            myreaderServiceType.Close()
                        End If
                    ElseIf businessType = "Car Rental" Then
                        strSql = "SELECT * FROM [Car Rental Service] WHERE [Service_ID] = '" + serviceID + "' "
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreaderServiceType As OleDbDataReader
                        myreaderServiceType = cmd.ExecuteReader
                        If myreaderServiceType.HasRows Then
                            While myreaderServiceType.Read()
                                serviceTypeId = myreaderServiceType("CarRental_ID").ToString
                                serviceFilter = myreaderServiceType("Time Frame").ToString
                                If myreaderServiceType("Car Photo") IsNot DBNull.Value Then
                                    ServiceImagePath = myreaderServiceType("Car Photo").ToString
                                Else
                                    ServiceImagePath = ""
                                End If
                            End While
                            myreaderServiceType.Close()

                        End If
                    Else
                        strSql = "SELECT * FROM [Parcel Collecting Service] WHERE [Service_ID] = '" + serviceID + "' "
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreaderServiceType As OleDbDataReader
                        myreaderServiceType = cmd.ExecuteReader
                        If myreaderServiceType.HasRows Then
                            While myreaderServiceType.Read()
                                serviceTypeId = myreaderServiceType("ParcelCollecting_ID").ToString
                                serviceFilter = myreaderServiceType("Type").ToString + ":" + myreaderServiceType("Weight").ToString
                                ServiceImagePath = ""
                            End While
                            myreaderServiceType.Close()
                        End If
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    conn.Close()
                End Try

                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    strSql = "Select * FROM [Transaction] 
                                WHERE [Buyer_ID] = '" + buyerId + "' AND [Service_ID] = '" + serviceID + "' 
                                And ([Complete Order Time] >= #" & Format(dtpCompleteOrderDate.Value.Date, "MM/dd/yyyy HH:mm:ss") & "#) 
                                And ([Complete Order Time] <= #" & Format((dtpCompleteOrderDate.Value.Date).AddDays(1), "MM/dd/yyyy HH:mm:ss") & "#)"
                    cmd = New OleDbCommand(strSql, conn)
                    Dim myreadertransaction As OleDbDataReader
                    myreadertransaction = cmd.ExecuteReader
                    'displaying the existing order
                    If myreadertransaction.HasRows Then
                        While myreadertransaction.Read()
                            'MsgBox("Reading")
                            Dim orderProgressPanel As New FlowOutOrderHistory
                            Dim intcount As Integer = 1
                            With orderProgressPanel
                                .Name = "UProgress" & (intcount)
                                .lblServiceName.Text = serviceName
                                .lblCompleteDateTime.Text = "Complete Time :" + vbNewLine + myreadertransaction("Complete Order Time").ToString
                                .lblStoreServiceID.Text = serviceID
                                .lblStoreServiceTypeID.Text = serviceTypeId
                                .lblStoreSellerID.Text = sellerId
                                .lblServiceFilter.Text = serviceFilter
                                .lblStore.Text = myreadertransaction("Transaction_ID").ToString
                                .lblPrice.Text = myreadertransaction("Amount").ToString + " MYR"
                                .lblQty.Visible = True
                                .lblQty.Text = myreadertransaction("Quantity").ToString
                                If ServiceImagePath <> String.Empty AndAlso ServiceImagePath IsNot DBNull.Value Then
                                    .pcbBusinessLogo.Image = Image.FromFile(ServiceImagePath)
                                Else
                                    If businessType = "Car Pool" Then
                                        .pcbBusinessLogo.Image = My.Resources.Default_Car_Photo
                                    ElseIf businessType = "Food Order" Then
                                        .pcbBusinessLogo.Image = My.Resources.Default_Food_Photo
                                    ElseIf businessType = "Car Rental" Then
                                        .pcbBusinessLogo.Image = My.Resources.Default_Car_Photo
                                    Else
                                        .pcbBusinessLogo.Image = My.Resources.icons8_parcel_100__1_
                                    End If
                                End If
                            End With
                            flpOrderHistory.Controls.Add(orderProgressPanel)
                            intcount += 1
                        End While
                        myreadertransaction.Close()
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    conn.Close()
                End Try
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class
