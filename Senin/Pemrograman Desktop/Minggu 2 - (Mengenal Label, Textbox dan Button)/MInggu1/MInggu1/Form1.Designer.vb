<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnTentukan = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.tbInpNama = New System.Windows.Forms.TextBox()
        Me.tbInpNilaiTugas = New System.Windows.Forms.TextBox()
        Me.tbInpNilaiUas = New System.Windows.Forms.TextBox()
        Me.tbInpNilaiUts = New System.Windows.Forms.TextBox()
        Me.tbOutStatus = New System.Windows.Forms.TextBox()
        Me.tbOutTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbOutNilaiUts = New System.Windows.Forms.TextBox()
        Me.tbOutNilaiUas = New System.Windows.Forms.TextBox()
        Me.tbOutNilaiTugas = New System.Windows.Forms.TextBox()
        Me.tbOutNama = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menentukan Kelulusan Dari Nilai Mahasiswa"
        '
        'btnTentukan
        '
        Me.btnTentukan.ForeColor = System.Drawing.Color.Black
        Me.btnTentukan.Location = New System.Drawing.Point(15, 152)
        Me.btnTentukan.Name = "btnTentukan"
        Me.btnTentukan.Size = New System.Drawing.Size(283, 23)
        Me.btnTentukan.TabIndex = 1
        Me.btnTentukan.Text = "Tentukan"
        Me.btnTentukan.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(328, 152)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(123, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'tbInpNama
        '
        Me.tbInpNama.Location = New System.Drawing.Point(56, 58)
        Me.tbInpNama.Name = "tbInpNama"
        Me.tbInpNama.Size = New System.Drawing.Size(396, 20)
        Me.tbInpNama.TabIndex = 3
        '
        'tbInpNilaiTugas
        '
        Me.tbInpNilaiTugas.Location = New System.Drawing.Point(15, 101)
        Me.tbInpNilaiTugas.Name = "tbInpNilaiTugas"
        Me.tbInpNilaiTugas.Size = New System.Drawing.Size(128, 20)
        Me.tbInpNilaiTugas.TabIndex = 4
        '
        'tbInpNilaiUas
        '
        Me.tbInpNilaiUas.Location = New System.Drawing.Point(325, 101)
        Me.tbInpNilaiUas.Name = "tbInpNilaiUas"
        Me.tbInpNilaiUas.Size = New System.Drawing.Size(128, 20)
        Me.tbInpNilaiUas.TabIndex = 5
        '
        'tbInpNilaiUts
        '
        Me.tbInpNilaiUts.Location = New System.Drawing.Point(170, 101)
        Me.tbInpNilaiUts.Name = "tbInpNilaiUts"
        Me.tbInpNilaiUts.Size = New System.Drawing.Size(128, 20)
        Me.tbInpNilaiUts.TabIndex = 6
        '
        'tbOutStatus
        '
        Me.tbOutStatus.Enabled = False
        Me.tbOutStatus.Location = New System.Drawing.Point(371, 321)
        Me.tbOutStatus.Name = "tbOutStatus"
        Me.tbOutStatus.Size = New System.Drawing.Size(81, 20)
        Me.tbOutStatus.TabIndex = 9
        '
        'tbOutTotal
        '
        Me.tbOutTotal.Enabled = False
        Me.tbOutTotal.Location = New System.Drawing.Point(170, 322)
        Me.tbOutTotal.Name = "tbOutTotal"
        Me.tbOutTotal.Size = New System.Drawing.Size(93, 20)
        Me.tbOutTotal.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nilai Tugas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nilai UTS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Nilai UAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Total Nilai Yang Didapatkan:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(325, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Status:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(325, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Nilai UAS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(167, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Nilai UTS:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Nilai Tugas:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Nama:"
        '
        'tbOutNilaiUts
        '
        Me.tbOutNilaiUts.Enabled = False
        Me.tbOutNilaiUts.Location = New System.Drawing.Point(170, 274)
        Me.tbOutNilaiUts.Name = "tbOutNilaiUts"
        Me.tbOutNilaiUts.Size = New System.Drawing.Size(128, 20)
        Me.tbOutNilaiUts.TabIndex = 22
        '
        'tbOutNilaiUas
        '
        Me.tbOutNilaiUas.Enabled = False
        Me.tbOutNilaiUas.Location = New System.Drawing.Point(325, 274)
        Me.tbOutNilaiUas.Name = "tbOutNilaiUas"
        Me.tbOutNilaiUas.Size = New System.Drawing.Size(128, 20)
        Me.tbOutNilaiUas.TabIndex = 21
        '
        'tbOutNilaiTugas
        '
        Me.tbOutNilaiTugas.Enabled = False
        Me.tbOutNilaiTugas.Location = New System.Drawing.Point(15, 274)
        Me.tbOutNilaiTugas.Name = "tbOutNilaiTugas"
        Me.tbOutNilaiTugas.Size = New System.Drawing.Size(128, 20)
        Me.tbOutNilaiTugas.TabIndex = 20
        '
        'tbOutNama
        '
        Me.tbOutNama.Enabled = False
        Me.tbOutNama.Location = New System.Drawing.Point(56, 231)
        Me.tbOutNama.Name = "tbOutNama"
        Me.tbOutNama.Size = New System.Drawing.Size(396, 20)
        Me.tbOutNama.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(465, 372)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbOutNilaiUts)
        Me.Controls.Add(Me.tbOutNilaiUas)
        Me.Controls.Add(Me.tbOutNilaiTugas)
        Me.Controls.Add(Me.tbOutNama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbOutTotal)
        Me.Controls.Add(Me.tbOutStatus)
        Me.Controls.Add(Me.tbInpNilaiUts)
        Me.Controls.Add(Me.tbInpNilaiUas)
        Me.Controls.Add(Me.tbInpNilaiTugas)
        Me.Controls.Add(Me.tbInpNama)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnTentukan)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Menentukan Kelulusan Dari Nilai Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTentukan As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents tbInpNama As System.Windows.Forms.TextBox
    Friend WithEvents tbInpNilaiTugas As System.Windows.Forms.TextBox
    Friend WithEvents tbInpNilaiUas As System.Windows.Forms.TextBox
    Friend WithEvents tbInpNilaiUts As System.Windows.Forms.TextBox
    Friend WithEvents tbOutStatus As System.Windows.Forms.TextBox
    Friend WithEvents tbOutTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbOutNilaiUts As System.Windows.Forms.TextBox
    Friend WithEvents tbOutNilaiUas As System.Windows.Forms.TextBox
    Friend WithEvents tbOutNilaiTugas As System.Windows.Forms.TextBox
    Friend WithEvents tbOutNama As System.Windows.Forms.TextBox

End Class
