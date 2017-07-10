Imports MySql.Data.MySqlClient

Public Class frndprof

    Private Sub frndprof_Load() Handles MyBase.Load
        tempconopen()

        Dim readcommand As New MySqlCommand("SELECT * FROM tb_users WHERE username='" & frndusrname & "'", tempcon)
        Dim datareader As MySqlDataReader
        datareader = readcommand.ExecuteReader

     

        While datareader.Read()
            lblusername1.Text = datareader(1).ToString()
            lblemail1.Text = datareader(3).ToString()
            lblname1.Text = datareader(4).ToString()
            lblmob1.Text = datareader(6).ToString()
            Me.Text = Me.Text & " - " & lblname1.Text
            Dim mems As System.IO.MemoryStream = New System.IO.MemoryStream(Convert.FromBase64String(datareader(5).ToString()))
            frnddp.Image = Drawing.Image.FromStream(mems)
        End While
        datareader.Close()
        tempcon.Close()


    End Sub

    Private Sub pmpic_Click(sender As Object, e As EventArgs) Handles pmpic.Click
        Dim pmform As New pm_form
        pmform.ShowDialog()
    End Sub
End Class