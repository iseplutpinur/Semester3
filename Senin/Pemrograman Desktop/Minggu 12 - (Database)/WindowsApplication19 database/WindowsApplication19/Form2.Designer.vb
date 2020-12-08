<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhapus
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
        Me.txtkota = New System.Windows.Forms.TextBox()
        Me.cmdhapus = New System.Windows.Forms.Button()
        Me.cmdbatal = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.cmbagama = New System.Windows.Forms.ComboBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtnpm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.radiolaki = New System.Windows.Forms.RadioButton()
        Me.radioperempuan = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'txtkota
        '
        Me.txtkota.Enabled = False
        Me.txtkota.Location = New System.Drawing.Point(98, 103)
        Me.txtkota.Name = "txtkota"
        Me.txtkota.Size = New System.Drawing.Size(212, 20)
        Me.txtkota.TabIndex = 15
        '
        'cmdhapus
        '
        Me.cmdhapus.Location = New System.Drawing.Point(123, 209)
        Me.cmdhapus.Name = "cmdhapus"
        Me.cmdhapus.Size = New System.Drawing.Size(58, 34)
        Me.cmdhapus.TabIndex = 18
        Me.cmdhapus.Text = "Hapus"
        Me.cmdhapus.UseVisualStyleBackColor = True
        '
        'cmdbatal
        '
        Me.cmdbatal.Location = New System.Drawing.Point(187, 209)
        Me.cmdbatal.Name = "cmdbatal"
        Me.cmdbatal.Size = New System.Drawing.Size(60, 34)
        Me.cmdbatal.TabIndex = 19
        Me.cmdbatal.Text = "Batal"
        Me.cmdbatal.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Location = New System.Drawing.Point(253, 209)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(58, 35)
        Me.cmdkeluar.TabIndex = 20
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'cmbagama
        '
        Me.cmbagama.Enabled = False
        Me.cmbagama.FormattingEnabled = True
        Me.cmbagama.Location = New System.Drawing.Point(100, 137)
        Me.cmbagama.Name = "cmbagama"
        Me.cmbagama.Size = New System.Drawing.Size(128, 21)
        Me.cmbagama.TabIndex = 16
        '
        'txtalamat
        '
        Me.txtalamat.Enabled = False
        Me.txtalamat.Location = New System.Drawing.Point(98, 74)
        Me.txtalamat.MaxLength = 30
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(213, 20)
        Me.txtalamat.TabIndex = 12
        '
        'txtnama
        '
        Me.txtnama.Enabled = False
        Me.txtnama.Location = New System.Drawing.Point(98, 46)
        Me.txtnama.MaxLength = 30
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(213, 20)
        Me.txtnama.TabIndex = 10
        '
        'txtnpm
        '
        Me.txtnpm.Location = New System.Drawing.Point(98, 20)
        Me.txtnpm.MaxLength = 5
        Me.txtnpm.Name = "txtnpm"
        Me.txtnpm.Size = New System.Drawing.Size(63, 20)
        Me.txtnpm.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Agama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Kota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NPM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Jenis Kelamin"
        '
        'radiolaki
        '
        Me.radiolaki.AutoSize = True
        Me.radiolaki.Location = New System.Drawing.Point(111, 171)
        Me.radiolaki.Name = "radiolaki"
        Me.radiolaki.Size = New System.Drawing.Size(64, 17)
        Me.radiolaki.TabIndex = 22
        Me.radiolaki.TabStop = True
        Me.radiolaki.Text = "Laki laki"
        Me.radiolaki.UseVisualStyleBackColor = True
        '
        'radioperempuan
        '
        Me.radioperempuan.AutoSize = True
        Me.radioperempuan.Location = New System.Drawing.Point(204, 173)
        Me.radioperempuan.Name = "radioperempuan"
        Me.radioperempuan.Size = New System.Drawing.Size(79, 17)
        Me.radioperempuan.TabIndex = 23
        Me.radioperempuan.TabStop = True
        Me.radioperempuan.Text = "Perempuan"
        Me.radioperempuan.UseVisualStyleBackColor = True
        '
        'frmhapus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 256)
        Me.Controls.Add(Me.radioperempuan)
        Me.Controls.Add(Me.radiolaki)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtkota)
        Me.Controls.Add(Me.cmdhapus)
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
        Me.Name = "frmhapus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hapus Data Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtkota As System.Windows.Forms.TextBox
    Friend WithEvents cmdhapus As System.Windows.Forms.Button
    Friend WithEvents cmdbatal As System.Windows.Forms.Button
    Friend WithEvents cmdkeluar As System.Windows.Forms.Button
    Friend WithEvents cmbagama As System.Windows.Forms.ComboBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtnpm As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents radiolaki As System.Windows.Forms.RadioButton
    Friend WithEvents radioperempuan As System.Windows.Forms.RadioButton
End Class
