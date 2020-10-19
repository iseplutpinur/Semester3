<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SurveyBuahTerEnakDiTokoIstanaBuah
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbNanas = New System.Windows.Forms.RadioButton()
        Me.rbMangga = New System.Windows.Forms.RadioButton()
        Me.rbJeruk = New System.Windows.Forms.RadioButton()
        Me.rbMelon = New System.Windows.Forms.RadioButton()
        Me.rbSemangka = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbNamaBuah = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(23, 269)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(189, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Survey Buah Ter Enak"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Di Toko Istana Buah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Manakah Buah Ter Enak ?"
        '
        'rbNanas
        '
        Me.rbNanas.AutoSize = True
        Me.rbNanas.Checked = True
        Me.rbNanas.Location = New System.Drawing.Point(30, 129)
        Me.rbNanas.Name = "rbNanas"
        Me.rbNanas.Size = New System.Drawing.Size(56, 17)
        Me.rbNanas.TabIndex = 4
        Me.rbNanas.TabStop = True
        Me.rbNanas.Text = "Nanas"
        Me.rbNanas.UseVisualStyleBackColor = True
        '
        'rbMangga
        '
        Me.rbMangga.AutoSize = True
        Me.rbMangga.Location = New System.Drawing.Point(30, 154)
        Me.rbMangga.Name = "rbMangga"
        Me.rbMangga.Size = New System.Drawing.Size(64, 17)
        Me.rbMangga.TabIndex = 5
        Me.rbMangga.TabStop = True
        Me.rbMangga.Text = "Mangga"
        Me.rbMangga.UseVisualStyleBackColor = True
        '
        'rbJeruk
        '
        Me.rbJeruk.AutoSize = True
        Me.rbJeruk.Location = New System.Drawing.Point(30, 179)
        Me.rbJeruk.Name = "rbJeruk"
        Me.rbJeruk.Size = New System.Drawing.Size(51, 17)
        Me.rbJeruk.TabIndex = 6
        Me.rbJeruk.TabStop = True
        Me.rbJeruk.Text = "Jeruk"
        Me.rbJeruk.UseVisualStyleBackColor = True
        '
        'rbMelon
        '
        Me.rbMelon.AutoSize = True
        Me.rbMelon.Location = New System.Drawing.Point(30, 204)
        Me.rbMelon.Name = "rbMelon"
        Me.rbMelon.Size = New System.Drawing.Size(54, 17)
        Me.rbMelon.TabIndex = 7
        Me.rbMelon.TabStop = True
        Me.rbMelon.Text = "Melon"
        Me.rbMelon.UseVisualStyleBackColor = True
        '
        'rbSemangka
        '
        Me.rbSemangka.AutoSize = True
        Me.rbSemangka.Location = New System.Drawing.Point(30, 229)
        Me.rbSemangka.Name = "rbSemangka"
        Me.rbSemangka.Size = New System.Drawing.Size(76, 17)
        Me.rbSemangka.TabIndex = 8
        Me.rbSemangka.TabStop = True
        Me.rbSemangka.Text = "Semangka"
        Me.rbSemangka.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Buah Pilihan Anda Adalah:"
        '
        'LbNamaBuah
        '
        Me.LbNamaBuah.AutoSize = True
        Me.LbNamaBuah.ForeColor = System.Drawing.Color.Red
        Me.LbNamaBuah.Location = New System.Drawing.Point(223, 129)
        Me.LbNamaBuah.Name = "LbNamaBuah"
        Me.LbNamaBuah.Size = New System.Drawing.Size(75, 13)
        Me.LbNamaBuah.TabIndex = 10
        Me.LbNamaBuah.Text = "<Nama Buah>"
        '
        'SurveyBuahTerEnakDiTokoIstanaBuah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 307)
        Me.Controls.Add(Me.LbNamaBuah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbSemangka)
        Me.Controls.Add(Me.rbMelon)
        Me.Controls.Add(Me.rbJeruk)
        Me.Controls.Add(Me.rbMangga)
        Me.Controls.Add(Me.rbNanas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "SurveyBuahTerEnakDiTokoIstanaBuah"
        Me.Text = "Survey Buah Ter Enak"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbNanas As System.Windows.Forms.RadioButton
    Friend WithEvents rbMangga As System.Windows.Forms.RadioButton
    Friend WithEvents rbJeruk As System.Windows.Forms.RadioButton
    Friend WithEvents rbMelon As System.Windows.Forms.RadioButton
    Friend WithEvents rbSemangka As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LbNamaBuah As System.Windows.Forms.Label
End Class
