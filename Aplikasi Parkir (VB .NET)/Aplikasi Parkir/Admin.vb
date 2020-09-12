Imports MySql.Data.MySqlClient

Public Class Admin
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showDataParkir()
        GridSettingParkir()

        showDataPendapatan()
        GridSettingPendapatan()

        showDataPendapatanHarian()
        GridSettingPendapatanHarian()

        showDataBiaya()
        GridSettingBiaya()

        showDataPetugas()
        GridSettingPetugas()
    End Sub

    Sub showDataParkir()
        openConnection()
        cmd = New MySqlCommand("select keluar.plat, masuk.tgl_masuk, masuk.jam_masuk, keluar.tgl_keluar, keluar.jam_keluar, 
                                sum(keluar.lama) as lama, sum(keluar.total) total 
                                from keluar join masuk 
                                on keluar.plat = masuk.plat
                                group by plat", conn)
        da = New MySqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "parkir")

        parkir.DataSource = ds
        parkir.DataMember = "parkir"

        cmd.Dispose()
        da.Dispose()
        conn.Close()
    End Sub

    Sub GridSettingParkir()

        parkir.Columns(0).HeaderText = "No. Kendaraan"
        parkir.Columns(1).HeaderText = "Tanggal Masuk"
        parkir.Columns(2).HeaderText = "Jam Masuk"
        parkir.Columns(3).HeaderText = "Tanggal Keluar"
        parkir.Columns(4).HeaderText = "Jam Keluar"
        parkir.Columns(5).HeaderText = "Lama Parkir"
        parkir.Columns(6).HeaderText = "Total Biaya"

        parkir.Columns(0).Width = 150
        parkir.Columns(1).Width = 100
        parkir.Columns(2).Width = 100
        parkir.Columns(3).Width = 100
        parkir.Columns(4).Width = 100
        parkir.Columns(5).Width = 50
        parkir.Columns(6).Width = 65
    End Sub

    Sub showDataPendapatan()
        openConnection()
        cmd = New MySqlCommand("select keluar.tgl_keluar, petugas.nama, sum(keluar.total) 
                                from petugas join keluar 
                                on petugas.id = keluar.id_petugas 
                                group by keluar.tgl_keluar, keluar.id_petugas", conn)
        da = New MySqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "parkir")

        pendapatan.DataSource = ds
        pendapatan.DataMember = "parkir"

        cmd.Dispose()
        da.Dispose()
        conn.Close()
    End Sub

    Sub GridSettingPendapatan()

        pendapatan.Columns(0).HeaderText = "Tanggal"
        pendapatan.Columns(1).HeaderText = "Petugas"
        pendapatan.Columns(2).HeaderText = "Total Pendapatan"

        pendapatan.Columns(0).Width = 250
        pendapatan.Columns(1).Width = 215
        pendapatan.Columns(2).Width = 200
    End Sub

    Sub showDataPendapatanHarian()
        openConnection()
        cmd = New MySqlCommand("select tgl_keluar, sum(total) from keluar 
                                group by tgl_keluar", conn)
        da = New MySqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "parkir")

        pendapatanHarian.DataSource = ds
        pendapatanHarian.DataMember = "parkir"

        cmd.Dispose()
        da.Dispose()
        conn.Close()
    End Sub

    Sub GridSettingPendapatanHarian()

        pendapatanHarian.Columns(0).HeaderText = "Tanggal"
        pendapatanHarian.Columns(1).HeaderText = "Total Pendapatan"

        pendapatanHarian.Columns(0).Width = 350
        pendapatanHarian.Columns(1).Width = 315
    End Sub

    Sub showDataBiaya()
        openConnection()
        cmd = New MySqlCommand("select * from biaya", conn)
        da = New MySqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "parkir")

        biaya.DataSource = ds
        biaya.DataMember = "parkir"

        cmd.Dispose()
        da.Dispose()
        conn.Close()
    End Sub

    Sub GridSettingBiaya()

        biaya.Columns(0).HeaderText = "Jenis"
        biaya.Columns(1).HeaderText = "Biaya"

        biaya.Columns(0).Width = 350
        biaya.Columns(1).Width = 315
    End Sub

    Sub showDataPetugas()
        openConnection()
        cmd = New MySqlCommand("select * from petugas", conn)
        da = New MySqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "parkir")

        petugas.DataSource = ds
        petugas.DataMember = "parkir"

        cmd.Dispose()
        da.Dispose()
        conn.Close()
    End Sub

    Sub GridSettingPetugas()

        petugas.Columns(0).HeaderText = "ID"
        petugas.Columns(1).HeaderText = "Nama"

        petugas.Columns(0).Width = 250
        petugas.Columns(1).Width = 415
    End Sub

    Private Sub tambah1_Click(sender As Object, e As EventArgs) Handles tambah1.Click
        Harga.Show()
    End Sub

    Private Sub tambah2_Click(sender As Object, e As EventArgs) Handles tambah2.Click
        AddPetugas.Show()
    End Sub

    Private Sub simpan2_Click(sender As Object, e As EventArgs) Handles simpan2.Click
        Dim row, Id As Integer
        Dim nama As String
        row = petugas.CurrentRow.Index
        Id = petugas(0, row).Value
        nama = petugas(1, row).Value


        Dim queryUpdateData As String = "UPDATE petugas set nama = '" & nama & "' where id = " & Id & ""

        UpdateData(queryUpdateData)

        showDataPetugas()
    End Sub

    Private Sub simpan1_Click(sender As Object, e As EventArgs) Handles simpan1.Click
        Dim row As Integer
        Dim jenis, harga As String
        row = biaya.CurrentRow.Index
        jenis = biaya(0, row).Value
        harga = biaya(1, row).Value


        Dim queryUpdateData As String = "UPDATE biaya set harga = " & harga & " where jenis = '" & jenis & "'"

        UpdateData(queryUpdateData)

        showDataBiaya()
    End Sub

    Private Sub hapus1_Click(sender As Object, e As EventArgs) Handles hapus1.Click
        Dim deletedata, jenis As String
        Dim row As Integer
        row = biaya.CurrentRow.Index
        jenis = biaya(0, row).Value
        Dim message As String
        message = MsgBox("Anda yakin ingin menghapus data ini ? ", vbYesNo + vbInformation, "warning")
        If message = vbNo Then
            Exit Sub
        End If

        deletedata = "DELETE from biaya where jenis = '" & jenis & "'"

        UpdateData(deletedata)
        showDataBiaya()
    End Sub

    Private Sub hapus2_Click(sender As Object, e As EventArgs) Handles hapus2.Click
        Dim deletedata As String
        Dim id, row As Integer
        row = petugas.CurrentRow.Index
        id = petugas(0, row).Value
        Dim message As String
        message = MsgBox("Anda yakin ingin menghapus data ini ? ", vbYesNo + vbInformation, "warning")
        If message = vbNo Then
            Exit Sub
        End If

        deletedata = "DELETE from petugas where id=" & id & ""

        UpdateData(deletedata)
        showDataPetugas()
    End Sub

End Class