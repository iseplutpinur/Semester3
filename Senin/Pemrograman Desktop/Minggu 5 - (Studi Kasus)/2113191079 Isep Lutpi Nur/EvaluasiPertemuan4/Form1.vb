'Nama : Isep Lutpi Nur
'NPM  : 2113191079
Public Class Form1

    Private Sub tbNPM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbNPM.KeyPress
        If Not (((e.KeyChar >= "0" And e.KeyChar <= "9") And Len(tbNPM.Text) < 10) Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tbNPM_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbNPM.TextChanged
        If Len(tbNPM.Text) = 10 Then
            tbNama.Enabled = True
            tbAlamat.Enabled = True
            cbAgama.Enabled = True
            rbLakiLaki.Enabled = True
            rbPerempuan.Enabled = True
            btnBaru.Enabled = True
            btnOk.Enabled = True
        Else
            tbNama.Enabled = False
            tbAlamat.Enabled = False
            cbAgama.Enabled = False
            rbLakiLaki.Enabled = False
            rbPerempuan.Enabled = False
            btnBaru.Enabled = False
            btnOk.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cbAgama.Items.Add("Islam")
        cbAgama.Items.Add("Budha")
        cbAgama.Items.Add("Kristen")
        cbAgama.Items.Add("Hindu")
        cbAgama.SelectedIndex = 0
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If tbNama.Text = "" Then
            MsgBox("Nama harus di isi..!", vbOKOnly, "Peringatan")
            tbNama.Focus()
        ElseIf tbAlamat.Text = "" Then
            MsgBox("Alamat harus di isi..!", vbOKOnly, "Peringatan")
            tbAlamat.Focus()
        Else
            Dim jenisKelamin As String = ""
            If rbLakiLaki.Checked Then
                jenisKelamin = rbLakiLaki.Text
            ElseIf rbPerempuan.Checked Then
                jenisKelamin = rbPerempuan.Text
            End If

            tbOutput.Text = "Nama saya " & tbNama.Text &
                ", NPM saya " & tbNPM.Text &
                ", Rumah saya di " & tbAlamat.Text &
                ", Agama saya " & cbAgama.Text &
                ", dan jenis kelamin saya " & jenisKelamin
            btnOk.Enabled = False
        End If
    End Sub

    Private Sub btnBaru_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBaru.Click
        tbNama.Enabled = False
        tbAlamat.Enabled = False
        cbAgama.Enabled = False
        rbLakiLaki.Enabled = False
        rbPerempuan.Enabled = False
        btnBaru.Enabled = False
        btnOk.Enabled = False

        tbNPM.Text = ""
        tbNama.Text = ""
        tbAlamat.Text = ""

        rbLakiLaki.Checked = True
        rbPerempuan.Checked = False
        cbAgama.SelectedIndex = 0
        tbOutput.Text = ""

        tbNPM.Focus()
    End Sub

    Private Sub cbAgama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbAgama.KeyPress
        e.Handled = True
    End Sub
End Class
