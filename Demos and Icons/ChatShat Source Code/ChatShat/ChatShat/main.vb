Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class main

    Dim action_signup As Boolean = False

    Private Sub main_formclosing() Handles MyBase.FormClosing

        connection.Close()
    End Sub
    Private Sub main_Load() Handles MyBase.Load
        openconnection()
        If Not My.Settings.username = String.Empty Then
            user.Text = My.Settings.username
            user.ForeColor = Color.Black
        End If

    End Sub

    Private Sub btnSignin_mouseenter() Handles btnSignin.MouseEnter
        btnSignin.ForeColor = Color.White
        btnSignin.BackColor = Color.DarkSlateBlue
        btnSignin.FlatAppearance.BorderColor = Color.FromArgb(0, 175, 240)
    End Sub

    Private Sub btnSignin_mouseleave() Handles btnSignin.MouseLeave
        btnSignin.ForeColor = Color.DarkSlateBlue
        btnSignin.BackColor = Color.FromArgb(0, 175, 240)
        btnSignin.FlatAppearance.BorderColor = Color.DarkSlateBlue
    End Sub

    Private Sub user_gotfocus() Handles user.GotFocus
        If user.Text = "username" Then
            user.ForeColor = Color.Black
            user.Text = String.Empty
            lblstatus.Visible = False
        End If
    End Sub

    Private Sub user_lostfocus() Handles user.LostFocus
        If user.Text = String.Empty Then
            user.ForeColor = Color.Silver
            user.Text = "username"
        End If
    End Sub

    Private Sub pass_gotfocus() Handles pass.GotFocus
        If pass.Text = "password" Then
            pass.ForeColor = Color.Black
            pass.Text = String.Empty
            pass.PasswordChar = "•"c
            lblstatus.Visible = False
        End If
    End Sub

    Private Sub pass_lostfocus() Handles pass.LostFocus
        If pass.Text = String.Empty Then
            pass.ForeColor = Color.Silver
            pass.Text = "password"
            pass.PasswordChar = CChar(String.Empty)
        End If
    End Sub

    Private Sub email_gotfocus() Handles email.GotFocus
        If email.Text = "email" Then
            email.ForeColor = Color.Black
            email.Text = String.Empty
            lblstatus.Visible = False
        End If
    End Sub

    Private Sub email_lostfocus() Handles email.LostFocus
        If email.Text = String.Empty Then
            email.ForeColor = Color.Silver
            email.Text = "email"
        End If
    End Sub

    Private Sub t1_tick() Handles t1.Tick
        If Not btnSignin.Location.Y > 310 Then
            btnSignin.Location = New Point(btnSignin.Location.X, btnSignin.Location.Y + 7)
        Else
            btnSignin.Text = "Sign Up"

        End If

        If Not email.Location.X = 200 Then
            email.Location = New Point(email.Location.X + 50, email.Location.Y)
        End If
    End Sub

    Private Sub t2_tick() Handles t2.Tick
        If Not btnSignin.Location.Y < 260 Then
            btnSignin.Location = New Point(btnSignin.Location.X, btnSignin.Location.Y - 7)
        Else
            btnSignin.Text = "Sign In"
        End If

        If Not email.Location.X = -300 Then
            email.Location = New Point(email.Location.X - 50, email.Location.Y)
        End If
    End Sub

    Private Sub lblacnt_Click() Handles lbl_acnt.Click
        If lbl_acnt.Text = "Create Account" Then
            t2.Enabled = False
            t1.Enabled = True
            lbl_acnt.Text = "Login"
            lbl_acnt.Location = New Point(lbl_acnt.Location.X + 35, lbl_acnt.Location.Y)
            action_signup = True

        ElseIf lbl_acnt.Text = "Login" Then
            t1.Enabled = False
            t2.Enabled = True
            lbl_acnt.Text = "Create Account"
            lbl_acnt.Location = New Point(lbl_acnt.Location.X - 35, lbl_acnt.Location.Y)
            action_signup = False
            lblstatus.Visible = False
        End If

    End Sub

    Private Sub btnSignin_click() Handles btnSignin.Click

        If user.Text = "username" Or user.Text = String.Empty Then
            lblstatus.Visible = True
            lblstatus.Text = "Invalid username"
            lblstatus.ForeColor = Color.Brown

            Exit Sub
        End If
        If pass.Text = "password" Or pass.Text = String.Empty Then
            lblstatus.Visible = True
            lblstatus.Text = "Invalid password"
            lblstatus.ForeColor = Color.Brown

            Exit Sub
        End If
        ''  Dim insertcommand0 As New MySqlCommand("UPDATE tb_chat SET chat = 'a'", connection)
        ''insertcommand0.ExecuteNonQuery()
        If action_signup = False Then
            Dim usrfound As Boolean = False
            Dim readcommand As New MySqlCommand("SELECT * FROM tb_users WHERE username='" & user.Text & "'", connection)
            Dim datareader As MySqlDataReader

            Try
                datareader = readcommand.ExecuteReader
                While datareader.Read()
                    If datareader(1).ToString = user.Text And datareader(2).ToString = md5encrypter(pass.Text) Then
                        My.Settings.username = datareader(1).ToString
                        My.Settings.email = datareader(3).ToString
                        My.Settings.fname = datareader(4).ToString
                        My.Settings.displaypic = datareader(5).ToString
                        My.Settings.mobile = datareader(6).ToString
                        My.Settings.chatcolor = datareader(7).ToString
                        My.Settings.chatfont = datareader(8).ToString
                        My.Settings.chatfontsize = CInt(datareader(9).ToString)
                        My.Settings.chatfontstyle = datareader(10).ToString
                        My.Settings.Save()
                        usrfound = True
                        Exit While
                    End If
                End While
                datareader.Close()
                If usrfound = True Then
                    Me.Hide()
                    Dim chatwin As New chat_window
                    chatwin.ShowDialog()
                Else
                    lblstatus.Visible = True
                    lblstatus.ForeColor = Color.Brown
                    lblstatus.Text = "Username or password is incorrect"
                End If
            Catch
                lblstatus.Visible = True
                lblstatus.ForeColor = Color.Brown
                lblstatus.Text = "Database error"
            End Try

        End If


        If action_signup = True Then
            If email.Text = "email" Or email.Text = String.Empty Then
                lblstatus.Visible = True
                lblstatus.Text = "Invalid email"
                lblstatus.ForeColor = Color.Brown
                Exit Sub
            End If
            Dim readcommand As New MySqlCommand("SELECT * FROM tb_users", connection)
            Dim datareader As MySqlDataReader
            Try
                datareader = readcommand.ExecuteReader()
                While datareader.Read()

                    If datareader(1).ToString = user.Text Then
                        lblstatus.Visible = True
                        lblstatus.Text = "Username already exists."
                        lblstatus.ForeColor = Color.Brown
                        datareader.Close()
                        Exit Sub
                    End If
                    If datareader(3).ToString = email.Text Then
                        lblstatus.Visible = True
                        lblstatus.Text = "Email already exists."
                        lblstatus.ForeColor = Color.Brown
                        datareader.Close()
                        Exit Sub
                    End If
                End While
                datareader.Close()
            Catch
                lblstatus.Visible = True
                lblstatus.ForeColor = Color.Brown
                lblstatus.Text = "Database error"
            End Try
            If Not IO.File.Exists(Application.StartupPath & "\users.png") Then
                MsgBox("A file named users.png not found. Please reinstall application.", MsgBoxStyle.Critical, "IO Error")
                Exit Sub
            End If
            Dim insertcommand As New MySqlCommand("INSERT INTO tb_users (username, password, email, name, dp, mobile, chatcolor, chatfont, chatfontsize, chatfontstyle) VALUES('" & user.Text & "','" & md5encrypter(pass.Text) & "','" & email.Text & "','" & user.Text & "','" & imgtobytes(Application.StartupPath & "\users.png") & "','+923xx-xxxxxxx', 'FF000000', 'Candara', '18', 'Regular')", connection)
            Try
                insertcommand.ExecuteNonQuery()
                lblstatus.Visible = True
                lblstatus.Text = "Account Created. You can now login."
                lblstatus.ForeColor = Color.DarkGreen
            Catch
                lblstatus.Visible = True
                lblstatus.ForeColor = Color.Brown
                lblstatus.Text = "Database error"
            End Try
        End If
    End Sub

    Private Sub user_textchange() Handles user.TextChanged
        If user.Text.Length > 18 And user.Text.Length < 24 Then
            user.Font = New Font(user.Font.FontFamily, 15)
        ElseIf user.Text.Length > 24 Then
            user.Font = New Font(user.Font.FontFamily, 12)
        ElseIf user.Text.Length < 18 Then
            user.Font = New Font(user.Font.FontFamily, 20)
        End If
    End Sub
    Private Sub pass_textchange() Handles pass.TextChanged
        If pass.Text.Length > 18 And pass.Text.Length < 24 Then
            pass.Font = New Font(pass.Font.FontFamily, 15)
        ElseIf pass.Text.Length > 24 Then
            pass.Font = New Font(pass.Font.FontFamily, 12)
        ElseIf pass.Text.Length < 18 Then
            pass.Font = New Font(pass.Font.FontFamily, 20)
        End If
    End Sub
    Private Sub email_textchange() Handles email.TextChanged
        If email.Text.Length > 18 And email.Text.Length < 24 Then
            email.Font = New Font(email.Font.FontFamily, 15)
        ElseIf email.Text.Length > 24 Then
            email.Font = New Font(email.Font.FontFamily, 12)
        ElseIf email.Text.Length < 18 Then
            email.Font = New Font(email.Font.FontFamily, 20)
        End If
    End Sub

End Class
