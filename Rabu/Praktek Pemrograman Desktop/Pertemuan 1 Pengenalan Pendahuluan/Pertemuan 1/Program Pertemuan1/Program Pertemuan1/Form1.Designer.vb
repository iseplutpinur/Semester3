<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNamaLengkap = New System.Windows.Forms.TextBox()
        Me.tbMatkul = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbJurusan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNPM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Location = New System.Drawing.Point(62, 212)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(228, 23)
        Me.btnTampilkan.TabIndex = 0
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Lengkap :"
        '
        'tbNamaLengkap
        '
        Me.tbNamaLengkap.Enabled = False
        Me.tbNamaLengkap.Location = New System.Drawing.Point(190, 43)
        Me.tbNamaLengkap.Name = "tbNamaLengkap"
        Me.tbNamaLengkap.Size = New System.Drawing.Size(100, 20)
        Me.tbNamaLengkap.TabIndex = 2
        '
        'tbMatkul
        '
        Me.tbMatkul.Enabled = False
        Me.tbMatkul.Location = New System.Drawing.Point(190, 164)
        Me.tbMatkul.Name = "tbMatkul"
        Me.tbMatkul.Size = New System.Drawing.Size(100, 20)
        Me.tbMatkul.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Matkul :"
        '
        'tbJurusan
        '
        Me.tbJurusan.Enabled = False
        Me.tbJurusan.Location = New System.Drawing.Point(190, 121)
        Me.tbJurusan.Name = "tbJurusan"
        Me.tbJurusan.Size = New System.Drawing.Size(100, 20)
        Me.tbJurusan.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jurusan :"
        '
        'tbNPM
        '
        Me.tbNPM.Enabled = False
        Me.tbNPM.Location = New System.Drawing.Point(190, 82)
        Me.tbNPM.Name = "tbNPM"
        Me.tbNPM.Size = New System.Drawing.Size(100, 20)
        Me.tbNPM.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(108, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NPM :"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(361, 313)
        Me.Controls.Add(Me.tbNPM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbJurusan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbMatkul)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbNamaLengkap)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTampilkan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Text = "main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTampilkan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbNamaLengkap As System.Windows.Forms.TextBox
    Friend WithEvents tbMatkul As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbJurusan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbNPM As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
