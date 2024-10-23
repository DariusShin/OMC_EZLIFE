Imports System.Data.OleDb

Public Class frmUserLogin
    'initializing the database connection and command
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand

    Dim arrOfImage() As Image = {My.Resources.online_Services, My.Resources.Car_Pooling, My.Resources.Food_Ordering,
        My.Resources.Car_Rental, My.Resources.Parcel_Colllecting, My.Resources.online_Services_2, My.Resources.Car_Pooling_2, My.Resources.Food_Ordering_2,
        My.Resources.Car_Rental_2, My.Resources.Parcel_Collecting_2, My.Resources.online_Services_3}
    Dim intImageIndex As Integer = 0

    Dim intIconCounter As Integer = 0

    Public Shared BuyerPage As New frmMainMenu

    'declare global variables that could use at other form
    Public Shared User_ID As String
    Public Shared userName As String = ""
    Public Shared UserType As String = ""
    Private Sub frmUserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        TimerChangeImage.Enabled = True
        TimerChangeImage.Interval = 5000
        TimerChangeImage.Start()
    End Sub
    Private Sub frmUserLogin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        pcbImage.Image = arrOfImage(intImageIndex)

        Me.WindowState = FormWindowState.Normal
        txtPassword.PasswordChar = ""
        txtUsername.Clear()
        txtUsername.Text = "Username"
        txtUsername.ForeColor = Color.Gray

        txtPassword.Clear()
        txtPassword.Text = "8 to 12 Character"
        txtPassword.ForeColor = Color.Gray
    End Sub
    Private Sub TimerChangeImage_Tick(sender As Object, e As EventArgs) Handles TimerChangeImage.Tick
        intImageIndex += 1
        If intImageIndex <= arrOfImage.Length - 1 Then
            pcbImage.Image = arrOfImage(intImageIndex)
        Else
            intImageIndex = 0
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pcbExit.Click
        Dim response As String
        response = MsgBox("Are you sure to Quit?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Reminder")
        If response = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'get the input username and password when click on login button
        Dim inputUsername As String = txtUsername.Text
        Dim inputPassword As String = txtPassword.Text
        Dim queryUsername As String = ""
        Dim queryPassword As String = ""

        'select command from database to check the username and password
        Try
            'open the connection to the database
            conn.Open()
            'Query to check the username
            strSql = "select * from [User] where Username = '" + inputUsername + "'"
            cmd = New OleDbCommand(strSql, conn)
            'declare a reader variable that may read through the database table
            Dim myReader As OleDbDataReader
            myReader = cmd.ExecuteReader()
            If myReader.HasRows Then
                myReader.Read()
                queryUsername = inputUsername
            Else
                txtUsername.Clear()
                lblInvalidUsername.Visible = True
                PanelUsername.BackColor = Color.Red

                'clear the password textbox
                txtPassword.Clear()
                intIconCounter = 0
                pcbHashPassword.Image = My.Resources.icons8_blind_32
                txtPassword.PasswordChar = "*"
                conn.Close()
                Return
            End If
            'end the connection to the database
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        'get the password for the input username
        If queryUsername = inputUsername Then
            Try
                conn.Open()
                'Query to check the password for the valid username
                strSql = "select [Password] from [User] where [Username] = '" & inputUsername & "' "
                cmd = New OleDbCommand(strSql, conn)
                Dim myReader As OleDbDataReader

                myReader = cmd.ExecuteReader()
                If myReader.HasRows Then
                    While myReader.Read()
                        queryPassword = myReader.Item(0).ToString
                    End While
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
        End If

        'if the input name and password existed in the database
        If queryUsername = inputUsername AndAlso queryPassword = inputPassword Then
            Try
                conn.Open()
                'when the username and pasword are correct
                If inputPassword = queryPassword Then
                    strSql = "Select [User_ID],[User_Type] from [User] where [Username] = '" + inputUsername + "' and Password = '" + inputPassword + "'"
                    cmd = New OleDbCommand(strSql, conn)
                    Dim myreader As OleDbDataReader
                    myreader = cmd.ExecuteReader()
                    If myreader.HasRows Then
                        While myreader.Read()
                            User_ID = myreader.Item(0).ToString
                            UserType = myreader.Item(1).ToString
                            'MsgBox(User_ID & UserType & inputUsername & inputPassword)
                        End While
                    End If
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
        Else
            lblInvalidPassword.Visible = True
            PanelPassword.BackColor = Color.Red
            txtPassword.Clear()
            intIconCounter = 0
            pcbHashPassword.Image = My.Resources.icons8_blind_32
            txtPassword.PasswordChar = "*"
            txtPassword.ForeColor = Color.Gray
            Return
        End If

        Select Case UserType
            Case "Buyer"
                Me.Hide()
                MsgBox("Login As Buyer Successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "EZ LIFE")
                BuyerPage.ShowDialog()
                'Dim LoginSplash As New frmBuyerLoginSplash
                'LoginSplash.ShowDialog()
            Case "Seller"
                'check if the seller has been approved by admin
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                        strSql = "SELECT * FROM [Seller] WHERE [User_ID] = '" + User_ID + "'"
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreaderSeller As OleDbDataReader
                        myreaderSeller = cmd.ExecuteReader
                        If myreaderSeller.HasRows Then
                            While myreaderSeller.Read()
                                If myreaderSeller("Request_Status") = 0 Then
                                    MsgBox("Your Request still haven't approve by the Admin." + vbNewLine + "Please be patient...",
                                            MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Pending Seller Request")
                                    conn.Close()
                                    Return
                                End If
                            End While
                        End If
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, 0, "Error in Checking the seller status")
                    conn.Close()
                End Try

                Me.Hide()
                MsgBox("Login As Seller Successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "EZ LIFE")
                Dim SellerPage As New frmSellerMainMenu
                SellerPage.ShowDialog()
            Case "Admin"
                Me.Hide()
                MsgBox("Login As Admin Successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "EZ LIFE")
                Dim AdminPage As New frmAdminMainMenu
                AdminPage.ShowDialog()
        End Select

    End Sub
    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "Username" Or txtUsername.Text = String.Empty Then
            txtUsername.ForeColor = Color.Gray
            txtUsername.Text = "Username"
        End If
    End Sub
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Me.Hide()
        frmSignUpChoice.Show()
    End Sub

    Private Sub txtPassword_MouseClick(sender As Object, e As EventArgs) Handles txtPassword.MouseClick
        If txtPassword.Text = "8 to 12 Character" Then
            txtPassword.Clear()
            txtPassword.PasswordChar = "*"
        End If

        If lblInvalidPassword.Visible = True Then
            lblInvalidPassword.Visible = False
            PanelPassword.BackColor = Color.Transparent
        End If
        txtPassword.ForeColor = Color.Black
    End Sub
    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = String.Empty Then
            txtPassword.ForeColor = Color.Gray
            txtPassword.Text = "8 to 12 Character"
        End If
    End Sub
    Private Sub pcbHashPassword_Click(sender As Object, e As EventArgs) Handles pcbHashPassword.Click
        If intIconCounter Mod 2 = 0 Then 'Even number is Openned Eye icon
            pcbHashPassword.Image = My.Resources.icons8_eye_32
            txtPassword.PasswordChar = ""
            intIconCounter += 1
        Else 'Odd Number is Hided eye icon
            pcbHashPassword.Image = My.Resources.icons8_blind_32
            txtPassword.PasswordChar = "*"
            intIconCounter += 1
        End If
    End Sub
    Private Sub txtUsername_Click(sender As Object, e As MouseEventArgs) Handles txtUsername.Click
        If txtUsername.Text = "Username" Then
            txtUsername.Clear()
        End If
        If lblInvalidUsername.Visible = True Then
            lblInvalidUsername.Visible = False
            PanelUsername.BackColor = Color.Transparent
        End If
        txtUsername.ForeColor = Color.Black
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If txtUsername.Text = "Username" Then
            txtUsername.Clear()
        End If
        If lblInvalidUsername.Visible = True Then
            lblInvalidUsername.Visible = False
            PanelUsername.BackColor = Color.Transparent
        End If
        txtUsername.ForeColor = Color.Black
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If txtPassword.Text = "8 to 12 Character" Then
            txtPassword.Clear()
            txtPassword.PasswordChar = "*"
        End If

        If lblInvalidPassword.Visible = True Then
            lblInvalidPassword.Visible = False
            PanelPassword.BackColor = Color.Transparent
        End If
        txtPassword.ForeColor = Color.Black
    End Sub
End Class