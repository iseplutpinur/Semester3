Public Class Form1

    Private Sub cmdpangkat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpangkat.Click
        Dim vhasil As Long
        vhasil = Val(txtangka.Text)
        For i = 1 To Val(txtangka.Text) - 1
            vhasil = vhasil * Val(txtangka.Text)
        Next
        MsgBox("Hasil " & txtangka.Text & " Pangkat " & txtangka.Text & " adalah : " & vhasil, vbOKOnly, " For .. Next")
    End Sub

    Private Sub cmdfibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfibo.Click
        Dim i, vhasil As Integer
        i = 1
        vhasil = 1
        Do While i <= Val(txtangka.Text)
            vhasil = vhasil * i
            i = i + 1
        Loop
        MsgBox("Hasil " & txtangka.Text & " Faktorial adalah : " & vhasil, vbOKOnly, "Do While .. Loop")
    End Sub

    Private Sub cmdpangkatfibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpangkatfibo.Click
        Dim vhasil1, vhasil2, i As Long
        vhasil1 = Val(txtangka.Text)
        For i = 1 To Val(txtangka.Text) - 1
            vhasil1 = vhasil1 * Val(txtangka.Text)
        Next

        i = 1
        vhasil2 = 1
        Do While i <= Val(txtangka.Text)
            vhasil2 = vhasil2 * i
            i = i + 1
        Loop
        MsgBox("Hasil " & txtangka.Text & " Pangkat adalah : " & vhasil1 & _
               " Faktorial Adalah : " & vhasil2, vbOKOnly, "Perhatian")
    End Sub
End Class
