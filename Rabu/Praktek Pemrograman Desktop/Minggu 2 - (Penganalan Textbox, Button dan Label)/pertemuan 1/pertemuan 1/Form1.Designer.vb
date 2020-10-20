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
        Me.txtbil1 = New System.Windows.Forms.TextBox()
        Me.txtbil2 = New System.Windows.Forms.TextBox()
        Me.btnjumlah = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.btnkali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bilangan Pertama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bilangan Kedua"
        '
        'txtbil1
        '
        Me.txtbil1.Location = New System.Drawing.Point(136, 29)
        Me.txtbil1.Name = "txtbil1"
        Me.txtbil1.Size = New System.Drawing.Size(89, 20)
        Me.txtbil1.TabIndex = 2
        '
        'txtbil2
        '
        Me.txtbil2.Location = New System.Drawing.Point(136, 59)
        Me.txtbil2.Name = "txtbil2"
        Me.txtbil2.Size = New System.Drawing.Size(88, 20)
        Me.txtbil2.TabIndex = 3
        '
        'btnjumlah
        '
        Me.btnjumlah.Location = New System.Drawing.Point(243, 30)
        Me.btnjumlah.Name = "btnjumlah"
        Me.btnjumlah.Size = New System.Drawing.Size(66, 35)
        Me.btnjumlah.TabIndex = 4
        Me.btnjumlah.Text = "Jumlahkan"
        Me.btnjumlah.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasil"
        '
        'txthasil
        '
        Me.txthasil.Location = New System.Drawing.Point(136, 92)
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(87, 20)
        Me.txthasil.TabIndex = 6
        '
        'btnkali
        '
        Me.btnkali.Location = New System.Drawing.Point(245, 78)
        Me.btnkali.Name = "btnkali"
        Me.btnkali.Size = New System.Drawing.Size(63, 33)
        Me.btnkali.TabIndex = 7
        Me.btnkali.Text = "Kalikan"
        Me.btnkali.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 129)
        Me.Controls.Add(Me.btnkali)
        Me.Controls.Add(Me.txthasil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnjumlah)
        Me.Controls.Add(Me.txtbil2)
        Me.Controls.Add(Me.txtbil1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Matematika"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbil1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbil2 As System.Windows.Forms.TextBox
    Friend WithEvents btnjumlah As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txthasil As System.Windows.Forms.TextBox
    Friend WithEvents btnkali As System.Windows.Forms.Button

End Class
