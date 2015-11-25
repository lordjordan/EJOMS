Public Class Services
    Dim timerStopper As String
    Dim btnAddNewClick, btnEditClick, btnPrintClick, btnAddEditClosed As Boolean

    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
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
        showAddEdit(True)
        If pnlAddEdit.Height <> 200 Then
            lblAddedit.Text = "   Add new service"
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
        If selected_count = 1 Then
            With lvServices.SelectedItems.Item(0)
                txtServiceID.Text = .SubItems(0).Text.ToString
                txtServiceName.Text = .SubItems(1).Text.ToString
                txtServiceFee.Text = CDbl(.SubItems(2).Text)
            End With
            btnAddNewClick = True
            showAddEdit(True)
            If pnlAddEdit.Height <> 200 Then
                lblAddedit.Text = "   Update service"
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
        If txtServiceFee.Text = "" Or txtServiceName.Text = "" Or Val(txtServiceFee.Text) <= 0 Then
            MsgBox("Invalid Service name/ Service Fee.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Invalid Data")
            Exit Sub
        End If
        Try
            Dim parameters As New Dictionary(Of String, Object)
            parameters.Add("service_name", txtServiceName.Text.ToString)
            parameters.Add("service_fee", NumToStr(txtServiceFee.Text))
            If (txtServiceID.Text <> "") Then
                '@ Update selected Item
                parameters.Add("service_id", Val(txtServiceID.Text))
                If (db.ExecuteNonQuery("UPDATE tbl_services SET service_name=@service_name,service_fee=@service_fee WHERE service_id=@service_id", parameters) > 0) Then
                    MsgBox("Record Update!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Save Succesful")
                End If
                loadServiceListview()
            Else
                '@ Insert New record
                If db.ExecuteNonQuery("INSERT INTO tbl_services(service_name,service_fee) VALUES(@service_name,@service_fee)", parameters) > 0 Then
                    MsgBox("New Record Added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Succesful")
                    loadServiceListview()
                End If
            End If
        Catch ex As Exception
        Finally
            db.Dispose()
        End Try
        btnAddEditClose_Click(sender, e)
    End Sub
    Private Sub loadPerCarBrandListview()
        lvw_PerCarBrand.Items.Clear()
        Dim parameters As New Dictionary(Of String, Object)
        parameters.Add("service_id", lvServices.SelectedItems.Item(0).SubItems(0).Text)
        Try
            dr = db.ExecuteReader("SELECT scb_id,sc.service_fee,c.name FROM tbl_services_carbrands as sc JOIN tbl_car_brands c ON sc.car_brand_id=c.car_brand_id WHERE sc.service_id=@service_id", parameters)
            If dr.HasRows Then
                While dr.Read
                    With Me.lvw_PerCarBrand.Items.Add(dr.Item("scb_id").ToString)
                        .SubItems.Add(dr.Item("name").ToString)
                        .SubItems.Add(StrToNum(dr.Item("service_fee").ToString))
                    End With
                End While

            Else
                MsgBox("No Record found", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "No record found")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try
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
        cbo_carbrand.Items.Clear()
        dr = db.ExecuteReader("SELECT car_brand_id,name FROM tbl_car_brands")

        If dr.HasRows Then
            Do While dr.Read
                cbo_carbrand.Items.Add(dr.Item("name") & "                                                                                   000" & dr.Item("car_brand_id"))
            Loop
        End If
    End Sub
    Private Sub loadServiceListview()
        Dim parameters As New Dictionary(Of String, Object)
        lvServices.Items.Clear()
        Dim Item As ListViewItem
        parameters.Add("keyword", "%" & txtSearch.Text & "%")

        Try
            dr = db.ExecuteReader("SELECT service_id,service_name,service_fee FROM tbl_services WHERE service_name LIKE @keyword", parameters)
            If dr.HasRows Then
                Do While dr.Read
                    Item = Me.lvServices.Items.Add(dr.Item("service_id").ToString)
                    With Item
                        .SubItems.Add(dr.Item("service_name"))
                        .SubItems.Add(StrToNum(dr.Item("service_fee"), 2))
                    End With

                    'With Me.lvServices.Items.Add(dr.Item("service_id").ToString)
                    '    .SubItems.Add(dr.Item("service_name").ToString)
                    '    .SubItems.Add(dr.Item("service_fee").ToString)
                    'End With
                Loop
            Else
                MsgBox("No record of services", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No services")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try
    End Sub
    Private Sub Services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadServiceListview()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        loadServiceListview()
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
End Class
