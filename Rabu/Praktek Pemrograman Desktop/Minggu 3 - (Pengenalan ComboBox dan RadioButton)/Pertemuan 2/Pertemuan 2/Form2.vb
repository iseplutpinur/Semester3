Public Class Form2

    Private Sub btnhitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhitung.Click

        If txtbil1.Text = "" Then
            MsgBox("Bilangan Pertama diisi", vbOKOnly, "Perhatian")
            txtbil1.Focus()
            Exit Sub
        End If

        If txtbil2.Text = "" Then
            MsgBox("Bilangan kedua harus diisi", vbOKOnly, "Perhatian")
            txtbil2.Focus()
            Exit Sub
        End If

        If rdojumlah.Checked = True Then
            txthasil.Text = Val(txtbil1.Text) + Val(txtbil2.Text)
        ElseIf rdokali.Checked = True Then
            txthasil.Text = Val(txtbil1.Text) * Val(txtbil2.Text)
        Else
            txthasil.Text = Val(txtbil1.Text) - Val(txtbil2.Text)
        End If
    End Sub

    Private Sub txtbil1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbil1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtbil2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbil2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdojumlah.Checked = True
    End Sub

    Private Sub btnbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaru.Click
        txtbil1.Clear()
        txtbil2.Clear()
        rdojumlah.Checked = True
        txthasil.Clear()
        txtbil1.Focus()
    End Sub
End Class