Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tugas As Double = 0.2
        Dim uts As Double = 0.3
        Dim uas As Double = 0.5

        Dim nilaiTugas As Double = tbInpNilaiTugas.Text * tugas
        Dim nilaiUts As Double = tbInpNilaiUts.Text * uts
        Dim nilaiUas As Double = tbInpNilaiUas.Text * uas
        Dim total As Double = nilaiTugas + nilaiUts + nilaiUas
        Dim status As String = ""

        If total >= 75 Then
            status = "Lulus"
        Else
            status = "Tidak Lulus"
        End If

        tbOutNama.Text = tbInpNama.Text
        tbOutNilaiTugas.Text = tbInpNilaiTugas.Text & " X " & (100 * tugas) & "% = " & nilaiTugas
        tbOutNilaiUts.Text = tbInpNilaiUts.Text & " X " & (100 * uts) & "% = " & nilaiUts
        tbOutNilaiUas.Text = tbInpNilaiUas.Text & " X " & (100 * uas) & "% = " & nilaiUas
        tbOutStatus.Text = status
        tbOutTotal.Text = total


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tbOutNama.Text = ""
        tbOutNilaiTugas.Text = ""
        tbOutNilaiUts.Text = ""
        tbOutNilaiUas.Text = ""
        tbOutStatus.Text = ""
        tbOutTotal.Text = ""

        tbInpNama.Text = ""
        tbInpNilaiTugas.Text = ""
        tbInpNilaiUts.Text = ""
        tbInpNilaiUas.Text = ""
    End Sub
End Class
