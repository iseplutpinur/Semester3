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
        Me.tbBeratBadan = New System.Windows.Forms.TextBox()
        Me.tbTinggiBadan = New System.Windows.Forms.TextBox()
        Me.cbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTentukan = New System.Windows.Forms.Button()
        Me.tbStatus = New System.Windows.Forms.TextBox()
        Me.tbNilai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menentukan Indeks Masa Tubuh"
        '
        'tbBeratBadan
        '
        Me.tbBeratBadan.Location = New System.Drawing.Point(31, 76)
        Me.tbBeratBadan.Name = "tbBeratBadan"
        Me.tbBeratBadan.Size = New System.Drawing.Size(100, 20)
        Me.tbBeratBadan.TabIndex = 1
        '
        'tbTinggiBadan
        '
        Me.tbTinggiBadan.Location = New System.Drawing.Point(153, 76)
        Me.tbTinggiBadan.Name = "tbTinggiBadan"
        Me.tbTinggiBadan.Size = New System.Drawing.Size(100, 20)
        Me.tbTinggiBadan.TabIndex = 2
        '
        'cbJenisKelamin
        '
        Me.cbJenisKelamin.FormattingEnabled = True
        Me.cbJenisKelamin.Location = New System.Drawing.Point(31, 124)
        Me.cbJenisKelamin.Name = "cbJenisKelamin"
        Me.cbJenisKelamin.Size = New System.Drawing.Size(222, 21)
        Me.cbJenisKelamin.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Berat Badan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tinggi Badan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jenis Kelamin"
        '
        'btnTentukan
        '
        Me.btnTentukan.Location = New System.Drawing.Point(34, 163)
        Me.btnTentukan.Name = "btnTentukan"
        Me.btnTentukan.Size = New System.Drawing.Size(219, 23)
        Me.btnTentukan.TabIndex = 7
        Me.btnTentukan.Text = "Tentukan"
        Me.btnTentukan.UseVisualStyleBackColor = True
        '
        'tbStatus
        '
        Me.tbStatus.Enabled = False
        Me.tbStatus.Location = New System.Drawing.Point(34, 216)
        Me.tbStatus.Name = "tbStatus"
        Me.tbStatus.Size = New System.Drawing.Size(141, 20)
        Me.tbStatus.TabIndex = 8
        '
        'tbNilai
        '
        Me.tbNilai.Enabled = False
        Me.tbNilai.Location = New System.Drawing.Point(197, 216)
        Me.tbNilai.Name = "tbNilai"
        Me.tbNilai.Size = New System.Drawing.Size(56, 20)
        Me.tbNilai.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Status IMT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(194, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nilai IMT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbNilai)
        Me.Controls.Add(Me.tbStatus)
        Me.Controls.Add(Me.btnTentukan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbJenisKelamin)
        Me.Controls.Add(Me.tbTinggiBadan)
        Me.Controls.Add(Me.tbBeratBadan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Menentukan IMT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbBeratBadan As System.Windows.Forms.TextBox
    Friend WithEvents tbTinggiBadan As System.Windows.Forms.TextBox
    Friend WithEvents cbJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnTentukan As System.Windows.Forms.Button
    Friend WithEvents tbStatus As System.Windows.Forms.TextBox
    Friend WithEvents tbNilai As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
