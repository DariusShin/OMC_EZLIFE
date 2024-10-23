Imports System.Data.OleDb

Public Class FlowNewSellerRequest
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        Dim response As String
        response = MsgBox("Are you sure to approve this request?" + vbNewLine + "The seller may access to your application once you have approved it.",
                    MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Confimation on authorise new Seller")
        btnApprove.BackgroundImage = My.Resources.icons8_approval_40
        If response = MsgBoxResult.Yes Then

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "UPDATE [Seller] SET [Request_Status] = '1' WHERE [Seller_ID] = '" + lblStoreSellerID.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("This seller has been authorised.")
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error when updating the seller request status.")
                conn.Close()
            End Try
        Else
            btnApprove.BackgroundImage = My.Resources.icons8_approval_40__1_
        End If
    End Sub

    Private Sub FlowNewSellerRequest_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
    End Sub

    Private Sub btnApprove_MouseEnter(sender As Object, e As EventArgs) Handles btnApprove.MouseEnter
        btnApprove.BackgroundImage = My.Resources.icons8_approval_40
    End Sub

    Private Sub btnApprove_MouseLeave(sender As Object, e As EventArgs) Handles btnApprove.MouseLeave
        btnApprove.BackgroundImage = My.Resources.icons8_approval_40__1_
    End Sub
End Class
