Imports System.Data.OleDb
Imports System.IO

Public Class frmSellerNewFoodOrderingService
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand

    'declaring the variable for the images file
    Dim saveDirectory As String = "D:\Users\user\Desktop\OMC_Images\"
    Dim SelectedFileName As String = ""
    Dim fileName As String = ""
    Dim fileSavePath As String = ""
    Dim directoryfromDataBase As String = ""


    Dim strFoodType As String = ""

    Private Sub cboHourEnd_DropDown(sender As Object, e As EventArgs) Handles cboHourEnd.DropDown
        If cboHourStart.SelectedIndex <> -1 Then 'if hour is not 12
            cboHourEnd.SelectedItem = cboHourEnd.Items(cboHourStart.SelectedIndex + 1)
        Else 'if hour is 12, set also 
            cboHourEnd.SelectedItem = cboHourEnd.Items(cboHourStart.SelectedIndex)
        End If
    End Sub
    Private Sub frmSellerFoodOrdeirnglService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        'resetting the combo box to its title
        If lblStoreFoodOrderID.Text = "" Then
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

    Sub AddNewFoodOrderingService(ByVal StartTime As DateTime, ByVal EndTime As DateTime)
        Try
            'Calculate the row of the table, to get the index of Table service
            Dim NewServiceID As String
            Dim NewFoodOrderID As String

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'get the number of row in table user
            strSql = "Select count(*) from [Service]"
            cmd = New OleDbCommand(strSql, conn)
            Dim rowCount As Integer
            rowCount = Convert.ToInt32(cmd.ExecuteScalar)
            'get the new Service Id by RowCount + 1
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
                cmd.Parameters.AddWithValue("@Service_Type", "Food Order")
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("1...Data Saved in Service Table.", MsgBoxStyle.OkOnly)
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try

            Try
                'insert the input data into table Food Ordering Service as new service
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                'get the number of row in table Food Ordering Service
                strSql = "Select count(*) from [Food Ordering Service]"
                cmd = New OleDbCommand(strSql, conn)
                rowCount = Convert.ToInt32(cmd.ExecuteScalar)
                'get the new FoodOrderingId by RowCount + 1
                If rowCount >= 10 Then
                    NewFoodOrderID = "FO0" + (rowCount + 1).ToString
                Else
                    NewFoodOrderID = "FO00" + (rowCount + 1).ToString
                End If

                MsgBox(NewFoodOrderID)
                'Insert the input data into table of food Ordering Service
                strSql = "INSERT INTO [Food Ordering Service] ([FoodOrdering_ID], [Service_ID], [Service Name], [Price], [Stock Qty],
                        [Food Type], [Operating Time], [Closing Time], [Food Photo]) 
                        VALUES (@FoodOrdering_ID, @Service_ID, @Service_Name, @Price, @Stock_Qty, @Food_Type, @Operating_Time, @Closing_Time, @Food_Photo)"

                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@FoodOrdering_ID", NewFoodOrderID)
                cmd.Parameters.AddWithValue("@Service_ID", NewServiceID)
                cmd.Parameters.AddWithValue("@Service_Name", txtServiceName.Text)
                cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtFoodPrice.Text))
                cmd.Parameters.AddWithValue("@Stock_Qty", Convert.ToInt32(txtQty.Text))
                cmd.Parameters.AddWithValue("@Food_Type", strFoodType)
                cmd.Parameters.AddWithValue("@Operating_Time", StartTime)
                cmd.Parameters.AddWithValue("@Closing_Time", EndTime)

                If fileSavePath = "" Then
                    cmd.Parameters.AddWithValue("@Food_Photo", DBNull.Value)
                Else
                    'MsgBox("Saving image here")
                    cmd.Parameters.AddWithValue("@Food_Photo", fileSavePath)
                    'make a copy about the picture and saved it into the defined directory path
                    File.Copy(SelectedFileName, fileSavePath, True)
                End If

                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data of New Food Ordering Service Has Been Saved.", MsgBoxStyle.OkOnly, "Add New Food Ordering Service Successful")
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

    Sub UpdateFoodOrderingService(ByVal StartTime As DateTime, ByVal EndTime As DateTime)
        Try
            'Calculate the row of the table, to get the index of Table service
            Dim ServiceID As String = ""
            Dim FoodOrderID As String = lblStoreFoodOrderID.Text

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                'select the serviceId from the table car pooling service
                strSql = "SELECT [Service_ID],[Food Photo] FROM [Food Ordering Service] WHERE [FoodOrdering_ID] ='" + FoodOrderID + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader
                If myreader.HasRows Then
                    While myreader.Read()
                        ServiceID = myreader("Service_ID").ToString
                        If myreader("Food Photo") IsNot DBNull.Value Then
                            directoryfromDataBase = myreader("Food Photo").ToString
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
                strSql = "UPDATE [Food Ordering Service] SET [Service Name] =@Service_Name , [Stock Qty] =@Stock_Qty, [Food Type] =@Food_Type,
                            [Operating Time] =@Operating_Time, [Closing Time] =@Closing_Time, [Food Photo] = @Food_Photo 
                            WHERE [FoodOrdering_ID]='" + FoodOrderID + "' AND [Service_ID] = '" + ServiceID + "'"


                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@Service_Name", txtServiceName.Text)
                cmd.Parameters.AddWithValue("@Stock_Qty", Convert.ToInt32(txtQty.Text))
                cmd.Parameters.AddWithValue("@Food_Type", strFoodType)
                cmd.Parameters.AddWithValue("@Operating_Time", StartTime)
                cmd.Parameters.AddWithValue("@Closing_Time", EndTime)

                If fileSavePath = directoryfromDataBase Then
                    cmd.Parameters.AddWithValue("@Food_Photo", fileSavePath)
                Else
                    'MsgBox("Saving image here")
                    cmd.Parameters.AddWithValue("@Food_Photo", fileSavePath)
                    'make a copy about the picture and saved it into the defined directory path
                    File.Copy(SelectedFileName, fileSavePath, True)
                End If

                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Data of the Food Ordering Service Has Been Updated.", MsgBoxStyle.OkOnly, "Update Food Ordering Service Successfully.")
                End If
                conn.Close()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error in Updating Food Ordering Service")
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
            'insert into database Food Ordering
            AddNewFoodOrderingService(StartDateTime, EndDateTime)
        Else
            UpdateFoodOrderingService(StartDateTime, EndDateTime)
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Using OpenFileDialogFoodPhoto As OpenFileDialog = New OpenFileDialog()
            With OpenFileDialogFoodPhoto
                .Title = "Select User Profile Photo"
                .Filter = "Images File (*.jpg;*.png)|*.jpg;*.png"
            End With
            If OpenFileDialogFoodPhoto.ShowDialog() = DialogResult.OK Then
                'if the file is not inside the directory then will create a new directory
                If Not Directory.Exists(saveDirectory) Then
                    Directory.CreateDirectory(saveDirectory)
                End If
                SelectedFileName = OpenFileDialogFoodPhoto.FileName
                'get the file name from openfiledialog
                fileName = Path.GetFileName(OpenFileDialogFoodPhoto.FileName)
                'combine the save directory and filename as the directory path of the choosed picture
                fileSavePath = Path.Combine(saveDirectory, fileName)
                'display the selected image in the picture box
                pcbFoodPhoto.Image = Image.FromFile(SelectedFileName)
            End If
        End Using
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'reset the uploaded car photo
        pcbFoodPhoto.Image = My.Resources.Default_Food_Photo

        'clear the user input in the textbox
        For Each txtbox As TextBox In {txtServiceName, txtFoodPrice, txtQty}
            txtbox.Clear()
        Next txtbox

        'reset both radio button to false checked 
        rbtFood.Checked = False
        rbtBeverage.Checked = False
        rbtDessert.Checked = False

        'reset the quantity
        txtQty.Text = 1

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

    Private Sub rbtFood_CheckedChanged(sender As Object, e As EventArgs) Handles rbtFood.CheckedChanged, rbtBeverage.CheckedChanged, rbtDessert.CheckedChanged
        Select Case sender.name
            Case "rbtFood"
                If rbtFood.Checked = True Then
                    strFoodType = "Food"
                End If
            Case "rbtBeverage"
                If rbtBeverage.Checked = True Then
                    strFoodType = "Beverage"
                End If
            Case "rbtDessert"
                If rbtDessert.Checked = True Then
                    strFoodType = "Dessert"
                End If
        End Select

    End Sub
End Class