<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frTokoIstanaBuah
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
        Me.cbNamaBuah = New System.Windows.Forms.ComboBox()
        Me.tbHargaBuah = New System.Windows.Forms.TextBox()
        Me.tbJumlahBeli = New System.Windows.Forms.TextBox()
        Me.tbTotalHarga = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Toko Istana Buah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Buah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(151, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga Buah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Beli"
        '
        'cbNamaBuah
        '
        Me.cbNamaBuah.FormattingEnabled = True
        Me.cbNamaBuah.Location = New System.Drawing.Point(34, 95)
        Me.cbNamaBuah.Name = "cbNamaBuah"
        Me.cbNamaBuah.Size = New System.Drawing.Size(100, 21)
        Me.cbNamaBuah.TabIndex = 5
        '
        'tbHargaBuah
        '
        Me.tbHargaBuah.Enabled = False
        Me.tbHargaBuah.Location = New System.Drawing.Point(154, 95)
        Me.tbHargaBuah.Name = "tbHargaBuah"
        Me.tbHargaBuah.Size = New System.Drawing.Size(100, 20)
        Me.tbHargaBuah.TabIndex = 6
        '
        'tbJumlahBeli
        '
        Me.tbJumlahBeli.Location = New System.Drawing.Point(34, 148)
        Me.tbJumlahBeli.Name = "tbJumlahBeli"
        Me.tbJumlahBeli.Size = New System.Drawing.Size(100, 20)
        Me.tbJumlahBeli.TabIndex = 7
        '
        'tbTotalHarga
        '
        Me.tbTotalHarga.Enabled = False
        Me.tbTotalHarga.Location = New System.Drawing.Point(154, 148)
        Me.tbTotalHarga.Name = "tbTotalHarga"
        Me.tbTotalHarga.Size = New System.Drawing.Size(100, 20)
        Me.tbTotalHarga.TabIndex = 8
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(34, 200)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(220, 23)
        Me.btnHitung.TabIndex = 9
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'frTokoIstanaBuah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.tbTotalHarga)
        Me.Controls.Add(Me.tbJumlahBeli)
        Me.Controls.Add(Me.tbHargaBuah)
        Me.Controls.Add(Me.cbNamaBuah)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frTokoIstanaBuah"
        Me.Text = "Toko Istana Buah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbHargaBuah As System.Windows.Forms.TextBox
    Friend WithEvents tbJumlahBeli As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents cbNamaBuah As System.Windows.Forms.ComboBox

End Class
