Imports MySql.Data.MySqlClient

Public Class frmupdate

    Private Sub cmdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatal.Click
        txtnpm.Enabled = True
        txtnpm.Clear()
        txtnpm.Focus()
        txtnama.Clear()
        txtalamat.Clear()
        txtkota.Clear()
        txtnama.Enabled = False
        txtalamat.Enabled = False
        txtkota.Enabled = False
        cmbagama.Enabled = False
        cmdbatal.Enabled = False
        cmdupdate.Enabled = False
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
                txtnama.Enabled = True
                txtalamat.Enabled = True
                txtkota.Enabled = True
                cmbagama.Enabled = True
            Else
                MsgBox("Data tidak ditemukan", vbOKOnly, "Perhatian")
                txtnpm.Clear()
                txtnpm.Focus()
            End If
        Catch ex As Exception

        End Try
        conn.Close()
        cmdupdate.Enabled = True
        cmdbatal.Enabled = True
    End Sub

    Private Sub frmupdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdbatal.Enabled = False
        cmdupdate.Enabled = False
        cmbagama.Items.Add("ISLAM")
        cmbagama.Items.Add("KRISTEN")
        cmbagama.Items.Add("BUDHA")
        cmbagama.Items.Add("HINDU")
    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        Dim x
        x = MsgBox("yakin akan dirubah", vbOKCancel, "Perhatian")
        If x = vbCancel Then
            Exit Sub
        End If
        Call koneksi()
        Try
            Dim str As String
            str = "update mahasiswa set nama='" & txtnama.Text & "', Alamat = '" _
                & txtalamat.Text & "', kota = '" & txtkota.Text & "', agama = '" _
                & cmbagama.Text & "' where npm = '" & txtnpm.Text & "'"
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
        cmdupdate.Enabled = False
        cmbagama.Text = ""
    End Sub

    Private Sub cmdkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdkeluar.Click
        Me.Close()
    End Sub
End Class