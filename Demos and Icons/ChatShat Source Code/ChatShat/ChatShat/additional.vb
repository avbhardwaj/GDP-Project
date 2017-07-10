Imports System.Security.Cryptography
Imports System.IO
Imports MySql.Data.MySqlClient

Module additional
    Public frndusrname As String
    Public connection As New MySqlConnection
    Public tempcon As New MySqlConnection
    Public msgsubject As String = String.Empty
    Sub tempconopen()
        tempcon.ConnectionString = "server=localhost; user id=root; password=; database=db_chatshat"
        Try
            tempcon.Open()
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & "CheckBox your database connections.", MsgBoxStyle.Critical, "Database Unreachable")
            Application.Exit()
        End Try
    End Sub

    Sub openconnection()
        connection.ConnectionString = "server=localhost; user id=root; password=; database=db_chatshat"
        Try
            connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & "CheckBox your database connections." & vbNewLine & "App is closing.", MsgBoxStyle.Critical, "Database Unreachable")
            Application.Exit()
        End Try

    End Sub

    Function md5encrypter(ByVal strPass As String) As String
        'Credit goes to dreamincode.net

        Dim hasher As New MD5CryptoServiceProvider
        Dim passbytes As Byte() = New Byte(strPass.Length + 3) {}
        Dim hashBytes As Byte()

        For i As Integer = 0 To strPass.Length - 1
            passbytes(i) = CByte(Asc(strPass(i)))
        Next
        passbytes(strPass.Length) = CByte(90)
        passbytes(strPass.Length + 1) = CByte(85)
        passbytes(strPass.Length + 2) = CByte(66)
        passbytes(strPass.Length + 3) = CByte(73)

        hashBytes = hasher.ComputeHash(passbytes)

        Dim newhashBytes As Byte() = New Byte(hashBytes.Length + 3) {}

        For j As Integer = 0 To hashBytes.Length - 1
            newhashBytes(j) = hashBytes(j)
        Next
        newhashBytes(hashBytes.Length) = CByte(90)
        newhashBytes(hashBytes.Length + 1) = CByte(85)
        newhashBytes(hashBytes.Length + 2) = CByte(66)
        newhashBytes(hashBytes.Length + 3) = CByte(73)

        strPass = Convert.ToBase64String(newhashBytes)
        Return strPass
    End Function

    Function imgtobytes(ByVal imgPath As String) As String
        Try
            Dim dp_image As Image = Image.FromFile(imgPath)
            Dim mems As MemoryStream = New MemoryStream()
            dp_image.Save(mems, System.Drawing.Imaging.ImageFormat.Png)
            Dim imgbytes As Byte() = mems.ToArray()

            Dim strImg As String = Convert.ToBase64String(imgbytes)

            Return strImg


        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & "Failed to convert image to bytes.", MsgBoxStyle.Critical, "Error Occurred")
        End Try

    End Function

    
End Module
