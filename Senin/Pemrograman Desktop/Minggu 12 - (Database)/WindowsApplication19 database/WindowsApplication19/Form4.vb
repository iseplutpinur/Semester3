Imports MySql.Data.MySqlClient
Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("No", 30, HorizontalAlignment.Left)
        ListView1.Columns.Add("NPM", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Nama", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Alamat", 250, HorizontalAlignment.Left)
        ListView1.Columns.Add("Kota", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Agama", 100, HorizontalAlignment.Left)
        ListView1.View = View.Details
        ListView1.GridLines = True
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        Call koneksi()
        Try
            Dim str As String
            str = "select * from mahasiswa order by npm"
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
                isi(1) = dt.Rows(i)("NPM")
                isi(2) = dt.Rows(i)("nama")
                isi(3) = dt.Rows(i)("alamat")
                isi(4) = dt.Rows(i)("kota")
                isi(5) = dt.Rows(i)("agama")
                itm = New ListViewItem(isi)
                ListView1.Items.Add(itm)
                no = no + 1
            Next
            cmdok.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
End Class