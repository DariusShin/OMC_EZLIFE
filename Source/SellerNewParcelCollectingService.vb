Imports System.Data.OleDb

Public Class frmSellerNewParcelCollectingService
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand

    Private Sub cboHourEnd_DropDown(sender As Object, e As EventArgs) Handles cboHourEnd.DropDown
        If cboHourStart.SelectedIndex <> -1 Then 'if hour is not 12
            cboHourEnd.SelectedItem = cboHourEnd.Items(cboHourStart.SelectedIndex + 1)
        Else 'if hour is 12, set also 
            cboHourEnd.SelectedItem = cboHourEnd.Items(cboHourStart.SelectedIndex)
        End If
    End Sub
    Private Sub frmSellerNewCarPoolService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"

        'resetting the combo box to its title
        If lblStoreParcelCollectID.Text = "" Then
            cboHourStart.SelectedItem = cboHourStart.Items(0)
            cboHourEnd.SelectedItem = cboHourEnd.Items(0)
            cboMinuteStart.SelectedItem = cboMinuteStart.Items(0)
            cboMinuteEnd.SelectedItem = cboMinuteEnd.Items(0)
            cboDayNightStart.SelectedItem = cboDayNightStart.Items(0)
            cboDayNightEnd.SelectedItem = cboDayNightEnd.Items(0)
        End If
    End Sub

    Private Sub pcbExit_Click(sender As Object, e As EventArgs) Handles pcbExit.Click
        Me.Close()
    End Sub

    Sub AddNewParcelCollectingService(ByVal StartTime As DateTime, ByVal EndTime As DateTime)
        Try
            'Calculate the row of the table, to get the index of Table service
            Dim NewServiceID As String
            Dim NewParcelCollectID As String

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'get the number of row in table user
            strSql = "Select count(*) from [Service]"
            cmd = New OleDbCommand(strSql, conn)
            Dim rowCount As Integer
            rowCount = Convert.ToInt32(cmd.ExecuteScalar)

            'get the new ServiceId by RowCount + 1
            If rowCount >= 10 Then
                NewServiceID = "SV0" + (rowCount + 1).ToString
            Else
                NewServiceID = "SV00" + (rowCount + 1).ToString
            End If
            conn.Close()

            Try
                conn.Open()
                'Insert the input data into table of Service as new service
                strSql = "Insert into [Service] ([Service_ID], [Seller_ID], [Service Name], [Service Type]) values (@Service_ID, @Seller_ID, @Servic_Name, @Service_Type)"
                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@Service_ID", NewServiceID)
                cmd.Parameters.AddWithValue("@Seler_ID", frmSellerMainMenu.SellerID)
                cmd.Parameters.AddWithValue("@Service_Name", txtServiceName.Text)
                cmd.Parameters.AddWithValue("@Service_Type", "Parcel Collect")
                If cmd.ExecuteNonQuery > 0 Then
                    'MsgBox("1...Data Saved.", MsgBoxStyle.OkOnly)
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try

            Try
                'insert the input data into table Car Pooling Service as new service
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                'get the number of row in table Car Pooling Service
                strSql = "Select count(*) from [Parcel Collecting Service]"
                cmd = New OleDbCommand(strSql, conn)
                rowCount = Convert.ToInt32(cmd.ExecuteScalar)
                'get the new CarPoolingId by RowCount + 1
                If rowCount >= 10 Then
                    NewParcelCollectID = "PC0" + (rowCount + 1).ToString
                Else
                    NewParcelCollectID = "PC00" + (rowCount + 1).ToString
                End If
                'MsgBox(NewCarPoolID)

                'Insert the input data into table of Car Pooling Service
                strSql = "INSERT INTO [Parcel Collecting Service] ([ParcelCollecting_ID], [Service_ID], [Service Name], [Description], [Type],
                        [Weight], [Price], [Operating Time], [Closing Time]) 
                        VALUES (@ParcelCollecting_ID, @Service_ID, @Service_Name, @Description, @Type, @Weight, @Price, @Operating_Time, @Closing_Time)"

                cmd = New OleDbCommand(strSql, conn)

                Dim ParcelType As String
                Dim weight As String = ""
                If rbtFragile.Checked = True Then
                    ParcelType = "Fragile"
                ElseIf rbtNonFragile.Checked = True Then
                    ParcelType = "Non-Fragile"
                Else
                    ParcelType = "Both Type"
                End If

                'if all type is being selected
                If chkAllWeight.Checked = True Then
                    weight = "All Weight/"
                Else 'not all type
                    '<1 is being selected
                    If chkLess1kg.Checked = True Then
                        weight += "<1kg/"
                        '<1 and 1~3 is selected
                        If chk1kgto3kg.Checked = True Then
                            weight += "1kg~3kg/"
                            '<1 and >3 is selected
                        Else
                            weight += ">3kg/"
                        End If
                        '<1 is not selected, 1~3 is selected
                    ElseIf chk1kgto3kg.Checked = True Then
                        weight += "1~3kg/"
                        '1~3 and >3 is selected
                        If chkMore3kg.Checked = True Then
                            weight += ">3kg/"
                        End If
                    Else
                        'only >3 is selected
                        weight += ">3kg/"
                    End If
                End If

                cmd.Parameters.AddWithValue("@ParcelCollecting_ID", NewParcelCollectID)
                cmd.Parameters.AddWithValue("@Service_ID", NewServiceID)
                cmd.Parameters.AddWithValue("@Service_Name", txtServiceName.Text)
                cmd.Parameters.AddWithValue("@Description", txtServiceDescription.Text)
                cmd.Parameters.AddWithValue("@Type", ParcelType)
                cmd.Parameters.AddWithValue("@Weight", weight.Trim("/"))
                cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtCollectPrice.Text))
                cmd.Parameters.AddWithValue("@Operating_Time", StartTime)
                cmd.Parameters.AddWithValue("@Closing_Time", EndTime)

                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data of New Parcel Collecting Service Has Been Saved.", MsgBoxStyle.OkOnly, "Add New Parcel Collecting Service Successfully.")
                End If
                conn.Close()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error in adding new Parcel Collecting service.")
                conn.Close()
            End Try
            'Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Sub UpdateParcelCollecingService(ByVal StartTime As DateTime, ByVal EndTime As DateTime)
        Try
            'Calculate the row of the table, to get the index of Table service
            Dim ServiceID As String = ""
            Dim ParcelCollectID As String = lblStoreParcelCollectID.Text

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                'select the serviceId from the table car pooling service
                strSql = "SELECT [Service_ID] FROM [Parcel Collecting Service] WHERE [ParcelCollecting_ID] ='" + ParcelCollectID + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader
                If myreader.HasRows Then
                    While myreader.Read()
                        ServiceID = myreader("Service_ID").ToString
                    End While
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try

            Try
                'UPDATE the input value as the new detyials of the existing service (Not included the price and ID)
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "UPDATE [Service] SET [Service Name]= @Service_Name WHERE [Service_ID] ='" + ServiceID + "'"
                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@Service_Name", txtServiceName.Text)
                If cmd.ExecuteNonQuery > 0 Then
                    'MsgBox("Data of the Car Pooling Service Has Been Updated.", MsgBoxStyle.OkOnly, "Update Car Pooling Service Successfully.")
                End If

                'Update the input data into table of Parcel Collecting Service
                strSql = "UPDATE [Parcel Collecting Service] SET [Service Name] = @Service_Name, [Description] =@Description, [Type] =@Type,
                            [Weight] =@Weight ,[Operating Time] = @Operating_Time, [Closing Time] =@Closing_Time
                            WHERE [ParcelCollecting_ID]='" + ParcelCollectID + "' AND [Service_ID] = '" + ServiceID + "'"
                cmd = New OleDbCommand(strSql, conn)

                cmd.Parameters.AddWithValue("@Service_Name", txtServiceName.Text)
                cmd.Parameters.AddWithValue("@Description", txtServiceDescription.Text)
                Dim ParcelType As String
                Dim weight As String = ""
                If rbtFragile.Checked = True Then
                    ParcelType = "Fragile"
                ElseIf rbtNonFragile.Checked = True Then
                    ParcelType = "Non-Fragile"
                Else
                    ParcelType = "Both Type"
                End If

                'if all type is being selected
                If chkAllWeight.Checked = True Then
                    weight = "All Weight/"
                Else 'not all type
                    '<1 is being selected
                    If chkLess1kg.Checked = True Then
                        weight += "<1kg/"
                        '<1 and 1~3 is selected
                        If chk1kgto3kg.Checked = True Then
                            weight += "1kg~3kg/"
                            '<1 and >3 is selected
                        Else
                            weight += ">3kg/"
                        End If
                        '<1 is not selected, 1~3 is selected
                    ElseIf chk1kgto3kg.Checked = True Then
                        weight += "1kg~3kg/"
                        '1~3 and >3 is selected
                        If chkMore3kg.Checked = True Then
                            weight += ">3kg/"
                        End If
                    Else
                        'only >3 is selected
                        weight += ">3kg/"
                    End If
                End If
                cmd.Parameters.AddWithValue("@Type", ParcelType)
                cmd.Parameters.AddWithValue("@Weight", weight.Trim("/"))
                cmd.Parameters.AddWithValue("@Operating_Time", StartTime)
                cmd.Parameters.AddWithValue("@Closing_Time", EndTime)

                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data of the Parcel Collecting Service Has Been Updated.", MsgBoxStyle.OkOnly, "Update Parcel Collecting Service Successfully.")
                End If
                conn.Close()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error in Updating Parcel Collecting Service")
                conn.Close()
            End Try
            'Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click

        'error checking here
        Dim StartDateTime, EndDateTime As DateTime
        StartDateTime = DateTime.Parse("#" + dtpStartOperationDate.Text + " " + cboHourStart.SelectedItem + ":" + cboMinuteStart.SelectedItem + ":00" + cboDayNightStart.SelectedItem + "#")
        EndDateTime = DateTime.Parse("#" + dtpEndOperationDate.Text + " " + cboHourEnd.SelectedItem + ":" + cboMinuteEnd.SelectedItem + ":00" + cboDayNightEnd.SelectedItem + "#")
        If btnAddService.Text = "ADD" Then
            'insert into database Service
            'insert into database Parcel Collecting
            Call AddNewParcelCollectingService(StartDateTime, EndDateTime)
        Else
            Call UpdateParcelCollecingService(StartDateTime, EndDateTime)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'clear the user input in the textbox
        For Each txtbox As TextBox In {txtServiceName, txtCollectPrice, txtServiceDescription}
            txtbox.Clear()
        Next txtbox

        'reset both radio button to false checked 
        rbtFragile.Checked = False
        rbtNonFragile.Checked = False
        rbtBothType.Checked = False

        'reste the check box of parcel weight
        For Each chkbox As CheckBox In {chkLess1kg, chk1kgto3kg, chkMore3kg, chkAllWeight}
            chkbox.Checked = False
        Next

        'reset the time
        cboHourStart.SelectedItem = cboHourStart.Items(0)
        cboHourEnd.SelectedItem = cboHourEnd.Items(0)
        cboMinuteStart.SelectedItem = cboMinuteStart.Items(0)
        cboMinuteEnd.SelectedItem = cboMinuteEnd.Items(0)
        cboDayNightStart.SelectedItem = cboDayNightStart.Items(0)
        cboDayNightEnd.SelectedItem = cboDayNightEnd.Items(0)

        'reset the date to current date
        dtpStartOperationDate.Value = Date.Today
        dtpEndOperationDate.Value = Date.Today
    End Sub

    Private Sub chkLess1kg_CheckedChanged(sender As Object, e As EventArgs) Handles chkLess1kg.CheckedChanged, chk1kgto3kg.CheckedChanged,
        chkMore3kg.CheckedChanged, chkAllWeight.CheckedChanged
        'if all weight checkbox is checked the will ignore others choice
        If chkAllWeight.Checked = True Then
            chkLess1kg.Checked = False
            chk1kgto3kg.Checked = False
            chkMore3kg.Checked = False
            Return
        End If

        If chkLess1kg.Checked = True AndAlso chk1kgto3kg.Checked = True AndAlso chkMore3kg.Checked = True Then
            chkAllWeight.Checked = True
            chkLess1kg.Checked = False
            chk1kgto3kg.Checked = False
            chkMore3kg.Checked = False
        End If
    End Sub
End Class