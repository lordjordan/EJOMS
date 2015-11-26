Imports System.Data.SqlClient
Public Class frmLogin
    Dim db As New DBHelper(My.Settings.DBconn)
    Dim dr As SqlClient.SqlDataReader
    'Dim rec As Integer
    'Dim data As New Dictionary(Of String, Object)

    'Dim dr As SQLite.SQLiteDataReader
    'Dim cmd As SQLite.SQLiteCommand
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        'Dim db As New DBHelper(My.Settings.connectionString)
        'Dim dr As SqlDataReader

        'dr = db.ExecuteReader("SELECT * FROM tbl_users")

        'Do While dr.Read
        '    MsgBox(dr.Item("user_name").ToString)
        'Loop

        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class