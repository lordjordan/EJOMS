Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
'Imports System.Drawing.Imaging
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class frmLogin
    'Dim db As New DBHelper(My.Settings.ConnectionString)
    'Dim dr As SQLite.SQLiteDataReader
    'Dim cmd As SQLite.SQLiteCommand

    Dim dr As SqlClient.SqlDataReader
    'Dim cmd As SqlClient.SqlCommand
    Private Const EM_SETCUEBANNER As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub SetCueText(ByVal control As Control, ByVal text As String)
        SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
    End Sub
    Private Shared DES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider
    Public Shared Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function

    Public Shared Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
        DES.Key = frmLogin.MD5Hash(key)
        DES.Mode = CipherMode.ECB
        Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click

        Try
            Dim user As String = txtUsername.Text
            Dim pass As String = txtPassword.Text
            Dim userType As String = lbl_utype.Text
            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MsgBox("Enter username and password", MsgBoxStyle.Exclamation, "Invalid Username/Password")
            Else
                Dim db As New DBHelper(My.Settings.connectionString)
                Dim dr As SqlDataReader
                Dim parameters As New Dictionary(Of String, Object)()
                Dim encryptPass = Encrypt(txtPassword.Text, "Keys")
                parameters.Add("user_name", txtUsername.Text)
                parameters.Add("user_password", encryptPass)

                dr = db.ExecuteReader("SELECT * FROM tbl_users WHERE user_name=@user_name AND user_password=@user_password", parameters)
                If dr.HasRows Then
                    dr.Read()
                    'lbl_utype.Text = CInt(dr.Item("user_type"))

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
        SetCueText(txtUsername, "Username")
        SetCueText(txtPassword, "Password")
    End Sub

    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
    Public Sub reset()
        Me.txtUsername.Text = ""
        Me.txtPassword.Text = ""
        Me.lbl_utype.Text = ""
    End Sub
    Private Sub thisIsOnlyYourAccess()
        'mga access nila later

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class