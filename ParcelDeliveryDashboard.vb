Imports System.Data.OleDb

Public Class frmParcelCollectingDashboard
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Dim index As Integer = 1
    Sub DisplayEmptyStatement()
        pcbEmptyService.Visible = True
        flpParcelCollect.Controls.Add(pcbEmptyService)
    End Sub
    Sub DisplayParcelCollectService() 'sub procudure to display all the Parcel Collecting Category Services
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            strSql = "SELECT * FROM [Service] INNER JOIN [Parcel Collecting Service] ON [Service].Service_ID = [Parcel Collecting Service].Service_ID
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
                        .lblStore.Text = myreader("ParcelCollecting_ID").ToString
                        .Size = New Size(flpParcelCollect.Width - 10, 135)
                        .lblServiceName.Text = myreader.Item(2).ToString
                        .lblPrice.Text = myreader("Price").ToString + " MYR"
                        .lblServiceFilter.Text = myreader("Type").ToString + ":" + myreader("Weight").ToString
                        .lblOperationDateTime.Text = myreader("Operating Time").ToString + vbNewLine + myreader("Closing Time").ToString
                        .pcbBusinessLogo.Image = My.Resources.icons8_parcel_100__1_
                        If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#") Then 'before both operating and closing time
                            .lblStatus.Text = "Preparing..."
                            .pcbStatus.Image = My.Resources.icons8_black_circle_24
                        Else 'in between operating and closing time
                            .lblStatus.Text = "On Going..."
                            .pcbStatus.Image = My.Resources.icons8_green_circle_24
                        End If
                    End With
                    'add the new existing service user control into the flowoutpanel
                    flpParcelCollect.Controls.Add(serviceControl)
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
    End Sub
    Private Sub frmParcelCollectingDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        cboWeightUTP.SelectedItem = cboWeightUTP.Items(0)

        'display all car pool services
        DisplayParcelCollectService()
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
            Call DisplayParcelCollectService()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'select form database to get all the Parcel Collecting Services in database
        cboWeightUTP.Items.Insert(0, "Filter")
        cboWeightUTP.SelectedItem = cboWeightUTP.Items(0)
        txtSearch.Text = "Search Name"
        txtSearch.ForeColor = Color.Gray
        flpParcelCollect.Controls.Clear()
        DisplayParcelCollectService()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub cboWeightUTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWeightUTP.SelectedIndexChanged
        'when the first item is not Filter
        'clear the flpCarPool
        flpParcelCollect.Controls.Clear()
        Dim strWeight As String = ""

        'get the targetted service area from combo box
        strWeight = cboWeightUTP.SelectedItem
        'if the filter is not the selected item in the combo box
        If strWeight <> "Filter" Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT * FROM [Service] INNER JOIN [Parcel Collecting Service] ON
                       [Service].Service_ID = [Parcel Collecting Service].Service_ID WHERE [Parcel Collecting Service].[Weight] LIKE '%" & strWeight & "%'
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
                            .lblStore.Text = myreader("ParcelCollecting_ID").ToString
                            .Size = New Size(flpParcelCollect.Width - 10, 135)
                            .lblServiceName.Text = myreader.Item(2).ToString
                            .lblPrice.Text = myreader("Price").ToString + " MYR"
                            .lblServiceFilter.Text = myreader("Type").ToString + ":" + myreader("Weight").ToString
                            .lblOperationDateTime.Text = myreader("Operating Time").ToString + vbNewLine + myreader("Closing Time").ToString
                            .pcbBusinessLogo.Image = My.Resources.icons8_parcel_100__1_
                            If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#") Then 'before both operating and closing time
                                .lblStatus.Text = "Preparing..."
                                .pcbStatus.Image = My.Resources.icons8_black_circle_24
                            Else 'in between operating and closing time
                                .lblStatus.Text = "On Going..."
                                .pcbStatus.Image = My.Resources.icons8_green_circle_24
                            End If
                        End With
                        'add the new existing service user control into the flowoutpanel
                        flpParcelCollect.Controls.Add(serviceControl)
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

    Private Sub cboWeightUTP_Leave(sender As Object, e As EventArgs) Handles cboWeightUTP.Leave
        'if the first item is not the title when user leave, and user didnt select any of the choices
        If cboWeightUTP.SelectedItem = "" Then
            'reset back the first item as Filter and display on combo box
            cboWeightUTP.Items.Insert(0, "Filter")
            cboWeightUTP.SelectedItem = cboWeightUTP.Items(0)
        End If
    End Sub

    Private Sub cboWeightUTP_DropDown(sender As Object, e As EventArgs) Handles cboWeightUTP.DropDown
        'if the title is the first items in the combo box when click drop
        If cboWeightUTP.Items(0) = "Filter" Then
            'remove the title item
            cboWeightUTP.Items.Remove(cboWeightUTP.Items(0))
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim strSearch As String = ""
        strSearch = txtSearch.Text

        If strSearch <> String.Empty And strSearch <> "Search Name" Then
            flpParcelCollect.Controls.Clear()
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT * FROM [Service] INNER JOIN [Parcel Collecting Service] ON
                       [Service].Service_ID = [Parcel Collecting Service].Service_ID WHERE [Parcel Collecting Service].[Service Name] LIKE '%" & strSearch & "%'
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
                            .lblStore.Text = myreader("ParcelCollecting_ID").ToString
                            .Size = New Size(flpParcelCollect.Width - 10, 135)
                            .lblServiceName.Text = myreader.Item(2).ToString
                            .lblPrice.Text = myreader("Price").ToString + " MYR"
                            .lblServiceFilter.Text = myreader("Type").ToString + ":" + myreader("Weight").ToString
                            .lblOperationDateTime.Text = myreader("Operating Time").ToString + vbNewLine + myreader("Closing Time").ToString
                            .pcbBusinessLogo.Image = My.Resources.icons8_parcel_100__1_
                            If myreader("Operating Time") >= ("#" & Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") & "#") Then 'before both operating and closing time
                                .lblStatus.Text = "Preparing..."
                                .pcbStatus.Image = My.Resources.icons8_black_circle_24
                            Else 'in between operating and closing time
                                .lblStatus.Text = "On Going..."
                                .pcbStatus.Image = My.Resources.icons8_green_circle_24
                            End If
                        End With
                        'add the new existing service user control into the flowoutpanel
                        flpParcelCollect.Controls.Add(serviceControl)
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
