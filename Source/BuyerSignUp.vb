Imports System.Data.OleDb
Imports System.IO
Public Class frmBuyerSignUp
    'declaring the connection of database
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim strSql As String
    'declaring the variable for the images file
    Dim saveDirectory As String = "D:\Users\user\Desktop\OMC_Images\"
    Dim SelectedFileName As String = ""
    Dim fileName As String = ""
    Dim fileSavePath As String = ""

    Dim intIconCounter As Integer

    Sub clear()
        For Each txtbox As TextBox In {txtUsername, txtFullName, txtPassword, txtGmail, txtReEnterPassword}
            txtbox.Clear()
        Next txtbox
        'resetting profile photo to default
        mtxtContactNo.Clear()
        txtNRIC.Clear()
        pcbProfilePhoto.Image = My.Resources.userDefaultImage
        txtReEnterPassword.Visible = False
        intIconCounter = 0
        pcbHashPassword.Image = My.Resources.icons8_blind_32
        txtPassword.PasswordChar = "*"
        txtReEnterPassword.PasswordChar = "*"

        For Each lbl As Label In {lblUsername, lblFullName, lblGmail, lblMatching, lblNRIC,
        lblPassword, lblReEnterPassword1, lblReEnterPassword2}
            lbl.Visible = False
        Next lbl
    End Sub
    Private Sub btnBackSignUp_Click(sender As Object, e As EventArgs) Handles btnBackSignUp.Click
        Me.Hide() 'hide the buyer sign up page
        frmSignUpChoice.Show()
    End Sub
    Private Sub pcbHashPassword_Click(sender As Object, e As EventArgs) Handles pcbHashPassword.Click
        If intIconCounter Mod 2 = 0 Then 'Even number is Openned Eye icon
            pcbHashPassword.Image = My.Resources.icons8_eye_32
            txtPassword.PasswordChar = ""
            txtReEnterPassword.PasswordChar = ""
            intIconCounter += 1
        Else 'Odd Number is Hided eye icon
            pcbHashPassword.Image = My.Resources.icons8_blind_32
            txtPassword.PasswordChar = "*"
            txtReEnterPassword.PasswordChar = "*"
            intIconCounter += 1
        End If
    End Sub

    Private Sub btnUploadProfile_Click(sender As Object, e As EventArgs) Handles btnUploadProfile.Click
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
                pcbProfilePhoto.Image = Image.FromFile(OpenFileDialogProfile.FileName)
            End If
        End Using
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'all text will be resetted
        clear()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'Error Checking for the input
        For Each InputField As Control In {txtUsername, txtFullName, txtNRIC, txtGmail, mtxtContactNo, txtPassword}
            If InputField.Text = String.Empty Then
                Select Case InputField.Name
                    Case "txtUsername"
                        lblUsername.Visible = True
                    Case "txtFullName"
                        lblFullName.Visible = True
                    Case "txtNRIC"
                        lblNRIC.Visible = True
                    Case "txtGmail"
                        lblGmail.Visible = True
                    Case "mtxtContactNo"
                        lblContactNo.Visible = True
                    Case "txtPassword"
                        lblPassword.Visible = True
                End Select
                Return
            End If
        Next
        If txtPassword.Text <> txtReEnterPassword.Text Then
            lblMatching.Visible = True
            lblMatching.Text = "Not Matching"
            Return
        End If

        'select from table to check whether there is duplicate of the username
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT COUNT(*) FROM [User] WHERE [Username] = '" + txtUsername.Text + "'"
            cmd = New OleDbCommand(strSql, conn)
            If Convert.ToInt32(cmd.ExecuteScalar) > 0 Then
                MsgBox("Please enter a different username.", 0, "Duplication with the existing username")
                txtUsername.Clear()
                lblUsername.Visible = True
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
            cmd.Parameters.AddWithValue("@Phone", mtxtContactNo.Text)
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
            clear()
            conn.Close()

            'direct user to login page
            MsgBox("Sign Up Successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "New Service Buyer")
            Me.Hide() 'hide seller sign up page
            Dim directToLogin As New frmUserLogin
            directToLogin.Show() 'direct user back to login page
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

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

    Private Sub frmBuyerSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter, txtFullName.Enter,
            txtGmail.Enter, mtxtContactNo.Enter, txtPassword.Enter, txtNRIC.Enter
        Select Case sender.name
            Case "txtUsername"
                lblUsername.Visible = False
            Case "txtFullName"
                lblFullName.Visible = False
            Case "txtGmail"
                lblGmail.Visible = False
            Case "txtNRIC"
                lblNRIC.Visible = False
                sender.select(0, 0)
            Case "mtxtContactNo"
                lblContactNo.Visible = False
                sender.select(0, 0)
            Case "txtPassword"
                lblPassword.Visible = False
        End Select
    End Sub
End Class
