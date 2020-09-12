Public Class AddPetugas
    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Dim saveData As String
        Dim message As String
        message = MsgBox("Anda yakin menambahkan ini ?", vbYesNo + vbInformation, "Warning")
        If message = vbNo Then
            Exit Sub
        End If

        saveData = "INSERT INTO petugas(id, nama)values('" & id.Text & "','" & nama.Text & "')"

        UpdateData(saveData)
        With Admin
            .petugas.Refresh()
            .showDataPetugas()
        End With
    End Sub
End Class