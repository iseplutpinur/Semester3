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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbNamaSuplier = New System.Windows.Forms.ComboBox()
        Me.rdoMeter = New System.Windows.Forms.RadioButton()
        Me.rdoLiter = New System.Windows.Forms.RadioButton()
        Me.rdoBox = New System.Windows.Forms.RadioButton()
        Me.rdoDus = New System.Windows.Forms.RadioButton()
        Me.rdoBotol = New System.Windows.Forms.RadioButton()
        Me.rdoPieces = New System.Windows.Forms.RadioButton()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 207)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 86)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Suplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Satuan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Kode barang"
        '
        'cmbNamaSuplier
        '
        Me.cmbNamaSuplier.FormattingEnabled = True
        Me.cmbNamaSuplier.Location = New System.Drawing.Point(143, 76)
        Me.cmbNamaSuplier.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbNamaSuplier.Name = "cmbNamaSuplier"
        Me.cmbNamaSuplier.Size = New System.Drawing.Size(220, 24)
        Me.cmbNamaSuplier.TabIndex = 48
        '
        'rdoMeter
        '
        Me.rdoMeter.AutoSize = True
        Me.rdoMeter.Location = New System.Drawing.Point(299, 164)
        Me.rdoMeter.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoMeter.Name = "rdoMeter"
        Me.rdoMeter.Size = New System.Drawing.Size(65, 21)
        Me.rdoMeter.TabIndex = 47
        Me.rdoMeter.Text = "Meter"
        Me.rdoMeter.UseVisualStyleBackColor = True
        '
        'rdoLiter
        '
        Me.rdoLiter.AutoSize = True
        Me.rdoLiter.Location = New System.Drawing.Point(299, 118)
        Me.rdoLiter.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoLiter.Name = "rdoLiter"
        Me.rdoLiter.Size = New System.Drawing.Size(57, 21)
        Me.rdoLiter.TabIndex = 46
        Me.rdoLiter.Text = "Liter"
        Me.rdoLiter.UseVisualStyleBackColor = True
        '
        'rdoBox
        '
        Me.rdoBox.AutoSize = True
        Me.rdoBox.Location = New System.Drawing.Point(228, 164)
        Me.rdoBox.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBox.Name = "rdoBox"
        Me.rdoBox.Size = New System.Drawing.Size(52, 21)
        Me.rdoBox.TabIndex = 45
        Me.rdoBox.Text = "Box"
        Me.rdoBox.UseVisualStyleBackColor = True
        '
        'rdoDus
        '
        Me.rdoDus.AutoSize = True
        Me.rdoDus.Location = New System.Drawing.Point(228, 118)
        Me.rdoDus.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoDus.Name = "rdoDus"
        Me.rdoDus.Size = New System.Drawing.Size(54, 21)
        Me.rdoDus.TabIndex = 44
        Me.rdoDus.Text = "Dus"
        Me.rdoDus.UseVisualStyleBackColor = True
        '
        'rdoBotol
        '
        Me.rdoBotol.AutoSize = True
        Me.rdoBotol.Location = New System.Drawing.Point(143, 164)
        Me.rdoBotol.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBotol.Name = "rdoBotol"
        Me.rdoBotol.Size = New System.Drawing.Size(61, 21)
        Me.rdoBotol.TabIndex = 43
        Me.rdoBotol.Text = "Botol"
        Me.rdoBotol.UseVisualStyleBackColor = True
        '
        'rdoPieces
        '
        Me.rdoPieces.AutoSize = True
        Me.rdoPieces.Location = New System.Drawing.Point(143, 118)
        Me.rdoPieces.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoPieces.Name = "rdoPieces"
        Me.rdoPieces.Size = New System.Drawing.Size(71, 21)
        Me.rdoPieces.TabIndex = 42
        Me.rdoPieces.Text = "Pieces"
        Me.rdoPieces.UseVisualStyleBackColor = True
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(143, 44)
        Me.txtNamaBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(220, 22)
        Me.txtNamaBarang.TabIndex = 41
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(143, 203)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(231, 22)
        Me.txtHarga.TabIndex = 40
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(143, 12)
        Me.txtKodeBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(169, 22)
        Me.txtKodeBarang.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 269)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 49)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(107, 269)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 49)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(198, 269)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 49)
        Me.Button3.TabIndex = 57
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(301, 269)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 49)
        Me.Button4.TabIndex = 58
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(16, 326)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(358, 162)
        Me.ListView1.TabIndex = 59
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 501)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNamaSuplier)
        Me.Controls.Add(Me.rdoMeter)
        Me.Controls.Add(Me.rdoLiter)
        Me.Controls.Add(Me.rdoBox)
        Me.Controls.Add(Me.rdoDus)
        Me.Controls.Add(Me.rdoBotol)
        Me.Controls.Add(Me.rdoPieces)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Name = "Form1"
        Me.Text = "Identitas Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNamaSuplier As System.Windows.Forms.ComboBox
    Friend WithEvents rdoMeter As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLiter As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBox As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDus As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBotol As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPieces As System.Windows.Forms.RadioButton
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView

End Class
