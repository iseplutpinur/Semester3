Public Class Form1

    Private Sub btnjumlah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnjumlah.Click
        txthasil.Text = Val(txtbil1.Text) + Val(txtbil2.Text)
    End Sub

    Private Sub btnkali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkali.Click
        txthasil.Text = Val(txtbil1.Text) * Val(txtbil2.Text)
    End Sub
End Class
