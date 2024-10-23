Imports System.Data.OleDb

Public Class FlowOutOrderHistory
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand

    Dim buyerId As String = frmMainMenu.BuyerId
    Dim BusinessName As String = ""
    Dim ServiceName As String = ""
    Dim SellerContact As String = ""
    Dim ServicePrice As String = ""
    Dim SellerGmail As String = ""

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'select the service name and the seller name from table service and seller

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "SELECT * FROM [Seller] WHERE [Seller_ID] = '" + lblStoreSellerID.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreaderSeller As OleDbDataReader
                myreaderSeller = cmd.ExecuteReader()
                If myreaderSeller.HasRows Then
                    While myreaderSeller.Read()
                        BusinessName = myreaderSeller("Business Name").ToString
                        SellerContact = myreaderSeller("Phone").ToString
                        SellerGmail = myreaderSeller("Gmail").ToString
                    End While
                End If
                myreaderSeller.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Select Business Name and phone from table seller wtih sellerid.")
                conn.Close()
            End Try

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "SELECT * FROM [Service] WHERE [Service_ID] = '" + lblStoreServiceID.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreaderService As OleDbDataReader
                myreaderService = cmd.ExecuteReader
                If myreaderService.HasRows Then
                    While myreaderService.Read()
                        ServiceName = myreaderService("Service Name").ToString
                    End While
                End If
                myreaderService.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Select Service Name from table service with serviceId")
                conn.Close()
            End Try

            'select the data from transaction
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT * FROM [Transaction] WHERE [Transaction_ID] = '" + lblStore.Text + "' AND [Buyer_ID] = '" + buyerId + "'"
            cmd = New OleDbCommand(strSql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    Dim ServiceReceipt As New frmBuyerReceipt
                    With ServiceReceipt
                        Dim totalpayment As Double
                        Dim Quantity As String
                        .Name = "Receipt " + lblStore.Text
                        .lblReceiptNo.Text = "R" & (lblStoreServiceID.Text) & "/" & (buyerId) & "/" & (lblStore.Text)
                        .lblServiceSeller.Text = BusinessName
                        .lblServiceName.Text = ServiceName
                        .lblBuyerName.Text = myreader("Full Name").ToString
                        .lblMatricNo.Text = myreader("Matric No").ToString
                        .lblBuyerContact.Text = myreader("Phone").ToString
                        .lblSellerContact.Text = SellerContact
                        totalpayment = Convert.ToDouble(myreader("Amount"))
                        .lbltotalPayment.Text = Format(totalpayment, "0.00") & " MYR"
                        Quantity = myreader("Quantity").ToString
                        .lblQuantity.Text = Quantity
                        ServicePrice = Val(totalpayment) / Val(Quantity)
                        .lblServicePrice.Text = ServicePrice
                        .lblPaymentMethod.Text = myreader("Payment_Method").ToString
                        .lblPurcahsedTime.Text = myreader("Purchased Time").ToString
                        .lblCompleteTime.Text = myreader("Complete Order Time").ToString
                        .lblTotalBold.Text = Format(totalpayment, "0.00") & " MYR"
                    End With
                    ServiceReceipt.ShowDialog()
                End While
                myreader.Close()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnReview_Click(sender As Object, e As EventArgs) Handles btnReview.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT * FROM [Seller] WHERE [Seller_ID] = '" + lblStoreSellerID.Text + "'"
            cmd = New OleDbCommand(strSql, conn)
            Dim myreaderSeller As OleDbDataReader
            myreaderSeller = cmd.ExecuteReader()
            If myreaderSeller.HasRows Then
                While myreaderSeller.Read()
                    SellerGmail = myreaderSeller("Gmail").ToString
                End While
            End If
            myreaderSeller.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Select Gmail from table seller wtih sellerid.")
            conn.Close()
        End Try
        Dim SVID As String
        SVID = lblStoreServiceID.Text
        Dim frmBuyerComment As New frmFeedBack
        With frmBuyerComment
            .lblFeedback.Text = "Comment :"
            .txtReceiver.Text = SellerGmail
            .txtComment.Text = "This is a Good Service!"
            .lblStoredServiceID.Text = SVID
        End With

        Dim BuyerCommentBase As New frmBuyerComment
        With BuyerCommentBase
            .PanelComment.Controls.Clear()
            .PanelComment.Controls.Add(frmBuyerComment)
            frmBuyerComment.Dock = DockStyle.Fill
        End With
        BuyerCommentBase.ShowDialog()
    End Sub
End Class
