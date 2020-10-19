Public Class frTokoIstanaBuah

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click

        If tbJumlahBeli.Text = "" Then
            MsgBox("Jumlah Beli Harus Di isi", vbOKOnly, "Peringatan")
        Else
            tbTotalHarga.Text = Val(tbHargaBuah.Text) * Val(tbJumlahBeli.Text)
        End If
    End Sub

    Private Sub frTokoIstanaBuah_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cbNamaBuah.Items.Add("Nanas")
        cbNamaBuah.Items.Add("Mangga")
        cbNamaBuah.Items.Add("Jeruk")
        cbNamaBuah.Items.Add("Semangka")
        cbNamaBuah.Items.Add("Melon")

        cbNamaBuah.SelectedIndex = 0

        If cbNamaBuah.Text = "Nanas" Then
            tbHargaBuah.Text = "10000"
        ElseIf cbNamaBuah.Text = "Mangga" Then
            tbHargaBuah.Text = "15000"
        ElseIf cbNamaBuah.Text = "Jeruk" Then
            tbHargaBuah.Text = "5000"
        ElseIf cbNamaBuah.Text = "Semangka" Then
            tbHargaBuah.Text = "2000"
        ElseIf cbNamaBuah.Text = "Melon" Then
            tbHargaBuah.Text = "25000"
        End If

    End Sub

    Private Sub cbNamaBuah_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNamaBuah.DropDownClosed

        If cbNamaBuah.Text = "Nanas" Then
            tbHargaBuah.Text = "10000"
        ElseIf cbNamaBuah.Text = "Mangga" Then
            tbHargaBuah.Text = "15000"
        ElseIf cbNamaBuah.Text = "Jeruk" Then
            tbHargaBuah.Text = "5000"
        ElseIf cbNamaBuah.Text = "Semangka" Then
            tbHargaBuah.Text = "2000"
        ElseIf cbNamaBuah.Text = "Melon" Then
            tbHargaBuah.Text = "25000"
        End If

    End Sub


    Private Sub cbNamaBuah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbNamaBuah.KeyPress
        e.Handled = True
    End Sub


    Private Sub tbJumlahBeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbJumlahBeli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class
