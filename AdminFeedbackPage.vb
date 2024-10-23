Imports System.Data.OleDb

Public Class frmAdminFeedbackPage
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand

    Dim Recordcount As Integer = 0
    Dim rating As Integer = 0
    Dim userType As String = ""
    Dim FeedbackID As String = ""
    Dim DeleteFeedbackIDs() As String = {}
    Sub DisplayingUserFeedback()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            strSql = "SELECT * FROM [Feedback] INNER JOIN [User] ON [Feedback].[User_ID] = [User].[User_ID]"
            cmd = New OleDbCommand(strSql, conn)
            Dim myreaderFeedback As OleDbDataReader
            myreaderFeedback = cmd.ExecuteReader
            If myreaderFeedback.HasRows Then
                While myreaderFeedback.Read()
                    Dim userFeedback As New frmCommentControl
                    With userFeedback
                        .Name = "Feedback"
                        .Size = New Size(flpFeedback.Width, 150)
                        .lblCommentID.Text = myreaderFeedback("Feedback_ID").ToString
                        .lblMessageType.Text = "Feedback"
                        .lblUsername.Text = myreaderFeedback("Username").ToString
                        .txtComment.Text = myreaderFeedback("Feedback").ToString
                        rating = Convert.ToInt32(myreaderFeedback("Rating Score"))
                        .txtComment.ReadOnly = True
                        Dim counter As Integer = 1
                        For Each pcbbox As PictureBox In { .pcbStar1, .pcbStar2, .pcbStar3, .pcbStar4, .pcbStar5}
                            If counter <= rating Then
                                pcbbox.BackgroundImage = My.Resources.icons8_star_32__3_
                            Else
                                Exit For
                            End If
                            counter += 1
                        Next pcbbox
                        userType = myreaderFeedback("User_Type")
                        .lblServiceName.Text = "User Type : " & userType
                        If userType = "Buyer" Then
                            .BackColor = Color.FromArgb(84, 160, 255)
                        Else
                            .BackColor = Color.FromArgb(207, 106, 135)
                        End If
                    End With

                    flpFeedback.Controls.Add(userFeedback)
                End While
            Else
                flpFeedback.Controls.Clear()
                pcbEmptyService.Visible = True
                flpFeedback.Controls.Add(pcbEmptyService)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in displaying the feedback from user")
        End Try
    End Sub
    Private Sub frmAdminFeedbackPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
        'check if the comment record existed
        Call DisplayingUserFeedback()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        flpFeedback.Controls.Clear()
        Call DisplayingUserFeedback()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'check rowcount of the feedback table
            strSql = "SELECT COUNT(*) FROM [Feedback] INNER JOIN [User] ON [Feedback].[User_ID] = [User].[User_ID]"
            cmd = New OleDbCommand(strSql, conn)
            Recordcount = Convert.ToInt32(cmd.ExecuteScalar)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "Error in counting the feedback table row")
        End Try

        If Recordcount > 0 Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                strSql = "SELECT * FROM [Feedback] INNER JOIN [User] ON [Feedback].[User_ID] = [User].[User_ID]"
                cmd = New OleDbCommand(strSql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader
                If myreader.HasRows Then
                    While myreader.Read()
                        FeedbackID = FeedbackID + myreader("Feedback_ID").ToString + "/"
                    End While
                End If
            Catch ex As Exception
                MsgBox(ex.Message, 0, "Error when selecting all feedback id")
            End Try

            'split all the Feedback_ID into a list
            DeleteFeedbackIDs = (FeedbackID.Trim("/")).Split("/")
            For Each deleteFeedback As String In DeleteFeedbackIDs
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    strSql = "DELETE FROM [Feedback] WHERE [Feedback_ID] = @FeedbackID"
                    cmd = New OleDbCommand(strSql, conn)
                    cmd.Parameters.AddWithValue("@FeedbackID", Convert.ToInt32(deleteFeedback))
                    If cmd.ExecuteNonQuery > 0 Then
                        flpFeedback.Controls.Clear()
                        pcbEmptyService.Visible = True
                        flpFeedback.Controls.Add(pcbEmptyService)
                        MsgBox("All the feedback from users has been deleted.")
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, 0, "Error when deleting all the feedback")
                    conn.Close()
                End Try
            Next deleteFeedback
        End If
    End Sub
End Class
