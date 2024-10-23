Imports System.Data.OleDb

Public Class frmCarPoolDashboard
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Dim index As Integer = 1

    Sub DisplayEmptyStatement()
        pcbEmptyService.Visible = True
        flpCarPool.Controls.Add(pcbEmptyService)
    End Sub
    Private Sub frmCarPoolDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        'selerct the business type of the
        'reset the title of the combo box to Filter
        cboInOutUTP.SelectedItem = cboInOutUTP.Items(0)

        'check if the displayed service is empty (no availble car pooling service)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim Recordcount As Integer
            strSql = "SELECT COUNT(*) FROM [Service] INNER JOIN [Car Pooling Service] ON
                       [Service].Service_ID = [Car Pooling Service].Service_ID
                        WHERE [Closing Time] >= #" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "# AND [Seat Capacity] > 0"
            cmd = New OleDbCommand(strSql, conn)
            Recordcount = Convert.ToInt32(cmd.ExecuteScalar)
            If Recordcount <= 0 Then
                Call DisplayEmptyStatement()
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 0, "error in checking the record of car pooling service")
        End Try
        'display all car pool services
        disPlayCarPoolingServices()
    End Sub

    Sub disPlayCarPoolingServices()
        'if user business type is car pool services seller
        'display all the car pool services of seller
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            strSql = "SELECT * FROM [Service] INNER JOIN [Car Pooling Service] ON
                       [Service].Service_ID = [Car Pooling Service].Service_ID
                        WHERE [Closing Time] >= #" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "# AND [Seat Capacity] > 0"
            cmd = New OleDbCommand(strSql, conn)
            Dim myreader As OleDbDataReader
            Dim intcount As Integer = 1
            myreader = cmd.ExecuteReader()
            If myreader.HasRows Then
                While myreader.Read()
                    Dim serviceControl As New FlowOutAvailableService
                    With serviceControl
                        .Name = "UControl" + (intcount).ToString
                        .lblStore.Text = myreader("CarPooling_ID").ToString
                        .lblQty.Visible = True
                        .lblQty.Text = myreader("Seat Capacity").ToString
                        .Size = New Size(flpCarPool.Width - 15, 135)
                        .lblServiceName.Text = myreader.Item(2).ToString
                        .lblPrice.Text = myreader("Seat Price").ToString + " MYR"
                        .lblServiceFilter.Text = myreader("Area Available").ToString
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
                    flpCarPool.Controls.Add(serviceControl)
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

    Private Sub cboInOutUTP_dropdown(sender As Object, e As EventArgs) Handles cboInOutUTP.DropDown
        'if the title is the first items in the combo box when click drop
        If cboInOutUTP.Items(0) = "Filter" Then
            'remove the title item
            cboInOutUTP.Items.Remove(cboInOutUTP.Items(0))
        End If
    End Sub
    Private Sub cboInOutUTP_Leave(sender As Object, e As EventArgs) Handles cboInOutUTP.Leave
        'if the first item is not the title when user leave, and user didnt select any of the choices
        If cboInOutUTP.SelectedItem = "" Then
            'reset back the first item as Filter and display on combo box
            cboInOutUTP.Items.Insert(0, "Filter")
            cboInOutUTP.SelectedItem = cboInOutUTP.Items(0)
        End If
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
            'after searching, display back all the car pool services
            Call disPlayCarPoolingServices()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'select form database to get all the Car Pool Services in database
        cboInOutUTP.Items.Insert(0, "Filter")
        cboInOutUTP.SelectedItem = cboInOutUTP.Items(0)
        txtSearch.Text = "Search Name"
        txtSearch.ForeColor = Color.Gray
        flpCarPool.Controls.Clear()
        disPlayCarPoolingServices()
    End Sub

    Private Sub cboInOutUTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInOutUTP.SelectedIndexChanged
        'when the first item is not Filter
        'clear the flpCarPool
        flpCarPool.Controls.Clear()
        Dim strServiceArea As String

        'get the targetted service area from combo box
        strServiceArea = cboInOutUTP.SelectedItem
        If strServiceArea <> "Filter" Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT * FROM [Service] INNER JOIN [Car Pooling Service] ON
                       [Service].Service_ID = [Car Pooling Service].Service_ID WHERE [Area Available] = '" + strServiceArea + "'
                       AND [Closing Time] >= #" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "# AND [Seat Capacity] > 0"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                Dim intcount As Integer = 1
                myreader = cmd.ExecuteReader()
                If myreader.HasRows Then
                    While myreader.Read()
                        Dim serviceControl As New FlowOutAvailableService
                        With serviceControl
                            .Name = "UControl" + (intcount).ToString
                            .lblStore.Text = myreader("CarPooling_ID").ToString
                            .lblQty.Visible = True
                            .lblQty.Text = myreader("Seat Capacity").ToString
                            .Size = New Size(flpCarPool.Width - 10, 135)
                            .lblServiceName.Text = myreader.Item(2).ToString
                            .lblPrice.Text = myreader("Seat Price").ToString + " MYR"
                            .lblServiceFilter.Text = myreader("Area Available").ToString
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
                        flpCarPool.Controls.Add(serviceControl)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text <> String.Empty AndAlso txtSearch.Text <> "Search Name" Then
            flpCarPool.Controls.Clear()
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT * FROM [Service] INNER JOIN [Car Pooling Service] ON
                       [Service].Service_ID = [Car Pooling Service].Service_ID WHERE [Car Pooling Service].[Service Name] = '" + txtSearch.Text + "'
                       AND [Closing Time] >= #" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "# AND [Seat Capacity] > 0"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                Dim intcount As Integer = 1
                myreader = cmd.ExecuteReader()
                If myreader.HasRows Then
                    While myreader.Read()
                        Dim serviceControl As New FlowOutAvailableService
                        With serviceControl
                            .Name = "UControl" + (intcount).ToString
                            .lblStore.Text = myreader("CarPooling_ID").ToString
                            .lblQty.Visible = True
                            .lblQty.Text = myreader("Seat Capacity").ToString
                            .Size = New Size(flpCarPool.Width - 10, 135)
                            .lblServiceName.Text = myreader.Item(2).ToString
                            .lblPrice.Text = myreader("Seat Price").ToString + " MYR"
                            .lblServiceFilter.Text = myreader("Area Available").ToString
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
                        flpCarPool.Controls.Add(serviceControl)
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
            flpCarPool.Controls.Clear()
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT * FROM [Service] INNER JOIN [Car Pooling Service] ON
                       [Service].Service_ID = [Car Pooling Service].Service_ID WHERE [Car Pooling Service].[Service Name] LIKE '%" + txtSearch.Text + "%'
                       AND [Closing Time] >= #" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "# AND [Seat Capacity] > 0"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                Dim intcount As Integer = 1
                myreader = cmd.ExecuteReader()
                If myreader.HasRows Then
                    While myreader.Read()
                        Dim serviceControl As New FlowOutAvailableService
                        With serviceControl
                            .Name = "UControl" + (intcount).ToString
                            .lblStore.Text = myreader("CarPooling_ID").ToString
                            .lblQty.Visible = True
                            .lblQty.Text = myreader("Seat Capacity").ToString
                            .Size = New Size(flpCarPool.Width - 10, 135)
                            .lblServiceName.Text = myreader.Item(2).ToString
                            .lblPrice.Text = myreader("Seat Price").ToString + " MYR"
                            .lblServiceFilter.Text = myreader("Area Available").ToString
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
                        flpCarPool.Controls.Add(serviceControl)
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
