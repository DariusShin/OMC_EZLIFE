Imports System.Data.OleDb

Public Class frmCommentControl
    Dim conn As New OleDbConnection
    Dim strSql As String
    Dim cmd As OleDbCommand
    Dim commentID As Integer
    Dim FeedbackID As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pcbDeleteComment.Click
        If lblMessageType.Text = "Comment" Then
            commentID = CInt(lblCommentID.Text)
            'delete the comment from table comment
            Dim response As String
            response = MsgBox("Are you sure to delete this comment?" + vbNewLine + "This comment may not be recovered once you have deleted it.",
                   MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirmation on delete")

            'seller proceed to delete this comment record
            If response = MsgBoxResult.Yes Then
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    strSql = "DELETE FROM [Comment] WHERE [Comment_ID] = @commentID"
                    cmd = New OleDbCommand(strSql, conn)
                    cmd.Parameters.AddWithValue("@commentID", commentID)
                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("The comment has been deleted.")
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, 0, "Error when deleting a particular comment")
                    conn.Close()
                End Try
            End If

        Else
            FeedbackID = CInt(lblCommentID.Text)
            'delete the comment from table comment
            Dim response As String
            response = MsgBox("Are you sure to delete this feedback?" + vbNewLine + "This feedback may not be recovered once you have deleted it.",
                   MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirmation on delete")

            'seller proceed to delete this comment record
            If response = MsgBoxResult.Yes Then
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    strSql = "DELETE FROM [Feedback] WHERE [Feedback_ID] = @FeedbackID"
                    cmd = New OleDbCommand(strSql, conn)
                    cmd.Parameters.AddWithValue("@FeedbackID", FeedbackID)
                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("The feedback has been deleted.")
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, 0, "Error when deleting a particular feedback")
                    conn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub frmCommentControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\OMC_EZLIFE_May2023\OMC_EZLIFE_May2023\OMC_EZLife.accdb"
    End Sub
End Class
