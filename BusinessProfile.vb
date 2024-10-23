Imports System.Data.OleDb
Imports System.IO

Public Class frmBusinessProfile
    'declarating the variable for the connection of database
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim strSql As String

    'declaring the variable for the images file
    Dim saveDirectory As String = "D:\Users\user\Desktop\OMC_Images\"
    Dim SelectedFileName As String = ""
    Dim fileName As String = ""
    Dim fileSavePath As String = ""
    Dim directoryfromDataBase As String = ""

    Sub RetrieveBusinessProfile()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'select all data from table user and table buyer using the Login UserID
            strSql = "Select [Username],[Password] from [User] where [User_ID] = '" + frmUserLogin.User_ID + "'"
            cmd = New OleDbCommand(strSql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader()
            If myreader.HasRows Then
                While myreader.Read()
                    txtUsername.Text = myreader.Item(0).ToString
                    txtPassword.Text = myreader.Item(1).ToString
                End While
            End If

            strSql = "Select * FROM [Seller] WHERE [User_ID] = '" + frmUserLogin.User_ID + "'"
            cmd = New OleDbCommand(strSql, conn)
            myreader = cmd.ExecuteReader()
            If myreader.HasRows Then
                While myreader.Read()
                    txtBusinessName.Text = myreader("Business Name").ToString
                    txtBusinessOwner.Text = myreader("Business Owner").ToString
                    txtBusinessType.Text = myreader("Business Type").ToString
                    txtNRIC.Text = myreader("NRIC").ToString
                    txtContactNo.Text = myreader("Phone").ToString
                    txtGmail.Text = myreader("Gmail").ToString

                    If myreader("Business Logo") IsNot DBNull.Value AndAlso myreader("Business Logo") IsNot String.Empty Then
                        directoryfromDataBase = myreader("Business Logo").ToString
                        fileSavePath = directoryfromDataBase
                        pcbBusinessLogo.Image = Image.FromFile(fileSavePath)
                    Else
                        pcbBusinessLogo.Image = My.Resources.icons8_conference_50
                    End If
                End While
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Sub clear()
        For Each ctrl As Control In {txtUsername, txtBusinessName, txtBusinessType, txtBusinessOwner, txtContactNo, txtNRIC, txtGmail, txtPassword,
            pcbBusinessLogo, txtReEnterPassword, btnReset, btnUpdate}
            ctrl.Enabled = False
        Next ctrl

        For Each txtbox As TextBox In {txtUsername, txtBusinessName, txtBusinessOwner, txtContactNo, txtGmail, txtNRIC, txtPassword, txtReEnterPassword, txtBusinessType}
            txtbox.Clear()
        Next txtbox

        btnEdit.Enabled = True
        lblMatching.Visible = False
        lblReEnterPassword1.Visible = False
        lblReEnterPassword2.Visible = False
        txtReEnterPassword.Visible = False
    End Sub
    Private Sub pcbBusinessLogo_Click(sender As Object, e As EventArgs) Handles pcbBusinessLogo.Click
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
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        For Each ctrl As Control In {txtUsername, txtBusinessName, txtBusinessType, txtBusinessOwner,
            txtContactNo, txtNRIC, txtGmail, txtPassword, pcbBusinessLogo, txtReEnterPassword, btnReset, btnUpdate}
            ctrl.Enabled = True
        Next
        btnEdit.Enabled = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clear()
        RetrieveBusinessProfile()
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

    Private Sub frmBusinessProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        'Refresh the user Profile
        RetrieveBusinessProfile()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        For Each InputField As Control In {txtUsername, txtBusinessName, txtBusinessOwner, txtNRIC, txtContactNo, txtGmail, txtPassword}
            If InputField.Text = String.Empty Then
                MsgBox("Please complete the information before updating")
                Call RetrieveBusinessProfile()
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
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "UPDATE [User] SET [Username]=@Username, [Password]=@Password WHERE [User_ID] = '" + frmUserLogin.User_ID + "'"
            cmd = New OleDbCommand(strSql, conn)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            If cmd.ExecuteNonQuery() > 0 Then
                'MsgBox("Loading.")
            End If

            strSql = "UPDATE [Seller] SET [Business Name]=@BusinessName, [Business Owner]=@BusinessOwner, [Business Type] = @BusinessType, [NRIC]=@NRIC 
                ,[Phone]=@Phone ,[Gmail]=@Gmail, [Business Logo]=@BusinessLogo WHERE [User_ID] = '" + frmUserLogin.User_ID + "'"
            cmd = New OleDbCommand(strSql, conn)
            cmd.Parameters.AddWithValue("@BusinessName", txtBusinessName.Text)
            cmd.Parameters.AddWithValue("@BusinessOwner", txtBusinessOwner.Text)
            cmd.Parameters.AddWithValue("@BusinessType", txtBusinessType.Text)
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
                MsgBox("The New Business Profile Have Been Updated Successfully.")
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
