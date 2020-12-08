<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCariKey = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.radioperempuan = New System.Windows.Forms.RadioButton()
        Me.radiolaki = New System.Windows.Forms.RadioButton()
        Me.txtkota = New System.Windows.Forms.TextBox()
        Me.cmbagama = New System.Windows.Forms.ComboBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtnpm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(21, 303)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(422, 173)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Pencarian data mahasiswa:"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(394, 274)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(49, 23)
        Me.btnCari.TabIndex = 38
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'txtCariKey
        '
        Me.txtCariKey.Location = New System.Drawing.Point(182, 277)
        Me.txtCariKey.Name = "txtCariKey"
        Me.txtCariKey.Size = New System.Drawing.Size(206, 20)
        Me.txtCariKey.TabIndex = 37
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(357, 193)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 23)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Tutup"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(245, 193)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 23)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(133, 193)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 23)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Jenis Kelamin"
        '
        'radioperempuan
        '
        Me.radioperempuan.AutoSize = True
        Me.radioperempuan.Location = New System.Drawing.Point(97, 154)
        Me.radioperempuan.Name = "radioperempuan"
        Me.radioperempuan.Size = New System.Drawing.Size(79, 17)
        Me.radioperempuan.TabIndex = 51
        Me.radioperempuan.TabStop = True
        Me.radioperempuan.Text = "Perempuan"
        Me.radioperempuan.UseVisualStyleBackColor = True
        '
        'radiolaki
        '
        Me.radiolaki.AutoSize = True
        Me.radiolaki.Location = New System.Drawing.Point(23, 154)
        Me.radiolaki.Name = "radiolaki"
        Me.radiolaki.Size = New System.Drawing.Size(68, 17)
        Me.radiolaki.TabIndex = 50
        Me.radiolaki.TabStop = True
        Me.radiolaki.Text = "Laki-Laki"
        Me.radiolaki.UseVisualStyleBackColor = True
        '
        'txtkota
        '
        Me.txtkota.Location = New System.Drawing.Point(165, 95)
        Me.txtkota.MaxLength = 20
        Me.txtkota.Name = "txtkota"
        Me.txtkota.Size = New System.Drawing.Size(124, 20)
        Me.txtkota.TabIndex = 46
        '
        'cmbagama
        '
        Me.cmbagama.FormattingEnabled = True
        Me.cmbagama.Location = New System.Drawing.Point(21, 95)
        Me.cmbagama.Name = "cmbagama"
        Me.cmbagama.Size = New System.Drawing.Size(128, 21)
        Me.cmbagama.TabIndex = 48
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(307, 42)
        Me.txtalamat.MaxLength = 100
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(136, 129)
        Me.txtalamat.TabIndex = 44
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(132, 42)
        Me.txtnama.MaxLength = 30
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(157, 20)
        Me.txtnama.TabIndex = 42
        '
        'txtnpm
        '
        Me.txtnpm.Location = New System.Drawing.Point(21, 42)
        Me.txtnpm.MaxLength = 10
        Me.txtnpm.Name = "txtnpm"
        Me.txtnpm.Size = New System.Drawing.Size(93, 20)
        Me.txtnpm.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Agama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(162, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Kota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Nama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "NPM"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 491)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.radioperempuan)
        Me.Controls.Add(Me.radiolaki)
        Me.Controls.Add(Me.txtkota)
        Me.Controls.Add(Me.cmbagama)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnpm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCariKey)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCariKey As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents radioperempuan As RadioButton
    Friend WithEvents radiolaki As RadioButton
    Friend WithEvents txtkota As TextBox
    Friend WithEvents cmbagama As ComboBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtnpm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
End Class
