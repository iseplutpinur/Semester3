Public Class SurveyBuahTerEnakDiTokoIstanaBuah

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        If rbNanas.Checked = True Then
            LbNamaBuah.Text = rbNanas.Text
        ElseIf rbMangga.Checked = True Then
            LbNamaBuah.Text = rbMangga.Text
        ElseIf rbJeruk.Checked = True Then
            LbNamaBuah.Text = rbJeruk.Text
        ElseIf rbMelon.Checked = True Then
            LbNamaBuah.Text = rbMelon.Text
        ElseIf rbSemangka.Checked = True Then
            LbNamaBuah.Text = rbSemangka.Text
        End If

    End Sub
End Class