Public Class Form1

    Private Sub btnTentukan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTentukan.Click
        Dim tugas As Double = 0.2
        Dim uts As Double = 0.3
        Dim uas As Double = 0.5

        Dim nilaiTugas As Double = tbInpNilaiTugas.Text * tugas
        Dim nilaiUts As Double = tbInpNilaiUts.Text * uts
        Dim nilaiUas As Double = tbInpNilaiUas.Text * uas
        Dim total As Double = nilaiTugas + nilaiUts + nilaiUas
        Dim status As String

        If total >= 75 Then
            status = "lulus"
        Else
            status = "Tidak Lulus"
        End If

        tbOutNama.Text = tbInpNama.Text
        tbOutNilaiTugas.Text = tbInpNilaiTugas.Text & " x " & (tugas * 100) & "% = " & nilaiTugas
        tbOutNilaiUts.Text = tbInpNilaiUts.Text & " x " & (uts * 100) & "% = " & nilaiUts
        tbOutNilaiUas.Text = tbInpNilaiUas.Text & " x " & (uas * 100) & "% = " & nilaiUas
        tbOutTotal.Text = total
        tbOutStatus.Text = status

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        tbInpNama.Text = ""
        tbInpNilaiTugas.Text = ""
        tbInpNilaiUts.Text = ""
        tbInpNilaiUas.Text = ""
        tbOutNama.Text = ""
        tbOutNilaiTugas.Text = ""
        tbOutNilaiUts.Text = ""
        tbOutNilaiUas.Text = ""
        tbOutTotal.Text = ""
        tbOutStatus.Text = ""
    End Sub
End Class
