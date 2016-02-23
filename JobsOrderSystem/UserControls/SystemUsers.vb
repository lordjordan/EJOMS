Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class SystemUsers
    Dim timerStopper As String
    Dim btnAddNewClick, btnEditClick, btnPrintClick, btnAddEditClosed As Boolean
 

    Private Shared DES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider



    Public Shared Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function

    Public Shared Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
        DES.Key = SystemUsers.MD5Hash(key)
        DES.Mode = CipherMode.ECB
        Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Public Shared Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String

        DES.Key = SystemUsers.MD5Hash(key)
        DES.Mode = CipherMode.ECB

        Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
        Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function
    Private Sub showAddEdit(mode As Boolean)
        pnlAddEdit.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        showUSC(uscMainmenu)
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        pnlAddEdit.BringToFront()
        btnAddNewClick = True
        lblAddedit.Text = "Add new user"
        showAddEdit(True)
        If pnlAddEdit.Height <> 250 Then
            timerAnimate.Start()
        End If

    End Sub
    Private Sub btnAddEditClose_Click(sender As Object, e As EventArgs) Handles btnAddEditClose.Click
        lvUsers.SelectedItems.Clear()
        clearPanel()

        btnAddEditClosed = True
        If pnlAddEdit.Height <> 0 Then

            timerAnimate.Start()

        End If
        pnlMain.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        EditItemInListView()
        If pnlAddEdit.Height <> 250 Then
            timerAnimate.Start()
        End If
    End Sub
    Private Sub EditItemInListView()
        pnlAddEdit.BringToFront()
        clearPanel()
        If lvUsers.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify
            btnAddNewClick = True
            showAddEdit(True)
            lblAddedit.Text = "Update system user"
            txtID.Text = lvUsers.FocusedItem.Text
            Try
                dr = db.ExecuteReader("select * from tbl_users WHERE user_id=" & lvUsers.FocusedItem.Text)
                pnlAddEdit.Visible = True
                If dr.HasRows Then
                    Dim pass = lvUsers.SelectedItems(0).SubItems(3).Text
                    Dim decryptPass = Decrypt(pass, "Keys")
                    txtID.Text = lvUsers.SelectedItems(0).SubItems(0).Text
                    txtpw.Text = decryptPass
                    txtconfirmpwd.Text = decryptPass
                    txtuname.Text = lvUsers.SelectedItems(0).SubItems(1).Text
                    cmbUtype.Text = lvUsers.SelectedItems(0).SubItems(2).Text
                    'txtpw.Text = lvUsers.SelectedItems(0).SubItems(3).Text
                    'txtconfirmpwd.Text = lvUsers.SelectedItems(0).SubItems(3).Text
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Dispose() '<--------CHECK THIS!
            End Try

        Else
            MessageBox.Show("Please select record to update.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
    End Sub
    Private Sub timerAnimate_Tick(sender As Object, e As EventArgs) Handles timerAnimate.Tick
        'opening
        If btnAddNewClick = True Then
            timerStopper = pnlAddEdit.Height
            If timerStopper = 250 Then
                timerAnimate.Stop()
                btnAddNewClick = False
                Exit Sub
            End If
            pnlAddEdit.Height += 50

        ElseIf btnEditClick = True Then
            timerStopper = pnlAddEdit.Height
            If timerStopper = 250 Then

                timerAnimate.Stop()
                btnEditClick = False
                Exit Sub
            End If
            pnlAddEdit.Height += 50

        ElseIf btnPrintClick = True Then

        ElseIf btnAddEditClosed = True Then
            timerStopper = pnlAddEdit.Height
            If timerStopper = 0 Then

                timerAnimate.Stop()
                btnAddEditClosed = False
                Exit Sub
            End If
            pnlAddEdit.Height -= 50
        End If
    End Sub
    Public Sub lvLoadListview()
        Dim parameters As New Dictionary(Of String, Object)
        lvUsers.Items.Clear()
        Dim Item As ListViewItem
        'parameters.Add("keyword", "%" & txtSearch.Text & "%")
        Try
            dr = db.ExecuteReader("SELECT user_id, user_name, user_password, confirm_password, user_type FROM tbl_users", parameters)
            If dr.HasRows Then
                Do While dr.Read
                    Dim utype = (CInt(dr.Item("user_type")))
                    Item = Me.lvUsers.Items.Add(dr.Item("user_id").ToString)
                    With Item
                        .SubItems.Add(dr.Item("user_name"))
                        If utype = "0" Then
                            .SubItems.Add("Administrator")
                        ElseIf utype = "1" Then
                            .SubItems.Add("General Manager")
                        ElseIf utype = "2" Then
                            .SubItems.Add("Bills and Purchasing")
                        ElseIf utype = "3" Then
                            .SubItems.Add("Encoder")
                        End If
                        .SubItems.Add(dr.Item("user_password"))

                        '.SubItems.Add(dr.Item("user_type"))
                        '.SubItems.Add(dr.Item("user_password"))
                    End With
                Loop
            Else
                MsgBox("No record of users", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No users")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try
    End Sub
    Private Sub clearPanel()

        For Each Control In pnlAddEdit.Controls
            If TypeOf Control Is ComboBox Then
                Control.text = Nothing
            End If
        Next Control

        For Each Control In pnlAddEdit.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim data As New Dictionary(Of String, Object)

        If txtuname.Text = "" Or txtpw.Text = "" Or txtconfirmpwd.Text = "" Or cmbUtype.Text = "" Then
            MessageBox.Show("Some fields are empty.", "Fill up the Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If lblAddedit.Text = "Add new user" Then
            'ADDING NEW USER
            Try
                Dim encryptPass = Encrypt(txtpw.Text, "Keys")
                Dim encryptPass2 = Encrypt(txtconfirmpwd.Text, "Keys")
                data.Add("user_name", Trim(txtuname.Text))
                If cmbUtype.Text = "Administrator" Then
                    data.Add("user_type", "0")
                ElseIf cmbUtype.Text = "General Manager" Then
                    data.Add("user_type", "1")
                ElseIf cmbUtype.Text = "Bills and Purchasing" Then
                    data.Add("user_type", "2")
                ElseIf cmbUtype.Text = "Encoder" Then
                    data.Add("user_type", "3")
                End If
                If txtpw.Text = txtconfirmpwd.Text Then
                    data.Add("user_password", encryptPass)
                    data.Add("confirm_password", encryptPass2)
                Else
                    MessageBox.Show("Password do not match!", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If

                rec = db.ExecuteNonQuery("INSERT INTO tbl_users values(@user_name,@user_password,@confirm_password,@user_type)", data)

                If Not rec < 1 Then
                    log("User_id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "Add new user. New user, named:" & Trim(txtuname.Text))
                    MessageBox.Show("Record saved!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    'pnlMain.Visible = False
                    data.Clear()
                    showAddEdit(False)
                    clearPanel()
                    lvLoadListview()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Dispose() '<--------CHECK THIS!
            End Try


        ElseIf lblAddedit.Text = "Update system user" Then
            Try
                Dim encryptPass = Encrypt(txtpw.Text, "Keys")
                Dim encryptPass2 = Encrypt(txtconfirmpwd.Text, "Keys")
                data.Add("user_name", txtuname.Text)
                If cmbUtype.Text = "Super Administrator" Then
                    data.Add("user_type", "0")
                ElseIf cmbUtype.Text = "Administrator" Then
                    data.Add("user_type", "1")
                ElseIf cmbUtype.Text = "Encoder" Then
                    data.Add("user_type", "2")
                End If
                If txtpw.Text = txtconfirmpwd.Text Then
                    data.Add("user_password", encryptPass)
                    data.Add("confirm_password", encryptPass2)
                Else
                    MessageBox.Show("Password do not match!", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If

                rec = db.ExecuteNonQuery("UPDATE tbl_users SET user_name=@user_name, user_password=@user_password, confirm_password=@confirm_password, user_type=@user_type WHERE user_id=" & txtID.Text, data)

                If Not rec < 1 Then
                    log("User_id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "update user; User_ID:" & Trim(txtID.Text))
                    MessageBox.Show("Record updated!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    data.Clear()
                    showAddEdit(False)
                    clearPanel()
                    lvLoadListview()
                    lvUsers.SelectedItems.Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Dispose() '<--------CHECK THIS!
            End Try
        End If
        'MsgBox("Save!")
        'lvUsers.SelectedItems.Clear()
    End Sub

    Private Sub SystemUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvLoadListview()
    End Sub
 
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim txt As String
            If txtSearch.Text.Contains("'") Then
                txt = Replace(Trim(txtSearch.Text), "'", "''")
            Else
                txt = Trim(txtSearch.Text)
            End If
            lvUsers.Items.Clear()
            dr = db.ExecuteReader("SELECT user_id, user_name, user_type FROM tbl_users WHERE user_id LIKE '%" & txt & "%' OR user_name LIKE '%" & txt & "%'")
            If dr.HasRows Then
                Do While dr.Read
                    itm = lvUsers.Items.Add(dr.Item("user_id"))
                    itm.SubItems.Add(dr.Item("user_name"))
                    If dr.Item("user_type") = 2 Then
                        itm.SubItems.Add("Encoder")
                    ElseIf dr.Item("user_type") = 1 Then
                        itm.SubItems.Add("Admin")
                    Else
                        itm.SubItems.Add("Super Administrator")
                    End If
                Loop

            Else
                MsgBox("No record found.", vbExclamation + vbOKOnly, "No users")
            End If
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub
End Class
