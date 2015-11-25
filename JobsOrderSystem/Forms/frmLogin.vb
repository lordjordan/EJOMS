Imports System.Data.SqlClient
Public Class frmLogin
    Dim db As New DBHelper(My.Settings.connectionString)
    'Dim dr As SQLite.SQLiteDataReader
    'Dim cmd As SQLite.SQLiteCommand

    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Try

            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MsgBox("Enter username and password", MsgBoxStyle.Exclamation, "Invalid Username/Password")
            Else
                Dim db As New DBHelper(My.Settings.connectionString)
                Dim dr As SqlDataReader
                Dim parameters As New Dictionary(Of String, Object)()
                parameters.Add("user_name", txtPassword.Text)
                parameters.Add("user_password", txtUsername.Text)

                dr = db.ExecuteReader("SELECT * FROM tbl_users WHERE user_name=@user_name AND user_password=@user_password", parameters)
                If dr.HasRows Then
                    dr.Read()
                    lbl_utype.Text = CInt(dr.Item("user_type"))
                    Me.Hide()
                    frmMain.Show()
                Else
                    MsgBox("Invalid Username/Password", MsgBoxStyle.Exclamation, "Invalid Username/Password")
                End If
                'Do While dr.Read
                '    MsgBox(dr.Item(1).ToString)
                'Loop

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose() '<--------CHECK THIS!
        End Try
        Exit Sub

    End Sub


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        reset()
    End Sub

    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
    Public Sub reset()
        Me.txtUsername.Text = ""
        Me.txtPassword.Text = ""
        Me.lbl_utype.Text = ""
    End Sub
End Class