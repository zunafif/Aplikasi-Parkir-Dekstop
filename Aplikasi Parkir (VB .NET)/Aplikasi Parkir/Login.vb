Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles masuk.Click
        Dim username = user.Text
        Dim password = pass.Text

        If password = "123" And username = "pegawai" Then
            Petugas.Show()
            Visible = False
        ElseIf password = "123" And username = "admin" Then
            Admin.Show()
            Visible = False
        Else
            MsgBox("Username / Password Salah")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles tampil.CheckedChanged
        If tampil.Checked = True Then
            pass.PasswordChar = ""
        Else
            pass.PasswordChar = "*"
        End If

    End Sub
End Class
