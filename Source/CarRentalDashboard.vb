Imports System.Data.OleDb

Public Class frmCarRentalDashboard
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Dim index As Integer = 1

    Sub DisplayEmptyStatement()
        pcbEmptyService.Visible = True
        flpCarRental.Controls.Add(pcbEmptyService)
    End Sub
    Sub DisplayCarRentalService() 'sub procudure to display all the Car Rental Category Services
        'if user business type is car pool services seller
        'display all the car pool services of seller
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            strSql = "SELECT * FROM [Service] INNER JOIN [Car Rental Service] ON
                       [Service].Service_ID = [Car Rental Service].Service_ID
                        WHERE [Closing Time] >= #" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#"
            cmd = New OleDbCommand(strSql, conn)
            Dim myreader As OleDbDataReader
            Dim intcount As Integer = 1
            myreader = cmd.ExecuteReader()
            If myreader.HasRows Then
                While myreader.Read()
                    Dim serviceControl As New FlowOutAvailableService
                    With serviceControl
                        .Name = "UControl" + (intcount).ToString
                        .lblStore.Text = myreader("CarRental_ID").ToString
                        .Size = New Size(flpCarRental.Width - 20, 135)
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
                        If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#") Then 'before both operating and closing time
                            .lblStatus.Text = "Preparing..."
                            .pcbStatus.Image = My.Resources.icons8_black_circle_24
                        Else 'in between operating and closing time
                            .lblStatus.Text = "On Going..."
                            .pcbStatus.Image = My.Resources.icons8_green_circle_24
                        End If
                    End With
                    'add the new existing service user control into the flowoutpanel
                    flpCarRental.Controls.Add(serviceControl)
                    intcount += 1
                End While
            Else
                Call DisplayEmptyStatement()
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message & " Second Wrong")
            conn.Close()
        End Try
    End Sub
    Private Sub frmFoodOrderDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"

        'reset the title of the combo box to Filter
        cboPeriod.SelectedItem = cboPeriod.Items(0)
        'display all Car Rental services
        DisplayCarRentalService()
    End Sub
    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        'If the text in search bar is "Search Name" when user enter it
        If txtSearch.Text = "Search Name" Then
            'clear the text and change forecolor to black(normal text color)
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        'if user leave the search box with empty input text
        If txtSearch.Text = "" Then
            txtSearch.Text = "Search Name"
            txtSearch.ForeColor = Color.Gray
            'after searching, display back all the car rental services
            Call DisplayCarRentalService()
        End If
    End Sub
    Private Sub cboPeriod_dropdown(sender As Object, e As EventArgs) Handles cboPeriod.DropDown
        'if the title is the first items in the combo box when click drop
        If cboPeriod.Items(0) = "Filter" Then
            'remove the title item
            cboPeriod.Items.Remove(cboPeriod.Items(0))
        End If
    End Sub
    Private Sub cboPeriod_Leave(sender As Object, e As EventArgs) Handles cboPeriod.Leave
        'if the first item is not the title when user leave, and user didnt select any of the choices
        If cboPeriod.SelectedItem = "" Then
            'reset back the first item as Filter and display on combo box
            cboPeriod.Items.Insert(0, "Filter")
            cboPeriod.SelectedItem = cboPeriod.Items(0)
        End If
    End Sub

    Private Sub cboPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriod.SelectedIndexChanged
        flpCarRental.Controls.Clear()
        Dim strTimeFrame As String

        'get the targetted service area from combo box
        strTimeFrame = cboPeriod.SelectedItem
        If strTimeFrame <> "Filter" Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT * FROM [Service] INNER JOIN [Car Rental Service] ON
                       [Service].Service_ID = [Car Rental Service].Service_ID WHERE [Time Frame] = '" + strTimeFrame + "'
                       AND [Closing Time] >= #" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                Dim intcount As Integer = 1
                myreader = cmd.ExecuteReader()
                If myreader.HasRows Then
                    While myreader.Read()
                        Dim serviceControl As New FlowOutAvailableService
                        With serviceControl
                            .Name = "UControl" + (intcount).ToString
                            .lblStore.Text = myreader("CarRental_ID").ToString
                            .Size = New Size(flpCarRental.Width - 10, 135)
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
                            If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#") Then 'before both operating and closing time
                                .lblStatus.Text = "Preparing..."
                                .pcbStatus.Image = My.Resources.icons8_black_circle_24
                            Else 'in between operating and closing time
                                .lblStatus.Text = "On Going..."
                                .pcbStatus.Image = My.Resources.icons8_green_circle_24
                            End If
                        End With
                        'add the new existing service user control into the flowoutpanel
                        flpCarRental.Controls.Add(serviceControl)
                        intcount += 1
                    End While
                Else
                    Call DisplayEmptyStatement()
                End If
                conn.Close()

            Catch ex As Exception
                MsgBox(ex.Message & "Wrong")
                conn.Close()
            End Try
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'select form database to get all the Car Rental Services in database
        cboPeriod.Items.Insert(0, "Filter")
        cboPeriod.SelectedItem = cboPeriod.Items(0)
        txtSearch.Text = "Search Name"
        txtSearch.ForeColor = Color.Gray
        flpCarRental.Controls.Clear()
        Call DisplayCarRentalService()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text <> String.Empty AndAlso txtSearch.Text <> "Search Name" Then
            flpCarRental.Controls.Clear()
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT * FROM [Service] INNER JOIN [Car Rental Service] ON
                       [Service].Service_ID = [Car Rental Service].Service_ID WHERE [Car Rental Service].[Service Name] = '" + txtSearch.Text + "'
                       AND WHERE [Closing Time] >= #" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                Dim intcount As Integer = 1
                myreader = cmd.ExecuteReader()
                If myreader.HasRows Then
                    While myreader.Read()
                        Dim serviceControl As New FlowOutAvailableService
                        With serviceControl
                            .Name = "UControl" + (intcount).ToString
                            .lblStore.Text = myreader("CarRental_ID").ToString
                            .Size = New Size(flpCarRental.Width - 10, 135)
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
                            If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#") Then 'before both operating and closing time
                                .lblStatus.Text = "Preparing..."
                                .pcbStatus.Image = My.Resources.icons8_black_circle_24
                            Else 'in between operating and closing time
                                .lblStatus.Text = "On Going..."
                                .pcbStatus.Image = My.Resources.icons8_green_circle_24
                            End If
                        End With
                        'add the new existing service user control into the flowoutpanel
                        flpCarRental.Controls.Add(serviceControl)
                        intcount += 1
                    End While
                Else
                    Call DisplayEmptyStatement()
                End If
                conn.Close()

            Catch ex As Exception
                MsgBox(ex.Message & "Wrong")
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text <> String.Empty AndAlso txtSearch.Text <> "Search Name" Then
            flpCarRental.Controls.Clear()
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT * FROM [Service] INNER JOIN [Car Rental Service] ON
                       [Service].Service_ID = [Car Rental Service].Service_ID WHERE [Car Rental Service].[Service Name] LIKE '%" + txtSearch.Text + "%'
                       WHERE [Closing Time] >= #" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                Dim intcount As Integer = 1
                myreader = cmd.ExecuteReader()
                If myreader.HasRows Then
                    While myreader.Read()
                        Dim serviceControl As New FlowOutAvailableService
                        With serviceControl
                            .Name = "UControl" + (intcount).ToString
                            .lblStore.Text = myreader("CarRental_ID").ToString
                            .Size = New Size(flpCarRental.Width - 10, 135)
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
                            If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#") Then 'before both operating and closing time
                                .lblStatus.Text = "Preparing..."
                                .pcbStatus.Image = My.Resources.icons8_black_circle_24
                            Else 'in between operating and closing time
                                .lblStatus.Text = "On Going..."
                                .pcbStatus.Image = My.Resources.icons8_green_circle_24
                            End If
                        End With
                        'add the new existing service user control into the flowoutpanel
                        flpCarRental.Controls.Add(serviceControl)
                        intcount += 1
                    End While
                Else
                    Call DisplayEmptyStatement()
                End If
                conn.Close()

            Catch ex As Exception
                MsgBox(ex.Message & "Wrong")
                conn.Close()
            End Try
        End If
    End Sub
End Class
