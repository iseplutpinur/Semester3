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
        Me.txtbil1 = New System.Windows.Forms.TextBox()
        Me.txtbil2 = New System.Windows.Forms.TextBox()
        Me.cmbpilihan = New System.Windows.Forms.ComboBox()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bilangan Pertama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bilangan Kedua"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pilihan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'txtbil1
        '
        Me.txtbil1.Location = New System.Drawing.Point(136, 29)
        Me.txtbil1.Name = "txtbil1"
        Me.txtbil1.Size = New System.Drawing.Size(105, 20)
        Me.txtbil1.TabIndex = 4
        '
        'txtbil2
        '
        Me.txtbil2.Location = New System.Drawing.Point(136, 67)
        Me.txtbil2.Name = "txtbil2"
        Me.txtbil2.Size = New System.Drawing.Size(104, 20)
        Me.txtbil2.TabIndex = 5
        '
        'cmbpilihan
        '
        Me.cmbpilihan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpilihan.FormattingEnabled = True
        Me.cmbpilihan.Location = New System.Drawing.Point(136, 103)
        Me.cmbpilihan.Name = "cmbpilihan"
        Me.cmbpilihan.Size = New System.Drawing.Size(103, 21)
        Me.cmbpilihan.TabIndex = 6
        '
        'txthasil
        '
        Me.txthasil.Enabled = False
        Me.txthasil.Location = New System.Drawing.Point(136, 135)
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(102, 20)
        Me.txthasil.TabIndex = 7
        '
        'btnhitung
        '
        Me.btnhitung.Location = New System.Drawing.Point(254, 103)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(67, 47)
        Me.btnhitung.TabIndex = 8
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 176)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.txthasil)
        Me.Controls.Add(Me.cmbpilihan)
        Me.Controls.Add(Me.txtbil2)
        Me.Controls.Add(Me.txtbil1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operasi Matematika"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtbil1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbil2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbpilihan As System.Windows.Forms.ComboBox
    Friend WithEvents txthasil As System.Windows.Forms.TextBox
    Friend WithEvents btnhitung As System.Windows.Forms.Button

End Class
