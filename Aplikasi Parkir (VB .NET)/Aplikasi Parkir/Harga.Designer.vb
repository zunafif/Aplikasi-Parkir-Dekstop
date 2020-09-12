<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Harga
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
        Me.simpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.jenis = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.biaya1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(158, 146)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(75, 23)
        Me.simpan.TabIndex = 0
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jenis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Biaya"
        '
        'jenis
        '
        Me.jenis.Location = New System.Drawing.Point(158, 52)
        Me.jenis.Name = "jenis"
        Me.jenis.Size = New System.Drawing.Size(134, 20)
        Me.jenis.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 5
        '
        'biaya1
        '
        Me.biaya1.Location = New System.Drawing.Point(158, 99)
        Me.biaya1.Name = "biaya1"
        Me.biaya1.Size = New System.Drawing.Size(134, 20)
        Me.biaya1.TabIndex = 6
        '
        'Biaya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 217)
        Me.Controls.Add(Me.biaya1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.jenis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.simpan)
        Me.Name = "Biaya"
        Me.Text = "Biaya"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents simpan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents jenis As TextBox
    Friend WithEvents biaya As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents biaya1 As TextBox
End Class
