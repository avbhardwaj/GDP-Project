Imports MySql.Data.MySqlClient
Public Class image_dp

    Private Sub image_dp_Load() Handles MyBase.Load
        Dim mems As System.IO.MemoryStream = New System.IO.MemoryStream(Convert.FromBase64String(My.Settings.displaypic))
        pp.Image = Drawing.Image.FromStream(mems)
    End Sub


    Private Sub chnagedp_Click() Handles chnagedp.Click
        If imgchoose.ShowDialog = vbOK Then
            Try
                My.Settings.displaypic = imgtobytes(imgchoose.FileName)
                My.Settings.Save()
            

                Dim updatepic As New MySqlCommand("UPDATE tb_users SET dp='" & My.Settings.displaypic & "' WHERE username='" & My.Settings.username & "'", connection)
                updatepic.ExecuteNonQuery()
                MsgBox("Profile picture updated. Settings will take effect after next login.", MsgBoxStyle.Information, "Operation Successful")
            Catch ex As Exception
                If ex.Message.Contains("Packets larger") Then
                    MsgBox("Piture dimensions are too large to store in database. Please use picture of lower dimensions like 640x480.", MsgBoxStyle.Critical, "Invalid Picture Dimensions")
                Else
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Data Error")
                End If

            End Try

        End If

    End Sub
End Class