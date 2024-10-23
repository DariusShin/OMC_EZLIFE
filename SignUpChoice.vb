Public Class frmSignUpChoice
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide() 'hide form sign up choice
        frmUserLogin.Show() 'direct user back to login page
    End Sub

    Private Sub scSignUpchoice_Panel1_MouseHover(sender As Object, e As EventArgs) Handles scSignUpchoice.Panel1.MouseHover
        scSignUpchoice.Panel1.BackColor = Color.FromArgb(106, 137, 204)
        lblBuyer.ForeColor = Color.White
    End Sub

    Private Sub scSignUpchoice_Panel1_Click(sender As Object, e As EventArgs) Handles scSignUpchoice.Panel1.Click
        Me.Hide() 'hide form sign up choice
        Dim BuyerSignUp As New frmBuyerSignUp
        BuyerSignUp.Show() 'direct user to buyer sign up page
    End Sub

    Private Sub scSignUpchoice_Panel1_MouseLeave(sender As Object, e As EventArgs) Handles scSignUpchoice.Panel1.MouseLeave
        scSignUpchoice.Panel1.BackColor = Color.White
        lblBuyer.ForeColor = Color.Black
    End Sub

    Private Sub scSignUpchoice_Panel2_Click(sender As Object, e As EventArgs) Handles scSignUpchoice.Panel2.Click
        Me.Hide() 'hide form sign up choice
        Dim SellerSignUp As New frmSellerSignUp
        SellerSignUp.Show() 'direct user to seller sign up page
    End Sub
    Private Sub scSignUpchoice_Panel2_MouseHover(sender As Object, e As EventArgs) Handles scSignUpchoice.Panel2.MouseHover
        scSignUpchoice.Panel2.BackColor = Color.FromArgb(207, 106, 135)
        lblSeller.ForeColor = Color.White
    End Sub

    Private Sub scSignUpchoice_Panel2_MouseLeave(sender As Object, e As EventArgs) Handles scSignUpchoice.Panel2.MouseLeave
        scSignUpchoice.Panel2.BackColor = Color.White
        lblSeller.ForeColor = Color.Black
    End Sub

End Class