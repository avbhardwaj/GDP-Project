
Imports MySql.Data.MySqlClient
Public Class editprof

    Private Sub chkpass_chkchange() Handles chkpass.CheckedChanged
        If chkpass.Checked = True Then
            chkpass.Checked = True
            txtpass.ReadOnly = False
            txtconpass.ReadOnly = False
        Else
            chkpass.Checked = False
            txtpass.ReadOnly = True
            txtconpass.ReadOnly = True
        End If
    End Sub

    Private Sub btnapply_mouseenter() Handles btnapply.MouseEnter
        btnapply.ForeColor = Color.White
        btnapply.BackColor = Color.White
        btnapply.FlatAppearance.BorderColor = Color.FromArgb(0, 175, 240)
    End Sub

    Private Sub btnSignin_mouseleave() Handles btnapply.MouseLeave
        btnapply.ForeColor = Color.White
        btnapply.BackColor = Color.FromArgb(0, 175, 240)
        btnapply.FlatAppearance.BorderColor = Color.White
    End Sub

    Private Sub editprof_FormClosing() Handles Me.FormClosing
        tempcon.Close()
    End Sub

    Private Sub editprof_Load() Handles MyBase.Load

       
        tempconopen()



        txtname.Text = My.Settings.fname
        txtemail.Text = My.Settings.email
        txtmob.Text = My.Settings.mobile
        txtusername.Text = My.Settings.username
    End Sub

    Private Sub btnapply_click() Handles btnapply.Click

        Dim cmdread As New MySqlCommand("SELECT * FROM tb_users", tempcon)
        Dim datareader As MySqlDataReader
        Try
            datareader = cmdread.ExecuteReader
            While datareader.Read()
                If datareader(1).ToString = txtusername.Text And Not My.Settings.username = txtusername.Text Then
                    MsgBox("Username already exists.", MsgBoxStyle.Exclamation, "Username Error")
                    datareader.Close()
                    Exit Sub
                End If
                If datareader(3).ToString = txtemail.Text And Not My.Settings.email = txtemail.Text Then
                    MsgBox("Email already exists.", MsgBoxStyle.Exclamation, "Email Error")
                    datareader.Close()
                    Exit Sub
                End If
                If datareader(6).ToString = txtmob.Text And Not My.Settings.mobile = txtmob.Text Then
                    MsgBox("Mobile number already exists.", MsgBoxStyle.Exclamation, "Mobile No. Error")
                    datareader.Close()
                    Exit Sub
                End If
            End While
            datareader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
        Try

            If chkpass.Checked = True Then
                If txtpass.Text = txtconpass.Text And Not txtpass.Text = String.Empty Then
                    Dim updateusr As New MySqlCommand("UPDATE tb_users SET username='" & txtusername.Text & "', email='" & txtemail.Text & "', name='" & txtname.Text & "', mobile='" & txtmob.Text & "', password='" & md5encrypter(txtpass.Text) & "' WHERE username='" & My.Settings.username & "'", tempcon)
                    updateusr.ExecuteNonQuery()
                Else
                    MsgBox("Password didn't match or invalid password.", MsgBoxStyle.Exclamation, "Password Error")
                End If
            Else
                Dim updateusr As New MySqlCommand("UPDATE tb_users SET username='" & txtusername.Text & "', email='" & txtemail.Text & "', name='" & txtname.Text & "', mobile='" & txtmob.Text & "' WHERE username='" & My.Settings.username & "'", tempcon)
                updateusr.ExecuteNonQuery()
            End If
            My.Settings.fname = txtname.Text
            My.Settings.username = txtusername.Text
            My.Settings.email = txtemail.Text
            My.Settings.mobile = txtmob.Text
            My.Settings.Save()
            MsgBox("Profile Saved.", MsgBoxStyle.Information, "Operation Applied")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try



    End Sub
End Class