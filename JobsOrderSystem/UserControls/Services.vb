﻿Public Class Services
    Dim timerStopper As String
    Dim btnAddNewClick, btnEditClick, btnPrintClick, btnAddEditClosed As Boolean


    Dim itm As ListViewItem
    Dim cmd As SqlClient.SqlCommand
    Private Sub showAddEdit(mode As Boolean)
        pnlAddEdit.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        showUSC(uscMainmenu)
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        btnAddNewClick = True
        lblAddedit.Text = "   Add new service"
        Label4.Visible = False
        txtServiceID.Visible = False
        showAddEdit(True)


        If pnlAddEdit.Height <> 200 Then

            timerAnimate.Start()
        End If
    End Sub
    Private Sub btnAddEditClose_Click(sender As Object, e As EventArgs) Handles btnAddEditClose.Click
        lvServices.SelectedItems.Clear()
        btnAddEditClosed = True
        If pnlAddEdit.Height <> 0 Then

            timerAnimate.Start()

        End If
        pnlMain.Enabled = True
        reset_service_form()
    End Sub
    Private Sub reset_service_form()
        txtServiceFee.Text = ""
        txtServiceID.Text = ""
        txtServiceName.Text = ""
    End Sub
    Private Sub reset_carbrand()
        txt_adjusted_price.Text = ""
        cbo_carbrand.Text = ""
        lbl_scb_id.Text = ""
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selected_count As Integer
        selected_count = lvServices.SelectedItems.Count
        Label4.Visible = True
        txtServiceID.Visible = True
        lblAddedit.Text = "   Update service"
        If selected_count = 1 Then
            With lvServices.SelectedItems.Item(0)
                txtServiceID.Text = .SubItems(0).Text.ToString
                txtServiceName.Text = .SubItems(1).Text.ToString
                txtServiceFee.Text = CDbl(.SubItems(2).Text)
            End With
            btnAddNewClick = True
            showAddEdit(True)
            If pnlAddEdit.Height <> 200 Then

                timerAnimate.Start()
            End If
        ElseIf selected_count >= 1 Then
            MsgBox("Multiple records selected. Please select one record to update. ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Else
            MsgBox("Please select a record to edit.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Record Selected")
        End If


    End Sub
    Private Sub timerAnimate_Tick(sender As Object, e As EventArgs) Handles timerAnimate.Tick
        'opening
        If btnAddNewClick = True Then
            timerStopper = pnlAddEdit.Height
            If timerStopper = 200 Then
                timerAnimate.Stop()
                btnAddNewClick = False
                Exit Sub
            End If
            pnlAddEdit.Height += 50

        ElseIf btnEditClick = True Then
            timerStopper = pnlAddEdit.Height
            If timerStopper = 200 Then

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
        If correctInputs() = False Then Exit Sub
        'If txtServiceFee.Text = "" Or txtServiceName.Text = "" Or Val(txtServiceFee.Text) <= 0 Then
        '    MsgBox("Invalid Service name/ Service Fee.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Invalid Data")
        '    Exit Sub
        'End If
        Try
            Dim parameters As New Dictionary(Of String, Object)
            parameters.Add("service_name", txtServiceName.Text.ToString)
            parameters.Add("service_fee", NumToStr(txtServiceFee.Text))
            If (txtServiceID.Text <> "") Then
                '@ Update selected Item
                parameters.Add("service_id", Val(txtServiceID.Text))
                If (db.ExecuteNonQuery("UPDATE tbl_services SET service_name=@service_name,service_fee=@service_fee WHERE service_id=@service_id", parameters) > 0) Then
                    log("User id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "; update service. Service_ID:" & txtServiceID.Text)
                    MsgBox("Record Update!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Save Succesful")
                End If
                load_Listview()
            Else
                '@ Insert New record
                If db.ExecuteNonQuery("INSERT INTO tbl_services(service_name,service_fee) VALUES(@service_name,@service_fee)", parameters) > 0 Then
                    log("User id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "; add new service. Service_name:" & txtServiceName.Text)
                    MsgBox("New Record Added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Succesful")
                    load_Listview()
                End If
            End If
            ClearTextBoxes()
        Catch ex As Exception

            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")

        Finally
            db.Dispose()
        End Try
        btnAddEditClose_Click(sender, e)
    End Sub
    Private Sub loadPerCarBrandListview()
        'lvw_PerCarBrand.Items.Clear()
        'Dim parameters As New Dictionary(Of String, Object)
        'parameters.Add("service_id", lvServices.SelectedItems.Item(0).SubItems(0).Text)
        'Try
        '    dr = db.ExecuteReader("SELECT scb_id,sc.service_fee,c.name FROM tbl_services_carbrands as sc JOIN tbl_car_brands c ON sc.car_brand_id=c.car_brand_id WHERE sc.service_id=@service_id", parameters)
        '    If dr.HasRows Then
        '        While dr.Read
        '            With Me.lvw_PerCarBrand.Items.Add(dr.Item("scb_id").ToString)
        '                .SubItems.Add(dr.Item("name").ToString)
        '                .SubItems.Add(StrToNum(dr.Item("service_fee").ToString))
        '            End With
        '        End While

        '    Else
        '        MsgBox("No Record found", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "No record found")
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'Finally
        '    db.Dispose()
        'End Try
    End Sub
    Private Sub loadCarBrands()
        'If (lvw_PerCarBrand.Items.Count > 1) Then
        '    Dim exempted(lvw_PerCarBrand.Items.Count - 1) As String
        '    Dim sql_exempted As String
        '    Dim counter As Integer = 0
        '    For Each x As ListViewItem In lvw_PerCarBrand.Items
        '        'MsgBox(x.SubItems(1).Text)
        '        exempted(counter) = "'" & x.SubItems(1).Text & "'"
        '        counter += 1
        '    Next
        '    sql_exempted = "(" & [String].Join(",", exempted) & ")"

        '    dr = db.ExecuteReader("SELECT car_brand_id,name FROM tbl_car_brands WHERE name NOT IN " & sql_exempted)
        'Else

        'End If
        'cbo_carbrand.Items.Clear()
        'dr = db.ExecuteReader("SELECT car_brand_id,name FROM tbl_car_brands")

        'If dr.HasRows Then
        '    Do While dr.Read
        '        cbo_carbrand.Items.Add(dr.Item("name") & "                                                                                   000" & dr.Item("car_brand_id"))
        '    Loop
        'End If
    End Sub
    Public Sub load_Listview()
        Dim parameters As New Dictionary(Of String, Object)
        lvServices.Items.Clear()
        Dim Item As ListViewItem


        Try
            dr = db.ExecuteReader("SELECT service_id,service_name,service_fee FROM tbl_services")
            If dr.HasRows Then
                Do While dr.Read
                    Item = Me.lvServices.Items.Add(dr.Item("service_id").ToString)
                    With Item
                        .SubItems.Add(dr.Item("service_name"))
                        .SubItems.Add(StrToNum(dr.Item("service_fee")))
                    End With

                    'With Me.lvServices.Items.Add(dr.Item("service_id").ToString)
                    '    .SubItems.Add(dr.Item("service_name").ToString)
                    '    .SubItems.Add(dr.Item("service_fee").ToString)
                    'End With
                Loop
                ToolStripStatusLabel1.Text = "Count: " & lvServices.Items.Count
            Else
                MsgBox("No record of services", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No services")
            End If
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub




    Private Sub btn_PricePerCarBrand_Click(sender As Object, e As EventArgs) Handles btn_PricePerCarBrand.Click
        Dim selected_count As Integer
        selected_count = lvServices.SelectedItems.Count
        If selected_count = 1 Then
            'With lvServices.SelectedItems.Item(0)
            '    txtServiceID.Text = .SubItems(0).Text.ToString
            '    txtServiceName.Text = .SubItems(1).Text.ToString
            '    txtServiceFee.Text = CDbl(.SubItems(2).Text)
            'End With
            With lvServices.SelectedItems.Item(0)
                txt_PCB_ID.Text = .SubItems(0).Text
                txt_PCB_service_name.Text = .SubItems(1).Text
                txt_PCB_service_fee.Text = .SubItems(2).Text
            End With
            pnlMain.Enabled = False
            pnl_PerCarBrand.Visible = True
            loadPerCarBrandListview()
            loadCarBrands()

        ElseIf selected_count >= 1 Then
            MsgBox("Multiple records selected. Please select one record to Edit. ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Else
            MsgBox("Please select a record to edit.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Record Selected")
        End If
    End Sub

    Private Sub btn_PerCarBrandClose_Click(sender As Object, e As EventArgs) Handles btn_PerCarBrandClose.Click
        reset_carbrand()
        pnl_PerCarBrand.Visible = False
        pnlMain.Enabled = True
    End Sub

    Private Sub btn_PerCarBrandAddNew_Click(sender As Object, e As EventArgs) Handles btn_PerCarBrandAddNew.Click
        use_form(True)
    End Sub
    Private Sub use_form(mode As Boolean)
        btn_PerCarBrandAddNew.Enabled = Not mode
        btn_PerCarBrandUpdate.Enabled = Not mode
        btn_PerCarBrandClose.Enabled = Not mode
        lvw_PerCarBrand.Enabled = Not mode
        pnl_PerCarBrandForm.Enabled = mode
    End Sub
    Private Sub btn_PerCarBrandUpdate_Click(sender As Object, e As EventArgs) Handles btn_PerCarBrandUpdate.Click
        Dim selected As Integer = lvw_PerCarBrand.SelectedItems.Count
        use_form(False)

        If selected = 1 Then
            With lvw_PerCarBrand.SelectedItems.Item(0)
                txt_adjusted_price.Text = StrToNum(.SubItems(2).Text, 2, False)
                lbl_scb_id.Text = .SubItems(0).Text
            End With
        ElseIf selected > 1 Then
            MsgBox("Multiple records selected. Please select one record to Edit. ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

        ElseIf selected < 1 Then
            MsgBox("Please select a record to edit.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Record Selected")
        End If
    End Sub

    Private Sub btn_PerCarBrandCancel_Click(sender As Object, e As EventArgs) Handles btn_PerCarBrandCancel.Click
        reset_carbrand()
        use_form(False)

    End Sub

    Private Sub btn_PerCarBrandSave_Click(sender As Object, e As EventArgs) Handles btn_PerCarBrandSave.Click

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            data.Add("keyword", "%" & Trim(txtSearch.Text) & "%")
            lvServices.Items.Clear()
            dr = db.ExecuteReader("SELECT * FROM tbl_services WHERE service_id LIKE @keyword OR " & _
                                  "service_name LIKE @keyword", data)
            If dr.HasRows Then
                Do While dr.Read
                    itm = lvServices.Items.Add(dr.Item("service_id"))
                    itm.SubItems.Add(dr.Item("service_name"))
                    itm.SubItems.Add(StrToNum(dr.Item("service_fee")))
                Loop
            Else
                MsgBox("No records", vbExclamation + vbOKOnly, "No data")
            End If
            ToolStripStatusLabel1.Text = "Count: " & lvServices.Items.Count
            data.Clear()
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub
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
    Private Function correctInputs()
        If txtServiceName.Text = "" Or txtServiceFee.Text = "" Then
            MsgBox("Some fields are empty", vbExclamation + vbOKOnly, "Empty fields")
            Return False
        Else
            Return True
        End If


    End Function

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
        End If
    End Sub
    Private Sub showPrintMe(mode As Boolean)
        pnlPrint.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            showPrintMe(True)
            Dim row1 As DataRow = Nothing
            Dim DS As New DataSet
            Dim rptINC As New ServicesReport
            'mag a-add na sa dataset (DS)
            DS.Tables.Add("ServicesReport")
            'lagay tayo ng columns
            With DS.Tables(0).Columns
                .Add("service_id")
                .Add("service_name")
                .Add("service_fee")
            End With
            For x = 1 To lvServices.Items.Count Step 1
                row1 = DS.Tables(0).NewRow
                row1(0) = lvServices.Items(x - 1).Text
                row1(1) = lvServices.Items(x - 1).SubItems(1).Text
                row1(2) = lvServices.Items(x - 1).SubItems(2).Text
                DS.Tables(0).Rows.Add(row1)
            Next

            DS.WriteXml("XML\ServicesReport.xml")

            Dim dsINC As New DataSet
            dsINC = New dsReportJobsOrder
            Dim dsINCTemp As New DataSet
            dsINCTemp = New DataSet()
            'dsINCTemp = New DSreports
            dsINCTemp.ReadXml("XML\ServicesReport.xml")
            dsINC.Merge(dsINCTemp.Tables(0))

            'MsgBox(dsINCTemp.Tables(0).Rows(0).Item(0).ToString)
            rptINC = New ServicesReport
            rptINC.SetDataSource(dsINCTemp.Tables(0))
            crvServices.ReportSource = rptINC

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancelPrintattack_Click(sender As Object, e As EventArgs) Handles btnCancelPrintattack.Click
        showPrintMe(False)
    End Sub

    Private Sub txtServiceFee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServiceFee.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub
End Class
