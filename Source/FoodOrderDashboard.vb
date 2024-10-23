Imports System.Data.OleDb

Public Class frmFoodOrderDashboard
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Sub DisplayEmptyStatement()
        pcbEmptyService.Visible = True
        flpFoodOrder.Controls.Add(pcbEmptyService)
    End Sub
    Private Sub frmFoodOrderDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        'reset the title of the combo box to Filter
        cboFoodType.SelectedItem = cboFoodType.Items(0)
        'display all car pool services
        flpFoodOrder.Controls.Clear()
        Call DisplayFoodOrderingServices()
    End Sub
    Sub DisplayFoodOrderingServices()
        'if user business type is car pool services seller
        'display all the car pool services of seller
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            strSql = "SELECT * FROM [Service] INNER JOIN [Food Ordering Service] ON
                       [Service].Service_ID = [Food Ordering Service].Service_ID WHERE [Stock Qty] > 0
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
                        .lblStore.Text = myreader("FoodOrdering_ID").ToString
                        .Size = New Size(flpFoodOrder.Width - 20, 135)
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
                        If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#") Then 'before both operating and closing time
                            .lblStatus.Text = "Preparing..."
                            .pcbStatus.Image = My.Resources.icons8_black_circle_24
                        Else 'in between operating and closing time
                            .lblStatus.Text = "On Going..."
                            .pcbStatus.Image = My.Resources.icons8_green_circle_24
                        End If
                    End With
                    'add the new existing service user control into the flowoutpanel
                    flpFoodOrder.Controls.Add(serviceControl)
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
            'after searching, display back all the food ordering services
            Call DisplayFoodOrderingServices()
        End If
    End Sub
    Private Sub cboFoodType_dropdown(sender As Object, e As EventArgs) Handles cboFoodType.DropDown
        'if the title is the first items in the combo box when click drop
        If cboFoodType.Items(0) = "Filter" Then
            'remove the title item
            cboFoodType.Items.Remove(cboFoodType.Items(0))
        End If
    End Sub
    Private Sub cboFoodType_Leave(sender As Object, e As EventArgs) Handles cboFoodType.Leave
        'if the first item is not the title when user leave, and user didnt select any of the choices
        If cboFoodType.SelectedItem = "" Then
            'reset back the first item as Filter and display on combo box
            cboFoodType.Items.Insert(0, "Filter")
            cboFoodType.SelectedItem = cboFoodType.Items(0)
        End If
    End Sub
    Private Sub cboFoodType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFoodType.SelectedIndexChanged
        If cboFoodType.SelectedItem <> "Filter" AndAlso cboFoodType.SelectedItem <> String.Empty Then
            'when the first item is not Filter
            'clear the flpCarPool
            flpFoodOrder.Controls.Clear()
            Dim strFoodType As String

            'get the targetted service area from combo box
            strFoodType = cboFoodType.SelectedItem

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT * FROM [Service] INNER JOIN [Food Ordering Service] ON
                       [Service].Service_ID = [Food Ordering Service].Service_ID WHERE [Food Type] = '" + strFoodType + "' AND [Stock Qty] > 0
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
                            .lblStore.Text = myreader("FoodOrdering_ID").ToString
                            .Size = New Size(flpFoodOrder.Width - 10, 135)
                            .lblServiceName.Text = myreader.Item(2).ToString
                            .lblPrice.Text = myreader("Price").ToString + " MYR"
                            .lblQty.Visible = True
                            .lblQty.Text = myreader("Stock Qty").ToString
                            .lblServiceFilter.Text = strFoodType
                            .lblOperationDateTime.Text = myreader("Operating Time").ToString + vbNewLine + myreader("Closing Time").ToString
                            If myreader("Food Photo") IsNot DBNull.Value Then
                                .pcbBusinessLogo.Image = Image.FromFile(myreader("Food Photo"))
                            Else
                                .pcbBusinessLogo.Image = My.Resources.Default_Food_Photo
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
                        flpFoodOrder.Controls.Add(serviceControl)
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
        'select form database to get all the Food Order Services in database
        cboFoodType.Items.Insert(0, "Filter")
        cboFoodType.SelectedItem = cboFoodType.Items(0)
        txtSearch.Text = "Search Name"
        txtSearch.ForeColor = Color.Gray
        flpFoodOrder.Controls.Clear()
        Call DisplayFoodOrderingServices()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text <> String.Empty AndAlso txtSearch.Text <> "Search Name" Then
            'clear the services in dashboard
            flpFoodOrder.Controls.Clear()
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT * FROM [Service] INNER JOIN [Food Ordering Service] ON
                       [Service].Service_ID = [Food Ordering Service].Service_ID WHERE [Food Ordering Service].[Service Name] = '" + txtSearch.Text + "' AND [Stock Qty] > 0
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
                            .lblStore.Text = myreader("FoodOrdering_ID").ToString
                            .Size = New Size(flpFoodOrder.Width - 10, 135)
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
                            If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#") Then 'before both operating and closing time
                                .lblStatus.Text = "Preparing..."
                                .pcbStatus.Image = My.Resources.icons8_black_circle_24
                            Else 'in between operating and closing time
                                .lblStatus.Text = "On Going..."
                                .pcbStatus.Image = My.Resources.icons8_green_circle_24
                            End If
                        End With
                        'add the new existing service user control into the flowoutpanel
                        flpFoodOrder.Controls.Add(serviceControl)
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
            'clear the services in dashboard
            flpFoodOrder.Controls.Clear()
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT * FROM [Service] INNER JOIN [Food Ordering Service] ON
                       [Service].Service_ID = [Food Ordering Service].Service_ID WHERE [Food Ordering Service].[Service Name] LIKE '%" + txtSearch.Text + "%' AND [Stock Qty] > 0
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
                            .lblStore.Text = myreader("FoodOrdering_ID").ToString
                            .Size = New Size(flpFoodOrder.Width - 10, 135)
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
                            If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#") Then 'before both operating and closing time
                                .lblStatus.Text = "Preparing..."
                                .pcbStatus.Image = My.Resources.icons8_black_circle_24
                            Else 'in between operating and closing time
                                .lblStatus.Text = "On Going..."
                                .pcbStatus.Image = My.Resources.icons8_green_circle_24
                            End If
                        End With
                        'add the new existing service user control into the flowoutpanel
                        flpFoodOrder.Controls.Add(serviceControl)
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
