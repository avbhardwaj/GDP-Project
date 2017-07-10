Imports MySql.Data.MySqlClient
Imports System.Collections
Public Class chat_window


    Private Sub chat_window_Load() Handles MyBase.Load

        Me.Text = Me.Text & " - " & My.Settings.fname
        Dim mems As System.IO.MemoryStream = New System.IO.MemoryStream(Convert.FromBase64String(My.Settings.displaypic))
        dppic.Image = Drawing.Image.FromStream(mems)
        usr_name.Text = My.Settings.fname
        usr_email.Text = My.Settings.email
        usr_mob.Text = My.Settings.mobile
        readfriends()
        CreateEmotions()
    End Sub

    Private Sub dppic_click() Handles dppic.Click
        Dim ppic As New image_dp
        ppic.ShowDialog()
    End Sub

    Private Sub readfriends()
        Dim readcommand As New MySqlCommand("SELECT * FROM tb_users", connection)
        Dim datareader As MySqlDataReader
        datareader = readcommand.ExecuteReader
        Dim chatfrom As New chat_window
        While datareader.Read()
            If Not datareader(1).ToString = My.Settings.username Then
                lstfrnds.Items.Add(datareader(1).ToString)
            End If

        End While
        datareader.Close()
    End Sub

    Private Sub chat_window_formclosing() Handles MyBase.FormClosing

        main.Show()
    End Sub

    Private Sub lstfrnds_selecteditem() Handles lstfrnds.Click
        If Not lstfrnds.SelectedIndex = -1 Then
            Dim frnds As New frndprof
            frndusrname = lstfrnds.SelectedItem.ToString
            frnds.ShowDialog()
        End If



    End Sub


   

    Private Sub tmchat_Tick() Handles tmchat.Tick
       

        Dim cmdreadchat As New MySqlCommand("SELECT chat FROM tb_chat", connection)
        Dim chatreader As MySqlDataReader
        chatreader = cmdreadchat.ExecuteReader
        While chatreader.Read()
            If Not chatreader(0).ToString = chatboxbackend.Text Then
                chatboxbackend.Text = chatreader(0).ToString

            End If
        End While
        chatreader.Close()

    End Sub


    Private Sub chatbox_textchanged() Handles chatbox.TextChanged

        chatbox.ScrollToCaret()
    End Sub

    Private Sub chatbox_textchanged(sender As Object, e As EventArgs) Handles chatbox.TextChanged
        chatbox.SelectionStart() = chatbox.TextLength
        chatbox.ScrollToCaret()
    End Sub

  
  
    Private Sub edprof_Click() Handles edprof.Click
        Dim profiedit As New editprof

        profiedit.ShowDialog()
    End Sub

   
    Private Sub vpm_Click() Handles vpm.Click
        Dim viewpmform As New viewpm
        viewpmform.ShowDialog()
    End Sub

    Private Sub sendmsj_Click() Handles sendmsj.Click

        chatboxbackend.Text += vbNewLine & vbNewLine & My.Settings.username & ": " & msjbox.Text
        Dim updatechat As New MySqlCommand("UPDATE tb_chat SET chat='" & chatboxbackend.Text & "'", connection)
        updatechat.ExecuteNonQuery()
        'changefontcolor()
        'chatbox.ReadOnly = False
        'AddEmotions()
        'chatbox.ReadOnly = True
    End Sub



    Private Sub chfontcolor_Click() Handles chfontcolor.Click

        If myfont.ShowDialog = vbOK Then
            My.Settings.chatfont = myfont.Font.FontFamily.ToString.Remove(0, 18).Replace("]", "")
            My.Settings.chatfontsize = CInt(myfont.Font.Size)
            If myfont.Font.Bold = True Then
                My.Settings.chatfontstyle = "Bold"
            ElseIf myfont.Font.Italic = True Then
                My.Settings.chatfontstyle = "Italic"
            ElseIf myfont.Font.Underline = True Then
                My.Settings.chatfontstyle = "Underline"
            ElseIf myfont.Font.Strikeout = True Then
                My.Settings.chatfontstyle = "Strikeout"
            End If
        End If

        If mycolor.ShowDialog = vbOK Then
            My.Settings.chatcolor = mycolor.Color.ToArgb.ToString("X")
        End If
        My.Settings.Save()
        Dim updatefont As New MySqlCommand("UPDATE tb_users SET chatcolor='" & My.Settings.chatcolor & "', chatfont='" & My.Settings.chatfont & "', chatfontsize='" & My.Settings.chatfontsize & "', chatfontstyle='" & My.Settings.chatfontstyle & "' WHERE username='" & My.Settings.username & "'", connection)
        updatefont.ExecuteNonQuery()

        changefontcolor()
       

    
    End Sub

    Private Sub changefontcolor()
        tempconopen()
        Dim readusrs As New MySqlCommand("SELECT * FROM tb_users", tempcon)
        Dim usrreader As MySqlDataReader

        usrreader = readusrs.ExecuteReader

        While usrreader.Read()
            Dim ind As Integer = 0
            While Not ind = -1
                ind = chatbox.Find(usrreader(1).ToString, ind + 1, RichTextBoxFinds.WholeWord)
                Dim startindex As Integer
                Dim lengthofline As Integer
                For i As Integer = 0 To chatbox.Lines.Count - 1
                    If ind = chatbox.GetFirstCharIndexFromLine(i) Then
                        startindex = ind
                        lengthofline = chatbox.Lines(i).Length
                        Exit For
                    End If
                Next
                chatbox.Select(startindex, lengthofline)
                chatbox.SelectionColor = Color.FromArgb(Convert.ToInt32(usrreader(7).ToString, 16))
                chatbox.Select(startindex, lengthofline)
                If usrreader(10).ToString = "Bold" Then
                    chatbox.SelectionFont = New Font(usrreader(8).ToString, CInt(usrreader(9).ToString), FontStyle.Bold)
                ElseIf usrreader(10).ToString = "Italic" Then
                    chatbox.SelectionFont = New Font(usrreader(8).ToString, CInt(usrreader(9).ToString), FontStyle.Italic)
                ElseIf usrreader(10).ToString = "Underline" Then
                    chatbox.SelectionFont = New Font(usrreader(8).ToString, CInt(usrreader(9).ToString), FontStyle.Underline)
                ElseIf usrreader(10).ToString = "Strikeout" Then
                    chatbox.SelectionFont = New Font(usrreader(8).ToString, CInt(usrreader(9).ToString), FontStyle.Strikeout)
                Else
                    chatbox.SelectionFont = New Font(usrreader(8).ToString, CInt(usrreader(9).ToString), FontStyle.Regular)
                End If

            End While
        End While
        usrreader.Close()
        tempcon.Close()
    End Sub



    Private emotions As Hashtable
    Private Sub CreateEmotions()
        emotions = New Hashtable(12)
        emotions.Add(":)", My.Resources.smile)
        emotions.Add(":-)", My.Resources.smile)
        emotions.Add(":(", My.Resources.sad)
        emotions.Add(":*", My.Resources.kiss)
        emotions.Add("<3", My.Resources.heart)
        emotions.Add(":<3", My.Resources.lovely)
        emotions.Add("(Y)", My.Resources.thumbsup)
        emotions.Add("(y)", My.Resources.thumbsup)
        emotions.Add(">.<", My.Resources.angry)
        emotions.Add("-_-", My.Resources.annoyed)
        emotions.Add(";-)", My.Resources.eyetwink)
        emotions.Add(";)", My.Resources.eyetwink)
        emotions.Add(":P", My.Resources.lool)
        emotions.Add(":p", My.Resources.lool)
        emotions.Add(":O", My.Resources.oh)
        emotions.Add(":o", My.Resources.oh)
        emotions.Add(":|", My.Resources.suspecious)
        emotions.Add(":D", My.Resources.teeth)
        emotions.Add(":'(", My.Resources.weep)
        emotions.Add(":(con)", My.Resources.confused)
        emotions.Add(":(lov)", My.Resources.lovely)
    End Sub

    Private Sub AddEmotions()
        For Each emote As String In emotions.Keys
            While chatbox.Text.Contains(emote)
                Dim ind As Integer = chatbox.Text.IndexOf(emote)
                chatbox.Select(ind, emote.Length)
                Clipboard.SetImage(DirectCast(emotions(emote), Image))
                chatbox.Paste()
            End While
        Next
    End Sub

    Private Sub chatboxbackend_textchanged() Handles chatboxbackend.TextChanged
        chatbox.Text = chatboxbackend.Text
        changefontcolor()
        chatbox.ReadOnly = False
        AddEmotions()
        chatbox.ReadOnly = True

    End Sub
End Class