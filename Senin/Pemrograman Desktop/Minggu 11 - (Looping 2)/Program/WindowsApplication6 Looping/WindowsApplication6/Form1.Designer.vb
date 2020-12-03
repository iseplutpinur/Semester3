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
        Me.txtangka = New System.Windows.Forms.TextBox()
        Me.cmdpangkat = New System.Windows.Forms.Button()
        Me.cmdfibo = New System.Windows.Forms.Button()
        Me.cmdpangkatfibo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Masukan Angka "
        '
        'txtangka
        '
        Me.txtangka.Location = New System.Drawing.Point(139, 32)
        Me.txtangka.Name = "txtangka"
        Me.txtangka.Size = New System.Drawing.Size(100, 20)
        Me.txtangka.TabIndex = 1
        '
        'cmdpangkat
        '
        Me.cmdpangkat.Location = New System.Drawing.Point(48, 79)
        Me.cmdpangkat.Name = "cmdpangkat"
        Me.cmdpangkat.Size = New System.Drawing.Size(85, 26)
        Me.cmdpangkat.TabIndex = 2
        Me.cmdpangkat.Text = "Pangkat"
        Me.cmdpangkat.UseVisualStyleBackColor = True
        '
        'cmdfibo
        '
        Me.cmdfibo.Location = New System.Drawing.Point(149, 79)
        Me.cmdfibo.Name = "cmdfibo"
        Me.cmdfibo.Size = New System.Drawing.Size(90, 25)
        Me.cmdfibo.TabIndex = 3
        Me.cmdfibo.Text = "Faktorial"
        Me.cmdfibo.UseVisualStyleBackColor = True
        '
        'cmdpangkatfibo
        '
        Me.cmdpangkatfibo.Location = New System.Drawing.Point(48, 121)
        Me.cmdpangkatfibo.Name = "cmdpangkatfibo"
        Me.cmdpangkatfibo.Size = New System.Drawing.Size(190, 25)
        Me.cmdpangkatfibo.TabIndex = 4
        Me.cmdpangkatfibo.Text = "Pangkat dan Faktorial"
        Me.cmdpangkatfibo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 227)
        Me.Controls.Add(Me.cmdpangkatfibo)
        Me.Controls.Add(Me.cmdfibo)
        Me.Controls.Add(Me.cmdpangkat)
        Me.Controls.Add(Me.txtangka)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pangkat Dan Faktorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtangka As System.Windows.Forms.TextBox
    Friend WithEvents cmdpangkat As System.Windows.Forms.Button
    Friend WithEvents cmdfibo As System.Windows.Forms.Button
    Friend WithEvents cmdpangkatfibo As System.Windows.Forms.Button

End Class
