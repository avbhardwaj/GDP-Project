Imports MySql.Data.MySqlClient
Public Class viewpm
    Dim messages(2000) As String
    Private Sub viewpm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text += " - " & My.Settings.fname
        tempconopen()
        Dim cmdreadmsgs As New MySqlCommand("SELECT * FROM tb_pm WHERE username='" & My.Settings.username & "'", tempcon)
        Dim msgreader As MySqlDataReader

        msgreader = cmdreadmsgs.ExecuteReader
        Dim index As Integer = 0
        While msgreader.Read()
            lstmsgs.Items.Add(msgreader(2).ToString).SubItems.Add(msgreader(3).ToString)
            If msgreader(5).ToString = "0" Then

                lstmsgs.Items.Item(index).Font = New Font(lstmsgs.Font.FontFamily, lstmsgs.Font.Size, FontStyle.Bold)
            End If
            messages(index) = msgreader(4).ToString
            index += 1
        End While
        msgreader.Close()
        tempcon.Close()
    End Sub

    Private Sub lstmsgs_SelectedIndexChanged(sender As Object, e As MouseEventArgs) Handles lstmsgs.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Not lstmsgs.FocusedItem.Index = -1 Then
                Dim update As New MySqlCommand("UPDATE tb_pm SET isread='1' WHERE subject='" & lstmsgs.FocusedItem.SubItems(1).Text & "'", connection)
                update.ExecuteNonQuery()
                lstmsgs.Items.Item(lstmsgs.FocusedItem.Index).Font = New Font(lstmsgs.Font.FontFamily, lstmsgs.Font.Size, FontStyle.Regular)
                Dim reply = MsgBox("To: " & My.Settings.username & vbNewLine & vbNewLine & "From: " & lstmsgs.FocusedItem.Text & vbNewLine & vbNewLine & "Subject: " & lstmsgs.FocusedItem.SubItems(1).Text & vbNewLine & vbNewLine & "Message: " & messages(lstmsgs.FocusedItem.Index) & vbNewLine & vbNewLine & "Do you want to reply?", MsgBoxStyle.YesNo, "Private Message")
                If reply = vbYes Then
                    Dim pmform As New pm_form
                    msgsubject = lstmsgs.FocusedItem.SubItems(1).Text
                    frndusrname = lstmsgs.FocusedItem.Text
                    pmform.ShowDialog()

                End If
            End If
        End If


    End Sub

    Private Sub delmsg_Click(sender As Object, e As EventArgs) Handles delmsg.Click
        If Not lstmsgs.FocusedItem.Index = -1 Then





            Dim deletemsg As New MySqlCommand("DELETE FROM tb_pm WHERE subject='" & lstmsgs.FocusedItem.SubItems(1).Text & "' AND username='" & My.Settings.username & "'", connection)
            deletemsg.ExecuteNonQuery()

            lstmsgs.FocusedItem.Remove()

        End If
    End Sub
End Class