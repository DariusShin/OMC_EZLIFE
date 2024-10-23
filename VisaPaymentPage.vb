
Imports System.Diagnostics.Eventing.Reader

Public Class frmVisaPaymentPage
    Private Sub pcbClosePayment_Click(sender As Object, e As EventArgs) Handles pcbClosePayment.Click
        Me.Hide()
    End Sub

    Public Sub ClearVisaCard()
        'reset the data display on card
        For Each CardNo As Label In {lblCardNum1, lblCardNum2, lblCardNum3, lblCardNum4}
            CardNo.Text = "0000"
        Next CardNo

        lblCardHolder.Text = "Card Holder"
        lblExpiryMonth.Text = "01"
        lblExpiryYear.Text = "/ 23"

        'reset user input on textbox
        For Each txtbox As TextBox In {txtCardHolder, txtCardNo1, txtCardNo2, txtCardNo3, txtCardNo4, txtCVV}
            txtbox.Clear()
        Next txtbox
        cboExpiryMonth.SelectedItem = cboExpiryMonth.Items(0)
        cboExpiryYear.SelectedItem = cboExpiryYear.Items(0)

        'reset the card type
        rbtVisa.Checked = True
        pcbCardType.Image = My.Resources.visaLogo
    End Sub
    Private Sub Textbox_TextChanged(sender As Object, e As EventArgs) Handles txtCardNo1.TextChanged, txtCardNo2.TextChanged, txtCardNo3.TextChanged, txtCardNo4.TextChanged, txtCardHolder.TextChanged
        Select Case sender.name
            Case "txtCardNo1"
                If sender.text <> "" Then 'if user input is not a space
                    If IsNumeric(sender.text) = True Then 'if user input is number
                        If sender.text.length <= 4 Then 'if the card number is not more than 4, then add into the card display
                            lblCardNum1.Text = sender.text
                        End If
                    End If
                Else
                    lblCardNum1.Text = "0000"
                End If
            Case "txtCardNo2"
                If sender.text <> "" Then 'if user input is not a space
                    If IsNumeric(sender.text) = True Then 'if user input is number
                        If sender.text.length <= 4 Then 'if the card number is not more than 4, then add into the card display
                            lblCardNum2.Text = sender.text
                        End If
                    End If
                Else
                    lblCardNum2.Text = "0000"
                End If
            Case "txtCardNo3"
                If sender.text <> "" Then 'if user input is not a space
                    If IsNumeric(sender.text) = True Then 'if user input is number
                        If sender.text.length <= 4 Then 'if the card number is not more than 4, then add into the card display
                            lblCardNum3.Text = sender.text
                        End If
                    End If
                Else
                    lblCardNum3.Text = "0000"
                End If
            Case "txtCardNo4"
                If sender.text <> "" Then 'if user input is not a space
                    If IsNumeric(sender.text) = True Then 'if user input is number
                        If sender.text.length <= 4 Then 'if the card number is not more than 4, then add into the card display
                            lblCardNum4.Text = sender.text
                        End If
                    End If
                Else
                    lblCardNum4.Text = "0000"
                End If
            Case "txtCardHolder"
                If sender.text <> "" Then 'if user input is not a space
                    If IsNumeric(sender.text) = False Then 'if user input is not number
                        lblCardHolder.Text = UCase(sender.text)
                    End If
                Else
                    lblCardHolder.Text = "CARD HOLDER"
                End If

        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExpiryMonth.SelectedIndexChanged, cboExpiryYear.SelectedIndexChanged
        Select Case sender.name
            Case "cboExpiryMonth"
                lblExpiryMonth.Text = cboExpiryMonth.SelectedItem
            Case "cboExpiryYear"
                Dim expiryYear As String
                expiryYear = cboExpiryYear.SelectedItem
                lblExpiryYear.Text = "/ " & expiryYear.Substring(2)
        End Select
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMaster.CheckedChanged, rbtVisa.CheckedChanged
        If sender.name = "rbtVisa" AndAlso sender.checked = True Then
            pcbCardType.Image = My.Resources.visaLogo
        End If
        If sender.name = "rbtMaster" AndAlso sender.checked = True Then
            pcbCardType.Image = My.Resources.MasterCard_Logo
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call ClearVisaCard() 'reset the component in the form
    End Sub
End Class