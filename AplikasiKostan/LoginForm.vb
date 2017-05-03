Imports System.Data.Odbc

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub Check()
        Call KoneksiDB()
        DS.Clear()
        STR = "SELECT * FROM user WHERE username= '" & txtUsername.Text & "' && password= '" & txtPassword.Text & "'"
        DA.SelectCommand = New Odbc.OdbcCommand(STR, KNS)
        DA.Fill(DS, "user")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call KoneksiDB()
        Dim cd As New OdbcCommand("SELECT * FROM user WHERE username  = '" & txtUsername.Text & "' && password = '" & txtPassword.Text & "'", KNS)
        Dim myReader As OdbcDataReader = cd.ExecuteReader(CommandBehavior.CloseConnection)
        myReader.Read()
        If myReader.HasRows Then
            Main.Show()
            Me.Visible = False
        Else
            MsgBox("Username dan Password Anda Salah!", MsgBoxStyle.Exclamation)
            txtUsername.Focus()
        End If
    End Sub
End Class