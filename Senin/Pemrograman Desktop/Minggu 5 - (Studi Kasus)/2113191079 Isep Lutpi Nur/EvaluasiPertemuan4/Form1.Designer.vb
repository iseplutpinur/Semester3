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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNPM = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.tbAlamat = New System.Windows.Forms.TextBox()
        Me.tbOutput = New System.Windows.Forms.TextBox()
        Me.rbLakiLaki = New System.Windows.Forms.RadioButton()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.cbAgama = New System.Windows.Forms.ComboBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NPM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Agama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jensi Kelamin"
        '
        'tbNPM
        '
        Me.tbNPM.Location = New System.Drawing.Point(99, 13)
        Me.tbNPM.Name = "tbNPM"
        Me.tbNPM.Size = New System.Drawing.Size(100, 20)
        Me.tbNPM.TabIndex = 5
        '
        'tbNama
        '
        Me.tbNama.Enabled = False
        Me.tbNama.Location = New System.Drawing.Point(99, 44)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(223, 20)
        Me.tbNama.TabIndex = 7
        '
        'tbAlamat
        '
        Me.tbAlamat.Enabled = False
        Me.tbAlamat.Location = New System.Drawing.Point(99, 78)
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.Size = New System.Drawing.Size(223, 20)
        Me.tbAlamat.TabIndex = 8
        '
        'tbOutput
        '
        Me.tbOutput.Enabled = False
        Me.tbOutput.Location = New System.Drawing.Point(15, 218)
        Me.tbOutput.Multiline = True
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.Size = New System.Drawing.Size(307, 71)
        Me.tbOutput.TabIndex = 9
        '
        'rbLakiLaki
        '
        Me.rbLakiLaki.AutoSize = True
        Me.rbLakiLaki.Checked = True
        Me.rbLakiLaki.Enabled = False
        Me.rbLakiLaki.Location = New System.Drawing.Point(99, 152)
        Me.rbLakiLaki.Name = "rbLakiLaki"
        Me.rbLakiLaki.Size = New System.Drawing.Size(68, 17)
        Me.rbLakiLaki.TabIndex = 10
        Me.rbLakiLaki.TabStop = True
        Me.rbLakiLaki.Text = "Laki-Laki"
        Me.rbLakiLaki.UseVisualStyleBackColor = True
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Enabled = False
        Me.rbPerempuan.Location = New System.Drawing.Point(99, 175)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbPerempuan.TabIndex = 11
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'cbAgama
        '
        Me.cbAgama.Enabled = False
        Me.cbAgama.FormattingEnabled = True
        Me.cbAgama.Location = New System.Drawing.Point(99, 115)
        Me.cbAgama.Name = "cbAgama"
        Me.cbAgama.Size = New System.Drawing.Size(100, 21)
        Me.cbAgama.TabIndex = 12
        '
        'btnOk
        '
        Me.btnOk.Enabled = False
        Me.btnOk.Location = New System.Drawing.Point(216, 115)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 35)
        Me.btnOk.TabIndex = 13
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnBaru
        '
        Me.btnBaru.Enabled = False
        Me.btnBaru.Location = New System.Drawing.Point(216, 157)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(75, 35)
        Me.btnBaru.TabIndex = 14
        Me.btnBaru.Text = "BARU"
        Me.btnBaru.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 301)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.cbAgama)
        Me.Controls.Add(Me.rbPerempuan)
        Me.Controls.Add(Me.rbLakiLaki)
        Me.Controls.Add(Me.tbOutput)
        Me.Controls.Add(Me.tbAlamat)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.tbNPM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Data Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbNPM As System.Windows.Forms.TextBox
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents tbAlamat As System.Windows.Forms.TextBox
    Friend WithEvents tbOutput As System.Windows.Forms.TextBox
    Friend WithEvents rbLakiLaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents cbAgama As System.Windows.Forms.ComboBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnBaru As System.Windows.Forms.Button

End Class
