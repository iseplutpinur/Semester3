<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtmidlename = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.btnfullname = New System.Windows.Forms.Button()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Midle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(130, 32)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(86, 20)
        Me.txtfirstname.TabIndex = 3
        '
        'txtmidlename
        '
        Me.txtmidlename.Location = New System.Drawing.Point(131, 64)
        Me.txtmidlename.Name = "txtmidlename"
        Me.txtmidlename.Size = New System.Drawing.Size(84, 20)
        Me.txtmidlename.TabIndex = 4
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(130, 97)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(84, 20)
        Me.txtlastname.TabIndex = 5
        '
        'btnfullname
        '
        Me.btnfullname.Location = New System.Drawing.Point(232, 30)
        Me.btnfullname.Name = "btnfullname"
        Me.btnfullname.Size = New System.Drawing.Size(68, 87)
        Me.btnfullname.TabIndex = 6
        Me.btnfullname.Text = "Full Name"
        Me.btnfullname.UseVisualStyleBackColor = True
        '
        'txtfullname
        '
        Me.txtfullname.Location = New System.Drawing.Point(130, 132)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(170, 20)
        Me.txtfullname.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Full Name"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 180)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.btnfullname)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtmidlename)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Aplikasi Full Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtmidlename As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents btnfullname As System.Windows.Forms.Button
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
