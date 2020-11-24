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
        Me.kd_brg = New System.Windows.Forms.TextBox()
        Me.nama_brg = New System.Windows.Forms.TextBox()
        Me.Satuan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Stock = New System.Windows.Forms.TextBox()
        Me.Jml_beli = New System.Windows.Forms.TextBox()
        Me.cmdok = New System.Windows.Forms.Button()
        Me.listview1 = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grandtotal = New System.Windows.Forms.Label()
        Me.cmdbaru = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Beli"
        '
        'kd_brg
        '
        Me.kd_brg.Location = New System.Drawing.Point(137, 23)
        Me.kd_brg.MaxLength = 5
        Me.kd_brg.Name = "kd_brg"
        Me.kd_brg.Size = New System.Drawing.Size(78, 20)
        Me.kd_brg.TabIndex = 4
        '
        'nama_brg
        '
        Me.nama_brg.Location = New System.Drawing.Point(138, 54)
        Me.nama_brg.MaxLength = 30
        Me.nama_brg.Name = "nama_brg"
        Me.nama_brg.Size = New System.Drawing.Size(221, 20)
        Me.nama_brg.TabIndex = 5
        '
        'Satuan
        '
        Me.Satuan.FormattingEnabled = True
        Me.Satuan.Location = New System.Drawing.Point(138, 85)
        Me.Satuan.Name = "Satuan"
        Me.Satuan.Size = New System.Drawing.Size(77, 21)
        Me.Satuan.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Stock"
        '
        'Stock
        '
        Me.Stock.Location = New System.Drawing.Point(141, 119)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(74, 20)
        Me.Stock.TabIndex = 8
        '
        'Jml_beli
        '
        Me.Jml_beli.Location = New System.Drawing.Point(287, 122)
        Me.Jml_beli.Name = "Jml_beli"
        Me.Jml_beli.Size = New System.Drawing.Size(72, 20)
        Me.Jml_beli.TabIndex = 9
        '
        'cmdok
        '
        Me.cmdok.Location = New System.Drawing.Point(237, 157)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(122, 26)
        Me.cmdok.TabIndex = 10
        Me.cmdok.Text = "OK"
        Me.cmdok.UseVisualStyleBackColor = True
        '
        'listview1
        '
        Me.listview1.Location = New System.Drawing.Point(34, 201)
        Me.listview1.Name = "listview1"
        Me.listview1.Size = New System.Drawing.Size(325, 161)
        Me.listview1.TabIndex = 11
        Me.listview1.UseCompatibleStateImageBehavior = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Harga"
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(270, 86)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(89, 20)
        Me.harga.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(187, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Grand Total"
        '
        'grandtotal
        '
        Me.grandtotal.AutoSize = True
        Me.grandtotal.Location = New System.Drawing.Point(275, 376)
        Me.grandtotal.Name = "grandtotal"
        Me.grandtotal.Size = New System.Drawing.Size(0, 13)
        Me.grandtotal.TabIndex = 15
        Me.grandtotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdbaru
        '
        Me.cmdbaru.Location = New System.Drawing.Point(34, 376)
        Me.cmdbaru.Name = "cmdbaru"
        Me.cmdbaru.Size = New System.Drawing.Size(106, 41)
        Me.cmdbaru.TabIndex = 16
        Me.cmdbaru.Text = "Baru"
        Me.cmdbaru.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 429)
        Me.Controls.Add(Me.cmdbaru)
        Me.Controls.Add(Me.grandtotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.listview1)
        Me.Controls.Add(Me.cmdok)
        Me.Controls.Add(Me.Jml_beli)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Satuan)
        Me.Controls.Add(Me.nama_brg)
        Me.Controls.Add(Me.kd_brg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Penjualan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents kd_brg As System.Windows.Forms.TextBox
    Friend WithEvents nama_brg As System.Windows.Forms.TextBox
    Friend WithEvents Satuan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Stock As System.Windows.Forms.TextBox
    Friend WithEvents Jml_beli As System.Windows.Forms.TextBox
    Friend WithEvents cmdok As System.Windows.Forms.Button
    Friend WithEvents listview1 As System.Windows.Forms.ListView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents harga As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grandtotal As System.Windows.Forms.Label
    Friend WithEvents cmdbaru As System.Windows.Forms.Button

End Class
