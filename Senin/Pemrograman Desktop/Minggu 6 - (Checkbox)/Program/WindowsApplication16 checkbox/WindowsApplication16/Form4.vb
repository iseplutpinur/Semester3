Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Barang harus diisi lengkap", vbOKOnly, "Perhatian")
            TextBox1.Focus()
        End If
        TextBox4.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox4.Text = "" Then
            MsgBox("barang belum diisi", vbOKOnly, "Perhatian")
            Exit Sub
        End If
        If Val(TextBox5.Text) > 100 Then
            MsgBox("discount tidak boleh diatas 100", vbOKOnly, "Perhatian")
            TextBox5.Text = 0
            TextBox5.Focus()
            Exit Sub
        End If
        If Val(TextBox5.Text) <= 0 And RadioButton1.Checked = True Then
            MsgBox("discount tidak boleh 0", vbOKOnly, "Perhatian")
            TextBox5.Text = 0
            TextBox5.Focus()
            Exit Sub
        End If
        If RadioButton2.Checked = True Then
            TextBox6.Text = TextBox4.Text
        Else
            TextBox6.Text = Val(TextBox4.Text) - ((Val(TextBox4.Text) / 100) * Val(TextBox5.Text))
        End If


    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox5.Enabled = True
        TextBox5.Focus()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox5.Enabled = False
        TextBox5.Clear()
    End Sub
End Class