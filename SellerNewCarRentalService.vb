Imports System.Data.OleDb
Imports System.IO

Public Class frmSellerNewCarRentalService
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand

    'declaring the variable for the images file
    Dim saveDirectory As String = "D:\Users\user\Desktop\OMC_Images\"
    Dim SelectedFileName As String = ""
    Dim fileName As String = ""
    Dim fileSavePath As String = ""
    Dim directoryfromDataBase As String = ""

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
        If lblStoreCarRentalID.Text = "" Then
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

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click
        Dim intSeatQty As Integer = Val(txtQty.Text)
        Select Case sender.name
            Case "btnPlus"
                If intSeatQty < 12 Then 'if car is not 12 seat car
                    If intSeatQty = 2 Then '2 seat car become 5 seat car
                        txtQty.Text = intSeatQty + 3
                    ElseIf intSeatQty = 5 Then '5 seat car beocme 7 seat car
                        txtQty.Text = intSeatQty + 2
                    Else '7 seat car become 12 seat car
                        txtQty.Text = intSeatQty + 5
                    End If
                End If
            Case "btnMinus"
                'minimum seat is 2 , if current is 2, subtraction may not happen
                If intSeatQty > 2 Then 'if car is not 2 seat car
                    If intSeatQty = 5 Then '5 seat car become 2 seat
                        txtQty.Text = intSeatQty - 3
                    ElseIf intSeatQty = 7 Then '7 seat car become 5 seat car
                        txtQty.Text = intSeatQty - 2
                    Else '12 seat cra become 7 seat car
                        txtQty.Text = intSeatQty - 5
                    End If
                End If
        End Select
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbtHourly.CheckedChanged, rbtHalfDay.CheckedChanged,
            rbtFullDay.CheckedChanged
        If sender.name = "rbtHourly" Then
            With txtAvailableHours
                .Enabled = True
                .Visible = True
            End With
            lblHourly1.Visible = True
            lblHourly2.Visible = True

        Else 'half day or full day the textbox may not appear
            txtAvailableHours.Visible = False
            lblHourly1.Visible = False
            lblHourly2.Visible = False
        End If
    End Sub

    Sub AddNewCarRentalService(ByVal StartTime As DateTime, ByVal EndTime As DateTime)
        Try
            'Calculate the row of the table, to get the index of Table service
            Dim NewServiceID As String
            Dim NewCarRentalID As String

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
                cmd.Parameters.AddWithValue("@Service_Type", "Car Rental")
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
                strSql = "Select count(*) from [Car Rental Service]"
                cmd = New OleDbCommand(strSql, conn)
                rowCount = Convert.ToInt32(cmd.ExecuteScalar)
                'get the new CarPoolingId by RowCount + 1
                If rowCount >= 10 Then
                    NewCarRentalID = "CR0" + (rowCount + 1).ToString
                Else
                    NewCarRentalID = "CR00" + (rowCount + 1).ToString
                End If
                'MsgBox(NewCarPoolID)

                'Insert the input data into table of Car Pooling Service
                strSql = "INSERT INTO [Car Rental Service] ([CarRental_ID], [Service_ID], [Service Name], [Time Frame], [Available Hour],
                        [Seat Number], [Rental Price], [Operating Time], [Closing Time], [Car Photo]) 
                        VALUES (@CarRental_ID, @Service_ID, @Service_Name, @Time_Frame, @Available_Hour, @Seat_Number, @Rental_Price,
                        @Operating_Time, @Closing_Time, @Car_Photo)"

                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@CarRental_ID", NewCarRentalID)
                cmd.Parameters.AddWithValue("@Service_ID", NewServiceID)
                cmd.Parameters.AddWithValue("@Service_Name", txtServiceName.Text)

                Dim time_Frame As String
                Dim available_Hour As String
                If rbtFullDay.Checked = True Then
                    time_Frame = "FullDay"
                    available_Hour = 24
                ElseIf rbtHourly.Checked = True Then
                    time_Frame = "Hourly"
                    available_Hour = Val(txtAvailableHours.Text)
                Else
                    time_Frame = "HalfDay"
                    available_Hour = 12
                End If
                cmd.Parameters.AddWithValue("@Time_Frame", time_Frame)
                cmd.Parameters.AddWithValue("@Available_Hour", Convert.ToInt32(available_Hour))
                cmd.Parameters.AddWithValue("@Seat_Number", Convert.ToInt32(txtQty.Text))
                cmd.Parameters.AddWithValue("@Rental_Price", Convert.ToDouble(txtRentalPrice.Text))
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
                    MsgBox("Data of New Car Rental Service Has Been Saved.", MsgBoxStyle.OkOnly, "Add New Car Rental Service Successfully.")
                End If
                conn.Close()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error in adding new car rental service.")
                conn.Close()
            End Try
            'Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Sub UpdateCarRentalService(ByVal StartTime As DateTime, ByVal EndTime As DateTime)
        Try
            'Calculate the row of the table, to get the index of Table service
            Dim ServiceID As String = ""
            Dim CarRentalID As String = lblStoreCarRentalID.Text

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                'select the serviceId from the table car pooling service
                strSql = "SELECT [Service_ID],[Car Photo] FROM [Car Rental Service] WHERE [CarRental_ID] ='" + CarRentalID + "'"
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
                strSql = "UPDATE [Car Rental Service] SET [Service Name] =@Service_Name , [Time Frame] =@Time_Frame, [Available Hour] =@Available_Hour,
                            [Seat Number] =@Seat_Number ,[Operating Time] =@Operating_Time, [Closing Time] =@Closing_Time,
                            [Car Photo] = @Car_Photo WHERE [CarRental_ID]='" + CarRentalID + "' AND [Service_ID] = '" + ServiceID + "'"

                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@Service_Name", txtServiceName.Text)

                Dim time_Frame As String
                Dim available_Hour As String
                If rbtFullDay.Checked = True Then
                    time_Frame = "FullDay"
                    available_Hour = 24
                ElseIf rbtHourly.Checked = True Then
                    time_Frame = "Hourly"
                    available_Hour = Val(txtAvailableHours.Text)
                Else
                    time_Frame = "HalfDay"
                    available_Hour = 12
                End If
                cmd.Parameters.AddWithValue("@Time_Frame", time_Frame)
                cmd.Parameters.AddWithValue("@Available_Hour", Convert.ToInt32(available_Hour))
                cmd.Parameters.AddWithValue("@Seat_Number", Convert.ToInt32(txtQty.Text))
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
                    MsgBox("Data of the Car Rental Service Has Been Updated.", MsgBoxStyle.OkOnly, "Update Car Rental Service Successfully.")
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
        Dim StartDateTime, EndDateTime As DateTime
        StartDateTime = DateTime.Parse("#" + dtpStartOperationDate.Text + " " + cboHourStart.SelectedItem + ":" + cboMinuteStart.SelectedItem + ":00" + cboDayNightStart.SelectedItem + "#")
        EndDateTime = DateTime.Parse("#" + dtpEndOperationDate.Text + " " + cboHourEnd.SelectedItem + ":" + cboMinuteEnd.SelectedItem + ":00" + cboDayNightEnd.SelectedItem + "#")
        If sender.text = "ADD" Then
            'insert into database Service
            'insert into database Car Rental
            AddNewCarRentalService(StartDateTime, EndDateTime)
        Else
            UpdateCarRentalService(StartDateTime, EndDateTime)
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
        For Each txtbox As TextBox In {txtServiceName, txtRentalPrice, txtQty, txtAvailableHours}
            txtbox.Clear()
        Next txtbox

        'reset both radio button to false checked 
        rbtHourly.Checked = False
        rbtHalfDay.Checked = False
        rbtFullDay.Checked = False

        'reset the quantity
        txtQty.Text = 5

        'hide the textboxes of start point and end point
        txtAvailableHours.Visible = False
        lblHourly1.Visible = False
        lblHourly2.Visible = False
        lblValidation.Visible = False

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

    Private Sub txtAvailableHours_TextChanged(sender As Object, e As EventArgs) Handles txtAvailableHours.TextChanged
        'if input of hour is non-numeric data or the input is empty
        lblValidation.Text = "*Invalid Input"
        If IsNumeric(txtAvailableHours.Text) = False OrElse txtAvailableHours.Text = String.Empty Then
            lblValidation.Visible = True
            Return
        End If
        'if input of hour is 12 or above 12
        If Val(txtAvailableHours.Text) >= 12 Then
            lblValidation.Visible = True
            Return
        End If

        lblValidation.Visible = False
        lblValidation.Text = ""
    End Sub
End Class