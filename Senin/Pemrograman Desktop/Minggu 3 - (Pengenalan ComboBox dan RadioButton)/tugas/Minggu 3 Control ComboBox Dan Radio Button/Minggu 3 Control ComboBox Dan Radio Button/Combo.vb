Public Class frComboBox

    Private Sub frComboBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbNamaBuah.Items.Add("Nanas")
        cbNamaBuah.Items.Add("Mangga")
        cbNamaBuah.Items.Add("Jeruk")
        cbNamaBuah.Items.Add("Semangka")
        cbNamaBuah.Items.Add("Melon")

        cbNamaBuah.SelectedIndex = 0
    End Sub

    Private Sub cbNamaBuah_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNamaBuah.TextChanged
        If cbNamaBuah.Text = "Nanas" Then
            tbHargaBuah.Text = "10000"
        ElseIf cbNamaBuah.Text = "Mangga" Then
            tbHargaBuah.Text = "15000"
        ElseIf cbNamaBuah.Text = "Jeruk" Then
            tbHargaBuah.Text = "5000"
        ElseIf cbNamaBuah.Text = "Semangka" Then
            tbHargaBuah.Text = "30000"
        ElseIf cbNamaBuah.Text = "Melon" Then
            tbHargaBuah.Text = "50000"
        End If
    End Sub

    Private Sub btnHitung_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        If (tbJumlahBeli.Text = "" Or tbJumlahBeli.Text < "1") Then
            MsgBox("Masukan Jumlah Beli")
        Else
            tbTotalHarga.Text = Val(tbHargaBuah.Text) * Val(tbJumlahBeli.Text)
        End If
    End Sub

    Private Sub tbJumlahBeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbJumlahBeli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class
