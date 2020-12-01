Public Class Form2

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox2.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox2.Enabled = False
        TextBox2.Text = "0"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox1.Text = "0" Then
            MsgBox("Grand total tidak boleh kosong", vbOKOnly, "Perhatian")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "0" And RadioButton1.Checked = True Then
            MsgBox("Diskon tidak boleh 0%", vbOKOnly, "Perhatian")
            TextBox2.Focus()
            Exit Sub
        End If
        If Val(TextBox2.Text) > 100 Then
            MsgBox("Discount tidak boleh melebihi 100%", vbOKOnly, "Perhatian")
            TextBox2.Clear()
            TextBox2.Focus()
            Exit Sub
        End If
        If RadioButton1.Checked = True Then
            TextBox3.Text = Val(TextBox1.Text) - ((Val(TextBox1.Text) / 100) * Val(TextBox2.Text))
        Else
            TextBox3.Text = TextBox1.Text
        End If
    End Sub
End Class