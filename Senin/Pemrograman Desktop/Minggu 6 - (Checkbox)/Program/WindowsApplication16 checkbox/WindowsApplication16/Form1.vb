Public Class Form1

   
   

    Private Sub cmdbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbaru.Click
        chknaskun.Checked = False
        chknaskuc.Checked = False
        chknasram.Checked = False
        chknasgor.Checked = False
        chknasud.Checked = False
        chknaskun.Checked = False
        txttotal.Text = "0"
    End Sub

    Private Sub chknaskun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknaskun.CheckedChanged
        If chknaskun.Checked = True Then
            txttotal.Text = Val(txttotal.Text) + 10000
        Else
            txttotal.Text = Val(txttotal.Text) - 10000
        End If
    End Sub

    Private Sub chknasgor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknasgor.CheckedChanged
        If chknasgor.Checked = True Then
            txttotal.Text = Val(txttotal.Text) + 12000
        Else
            txttotal.Text = Val(txttotal.Text) - 12000
        End If
    End Sub

    Private Sub chknasud_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknasud.CheckedChanged
        If chknasud.Checked = True Then
            txttotal.Text = Val(txttotal.Text) + 15000
        Else
            txttotal.Text = Val(txttotal.Text) - 15000
        End If
    End Sub

    Private Sub chknasram_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknasram.CheckedChanged
        If chknasram.Checked = True Then
            txttotal.Text = Val(txttotal.Text) + 20000
        Else
            txttotal.Text = Val(txttotal.Text) - 20000
        End If
    End Sub

    Private Sub chknaskuc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknaskuc.CheckedChanged
        If chknaskuc.Checked = True Then
            txttotal.Text = Val(txttotal.Text) + 25000
        Else
            txttotal.Text = Val(txttotal.Text) - 25000
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
