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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnpm = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtnilai = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtJmlA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtJmlB = New System.Windows.Forms.TextBox()
        Me.txtJmlC = New System.Windows.Forms.TextBox()
        Me.txtJmlD = New System.Windows.Forms.TextBox()
        Me.txtJmlE = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NPM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Mahasiswa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(26, 185)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(392, 97)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jumlah Mutu:"
        '
        'txtnpm
        '
        Me.txtnpm.Location = New System.Drawing.Point(129, 22)
        Me.txtnpm.Name = "txtnpm"
        Me.txtnpm.Size = New System.Drawing.Size(118, 20)
        Me.txtnpm.TabIndex = 5
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(129, 57)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(211, 20)
        Me.txtnama.TabIndex = 6
        '
        'txtnilai
        '
        Me.txtnilai.Location = New System.Drawing.Point(129, 93)
        Me.txtnilai.Name = "txtnilai"
        Me.txtnilai.Size = New System.Drawing.Size(71, 20)
        Me.txtnilai.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(343, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtJmlA
        '
        Me.txtJmlA.Location = New System.Drawing.Point(129, 305)
        Me.txtJmlA.Name = "txtJmlA"
        Me.txtJmlA.Size = New System.Drawing.Size(49, 20)
        Me.txtJmlA.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "A"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(109, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "B"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(109, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "C"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(199, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "D"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(200, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "E"
        '
        'txtJmlB
        '
        Me.txtJmlB.Location = New System.Drawing.Point(129, 332)
        Me.txtJmlB.Name = "txtJmlB"
        Me.txtJmlB.Size = New System.Drawing.Size(49, 20)
        Me.txtJmlB.TabIndex = 15
        '
        'txtJmlC
        '
        Me.txtJmlC.Location = New System.Drawing.Point(129, 365)
        Me.txtJmlC.Name = "txtJmlC"
        Me.txtJmlC.Size = New System.Drawing.Size(49, 20)
        Me.txtJmlC.TabIndex = 16
        '
        'txtJmlD
        '
        Me.txtJmlD.Location = New System.Drawing.Point(220, 305)
        Me.txtJmlD.Name = "txtJmlD"
        Me.txtJmlD.Size = New System.Drawing.Size(49, 20)
        Me.txtJmlD.TabIndex = 17
        '
        'txtJmlE
        '
        Me.txtJmlE.Location = New System.Drawing.Point(220, 335)
        Me.txtJmlE.Name = "txtJmlE"
        Me.txtJmlE.Size = New System.Drawing.Size(49, 20)
        Me.txtJmlE.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 416)
        Me.Controls.Add(Me.txtJmlE)
        Me.Controls.Add(Me.txtJmlD)
        Me.Controls.Add(Me.txtJmlC)
        Me.Controls.Add(Me.txtJmlB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtJmlA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnilai)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnpm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Rekapitulasi Nilai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnpm As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtnilai As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtJmlA As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtJmlB As System.Windows.Forms.TextBox
    Friend WithEvents txtJmlC As System.Windows.Forms.TextBox
    Friend WithEvents txtJmlD As System.Windows.Forms.TextBox
    Friend WithEvents txtJmlE As System.Windows.Forms.TextBox

End Class
