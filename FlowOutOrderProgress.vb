Imports System.Data.OleDb
Public Class FlowOutOrderProgress
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Dim usercontrolName As String

    Private Sub btnReview_Click(sender As Object, e As EventArgs) Handles btnReview.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            usercontrolName = lblStoreServiceTypeID.Text
            'only for the car pooling services, got 3 mores to go with the similar code
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
            MsgBox(ex.Message, 0, "Error Here")
            conn.Close()
        End Try
    End Sub
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
                    For Each ctrl As Control In { .txtServiceName, .txtSeatPrice, .txtQty, .txtStartPoint, .txtEndPoint, .rbtInUtp, .rbtOutsideUtp,
                        .btnPlus, .btnMinus, .btnReset, .btnUpload, .btnAddService, .dtpStartOperationDate, .dtpEndOperationDate, .cboHourStart,
                        .cboMinuteStart, .cboDayNightStart, .cboHourEnd, .cboMinuteEnd, .cboDayNightEnd, .cboStartPoint, .cboEndPoint}
                        ctrl.Enabled = False
                    Next ctrl
                    .lblHeader.Text = "Car Pooling Service Details"
                    .txtServiceName.Text = myreader("Service Name").ToString
                    .txtSeatPrice.Text = myreader("Seat Price").ToString
                    .txtQty.Text = myreader("Seat Capacity").ToString
                    ServiceArea = myreader("Area Available").ToString
                    If ServiceArea = "In UTP" Then
                        .rbtInUtp.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtInUtp.Checked = True
                    Else
                        .rbtOutsideUtp.Font = New Font("Segoe UI", 12, FontStyle.Bold)
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
                    .cboHourStart.DropDownStyle = ComboBoxStyle.Simple
                    .cboHourStart.Items.Clear()
                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    .cboHourStart.Items.Add(arrTime(0))
                    .cboHourStart.SelectedItem = .cboHourStart.Items(0)

                    .cboMinuteStart.DropDownStyle = ComboBoxStyle.Simple
                    .cboMinuteStart.Items.Clear()
                    .cboMinuteStart.Items.Add(arrTime(1))
                    .cboMinuteStart.SelectedItem = .cboMinuteStart.Items(0)

                    .cboDayNightStart.DropDownStyle = ComboBoxStyle.Simple
                    .cboDayNightStart.Items.Clear()
                    .cboDayNightStart.Items.Add(arrTime(2).Substring(3, 2))
                    .cboDayNightStart.SelectedItem = .cboDayNightStart.Items(0)

                    EndDate = Convert.ToDateTime(myreader("Closing Time").ToString)

                    'MsgBox(EndDate)
                    EndTime = EndDate.Substring(0, 9)
                    .dtpEndOperationDate.Value = EndTime
                    EndTime = EndDate.Substring(10).Trim 'after the space
                    'MsgBox(EndTime)
                    ReDim arrTime(2)
                    arrTime = EndTime.Split(":")
                    .cboHourEnd.DropDownStyle = ComboBoxStyle.Simple
                    .cboHourEnd.Items.Clear()
                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    .cboHourEnd.Items.Add(arrTime(0))
                    .cboHourEnd.SelectedItem = .cboHourEnd.Items(0)

                    .cboMinuteEnd.DropDownStyle = ComboBoxStyle.Simple
                    .cboMinuteEnd.Items.Clear()
                    .cboMinuteEnd.Items.Add(arrTime(1))
                    .cboMinuteEnd.SelectedItem = .cboMinuteEnd.Items(0)

                    .cboDayNightEnd.DropDownStyle = ComboBoxStyle.Simple
                    .cboDayNightEnd.Items.Clear()
                    .cboDayNightEnd.Items.Add(arrTime(2).Substring(3, 2))
                    .cboDayNightEnd.SelectedItem = .cboDayNightEnd.Items(0)

                    If myreader("Car Photo") IsNot DBNull.Value Then
                        .pcbCarPhoto.Image = Image.FromFile(myreader("Car Photo"))
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
                    'disable all the controls inside the new form
                    For Each ctrl As Control In { .txtServiceName, .txtFoodPrice, .txtQty, .rbtFood, .rbtDessert, .rbtBeverage,
                        .btnPlus, .btnMinus, .btnReset, .btnUpload, .btnAddService, .dtpStartOperationDate, .dtpEndOperationDate, .cboHourStart,
                        .cboMinuteStart, .cboDayNightStart, .cboHourEnd, .cboMinuteEnd, .cboDayNightEnd}
                        ctrl.Enabled = False
                    Next
                    .lblHeader.Text = "Food Ordering Service Details"
                    .txtServiceName.Text = myreader("Service Name").ToString
                    .txtFoodPrice.Text = myreader("Price").ToString
                    .txtQty.Text = myreader("Stock Qty").ToString
                    FoodType = myreader("Food Type").ToString
                    If FoodType = "Food" Then
                        .rbtFood.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtFood.Checked = True
                    ElseIf FoodType = "Beverage" Then
                        .rbtBeverage.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtBeverage.Checked = True
                    Else
                        .rbtDessert.Font = New Font("Segoe UI", 12, FontStyle.Bold)
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
                    .cboHourStart.DropDownStyle = ComboBoxStyle.Simple
                    .cboHourStart.Items.Clear()
                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    .cboHourStart.Items.Add(arrTime(0))
                    .cboHourStart.SelectedItem = .cboHourStart.Items(0)

                    .cboMinuteStart.DropDownStyle = ComboBoxStyle.Simple
                    .cboMinuteStart.Items.Clear()
                    .cboMinuteStart.Items.Add(arrTime(1))
                    .cboMinuteStart.SelectedItem = .cboMinuteStart.Items(0)

                    .cboDayNightStart.DropDownStyle = ComboBoxStyle.Simple
                    .cboDayNightStart.Items.Clear()
                    .cboDayNightStart.Items.Add(arrTime(2).Substring(3, 2))
                    .cboDayNightStart.SelectedItem = .cboDayNightStart.Items(0)

                    EndDate = Convert.ToDateTime(myreader("Closing Time").ToString)

                    'MsgBox(EndDate)
                    EndTime = EndDate.Substring(0, 9)
                    .dtpEndOperationDate.Value = EndTime
                    EndTime = EndDate.Substring(10).Trim 'after the space
                    'MsgBox(EndTime)
                    ReDim arrTime(2)
                    arrTime = EndTime.Split(":")
                    .cboHourEnd.DropDownStyle = ComboBoxStyle.Simple
                    .cboHourEnd.Items.Clear()
                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    .cboHourEnd.Items.Add(arrTime(0))
                    .cboHourEnd.SelectedItem = .cboHourEnd.Items(0)

                    .cboMinuteEnd.DropDownStyle = ComboBoxStyle.Simple
                    .cboMinuteEnd.Items.Clear()
                    .cboMinuteEnd.Items.Add(arrTime(1))
                    .cboMinuteEnd.SelectedItem = .cboMinuteEnd.Items(0)

                    .cboDayNightEnd.DropDownStyle = ComboBoxStyle.Simple
                    .cboDayNightEnd.Items.Clear()
                    .cboDayNightEnd.Items.Add(arrTime(2).Substring(3, 2))
                    .cboDayNightEnd.SelectedItem = .cboDayNightEnd.Items(0)

                    If myreader("Food Photo") IsNot DBNull.Value Then
                        .pcbFoodPhoto.Image = Image.FromFile(myreader("Food Photo"))
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
                    'disable all the controls inside the new form
                    For Each ctrl As Control In { .txtServiceName, .txtRentalPrice, .txtQty, .rbtFullDay, .rbtHalfDay, .rbtHourly, .txtAvailableHours,
                        .btnPlus, .btnMinus, .btnReset, .btnUpload, .btnAddService, .dtpStartOperationDate, .dtpEndOperationDate, .cboHourStart,
                        .cboMinuteStart, .cboDayNightStart, .cboHourEnd, .cboMinuteEnd, .cboDayNightEnd}
                        ctrl.Enabled = False
                    Next ctrl
                    .lblHeader.Text = "Car Rental Service Details"
                    .txtServiceName.Text = myreader("Service Name").ToString
                    .txtRentalPrice.Text = myreader("Rental Price").ToString
                    .txtQty.Text = myreader("Seat Number").ToString
                    TimeFrame = myreader("Time Frame").ToString
                    If TimeFrame = "Hourly" Then
                        .rbtHourly.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtHourly.Checked = True
                        .txtAvailableHours.Visible = True
                        .txtAvailableHours.Text = myreader("Available Hour")
                    ElseIf TimeFrame = "HalfDay" Then
                        .rbtHalfDay.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtHalfDay.Checked = True
                    Else
                        .rbtFullDay.Font = New Font("Segoe UI", 12, FontStyle.Bold)
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
                    .cboHourStart.DropDownStyle = ComboBoxStyle.Simple
                    .cboHourStart.Items.Clear()
                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    .cboHourStart.Items.Add(arrTime(0))
                    .cboHourStart.SelectedItem = .cboHourStart.Items(0)

                    .cboMinuteStart.DropDownStyle = ComboBoxStyle.Simple
                    .cboMinuteStart.Items.Clear()
                    .cboMinuteStart.Items.Add(arrTime(1))
                    .cboMinuteStart.SelectedItem = .cboMinuteStart.Items(0)

                    .cboDayNightStart.DropDownStyle = ComboBoxStyle.Simple
                    .cboDayNightStart.Items.Clear()
                    .cboDayNightStart.Items.Add(arrTime(2).Substring(3, 2))
                    .cboDayNightStart.SelectedItem = .cboDayNightStart.Items(0)

                    EndDate = Convert.ToDateTime(myreader("Closing Time").ToString)

                    'MsgBox(EndDate)
                    EndTime = EndDate.Substring(0, 9)
                    .dtpEndOperationDate.Value = EndTime
                    EndTime = EndDate.Substring(10).Trim 'after the space
                    'MsgBox(EndTime)
                    ReDim arrTime(2)
                    arrTime = EndTime.Split(":")
                    .cboHourEnd.DropDownStyle = ComboBoxStyle.Simple
                    .cboHourEnd.Items.Clear()
                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    .cboHourEnd.Items.Add(arrTime(0))
                    .cboHourEnd.SelectedItem = .cboHourEnd.Items(0)

                    .cboMinuteEnd.DropDownStyle = ComboBoxStyle.Simple
                    .cboMinuteEnd.Items.Clear()
                    .cboMinuteEnd.Items.Add(arrTime(1))
                    .cboMinuteEnd.SelectedItem = .cboMinuteEnd.Items(0)

                    .cboDayNightEnd.DropDownStyle = ComboBoxStyle.Simple
                    .cboDayNightEnd.Items.Clear()
                    .cboDayNightEnd.Items.Add(arrTime(2).Substring(3, 2))
                    .cboDayNightEnd.SelectedItem = .cboDayNightEnd.Items(0)

                    If myreader("Car Photo") IsNot DBNull.Value Then
                        .pcbCarPhoto.Image = Image.FromFile(myreader("Car Photo"))
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
                Dim weight() As String
                Dim numOfWeight As Integer
                Dim StartDate As String
                Dim EndDate As String
                Dim StartTime As String
                Dim EndTime As String
                With viewMoreParcelCollecting
                    'disable all the controls inside the new form
                    For Each ctrl As Control In { .txtServiceName, .txtCollectPrice, .txtServiceDescription, .rbtFragile, .rbtNonFragile, .rbtBothType, .chkLess1kg,
                        .chk1kgto3kg, .chkMore3kg, .chkAllWeight, .btnReset, .btnAddService, .dtpStartOperationDate, .dtpEndOperationDate, .cboHourStart,
                        .cboMinuteStart, .cboDayNightStart, .cboHourEnd, .cboMinuteEnd, .cboDayNightEnd}
                        ctrl.Enabled = False
                    Next ctrl
                    .lblHeader.Text = "Parcel Collecting Service Details"
                    .txtServiceName.Text = myreader("Service_Name").ToString
                    .txtCollectPrice.Text = myreader("Price").ToString
                    .txtServiceDescription.Text = myreader("Description").ToString
                    ParcelType = myreader("Type").ToString
                    If ParcelType = "Fragile" Then
                        .rbtFragile.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtFragile.Checked = True
                    ElseIf ParcelType = "HalfDay" Then
                        .rbtNonFragile.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtNonFragile.Checked = True
                    Else
                        .rbtBothType.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .rbtBothType.Checked = True
                    End If

                    weight = (myreader("Weight").ToString).Split("/")
                    numOfWeight = weight.Length
                    If weight(0) = "All Weight" Then
                        .chkAllWeight.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .chkAllWeight.Checked = True
                    Else 'not all type
                        Select Case numOfWeight
                            Case 1
                                If weight(0) = "<1kg" Then
                                    .chkLess1kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                    .chkLess1kg.Checked = True
                                ElseIf weight(0) = "1kg~3kg" Then
                                    .chk1kgto3kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                    .chk1kgto3kg.Checked = True
                                Else
                                    .chkMore3kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                    .chkMore3kg.Checked = True
                                End If
                            Case 2
                                'Selection contain <1kg
                                If weight(0) = "<1kg" OrElse weight(1) = "<1kg" Then
                                    .chkLess1kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                    .chkLess1kg.Checked = True
                                    If weight(0) = "1kg~3kg" OrElse weight(1) = "1kg~3kg" Then '<1 and 1~3
                                        .chk1kgto3kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                        .chk1kgto3kg.Checked = True
                                    Else ' '<1 and >3
                                        .chkMore3kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                        .chkMore3kg.Checked = True
                                    End If

                                    'selection contain 1kg~3kg and >3
                                Else
                                    .chk1kgto3kg.Checked = True
                                    .chk1kgto3kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                    .chkMore3kg.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                                    .chkMore3kg.Checked = True
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
                    .cboHourStart.DropDownStyle = ComboBoxStyle.Simple
                    .cboHourStart.Items.Clear()
                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    .cboHourStart.Items.Add(arrTime(0))
                    .cboHourStart.SelectedItem = .cboHourStart.Items(0)

                    .cboMinuteStart.DropDownStyle = ComboBoxStyle.Simple
                    .cboMinuteStart.Items.Clear()
                    .cboMinuteStart.Items.Add(arrTime(1))
                    .cboMinuteStart.SelectedItem = .cboMinuteStart.Items(0)

                    .cboDayNightStart.DropDownStyle = ComboBoxStyle.Simple
                    .cboDayNightStart.Items.Clear()
                    .cboDayNightStart.Items.Add(arrTime(2).Substring(3, 2))
                    .cboDayNightStart.SelectedItem = .cboDayNightStart.Items(0)

                    EndDate = Convert.ToDateTime(myreader("Closing Time").ToString)

                    'MsgBox(EndDate)
                    EndTime = EndDate.Substring(0, 9)
                    .dtpEndOperationDate.Value = EndTime
                    EndTime = EndDate.Substring(10).Trim 'after the space
                    'MsgBox(EndTime)
                    ReDim arrTime(2)
                    arrTime = EndTime.Split(":")
                    .cboHourEnd.DropDownStyle = ComboBoxStyle.Simple
                    .cboHourEnd.Items.Clear()
                    If arrTime(0).Length <= 1 Then
                        arrTime(0) = "0" + arrTime(0)
                    End If
                    .cboHourEnd.Items.Add(arrTime(0))
                    .cboHourEnd.SelectedItem = .cboHourEnd.Items(0)

                    .cboMinuteEnd.DropDownStyle = ComboBoxStyle.Simple
                    .cboMinuteEnd.Items.Clear()
                    .cboMinuteEnd.Items.Add(arrTime(1))
                    .cboMinuteEnd.SelectedItem = .cboMinuteEnd.Items(0)

                    .cboDayNightEnd.DropDownStyle = ComboBoxStyle.Simple
                    .cboDayNightEnd.Items.Clear()
                    .cboDayNightEnd.Items.Add(arrTime(2).Substring(3, 2))
                    .cboDayNightEnd.SelectedItem = .cboDayNightEnd.Items(0)

                End With
                'show the read only form
                viewMoreParcelCollecting.ShowDialog()
            End While
        End If
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'select the service name and the seller name from table service and seller
            Dim BusinessName As String = ""
            Dim ServiceName As String = ""
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "SELECT * FROM [Seller] WHERE [Seller_ID] = '" + lblStoreSellerID.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreaderSeller As OleDbDataReader
                myreaderSeller = cmd.ExecuteReader()
                If myreaderSeller.HasRows Then
                    While myreaderSeller.Read()
                        BusinessName = myreaderSeller("Business Name").ToString
                    End While
                End If
                myreaderSeller.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Select Business Nae from table seller wtih sellerid.")
                conn.Close()
            End Try

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "SELECT * FROM [Service] WHERE [Service_ID] = '" + lblStoreServiceID.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreaderService As OleDbDataReader
                myreaderService = cmd.ExecuteReader
                If myreaderService.HasRows Then
                    While myreaderService.Read()
                        ServiceName = myreaderService("Service Name").ToString
                    End While
                End If
                myreaderService.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Select Service Name from table service with serviceId")
            End Try

            'select the data from transaction
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT * FROM [Transaction] WHERE [Transaction_ID] = '" + lblStore.Text + "'"
            cmd = New OleDbCommand(strSql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    Dim TransactionDetails As New frmServicePayment
                    With TransactionDetails
                        Dim Location() As String
                        'disable/change all input controls become read only
                        For Each inputCtrl As TextBox In { .txtFullName, .txtPaymentAmount, .txtRequest, .txtQty}
                            inputCtrl.ReadOnly = True
                        Next inputCtrl
                        .txtContactNo.ReadOnly = True
                        .txtMatricNo.ReadOnly = True
                        For Each clickCtrl As Control In { .btnConfirm, .btnClear, .btnCancel, .btnMinus, .btnPlus, .pcbCOD, .pcbVisaMaster}
                            clickCtrl.Enabled = False
                        Next clickCtrl

                        .Name = "Transaction Details " + lblStore.Text
                        .lblServiceSeller.Text = BusinessName
                        .lblServiceName.Text = ServiceName
                        .txtFullName.Text = myreader("Full Name").ToString
                        .txtMatricNo.Text = myreader("Matric No").ToString
                        .txtContactNo.Text = myreader("Phone").ToString
                        .cboGender.Items.Insert(0, myreader("Gender").ToString)
                        .cboGender.SelectedItem = .cboGender.Items(0)
                        .txtRequest.Text = myreader("Request_Details").ToString
                        .txtPaymentAmount.Text = myreader("Amount").ToString
                        .txtQty.Text = myreader("Quantity").ToString
                        If myreader("Payment_Method").ToString = "Visa & Master" Then
                            .pcbVisaMaster.BorderStyle = BorderStyle.FixedSingle
                        Else
                            .pcbCOD.BorderStyle = BorderStyle.Fixed3D
                        End If

                        Location = (myreader("Village").ToString).Split(" ")
                        .cboVillage.Items.Insert(0, Location(0))
                        .cboVillage.SelectedItem = .cboVillage.Items(0)

                        .cboBlock.Items.Insert(0, Location(1))
                        .cboBlock.SelectedItem = .cboBlock.Items(0)
                    End With
                    TransactionDetails.ShowDialog()
                End While
                myreader.Close()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class
