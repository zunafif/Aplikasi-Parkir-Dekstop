Imports MySql.Data.MySqlClient

Public Class Harga
    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Dim saveData As String
        Dim message As String
        message = MsgBox("Anda yakin menambahkan ini ?", vbYesNo + vbInformation, "Warning")
        If message = vbNo Then
            Exit Sub
        End If

        saveData = "INSERT INTO biaya(jenis, harga)values('" & jenis.Text & "','" & biaya1.Text & "')"

        UpdateData(saveData)
        With Admin
            .biaya.Refresh()
            .showDataBiaya()
        End With
    End Sub
End Class