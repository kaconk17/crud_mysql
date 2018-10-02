Imports MySql.Data.MySqlClient
Module koneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter 
    Public ds As DataSet
    Public dt As DataTable

    Sub connect()
        Try

            conn = New MySqlConnection("Server=localhost; port=8889; user id=root; password=root;database=pl_crud; sslmode=none")
            conn.Open()
            conn.Close()
            'MsgBox("berhasil")
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
