'Nama  : Isep Lutpi Nur
'Npm   : 2113191079
'Prodi : Teknik Informatika / A2
Public Class Form1
    Private Sub cbMakNasiGoreng_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMakNasiGoreng.CheckedChanged
        captureTotal()
    End Sub

    Private Sub cbMakNasiRamen_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMakNasiRamen.CheckedChanged
        captureTotal()
    End Sub

    Private Sub cbMakNasiRemes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMakNasiRemes.CheckedChanged
        captureTotal()
    End Sub

    Private Sub cbMakNasiUduk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMakNasiUduk.CheckedChanged
        captureTotal()
    End Sub

    Private Sub cbMinAirMineral_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMinAirMineral.CheckedChanged
        captureTotal()
    End Sub

    Private Sub cbMinEsCampur_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMinEsCampur.CheckedChanged
        captureTotal()
    End Sub

    Private Sub cbMinEsJuice_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMinEsJuice.CheckedChanged
        captureTotal()
    End Sub

    Private Sub cbMinTehManis_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMinTehManis.CheckedChanged
        captureTotal()
    End Sub

    Private Sub btnGtOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGtOk.Click
        Dim total As Double = Val(tbTotal.Text)
        If rbGtDisYa.Checked Then
            total = total - ((total / 100) * Val(tbGtDisValue.Text))
        End If
        tbGtTotalAll.Text = total
    End Sub

    Private Sub tbGtDisValue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbGtDisValue.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tbGtDisValue_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbGtDisValue.TextChanged
        If Val(tbGtDisValue.Text) > 100 Then
            MsgBox("Diskon tidak boleh lebih dari 100%", vbOKOnly, "Peringatan")
            tbGtDisValue.Text = ""
            tbGtDisValue.Focus()
        End If
    End Sub


    Private Sub rbGtDisTidak_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbGtDisTidak.CheckedChanged
        cekVisibleDiscount()
    End Sub

    Private Sub rbGtDisYa_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbGtDisYa.CheckedChanged
        cekVisibleDiscount()
    End Sub

    Sub captureTotal()
        Dim totalMinuman As Integer = 0
        Dim totalMakanan As Integer = 0

        If cbMakNasiGoreng.Checked Then
            totalMakanan = totalMakanan + 12000
        End If
        If cbMakNasiRamen.Checked Then
            totalMakanan = totalMakanan + 17000
        End If
        If cbMakNasiRemes.Checked Then
            totalMakanan = totalMakanan + 15000
        End If
        If cbMakNasiUduk.Checked Then
            totalMakanan = totalMakanan + 10000
        End If
        tbMakTotal.Text = totalMakanan

        If cbMinTehManis.Checked Then
            totalMinuman = totalMinuman + 5000
        End If
        If cbMinEsCampur.Checked Then
            totalMinuman = totalMinuman + 8000
        End If
        If cbMinEsJuice.Checked Then
            totalMinuman = totalMinuman + 7000
        End If
        If cbMinAirMineral.Checked Then
            totalMinuman = totalMinuman + 4000
        End If
        tbMinTotal.Text = totalMinuman

        tbTotal.Text = Val(tbMakTotal.Text) + Val(tbMinTotal.Text)
    End Sub

    Sub cekVisibleDiscount()
        If rbGtDisYa.Checked Then
            tbGtDisValue.Enabled = True
        Else
            tbGtDisValue.Enabled = False
        End If
    End Sub
End Class
