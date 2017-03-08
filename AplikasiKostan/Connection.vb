Imports System.Data.Odbc

Module Connection

    Public KNS As OdbcConnection
    Public DA As New OdbcDataAdapter
    Public DS As New DataSet
    Public STR, strcon As String

    Public Sub KoneksiDB()
        strcon = "Driver={MYSQL ODBC 5.3 Ansi Driver};database=kostan;server=localhost;uid=root"
        KNS = New Odbc.OdbcConnection(strcon)

        If KNS.State = ConnectionState.Closed Then
            KNS.Open()
        End If
    End Sub
End Module
