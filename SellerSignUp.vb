Imports System.Data.OleDb
Imports System.IO

Public Class frmSellerSignUp
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

    'sub procedure to clear the input data
    Sub clear()
        For Each txtbox As TextBox In {txtBusinessName, txtBusinessOwner, txtUsername, txtGmail, txtPassword, txtReEnterPassword}
            txtbox.Clear() 'clear all textbox
        Next txtbox

        If cboServiceType.Items(0) <> "Service Type" Then
            cboServiceType.Items.Insert(0, "Service Type") 'reset combo box text to Service Type
        End If
        'resetting the business logo
        pcbBusinessLogo.Image = My.Resources.icons8_conference_50
        'resetting the combo box to its title
        cboServiceType.SelectedItem = cboServiceType.Items(0)

        mtxtContactNo.Clear()
        txtNRIC.Clear()
        txtReEnterPassword.Visible = False
        lblMatching.Visible = False
        lblReEnterPassword2.Visible = False
        lblReEnterPassword1.Visible = False
        intIconCounter = 0
        pcbHashPassword.Image = My.Resources.icons8_blind_32
        txtPassword.PasswordChar = "*"
        txtReEnterPassword.PasswordChar = "*"
    End Sub
    Private Sub btnBackSignUp_Click(sender As Object, e As EventArgs) Handles btnBackSignUp.Click
        Me.Hide() 'hide seller sign up page
        frmSignUpChoice.Show() ' drect user back to sign up choice pages
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

    Private Sub btnUploadLogo_Click(sender As Object, e As EventArgs) Handles btnUploadLogo.Click
        Using OpenFileDialogLogo As OpenFileDialog = New OpenFileDialog()
            With OpenFileDialogLogo
                .Title = "Select New Business Logo"
                .Filter = "Images File (*.jpg;*.png)|*.jpg;*.png"
            End With
            If OpenFileDialogLogo.ShowDialog() = DialogResult.OK Then
                'if the file is not inside the directory then will create a new directory
                If Not Directory.Exists(saveDirectory) Then
                    Directory.CreateDirectory(saveDirectory)
                End If
                SelectedFileName = OpenFileDialogLogo.FileName
                'get the file name from openfiledialog
                fileName = Path.GetFileName(OpenFileDialogLogo.FileName)
                'combine the save directory and filename as the directory path of the choosed picture
                fileSavePath = Path.Combine(saveDirectory, fileName)
                'display the selected image in the picture box
                pcbBusinessLogo.Image = Image.FromFile(OpenFileDialogLogo.FileName)
            End If
        End Using
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'Error checking for user input
        'Error Checking for the input
        Dim strServicetype As String = ""
        For Each InputField As Control In {txtUsername, txtBusinessName, txtBusinessOwner, txtNRIC, mtxtContactNo, txtGmail, txtPassword}
            If InputField.Text = String.Empty Then
                Select Case InputField.Name
                    Case "txtUsername"
                        lblUsername.Visible = True
                    Case "txtBusinessName"
                        lblBusinessName.Visible = True
                    Case "txtBusinessOwner"
                        lblBusinessOwner.Visible = True
                    Case "txtNRIC"
                        lblNRIC.Visible = True
                        sender.select(0, 0)
                    Case "mtxtContactNo"
                        lblContactNo.Visible = True
                        sender.select(0, 0)
                    Case "txtGmail"
                        lblGmail.Visible = True
                    Case "txtPassword"
                        lblPassword.Visible = True
                End Select
                Return
            End If
        Next
        If cboServiceType.SelectedItem = "" Then
            lblBusinessType.Visible = True
            Return
        End If
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
            If Convert.ToInt32(cmd.ExecuteScalar) > 0 Then 'targetted record exist
                MsgBox("Please enter a different username.", 0, "Duplication with the existing username")
                txtUsername.Clear()
                lblUsername.Visible = True
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
            strServicetype = cboServiceType.SelectedItem
            If strServicetype = "Car Pool" Then
                cmd.Parameters.AddWithValue("@Business_Type", "Car Pool")
            ElseIf strServicetype = "Food Order" Then
                cmd.Parameters.AddWithValue("@Business_Type", "Food Order")
            ElseIf strServicetype = "Car Rental" Then
                cmd.Parameters.AddWithValue("@Business_Type", "Car Rental")
            Else
                MsgBox("Here")
                cmd.Parameters.AddWithValue("@Business_Type", "Parcel Collect")
            End If
            cmd.Parameters.AddWithValue("@NRIC", txtNRIC.Text)
            cmd.Parameters.AddWithValue("@Phone", mtxtContactNo.Text)
            cmd.Parameters.AddWithValue("@Gmail", txtGmail.Text)
            If fileSavePath = "" Then
                cmd.Parameters.AddWithValue("@Business_Logo", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Business_Logo", fileSavePath)
                'make a copy about the picture and saved it into the defined directory path
                File.Copy(SelectedFileName, fileSavePath, True)
            End If

            If cmd.ExecuteNonQuery > 0 Then
                MsgBox("New Sign Up Data Has Been Saved.", MsgBoxStyle.OkOnly, "Sign Up Successful")
            End If
            conn.Close()
            clear()
            'direct user to login page
            MsgBox("Sign Up Successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "New Service Provider")
            Me.Hide() 'hide seller sign up page
            Dim directToLogin As New frmUserLogin
            directToLogin.Show() 'direct user back to login page
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub cboServiceType_Leave(sender As Object, e As EventArgs) Handles cboServiceType.Leave
        If cboServiceType.SelectedItem = "" Then
            cboServiceType.SelectedItem = cboServiceType.Items(0)
        End If
    End Sub

    Private Sub cboServiceType_DropDown(sender As Object, e As EventArgs) Handles cboServiceType.DropDown
        lblBusinessType.Visible = False
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

    Private Sub frmSellerSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
    End Sub
    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter, txtBusinessName.Enter,
        txtGmail.Enter, mtxtContactNo.Enter, txtPassword.Enter, txtNRIC.Enter, txtBusinessOwner.Enter
        Select Case sender.name
            Case "txtUsername"
                lblUsername.Visible = False
            Case "txtBusinessName"
                lblBusinessName.Visible = False
            Case "txtGmail"
                lblGmail.Visible = False
            Case "txtBusinessOwner"
                lblBusinessOwner.Visible = False
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