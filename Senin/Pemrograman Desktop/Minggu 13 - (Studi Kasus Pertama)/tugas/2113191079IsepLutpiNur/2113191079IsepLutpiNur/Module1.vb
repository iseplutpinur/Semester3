Imports MySql.Data.MySqlClient

Module koneksimysql
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter

    Public supliers() As String = {"PT. MAKMUR BERSAMA", _
                                  "PT. ALIM UNTUNG", _
                                  "MULYA UTAMA SEJAHTERA", _
                                  "PT. INDAH MEKAR MULYA", _
                                  "CV. SUMBER UTAMA BERKAH"}

    Sub koneksi()
        Try
            Dim str As String
            str = "Server=localhost;Port=3306;userid=root;password=123;database=warungsaya"
            conn = New MySqlConnection(Str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Module
