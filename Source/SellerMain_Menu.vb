Imports System.Data.OleDb

Public Class frmSellerMainMenu
    'initializing the database connection and command
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand

    'declare global variable SellerID
    Public Shared SellerID As String
    Public Shared BusinessLogoDirectory As String
    Public Shared BusinessType As String

    Dim CurrTime As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CurrTime = TimeString
        lblDate.Text = Date.Today
        lblTime.Text = CurrTime
    End Sub
    Sub ChangeClickedButtonColor(ByVal TriggerButtonName As String)
        For Each Btn As Button In {btnDashboard, btnProfile, btnAddService, btnOrder, btnAboutUs, btnFeedback, btnComment}
            If Btn.Name = TriggerButtonName Then
                Btn.BackColor = Color.FromArgb(181, 52, 113)
            Else
                Btn.BackColor = PanelButton.BackColor
            End If
        Next Btn
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnProfile.Click, btnAddService.Click, btnOrder.Click,
            btnAboutUs.Click, btnFeedback.Click, btnLogOut.Click, btnComment.Click

        'change the color of the clicked button
        If sender.name <> "btnLogOut" Then
            Call ChangeClickedButtonColor(sender.name)
        End If

        Select Case sender.name
            Case "btnDashboard"
                lblHeader.Text = "Statistics Dashboard"
                Dim ursctrl As New frmStatisticsDashboard
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursctrl)
                ursctrl.Dock = DockStyle.Fill
            Case "btnProfile"
                lblHeader.Text = "Business Profile"
                Dim ursctrl As New frmBusinessProfile
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursctrl)
                ursctrl.Dock = DockStyle.Fill
            Case "btnAddService"
                lblHeader.Text = "Create New Service"
                Dim ursctrl As New frmSellerAddNewService
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursctrl)
                ursctrl.Dock = DockStyle.Fill
                'Retrieve the data of seller existing services form database

                'if user business type is car pool services seller
                'display all the car pool services of seller
                If BusinessType = "Car Pool" Then
                    Try
                        If conn.State = ConnectionState.Closed Then
                            conn.Open()
                        End If

                        strSql = "SELECT * FROM [Service] INNER JOIN [Car Pooling Service] ON
                       [Service].Service_ID = [Car Pooling Service].Service_ID WHERE [Service].Seller_ID = '" + SellerID + "'"
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreader As OleDbDataReader
                        Dim intcount As Integer = 1
                        myreader = cmd.ExecuteReader()
                        If myreader.HasRows Then
                            While myreader.Read()
                                Dim serviceControl As New FlowOutAvailableService
                                With serviceControl
                                    .btnPay.Text = "Update"
                                    .btnPay.Image = My.Resources.icons8_update_24
                                    .lblQty.Visible = True
                                    .lblQty.Text = myreader("Seat Capacity").ToString
                                    .btnPay.BackColor = Color.FromArgb(29, 209, 161)
                                    .Name = "UControl" + (intcount).ToString
                                    .lblStore.Text = myreader("CarPooling_ID").ToString
                                    .Size = New Size(ursctrl.flpExistService.Width, 135)
                                    .lblServiceName.Text = myreader.Item(2).ToString
                                    .lblPrice.Text = myreader("Seat Price").ToString + " MYR"
                                    .lblServiceFilter.Text = myreader("Area Available").ToString
                                    .lblOperationDateTime.Text = myreader("Operating Time").ToString + vbNewLine + myreader("Closing Time").ToString
                                    If myreader("Car Photo") IsNot DBNull.Value Then
                                        .pcbBusinessLogo.Image = Image.FromFile(myreader("Car Photo"))
                                    Else
                                        .pcbBusinessLogo.Image = My.Resources.Default_Car_Photo
                                    End If

                                    If myreader("Closing Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy hh:mm:ss") & "#") Then
                                        If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy hh:mm:ss") & "#") Then 'before both operating and closing time
                                            .lblStatus.Text = "Preparing..."
                                            .pcbStatus.Image = My.Resources.icons8_black_circle_24
                                        Else 'in between operating and closing time
                                            .lblStatus.Text = "On Going..."
                                            .pcbStatus.Image = My.Resources.icons8_green_circle_24
                                        End If
                                    Else 'closing date before today = expired
                                        .lblStatus.Text = "Ended..."
                                        .pcbStatus.Image = My.Resources.icons8_red_24
                                    End If

                                End With
                                'add the new existing service user control into the flowoutpanel
                                ursctrl.flpExistService.Controls.Add(serviceControl)
                                intcount += 1
                            End While
                        End If
                        conn.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message & " Second Wrong")
                        conn.Close()
                    End Try

                ElseIf BusinessType = "Food Order" Then
                    'displaying all available Food Ordering Services of seller
                    Try
                        If conn.State = ConnectionState.Closed Then
                            conn.Open()
                        End If

                        strSql = "SELECT * FROM [Service] INNER JOIN [Food Ordering Service] ON
                       [Service].Service_ID = [Food Ordering Service].Service_ID WHERE [Service].Seller_ID = '" + SellerID + "'"
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreader As OleDbDataReader
                        Dim intcount As Integer = 1
                        myreader = cmd.ExecuteReader()
                        If myreader.HasRows Then
                            While myreader.Read()
                                Dim serviceControl As New FlowOutAvailableService
                                With serviceControl
                                    .btnPay.Text = "Update"
                                    .btnPay.Image = My.Resources.icons8_update_24
                                    .Name = "UControl" + (intcount).ToString
                                    .lblStore.Text = myreader("FoodOrdering_ID").ToString
                                    .Size = New Size(ursctrl.flpExistService.Width, 135)
                                    .lblServiceName.Text = myreader.Item(2).ToString
                                    .lblPrice.Text = myreader("Price").ToString + " MYR"
                                    .lblQty.Visible = True
                                    .lblQty.Text = myreader("Stock Qty").ToString
                                    .lblServiceFilter.Text = myreader("Food Type").ToString
                                    .lblOperationDateTime.Text = myreader("Operating Time").ToString + vbNewLine + myreader("Closing Time").ToString
                                    If myreader("Food Photo") IsNot DBNull.Value Then
                                        .pcbBusinessLogo.Image = Image.FromFile(myreader("Food Photo"))
                                    Else
                                        .pcbBusinessLogo.Image = My.Resources.Default_Food_Photo
                                    End If
                                    '.pcbstatus
                                    If myreader("Closing Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy hh:mm : ss") & "#") Then
                                        If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy hh:mm : ss") & "#") Then 'before both operating and closing time
                                            .lblStatus.Text = "Preparing..."
                                            .pcbStatus.Image = My.Resources.icons8_black_circle_24
                                        Else 'in between operating and closing time
                                            .lblStatus.Text = "On Going..."
                                            .pcbStatus.Image = My.Resources.icons8_green_circle_24
                                        End If
                                    Else 'closing date before today = expired
                                        .lblStatus.Text = "Ended..."
                                        .pcbStatus.Image = My.Resources.icons8_red_24
                                    End If
                                End With
                                'add the new existing service user control into the flowoutpanel
                                ursctrl.flpExistService.Controls.Add(serviceControl)
                                intcount += 1
                            End While
                        End If
                        conn.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message & " Second Wrong")
                        conn.Close()
                    End Try

                ElseIf BusinessType = "Car Rental" Then
                    'displaying all available car pooling service of seller
                    Try
                        If conn.State = ConnectionState.Closed Then
                            conn.Open()
                        End If

                        strSql = "SELECT * FROM [Service] INNER JOIN [Car Rental Service] ON
                       [Service].Service_ID = [Car Rental Service].Service_ID WHERE [Service].Seller_ID = '" + SellerID + "'"
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreader As OleDbDataReader
                        Dim intcount As Integer = 1
                        myreader = cmd.ExecuteReader()
                        If myreader.HasRows Then
                            While myreader.Read()
                                Dim serviceControl As New FlowOutAvailableService
                                With serviceControl
                                    .btnPay.Text = "Update"
                                    .btnPay.Image = My.Resources.icons8_update_24
                                    .Name = "UControl" + (intcount).ToString
                                    .lblStore.Text = myreader("CarRental_ID").ToString
                                    .Size = New Size(ursctrl.flpExistService.Width, 135)
                                    .lblServiceName.Text = myreader.Item(2).ToString
                                    .lblPrice.Text = myreader("Rental Price").ToString + " MYR"
                                    .lblServiceFilter.Text = myreader("Time Frame").ToString
                                    .lblOperationDateTime.Text = myreader("Operating Time").ToString + vbNewLine + myreader("Closing Time").ToString
                                    If myreader("Car Photo") IsNot DBNull.Value Then
                                        .pcbBusinessLogo.Image = Image.FromFile(myreader("Car Photo"))
                                    Else
                                        .pcbBusinessLogo.Image = My.Resources.Default_Car_Photo
                                    End If
                                    '.pcbstatus
                                    If myreader("Closing Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy hh:mm : ss") & "#") Then
                                        If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy hh:mm : ss") & "#") Then 'before both operating and closing time
                                            .lblStatus.Text = "Preparing..."
                                            .pcbStatus.Image = My.Resources.icons8_black_circle_24
                                        Else 'in between operating and closing time
                                            .lblStatus.Text = "On Going..."
                                            .pcbStatus.Image = My.Resources.icons8_green_circle_24
                                        End If
                                    Else 'closing date before today = expired
                                        .lblStatus.Text = "Ended..."
                                        .pcbStatus.Image = My.Resources.icons8_red_24
                                    End If
                                End With
                                'add the new existing service user control into the flowoutpanel
                                ursctrl.flpExistService.Controls.Add(serviceControl)
                                intcount += 1
                            End While
                        End If
                        conn.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message & " Second Wrong")
                        conn.Close()
                    End Try
                Else
                    'displaying all available parcel collecting service of seller
                    Try
                        If conn.State = ConnectionState.Closed Then
                            conn.Open()
                        End If

                        strSql = "SELECT * FROM [Service] INNER JOIN [Parcel Collecting Service] ON
                       [Service].Service_ID = [Parcel Collecting Service].Service_ID WHERE [Service].Seller_ID = '" + SellerID + "'"
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreader As OleDbDataReader
                        Dim intcount As Integer = 1
                        myreader = cmd.ExecuteReader()
                        If myreader.HasRows Then
                            While myreader.Read()
                                Dim serviceControl As New FlowOutAvailableService
                                With serviceControl
                                    .btnPay.Text = "Update"
                                    .btnPay.Image = My.Resources.icons8_update_24
                                    .Name = "UControl" + (intcount).ToString
                                    .lblStore.Text = myreader("ParcelCollecting_ID").ToString
                                    .Size = New Size(ursctrl.flpExistService.Width, 135)
                                    .lblServiceName.Text = myreader.Item(2).ToString
                                    .lblPrice.Text = myreader("Price").ToString + " MYR"
                                    .lblServiceFilter.Text = (myreader("Type").ToString + ":" + myreader("Weight").ToString)
                                    .lblOperationDateTime.Text = myreader("Operating Time").ToString + vbNewLine + myreader("Closing Time").ToString
                                    If BusinessLogoDirectory <> String.Empty Then
                                        .pcbBusinessLogo.Image = Image.FromFile(BusinessLogoDirectory)
                                    Else
                                        .pcbBusinessLogo.Image = My.Resources.icons8_parcel_100__1_
                                    End If
                                    If myreader("Closing Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy hh:mm : ss") & "#") Then
                                        If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy hh:mm : ss") & "#") Then 'before both operating and closing time
                                            .lblStatus.Text = "Preparing..."
                                            .pcbStatus.Image = My.Resources.icons8_black_circle_24
                                        Else 'in between operating and closing time
                                            .lblStatus.Text = "On Going..."
                                            .pcbStatus.Image = My.Resources.icons8_green_circle_24
                                        End If
                                    Else 'closing date before today = expired
                                        .lblStatus.Text = "Ended..."
                                        .pcbStatus.Image = My.Resources.icons8_red_24
                                    End If
                                    '.pcbstatus
                                End With
                                'add the new existing service user control into the flowoutpanel
                                ursctrl.flpExistService.Controls.Add(serviceControl)
                                intcount += 1
                            End While
                        End If
                        conn.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message & " Second Wrong")
                        conn.Close()
                    End Try
                End If

            Case "btnOrder"
                lblHeader.Text = "Customer Orders"
                Dim ursctrl As New frmSellerOrder
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursctrl)
                ursctrl.Dock = DockStyle.Fill
            Case "btnComment"
                lblHeader.Text = "Customer Comments"
                Dim ursctrl As New frmSellerCustomerComment
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursctrl)
                ursctrl.Dock = DockStyle.Fill

            Case "btnAboutUs"
                lblHeader.Text = "About Us"
                Dim ursCtrl As New frmAboutUs
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursCtrl)
                ursCtrl.Dock = DockStyle.Fill
            Case "btnFeedback"
                lblHeader.Text = "User Feedback"
                Dim ursCtrl As New frmFeedBack
                PanelContent.Controls.Clear()
                PanelContent.Controls.Add(ursCtrl)
                ursCtrl.Dock = DockStyle.Fill
                ursCtrl.txtComment.Text = "This is a Good Application!"
                ursCtrl.txtReceiver.Text = "Admin"

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
        'Find the SellerId From the UserID
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'Select the seller ID and business logo from the UserId in table Seller\
            strSql = "SELECT [Seller_ID], [Business Logo],[Business Type] FROM [Seller] WHERE [User_ID] = '" + frmUserLogin.User_ID + "'"
            cmd = New OleDbCommand(strSql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader()
            If myreader.HasRows Then
                While myreader.Read()
                    SellerID = myreader("Seller_ID").ToString
                    BusinessLogoDirectory = myreader("Business Logo").ToString
                    BusinessType = myreader("Business Type").ToString
                End While
            End If
            'SellerID = (cmd.ExecuteScalar()).ToString
            'MsgBox("The UserId is " & frmUserLogin.User_ID & " The SellerId is " & SellerID & vbNewLine & BusinessLogoDirectory)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        'set the initial page in main menu (statistics page)
        Dim InitialCtrl As New frmStatisticsDashboard
        PanelContent.Controls.Add(InitialCtrl)
        InitialCtrl.Dock = DockStyle.Fill
        btnDashboard.BackColor = Color.FromArgb(181, 52, 113)

    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles btnDashboard.MouseEnter, btnProfile.MouseEnter, btnAddService.MouseEnter,
            btnOrder.MouseEnter, btnAboutUs.MouseEnter, btnFeedback.MouseEnter, btnComment.MouseEnter
        If sender.backcolor <> Color.FromArgb(181, 52, 113) AndAlso sender.backcolor = PanelButton.BackColor Then
            sender.backcolor = Color.FromArgb(247, 143, 179)
        End If
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles btnDashboard.MouseLeave, btnProfile.MouseLeave, btnAddService.MouseLeave,
            btnOrder.MouseLeave, btnAboutUs.MouseLeave, btnFeedback.MouseLeave, btnComment.MouseLeave
        If sender.backcolor <> Color.FromArgb(181, 52, 113) AndAlso sender.backcolor = Color.FromArgb(247, 143, 179) Then
            sender.backcolor = PanelButton.BackColor
        End If
    End Sub

End Class