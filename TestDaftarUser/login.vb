Imports MySql.Data.MySqlClient
Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Me.Hide()
        daftar.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (unameTBX.Text = "") Then
            MsgBox("Please enter Username")
            unameTBX.Focus()
        End If
        If (PasswdTBX.Text = "") Then
            MsgBox("Please enter Password")
            PasswdTBX.Focus()
        End If

        Conn.Open()
        Dim query As String = "select role from userlogin where username=@d1 and password=@d2"
        cmd = New MySqlCommand(query, Conn)
        cmd.Parameters.AddWithValue("@d1", unameTBX.Text)
        cmd.Parameters.AddWithValue("@d2", PasswdTBX.Text)
        rdr = cmd.ExecuteReader()
        If (rdr.Read()) Then
            If unameTBX.Text = "admin" Then
                DashboardAdmin.lbUsertype.Text = rdr.GetValue(0)
                DashboardAdmin.lbUsername.Text = unameTBX.Text
                DashboardAdmin.lbDate.Text = Now

                DashboardAdmin.Show()
                Me.Hide()

            Else
                DashboardUser.lbUsertype.Text = rdr.GetValue(0)
                DashboardUser.lbUsername.Text = unameTBX.Text
                DashboardUser.lbDate.Text = Now

                DashboardUser.Show()
                Me.Hide()
            End If



        Else
            MsgBox("Please enter the valid username and password,", MsgBoxStyle.Critical, "Login Denied")
            unameTBX.Text = ""
            PasswdTBX.Text = ""
            unameTBX.Focus()

            Conn.Close()
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
    End Sub
End Class