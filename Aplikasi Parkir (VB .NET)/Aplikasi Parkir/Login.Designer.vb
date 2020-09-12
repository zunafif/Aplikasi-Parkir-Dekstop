<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.user = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.masuk = New System.Windows.Forms.Button()
        Me.tampil = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(64, 108)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(164, 20)
        Me.user.TabIndex = 0
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(64, 145)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(164, 20)
        Me.pass.TabIndex = 1
        '
        'masuk
        '
        Me.masuk.Location = New System.Drawing.Point(102, 197)
        Me.masuk.Name = "masuk"
        Me.masuk.Size = New System.Drawing.Size(75, 23)
        Me.masuk.TabIndex = 2
        Me.masuk.Text = "Masuk"
        Me.masuk.UseVisualStyleBackColor = True
        '
        'tampil
        '
        Me.tampil.AutoSize = True
        Me.tampil.Location = New System.Drawing.Point(244, 147)
        Me.tampil.Name = "tampil"
        Me.tampil.Size = New System.Drawing.Size(98, 17)
        Me.tampil.TabIndex = 3
        Me.tampil.Text = "Lihat Password"
        Me.tampil.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LOGIN"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 271)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tampil)
        Me.Controls.Add(Me.masuk)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.user)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents user As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents masuk As Button
    Friend WithEvents tampil As CheckBox
    Friend WithEvents Label1 As Label
End Class
