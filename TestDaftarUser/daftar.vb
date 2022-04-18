Imports MySql.Data.MySqlClient
Public Class daftar

    Private Sub daftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim role As String = "User"
        If usernameTBX.Text = "" Or emailTBX.Text = "" Or PasswordTBX.Text = "" Or namaTBX.Text = "" Or tlpTBX.Text = "" Then
            MsgBox("Data Yang Anda Input Belum Lengkap")
        Else
            Conn.Open()
            Dim inputdata As String
            inputdata = "insert into userlogin values('""','" & namaTBX.Text & "','" & emailTBX.Text & "','" & tlpTBX.Text & "','" & usernameTBX.Text & "', '" & PasswordTBX.Text & "','" & role & "')"
            cmd = New MySqlCommand(inputdata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Pendaftaran Akun Berhasil")
            Conn.Close()
            'Updatedata()
            clear()

            Me.Close()
            login.Show()
        End If
    End Sub

    Sub clear()
        namaTBX.Clear()
        emailTBX.Clear()
        tlpTBX.Clear()
        usernameTBX.Clear()
        namaTBX.Clear()
    End Sub

End Class
