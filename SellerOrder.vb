Imports System.Data.OleDb

Public Class frmSellerOrder
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Dim Orderid As String = ""

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'Update the data record of the DataGridView
        'Reinsert the data form database into the DataGridView
        DGVCustomerOrder.Rows.Clear()
        Call DisplayTheCustomerOrder()
    End Sub

    Sub DisplayTheCustomerOrder()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT * FROM [Transaction] INNER JOIN [Service] ON [Transaction].Service_ID = [Service].Service_ID 
                        WHERE [Service].Seller_ID = '" + frmSellerMainMenu.SellerID + "' AND [Order Status] = 0"
            cmd = New OleDbCommand(strSql, conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()
                    DGVCustomerOrder.Rows.Add(False, dr("Transaction_ID").ToString, dr("Full Name").ToString, dr("Matric No").ToString, dr("Phone").ToString,
                        dr("Village").ToString, dr("Gender").ToString, dr("Request_Details").ToString, dr("Quantity").ToString, dr("Amount").ToString,
                        dr("Payment_Method").ToString)
                End While
            Else
                DGVCustomerOrder.Rows.Clear()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "error when displaying data top DGV")
            conn.Close()
        End Try

        lblRowCount.Text = "Incomplete Order : " & DGVCustomerOrder.RowCount
    End Sub

    Private Sub frmSellerOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        DGVCustomerOrder.Rows.Clear()
        Call DisplayTheCustomerOrder()
    End Sub

    Private Sub DGVCustomerOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCustomerOrder.CellContentClick
        'Call DisplayTheCustomerOrder()
        If DGVCustomerOrder.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "False" Then
            'Checked condition'
            MsgBox("Checked")

            'get the transactionId from the same row
            Orderid = DGVCustomerOrder.Rows(e.RowIndex).Cells(1).Value
            MsgBox(Orderid)

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "UPDATE [Transaction] SET [Order Status] = '1', [Complete Order Time] =@Complete_Time WHERE [Transaction_ID] ='" + Orderid + "'"
                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@Complete Order Time", DateTime.Parse(Date.Now))
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("You have complete the customer order!")
                    DGVCustomerOrder.Rows.Clear()
                    Call DisplayTheCustomerOrder()
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error when updating the order status")
                conn.Close()
            End Try
        End If
    End Sub
End Class
