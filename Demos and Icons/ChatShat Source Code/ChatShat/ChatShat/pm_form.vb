Imports MySql.Data.MySqlClient
Public Class pm_form

    Private Sub sendbtn_Click() Handles sendbtn.Click
        If txtsub.Text = String.Empty Then
            MsgBox("Please write a valid subject.", MsgBoxStyle.Exclamation, "Invalid Subject")
            Exit Sub
        End If
        If txtmsg.Text = String.Empty Then
            MsgBox("Please write a valid message", MsgBoxStyle.Exclamation, "Invalid Messsage")
            Exit Sub
        End If

        Dim sendcommand As New MySqlCommand("INSERT INTO tb_pm (username, fromuser, subject, message, isread) VALUES('" & frndusrname & "', '" & My.Settings.username & "', '" & txtsub.Text & "', '" & txtmsg.Text & "', '0')", connection)
        
        Try
            sendcommand.ExecuteNonQuery()
            sendbtn.Image = My.Resources.tick
            sendbtn.Enabled = False

        Catch ex As Exception
            sendbtn.Image = My.Resources.rsz_deletered
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
    End Sub

    Private Sub pm_form_Load() Handles MyBase.Load
        If Not msgsubject = String.Empty Then
            txtsub.Text = "Re: " & msgsubject
            msgsubject = String.Empty
        End If
        Me.Text += frndusrname
    End Sub
End Class