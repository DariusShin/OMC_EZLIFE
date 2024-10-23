Imports System.Data.OleDb
Imports System.IO

Public Class frmSellerNewCarPoolService
    'initializing the database connection and command
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand

    'declaring the variable for the images file
    Dim saveDirectory As String = "D:\Users\user\Desktop\OMC_Images\"
    Dim SelectedFileName As String = ""
    Dim fileName As String = ""
    Dim fileSavePath As String = ""
    Dim directoryfromDataBase As String = ""

    'initialize the items for the combo boxes
    Dim arrVillage() As String = {"Village 1", "Village 2", "Village 3", "Village 4", "Village 5", "Village 6", "All Village", "Others"}
    Dim arrState() As String = {"Perlis", "Kedah", "Penang", "Perak", "Selangor", "Kuala Lumpur", "Melaka", "Kelantan", "Terengganu", "Pahang", "Johor"}
    Dim strAreaAvailable As String
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
        If lblStoreCarPoolID.Text = "" Then
            cboHourStart.SelectedItem = cboHourStart.Items(0)
            cboHourEnd.SelectedItem = cboHourEnd.Items(0)
            cboMinuteStart.SelectedItem = cboMinuteStart.Items(0)
            cboMinuteEnd.SelectedItem = cboMinuteEnd.Items(0)
            cboDayNightStart.SelectedItem = cboDayNightStart.Items(0)
            cboDayNightEnd.SelectedItem = cboDayNightEnd.Items(0)
        End If
    End Sub

    Private Sub pcbExit_Click(sender As Object, e As EventArgs) Handles pcbExit.Click
        Me.Hide()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click
        Select Case sender.name
            'addition of 1 seat
            Case "btnPlus"
                txtQty.Text = Val(txtQty.Text) + 1
            Case "btnMinus"
                'minimum seat is 1, if current is 1, subtraction may not happen
                If Val(txtQty.Text) > 1 Then
                    txtQty.Text = Val(txtQty.Text) - 1
                End If
        End Select
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbtInUtp.CheckedChanged, rbtOutsideUtp.CheckedChanged
        ' changing the properties of the disabled combo box
        With txtStartPoint
            .Enabled = True
            .Visible = True
        End With

        With txtEndPoint
            .Enabled = True
            .Visible = True
        End With
        Select Case sender.name
            Case "rbtInUtp"
                If sender.checked = True Then
                    cboStartPoint.Enabled = True
                    cboEndPoint.Enabled = True
                    cboStartPoint.Items.Clear()
                    cboEndPoint.Items.Clear()
                    strAreaavailable = "In UTP"

                    For Each village As String In arrVillage
                        cboStartPoint.Items.Add(village)
                        cboEndPoint.Items.Add(village)
                    Next village
                    cboStartPoint.Text = ""
                    cboEndPoint.Text = ""
                End If
            Case "rbtOutsideUtp"
                If sender.checked = True Then
                    cboStartPoint.Enabled = True
                    cboEndPoint.Enabled = True
                    cboStartPoint.Items.Clear()
                    cboEndPoint.Items.Clear()
                    strAreaavailable = "Outside UTP"

                    For Each state As String In arrState
                        cboStartPoint.Items.Add(state)
                        cboEndPoint.Items.Add(state)
                    Next state
                    cboStartPoint.Text = ""
                    cboEndPoint.Text = ""
                End If
        End Select
    End Sub

    Sub AddNewCarPoolService(ByVal StartTime As DateTime, ByVal EndTime As DateTime)
        Try
            'Calculate the row of the table, to get the index of Table service
            Dim NewServiceID As String
            Dim NewCarPoolID As String

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
                cmd.Parameters.AddWithValue("@Service_Type", "Car Pool")
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
                strSql = "Select count(*) from [Car Pooling Service]"
                cmd = New OleDbCommand(strSql, conn)
                rowCount = Convert.ToInt32(cmd.ExecuteScalar)
                'get the new CarPoolingId by RowCount + 1
                If rowCount >= 10 Then
                    NewCarPoolID = "CP0" + (rowCount + 1).ToString
                Else
                    NewCarPoolID = "CP00" + (rowCount + 1).ToString
                End If
                'MsgBox(NewCarPoolID)

                'Insert the input data into table of Car Pooling Service
                strSql = "INSERT INTO [Car Pooling Service] ([CarPooling_ID], [Service_ID], [Service Name], [Seat Price], [Seat Capacity],
                        [Area Available], [Starting Point], [Destination], [Operating Time], [Closing Time], [Car Photo]) 
                        VALUES (@CarPooling_ID, @Service_ID, @Service_Name, @Seat_Price, @Seat_Capacity, @Area_Available, @Starting_Point,
                        @Destination, @Operating_Time, @Closing_Time, @Car_Photo)"

                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@CarPooling_ID", NewCarPoolID)
                cmd.Parameters.AddWithValue("@Service_ID", NewServiceID)
                cmd.Parameters.AddWithValue("@Service_Name", txtServiceName.Text)
                cmd.Parameters.AddWithValue("@Seat_Price", Convert.ToDouble(txtSeatPrice.Text))
                cmd.Parameters.AddWithValue("@Seat_Capacity", Convert.ToInt32(txtQty.Text))
                cmd.Parameters.AddWithValue("@Area_Available", strAreaAvailable)
                If txtStartPoint.Text IsNot String.Empty Then
                    cmd.Parameters.AddWithValue("@Starting_Point", (cboStartPoint.SelectedItem + "," + txtStartPoint.Text))
                Else
                    cmd.Parameters.AddWithValue("@Starting_Point", (cboStartPoint.SelectedItem))
                End If

                If txtEndPoint.Text IsNot String.Empty Then
                    cmd.Parameters.AddWithValue("@Destination", (cboEndPoint.SelectedItem + "," + txtEndPoint.Text))
                Else
                    cmd.Parameters.AddWithValue("@Destination", (cboEndPoint.SelectedItem))
                End If
                cmd.Parameters.AddWithValue("@Operating_Time", StartTime)
                cmd.Parameters.AddWithValue("@Closing_Time", EndTime)

                If fileSavePath = String.Empty Then
                    cmd.Parameters.AddWithValue("@Car_Photo", DBNull.Value)
                Else
                    'MsgBox("Saving image here")
                    cmd.Parameters.AddWithValue("@Car_Photo", fileSavePath)
                    'make a copy about the picture and saved it into the defined directory path
                    File.Copy(SelectedFileName, fileSavePath, True)
                End If

                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data of New Car Pooling Service Has Been Saved.", MsgBoxStyle.OkOnly, "Add New Car Pooling Service Successfully.")
                End If
                conn.Close()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
            'Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Sub UpdateCarPoolService(ByVal StartTime As DateTime, ByVal EndTime As DateTime)
        Try
            'Calculate the row of the table, to get the index of Table service
            Dim ServiceID As String = ""
            Dim CarPoolID As String = lblStoreCarPoolID.Text

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                'select the serviceId from the table car pooling service
                strSql = "SELECT [Service_ID],[Car Photo] FROM [Car Pooling Service] WHERE [CarPooling_ID] ='" + CarPoolID + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader
                If myreader.HasRows Then
                    While myreader.Read()
                        ServiceID = myreader("Service_ID").ToString
                        If myreader("Car Photo") IsNot DBNull.Value Then
                            directoryfromDataBase = myreader("Car Photo").ToString
                            fileSavePath = directoryfromDataBase
                        End If
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
                strSql = "UPDATE [Service] SET [Service Name]=@Service_Name WHERE [Service_ID] ='" + ServiceID + "'"
                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@Service_Name", txtServiceName.Text)
                If cmd.ExecuteNonQuery > 0 Then
                    'MsgBox("Data of the Car Pooling Service Has Been Updated.", MsgBoxStyle.OkOnly, "Update Car Pooling Service Successfully.")
                End If

                'Insert the input data into table of Car Pooling Service
                strSql = "UPDATE [Car Pooling Service] SET [Service Name] =@Service_Name , [Seat Capacity] =@Seat_Capacity, [Area Available] =@Area_Available,
                            [Starting Point] =@Starting_Point , [Destination] =@Destination, [Operating Time] =@Operating_Time, [Closing Time] =@Closing_Time,
                            [Car Photo] = @Car_Photo WHERE [CarPooling_ID]='" + CarPoolID + "' AND [Service_ID] = '" + ServiceID + "'"

                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@Service_Name", txtServiceName.Text)
                cmd.Parameters.AddWithValue("@Seat_Capacity", Convert.ToInt32(txtQty.Text))
                cmd.Parameters.AddWithValue("@Area_Available", strAreaAvailable)
                If txtStartPoint.Text IsNot String.Empty Then
                    cmd.Parameters.AddWithValue("@Starting_Point", (cboStartPoint.SelectedItem + "," + txtStartPoint.Text))
                Else
                    cmd.Parameters.AddWithValue("@Starting_Point", (cboStartPoint.SelectedItem))
                End If

                If txtEndPoint.Text IsNot String.Empty Then
                    cmd.Parameters.AddWithValue("@Destination", (cboEndPoint.SelectedItem + "," + txtEndPoint.Text))
                Else
                    cmd.Parameters.AddWithValue("@Destination", (cboEndPoint.SelectedItem))
                End If
                cmd.Parameters.AddWithValue("@Operating_Time", StartTime)
                cmd.Parameters.AddWithValue("@Closing_Time", EndTime)

                If fileSavePath = directoryfromDataBase Then
                    cmd.Parameters.AddWithValue("@Car_Photo", fileSavePath)
                Else
                    'MsgBox("Saving image here")
                    cmd.Parameters.AddWithValue("@Car_Photo", fileSavePath)
                    'make a copy about the picture and saved it into the defined directory path
                    File.Copy(SelectedFileName, fileSavePath, True)
                End If

                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data of the Car Pooling Service Has Been Updated.", MsgBoxStyle.OkOnly, "Update Car Pooling Service Successfully.")
                End If
                conn.Close()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error in Updating Car Pooling Service")
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
        If sender.text = "ADD" Then
            'insert into database Service
            'insert into database Car Pool
            AddNewCarPoolService(StartDateTime, EndDateTime)
        Else
            UpdateCarPoolService(StartDateTime, EndDateTime)
        End If


    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Using OpenFileDialogCarPhoto As OpenFileDialog = New OpenFileDialog()
            With OpenFileDialogCarPhoto
                .Title = "Select User Profile Photo"
                .Filter = "Images File (*.jpg;*.png)|*.jpg;*.png"
            End With
            If OpenFileDialogCarPhoto.ShowDialog() = DialogResult.OK Then
                'if the file is not inside the directory then will create a new directory
                If Not Directory.Exists(saveDirectory) Then
                    Directory.CreateDirectory(saveDirectory)
                End If
                SelectedFileName = OpenFileDialogCarPhoto.FileName
                'get the file name from openfiledialog
                fileName = Path.GetFileName(OpenFileDialogCarPhoto.FileName)
                'combine the save directory and filename as the directory path of the choosed picture
                fileSavePath = Path.Combine(saveDirectory, fileName)
                'display the selected image in the picture box
                pcbCarPhoto.Image = Image.FromFile(OpenFileDialogCarPhoto.FileName)
            End If
        End Using
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'reset the uploaded car photo
        pcbCarPhoto.Image = My.Resources.Default_Car_Photo

        'clear the user input in the textbox
        For Each txtbox As TextBox In {txtServiceName, txtSeatPrice, txtQty, txtStartPoint, txtEndPoint}
            txtbox.Clear()
        Next txtbox

        'disable both start point and end point combo box
        cboStartPoint.Enabled = False
        cboEndPoint.Enabled = False

        'reset both radio button to false checked 
        rbtInUtp.Checked = False
        rbtOutsideUtp.Checked = False

        'reset the quantity
        txtQty.Text = 1

        'hide the textboxes of start point and end point
        txtStartPoint.Visible = False
        txtEndPoint.Visible = False

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

        'reset the items of the start point and end point
        cboStartPoint.Items.Clear()
        cboEndPoint.Items.Clear()
        cboStartPoint.Text = ""
        cboEndPoint.Text = ""
    End Sub

End Class