Imports MySql.Data.MySqlClient

Public Class frmInput
    Private Function satuanToChar() As String
        Dim hasil As String
        If rdoBotol.Checked Then
            hasil = "B"
        ElseIf rdoBox.Checked Then
            hasil = "X"
        ElseIf rdoLiter.Checked Then
            hasil = "L"
        ElseIf rdoDus.Checked Then
            hasil = "D"
        ElseIf rdoPieces.Checked Then
            hasil = "P"
        Else
            hasil = "M"
        End If
        satuanToChar = hasil
    End Function

    Private Sub awal()
        cmbNamaSuplier.Items.Clear()
        For Each suplier In supliers
            cmbNamaSuplier.Items.Add(suplier)
        Next
        cmbNamaSuplier.DropDownStyle = ComboBoxStyle.DropDownList
        cmbNamaSuplier.SelectedIndex = 0
        Call koneksi()

        Dim str As String
        str = "SELECT IFNULL(MAX(kdbarang),'0') AS hasil FROM barang"
        cmd = New MySqlCommand(str, conn)
        da = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        txtKodeBarang.Text = Microsoft.VisualBasic.Right("00000" & (dt.Rows(0)("hasil")) + 1, 6)
        txtKodeBarang.Enabled = False
        txtNamaBarang.Focus()
        txtNamaBarang.Clear()
        txtHarga.Clear()

        rdoBotol.Checked = False
        rdoBox.Checked = False
        rdoDus.Checked = False
        rdoLiter.Checked = False
        rdoMeter.Checked = False
        rdoPieces.Checked = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call awal()
    End Sub

    Private Sub txtHarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtNamaBarang.Text = "" Then
            MsgBox("Nama barang harus di isi..!", vbOKOnly + MessageBoxIcon.Exclamation, "Peringatan")
            txtNamaBarang.Focus()
        ElseIf txtHarga.Text = "" Then
            MsgBox("Harga harus di isi..!", vbOKOnly + MessageBoxIcon.Exclamation, "Peringatan")
            txtHarga.Focus()
        Else
            Try
                Call koneksi()
                Dim str As String = "INSERT INTO barang VALUES('" & txtKodeBarang.Text & _
                    "','" & txtNamaBarang.Text & _
                    "','" & cmbNamaSuplier.Text & _
                    "','" & satuanToChar() & _
                    "'," & txtHarga.Text & _
                    ")"

                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()


                MsgBox("Data berhasil di simpan.",
                    vbOKOnly + MessageBoxIcon.Information,
                    "Sukses")
                Call awal()
            Catch ex As Exception
                MsgBox("Gagal", vbOKOnly, "Perhatian")
            End Try

        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call awal()
    End Sub
End Class
