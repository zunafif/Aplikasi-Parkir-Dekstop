<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.parkir = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.pendapatanHarian = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pendapatan = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.hapus1 = New System.Windows.Forms.Button()
        Me.simpan1 = New System.Windows.Forms.Button()
        Me.tambah1 = New System.Windows.Forms.Button()
        Me.biaya = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.tambah2 = New System.Windows.Forms.Button()
        Me.simpan2 = New System.Windows.Forms.Button()
        Me.hapus2 = New System.Windows.Forms.Button()
        Me.petugas = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.parkir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.pendapatanHarian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pendapatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.biaya, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.petugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 42)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 396)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.parkir)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 370)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Parkir"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'parkir
        '
        Me.parkir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.parkir.Location = New System.Drawing.Point(32, 46)
        Me.parkir.Name = "parkir"
        Me.parkir.Size = New System.Drawing.Size(700, 250)
        Me.parkir.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.pendapatanHarian)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.pendapatan)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 370)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pendapatan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'pendapatanHarian
        '
        Me.pendapatanHarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pendapatanHarian.Location = New System.Drawing.Point(34, 217)
        Me.pendapatanHarian.Name = "pendapatanHarian"
        Me.pendapatanHarian.Size = New System.Drawing.Size(700, 107)
        Me.pendapatanHarian.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PENDAPATAN HARIAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PENDAPATAN HARIAN PETUGAS"
        '
        'pendapatan
        '
        Me.pendapatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pendapatan.Location = New System.Drawing.Point(34, 48)
        Me.pendapatan.Name = "pendapatan"
        Me.pendapatan.Size = New System.Drawing.Size(700, 109)
        Me.pendapatan.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.hapus1)
        Me.TabPage3.Controls.Add(Me.simpan1)
        Me.TabPage3.Controls.Add(Me.tambah1)
        Me.TabPage3.Controls.Add(Me.biaya)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(768, 370)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Biaya"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'hapus1
        '
        Me.hapus1.Location = New System.Drawing.Point(652, 328)
        Me.hapus1.Name = "hapus1"
        Me.hapus1.Size = New System.Drawing.Size(75, 23)
        Me.hapus1.TabIndex = 3
        Me.hapus1.Text = "Hapus"
        Me.hapus1.UseVisualStyleBackColor = True
        '
        'simpan1
        '
        Me.simpan1.Location = New System.Drawing.Point(571, 328)
        Me.simpan1.Name = "simpan1"
        Me.simpan1.Size = New System.Drawing.Size(75, 23)
        Me.simpan1.TabIndex = 2
        Me.simpan1.Text = "Simpan"
        Me.simpan1.UseVisualStyleBackColor = True
        '
        'tambah1
        '
        Me.tambah1.Location = New System.Drawing.Point(490, 328)
        Me.tambah1.Name = "tambah1"
        Me.tambah1.Size = New System.Drawing.Size(75, 23)
        Me.tambah1.TabIndex = 1
        Me.tambah1.Text = "Tambah"
        Me.tambah1.UseVisualStyleBackColor = True
        '
        'biaya
        '
        Me.biaya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.biaya.Location = New System.Drawing.Point(32, 46)
        Me.biaya.Name = "biaya"
        Me.biaya.Size = New System.Drawing.Size(700, 250)
        Me.biaya.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.tambah2)
        Me.TabPage4.Controls.Add(Me.simpan2)
        Me.TabPage4.Controls.Add(Me.hapus2)
        Me.TabPage4.Controls.Add(Me.petugas)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(768, 370)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Petugas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'tambah2
        '
        Me.tambah2.Location = New System.Drawing.Point(488, 327)
        Me.tambah2.Name = "tambah2"
        Me.tambah2.Size = New System.Drawing.Size(75, 23)
        Me.tambah2.TabIndex = 3
        Me.tambah2.Text = "Tambah"
        Me.tambah2.UseVisualStyleBackColor = True
        '
        'simpan2
        '
        Me.simpan2.Location = New System.Drawing.Point(569, 327)
        Me.simpan2.Name = "simpan2"
        Me.simpan2.Size = New System.Drawing.Size(75, 23)
        Me.simpan2.TabIndex = 2
        Me.simpan2.Text = "Simpan"
        Me.simpan2.UseVisualStyleBackColor = True
        '
        'hapus2
        '
        Me.hapus2.Location = New System.Drawing.Point(650, 327)
        Me.hapus2.Name = "hapus2"
        Me.hapus2.Size = New System.Drawing.Size(75, 23)
        Me.hapus2.TabIndex = 1
        Me.hapus2.Text = "Hapus"
        Me.hapus2.UseVisualStyleBackColor = True
        '
        'petugas
        '
        Me.petugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.petugas.Location = New System.Drawing.Point(32, 46)
        Me.petugas.Name = "petugas"
        Me.petugas.Size = New System.Drawing.Size(700, 250)
        Me.petugas.TabIndex = 0
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.parkir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pendapatanHarian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pendapatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.biaya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.petugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents parkir As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents pendapatan As DataGridView
    Friend WithEvents hapus1 As Button
    Friend WithEvents simpan1 As Button
    Friend WithEvents tambah1 As Button
    Friend WithEvents biaya As DataGridView
    Friend WithEvents tambah2 As Button
    Friend WithEvents simpan2 As Button
    Friend WithEvents hapus2 As Button
    Friend WithEvents petugas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents pendapatanHarian As DataGridView
    Friend WithEvents Label2 As Label
End Class
