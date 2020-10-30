Public Class Form1

    Private Sub btnTentukan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTentukan.Click
        If tbBeratBadan.Text = "0" Or tbBeratBadan.Text < "1" Then
            MsgBox("Berat Badan harus di isi..!", vbOKOnly, "Peringatan")
            tbBeratBadan.Focus()
        ElseIf tbTinggiBadan.Text = "0" Or tbTinggiBadan.Text < "1" Then
            MsgBox("Tinggi Badan harus di isi..!", vbOKOnly, "Peringatan")
            tbTinggiBadan.Focus()

        Else
            Dim status As String = ""
            Dim tinggi As Integer = Val(tbTinggiBadan.Text)
            Dim berat As Integer = Val(tbBeratBadan.Text)
            Dim nilai As Double = berat / ((tinggi * tinggi) / 10000)
            If cbJenisKelamin.Text = "Pria" Then
                If nilai < 18 Then
                    status = "Kurus"
                ElseIf (nilai > 18 And nilai <= 25) Then
                    status = "Normal"
                ElseIf (nilai > 25 And nilai <= 27) Then
                    status = "Kegemukan"
                ElseIf nilai > 27 Then
                    status = "Obesitas"
                End If
            ElseIf cbJenisKelamin.Text = "Wanita" Then
                If nilai < 17 Then
                    status = "Kurus"
                ElseIf (nilai > 17 And nilai <= 24) Then
                    status = "Normal"
                ElseIf (nilai > 24 And nilai <= 27) Then
                    status = "Kegemukan"
                ElseIf nilai > 27 Then
                    status = "Obesitas"
                End If
            End If

            tbStatus.Text = status
            tbNilai.Text = FormatNumber(nilai, 2)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbJenisKelamin.Items.Add("Pria")
        cbJenisKelamin.Items.Add("Wanita")

        cbJenisKelamin.SelectedIndex = 0
    End Sub

    Private Sub cbJenisKelamin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbJenisKelamin.KeyPress
        e.Handled = True
    End Sub

    Private Sub tbBeratBadan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbBeratBadan.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub


    Private Sub tbTinggiBadan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbTinggiBadan.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class
