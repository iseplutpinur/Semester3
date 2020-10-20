Public Class Form2

    Private Sub btnfullname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfullname.Click
        txtfullname.Text = txtfirstname.Text + " " + txtmidlename.Text + " " + txtlastname.Text
    End Sub
End Class