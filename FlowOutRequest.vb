Imports System.Data.OleDb
Imports System.Deployment.Application

Public Class FlowOutAvailableService
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Dim usercontrolName As String
    Dim ServiceId As String
    Dim SellerId As String
    Dim ServicePrice As String

    Sub ViewMoreCarPool()
        strSql = "SELECT * FROM [Car Pooling Service] WHERE [CarPooling_ID] = '" + usercontrolName + "'"
        cmd = New OleDbCommand(strSql, conn)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader()
        If myreader.HasRows Then
            While myreader.Read()
                Dim viewMoreCarPool As New frmSellerNewCarPoolService
                Dim ServiceArea As String
                Dim StartPosition As String
                Dim EndLocation As String
                Dim StartDate As String
                Dim EndDate As String
                Dim StartTime As String
                Dim EndTime As String
                With viewMoreCarPool
                    'disable all the controls inside the new form
                    If btnPay.Text = "Buy" Then
                        For Each ctrl As Control In { .txtServiceName, .txtSeatPrice, .txtQty, .txtStartPoint, .txtEndPoint, .rbtInUtp, .rbtOutsideUtp,
                        .btnPlus, .btnMinus, .btnReset, .btnUpload, .btnAddService, .dtpStartOperationDate, .dtpEndOperationDate, .cboHourStart,
                        .cboMinuteStart, .cboDayNightStart, .cboHourEnd, .cboMinuteEnd, .cboDayNightEnd, .cboStartPoint, .cboEndPoint}
                            ctrl.Enabled = False
                        Next ctrl
                    End If

                    If btnPay.Text = "Update" Then
                        .txtSeatPrice.ReadOnly = True
                        .btnAddService.ImageAlign = ContentAlignment.MiddleLeft
                    End If

                    .lblStoreCarPoolID.Text = usercontrolName
                    .lblHeader.Text = "Car Pooling Service Details"
                    .txtServiceName.Text = myreader("Service Name").ToString
                    .txtSeatPrice.Text = myreader("Seat Price").ToString
                    .txtQty.Text = myreader("Seat Capacity").ToString
                    ServiceArea = myreader("Area Available").ToString

                    If ServiceArea = "In UTP" Then
                        '.rbtInUtp.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtInUtp.Checked = True
                    Else
                        '.rbtOutsideUtp.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtOutsideUtp.Checked = True
                    End If
                    StartPosition = myreader("Starting Point").ToString
                    Dim location() As String = StartPosition.Split(",")
                    If location.Count = 1 Then 'if the array only contain an element (Dont have coma)
                        .cboStartPoint.SelectedItem = location(0)
                        .cboStartPoint.Enabled = False
                        .txtStartPoint.ReadOnly = True
                    Else 'the items is more tha one
                        .cboStartPoint.SelectedItem = location(0)
                        .txtStartPoint.Text = location(1)
                        .cboStartPoint.Enabled = False
                        .txtStartPoint.ReadOnly = True
                    End If

                    ReDim location(1) 'reset the size and clearing the element
                    EndLocation = myreader("Destination").ToString
                    location = EndLocation.Split(",")
                    If location.Count = 1 Then 'only one element inside the array
                        .cboEndPoint.SelectedItem = location(0)
                        .cboEndPoint.Enabled = False
                        .txtEndPoint.ReadOnly = True
                    Else
                        .cboEndPoint.SelectedItem = location(0)
                        .txtEndPoint.Text = location(1)
                        .cboEndPoint.Enabled = False
                        .txtEndPoint.ReadOnly = True
                    End If
                    StartDate = Convert.ToDateTime(myreader("Operating Time").ToString)

                    'MsgBox(StartDate)
                    StartTime = StartDate.Substring(0, 9)
                    .dtpStartOperationDate.Value = StartTime
                    StartTime = StartDate.Substring(10).Trim
                    'MsgBox(StartTime)
                    ''''''
                    Dim arrTime() As String = StartTime.Split(":")
                    If btnPay.Text = "Buy" Then
                        .cboHourStart.DropDownStyle = ComboBoxStyle.Simple
                        .cboMinuteStart.DropDownStyle = ComboBoxStyle.Simple
                        .cboDayNightStart.DropDownStyle = ComboBoxStyle.Simple
                        .cboHourEnd.DropDownStyle = ComboBoxStyle.Simple
                        .cboMinuteEnd.DropDownStyle = ComboBoxStyle.Simple
                        .cboDayNightEnd.DropDownStyle = ComboBoxStyle.Simple
                    End If

                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    .cboHourStart.SelectedIndex = .cboHourStart.Items.IndexOf(arrTime(0))

                    .cboMinuteStart.SelectedIndex = .cboMinuteStart.Items.IndexOf(arrTime(1))

                    .cboDayNightStart.SelectedIndex = .cboDayNightStart.Items.IndexOf(arrTime(2).Substring(3, 2))

                    EndDate = Convert.ToDateTime(myreader("Closing Time").ToString)

                    'MsgBox(EndDate)
                    EndTime = EndDate.Substring(0, 9)
                    .dtpEndOperationDate.Value = EndTime
                    EndTime = EndDate.Substring(10).Trim 'after the space
                    'MsgBox(EndTime)
                    ReDim arrTime(2)
                    arrTime = EndTime.Split(":")

                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    '.cboHourEnd.Items.IndexOf(arrTime(0))
                    .cboHourEnd.SelectedIndex = .cboHourEnd.Items.IndexOf(arrTime(0))

                    .cboMinuteEnd.SelectedIndex = (.cboMinuteEnd.Items.IndexOf(arrTime(1)))

                    .cboDayNightEnd.SelectedIndex = .cboDayNightEnd.Items.IndexOf(arrTime(2).Substring(3, 2))

                    If myreader("Car Photo") IsNot DBNull.Value Then
                        .pcbCarPhoto.Image = Image.FromFile(myreader("Car Photo"))
                    End If

                    If btnPay.Text = "Update" Then
                        .btnAddService.Text = UCase("Update")
                        .btnAddService.Image = My.Resources.icons8_update_24
                    End If
                End With
                'show the read only form
                viewMoreCarPool.ShowDialog()
            End While
        End If
    End Sub

    Sub ViewMoreFoodOrder()
        strSql = "SELECT * FROM [Food Ordering Service] WHERE [FoodOrdering_ID] = '" + usercontrolName + "'"
        cmd = New OleDbCommand(strSql, conn)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader()
        If myreader.HasRows Then
            While myreader.Read()
                Dim viewMoreFoodOrder As New frmSellerNewFoodOrderingService
                Dim FoodType As String
                Dim StartDate As String
                Dim EndDate As String
                Dim StartTime As String
                Dim EndTime As String
                With viewMoreFoodOrder
                    If btnPay.Text = "Buy" Then
                        'disable all the controls inside the new form
                        For Each ctrl As Control In { .txtServiceName, .txtFoodPrice, .txtQty, .rbtFood, .rbtDessert, .rbtBeverage,
                            .btnPlus, .btnMinus, .btnReset, .btnUpload, .btnAddService, .dtpStartOperationDate, .dtpEndOperationDate, .cboHourStart,
                            .cboMinuteStart, .cboDayNightStart, .cboHourEnd, .cboMinuteEnd, .cboDayNightEnd}
                            ctrl.Enabled = False
                        Next
                    Else
                        .txtFoodPrice.ReadOnly = True
                        .btnAddService.ImageAlign = ContentAlignment.MiddleLeft
                    End If
                    .lblStoreFoodOrderID.Text = usercontrolName
                    .lblHeader.Text = "Food Ordering Service Details"
                    .txtServiceName.Text = myreader("Service Name").ToString
                    .txtFoodPrice.Text = myreader("Price").ToString
                    .txtQty.Text = myreader("Stock Qty").ToString
                    FoodType = myreader("Food Type").ToString
                    If FoodType = "Food" Then
                        '.rbtFood.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtFood.Checked = True
                    ElseIf FoodType = "Beverage" Then
                        '.rbtBeverage.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtBeverage.Checked = True
                    Else
                        ' .rbtDessert.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtDessert.Checked = True
                    End If

                    StartDate = Convert.ToDateTime(myreader("Operating Time").ToString)

                    'MsgBox(StartDate)
                    StartTime = StartDate.Substring(0, 9)
                    .dtpStartOperationDate.Value = StartTime
                    StartTime = StartDate.Substring(10).Trim
                    'MsgBox(StartTime)
                    ''''''
                    Dim arrTime() As String = StartTime.Split(":")
                    If btnPay.Text = "Buy" Then
                        .cboHourStart.DropDownStyle = ComboBoxStyle.Simple
                        .cboMinuteStart.DropDownStyle = ComboBoxStyle.Simple
                        .cboDayNightStart.DropDownStyle = ComboBoxStyle.Simple
                        .cboHourEnd.DropDownStyle = ComboBoxStyle.Simple
                        .cboMinuteEnd.DropDownStyle = ComboBoxStyle.Simple
                        .cboDayNightEnd.DropDownStyle = ComboBoxStyle.Simple
                    End If

                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    .cboHourStart.SelectedIndex = .cboHourStart.Items.IndexOf(arrTime(0))

                    .cboMinuteStart.SelectedIndex = .cboMinuteStart.Items.IndexOf(arrTime(1))

                    .cboDayNightStart.SelectedIndex = .cboDayNightStart.Items.IndexOf(arrTime(2).Substring(3, 2))

                    EndDate = Convert.ToDateTime(myreader("Closing Time").ToString)

                    'MsgBox(EndDate)
                    EndTime = EndDate.Substring(0, 9)
                    .dtpEndOperationDate.Value = EndTime
                    EndTime = EndDate.Substring(10).Trim 'after the space
                    'MsgBox(EndTime)
                    ReDim arrTime(2)
                    arrTime = EndTime.Split(":")

                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    '.cboHourEnd.Items.IndexOf(arrTime(0))
                    .cboHourEnd.SelectedIndex = .cboHourEnd.Items.IndexOf(arrTime(0))

                    .cboMinuteEnd.SelectedIndex = (.cboMinuteEnd.Items.IndexOf(arrTime(1)))

                    .cboDayNightEnd.SelectedIndex = .cboDayNightEnd.Items.IndexOf(arrTime(2).Substring(3, 2))

                    If myreader("Food Photo") IsNot DBNull.Value Then
                        .pcbFoodPhoto.Image = Image.FromFile(myreader("Food Photo"))
                    End If

                    If btnPay.Text = "Update" Then
                        .btnAddService.Text = UCase("Update")
                        .btnAddService.Image = My.Resources.icons8_update_24
                    End If
                End With
                'show the read only form
                viewMoreFoodOrder.ShowDialog()
            End While
        End If
    End Sub

    Sub ViewMoreCarRental()
        strSql = "SELECT * FROM [Car Rental Service] WHERE [CarRental_ID] = '" + usercontrolName + "'"
        cmd = New OleDbCommand(strSql, conn)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader()
        If myreader.HasRows Then
            While myreader.Read()
                Dim viewMoreCarRental As New frmSellerNewCarRentalService
                Dim TimeFrame As String
                Dim StartDate As String
                Dim EndDate As String
                Dim StartTime As String
                Dim EndTime As String
                With viewMoreCarRental
                    If btnPay.Text = "Buy" Then
                        'disable all the controls inside the new form
                        For Each ctrl As Control In { .txtServiceName, .txtRentalPrice, .txtQty, .rbtFullDay, .rbtHalfDay, .rbtHourly, .txtAvailableHours,
                            .btnPlus, .btnMinus, .btnReset, .btnUpload, .btnAddService, .dtpStartOperationDate, .dtpEndOperationDate, .cboHourStart,
                            .cboMinuteStart, .cboDayNightStart, .cboHourEnd, .cboMinuteEnd, .cboDayNightEnd}
                            ctrl.Enabled = False
                        Next ctrl
                    Else
                        .txtRentalPrice.ReadOnly = True
                        .btnAddService.ImageAlign = ContentAlignment.MiddleLeft
                    End If
                    .lblStoreCarRentalID.Text = usercontrolName
                    .lblHeader.Text = "Car Rental Service Details"
                    .txtServiceName.Text = myreader("Service Name").ToString
                    .txtRentalPrice.Text = myreader("Rental Price").ToString
                    .txtQty.Text = myreader("Seat Number").ToString
                    TimeFrame = myreader("Time Frame").ToString
                    If TimeFrame = "Hourly" Then
                        .rbtHourly.Checked = True
                        '.rbtHourly.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .txtAvailableHours.Visible = True
                        .txtAvailableHours.Text = myreader("Available Hour")
                    ElseIf TimeFrame = "HalfDay" Then
                        '.rbtHalfDay.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtHalfDay.Checked = True
                    Else
                        '.rbtHalfDay.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtFullDay.Checked = True
                    End If

                    StartDate = Convert.ToDateTime(myreader("Operating Time").ToString)

                    'MsgBox(StartDate)
                    StartTime = StartDate.Substring(0, 9)
                    .dtpStartOperationDate.Value = StartTime
                    StartTime = StartDate.Substring(10).Trim
                    'MsgBox(StartTime)
                    ''''''
                    Dim arrTime() As String = StartTime.Split(":")
                    If btnPay.Text = "Buy" Then
                        .cboHourStart.DropDownStyle = ComboBoxStyle.Simple
                        .cboMinuteStart.DropDownStyle = ComboBoxStyle.Simple
                        .cboDayNightStart.DropDownStyle = ComboBoxStyle.Simple
                        .cboHourEnd.DropDownStyle = ComboBoxStyle.Simple
                        .cboMinuteEnd.DropDownStyle = ComboBoxStyle.Simple
                        .cboDayNightEnd.DropDownStyle = ComboBoxStyle.Simple
                    End If

                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    .cboHourStart.SelectedIndex = .cboHourStart.Items.IndexOf(arrTime(0))

                    .cboMinuteStart.SelectedIndex = .cboMinuteStart.Items.IndexOf(arrTime(1))

                    .cboDayNightStart.SelectedIndex = .cboDayNightStart.Items.IndexOf(arrTime(2).Substring(3, 2))

                    EndDate = Convert.ToDateTime(myreader("Closing Time").ToString)

                    'MsgBox(EndDate)
                    EndTime = EndDate.Substring(0, 9)
                    .dtpEndOperationDate.Value = EndTime
                    EndTime = EndDate.Substring(10).Trim 'after the space
                    'MsgBox(EndTime)
                    ReDim arrTime(2)
                    arrTime = EndTime.Split(":")

                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    '.cboHourEnd.Items.IndexOf(arrTime(0))
                    .cboHourEnd.SelectedIndex = .cboHourEnd.Items.IndexOf(arrTime(0))

                    .cboMinuteEnd.SelectedIndex = (.cboMinuteEnd.Items.IndexOf(arrTime(1)))

                    .cboDayNightEnd.SelectedIndex = .cboDayNightEnd.Items.IndexOf(arrTime(2).Substring(3, 2))

                    If myreader("Car Photo") IsNot DBNull.Value Then
                        .pcbCarPhoto.Image = Image.FromFile(myreader("Car Photo"))
                    End If

                    If btnPay.Text = "Update" Then
                        .btnAddService.Text = UCase("Update")
                        .btnAddService.Image = My.Resources.icons8_update_24
                    End If
                End With
                'show the read only form
                viewMoreCarRental.ShowDialog()
            End While
        End If
    End Sub

    Sub ViewMoreParcelCollect()
        strSql = "SELECT * FROM [Parcel Collecting Service] WHERE [ParcelCollecting_ID] = '" + usercontrolName + "'"
        cmd = New OleDbCommand(strSql, conn)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader()
        If myreader.HasRows Then
            While myreader.Read()
                Dim viewMoreParcelCollecting As New frmSellerNewParcelCollectingService
                Dim ParcelType As String
                Dim weight() As String = {}
                Dim numOfWeight As Integer
                Dim StartDate As String
                Dim EndDate As String
                Dim StartTime As String
                Dim EndTime As String
                With viewMoreParcelCollecting
                    If btnPay.Text = "Buy" Then
                        'disable all the controls inside the new form
                        For Each ctrl As Control In { .txtServiceName, .txtCollectPrice, .txtServiceDescription, .rbtFragile, .rbtNonFragile, .rbtBothType, .chkLess1kg,
                            .chk1kgto3kg, .chkMore3kg, .chkAllWeight, .btnReset, .btnAddService, .dtpStartOperationDate, .dtpEndOperationDate, .cboHourStart,
                            .cboMinuteStart, .cboDayNightStart, .cboHourEnd, .cboMinuteEnd, .cboDayNightEnd}
                            ctrl.Enabled = False
                        Next ctrl
                    Else
                        .txtCollectPrice.ReadOnly = True
                        .btnAddService.ImageAlign = ContentAlignment.MiddleLeft
                    End If
                    .lblStoreParcelCollectID.Text = usercontrolName
                    .lblHeader.Text = "Parcel Collecting Service Details"
                    .txtServiceName.Text = myreader("Service Name").ToString
                    .txtCollectPrice.Text = myreader("Price").ToString
                    .txtServiceDescription.Text = myreader("Description").ToString
                    ParcelType = myreader("Type").ToString
                    If ParcelType = "Fragile" Then
                        .rbtFragile.Checked = True
                        '.rbtFragile.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                    ElseIf ParcelType = "Non-Fragile" Then
                        '.rbtNonFragile.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtNonFragile.Checked = True
                    Else
                        '.rbtBothType.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtBothType.Checked = True
                    End If

                    weight = (myreader("Weight").ToString).Split("/")
                    numOfWeight = weight.Length
                    If weight(0) = "All Weight" Then
                        '.chkAllWeight.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .chkAllWeight.Checked = True
                    Else 'not all type
                        Select Case numOfWeight
                            Case 1
                                If weight(0) = "<1kg" Then
                                    .chkLess1kg.Checked = True
                                    '.chkLess1kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                ElseIf weight(0) = "1kg~3kg" Then
                                    .chk1kgto3kg.Checked = True
                                    '.chk1kgto3kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                Else
                                    .chkMore3kg.Checked = True
                                    '.chkMore3kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                End If
                            Case 2
                                'Selection contain <1kg
                                If weight(0) = "<1kg" OrElse weight(1) = "<1kg" Then
                                    .chkLess1kg.Checked = True
                                    '.chkLess1kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                    If weight(0) = "1kg~3kg" OrElse weight(1) = "1kg~3kg" Then '<1 and 1~3
                                        .chk1kgto3kg.Checked = True
                                        '.chk1kgto3kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                    Else ' '<1 and >3
                                        .chkMore3kg.Checked = True
                                        '.chkMore3kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                    End If

                                    'selection contain 1kg~3kg and >3
                                Else
                                    .chk1kgto3kg.Checked = True
                                    '.chk1kgto3kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                    .chkMore3kg.Checked = True
                                    '.chkMore3kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                End If
                        End Select
                    End If

                    StartDate = Convert.ToDateTime(myreader("Operating Time").ToString)

                    'MsgBox(StartDate)
                    StartTime = StartDate.Substring(0, 9)
                    .dtpStartOperationDate.Value = StartTime
                    StartTime = StartDate.Substring(10).Trim
                    'MsgBox(StartTime)
                    ''''''
                    Dim arrTime() As String = StartTime.Split(":")

                    If btnPay.Text = "Buy" Then
                        .cboHourStart.DropDownStyle = ComboBoxStyle.Simple
                        .cboMinuteStart.DropDownStyle = ComboBoxStyle.Simple
                        .cboDayNightStart.DropDownStyle = ComboBoxStyle.Simple
                        .cboHourEnd.DropDownStyle = ComboBoxStyle.Simple
                        .cboMinuteEnd.DropDownStyle = ComboBoxStyle.Simple
                        .cboDayNightEnd.DropDownStyle = ComboBoxStyle.Simple
                    End If

                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    .cboHourStart.SelectedIndex = .cboHourStart.Items.IndexOf(arrTime(0))

                    .cboMinuteStart.SelectedIndex = .cboMinuteStart.Items.IndexOf(arrTime(1))

                    .cboDayNightStart.SelectedIndex = .cboDayNightStart.Items.IndexOf(arrTime(2).Substring(3, 2))

                    EndDate = Convert.ToDateTime(myreader("Closing Time").ToString)

                    'MsgBox(EndDate)
                    EndTime = EndDate.Substring(0, 9)
                    .dtpEndOperationDate.Value = EndTime
                    EndTime = EndDate.Substring(10).Trim 'after the space
                    'MsgBox(EndTime)
                    ReDim arrTime(2)
                    arrTime = EndTime.Split(":")

                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    '.cboHourEnd.Items.IndexOf(arrTime(0))
                    .cboHourEnd.SelectedIndex = .cboHourEnd.Items.IndexOf(arrTime(0))

                    .cboMinuteEnd.SelectedIndex = .cboMinuteEnd.Items.IndexOf(arrTime(1))

                    .cboDayNightEnd.SelectedIndex = .cboDayNightEnd.Items.IndexOf(arrTime(2).Substring(3, 2))

                    If btnPay.Text = "Update" Then
                        .btnAddService.Text = UCase("Update")
                        .btnAddService.Image = My.Resources.icons8_update_24
                    End If
                End With
                'show the read only form
                viewMoreParcelCollecting.ShowDialog()
            End While
        End If
    End Sub

    'buyer make payment here
    Sub BuyerPayment()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        'service ID, Servce Namei,Service Provider(Service Seller)
        'select the serviceId of the carpool/foodorder/carrental/ParcelCollect
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            If usercontrolName.Substring(0, 2) = "CP" Then
                'find the serviceId and its price in the table Car Pooling service
                strSql = "SELECT [Service_ID],[Seat Price] FROM [Car Pooling Service] WHERE [CarPooling_ID] = '" + lblStore.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader()
                While myreader.Read()
                    ServiceId = myreader("Service_ID").ToString
                    ServicePrice = myreader("Seat Price").ToString
                End While
                'MsgBox(ServiceId)
            ElseIf usercontrolName.Substring(0, 2) = "FO" Then
                'find the serviceId and its price in the table Food Ordering service
                strSql = "SELECT [Service_ID],[Price] FROM [Food Ordering Service] WHERE [FoodOrdering_ID] = '" + lblStore.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader()
                While myreader.Read()
                    ServiceId = myreader("Service_ID").ToString
                    ServicePrice = myreader("Price").ToString
                End While
                'MsgBox(ServiceId)
            ElseIf usercontrolName.Substring(0, 2) = "CR" Then
                'find the serviceId and its price in the table Car Rental service
                strSql = "SELECT [Service_ID],[Rental Price] FROM [Car Rental Service] WHERE [CarRental_ID] = '" + lblStore.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader()
                While myreader.Read()
                    ServiceId = myreader("Service_ID").ToString
                    ServicePrice = myreader("Rental Price").ToString
                End While
                'MsgBox(ServiceId)
            Else
                'find the serviceId and its price in the table Parcel Collecting service
                strSql = "SELECT [Service_ID],[Price] FROM [Parcel Collecting Service] WHERE [ParcelCollecting_ID] = '" + lblStore.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader()
                While myreader.Read()
                    ServiceId = myreader("Service_ID").ToString
                    ServicePrice = myreader("Price").ToString
                End While
                'MsgBox(ServiceId)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        'select the seller of the selected serviceID
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT [Seller_ID] FROM [Service] WHERE [Service_ID] = '" + ServiceId + "'"
            cmd = New OleDbCommand(strSql, conn)
            SellerId = (cmd.ExecuteScalar()).ToString
            'MsgBox(SellerId)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        'Select the service Seller and Service Name of the particular services
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT [Seller].[Business Name],[Service].[Service Name] FROM [Seller] INNER JOIN [Service] ON [Seller].Seller_ID = [Service].Seller_ID WHERE 
                    [Service].Seller_ID = '" + SellerId + "' AND [Service].Service_ID = '" + ServiceId + "'"
            cmd = New OleDbCommand(strSql, conn)
            Dim myreader As OleDbDataReader = cmd.ExecuteReader()
            If myreader.HasRows Then
                While myreader.Read()
                    Dim Buyerpayment As New frmServicePayment
                    With Buyerpayment
                        .lblServiceSeller.Text = myreader("Business Name").ToString
                        .lblServiceName.Text = myreader("Service Name").ToString
                        .lblStoredServiceID.Text = ServiceId
                        .txtPaymentAmount.Text = ServicePrice
                    End With
                    Buyerpayment.ShowDialog()
                End While
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Sub UpdateServiceDetails()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        'select the service details of that particular service
        'enable all the button and control
        'error checking for all the updated input when user click on the update button
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            If usercontrolName.Substring(0, 2) = "CP" Then
                Call ViewMoreCarPool()
            ElseIf usercontrolName.Substring(0, 2) = "FO" Then
                Call ViewMoreFoodOrder()
            ElseIf usercontrolName.Substring(0, 2) = "CR" Then
                Call ViewMoreCarRental()
            Else
                Call ViewMoreParcelCollect()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in updating the service details")
        End Try
    End Sub
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"

        usercontrolName = lblStore.Text

        If sender.text = "Buy" Then
            BuyerPayment()
        Else
            UpdateServiceDetails()
        End If
    End Sub

    'Buyer press viewe more button
    Private Sub btnViewMore_Click(sender As Object, e As EventArgs) Handles btnViewMore.Click
        'About page for the particular services
        'get the sellerID, Service Type, Service ID/Car Pooling ID
        'show the details of the services (the new service form but readonly and disable all the button)
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        usercontrolName = lblStore.Text
        'MsgBox(usercontrolName)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'only for the car pooling services, got 3 mores to go with the similar code
            If usercontrolName.Substring(0, 2) = "CP" Then
                Call ViewMoreCarPool()
            ElseIf usercontrolName.substring(0, 2) = "FO" Then
                Call ViewMoreFoodOrder()
            ElseIf usercontrolName.Substring(0, 2) = "CR" Then
                Call ViewMoreCarRental()
            Else
                Call ViewMoreParcelCollect()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error Here")
            conn.Close()
        End Try
    End Sub
End Class
