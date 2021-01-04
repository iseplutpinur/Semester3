Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        Const V As String = "dd/MM/yyy"
        DateTimePicker1.CustomFormat = V

        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = ColorTranslator.FromHtml("#0275d8")
        Button1.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#0275d8")


        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button2.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#0275d8")
        Button2.BackColor = ColorTranslator.FromHtml("#0275d8")
    End Sub

    Private Sub Luncurkan()
        MsgBox("NPM harus di isi", vbOKOnly + MessageBoxIcon.Error, "Peringatan")
        MsgBox("NPM harus di isi angka saja", vbOKOnly + MessageBoxIcon.Error, "Peringatan")
        MsgBox("NPM harus dari 10 dgit", vbOKOnly + MessageBoxIcon.Information, "Perhatian")
        MsgBox("Nama Lengkap harus di isi", vbOKOnly + MessageBoxIcon.Error, "Peringatan")
        MsgBox("Nama Lengkap minimal 3 dgit", vbOKOnly + MessageBoxIcon.Information, "Perhatian")
        MsgBox("Nama Lengkap Harus berupa huruf tidak boleh simbol atau angka kecuali min, titik, koma dan tanda petik tunggal ",
               vbOKOnly + MessageBoxIcon.Error, "Peringatan")
        MsgBox("Tempat Lahir harus di isi", vbOKOnly + MessageBoxIcon.Error, "Peringatan")
        MsgBox("Tempat Lahir minimal 3 dgit", vbOKOnly + MessageBoxIcon.Information, "Perhatian")
        MsgBox("Tempat Lahir Harus berupa huruf tidak boleh simbol atau angka kecuali min, titik, koma dan tanda petik tunggal ",
               vbOKOnly + MessageBoxIcon.Error, "Peringatan")
        MsgBox("Tanggal Lahir harus di isi", vbOKOnly + MessageBoxIcon.Error, "Peringatan")
        MsgBox("Alamat harus di isi", vbOKOnly + MessageBoxIcon.Error, "Peringatan")
        MsgBox("Alamat minimal 3 dgit", vbOKOnly + MessageBoxIcon.Information, "Perhatian")
        MsgBox("Alamat Harus berupa huruf tidak boleh simbol atau angka kecuali min, titik, koma dan tanda petik tunggal ",
               vbOKOnly + MessageBoxIcon.Error, "Peringatan")
        MsgBox("Jenis Kelamin Harus di pilih", vbOKOnly + MessageBoxIcon.Error, "Peringatan")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Luncurkan()
    End Sub
End Class
