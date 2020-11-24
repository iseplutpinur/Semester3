Public Class Form1
    Dim no, gtotal As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listview1.Columns.Add("No", 30, HorizontalAlignment.Left)
        listview1.Columns.Add("Kode", 60, HorizontalAlignment.Left)
        listview1.Columns.Add("Nama Barang", 200, HorizontalAlignment.Left)
        listview1.Columns.Add("Harga", 70, HorizontalAlignment.Left)
        listview1.Columns.Add("Satuan", 70, HorizontalAlignment.Left)
        listview1.Columns.Add("Jml. Beli", 60, HorizontalAlignment.Left)
        listview1.Columns.Add("Total", 100, HorizontalAlignment.Left)
        ListView1.View = View.Details
        listview1.GridLines = True
        no = 1
        gtotal = 0
        Satuan.Items.Add("PCS")
        Satuan.Items.Add("Kg.")
        Satuan.Items.Add("DUS")
        Satuan.Items.Add("Botol")
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        If kd_brg.Text = "" Or nama_brg.Text = "" Or Stock.Text = "" Or Jml_beli.Text = "" Then
            MsgBox("Harus diisi Lengkap", vbOKOnly, "Perhatian")
            Exit Sub
        End If

        If Val(Stock.Text) < Val(Jml_beli.Text) Then
            MsgBox("Stock tidak cukup", vbOKOnly, "Perhatian")
            Jml_beli.Focus()
            Exit Sub
        End If
        Dim isi(7) As String
        Dim itm As ListViewItem
        isi(0) = no
        isi(1) = kd_brg.Text
        isi(2) = nama_brg.Text
        isi(3) = harga.Text
        isi(4) = Satuan.Text
        isi(5) = Jml_beli.Text
        isi(6) = Val(isi(3)) * Val(isi(5))
        itm = New ListViewItem(isi)
        listview1.Items.Add(itm)
        no = no + 1
        gtotal = gtotal + Val(isi(6))
        grandtotal.Text = gtotal
        kd_brg.Clear()
        nama_brg.Clear()
        harga.Clear()
        Stock.Clear()
        Jml_beli.Clear()
    End Sub

    Private Sub cmdbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbaru.Click
        gtotal = 0
        no = 1
        listview1.Items.Clear()
        kd_brg.Clear()
        nama_brg.Clear()
        harga.Clear()
        Stock.Clear()
        Jml_beli.Clear()
    End Sub
End Class
