﻿Imports MySql.Data.MySqlClient

Module koneksimysql


    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter

    Sub koneksi()
        Try
            Dim str As String
            str = "Server=localhost;userid=root;password=123;database=ypkp"
            conn = New MySqlConnection(Str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
