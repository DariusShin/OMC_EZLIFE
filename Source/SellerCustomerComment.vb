Imports System.Data.OleDb
Public Class frmSellerCustomerComment

    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand

    Dim Recordcount As Integer = 0

    Dim buyerID As String = ""
    Dim username As String = ""
    Dim serviceName As String = ""
    Dim comment As String = ""
    Dim rating As String = ""
    Dim commentid As String = ""

    Dim buyerUsernames() As String = {}
    Dim buyerIDs() As String = {}
    Dim service_Names() As String = {}
    Dim Comments() As String = {}
    Dim Ratings() As String = {}
    Dim CommentIDs() As String = {}

    Sub DisplayingCustomerComment()
        buyerID = ""
        username = ""
        serviceName = ""
        comment = ""
        rating = ""
        commentid = ""
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT COUNT(*) FROM [Comment] INNER JOIN [Service] ON [Comment].[Service_ID] = [Service].[Service_ID] WHERE [Service].[Seller_ID] = '" + frmSellerMainMenu.SellerID + "'"
            cmd = New OleDbCommand(strSql, conn)
            Recordcount = Convert.ToInt32(cmd.ExecuteScalar)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in displaying comment record count")
            conn.Close()
        End Try

        If Recordcount > 0 Then
            flpComment.Controls.Clear()
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "SELECT * FROM [Comment] INNER JOIN [Service] ON [Comment].[Service_ID] = [Service].[Service_ID] WHERE [Service].[Seller_ID] = '" + frmSellerMainMenu.SellerID + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader()
                If myreader.HasRows Then
                    While myreader.Read()
                        commentid = commentid + myreader("Comment_ID").ToString + "/"
                        serviceName = serviceName + myreader("Service Name").ToString + "/"
                        comment = comment + myreader("Comment Text").ToString + "/"
                        rating = rating + myreader("Rating Score").ToString + "/"
                        buyerID = buyerID + myreader("Buyer_ID").ToString + "/"
                    End While
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error in the part of retrieving data from comment table")
                conn.Close()
            End Try

            buyerIDs = (buyerID.Trim("/")).Split("/")
            'MsgBox(buyerIDs.Length)
            'select all the buyer's username from table user by the buyerid
            For index = 0 To (buyerIDs.Length - 1)
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    Dim intCount As Integer = 0
                    For Each buyer As String In buyerID
                        strSql = "SELECT * FROM [User] INNER JOIN [Buyer] ON [User].[User_ID] = [Buyer].[User_ID] WHERE [Buyer].[Buyer_ID] ='" + buyerIDs(index) + "'"
                        cmd = New OleDbCommand(strSql, conn)
                        Dim myreaderUser As OleDbDataReader
                        myreaderUser = cmd.ExecuteReader
                        If myreaderUser.HasRows Then
                            While myreaderUser.Read()
                                username = username + myreaderUser("Username").ToString + "/"
                            End While
                        End If
                        intCount += 1
                    Next buyer
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, 0, "Error in the part of retireving the buyer username")
                    conn.Close()
                End Try
            Next index

            buyerUsernames = (username.Trim("/")).Split("/")
            service_Names = (serviceName.Trim("/")).Split("/")
            CommentIDs = (commentid.Trim("/")).Split("/")
            Comments = (comment.Trim("/")).Split("/")
            Ratings = (rating.Trim("/")).Split("/")

            For i = 0 To Recordcount - 1 Step 1
                Dim CommentMessage As New frmCommentControl
                With CommentMessage
                    .Size = New Size(flpComment.Width, 150)
                    .lblCommentID.Text = Convert.ToInt32(CommentIDs(i))
                    .lblUsername.Text = buyerUsernames(i)
                    .lblServiceName.Text = "Service Name : " + service_Names(i)
                    .txtComment.ReadOnly = True
                    .txtComment.Text = Comments(i)
                    .lblMessageType.Text = "Comment"
                    Dim counter As Integer = 1
                    For Each pcbbox As PictureBox In { .pcbStar1, .pcbStar2, .pcbStar3, .pcbStar4, .pcbStar5}
                        If counter <= Val(Ratings(i)) Then
                            pcbbox.BackgroundImage = My.Resources.icons8_star_32__3_
                        Else
                            Exit For
                        End If
                        counter += 1
                    Next pcbbox
                End With
                flpComment.Controls.Add(CommentMessage)
            Next i
        Else
            pcbEmptyService.Visible = True
            flpComment.Controls.Add(pcbEmptyService)
        End If
    End Sub
    Private Sub SellerCustomerComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        'check if the comment record existed
        Call DisplayingCustomerComment()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        flpComment.Controls.Clear()
        Call DisplayingCustomerComment()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim RecordCount As Integer = 0
        Dim DeleteCommandIDs() As String = {}
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT COUNT(*) FROM [Comment] INNER JOIN [Service] ON [Comment].[Service_ID] = [Service].[Service_ID] WHERE [Service].[Seller_ID] = '" + frmSellerMainMenu.SellerID + "'"
            cmd = New OleDbCommand(strSql, conn)
            RecordCount = Convert.ToInt32(cmd.ExecuteScalar)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in displaying comment record count")
            conn.Close()
        End Try

        If RecordCount > 0 Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "SELECT * FROM [Comment] INNER JOIN [Service] ON [Comment].[Service_ID] = [Service].[Service_ID] WHERE [Service].[Seller_ID] = '" + frmSellerMainMenu.SellerID + "'"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader()
                If myreader.HasRows Then
                    While myreader.Read()
                        commentid = commentid + myreader("Comment_ID").ToString + "/"
                    End While
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error in the part of retrieving data from comment table")
                conn.Close()
            End Try

            DeleteCommandIDs = (commentid.Trim("/")).Split("/")
            'delete all the record from table comment
            For Each deleteCommentID As String In DeleteCommandIDs
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    strSql = "DELETE FROM [Comment] WHERE [Comment_ID] = @CommentID"
                    cmd = New OleDbCommand(strSql, conn)
                    cmd.Parameters.AddWithValue("@CommentID", Convert.ToInt32(deleteCommentID))
                    If cmd.ExecuteNonQuery > 0 Then
                        flpComment.Controls.Clear()
                        pcbEmptyService.Visible = True
                        flpComment.Controls.Add(pcbEmptyService)
                        MsgBox("All the Comment has been deleted.")
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, 0, "error when deleting all the comment.")
                    conn.Close()
                End Try
            Next deleteCommentID
        End If
    End Sub
End Class
