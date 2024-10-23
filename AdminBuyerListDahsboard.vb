Imports System.Data.OleDb
Imports System.IO
Public Class frmAdminBuyerListDahsboard
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter

    'declaring the variable for the images file
    Dim saveDirectory As String = "D:\Users\user\Desktop\OMC_Images\"
    Dim SelectedFileName As String = ""
    Dim fileName As String = ""
    Dim fileSavePath As String = ""
    Dim directoryfromDataBase As String = ""

    Sub clear()
        For Each txtbox As TextBox In {txtUsername, txtPassword, txtFullName, txtContactNo, txtGmail, txtNRIC}
            txtbox.ReadOnly = True
            txtbox.Clear()
        Next
        btnUploadLogo.Enabled = False
        btnAddNew.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        pcbProfilePhoto.Image = My.Resources.userDefaultImage
        Call DisplayBuyerList()
    End Sub
    Function InputChecking() As Boolean
        For Each txtbox As TextBox In {txtUsername, txtPassword, txtFullName, txtContactNo, txtGmail, txtNRIC}
            If txtbox.Text = String.Empty Then
                MsgBox("Please complete all the input.", 0, "Reminder of Invalid Input ")
                Return False
                Exit Function
            End If
        Next txtbox
        Return True
    End Function
    Sub DisplayBuyerList()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Try
            strSql = "SELECT [Buyer].*, [User].[Username], [User].[Password] FROM [Buyer] INNER JOIN [User] ON [Buyer].[User_ID] = [User].[User_ID] ORDER BY [Buyer_ID]"
            cmd = New OleDbCommand(strSql, conn)
            da = New OleDbDataAdapter With {
                .SelectCommand = cmd
                }
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            DGVBuyer.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in displaying the seller from database")
            conn.Close()
        End Try
    End Sub
    Private Sub frmAdminBuyerListDahsboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        'to check whether the buyer list got record
        Call DisplayBuyerList()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        For Each txtbox As TextBox In {txtUsername, txtPassword, txtFullName, txtContactNo, txtGmail, txtNRIC}
            txtbox.ReadOnly = False
        Next

        btnUploadLogo.Enabled = True
        btnAddNew.Enabled = True
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnUploadLogo_Click(sender As Object, e As EventArgs) Handles btnUploadLogo.Click
        Using OpenFileDialogProfilePhoto As OpenFileDialog = New OpenFileDialog()
            With OpenFileDialogProfilePhoto
                .Title = "Select User Profile Photo"
                .Filter = "Images File (*.jpg;*.png)|*.jpg;*.png"
            End With
            If OpenFileDialogProfilePhoto.ShowDialog() = DialogResult.OK Then
                'if the file is not inside the directory then will create a new directory
                If Not Directory.Exists(saveDirectory) Then
                    Directory.CreateDirectory(saveDirectory)
                End If
                SelectedFileName = OpenFileDialogProfilePhoto.FileName
                'get the file name from openfiledialog
                fileName = Path.GetFileName(OpenFileDialogProfilePhoto.FileName)
                'combine the save directory and filename as the directory path of the choosed picture
                fileSavePath = Path.Combine(saveDirectory, fileName)
                'display the selected image in the picture box
                pcbProfilePhoto.Image = Image.FromFile(OpenFileDialogProfilePhoto.FileName)
            End If
        End Using
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        clear()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim checkingResult As Boolean
        checkingResult = InputChecking()

        If checkingResult = True Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT COUNT(*) FROM [User] WHERE [Username] = '" + txtUsername.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                If Convert.ToInt32(cmd.ExecuteScalar) > 0 Then
                    MsgBox("Please enter a different username.", 0, "Duplication with the existing username")
                    txtUsername.Clear()
                    conn.Close()
                    Return
                Else
                    MsgBox("NO duplication in username")
                End If

                Dim NewUserID As String
                Dim NewBuyerID As String

                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                'get the number of row in table user
                strSql = "Select count(*) from [User]"
                cmd = New OleDbCommand(strSql, conn)
                Dim rowCount As Integer
                rowCount = Convert.ToInt32(cmd.ExecuteScalar)
                'get the new user Id by RowCount + 1
                If rowCount >= 10 Then
                    NewUserID = "U0" + (rowCount + 1).ToString
                Else
                    NewUserID = "U00" + (rowCount + 1).ToString
                End If
                'MsgBox("The Row in table user is" & CStr(rowCount) & vbNewLine & "The new User_Id should be " & NewUSerID)
                conn.Close()

                Try
                    conn.Open()
                    'Insert the input data into table of User
                    strSql = "Insert into [User] ([User_ID], [Username], [Password], [User_Type]) values (@User_ID, @Username, @Password, @User_Type)"
                    cmd = New OleDbCommand(strSql, conn)
                    cmd.Parameters.AddWithValue("@User_ID", NewUserID)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@User_Type", "Buyer")

                    If cmd.ExecuteNonQuery > 0 Then
                        'MsgBox("New Sign Up Data Has Been Saved.", MsgBoxStyle.OkOnly, "Sign Up Successful")
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    conn.Close()
                End Try

                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    'get the number of row in table user
                    strSql = "Select count(*) from [Buyer]"
                    cmd = New OleDbCommand(strSql, conn)
                    rowCount = Convert.ToInt32(cmd.ExecuteScalar)
                    'get the new user Id by RowCount + 1
                    If rowCount >= 10 Then
                        NewBuyerID = "B0" + (rowCount + 1).ToString
                    Else
                        NewBuyerID = "B00" + (rowCount + 1).ToString
                    End If
                    'MsgBox(NewBuyerID)

                    'Insert the input data into table of Buyer
                    strSql = "INSERT INTO [Buyer] ([Buyer_ID], [User_ID], [Full Name], [NRIC], [Phone], [Gmail], [Profile Image]) 
                        VALUES (@Buyer_ID, @User_ID, @Full_Name, @NRIC, @Phone, @Gmail, @Profile_Image)"

                    cmd = New OleDbCommand(strSql, conn)
                    cmd.Parameters.AddWithValue("@Buyer_ID", NewBuyerID)
                    cmd.Parameters.AddWithValue("@User_ID", NewUserID)
                    cmd.Parameters.AddWithValue("@Full_Name", txtFullName.Text)
                    cmd.Parameters.AddWithValue("@NRIC", txtNRIC.Text)
                    cmd.Parameters.AddWithValue("@Phone", txtContactNo.Text)
                    cmd.Parameters.AddWithValue("@Gmail", txtGmail.Text)
                    If fileSavePath = "" Then
                        cmd.Parameters.AddWithValue("@Profile_Image", DBNull.Value)
                    Else
                        'MsgBox("Saving image here")
                        cmd.Parameters.AddWithValue("@Profile_Image", fileSavePath)
                        'make a copy about the picture and saved it into the defined directory path
                        File.Copy(SelectedFileName, fileSavePath, True)
                    End If

                    If cmd.ExecuteNonQuery > 0 Then
                        'MsgBox("New Sign Up Data Has Been Saved.", MsgBoxStyle.OkOnly, "Sign Up Successful")
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, 0, "error in insert new buyer")
                    conn.Close()
                End Try
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error in insert new buyer and user")
                conn.Close()
            End Try

            clear()
        End If
    End Sub

    Dim index As Integer
    Dim selectedrow As DataGridViewRow
    Dim userID As String
    Dim buyerId As String
    Private Sub DGVBuyer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBuyer.CellClick

        Index = e.RowIndex
        selectedrow = DGVBuyer.Rows(index)
        buyerId = selectedrow.Cells(0).Value.ToString
        userID = selectedrow.Cells(1).Value.ToString
        txtFullName.Text = selectedrow.Cells(2).Value.ToString
        txtNRIC.Text = selectedrow.Cells(3).Value.ToString
        txtContactNo.Text = selectedrow.Cells(4).Value.ToString
        txtGmail.Text = selectedrow.Cells(5).Value.ToString
        If (selectedrow.Cells(6).Value.ToString) <> String.Empty Then
            directoryfromDataBase = selectedrow.Cells(6).Value.ToString
            fileSavePath = directoryfromDataBase
            pcbProfilePhoto.Image = Image.FromFile(selectedrow.Cells(6).Value)
        Else
            pcbProfilePhoto.Image = My.Resources.userDefaultImage
        End If
        txtUsername.Text = selectedrow.Cells(7).Value.ToString
        txtPassword.Text = selectedrow.Cells(8).Value.ToString
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim checkingResult As Boolean
        checkingResult = InputChecking()

        If checkingResult = True Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "SELECT COUNT(*) FROM [User] WHERE [Username] = '" + txtUsername.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                If Convert.ToInt32(cmd.ExecuteScalar) > 1 Then
                    MsgBox("Please enter a different username.", 0, "Duplication with the existing username")
                    txtUsername.Clear()
                    conn.Close()
                    Return
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error when checking the duplication of username")
                conn.Close()
            End Try

            'Update the new user input into table buyer and user (by refering to the login UserID)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "UPDATE [User] SET [Username]=@Username, [Password]=@Password WHERE [User_ID] = '" + userID + "'"
                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                If cmd.ExecuteNonQuery() > 0 Then
                    'MsgBox("The New User Profile Have Been Updated Successfully.")
                End If

                strSql = "UPDATE [Buyer] SET [Full Name]=@FullName, [NRIC]=@NRIC ,[Phone]=@Phone ,[Gmail]=@Gmail ,
                        [Profile Image]=@ProfileImage WHERE [User_ID] = '" + userID + "' and [Buyer_ID] = '" + buyerId + "'"
                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text)
                cmd.Parameters.AddWithValue("@NRIC", txtNRIC.Text)
                cmd.Parameters.AddWithValue("@Phone", txtContactNo.Text)
                cmd.Parameters.AddWithValue("@Gmail", txtGmail.Text)
                If fileSavePath = directoryfromDataBase Then
                    cmd.Parameters.AddWithValue("@Profile_Image", directoryfromDataBase)
                    'the filesavepath have changed due top user selected another image
                Else
                    'MsgBox("Saving image here")
                    cmd.Parameters.AddWithValue("@Profile_Image", fileSavePath)
                    'make a copy about the picture and saved it into the defined directory path
                    File.Copy(SelectedFileName, fileSavePath, True)
                End If
                If cmd.ExecuteNonQuery() > 0 Then
                    'MsgBox("2")
                End If
                MsgBox("The New User Profile Have Been Updated Successfully.")
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
            clear()
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim checkingResult As Boolean
        checkingResult = InputChecking()

        If checkingResult = True Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "DELETE FROM [Buyer] WHERE [Buyer_ID] = '" + buyerId + "'"
                cmd = New OleDbCommand(strSql, conn)
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("The buyer has been deleted from database.")
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error in deleting the buyer data")
                conn.Close()
            End Try

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "DELETE FROM [User] WHERE [User_ID] = '" + userID + "'"
                cmd = New OleDbCommand(strSql, conn)
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("The user has been deleted from database.")
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error in deleting the buyer data")
                conn.Close()
            End Try
        End If


    End Sub
End Class
