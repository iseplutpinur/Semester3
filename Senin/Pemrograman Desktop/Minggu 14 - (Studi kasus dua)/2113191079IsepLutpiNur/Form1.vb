Imports MySql.Data.MySqlClient

Public Class Form1
    '=======================================================================================
    'Begin varables declaration


    Private supliers() As String = {"PT. MAKMUR BERSAMA", _
                              "PT. ALIM UNTUNG", _
                              "MULYA UTAMA SEJAHTERA", _
                              "PT. INDAH MEKAR MULYA", _
                              "CV. SUMBER UTAMA BERKAH"}

    Private temp(10, 10) As String
    'temp(0,5) string konfirmasi edit data
    'temp(0,6) string query builder untuk edit data

    'End variables declaration
    '=======================================================================================
    'Begin procedures
    Private Sub btnAwal()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Text = "Keluar"
        Button1.Text = "Tambah"
        temp(0, 0) = ""
    End Sub


    Private Sub setSatuan(ByVal satuan As String)
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

    Private Sub setSuplier(Optional ByVal inpsuplier As String = "")
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



    Private Sub setInput(Optional ByVal enabled As Boolean = False, Optional ByVal clear As Boolean = False)
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


    Private Sub loadViewData()
        ListView1.Clear()
        ListView1.Columns.Add("No", 30, HorizontalAlignment.Left)
        ListView1.Columns.Add("Kode", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Nama", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Supplier", 250, HorizontalAlignment.Left)
        ListView1.Columns.Add("Satuan", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Harga", 100, HorizontalAlignment.Left)
        ListView1.View = View.Details
        ListView1.GridLines = True

        Try
            Call koneksi()
            cmd = New MySqlCommand("SELECT * FROM warungsaya.barang", conn)
            da = New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            conn.Close()
            Dim i, no As Integer
            no = 1
            For i = 0 To dt.Rows.Count - 1
                Dim isi(6) As String
                Dim itm As ListViewItem
                isi(0) = no
                isi(1) = dt.Rows(i)("kdbarang")
                isi(2) = dt.Rows(i)("nmbarang")
                isi(3) = dt.Rows(i)("supplier")
                isi(4) = charToSatuan(dt.Rows(i)("satuan"))
                isi(5) = dt.Rows(i)("harga")
                itm = New ListViewItem(isi)
                ListView1.Items.Add(itm)
                no = no + 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'End procedures
    '=======================================================================================
    'Begin functions


    Private Function cekUpdate() As Boolean
        Dim hasil As Boolean = False
        temp(0, 5) = ""
        temp(0, 6) = ""

        If temp(0, 1) <> txtNamaBarang.Text Then
            hasil = True
            temp(0, 5) &= "Nama dirubah dari " & temp(0, 1) & " menjadi " & txtNamaBarang.Text & Chr(13)
            temp(0, 6) &= " nmbarang='" & txtNamaBarang.Text & "' "
        End If

        If temp(0, 2) <> cmbNamaSuplier.Text Then
            hasil = True
            temp(0, 5) &= "Suplier dirubah dari " & temp(0, 2) & " menjadi " & cmbNamaSuplier.Text & Chr(13)
            temp(0, 6) = IIf(temp(0, 6) = "", "", temp(0, 6) & ",")
            temp(0, 6) &= " supplier='" & cmbNamaSuplier.Text & "' "
        End If

        If temp(0, 3) <> satuanToChar() Then
            hasil = True
            temp(0, 5) &= "Satuan dirubah dari " & charToSatuan(temp(0, 3)) & " menjadi " & charToSatuan(satuanToChar()) & Chr(13)
            temp(0, 6) = IIf(temp(0, 6) = "", "", temp(0, 6) & ",")
            temp(0, 6) &= " satuan='" & satuanToChar() & "' "
        End If

        If temp(0, 4) <> txtHarga.Text Then
            hasil = True
            temp(0, 5) &= "Harga dirubah dari " & temp(0, 4) & " menjadi " & txtHarga.Text & Chr(13)
            temp(0, 6) = IIf(temp(0, 6) = "", "", temp(0, 6) & ",")
            temp(0, 6) &= " harga='" & txtHarga.Text & "' "
        End If

        cekUpdate = hasil
    End Function

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

    Private Function getKodeBarang() As String
        Call koneksi()
        cmd = New MySqlCommand("SELECT IFNULL(MAX(kdbarang),'0') AS hasil FROM barang", conn)
        da = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        getKodeBarang = Microsoft.VisualBasic.Right("00000" & (dt.Rows(0)("hasil")) + 1, 6)
    End Function


    'End functions
    '=======================================================================================










    '=======================================================================================
    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Button3.Enabled = False
        txtKodeBarang.Enabled = False
        Call setInput(False, True)
        Call loadViewData()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "Keluar" Then
            End
        Else
            Call setInput(False, True)
            Call btnAwal()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Tambah" Then
            Button1.Text = "Simpan"
            Button4.Text = "Batal"
            txtKodeBarang.Text = getKodeBarang()
            setInput(True)
            txtNamaBarang.Focus()
        Else
            If txtNamaBarang.Text = "" Then
                MsgBox("Nama barang harus di isi..!", vbOKOnly + MessageBoxIcon.Exclamation, "Peringatan")
                txtNamaBarang.Focus()
            ElseIf txtNamaBarang.Text = "" Then
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
                    conn.Close()

                    MsgBox("Data berhasil di simpan.",
                        vbOKOnly + MessageBoxIcon.Information,
                        "Sukses")

                    Call setInput(False, True)
                    Call loadViewData()
                    Call btnAwal()
                Catch ex As Exception
                    MsgBox("Gagal", vbOKOnly, "Perhatian")
                End Try
            End If
        End If
    End Sub

    Private Sub txtHarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If temp(0, 0) <> ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text Then
            Try
                Button4.Text = "Batal"
                Button1.Enabled = False
                Button2.Enabled = True
                Button3.Enabled = True

                Call koneksi()
                Dim str As String
                str = "SELECT * FROM barang WHERE kdbarang='" & ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text & "'"
                cmd = New MySqlCommand(str, conn)
                da = New MySqlDataAdapter(cmd)
                conn.Close()
                Dim dt As New DataTable
                da.Fill(dt)

                txtKodeBarang.Text = dt.Rows(0)("kdbarang")
                txtNamaBarang.Text = dt.Rows(0)("nmbarang")
                setSuplier(dt.Rows(0)("supplier"))
                setSatuan(dt.Rows(0)("satuan"))
                txtHarga.Text = dt.Rows(0)("harga")

                temp(0, 0) = dt.Rows(0)("kdbarang")
                temp(0, 1) = dt.Rows(0)("nmbarang")
                temp(0, 2) = dt.Rows(0)("supplier")
                temp(0, 3) = dt.Rows(0)("satuan")
                temp(0, 4) = dt.Rows(0)("harga")


                setInput(True)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim result As DialogResult = MsgBox("Apakah anda yakin akan menghapus data " & temp(1, 1),
        MessageBoxButtons.YesNo + MessageBoxIcon.Question,
        "Peringatan")
        If result = DialogResult.Yes Then
            Try
                Call koneksi()
                Dim str As String
                str = "DELETE FROM barang WHERE kdbarang = '" & txtKodeBarang.Text & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                conn.Close()

                Call setInput(False, True)
                Call loadViewData()
                Call btnAwal()

                MsgBox("Data berhasil di Dihapus.", vbOKOnly + MessageBoxIcon.Information, "Perhatian")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If cekUpdate() Then
            If txtNamaBarang.Text = "" Then
                MsgBox("Nama barang harus di isi..!", vbOKOnly + MessageBoxIcon.Exclamation, "Peringatan")
                txtNamaBarang.Focus()
            ElseIf txtNamaBarang.Text = "" Then
                MsgBox("Harga harus di isi..!", vbOKOnly + MessageBoxIcon.Exclamation, "Peringatan")
                txtHarga.Focus()
            Else
                Dim result As DialogResult = MsgBox("Apakah anda yakin akan Mengupdate data ini..?  " & Chr(13) & temp(0, 5), _
                                                    MessageBoxButtons.YesNo + MessageBoxIcon.Question, _
                                                    "Peringatan")
                If result = DialogResult.Yes Then
                    Try
                        Call koneksi()
                        cmd = New MySqlCommand("UPDATE barang SET " & temp(0, 6) & " WHERE kdbarang='" & txtKodeBarang.Text & "'", conn)
                        cmd.ExecuteNonQuery()
                        conn.Close()

                        MsgBox("Data berhasil di update.",
                            vbOKOnly + MessageBoxIcon.Information,
                            "Sukses")


                        Call setInput(False, True)
                        Call loadViewData()
                        Call btnAwal()

                    Catch ex As Exception
                        MsgBox("Gagal", vbOKOnly, "Perhatian")
                    End Try
                End If
            End If
        End If
    End Sub
End Class
