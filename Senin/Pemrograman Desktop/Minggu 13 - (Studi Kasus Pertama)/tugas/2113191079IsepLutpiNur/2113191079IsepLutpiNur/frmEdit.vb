Imports MySql.Data.MySqlClient
Public Class frmEdit
    Private temporary(10, 10) As String

    Private Sub satuanChecked(ByVal satuan As String)
        If satuan = "B" Then
            rdoBotol.Checked = True
        Else
            rdoBotol.Checked = False
        End If

        If satuan = "X" Then
            rdoBox.Checked = True
        Else
            rdoBox.Checked = False
        End If

        If satuan = "L" Then
            rdoLiter.Checked = True
        Else
            rdoLiter.Checked = False
        End If

        If satuan = "D" Then
            rdoDus.Checked = True
        Else
            rdoDus.Checked = False
        End If

        If satuan = "P" Then
            rdoPieces.Checked = True
        Else
            rdoPieces.Checked = False
        End If

        If satuan = "M" Then
            rdoMeter.Checked = True
        Else
            rdoMeter.Checked = False
        End If
    End Sub

    Private Function charToSatuan(ByVal satuan As String) As String
        Dim hasil As String

        If satuan = "B" Then
            hasil = "Botol"
        ElseIf satuan = "X" Then
            hasil = "Box"
        ElseIf satuan = "L" Then
            hasil = "Liter"
        ElseIf satuan = "D" Then
            hasil = "Dus"
        ElseIf satuan = "P" Then
            hasil = "Pieces"
        ElseIf satuan = "M" Then
            hasil = "Meter"
        Else
            hasil = "Tidak diketahui"
        End If

        charToSatuan = hasil
    End Function

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

    Private Sub setSuplier(ByVal inpsuplier As String)
        cmbNamaSuplier.Items.Clear()
        Dim i As Integer = 0
        For Each suplier In supliers
            cmbNamaSuplier.Items.Add(suplier)
            If suplier = inpsuplier Then
                cmbNamaSuplier.SelectedIndex = i
            End If
            i += 1
        Next
        cmbNamaSuplier.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub awal(Optional ByVal enabled As Boolean = False, Optional ByVal clear As Boolean = True)
        txtHarga.Enabled = enabled
        cmbNamaSuplier.Enabled = enabled
        txtNamaBarang.Enabled = enabled

        rdoBotol.Enabled = enabled
        rdoBox.Enabled = enabled
        rdoDus.Enabled = enabled
        rdoLiter.Enabled = enabled
        rdoMeter.Enabled = enabled
        rdoPieces.Enabled = enabled

        If clear Then
            cmbNamaSuplier.Items.Clear()
            For Each suplier In supliers
                cmbNamaSuplier.Items.Add(suplier)
            Next
            cmbNamaSuplier.DropDownStyle = ComboBoxStyle.DropDownList
            cmbNamaSuplier.SelectedIndex = 0

            txtHarga.Clear()
            txtKodeBarang.Clear()
            txtNamaBarang.Clear()

            rdoBotol.Checked = False
            rdoBox.Checked = False
            rdoDus.Checked = False
            rdoLiter.Checked = False
            rdoMeter.Checked = False
            rdoPieces.Checked = True

            txtKodeBarang.Focus()
        End If
    End Sub

    Private Function cekUpdate() As Boolean
        Dim hasil As Boolean = False
        temporary(0, 5) = ""
        temporary(0, 6) = ""

        If temporary(0, 3) <> txtNamaBarang.Text Then
            hasil = True
            temporary(0, 5) &= "Nama dirubah dari " & temporary(0, 3) & " menjadi " & txtNamaBarang.Text & Chr(13)
            temporary(0, 6) &= " nmbarang='" & txtNamaBarang.Text & "' "
        End If

        If temporary(0, 2) <> cmbNamaSuplier.Text Then
            hasil = True
            temporary(0, 5) &= "Suplier dirubah dari " & temporary(0, 2) & " menjadi " & cmbNamaSuplier.Text & Chr(13)
            temporary(0, 6) = IIf(temporary(0, 6) = "", "", temporary(0, 6) & ",")
            temporary(0, 6) &= " suplier='" & cmbNamaSuplier.Text & "' "
        End If

        If temporary(0, 1) <> satuanToChar() Then
            hasil = True
            temporary(0, 5) &= "Satuan dirubah dari " & charToSatuan(temporary(0, 1)) & " menjadi " & charToSatuan(satuanToChar()) & Chr(13)
            temporary(0, 6) = IIf(temporary(0, 6) = "", "", temporary(0, 6) & ",")
            temporary(0, 6) &= " satuan='" & satuanToChar() & "' "
        End If

        If temporary(0, 4) <> txtHarga.Text Then
            hasil = True
            temporary(0, 5) &= "Harga dirubah dari " & temporary(0, 4) & " menjadi " & txtHarga.Text & Chr(13)
            temporary(0, 6) = IIf(temporary(0, 6) = "", "", temporary(0, 6) & ",")
            temporary(0, 6) &= " harga='" & txtHarga.Text & "' "
        End If


        If temporary(0, 0) = "f" Then
            hasil = False
        End If

        cekUpdate = hasil
    End Function

    Private Sub txtKodeBarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub frmEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call awal()
        txtKodeBarang.Focus()
        temporary(0, 0) = "f"
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call awal()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub txtKodeBarang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKodeBarang.TextChanged
        If Len(txtKodeBarang.Text) = "6" Then
            Try
                Call koneksi()
                Dim str As String
                str = "SELECT * FROM barang WHERE kdbarang='" & txtKodeBarang.Text & "'"
                cmd = New MySqlCommand(str, conn)
                da = New MySqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    awal(True, False)
                    temporary(0, 0) = "t"
                    satuanChecked(dt.Rows(0)("satuan"))
                    temporary(0, 1) = dt.Rows(0)("satuan")

                    setSuplier(dt.Rows(0)("suplier"))
                    temporary(0, 2) = dt.Rows(0)("suplier")

                    txtNamaBarang.Text = dt.Rows(0)("nmbarang")
                    temporary(0, 3) = dt.Rows(0)("nmbarang")

                    txtHarga.Text = dt.Rows(0)("harga")
                    temporary(0, 4) = dt.Rows(0)("harga")
                Else
                    MsgBox("Data tidak ada", vbOKOnly, "Perhatian")
                    temporary(0, 0) = "f"
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            awal(False, False)
            temporary(0, 0) = "f"
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If cekUpdate() Then
            If txtNamaBarang.Text = "" Then
                MsgBox("Nama barang harus di isi..!", vbOKOnly + MessageBoxIcon.Exclamation, "Peringatan")
                txtNamaBarang.Focus()
            ElseIf txtHarga.Text = "" Then
                MsgBox("Harga harus di isi..!", vbOKOnly + MessageBoxIcon.Exclamation, "Peringatan")
                txtHarga.Focus()
            Else
                Dim result As DialogResult = MsgBox("Apakah anda yakin akan Mengupdate data ini..?  " & Chr(13) & temporary(0, 5),
                MessageBoxButtons.YesNo + MessageBoxIcon.Question,
                "Peringatan")
                If result = DialogResult.Yes Then
                    Try
                        Call koneksi()
                        cmd = New MySqlCommand("UPDATE barang SET " & temporary(0, 6) & " WHERE kdbarang='" & txtKodeBarang.Text & "'", conn)
                        cmd.ExecuteNonQuery()

                        MsgBox("Data berhasil di update.",
                            vbOKOnly + MessageBoxIcon.Information,
                            "Sukses")
                        Call awal()
                        temporary(0, 0) = "f"
                    Catch ex As Exception
                        MsgBox("Gagal", vbOKOnly, "Perhatian")
                    End Try
                End If
            End If
        End If
    End Sub
End Class