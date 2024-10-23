Imports System.Data.OleDb
Imports System.IO

Public Class frmAdminSellerListDashboard
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
        For Each txtbox As TextBox In {txtUsername, txtPassword, txtBusinessName, txtBusinessOwner, txtGmail}
            txtbox.ReadOnly = True
            txtbox.Clear()
        Next
        txtNRIC.ReadOnly = True
        txtNRIC.Clear()
        txtContactNo.ReadOnly = True
        txtContactNo.Clear()
        cboBusinessType.Enabled = False
        btnUploadLogo.Enabled = False
        btnAddNew.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        pcbBusinessLogo.Image = My.Resources.icons8_conference_50
        Call DisplaySellerList()
    End Sub

    Sub DisplaySellerList()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Try
            strSql = "SELECT [Seller].*, [User].[Username], [User].[Password] FROM [Seller] INNER JOIN [User] ON [Seller].[User_ID] = [User].[User_ID] ORDER BY [Seller_ID]"
            cmd = New OleDbCommand(strSql, conn)
            da = New OleDbDataAdapter With {
                .SelectCommand = cmd
                }
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            DGVSeller.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in displaying the seller from database")
            conn.Close()
        End Try
    End Sub

    Function InputChecking() As Boolean
        For Each txtbox As TextBox In {txtUsername, txtPassword, txtBusinessName, txtBusinessOwner, txtGmail}
            If txtbox.Text = String.Empty Then
                MsgBox("Please complete all the input.", 0, "Reminder of Invalid Input ")
                Return False
                Exit Function
            End If
        Next txtbox

        If txtContactNo.Text = String.Empty OrElse txtNRIC.Text = String.Empty Then
            MsgBox("Please complete all the input.", 0, "Reminder of Invalid Input ")
            Return False
            Exit Function
        End If

        If cboBusinessType.SelectedItem = "" Then
            MsgBox("Please complete all the input.", 0, "Reminder of Invalid Input ")
            Return False
            Exit Function
        End If
        Return True
    End Function
    Private Sub frmAdminSellerListDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = My.Settings.OMC_EZLifeConnectionString
        'to check whether the buyer list got record
        Call DisplaySellerList()
    End Sub

    Private Sub btnUploadLogo_Click(sender As Object, e As EventArgs) Handles btnUploadLogo.Click
        Using OpenFileDialogBusinessLogo As OpenFileDialog = New OpenFileDialog()
            With OpenFileDialogBusinessLogo
                .Title = "Select User Profile Photo"
                .Filter = "Images File (*.jpg;*.png)|*.jpg;*.png"
            End With
            If OpenFileDialogBusinessLogo.ShowDialog() = DialogResult.OK Then
                'if the file is not inside the directory then will create a new directory
                If Not Directory.Exists(saveDirectory) Then
                    Directory.CreateDirectory(saveDirectory)
                End If
                SelectedFileName = OpenFileDialogBusinessLogo.FileName
                'get the file name from openfiledialog
                fileName = Path.GetFileName(OpenFileDialogBusinessLogo.FileName)
                'combine the save directory and filename as the directory path of the choosed picture
                fileSavePath = Path.Combine(saveDirectory, fileName)
                'display the selected image in the picture box
                pcbBusinessLogo.Image = Image.FromFile(OpenFileDialogBusinessLogo.FileName)
            End If
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        For Each txtbox As TextBox In {txtUsername, txtPassword, txtBusinessName, txtBusinessOwner, txtGmail}
            txtbox.ReadOnly = False
        Next
        cboBusinessType.Enabled = True
        txtContactNo.ReadOnly = False
        txtNRIC.ReadOnly = False
        btnUploadLogo.Enabled = True
        btnAddNew.Enabled = True
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        clear()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim checkingResult As Boolean
        checkingResult = InputChecking()
        Dim strServiceType As String
        If checkingResult = True Then
            'select from table to check whether there is duplicate of the username
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "SELECT COUNT(*) FROM [User] WHERE [Username] = '" + txtUsername.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                If Convert.ToInt32(cmd.ExecuteScalar) > 0 Then 'targetted record exist
                    MsgBox("Please enter a different username.", 0, "Duplication with the existing username")
                    txtUsername.Clear()
                    conn.Close()
                    Return
                Else
                    'MsgBox("NO duplication in username")
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error when checking the duplication of username")
                conn.Close()
            End Try

            strServiceType = (cboBusinessType.SelectedItem).ToString
            'MsgBox(txtUsername.Text + strServicetype)

            'Insert new seller data into tableDim NewUserID As String
            Dim NewUserID As String
            Dim NewSellerID As String
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
            'Error Checking for the input

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                'Insert the input data into table of User
                strSql = "Insert into [User] ([User_ID], [Username], [Password], [User_Type]) values (@User_ID, @Username, @Password, @User_Type)"
                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@User_ID", NewUserID)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@User_Type", "Seller")

                If cmd.ExecuteNonQuery > 0 Then
                    'MsgBox("New Sign Up Data Has Been Saved in table user.", MsgBoxStyle.OkOnly, "Sign Up Successful")
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
                strSql = "Select count(*) from [Seller]"
                cmd = New OleDbCommand(strSql, conn)
                rowCount = Convert.ToInt32(cmd.ExecuteScalar)
                'get the new user Id by RowCount + 1
                If rowCount >= 10 Then
                    NewSellerID = "S0" + (rowCount + 1).ToString
                Else
                    NewSellerID = "S00" + (rowCount + 1).ToString
                End If
                'MsgBox(NewSellerID)

                'Insert the input data into table of Buyer
                strSql = "INSERT INTO [Seller] ([Seller_ID], [User_ID], [Business Name], [Business Owner], [Business Type], [NRIC], [Phone], [Gmail], [Business Logo]) 
                        VALUES (@Seller_ID, @User_ID, @Business_Name, @Business_Owner, @Business_Type, @NRIC, @Phone, @Gmail, @Business_Logo)"

                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@Seller_ID", NewSellerID)
                cmd.Parameters.AddWithValue("@User_ID", NewUserID)
                cmd.Parameters.AddWithValue("@Business_Name", txtBusinessName.Text)
                cmd.Parameters.AddWithValue("@Business_Owner", txtBusinessOwner.Text)
                cmd.Parameters.AddWithValue("@Business_Type", strServiceType)
                cmd.Parameters.AddWithValue("@NRIC", txtNRIC.Text)
                cmd.Parameters.AddWithValue("@Phone", txtContactNo.Text)
                cmd.Parameters.AddWithValue("@Gmail", txtGmail.Text)
                If fileSavePath = "" Then
                    cmd.Parameters.AddWithValue("@Business_Logo", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@Business_Logo", fileSavePath)
                    'make a copy about the picture and saved it into the defined directory path
                    File.Copy(SelectedFileName, fileSavePath, True)
                End If

                If cmd.ExecuteNonQuery > 0 Then
                    'MsgBox("New Sign Up Data Has Been Saved.", MsgBoxStyle.OkOnly, "Sign Up Successful")
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error when inserting new seller")
                conn.Close()
            End Try

            clear()
        End If
    End Sub

    Dim index As Integer
    Dim selectedrow As DataGridViewRow
    Dim userID As String
    Dim sellerId As String
    Private Sub DGVSeller_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSeller.CellClick
        index = e.RowIndex
        selectedrow = DGVSeller.Rows(index)
        sellerId = selectedrow.Cells(0).Value.ToString
        userID = selectedrow.Cells(1).Value.ToString
        txtBusinessName.Text = selectedrow.Cells(2).Value.ToString
        txtBusinessOwner.Text = selectedrow.Cells(3).Value.ToString
        cboBusinessType.SelectedIndex = cboBusinessType.Items.IndexOf(selectedrow.Cells(4).Value.ToString)

        txtNRIC.Text = selectedrow.Cells(5).Value.ToString
        txtContactNo.Text = selectedrow.Cells(6).Value.ToString
        txtGmail.Text = selectedrow.Cells(7).Value.ToString
        If (selectedrow.Cells(8).Value.ToString) <> String.Empty Then
            directoryfromDataBase = selectedrow.Cells(8).Value.ToString
            fileSavePath = directoryfromDataBase
            pcbBusinessLogo.Image = Image.FromFile(selectedrow.Cells(8).Value)
        Else
            pcbBusinessLogo.Image = My.Resources.userDefaultImage
        End If
        txtUsername.Text = selectedrow.Cells(10).Value.ToString
        txtPassword.Text = selectedrow.Cells(11).Value.ToString
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

            'Update the new user input into table seller and user
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "UPDATE [User] SET [Username]=@Username, [Password]=@Password WHERE [User_ID] = '" + userID + "'"
                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                If cmd.ExecuteNonQuery() > 0 Then
                    'MsgBox("Loading.")
                End If

                strSql = "UPDATE [Seller] SET [Business Name]=@BusinessName, [Business Owner]=@BusinessOwner, [Business Type] = @BusinessType, [NRIC]=@NRIC 
                ,[Phone]=@Phone ,[Gmail]=@Gmail, [Business Logo]=@BusinessLogo WHERE [User_ID] = '" + userID + "' and [Seller_ID] = '" + sellerId + "'"
                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@BusinessName", txtBusinessName.Text)
                cmd.Parameters.AddWithValue("@BusinessOwner", txtBusinessOwner.Text)
                cmd.Parameters.AddWithValue("@BusinessType", cboBusinessType.SelectedItem)
                cmd.Parameters.AddWithValue("@NRIC", txtNRIC.Text)
                cmd.Parameters.AddWithValue("@Phone", txtContactNo.Text)
                cmd.Parameters.AddWithValue("@Gmail", txtGmail.Text)

                'if the image directory is still the same, which means it is the same images files
                If fileSavePath = directoryfromDataBase Then
                    cmd.Parameters.AddWithValue("@BusinessLogo", directoryfromDataBase)
                    'user choosed a new picture so the directory is different from databse
                Else
                    cmd.Parameters.AddWithValue("@BusinessLogo", fileSavePath)
                    File.Copy(SelectedFileName, fileSavePath, True)
                End If
                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Done")
                End If
                MsgBox("The New Business Profile Have Been Updated Successfully.")
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
                strSql = "DELETE FROM [Seller] WHERE [Seller_ID] = '" + sellerId + "'"
                cmd = New OleDbCommand(strSql, conn)
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("The seller has been deleted from database.")
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
