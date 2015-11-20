Imports System.Data.SqlClient
Public Class frmLogin
    'Dim db As New DBHelper(My.Settings.ConnectionString)
    'Dim dr As SQLite.SQLiteDataReader
    'Dim cmd As SQLite.SQLiteCommand
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        'Dim db As New DBHelper(My.Settings.connectionString)
        'Dim dr As SqlDataReader

        'dr = db.ExecuteReader("SELECT * FROM tbl_users")

        'Do While dr.Read
        '    MsgBox(dr.Item(0).ToString)

        'Loop
        'Exit Sub
        Me.Hide()
        frmMain.Show()
    End Sub
End Class