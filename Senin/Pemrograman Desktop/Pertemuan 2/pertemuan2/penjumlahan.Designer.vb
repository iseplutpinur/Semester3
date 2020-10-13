<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class penjumlahan
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
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.input1 = New System.Windows.Forms.TextBox()
        Me.input2 = New System.Windows.Forms.TextBox()
        Me.labelHasil = New System.Windows.Forms.Label()
        Me.outputHasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(250, 22)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 74)
        Me.btnHitung.TabIndex = 0
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(12, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(106, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Bilangan Pertama"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(12, 47)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(106, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Bilangan Pertama"
        '
        'input1
        '
        Me.input1.Location = New System.Drawing.Point(124, 22)
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(100, 20)
        Me.input1.TabIndex = 3
        '
        'input2
        '
        Me.input2.Location = New System.Drawing.Point(124, 48)
        Me.input2.Name = "input2"
        Me.input2.Size = New System.Drawing.Size(100, 20)
        Me.input2.TabIndex = 4
        '
        'labelHasil
        '
        Me.labelHasil.AutoSize = True
        Me.labelHasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHasil.Location = New System.Drawing.Point(13, 76)
        Me.labelHasil.Name = "labelHasil"
        Me.labelHasil.Size = New System.Drawing.Size(35, 13)
        Me.labelHasil.TabIndex = 5
        Me.labelHasil.Text = "Hasil"
        '
        'outputHasil
        '
        Me.outputHasil.Location = New System.Drawing.Point(125, 76)
        Me.outputHasil.Name = "outputHasil"
        Me.outputHasil.Size = New System.Drawing.Size(100, 20)
        Me.outputHasil.TabIndex = 6
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 111)
        Me.Controls.Add(Me.outputHasil)
        Me.Controls.Add(Me.labelHasil)
        Me.Controls.Add(Me.input2)
        Me.Controls.Add(Me.input1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnHitung)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operasi Penjumlahan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents input1 As System.Windows.Forms.TextBox
    Friend WithEvents input2 As System.Windows.Forms.TextBox
    Friend WithEvents labelHasil As System.Windows.Forms.Label
    Friend WithEvents outputHasil As System.Windows.Forms.TextBox

End Class
