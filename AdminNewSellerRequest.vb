Imports System.Data.OleDb

Public Class frmAdminNewSellerRequest
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand

    Sub DisplayingNewSellerRequest()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT * FROM [Seller] WHERE [Request_Status] = 0"
            cmd = New OleDbCommand(strSql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    Dim newSellerRequest As New FlowNewSellerRequest
                    With newSellerRequest
                        .lblStoreSellerID.Text = myreader("Seller_ID").ToString
                        .lblBusinessName.Text = myreader("Business Name").ToString
                        .lblBusinessOwner.Text = myreader("Business Owner").ToString
                        .lblBusinessType.Text = myreader("Business Type").ToString
                        .lblContact.Text = myreader("Phone").ToString
                        If myreader("Business Logo") IsNot DBNull.Value Then
                            .pcbBusinessLogo.Image = Image.FromFile(myreader("Business Logo"))
                        End If

                    End With
                    flpNewSellerRequest.Controls.Add(newSellerRequest)
                End While
            Else
                pcbEmptyService.Visible = True
                flpNewSellerRequest.Controls.Clear()
                flpNewSellerRequest.Controls.Add(pcbEmptyService)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in displaying the Disapproved seller request.")
            conn.Close()
        End Try
    End Sub
    Private Sub frmAdminNewSellerRequest_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        flpNewSellerRequest.Controls.Clear()
        Call DisplayingNewSellerRequest()
    End Sub
End Class
