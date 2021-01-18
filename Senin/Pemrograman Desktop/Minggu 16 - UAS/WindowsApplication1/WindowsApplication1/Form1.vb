
Public Class Form1
    Dim npm(100) As String
    Dim nama(100) As String
    Dim nilai(100) As String
    Dim counter As Integer = 1

    Sub refreshTable()
        Dim totalA As Integer = 0
        Dim totalB As Integer = 0
        Dim totalC As Integer = 0
        Dim totalD As Integer = 0
        Dim totalE As Integer = 0

        nama(0) = "Isep Lutpi Nur"
        npm(0) = "2113191079"
        nilai(0) = "90"
        ListView1.Clear()
        ListView1.Columns.Add("No", 30, HorizontalAlignment.Left)
        ListView1.Columns.Add("NPM", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Nama", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Nilai", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("Mutu", 70, HorizontalAlignment.Left)
        ListView1.View = View.Details
        ListView1.GridLines = True

        Dim no As Integer = 1
        For i = 0 To counter - 1
            Dim isi(6) As String
            Dim itm As ListViewItem
            Dim cekMutuHasil As String = cekMutu(nilai(i))
            isi(0) = no
            isi(1) = npm(i)
            isi(2) = nama(i)
            isi(3) = nilai(i)
            isi(4) = cekMutuHasil
            itm = New ListViewItem(isi)
            ListView1.Items.Add(itm)
            no = no + 1
            If cekMutuHasil = "A" Then
                totalA += 1
            ElseIf cekMutuHasil = "B" Then
                totalB += 1
            ElseIf cekMutuHasil = "C" Then
                totalC += 1
            ElseIf cekMutuHasil = "D" Then
                totalD += 1
            ElseIf cekMutuHasil = "E" Then
                totalE += 1
            End If
        Next
        txtJmlA.Text = totalA
        txtJmlB.Text = totalB
        txtJmlC.Text = totalC
        txtJmlD.Text = totalD
        txtJmlE.Text = totalE
    End Sub

    Private Function cekMutu(ByVal mutu As String)
        Dim cek As Integer = mutu
        Dim hasil As String = ""
        If cek >= 90 And cek <= 100 Then
            hasil = "A"
        ElseIf cek >= 80 And cek < 90 Then
            hasil = "B"
        ElseIf cek >= 70 And cek < 80 Then
            hasil = "C"
        ElseIf cek >= 60 And cek < 70 Then
            hasil = "D"
        Else
            hasil = "E"
        End If
        cekMutu = hasil
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call refreshTable()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        nama(counter) = txtnama.Text
        npm(counter) = txtnpm.Text
        nilai(counter) = txtnilai.Text
        txtnama.Clear()
        txtnpm.Clear()
        txtnilai.Clear()
        txtnpm.Focus()
        counter += 1
        MsgBox("Data berhasil ditambahkan", vbOKOnly, "Perhatian")
        Call refreshTable()
    End Sub


    Private Sub txtnilai_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnilai.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtnpm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnpm.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class
