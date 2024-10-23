Imports System.Data.OleDb
Public Class frmServicePayment

    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Dim rowCounts As Integer
    Dim newTransactionId As String
    Dim ServiceType As String
    Dim ServiceTypeId As String
    Dim originalPrice As Double

    Dim newVisaPage As frmVisaPaymentPage
    Private Sub PanelPayment_Scroll(sender As Object, e As ScrollEventArgs) Handles PanelPayment.Scroll
        'set the scroll value = new vertical scroll value (up/down)
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            PanelPayment.VerticalScroll.Value = e.NewValue
        End If
    End Sub
    Sub clear()
        'resetting all textbox text
        For Each txtbox As TextBox In {txtFullName, txtRequest}
            txtbox.Clear()
        Next txtbox
        txtMatricNo.Clear()
        txtContactNo.Clear()
        'resetting the combo box to its title
        If cboGender.Items(0) <> "Gender" Then
            cboGender.Items.Insert(0, "Gender")
        End If
        cboGender.SelectedItem = cboGender.Items(0)

        If cboVillage.Items(0) <> "Village" Then
            cboVillage.Items.Insert(0, "Village")
        End If
        cboVillage.SelectedItem = cboVillage.Items(0)

        If cboBlock.Items(0) <> "Block" Then
            cboBlock.Items.Insert(0, "Block")
        End If
        cboBlock.SelectedItem = cboBlock.Items(0)

        'resetting the payment method choice
        pcbCOD.BorderStyle = BorderStyle.None
        pcbVisaMaster.BorderStyle = BorderStyle.None

        'resetting the vertical scroll
        PanelPayment.AutoScrollPosition = New Point(Math.Abs(PanelPayment.AutoScrollPosition.X), 0)
        PanelPayment.VerticalScroll.Value = 0

        For Each lbl As Label In {lblFullName, lblContactNo, lblGender, lblMatricNo, lblMethod, lblVillage}
            lbl.Visible = False
        Next lbl

    End Sub
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click
        Select Case sender.name
            'addition of 1 seat
            Case "btnPlus"
                txtQty.Text = Val(txtQty.Text) + 1
                If ServiceType = "Food Order" OrElse ServiceType = "Parcel Collect" OrElse ServiceType = "Car Pool" Then
                    txtPaymentAmount.Text = originalPrice * Val(txtQty.Text)
                End If
            Case "btnMinus"
                'minimum seat is 1, if current is 1, subtraction may not happen
                If Val(txtQty.Text) > 1 Then
                    txtQty.Text = Val(txtQty.Text) - 1
                    If ServiceType = "Food Order" OrElse ServiceType = "Parcel Collect" OrElse ServiceType = "Car Pool" Then
                        txtPaymentAmount.Text = originalPrice * Val(txtQty.Text)
                    End If
                Else 'qty is 1
                    txtPaymentAmount.Text = originalPrice
                End If
        End Select
    End Sub
    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles pcbCOD.Click, pcbVisaMaster.Click
        'check which payment method diagram have user click on it
        Select Case sender.name
            'border will apppear at the picture box that have been clicked, also hide the border of another picture box
            Case "pcbVisaMaster" 'user clicked on the picture box of VisaMAster 
                pcbVisaMaster.BorderStyle = BorderStyle.FixedSingle
                pcbCOD.BorderStyle = BorderStyle.None

                'direct user to the visa card payment page
                newVisaPage.ShowDialog()

            Case "pcbCOD" 'user clicked on the picture box of FPXOnline
                pcbVisaMaster.BorderStyle = BorderStyle.None
                pcbCOD.BorderStyle = BorderStyle.FixedSingle
        End Select
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub ComboBox_Leave(sender As Object, e As EventArgs) Handles cboVillage.Leave, cboBlock.Leave, cboGender.Leave
        'if user didnt select anything for the combo box and leave , reset its title there
        If sender.SelectedItem = "" Then
            Select Case sender.name
                Case "cboGender"
                    cboGender.Items.Insert(0, "Gender")
                    cboGender.SelectedItem = cboGender.Items(0)
                Case "cboVillage"
                    cboVillage.Items.Insert(0, "Village")
                    cboVillage.SelectedItem = cboVillage.Items(0)
                Case "cboBlock"
                    cboBlock.Items.Insert(0, "Block")
                    cboBlock.SelectedItem = cboBlock.Items(0)
            End Select
        End If
    End Sub

    Private Sub ComboBox_DropDown(sender As Object, e As EventArgs) Handles cboVillage.DropDown, cboBlock.DropDown, cboGender.DropDown
        'when combo box is clicked, if the items contain its title, remove it
        If sender.items(0) = "Gender" OrElse sender.items(0) = "Village" OrElse sender.items(0) = "Block" Then
            sender.items.remove(sender.items(0))
            Select Case sender.name
                Case "cboVillage"
                    lblVillage.Visible = False
                Case "cboBlobck"
                    lblVillage.Visible = False
                Case "cboGender"
                    lblGender.Visible = False
            End Select
        End If
    End Sub

    Private Sub pcbClosePayment_Click(sender As Object, e As EventArgs) Handles pcbClosePayment.Click
        frmVisaPaymentPage.ClearVisaCard()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmVisaPaymentPage.ClearVisaCard()
        Me.Hide()
    End Sub

    Private Sub frmServicePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        'select the service type and servicetypeID from tables using the passed value of ServiceID
        newVisaPage = New frmVisaPaymentPage
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT * FROM [Service] WHERE [Service_ID] = '" + lblStoredServiceID.Text + "'"
            cmd = New OleDbCommand(strSql, conn)
            Dim myreader As OleDbDataReader = cmd.ExecuteReader()
            If myreader.HasRows Then
                While myreader.Read()
                    ServiceType = myreader("Service Type").ToString
                End While
            End If
            conn.Close()
            'MsgBox(ServiceType)

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        Select Case ServiceType
            Case "Car Pool"
                txtQty.Enabled = True
            Case "Food Order"
                txtQty.Enabled = True
            Case "Car Rental"
                txtQty.Enabled = False
                btnPlus.Enabled = False
                btnMinus.Enabled = False
                txtQty.Text = "1"
            Case "Parcel Collecting"
                txtQty.Enabled = True
        End Select

        For Each cbobox As ComboBox In {cboGender, cboVillage, cboBlock}
            cbobox.SelectedItem = cbobox.Items(0)
        Next cbobox

        'store the original payment amount/price of the service
        originalPrice = Val(txtPaymentAmount.Text)
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'error checking for all the information input
        For Each InputField As Control In {txtFullName, txtMatricNo, txtContactNo}
            If InputField.Text = String.Empty Then
                Select Case InputField.Name
                    Case "txtFullname"
                        lblFullName.Visible = True
                    Case "txtMatricNo"
                        lblMatricNo.Visible = True
                    Case "txtContactNo"
                        lblContactNo.Visible = True
                End Select
                Return
            End If
        Next
        If cboGender.SelectedItem = "" OrElse cboGender.SelectedItem = "Gender" Then
            lblGender.Visible = True
            Return
        End If
        If cboVillage.SelectedItem = "" OrElse cboVillage.SelectedItem = "Village" Then
            lblVillage.Visible = True
            Return
        End If
        If cboBlock.SelectedItem = "" OrElse cboBlock.SelectedItem = "Block" Then
            lblVillage.Visible = True
            Return
        End If
        If pcbCOD.BorderStyle = BorderStyle.None AndAlso pcbVisaMaster.BorderStyle = BorderStyle.None Then
            lblMethod.Visible = True
            Return
        End If
        'insert into database
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'calculate the row count of transaction table
            strSql = "SELECT COUNT(*) FROM [Transaction]"
            cmd = New OleDbCommand(strSql, conn)
            rowCounts = Convert.ToInt32(cmd.ExecuteScalar)
            If rowCounts >= 10 Then
                newTransactionId = "T0" & (rowCounts + 1).ToString
            Else
                newTransactionId = "T00" & (rowCounts + 1).ToString
            End If
            conn.Close()
            'MsgBox("1.Successfully " & newTransactionId)
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        Dim databaseStockQty As Integer
        Dim buyerPurchasedQty As Integer
        If newTransactionId <> String.Empty Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "INSERT INTO [Transaction] ([Transaction_ID], [Buyer_ID], [Service_ID], [Full Name], [Matric No], [Phone], [Village], [Gender]
                        ,[Request_Details], [Quantity], [Amount], [Payment_Method], [Purchased Time])
                    VALUES (@Transaction_ID, @Buyer_ID, @Service_ID, @FullName, @Matric_No, @Phone, @Village, @Gender,
                        @Request_Details, @Quantity, @Amount, @Payment_Method, @Purchased_Time)"
                cmd = New OleDbCommand(strSql, conn)
                cmd.Parameters.AddWithValue("@Transaction_ID", newTransactionId)
                cmd.Parameters.AddWithValue("@Buyer_ID", frmMainMenu.BuyerId)
                cmd.Parameters.AddWithValue("@Service_ID", lblStoredServiceID.Text)
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text)
                cmd.Parameters.AddWithValue("@Matric_No", txtMatricNo.Text)
                cmd.Parameters.AddWithValue("@Phone", txtContactNo.Text)
                cmd.Parameters.AddWithValue("@Village", (cboVillage.SelectedItem + " " + cboBlock.SelectedItem))
                cmd.Parameters.AddWithValue("@Gender", cboGender.SelectedItem)
                cmd.Parameters.AddWithValue("@Request_Details", txtRequest.Text)
                buyerPurchasedQty = Convert.ToInt32(txtQty.Text)
                cmd.Parameters.AddWithValue("@Quantity", buyerPurchasedQty)
                cmd.Parameters.AddWithValue("@Amount", Convert.ToDouble(txtPaymentAmount.Text))

                If pcbVisaMaster.BorderStyle = BorderStyle.FixedSingle Then
                    cmd.Parameters.AddWithValue("@Payment_Method", "Visa & Master")
                Else
                    cmd.Parameters.AddWithValue("@Payment_Method", "Cash On Delivery")
                End If
                cmd.Parameters.AddWithValue("@Purchased_Time", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"))

                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Your payment is successfully.")
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
        End If

        'if the service is food ordering then, minus the stock qty with buyer's purchased qty
        If ServiceType = "Food Order" Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT * FROM [Food Ordering Service] WHERE [Service_ID] = '" + lblStoredServiceID.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader()
                While myreader.Read()
                    databaseStockQty = Convert.ToInt32(myreader("Stock Qty"))
                End While
                'MsgBox("database quantity now is " & databaseStockQty)
                myreader.Close()

                Try
                    If databaseStockQty > 0 Then
                        databaseStockQty = databaseStockQty - buyerPurchasedQty
                        'MsgBox(databaseStockQty)
                        strSql = "UPDATE [Food Ordering Service] SET [Stock Qty] = @StockQty WHERE [Service_ID] = '" + lblStoredServiceID.Text + "'"
                        cmd = New OleDbCommand(strSql, conn)
                        cmd.Parameters.AddWithValue("@StockQty", databaseStockQty)
                        If cmd.ExecuteNonQuery > 0 Then
                            'MsgBox("The new Stock Quantity is updated successfully.")
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
            Me.Hide()

        ElseIf ServiceType = "Car Pool" Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                strSql = "SELECT * FROM [Car Pooling Service] WHERE [Service_ID] = '" + lblStoredServiceID.Text + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader()
                While myreader.Read()
                    databaseStockQty = Convert.ToInt32(myreader("Seat Capacity"))
                End While
                'MsgBox("database seat now is " & databaseStockQty)
                myreader.Close()

                Try
                    If databaseStockQty > 0 Then
                        databaseStockQty = databaseStockQty - buyerPurchasedQty
                        'MsgBox(databaseStockQty)
                        strSql = "UPDATE [Car Pooling Service] SET [Seat Capacity] = @Seat_Capacity WHERE [Service_ID] = '" + lblStoredServiceID.Text + "'"
                        cmd = New OleDbCommand(strSql, conn)
                        cmd.Parameters.AddWithValue("@Seat_Capacity ", databaseStockQty)
                        If cmd.ExecuteNonQuery > 0 Then
                            'MsgBox("The new Seat Capacity is updated successfully.")
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
            Me.Hide()
        Else
            'MsgBox("Not enter the UPDATE SQL")
            Me.Hide()
        End If
    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles txtFullName.Enter
        Select Case sender.name
            Case "txtFullName"
                lblFullName.Visible = False
            Case "txtcontactNo"
                lblContactNo.Visible = False
            Case "txtMatricNo"
                lblMatricNo.Visible = False
        End Select
    End Sub
End Class