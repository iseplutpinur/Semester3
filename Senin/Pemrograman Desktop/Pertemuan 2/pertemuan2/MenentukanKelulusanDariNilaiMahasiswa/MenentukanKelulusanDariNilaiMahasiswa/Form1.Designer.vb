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
        Me.tbInpNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbInpNilaiUas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbInpNilaiTugas = New System.Windows.Forms.TextBox()
        Me.tbInpNilaiUts = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbOutNilaiTugas = New System.Windows.Forms.TextBox()
        Me.tbOutNilaiUts = New System.Windows.Forms.TextBox()
        Me.tbOutNilaiUas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbOutNama = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbOutTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbOutStatus = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menentukan Kelulusan Dari Nilai Mahasiswa"
        '
        'tbInpNama
        '
        Me.tbInpNama.Location = New System.Drawing.Point(79, 66)
        Me.tbInpNama.Name = "tbInpNama"
        Me.tbInpNama.Size = New System.Drawing.Size(321, 20)
        Me.tbInpNama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(291, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nilai UAS:"
        '
        'tbInpNilaiUas
        '
        Me.tbInpNilaiUas.Location = New System.Drawing.Point(294, 112)
        Me.tbInpNilaiUas.Name = "tbInpNilaiUas"
        Me.tbInpNilaiUas.Size = New System.Drawing.Size(106, 20)
        Me.tbInpNilaiUas.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nilai UTS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nilai Tugas:"
        '
        'tbInpNilaiTugas
        '
        Me.tbInpNilaiTugas.Location = New System.Drawing.Point(15, 112)
        Me.tbInpNilaiTugas.Name = "tbInpNilaiTugas"
        Me.tbInpNilaiTugas.Size = New System.Drawing.Size(89, 20)
        Me.tbInpNilaiTugas.TabIndex = 7
        '
        'tbInpNilaiUts
        '
        Me.tbInpNilaiUts.Location = New System.Drawing.Point(157, 112)
        Me.tbInpNilaiUts.Name = "tbInpNilaiUts"
        Me.tbInpNilaiUts.Size = New System.Drawing.Size(84, 20)
        Me.tbInpNilaiUts.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(15, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(226, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Tentukan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(294, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbOutNilaiTugas
        '
        Me.tbOutNilaiTugas.Enabled = False
        Me.tbOutNilaiTugas.Location = New System.Drawing.Point(15, 294)
        Me.tbOutNilaiTugas.Name = "tbOutNilaiTugas"
        Me.tbOutNilaiTugas.Size = New System.Drawing.Size(89, 20)
        Me.tbOutNilaiTugas.TabIndex = 18
        '
        'tbOutNilaiUts
        '
        Me.tbOutNilaiUts.Enabled = False
        Me.tbOutNilaiUts.Location = New System.Drawing.Point(157, 294)
        Me.tbOutNilaiUts.Name = "tbOutNilaiUts"
        Me.tbOutNilaiUts.Size = New System.Drawing.Size(84, 20)
        Me.tbOutNilaiUts.TabIndex = 16
        '
        'tbOutNilaiUas
        '
        Me.tbOutNilaiUas.Enabled = False
        Me.tbOutNilaiUas.Location = New System.Drawing.Point(294, 294)
        Me.tbOutNilaiUas.Name = "tbOutNilaiUas"
        Me.tbOutNilaiUas.Size = New System.Drawing.Size(106, 20)
        Me.tbOutNilaiUas.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Nama:"
        '
        'tbOutNama
        '
        Me.tbOutNama.Enabled = False
        Me.tbOutNama.Location = New System.Drawing.Point(79, 248)
        Me.tbOutNama.Name = "tbOutNama"
        Me.tbOutNama.Size = New System.Drawing.Size(321, 20)
        Me.tbOutNama.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 352)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Total Nilai Yang Didapatkan:"
        '
        'tbOutTotal
        '
        Me.tbOutTotal.Enabled = False
        Me.tbOutTotal.Location = New System.Drawing.Point(157, 349)
        Me.tbOutTotal.Name = "tbOutTotal"
        Me.tbOutTotal.Size = New System.Drawing.Size(70, 20)
        Me.tbOutTotal.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(284, 352)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Status:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Nilai Tugas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(154, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Nilai UTS:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(291, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Nilai UAS:"
        '
        'tbOutStatus
        '
        Me.tbOutStatus.Enabled = False
        Me.tbOutStatus.Location = New System.Drawing.Point(330, 349)
        Me.tbOutStatus.Name = "tbOutStatus"
        Me.tbOutStatus.Size = New System.Drawing.Size(70, 20)
        Me.tbOutStatus.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(412, 414)
        Me.Controls.Add(Me.tbOutStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbOutTotal)
        Me.Controls.Add(Me.tbOutNilaiTugas)
        Me.Controls.Add(Me.tbOutNilaiUts)
        Me.Controls.Add(Me.tbOutNilaiUas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbOutNama)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbInpNilaiTugas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbInpNilaiUts)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbInpNilaiUas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbInpNama)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(428, 452)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(428, 452)
        Me.Name = "Form1"
        Me.Text = "Menentukan Kelulusan Dari Nilai Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbInpNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbInpNilaiUas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbInpNilaiTugas As System.Windows.Forms.TextBox
    Friend WithEvents tbInpNilaiUts As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbOutNilaiTugas As System.Windows.Forms.TextBox
    Friend WithEvents tbOutNilaiUts As System.Windows.Forms.TextBox
    Friend WithEvents tbOutNilaiUas As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbOutNama As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbOutTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbOutStatus As System.Windows.Forms.TextBox

End Class
