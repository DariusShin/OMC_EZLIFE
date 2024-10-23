Imports System.Data.OleDb
Imports System.IO

Public Class frmBuyerProfile
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim strSql As String

    'declaring the variable for the images file
    Dim saveDirectory As String = "D:\Users\user\Desktop\OMC_Images\"
    Dim SelectedFileName As String = ""
    Dim fileName As String = ""
    Dim fileSavePath As String = ""
    Dim directoryfromDataBase As String = ""

    Sub clear()
        For Each ctrl As Control In {txtUsername, txtFullName, txtContactNo, txtNRIC, txtGmail, txtPassword, txtReEnterPassword, pcbProfile, btnReset, btnUpdate}
            ctrl.Enabled = False
        Next

        For Each txtbox As TextBox In {txtUsername, txtFullName, txtContactNo, txtNRIC, txtGmail, txtPassword, txtReEnterPassword}
            txtbox.Clear()
        Next
        btnEdit.Enabled = True
        txtReEnterPassword.Visible = False
        lblMatching.Visible = False
        lblReEnterPassword2.Visible = False
        lblReEnterPassword1.Visible = False
        pcbProfile.Image = My.Resources.userDefaultImage
    End Sub
    Sub RetrieveUserProfile()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'select all data from table user and table buyer using the Login UserID
            strSql = "Select [Username],[Password] from [User] where User_ID = '" + frmUserLogin.User_ID + "'"
            cmd = New OleDbCommand(strSql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader()
            If myreader.HasRows Then
                While myreader.Read()
                    txtUsername.Text = myreader.Item(0).ToString
                    txtPassword.Text = myreader.Item(1).ToString
                End While
            End If

            strSql = "Select [Full Name],[NRIC],[Phone],[Gmail],[Profile Image] from [Buyer] where User_ID = '" + frmUserLogin.User_ID + "' "
            cmd = New OleDbCommand(strSql, conn)
            myreader = cmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    txtFullName.Text = myreader("Full Name").ToString
                    txtNRIC.Text = myreader("NRIC").ToString
                    txtContactNo.Text = myreader("Phone").ToString
                    txtGmail.Text = myreader("Gmail").ToString
                    If myreader("Profile Image") IsNot DBNull.Value AndAlso myreader("Profile Image") IsNot String.Empty Then
                        directoryfromDataBase = myreader("Profile Image").ToString
                        fileSavePath = directoryfromDataBase
                        pcbProfile.Image = Image.FromFile(fileSavePath)
                    Else
                        pcbProfile.Image = My.Resources.userDefaultImage
                    End If
                End While
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pcbProfile.Click
        Using OpenFileDialogProfile As OpenFileDialog = New OpenFileDialog()
            With OpenFileDialogProfile
                .Title = "Select User Profile Photo"
                .Filter = "Images File (*.jpg;*.png)|*.jpg;*.png"
            End With
            If OpenFileDialogProfile.ShowDialog() = DialogResult.OK Then
                'if the file is not inside the directory then will create a new directory
                If Not Directory.Exists(saveDirectory) Then
                    Directory.CreateDirectory(saveDirectory)
                End If
                SelectedFileName = OpenFileDialogProfile.FileName
                'get the file name from openfiledialog
                fileName = Path.GetFileName(OpenFileDialogProfile.FileName)
                'combine the save directory and filename as the directory path of the choosed picture
                fileSavePath = Path.Combine(saveDirectory, fileName)
                'display the selected image in the picture box
                pcbProfile.Image = Image.FromFile(OpenFileDialogProfile.FileName)
            End If
        End Using
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        For Each ctrl As Control In {txtUsername, txtFullName, txtContactNo, txtNRIC, txtGmail, txtPassword, pcbProfile, txtReEnterPassword, btnReset, btnUpdate}
            ctrl.Enabled = True
        Next
        btnEdit.Enabled = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clear()
        'Refresh the user profile
        RetrieveUserProfile()
    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text <> String.Empty Then
            txtReEnterPassword.Visible = True
            lblReEnterPassword2.Visible = True
            lblReEnterPassword1.Visible = True
        Else
            txtReEnterPassword.Visible = False
            lblReEnterPassword2.Visible = False
            lblReEnterPassword1.Visible = False
            lblMatching.Visible = False
        End If
    End Sub

    Private Sub txtReEnterPassword_TextChanged(sender As Object, e As EventArgs) Handles txtReEnterPassword.TextChanged
        If txtReEnterPassword.Text <> String.Empty Then
            lblMatching.Visible = True
            If txtReEnterPassword.Text = txtPassword.Text Then
                lblMatching.Text = "Matching"
                lblMatching.ForeColor = Color.Lime
            Else
                lblMatching.Text = "Not Matching"
                lblMatching.ForeColor = Color.Red
            End If
        Else
            lblMatching.Visible = False
        End If
    End Sub

    Private Sub frmBuyerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        'MsgBox(frmUserLogin.User_ID)
        'Refresh the user Profile
        RetrieveUserProfile()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        For Each InputField As Control In {txtUsername, txtFullName, txtNRIC, txtGmail, txtContactNo, txtPassword}
            If InputField.Text = String.Empty Then
                MsgBox("Please fill up all the information before updating.")
                Call RetrieveUserProfile()
                Return
            End If
        Next
        If txtPassword.Text <> txtReEnterPassword.Text Then
            lblMatching.Visible = True
            lblMatching.Text = "Not Matching"
            Return
        End If
        'Update the new user input into table buyer and username (by refering to the login UserID)
        Try
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
                Else
                    'MsgBox("No duplication in username")
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error when checking the duplication of username")
                conn.Close()
            End Try

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "UPDATE [User] SET [Username]=@Username, [Password]=@Password WHERE [User_ID] = '" + frmUserLogin.User_ID + "'"
            cmd = New OleDbCommand(strSql, conn)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            If cmd.ExecuteNonQuery() > 0 Then
                'MsgBox("The New User Profile Have Been Updated Successfully.")
            End If

            strSql = "UPDATE [Buyer] SET [Full Name]=@FullName, [NRIC]=@NRIC ,[Phone]=@Phone ,[Gmail]=@Gmail ,
                        [Profile Image]=@ProfileImage WHERE [User_ID] = '" + frmUserLogin.User_ID + "'"
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
                MsgBox("The New User Profile Have Been Updated Successfully.")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If txtPassword.Text <> String.Empty Then
            txtReEnterPassword.Visible = True
            lblReEnterPassword2.Visible = True
            lblReEnterPassword1.Visible = True
        Else
            txtReEnterPassword.Visible = False
            lblReEnterPassword2.Visible = False
            lblReEnterPassword1.Visible = False
            lblMatching.Visible = False
        End If
    End Sub
End Class
