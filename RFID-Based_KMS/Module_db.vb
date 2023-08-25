Imports MySql.Data.MySqlClient
Module Module_db
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Sub OpenCon()
        con.Close()
        con.ConnectionString = My.Settings.db_kmsConnectionString
        con.Open()
    End Sub
End Module
