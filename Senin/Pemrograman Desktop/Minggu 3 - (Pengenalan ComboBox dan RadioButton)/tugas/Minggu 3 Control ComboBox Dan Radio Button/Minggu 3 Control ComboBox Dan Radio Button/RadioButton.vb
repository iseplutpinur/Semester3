Public Class frRadioButton

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If rbJeruk.Checked = True Then
            lbNamaBuah.Text = rbJeruk.Text
        ElseIf rbMangga.Checked = True Then
            lbNamaBuah.Text = rbMangga.Text
        ElseIf rbNanas.Checked = True Then
            lbNamaBuah.Text = rbNanas.Text
        ElseIf rbMelon.Checked = True Then
            lbNamaBuah.Text = rbMelon.Text
        ElseIf rbSemangka.Checked = True Then
            lbNamaBuah.Text = rbSemangka.Text
        End If
    End Sub
End Class