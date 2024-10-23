Imports System.Data.OleDb

Public Class frmFeedBack
    'procedure to clear to existed rating from user
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Dim intRatingScore As Integer = 0

    Sub clearRating()
        For Each pcbBox As PictureBox In {pcbStar1, pcbStar2, pcbStar3, pcbStar4, pcbStar5}
            pcbBox.BackgroundImage = My.Resources.icons8_star_32__2_
        Next pcbBox
    End Sub

    Sub clearContent()
        lblInvalidRating.Visible = False
        lblInvalidComment.visible = False
        If lblFeedback.Text = "Feedback :" Then
            txtComment.Text = "This is a Good Application!"
        Else
            txtComment.Text = "This is a Good Service!"
        End If
        intRatingScore = 0

    End Sub
    Private Sub btnSentComment_Click(sender As Object, e As EventArgs) Handles btnSentComment.Click
        'insert into table feedback
        'if no rating has been given
        If intRatingScore = 0 Then
            lblInvalidRating.Visible = True
            Return
        End If

        If txtComment.Text = String.Empty Then
            lblInvalidComment.visible = True
            Return
        End If

        Try
            'Dim rowCount As Integer
            'Dim newID As String
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            If txtReceiver.Text = "Admin" Then 'insert data into application feedback table
                'strSql = "SELECT COUNT(*) FROM [Feedback]"
                'cmd = New OleDbCommand(strSql, conn)
                'rowCount = Convert.ToInt32(cmd.ExecuteScalar)
                'If rowCount >= 10 Then
                'newID = "FB0" + (rowCount + 1).ToString
                'Else
                'newID = "FB00" + (rowCount + 1).ToString
                ' End If

                strSql = "INSERT INTO [Feedback] ([User_ID],[Feedback],[Rating Score]) 
                            VALUES (@User_ID,@Feedback,@Rating_Score)"
                cmd = New OleDbCommand(strSql, conn)
                'cmd.Parameters.AddWithValue("@Feedback_ID", newID)
                cmd.Parameters.AddWithValue("@User_ID", frmUserLogin.User_ID)
                cmd.Parameters.AddWithValue("@Feedback", txtComment.Text)
                cmd.Parameters.AddWithValue("@Rating_Score", intRatingScore)

                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Your Feedback has been sent!", 0, "Feedback sent successfully")
                End If
                conn.Close()
            Else 'insert data into the service comment table
                'strSql = "SELECT COUNT(*) FROM [Comment]"
                'cmd = New OleDbCommand(strSql, conn)
                'rowCount = Convert.ToInt32(cmd.ExecuteScalar)
                'If rowCount >= 10 Then
                'newID = "C0" + (rowCount + 1).ToString
                'Else
                'newID = "C00" + (rowCount + 1).ToString
                'End If

                strSql = "INSERT INTO [Comment] ([Buyer_ID],[Service_ID],[Comment Text],[Rating Score]) 
                            VALUES (@Buyer_ID, @Service_ID, @Comment, @Rating_Score)"
                cmd = New OleDbCommand(strSql, conn)
                'cmd.Parameters.AddWithValue("@comment_ID", newID)
                cmd.Parameters.AddWithValue("@Buyer_ID", frmMainMenu.BuyerId)
                cmd.Parameters.AddWithValue("@Service_ID", lblStoredServiceID.Text)
                cmd.Parameters.AddWithValue("@Comment", txtComment.Text)
                cmd.Parameters.AddWithValue("@Rating_Score", intRatingScore)

                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Your comment has been sent!", 0, "Comment sent successfully")
                End If

                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in saving the data of the Comment/Feedback.")
            conn.Close()
        End Try

        clearRating()
        clearContent()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clearRating()
        clearContent()
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles pcbStar1.Click, pcbStar2.Click, pcbStar3.Click, pcbStar4.Click, pcbStar5.Click
        If lblInvalidRating.Visible = True Then
            lblInvalidRating.Visible = False
        End If
        'sender is the picturebox that triggered this click event
        Select Case sender.name
            Case "pcbStar1"
                intRatingScore = 1
            Case "pcbStar2"
                intRatingScore = 2
            Case "pcbStar3"
                intRatingScore = 3
            Case "pcbStar4"
                intRatingScore = 4
            Case "pcbStar5"
                intRatingScore = 5
        End Select

        RatingStar(intRatingScore)
        'MsgBox("The rating score is " & Val(intRatingScore))
    End Sub

    Private Sub RatingStar(ByVal score As Integer)
        clearRating()
        Dim counter As Integer = 1
        For Each pcbbox As PictureBox In {pcbStar1, pcbStar2, pcbStar3, pcbStar4, pcbStar5}
            If counter <= score Then
                pcbbox.BackgroundImage = My.Resources.icons8_star_32__3_
            Else
                Exit For
            End If
            counter += 1
        Next pcbbox
    End Sub

    Private Sub txtComment_TextChanged(sender As Object, e As EventArgs) Handles txtComment.TextChanged
        If txtComment.Text = String.Empty Then
            lblInvalidComment.Visible = True
        Else
            lblInvalidComment.Visible = False
        End If
    End Sub

    Private Sub frmFeedBack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
    End Sub
End Class
