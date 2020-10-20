<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.txtbil2 = New System.Windows.Forms.TextBox()
        Me.txtbil1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdojumlah = New System.Windows.Forms.RadioButton()
        Me.rdokali = New System.Windows.Forms.RadioButton()
        Me.rdokurang = New System.Windows.Forms.RadioButton()
        Me.btnbaru = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnhitung
        '
        Me.btnhitung.Location = New System.Drawing.Point(244, 109)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(67, 47)
        Me.btnhitung.TabIndex = 17
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'txthasil
        '
        Me.txthasil.Enabled = False
        Me.txthasil.Location = New System.Drawing.Point(122, 190)
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(102, 20)
        Me.txthasil.TabIndex = 16
        '
        'txtbil2
        '
        Me.txtbil2.Location = New System.Drawing.Point(122, 56)
        Me.txtbil2.Name = "txtbil2"
        Me.txtbil2.Size = New System.Drawing.Size(104, 20)
        Me.txtbil2.TabIndex = 14
        '
        'txtbil1
        '
        Me.txtbil1.Location = New System.Drawing.Point(122, 18)
        Me.txtbil1.Name = "txtbil1"
        Me.txtbil1.Size = New System.Drawing.Size(105, 20)
        Me.txtbil1.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Hasil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Pilihan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Bilangan Kedua"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Bilangan Pertama"
        '
        'rdojumlah
        '
        Me.rdojumlah.AutoSize = True
        Me.rdojumlah.Location = New System.Drawing.Point(129, 96)
        Me.rdojumlah.Name = "rdojumlah"
        Me.rdojumlah.Size = New System.Drawing.Size(86, 17)
        Me.rdojumlah.TabIndex = 18
        Me.rdojumlah.TabStop = True
        Me.rdojumlah.Text = "Penjumlahan"
        Me.rdojumlah.UseVisualStyleBackColor = True
        '
        'rdokali
        '
        Me.rdokali.AutoSize = True
        Me.rdokali.Location = New System.Drawing.Point(129, 125)
        Me.rdokali.Name = "rdokali"
        Me.rdokali.Size = New System.Drawing.Size(69, 17)
        Me.rdokali.TabIndex = 19
        Me.rdokali.TabStop = True
        Me.rdokali.Text = "Perkalian"
        Me.rdokali.UseVisualStyleBackColor = True
        '
        'rdokurang
        '
        Me.rdokurang.AutoSize = True
        Me.rdokurang.Location = New System.Drawing.Point(127, 157)
        Me.rdokurang.Name = "rdokurang"
        Me.rdokurang.Size = New System.Drawing.Size(89, 17)
        Me.rdokurang.TabIndex = 20
        Me.rdokurang.TabStop = True
        Me.rdokurang.Text = "Pengurangan"
        Me.rdokurang.UseVisualStyleBackColor = True
        '
        'btnbaru
        '
        Me.btnbaru.Location = New System.Drawing.Point(242, 162)
        Me.btnbaru.Name = "btnbaru"
        Me.btnbaru.Size = New System.Drawing.Size(68, 47)
        Me.btnbaru.TabIndex = 21
        Me.btnbaru.Text = "Baru"
        Me.btnbaru.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 235)
        Me.Controls.Add(Me.btnbaru)
        Me.Controls.Add(Me.rdokurang)
        Me.Controls.Add(Me.rdokali)
        Me.Controls.Add(Me.rdojumlah)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.txthasil)
        Me.Controls.Add(Me.txtbil2)
        Me.Controls.Add(Me.txtbil1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Operasi Matematika"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnhitung As System.Windows.Forms.Button
    Friend WithEvents txthasil As System.Windows.Forms.TextBox
    Friend WithEvents txtbil2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbil1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdojumlah As System.Windows.Forms.RadioButton
    Friend WithEvents rdokali As System.Windows.Forms.RadioButton
    Friend WithEvents rdokurang As System.Windows.Forms.RadioButton
    Friend WithEvents btnbaru As System.Windows.Forms.Button
End Class
