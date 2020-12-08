Imports MySql.Data.MySqlClient

Public Class frmhapus

    Private Sub cmdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatal.Click
        txtnpm.Enabled = True
        txtnpm.Clear()
        txtnpm.Focus()
        txtnama.Clear()
        txtalamat.Clear()
        txtkota.Clear()
        cmdbatal.Enabled = False
        cmdhapus.Enabled = False
        cmbagama.Text = ""
    End Sub

    Private Sub txtnpm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnpm.TextChanged
        Dim panjang As Byte
        panjang = Len(txtnpm.Text)
        If panjang < 5 Then
            Exit Sub
        End If

        Call koneksi()
        Try
            Dim str As String
            str = "select * from mahasiswa where npm = '" & txtnpm.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtnama.Text = rd.Item("nama")
                txtalamat.Text = rd.Item("alamat")
                txtkota.Text = rd.Item("kota")
                cmbagama.Text = rd.Item("agama")
                If rd.Item("jeniskelamin") = "L" Then
                    radiolaki.Checked = True
                Else
                    radioperempuan.Checked = True
                End If
            Else
                MsgBox("Data tidak ditemukan", vbOKOnly, "Perhatian")
                txtnpm.Clear()
                txtnpm.Focus()
            End If
        Catch ex As Exception

        End Try
        conn.Close()
        cmdhapus.Enabled = True
        cmdbatal.Enabled = True
    End Sub

    Private Sub cmdkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdkeluar.Click
        Me.Close()
    End Sub

    Private Sub cmdhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdhapus.Click
        Dim x
        x = MsgBox("yakin akan dihapus", vbOKCancel, "Perhatian")
        If x = vbCancel Then
            Exit Sub
        End If
        Call koneksi()
        Try
            Dim str As String
            str = "delete from mahasiswa where npm = '" & txtnpm.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
        txtnpm.Enabled = True
        txtnpm.Clear()
        txtnpm.Focus()
        txtnama.Clear()
        txtalamat.Clear()
        txtkota.Clear()
        cmdbatal.Enabled = False
        cmdhapus.Enabled = False
        cmbagama.Text = ""
    End Sub

    Private Sub frmhapus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdbatal.Enabled = False
        cmdhapus.Enabled = False
    End Sub
End Class