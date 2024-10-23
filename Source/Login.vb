Public Class frmLogin
    Dim intIconCounter As Integer = 0
    Friend userName As String = ""
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If UCase(txtUsername.Text) = "SELLER" Then
            Me.Hide()
            userName = txtUsername.Text
            frmSellerMainMenu.Show()
        ElseIf UCase(txtUsername.Text) = "BUYER" Then
            Me.Hide()
            userName = txtUsername.Text
            frmBuyerLoginSplash.ShowDialog()
        Else
            MsgBox("Please enter the correct Username!")
            txtUsername.Clear()
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "Username" Or txtUsername.Text = String.Empty Then
            txtUsername.ForeColor = Color.Gray
            txtUsername.Text = "Username"
        End If
    End Sub
    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        txtUsername.Clear()
        txtUsername.ForeColor = Color.Black
    End Sub
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Me.Hide()
        frmSignUpChoice.Show()
    End Sub

    Private Sub txtPassword_click(sender As Object, e As EventArgs) Handles txtPassword.Click
        If txtPassword.Text = "8 to 12 Character" Then
            txtPassword.Clear()
            txtPassword.PasswordChar = "*"
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
    Private Sub frmLogin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.WindowState = FormWindowState.Normal
        txtPassword.PasswordChar = ""
        txtUsername.Clear()
        txtUsername.Text = "Username"
        txtUsername.ForeColor = Color.Gray

        txtPassword.Clear()
        txtPassword.Text = "8 to 12 Character"
        txtPassword.ForeColor = Color.Gray

    End Sub
End Class