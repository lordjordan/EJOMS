Imports System.Data.SqlClient
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Xml
Imports System.Data
Public Class Items
  
    Dim ds As New DataSet
    Dim con As New SqlClient.SqlConnection

    Dim da As SqlClient.SqlDataAdapter
    Dim rptItems As New ItemReport
    Dim timerStopper As String
    Dim btnAddNewClick, btnEditClick, btnPrintClick, btnAddEditClosed As Boolean


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
        pnlAddEdit.BringToFront()
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
        txt_critical_level.Text = lvItems.FocusedItem.SubItems(4).Text
        showAddEdit(True)
        pnlAddEdit.BringToFront()
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
        If correctInputs() = False Then
            Exit Sub
        End If
        saveItem()
        load_items()
        uscMainmenu.get_notifications()
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
            Dim txt As String
            If txtSearch.Text.Contains("'") Then
                txt = Replace(Trim(txtSearch.Text), "'", "''")
            Else
                txt = Trim(txtSearch.Text)
            End If
            lvItems.Items.Clear()
            If cbx_in_critical_level.Checked = True Then
                dr = db.ExecuteReader("SELECT * FROM tbl_items WHERE item_id LIKE '%" & txt & "%' OR name LIKE '%" & _
                txt & "%' AND quantity <= critical_level")
            Else
                dr = db.ExecuteReader("SELECT * FROM tbl_items WHERE item_id LIKE '%" & txt & "%' OR name LIKE '%" & _
                txt & "%'")

            End If
            If dr.HasRows Then
                Do While dr.Read
                    itm = lvItems.Items.Add(dr.Item("item_id"))
                    itm.SubItems.Add(dr.Item("name"))
                    itm.SubItems.Add(StrToNum(dr.Item("price")))
                    itm.SubItems.Add(dr.Item("quantity"))
                    itm.SubItems.Add(dr.Item("critical_level"))
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
            If cbx_in_critical_level.Checked = True Then
                dr = db.ExecuteReader("SELECT * FROM tbl_items WHERE quantity <= critical_level")
            Else
                dr = db.ExecuteReader("SELECT * FROM tbl_items")

            End If
            If dr.HasRows Then
                Do While dr.Read
                    itm = lvItems.Items.Add(dr.Item("item_id"))
                    itm.SubItems.Add(dr.Item("name"))
                    itm.SubItems.Add(StrToNum(dr.Item("price")))
                    itm.SubItems.Add(dr.Item("quantity"))
                    itm.SubItems.Add(dr.Item("critical_level"))

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
        'If correctInputs() = False Then Exit Sub
        Try
            data.Add("name", txtPartsname.Text)
            data.Add("price", NumToStr(txtPrice.Text))
            data.Add("quantity", txtQuantity.Text)
            data.Add("time_stamp", Date.Now)
            data.Add("critical_level", txt_critical_level.Text)
            If lblAddedit.Text = "   Add new item" Then

                rec = db.ExecuteNonQuery("INSERT INTO tbl_items(name, price, quantity,time_stamp,critical_level) VALUES(@name, @price, @quantity,@time_stamp,@critical_level)", data)
                log("User id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "; add new item; Item_name:" & txtPartsname.Text)
                MsgBox("Record saved!", vbInformation + vbOKOnly, "Saved")
            ElseIf lblAddedit.Text = "   Update item" Then

                rec = db.ExecuteNonQuery("UPDATE tbl_items set name =@name , price= @price, quantity = @quantity, time_stamp = @time_stamp,critical_level=@critical_level WHERE item_id=" & txtItemID.Text, data)
                log("User id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "; update item; Item_id:" & txtItemID.Text)
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
            MsgBox("Please complete the fields.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
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


    Private Sub cbx_in_critical_level_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_in_critical_level.CheckedChanged
        load_items()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        showPrintMe(True)
        Try
            ds.Tables.Clear()
            pnl_item_report.BringToFront()
            Dim row As DataRow = Nothing
            ds.Tables.Add("Items")
            With ds.Tables(0).Columns
                '.Add("item_id")
                .Add("name")
                .Add("price")
                .Add("quantity")
                .Add("critical_level")
            End With


            For x = 1 To lvItems.Items.Count Step 1
                row = ds.Tables(0).NewRow

                row(0) = lvItems.Items(x - 1).SubItems(1).Text
                row(1) = lvItems.Items(x - 1).SubItems(2).Text
                row(2) = lvItems.Items(x - 1).SubItems(3).Text
                row(3) = lvItems.Items(x - 1).SubItems(4).Text


                ds.Tables(0).Rows.Add(row)
            Next
            ds.WriteXml("XML\ItemsReport.xml")
            Dim dsItem As New DataSet
            dsItem = New dsReportJobsOrder
            Dim dsItemTemp As New DataSet
            dsItemTemp = New DataSet()
            dsItemTemp.ReadXml("XML\ItemsReport.xml")
            dsItem.Merge(dsItemTemp.Tables(0))
            rptItems = New ItemReport
            rptItems.SetDataSource(dsItem)
            crv_items.ReportSource = rptItems
            Exit Sub
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        End Try
        'crv_items.ReportSource = Nothing
        'crv_items.Refresh()
        'ds.Tables.Clear()

        'con.ConnectionString = My.Settings.DBconn
        'Dim query As String

        'If cbx_in_critical_level.Checked = True Then
        '    query = "SELECT * FROM tbl_items WHERE item_id LIKE '%" & txtSearch.Text & "%' OR name LIKE '%" & _
        '    txtSearch.Text & "%' AND quantity <= critical_level"
        'Else
        '    query = "SELECT * FROM tbl_items WHERE item_id LIKE '%" & txtSearch.Text & "%' OR name LIKE '%" & _
        '    txtSearch.Text & "%'"
        'End If
        'Try


        'da = New SqlClient.SqlDataAdapter(query, con)
        '    da.Fill(ds, "Items")

        'If (ds.Tables.Count) Then
        '    ds.WriteXml("XML\ItemsReport.xml")
        'End If

        'Dim dsItem As New DataSet
        '    dsItem = New dsReportJobsOrder
        'Dim dsItemTemp As New DataSet
        'dsItemTemp = New DataSet()
        'dsItemTemp.ReadXml("XML\ItemsReport.xml")
        'dsItem.Merge(dsItemTemp.Tables(0))
        'rptItems = New ItemReport
        'rptItems.SetDataSource(dsItem)
        'crv_items.ReportSource = rptItems
        '    'pnl_item_report.Visible = True

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub showPrintMe(mode As Boolean)
        pnl_item_report.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub
    Private Sub btn_report_back_Click(sender As Object, e As EventArgs) Handles btn_report_back.Click
        showPrintMe(False)
    End Sub

    Private Sub btn_print_report_Click(sender As Object, e As EventArgs) Handles btn_print_report.Click
        crv_items.PrintReport()
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If e.Handled = (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
