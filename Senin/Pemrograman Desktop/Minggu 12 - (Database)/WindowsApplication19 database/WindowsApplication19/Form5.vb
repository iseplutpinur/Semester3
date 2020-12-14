Imports MySql.Data.MySqlClient
Public Class Form5
    Private temporary(10, 10) As String
    'temporary(0,0) untuk konsisi mengedit dan menghapus data t(true) untuk ya dan f(false) untuk tidak
    'temporary(1,{}) untuk menyimpan data sementara pengeditan
    'temporary(2,{}) untuk menyimpan data sementara pencarian


    Private agama() As String = {"ISLAM", "KRISTEN", "HINDU", "BUDHA"}

    Private Sub inputVisb(Optional ByVal inp As Boolean = False, Optional ByVal inpnpm As Char = "d")
        radiolaki.Enabled = inp
        radioperempuan.Enabled = inp

        cmbagama.Enabled = inp

        txtalamat.Enabled = inp
        txtkota.Enabled = inp
        txtnama.Enabled = inp

        If inpnpm = "f" Or inpnpm = "t" Then
            If inpnpm = "f" Then
                txtnpm.Enabled = False
            ElseIf inpnpm = "t" Then
                txtnpm.Enabled = True
            End If
        Else
            txtnpm.Enabled = inp
        End If
    End Sub

    Private Sub bersihkan()
        cmbagama.Items.Clear()
        txtalamat.Clear()
        txtkota.Clear()
        txtnama.Clear()
        txtnpm.Clear()

        For Each a As String In agama
            cmbagama.Items.Add(a)
        Next

        cmbagama.DropDownStyle = ComboBoxStyle.DropDownList
        cmbagama.SelectedIndex = 0

        radiolaki.Checked = True
        radioperempuan.Checked = False
    End Sub

    Private Sub btnAwal()
        Button1.Text = "Tambah"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"

        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = True
    End Sub

    Private Function cekDataInput() As Boolean
        Dim hasil As Boolean = False
        If txtnpm.Text = "" Then
            MsgBox("NPM harus di isi..!",
                vbOKOnly + MessageBoxIcon.Exclamation,
                "Peringatan")
            hasil = True
            txtnpm.Focus()
        ElseIf txtnama.Text = "" Then
            MsgBox("Nama harus di isi..!",
                vbOKOnly + MessageBoxIcon.Exclamation,
                "Peringatan")
            hasil = True
            txtnama.Focus()
        ElseIf txtkota.Text = "" Then
            MsgBox("Kota harus di isi..!",
                vbOKOnly + MessageBoxIcon.Exclamation,
                "Peringatan")
            hasil = True
            txtkota.Focus()
        ElseIf txtalamat.Text = "" Then
            MsgBox("Alamat harus di isi..!",
                vbOKOnly + MessageBoxIcon.Exclamation,
                "Peringatan")
            hasil = True
            txtalamat.Focus()
        End If
        cekDataInput = hasil
    End Function

    Private Sub loadViewData(Optional ByVal keyword As String = "")
        Call koneksi()

        ListView1.Clear()
        ListView1.Columns.Add("No", 30, HorizontalAlignment.Left)
        ListView1.Columns.Add("NPM", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Nama", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Alamat", 250, HorizontalAlignment.Left)
        ListView1.Columns.Add("Kota", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Agama", 100, HorizontalAlignment.Left)
        ListView1.View = View.Details
        ListView1.GridLines = True

        Dim str As String
        If keyword = "" Then
            str = "SELECT * FROM mahasiswa ORDER BY npm"
        Else
            str = "SELECT * FROM mahasiswa WHERE npm LIKE '%" & _
            keyword & "%' OR nama LIKE '%" & _
            keyword & "%' OR alamat LIKE '%" & _
            keyword & "%' OR agama LIKE '%" & _
            keyword & "%' OR kota LIKE '%" & _
            keyword & "%' ORDER BY npm"
        End If

        Try
            cmd = New MySqlCommand(str, conn)
            da = New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim i, no As Integer
            no = 1
            For i = 0 To dt.Rows.Count - 1
                Dim isi(6) As String
                Dim itm As ListViewItem
                isi(0) = no
                isi(1) = dt.Rows(i)("npm")
                isi(2) = dt.Rows(i)("nama")
                isi(3) = dt.Rows(i)("alamat")
                isi(4) = dt.Rows(i)("kota")
                isi(5) = dt.Rows(i)("agama")
                itm = New ListViewItem(isi)
                ListView1.Items.Add(itm)
                no = no + 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cari()
        If txtCariKey.Text <> "" And temporary(2, 1) <> txtCariKey.Text Then
            temporary(2, 1) = txtCariKey.Text
            Call bersihkan()
            Call btnAwal()
            Call inputVisb()
            Call loadViewData(txtCariKey.Text)
            Button4.Text = "Batal"
            temporary(2, 0) = "t"
            Button1.Enabled = False
        End If
    End Sub
    '========================================================================================================

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        temporary(0, 0) = "f"
        temporary(2, 0) = "f"

        Call bersihkan()
        Call btnAwal()
        Call inputVisb()


        loadViewData()
    End Sub

    Private Sub txtnpm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnpm.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Tambah" Then
            Button1.Text = "Simpan"
            Button4.Text = "Batal"

            txtnpm.Enabled = True
            txtnpm.Focus()
        Else
            If cekDataInput() Then
                Exit Sub
            Else
                Try
                    Call koneksi()
                    Dim str As String
                    Dim jk As String
                    If radiolaki.Checked = True Then
                        jk = "L"
                    Else
                        jk = "P"
                    End If

                    str = "INSERT INTO mahasiswa VALUES ('" &
                        txtnpm.Text & "','" &
                        txtnama.Text & "','" &
                        txtalamat.Text & "','" &
                        txtkota.Text & "','" &
                        cmbagama.Text & "','" &
                        jk & "')"


                    cmd = New MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()


                    MsgBox("Data berhasil di simpan.",
                        vbOKOnly + MessageBoxIcon.Information,
                        "Sukses")

                    Call bersihkan()
                    Call inputVisb()
                    Call loadViewData()

                    txtnpm.Enabled = True
                    txtnpm.Focus()

                Catch ex As Exception
                    MsgBox("Gagal", vbOKOnly, "Perhatian")
                End Try
            End If
        End If
    End Sub

    Private Sub txtnpm_TextChanged(sender As Object, e As EventArgs) Handles txtnpm.TextChanged
        If temporary(0, 0) = "f" Then
            If Len(txtnpm.Text) = 10 Then
                Call inputVisb(True)
                txtnama.Focus()

                Try
                    Call koneksi()
                    Dim str As String
                    str = "SELECT * FROM mahasiswa WHERE npm = '" & txtnpm.Text & "'"
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
            Else
                Call inputVisb(False, "t")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Tutup" Then
            End
        ElseIf Button4.Text = "Batal" Then
            Call bersihkan()
            Call inputVisb()
            Call btnAwal()

            If temporary(0, 0) = "t" Then
                temporary(0, 0) = "f"
            End If

            If temporary(2, 0) = "t" Then
                temporary(2, 0) = "f"
                loadViewData()
                txtCariKey.Clear()
            End If
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.MouseClick
        If temporary(1, 0) <> ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text Then
            Try
                temporary(0, 0) = "t"
                inputVisb(True, "f")

                Button4.Text = "Batal"
                Button1.Enabled = False
                Button2.Enabled = True
                Button3.Enabled = True


                Call koneksi()
                Dim str As String
                str = "SELECT * FROM mahasiswa WHERE npm='" & ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text & "'"
                cmd = New MySqlCommand(str, conn)
                da = New MySqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                txtnpm.Text = dt.Rows(0)("npm")
                txtnama.Text = dt.Rows(0)("nama")
                txtalamat.Text = dt.Rows(0)("alamat")
                txtkota.Text = dt.Rows(0)("kota")

                temporary(1, 0) = dt.Rows(0)("npm")
                temporary(1, 1) = dt.Rows(0)("nama")
                temporary(1, 2) = dt.Rows(0)("alamat")
                temporary(1, 3) = dt.Rows(0)("kota")
                temporary(1, 5) = dt.Rows(0)("agama")

                If dt.Rows(0)("jenis_kelamin") = "L" Then
                    radiolaki.Checked = True
                    temporary(1, 4) = "L"
                Else
                    radioperempuan.Checked = True
                    temporary(1, 4) = "P"
                End If

                Dim indexAgama As Integer = 0
                For Each a As String In agama
                    If dt.Rows(0)("agama") = a Then
                        Exit For
                    End If
                    indexAgama += 1
                Next
                cmbagama.SelectedIndex = indexAgama
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MsgBox("Apakah anda yakin akan menghapus data " & temporary(1, 1),
                MessageBoxButtons.YesNo + MessageBoxIcon.Question,
                "Peringatan")
        If result = DialogResult.Yes Then
            Try
                Call koneksi()
                Dim str As String
                str = "DELETE FROM mahasiswa WHERE NPM = '" & txtnpm.Text & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()

                temporary(0, 0) = "f"

                Call bersihkan()
                Call btnAwal()
                Call inputVisb()


                loadViewData()

                MsgBox("Data berhasil di Dihapus.",
            vbOKOnly + MessageBoxIcon.Information,
                "Perhatian")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cekEdit As Boolean = False
        Dim detail As String = ""
        Dim querybuilder As String = ""
        Dim jk As String = IIf(radiolaki.Checked, "L", "P")

        If temporary(1, 1) <> txtnama.Text Then
            detail &= "Nama dirubah dari " & txtnama.Text & " menjadi " & temporary(1, 1) & Chr(13)
            querybuilder &= "nama='" & txtnama.Text & "'"
            cekEdit = True
        End If


        If temporary(1, 2) <> txtalamat.Text Then
            detail &= "Alamat dirubah dari " & temporary(1, 2) & " menjadi " & txtalamat.Text & Chr(13)
            querybuilder = IIf(querybuilder = "", "", querybuilder & ",")
            querybuilder &= "alamat='" & txtalamat.Text & "'"

            cekEdit = True
        End If


        If temporary(1, 3) <> txtkota.Text Then
            detail &= "Kota dirubah dari " & temporary(1, 3) & " menjadi " & txtkota.Text & Chr(13)
            querybuilder = IIf(querybuilder = "", "", querybuilder & ",")
            querybuilder &= "kota='" & txtkota.Text & "'"

            cekEdit = True
        End If


        If temporary(1, 4) <> jk Then
            Dim jk1 As String = IIf(temporary(1, 4) = "L", "Laki-Laki", "Perempuan")
            Dim jk2 As String = IIf(radiolaki.Checked, "Laki-Laki", "Perempuan")
            querybuilder = IIf(querybuilder = "", "", querybuilder & ",")
            querybuilder &= "jenis_kelamin='" & jk & "'"

            detail &= "Jenis Kelamin dirubah dari " & jk1 & " menjadi " & jk2 & Chr(13)
            cekEdit = True
        End If


        If temporary(1, 5) <> cmbagama.Text Then
            detail &= "Agama dirubah dari " & temporary(1, 5) & " menjadi " & cmbagama.Text & Chr(13)
            cekEdit = True

            querybuilder = IIf(querybuilder = "", "", querybuilder & ",")
            querybuilder &= "agama='" & cmbagama.Text & "'"
        End If

        If cekEdit Then
            Dim result As DialogResult = MsgBox("Apakah anda yakin akan Mengedit data ini..?  " & Chr(13) & detail,
                                            MessageBoxButtons.YesNo + MessageBoxIcon.Question,
                                            "Peringatan")
            If result = DialogResult.Yes Then
                Call koneksi()
                Try
                    Dim str As String
                    str = "UPDATE mahasiswa SET " & querybuilder & " WHERE npm='" & txtnpm.Text & "'"

                    cmd = New MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()

                    MsgBox("Data berhasil di edit.",
                        vbOKOnly + MessageBoxIcon.Information,
                        "Sukses")
                    Call bersihkan()
                    Call inputVisb()
                    Call loadViewData()
                    Call btnAwal()

                    temporary(1, 0) = ""
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call cari()
    End Sub

    Private Sub txtCariKey_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariKey.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call cari()
        End If
    End Sub
End Class