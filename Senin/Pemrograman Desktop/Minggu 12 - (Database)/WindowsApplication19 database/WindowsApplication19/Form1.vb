Imports MySql.Data.MySqlClient

Public Class frminput

    Private Sub cmdkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdkeluar.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbagama.Items.Add("ISLAM")
        cmbagama.Items.Add("KRISTEN")
        cmbagama.Items.Add("BUDHA")
        cmbagama.Items.Add("HINDU")
        txtnama.Enabled = False
        txtalamat.Enabled = False
        txtkota.Enabled = False
        cmbagama.Enabled = False
        cmbagama.SelectedIndex = 0
        cmdsimpan.Enabled = False
        cmdbatal.Enabled = False
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
            If rd.HasRows Then
                MsgBox("Data sudah ada", vbOKOnly, "Perhatian")
                txtnpm.Text = ""
                txtnpm.Focus()
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        txtnama.Enabled = True
        txtalamat.Enabled = True
        txtkota.Enabled = True
        cmbagama.Enabled = True
        cmdsimpan.Enabled = True
        cmdbatal.Enabled = True
        txtnama.Focus()
        txtnpm.Enabled = False
    End Sub

    Private Sub cmdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatal.Click
        txtnpm.Enabled = True
        txtnpm.Text = ""
        txtnpm.Focus()
        txtnama.Text = ""
        txtalamat.Text = ""
        txtkota.Text = ""
        txtnama.Enabled = False
        txtalamat.Enabled = False
        txtkota.Enabled = False
        cmbagama.Enabled = False
        cmbagama.SelectedIndex = 0
        cmbagama.Enabled = False
        cmdbatal.Enabled = False
        cmdsimpan.Enabled = False
    End Sub

    Private Sub cmdsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsimpan.Click
        If txtnama.Text = "" Or txtalamat.Text = "" Or txtkota.Text = "" Then
            MsgBox("Form harus diisi lengkap", vbOKOnly, "perhatian")
            txtnama.Focus()
            Exit Sub
        End If
        Call koneksi()
        Try
            Dim str As String
            Dim jk As String
            If radiolaki.Checked = True Then
                jk = "L"
            Else
                jk = "P"
            End If
            str = "insert into mahasiswa values ('" & txtnpm.Text & "','" & txtnama.Text &
                "','" & txtalamat.Text & "','" & txtkota.Text & "','" & cmbagama.Text &
                "','" & jk & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            txtnpm.Enabled = True
            txtnpm.Text = ""
            txtnpm.Focus()
            txtnama.Text = ""
            txtalamat.Text = ""
            txtkota.Text = ""
            txtnama.Enabled = False
            txtalamat.Enabled = False
            txtkota.Enabled = False
            cmbagama.Enabled = False
            cmbagama.SelectedIndex = 0
            cmbagama.Enabled = False
            cmdbatal.Enabled = False
            cmdsimpan.Enabled = False
        Catch ex As Exception
            MsgBox("Gagal", vbOKOnly, "Perhatian")
            Exit Sub
        End Try

    End Sub
End Class
