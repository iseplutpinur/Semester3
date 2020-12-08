<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminput
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnpm = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.cmbagama = New System.Windows.Forms.ComboBox()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.cmdbatal = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.txtkota = New System.Windows.Forms.TextBox()
        Me.radiolaki = New System.Windows.Forms.RadioButton()
        Me.radioperempuan = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NPM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Agama"
        '
        'txtnpm
        '
        Me.txtnpm.Location = New System.Drawing.Point(105, 32)
        Me.txtnpm.MaxLength = 5
        Me.txtnpm.Name = "txtnpm"
        Me.txtnpm.Size = New System.Drawing.Size(63, 20)
        Me.txtnpm.TabIndex = 0
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(105, 58)
        Me.txtnama.MaxLength = 30
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(213, 20)
        Me.txtnama.TabIndex = 1
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(105, 86)
        Me.txtalamat.MaxLength = 30
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(213, 20)
        Me.txtalamat.TabIndex = 2
        '
        'cmbagama
        '
        Me.cmbagama.FormattingEnabled = True
        Me.cmbagama.Location = New System.Drawing.Point(107, 149)
        Me.cmbagama.Name = "cmbagama"
        Me.cmbagama.Size = New System.Drawing.Size(128, 21)
        Me.cmbagama.TabIndex = 4
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Location = New System.Drawing.Point(260, 218)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(58, 35)
        Me.cmdkeluar.TabIndex = 7
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'cmdbatal
        '
        Me.cmdbatal.Location = New System.Drawing.Point(194, 218)
        Me.cmdbatal.Name = "cmdbatal"
        Me.cmdbatal.Size = New System.Drawing.Size(60, 34)
        Me.cmdbatal.TabIndex = 6
        Me.cmdbatal.Text = "Batal"
        Me.cmdbatal.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Location = New System.Drawing.Point(130, 218)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(58, 34)
        Me.cmdsimpan.TabIndex = 5
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'txtkota
        '
        Me.txtkota.Location = New System.Drawing.Point(105, 115)
        Me.txtkota.MaxLength = 20
        Me.txtkota.Name = "txtkota"
        Me.txtkota.Size = New System.Drawing.Size(212, 20)
        Me.txtkota.TabIndex = 3
        '
        'radiolaki
        '
        Me.radiolaki.AutoSize = True
        Me.radiolaki.Location = New System.Drawing.Point(107, 183)
        Me.radiolaki.Name = "radiolaki"
        Me.radiolaki.Size = New System.Drawing.Size(68, 17)
        Me.radiolaki.TabIndex = 8
        Me.radiolaki.TabStop = True
        Me.radiolaki.Text = "Laki-Laki"
        Me.radiolaki.UseVisualStyleBackColor = True
        '
        'radioperempuan
        '
        Me.radioperempuan.AutoSize = True
        Me.radioperempuan.Location = New System.Drawing.Point(177, 183)
        Me.radioperempuan.Name = "radioperempuan"
        Me.radioperempuan.Size = New System.Drawing.Size(79, 17)
        Me.radioperempuan.TabIndex = 9
        Me.radioperempuan.TabStop = True
        Me.radioperempuan.Text = "Perempuan"
        Me.radioperempuan.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Jenis Kelamin"
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 265)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.radioperempuan)
        Me.Controls.Add(Me.radiolaki)
        Me.Controls.Add(Me.txtkota)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdbatal)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmbagama)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnpm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frminput"
        Me.Text = "Input Data Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnpm As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents cmbagama As System.Windows.Forms.ComboBox
    Friend WithEvents cmdkeluar As System.Windows.Forms.Button
    Friend WithEvents cmdbatal As System.Windows.Forms.Button
    Friend WithEvents cmdsimpan As System.Windows.Forms.Button
    Friend WithEvents txtkota As System.Windows.Forms.TextBox
    Friend WithEvents radiolaki As System.Windows.Forms.RadioButton
    Friend WithEvents radioperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
