Imports System.Data.SqlClient
Public Class Items
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlDataReader
    Dim itm As ListViewItem
    Dim timerStopper As String
    Dim btnAddNewClick, btnEditClick, btnPrintClick, btnAddEditClosed As Boolean
    Dim rec As Integer
    Dim data As New Dictionary(Of String, Object)
    Private Sub showAddEdit(mode As Boolean)
        pnlAddEdit.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        showUSC(uscMainmenu)
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        btnAddNewClick = True
        lblItemID.Visible = False
        txtItemID.Visible = False
        lblAddedit.Text = "   Add new item"

        showAddEdit(True)
        If pnlAddEdit.Height <> 250 Then

            timerAnimate.Start()
        End If

    End Sub
    'Clears all textboxes
    Public Sub ClearTextBoxes(Optional ByVal ctlcol As Control.ControlCollection = Nothing)
        If ctlcol Is Nothing Then ctlcol = Me.Controls
        For Each ctl As Control In ctlcol
            If TypeOf (ctl) Is TextBox Then
                DirectCast(ctl, TextBox).Clear()
            Else
                If Not ctl.Controls Is Nothing OrElse ctl.Controls.Count <> 0 Then
                    ClearTextBoxes(ctl.Controls)
                End If
            End If
        Next
    End Sub
    Private Sub btnAddEditClose_Click(sender As Object, e As EventArgs) Handles btnAddEditClose.Click

        btnAddEditClosed = True
        If pnlAddEdit.Height <> 0 Then

            timerAnimate.Start()

        End If

        'pnlAddEdit.Visible = False
        ClearTextBoxes()
        pnlMain.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lvItems.SelectedItems.Count = 0 Then
            MsgBox("Please select an item.", vbExclamation + vbOKOnly, "Please select")
            Exit Sub
        End If
        btnAddNewClick = True
        lblItemID.Visible = True
        txtItemID.Visible = True
        lblAddedit.Text = "   Update item"
        txtItemID.Text = lvItems.FocusedItem.Text
        txtPartsname.Text = lvItems.FocusedItem.SubItems(1).Text
        txtPrice.Text = lvItems.FocusedItem.SubItems(2).Text
        txtQuantity.Text = lvItems.FocusedItem.SubItems(3).Text
        showAddEdit(True)
        If pnlAddEdit.Height <> 250 Then
            timerAnimate.Start()
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
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveItem()
        load_items()
        btnAddEditClose_Click(sender, e)

    End Sub
    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If e.Handled = (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            lvItems.Items.Clear()
            dr = db.ExecuteReader("SELECT * FROM tbl_items WHERE item_id LIKE '%" & txtSearch.Text & "%' OR name LIKE '%" & _
                                 txtSearch.Text & "%'")
            If dr.HasRows Then
                Do While dr.Read
                    itm = lvItems.Items.Add(dr.Item("item_id"))
                    itm.SubItems.Add(dr.Item("name"))
                    itm.SubItems.Add(StrToNum(dr.Item("price")))
                    itm.SubItems.Add(dr.Item("quantity"))
                Loop

            Else
                MsgBox("No item found!", vbExclamation + vbOKOnly, "No record(s)")
            End If
            ToolStripStatusLabel1.Text = "Count: " & lvItems.Items.Count
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try

    End Sub






    'Methods
    Public Sub load_items()
        Try
            lvItems.Items.Clear()
            dr = db.ExecuteReader("SELECT * FROM tbl_items")
            If dr.HasRows Then
                Do While dr.Read
                    itm = lvItems.Items.Add(dr.Item("item_id"))
                    itm.SubItems.Add(dr.Item("name"))
                    itm.SubItems.Add(StrToNum(dr.Item("price")))
                    itm.SubItems.Add(dr.Item("quantity"))
                Loop
            Else
                MsgBox("No items found", vbInformation + vbOKOnly, "No record(s).")
            End If
            ToolStripStatusLabel1.Text = "Count: " & lvItems.Items.Count
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub saveItem()
        If correctInputs() = False Then Exit Sub
        Try
            data.Add("name", txtPartsname.Text)
            data.Add("price", NumToStr(txtPrice.Text))
            data.Add("quantity", txtQuantity.Text)
            data.Add("time_stamp", Date.Now)
            If lblAddedit.Text = "   Add new item" Then

                rec = db.ExecuteNonQuery("INSERT INTO tbl_items(name, price, quantity,time_stamp) VALUES(@name, @price, @quantity,@time_stamp)", data)

                MsgBox("Record saved!", vbInformation + vbOKOnly, "Saved")
            ElseIf lblAddedit.Text = "   Update item" Then

                rec = db.ExecuteNonQuery("UPDATE tbl_items set name =@name , price= @price, quantity = @quantity, time_stamp = @time_stamp WHERE item_id=" & txtItemID.Text, data)

                MsgBox("Record updated!", vbInformation + vbOKOnly, "Updated")

            End If
            ClearTextBoxes()
            data.Clear()
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
        
    End Sub


    Private Function correctInputs()
        If txtPartsname.Text = "" Or txtPrice.Text = "" Or txtQuantity.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
        End If
    End Sub


End Class
