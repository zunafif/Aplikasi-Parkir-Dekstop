Imports MySql.Data.MySqlClient

Module Module1
    Public conn As MySqlConnection
    Sub openConnection()
        Dim server As String = "127.0.0.1"
        Dim userID As String = "root"
        Dim password As String = ""
        Dim database As String = "parkir"
        Try
            Dim query As String = "Server=" & server & "; user id=" & userID & ";password=" & password & "; database=" & database & ";Convert Zero Datetime=True"

            conn = New MySqlConnection(query)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal" + ex.ToString)
        End Try
    End Sub

    Sub UpdateData(ByVal sql As String)
        Dim objCMD As New MySqlCommand
        Try
            openConnection()
            objCMD.Connection = conn
            objCMD.CommandType = CommandType.Text
            objCMD.CommandText = sql
            objCMD.ExecuteNonQuery()
            objCMD.Dispose()
            MsgBox("Data Berhasil Diperbarui", vbInformation)
        Catch ex As Exception
            MsgBox("Tidak dapat memperbarui data " & ex.Message)
        End Try
    End Sub
End Module
