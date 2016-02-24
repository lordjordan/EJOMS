Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Security.Cryptography

Public Class JobOrder

    Dim timerStopper As String
    Dim btnAddNewClick, btnEditClick, btnPrintClick, btnAddEditClosed As Boolean
  
    Dim da As SqlDataAdapter
   
    Dim con As New SqlConnection
    Dim itm As ListViewItem
    Dim tax_val As Double
    Dim ds, tempDs As New DataSet

    Dim boolVoid As Boolean
    Dim sourcePath As String
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

    Public Shared Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String

        DES.Key = frmLogin.MD5Hash(key)
        DES.Mode = CipherMode.ECB

        Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
        Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function
    Private Sub showAddEdit(mode As Boolean)
        pnlAddEdit.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub
    Public Sub showVerifyAcc(mode As Boolean)
        pnlVerify.BringToFront()
        pnlVerify.Visible = mode
        pnlAddEdit.Enabled = Not mode
    End Sub
    Private Sub showEditQuan(mode As Boolean)
        pnlQuan.Visible = mode
        pnlAddEdit.Enabled = Not mode
    End Sub
    Private Sub showCars(mode As Boolean)
        pnlCar.BringToFront()
        pnlCar.Visible = mode
        pnlAddEdit.Enabled = Not mode
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        showUSC(uscMainmenu)
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        Try
            btnAddNewClick = True
            showAddEdit(True)
            ClearTextBoxes()
            lblAddedit.Text = "   Add new job order"
            dtReceived.Value = Date.Now
            Label4.Visible = False
            txtJobID.Visible = False
            txtStatus.Text = "Unpaid"

            chkTax.Text = "With " & getTax() & "% tax amt.:"
            chkTax.Checked = False
            lblInspectForm.Text = "Upload inspection form"
            If pnlAddEdit.Height <> 650 Then
                timerAnimate.Start()
            End If
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error!")
        Finally
            db.Dispose()
        End Try


    End Sub
    Private Sub btnAddEditClose_Click(sender As Object, e As EventArgs) Handles btnAddEditClose.Click
        Try
            btnAddEditClosed = True
            If pnlAddEdit.Height <> 0 Then
                timerAnimate.Start()
            End If
           
            lvJobOrderList.Items.Clear()
            dr = db.ExecuteReader("SELECT job_id , last_name + ', '+ first_name + ' ' + middle_name as name , car_model_year, plate_no, status " & _
                                  "FROM tbl_job_orders INNER JOIN tbl_cars on tbl_job_orders.car_id = tbl_cars.car_id WHERE status =  1") 'pendings lang muna
            If dr.HasRows Then
                Do While dr.Read
                    itm = lvJobOrderList.Items.Add(dr.Item("job_id"))
                    itm.SubItems.Add(dr.Item("name"))
                    itm.SubItems.Add(dr.Item("car_model_year"))
                    itm.SubItems.Add(dr.Item("plate_no"))
                    itm.SubItems.Add("Unpaid") ' condition if filter na.
                Loop
            End If
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbExclamation + vbOKOnly, "Error")
        Finally
            db.Dispose()
            ds.Tables.Clear()
        End Try

        ClearTextBoxes()
        pnlMain.Enabled = True
        'visiblesParts(False)
        'visiblesServices(False)
        enable(True)
    End Sub
    Public Function getTax()
        dr = db.ExecuteReader("SELECT tax_default FROM tbl_tax")
        dr.Read()
        Return dr.Item("tax_default")
    End Function
    Private Sub enable(mode As Boolean)

        txtMechanic.Enabled = mode
        txtElectrician.Enabled = mode
        txtDetailing.Enabled = mode
        dtReceived.Enabled = mode
        chkTax.Enabled = mode
        cbxOrdertype.Enabled = mode
        btnSearchPlate.Enabled = mode
        btnBrowseInspect.Enabled = mode
        btnViewImg.Enabled = mode
        btnEditPrice.Enabled = mode
        btnEditQuantity.Enabled = mode
        btnRemoveItem.Enabled = mode
        btnSearchParts.Enabled = mode
        ContextMenuStrip1.Enabled = mode
        ContextMenuStrip2.Enabled = mode
        btnEditServiceFee.Enabled = mode
        btnRemoveServices.Enabled = mode
        btnSearchService.Enabled = mode
        btnSave.Enabled = mode
    End Sub
    Public Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lvJobOrderList.SelectedItems.Count = 0 Then
            MsgBox("Please select an order", vbExclamation + vbOKOnly, "Select")
            Exit Sub
        End If
        Try
            pnlAddEdit.BringToFront()
            btnAddNewClick = True
            showAddEdit(True)
            lblAddedit.Text = "   Update job order"
            Label4.Visible = True
            txtJobID.Visible = True

            txtPlateno.Text = lvJobOrderList.FocusedItem.SubItems(3).Text
            txtName.Text = lvJobOrderList.FocusedItem.SubItems(1).Text
            txtJobID.Text = lvJobOrderList.FocusedItem.Text


            dr = db.ExecuteReader("SELECT * FROM tbl_job_orders WHERE job_id = " & txtJobID.Text)
            dr.Read()
            If dr.HasRows Then
                chkTax.Text = "With " & dr.Item("tax_val") & "% tax amt.:"
                dtReceived.Value = StrToDate(dr.Item("date_received"))
                txtMechanic.Text = dr.Item("mechanic")
                txtElectrician.Text = dr.Item("electrician")
                txtDetailing.Text = dr.Item("detailing")

                If dr.Item("trans_type") = 0 Then
                    cbxOrdertype.SelectedIndex = 0
                    trans_type = 0
                Else
                    cbxOrdertype.SelectedIndex = 1
                    trans_type = 1
                End If
                lblCarId.Text = dr.Item("car_id") 'base tayo here para makuha ang car info!
                If dr.Item("status") = 0 Then
                    txtStatus.Text = "Paid"
                    enable(False)
                ElseIf dr.Item("status") = 1 Then
                    txtStatus.Text = "Unpaid"
                    enable(True)

                ElseIf dr.Item("status") = 2 Then
                    txtStatus.Text = "For quotation"
                    enable(True)
                Else
                    txtStatus.Text = "Voided"
                    enable(False)
                End If
                
                txtMarkup.Text = dr.Item("mark_up_val")
                txtFindings.Text = dr.Item("findings")
                txtRemarks.Text = dr.Item("remarks")
                If IsNothing(dr.Item("inspection_img")) Then
                    lblInspectForm.Text = "Upload inspection form"
                    txtImage.Text = ""
                Else
                    lblInspectForm.Text = "Update inspection form"
                    txtImage.Text = "To preview, click the view icon."
                End If
            Else
                MsgBox("No data!", vbExclamation + vbOKOnly, "No info")
                Exit Sub
            End If
            lvParts.Items.Clear()
            If dr.Item("w_tax") = 0 Then
                chkTax.Checked = False
            Else
                chkTax.Checked = True
            End If
            dr = db.ExecuteReader("SELECT car_id, contact_no, email, address, " & _
                                  "name, car_model_year, vin_chassis_no, color, mileage, engine_no , fuel_type, transmission,percentage " & _
                                  "FROM tbl_cars INNER JOIN tbl_car_brands ON tbl_cars.car_brand_id = tbl_car_brands.car_brand_id WHERE car_id = " & lblCarId.Text)
            If dr.HasRows Then
                dr.Read()
                lblCarId.Text = dr.Item("car_id")
                txtContact.Text = dr.Item("contact_no")
                txtEmail.Text = dr.Item("email")
                txtAddress.Text = dr.Item("address")
                txtBrand.Text = dr.Item("name")
                txtCarMod.Text = dr.Item("car_model_year")
                txtVin.Text = dr.Item("vin_chassis_no")
                txtColor.Text = dr.Item("color")
                txtMileage.Text = dr.Item("mileage")
                txtEngine.Text = dr.Item("engine_no")
                txtMarkup.Text = dr.Item("percentage")
                If dr.Item("fuel_type") = 0 Then
                    txtFuel.Text = "Gas"
                ElseIf dr.Item("fuel_type") = 1 Then
                    txtFuel.Text = "Diesel"
                Else
                    txtFuel.Text = "Hybrid"
                End If
                If dr.Item("transmission") = 0 Then
                    txtTransmission.Text = "Manual"
                Else
                    txtTransmission.Text = "Automatic"
                End If
            End If
            dr = db.ExecuteReader("SELECT * FROM tbl_ordered_items WHERE job_id=" & txtJobID.Text) ' ordered items
            If dr.HasRows Then
                Do While dr.Read
                    itm = lvParts.Items.Add(dr.Item("jo_item_id"))
                    itm.SubItems.Add(dr.Item("quantity"))
                    itm.SubItems.Add(dr.Item("name"))
                    itm.SubItems.Add(IIf(user_type <> 3, StrToNum(dr.Item("price")), 0))
                    itm.SubItems.Add("")
                Loop
            End If
            dr = db.ExecuteReader("SELECT * FROM tbl_ordered_services WHERE job_id=" & txtJobID.Text) ' ordered services
            If dr.HasRows Then
                Do While dr.Read
                    itm = lvServices.Items.Add(dr.Item("jo_service_id"))
                    itm.SubItems.Add(dr.Item("service_name"))
                    itm.SubItems.Add(IIf(user_type <> 3, StrToNum(dr.Item("service_fee")), 0))
                Loop
            End If
            Dim row As DataRow = Nothing
            ds.Tables.Add("lvItems")
            With ds.Tables("lvItems").Columns
                .Add("item_id")
                .Add("quantity")
            End With
            For x = 1 To lvParts.Items.Count Step 1
                row = ds.Tables("lvItems").NewRow
                row(0) = lvParts.Items(x - 1).Text
                row(1) = lvParts.Items(x - 1).SubItems(1).Text
                ds.Tables("lvItems").Rows.Add(row)
            Next
            'calculate each price
            computeEachTotalPrice()
           




            If pnlAddEdit.Height <> 650 Then

                timerAnimate.Start()
            End If
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub
    Private Sub computeEachTotalPrice()
        Try
            Dim totalOrderAmount As Double = 0
            Dim totalServiceFee As Double = 0
            For x = 1 To lvParts.Items.Count Step 1
                lvParts.Items(x - 1).SubItems(4).Text = FormatNumber((lvParts.Items(x - 1).SubItems(1).Text) * Val(Replace(lvParts.Items(x - 1).SubItems(3).Text, ",", "")))
                totalOrderAmount += Val(Replace(lvParts.Items(x - 1).SubItems(4).Text, ",", ""))
            Next
            txtTotalOrder.Text = FormatNumber(totalOrderAmount)
            For x = 1 To lvServices.Items.Count Step 1
                totalServiceFee += Val(Replace(lvServices.Items(x - 1).SubItems(2).Text, ",", ""))
            Next
            txtTotalServices.Text = FormatNumber(totalServiceFee)
            dr = db.ExecuteReader("SELECT tax_val FROM tbl_job_orders WHERE job_id= " & txtJobID.Text)
            dr.Read()
            Dim taxval As Double = CDbl("1." & dr.Item("tax_val"))
            txtTaxValue.Text = FormatNumber((Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", ""))) - _
                                            ((Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", ""))) _
                                             / taxval))
            If chkTax.Checked = False Then
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")))
            Else
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")) + Val(Replace(txtTaxValue.Text, ",", "")))
            End If
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try

        'txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")))
    End Sub
    Private Sub timerAnimate_Tick(sender As Object, e As EventArgs) Handles timerAnimate.Tick
        'opening
        If btnAddNewClick = True Then
            timerStopper = pnlAddEdit.Height
            If timerStopper = 650 Then
                timerAnimate.Stop()
                btnAddNewClick = False
                Exit Sub
            End If
            pnlAddEdit.Height += 50

        ElseIf btnEditClick = True Then
            timerStopper = pnlAddEdit.Height
            If timerStopper = 650 Then

                timerAnimate.Stop()
                btnEditClick = False
                Exit Sub
            End If
            pnlAddEdit.Height += 50



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

        If validationTechnique() = False Then
            Exit Sub
        End If
        saveJobsOrder()
        uscMainmenu.get_notifications()
        enable(True)
        loadJobsOrder()

    End Sub


   
    Private Sub btnSearchPlate_Click(sender As Object, e As EventArgs) Handles btnSearchPlate.Click
        showCars(True)
    End Sub

    Private Sub btnCloseBrand_Click(sender As Object, e As EventArgs) Handles btnCloseBrand.Click
        showCars(False)
    End Sub

    Private Sub btn_Searchcar_Click(sender As Object, e As EventArgs) Handles btn_Searchcar.Click
        Try
            lvCars.Items.Clear()
            Dim txt As String
            If txtSearchCar.Text.Contains("'") Then
                txt = Replace(Trim(txtSearchCar.Text), "'", "''")
            Else
                txt = Trim(txtSearchCar.Text)
            End If
            dr = db.ExecuteReader("SELECT car_id, last_name + ', ' + first_name + ' ' + middle_name as name , car_model_year, plate_no " & _
                                  "FROM tbl_cars WHERE plate_no like '%" & txt & "%' or car_model_year like '%" & txt & "%' " & _
                                  "or first_name like '%" & txt & "%' or last_name like '%" & txt & "%' or " & _
                                  "middle_name like '%" & txt & "%'")
            If dr.HasRows Then
                Do While dr.Read
                    itm = lvCars.Items.Add(dr.Item("car_id"))
                    itm.SubItems.Add(dr.Item("name"))
                    itm.SubItems.Add(dr.Item("car_model_year"))
                    itm.SubItems.Add(dr.Item("plate_no"))
                Loop
            Else
                MsgBox("No results found!", vbInformation + vbOKOnly, "No record(s)")
            End If
        Catch ex As Exception
            MsgBox("Error occured" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub txtSearchCar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchCar.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_Searchcar_Click(sender, e)
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
            lvJobOrderList.Items.Clear()
            If cbxFilter.SelectedIndex = 0 Or cbxFilter.Text = Nothing Then 'all
                dr = db.ExecuteReader("SELECT job_id , last_name + ', '+ first_name + ' ' + middle_name as name , car_model_year, plate_no, status " & _
                                  "FROM tbl_job_orders INNER JOIN tbl_cars on tbl_job_orders.car_id = tbl_cars.car_id WHERE job_id LIKE '%" & _
                                  txt & "%' OR first_name LIKE '%" & txt & "%' OR last_name LIKE '%" & _
                                   txt & "%' OR middle_name LIKE '%" & txt & "%' OR car_model_year LIKE '%" & _
                                   txt & "%' OR plate_no LIKE '%" & txt & "%' ORDER BY job_id DESC")

            ElseIf cbxFilter.SelectedIndex = 2 Then 'unpaid
                dr = db.ExecuteReader("SELECT job_id , last_name + ', '+ first_name + ' ' + middle_name as name , car_model_year, plate_no, status " & _
                                  "FROM (SELECT job_id, status, car_id FROM tbl_job_orders WHERE status = 1) as tblJO " & _
                                  "INNER JOIN tbl_cars on tblJO.car_id = tbl_cars.car_id WHERE job_id LIKE '%" & _
                                   txt & "%' OR first_name LIKE '%" & txt & "%' OR last_name LIKE '%" & _
                                   txt & "%' OR middle_name LIKE '%" & txt & "%' OR car_model_year LIKE '%" & _
                                   txt & "%' OR plate_no LIKE '%" & txt & "%' ORDER BY job_id DESC")
            ElseIf cbxFilter.SelectedIndex = 1 Then 'paid
                dr = db.ExecuteReader("SELECT job_id , last_name + ', '+ first_name + ' ' + middle_name as name , car_model_year, plate_no, status " & _
                                  "FROM (SELECT job_id, status, car_id FROM tbl_job_orders WHERE status = 0) as tblJO " & _
                                  "INNER JOIN tbl_cars on tblJO.car_id = tbl_cars.car_id WHERE job_id LIKE '%" & _
                                   txt & "%' OR first_name LIKE '%" & txt & "%' OR last_name LIKE '%" & _
                                  txt & "%' OR middle_name LIKE '%" & txt & "%' OR car_model_year LIKE '%" & _
                                   txt & "%' OR plate_no LIKE '%" & txt & "%' ORDER BY job_id DESC")
            ElseIf cbxFilter.SelectedIndex = 3 Then 'for quotation
                dr = db.ExecuteReader("SELECT job_id , last_name + ', '+ first_name + ' ' + middle_name as name , car_model_year, plate_no, status " & _
                                  "FROM (SELECT job_id, status, car_id FROM tbl_job_orders WHERE status = 2) as tblJO " & _
                                  "INNER JOIN tbl_cars on tblJO.car_id = tbl_cars.car_id WHERE job_id LIKE '%" & _
                                   txt & "%' OR first_name LIKE '%" & txt & "%' OR last_name LIKE '%" & _
                                   txt & "%' OR middle_name LIKE '%" & txt & "%' OR car_model_year LIKE '%" & _
                                   txt & "%' OR plate_no LIKE '%" & txt & "%' ORDER BY job_id DESC")
            Else 'voided
                dr = db.ExecuteReader("SELECT job_id , last_name + ', '+ first_name + ' ' + middle_name as name , car_model_year, plate_no, status " & _
                                  "FROM (SELECT job_id, status, car_id FROM tbl_job_orders WHERE status = 3) as tblJO " & _
                                  "INNER JOIN tbl_cars on tblJO.car_id = tbl_cars.car_id WHERE job_id LIKE '%" & _
                                   txt & "%' OR first_name LIKE '%" & txt & "%' OR last_name LIKE '%" & _
                                   txt & "%' OR middle_name LIKE '%" & txt & "%' OR car_model_year LIKE '%" & _
                                   txt & "%' OR plate_no LIKE '%" & txt & "%' ORDER BY job_id DESC")
            End If

            If dr.HasRows Then
                Do While dr.Read
                    itm = lvJobOrderList.Items.Add(dr.Item("job_id"))
                    itm.SubItems.Add(dr.Item("name"))
                    itm.SubItems.Add(dr.Item("car_model_year"))
                    itm.SubItems.Add(dr.Item("plate_no"))
                    If dr.Item("status") = 0 Then
                        itm.SubItems.Add("Paid")
                    ElseIf dr.Item("status") = 1 Then
                        itm.SubItems.Add("Unpaid")
                    ElseIf dr.Item("status") = 2 Then
                        itm.SubItems.Add("For quotation")
                    Else
                        itm.SubItems.Add("Voided")
                    End If
                Loop
            End If
        Catch ex As Exception
            MsgBox("Error occured" & vbCrLf & ex.ToString, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub
    Private Sub btnSelectCar_Click(sender As Object, e As EventArgs) Handles btnSelectCar.Click
        If lvCars.SelectedItems.Count = 0 Then
            MsgBox("Please select a car", vbExclamation + vbOKOnly, "Select")
            Exit Sub
        End If
        If lblCarId.Text <> "" And lvParts.Items.Count <> 0 Or lvServices.Items.Count <> 0 Then
            Select Case MsgBox("All inputs will change or remove because you select a car again, " & vbCrLf & "Do you want to proceed?" _
                      , vbQuestion + vbYesNo, "Are you sure?")
                Case vbYes
                    ClearTextBoxes()
                    lblCarId.Text = ""
                    lvParts.Items.Clear()
                    lvServices.Items.Clear()
                Case vbNo
                    Exit Sub
            End Select
        End If
        txtPlateno.Text = lvCars.FocusedItem.SubItems(3).Text
        txtName.Text = lvCars.FocusedItem.SubItems(1).Text
        txtCarMod.Text = lvCars.FocusedItem.SubItems(2).Text
        Try
            dr = db.ExecuteReader("SELECT car_id, contact_no, email, address, " & _
                                  "name, car_model_year, vin_chassis_no, color, mileage, engine_no , fuel_type, transmission,percentage " & _
                                  "FROM tbl_cars INNER JOIN tbl_car_brands ON tbl_cars.car_brand_id = tbl_car_brands.car_brand_id WHERE car_id = " & lvCars.FocusedItem.Text)
            If dr.HasRows Then
                dr.Read()
                lblCarId.Text = dr.Item("car_id")
                txtContact.Text = dr.Item("contact_no")
                txtEmail.Text = dr.Item("email")
                txtAddress.Text = dr.Item("address")
                txtBrand.Text = dr.Item("name")
                txtCarMod.Text = dr.Item("car_model_year")
                txtVin.Text = dr.Item("vin_chassis_no")
                txtColor.Text = dr.Item("color")
                txtMileage.Text = dr.Item("mileage")
                txtEngine.Text = dr.Item("engine_no")
                txtMarkup.Text = dr.Item("percentage")
                If dr.Item("fuel_type") = 0 Then
                    txtFuel.Text = "Gas"
                ElseIf dr.Item("fuel_type") = 1 Then
                    txtFuel.Text = "Diesel"
                ElseIf dr.Item("fuel_type") = 2 Then
                    txtFuel.Text = "Hybrid"
                End If
                If dr.Item("transmission") = 0 Then
                    txtTransmission.Text = "Manual"
                Else
                    txtTransmission.Text = "Automatic"
                End If

            End If
            showCars(False)
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString)
        Finally
            db.Dispose()
        End Try


    End Sub


    Private Sub cbxOrdertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOrdertype.SelectedIndexChanged
        'trans_type
        
        If user_type = 3 Then
            If cbxOrdertype.SelectedIndex = 0 Then
                txtStatus.Text = "For quotation"
            Else
                txtStatus.Text = "Unpaid"
            End If
        Else
            If cbxOrdertype.SelectedIndex = 0 Then
                txtStatus.Text = "For quotation"
                btnPayment.Visible = False
            Else
                txtStatus.Text = "Unpaid"
                btnPayment.Visible = True
            End If
        End If

    End Sub

    Private Sub btnSearchParts_Click(sender As Object, e As EventArgs) Handles btnSearchParts.Click
        If txtPlateno.Text = "" Then
            MsgBox("Please select a car. Click the search button beside the plate no. field.", vbExclamation + vbOKOnly, "Select")
            Exit Sub
        End If
        frmItems.ShowDialog()
    End Sub
    Private Sub btnSearchService_Click(sender As Object, e As EventArgs) Handles btnSearchService.Click
        If txtPlateno.Text = "" Then
            MsgBox("Please select a car. Click the search button beside the plate no. field.", vbExclamation + vbOKOnly, "Select")
            Exit Sub
        End If
        frmServices.ShowDialog()
    End Sub
    Private Sub lvCars_DoubleClick(sender As Object, e As EventArgs) Handles lvCars.DoubleClick
        btnSelectCar_Click(sender, e)
    End Sub
    Private Sub QuantityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuantityToolStripMenuItem.Click
        lblQuanPrice.Text = "Enter quantity"
        pnlQuan.BringToFront()
        If lvParts.Items.Count = 0 Then
            MsgBox("No order.", vbExclamation + vbOKOnly)
            Exit Sub
        End If
        If lvParts.SelectedItems.Count = 0 Then
            MsgBox("Please select an item", vbExclamation + vbOKOnly, "Select")
            Exit Sub
        End If
        txtSelecteditem.Text = lvParts.FocusedItem.SubItems(2).Text
        txtQuantity.Text = lvParts.FocusedItem.SubItems(1).Text
        showEditQuan(True)
    End Sub
    Private Sub UnitPriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TSMUnitPrice.Click
        lblQuanPrice.Text = "Enter unit price"
        pnlQuan.BringToFront()
        If lvParts.Items.Count = 0 Then
            MsgBox("No order.", vbExclamation + vbOKOnly)
            Exit Sub
        End If
        If lvParts.SelectedItems.Count = 0 Then

            MsgBox("Please select an item", vbExclamation + vbOKOnly, "Select")
            Exit Sub
        End If
        txtSelecteditem.Text = lvParts.FocusedItem.SubItems(2).Text
        txtQuantity.Text = Replace(lvParts.FocusedItem.SubItems(3).Text, ",", "")
        showEditQuan(True)

    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TSMServiceFee.Click
        lblQuanPrice.Text = "Edit service fee"
        pnlQuan.BringToFront()
        If lvServices.Items.Count = 0 Then
            MsgBox("No order.", vbExclamation + vbOKOnly)
            Exit Sub
        End If
        If lvServices.SelectedItems.Count = 0 Then

            MsgBox("Please select a service", vbExclamation + vbOKOnly, "Select")
            Exit Sub
        End If
        txtSelecteditem.Text = lvServices.FocusedItem.SubItems(1).Text
        txtQuantity.Text = Replace(lvServices.FocusedItem.SubItems(2).Text, ",", "")
        showEditQuan(True)
    End Sub
    Private Sub btnx_Click(sender As Object, e As EventArgs) Handles btnx.Click
        showEditQuan(False)
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim totalOrderAmount As Double = 0
            Dim totalServicesFee As Double = 0
            If lblQuanPrice.Text = "Enter quantity" Then
                lvParts.FocusedItem.SubItems(1).Text = txtQuantity.Text
                lvParts.FocusedItem.SubItems(4).Text = FormatNumber(Val(lvParts.FocusedItem.SubItems(1).Text) * Val(Replace(lvParts.FocusedItem.SubItems(3).Text, ",", "")))
                For x = 1 To lvParts.Items.Count
                    totalOrderAmount += Val(Replace(lvParts.Items(x - 1).SubItems(4).Text, ",", ""))
                Next
                txtTotalOrder.Text = FormatNumber(totalOrderAmount)

                showEditQuan(False)
                txtQuantity.Clear()
            ElseIf lblQuanPrice.Text = "Enter unit price" Then
                lvParts.FocusedItem.SubItems(3).Text = FormatNumber(txtQuantity.Text)
                lvParts.FocusedItem.SubItems(4).Text = FormatNumber(Val(lvParts.FocusedItem.SubItems(1).Text) * Val(Replace(lvParts.FocusedItem.SubItems(3).Text, ",", "")))
                For x = 1 To lvParts.Items.Count
                    totalOrderAmount += Val(Replace(lvParts.Items(x - 1).SubItems(4).Text, ",", ""))
                Next
                txtTotalOrder.Text = FormatNumber(totalOrderAmount)

                showEditQuan(False)
                txtQuantity.Clear()
            ElseIf lblQuanPrice.Text = "Edit service fee" Then
                lvServices.FocusedItem.SubItems(2).Text = FormatNumber(txtQuantity.Text)
                For x = 1 To lvServices.Items.Count
                    totalServicesFee += Val(Replace(lvServices.Items(x - 1).SubItems(2).Text, ",", ""))
                Next
                txtTotalServices.Text = FormatNumber(totalServicesFee)

                showEditQuan(False)
                txtQuantity.Clear()
            End If
            If lblAddedit.Text = "   Add new job order" Then
                txtTaxValue.Text = FormatNumber((Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", ""))) * (getTax() / 100))
                If chkTax.Checked = False Then
                    txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")))
                Else
                    txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")) + Val(Replace(txtTaxValue.Text, ",", "")))
                End If
            Else
                dr = db.ExecuteReader("SELECT tax_val FROM tbl_job_orders WHERE job_id= " & txtJobID.Text)
                dr.Read()
                txtTaxValue.Text = FormatNumber((Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", ""))) * (dr.Item("tax_val") / 100))
                If chkTax.Checked = False Then
                    txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")))
                Else
                    txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")) + Val(Replace(txtTaxValue.Text, ",", "")))
                End If
            End If
            '  txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")))

        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try


    End Sub


    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If lvParts.Items.Count = 0 Then
            MsgBox("No order.", vbExclamation + vbOKOnly)
            Exit Sub
        End If
        If lvParts.SelectedItems.Count = 0 Then
            MsgBox("Please select an item to be removed.", vbExclamation + vbOKOnly, "Select")
            Exit Sub
        End If
        Select Case MsgBox("Remove this item?" & vbCrLf & "- " & lvParts.FocusedItem.SubItems(2).Text _
                           , vbInformation + vbYesNo, "Are you sure?")
            Case vbYes
                lvParts.FocusedItem.Remove()
            Case vbNo
                Exit Sub
        End Select
        Dim totalOrderAmount As Double = 0
        For x = 1 To lvParts.Items.Count
            totalOrderAmount += Val(Replace(lvParts.Items(x - 1).SubItems(4).Text, ",", ""))
        Next
        txtTotalOrder.Text = FormatNumber(totalOrderAmount)
        If lblAddedit.Text = "   Add new job order" Then
            txtTaxValue.Text = FormatNumber((Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", ""))) * (getTax() / 100))
            If chkTax.Checked = False Then
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")))
            Else
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")) + Val(Replace(txtTaxValue.Text, ",", "")))
            End If
        Else
            dr = db.ExecuteReader("SELECT tax_val FROM tbl_job_orders WHERE job_id= " & txtJobID.Text)
            dr.Read()
            txtTaxValue.Text = FormatNumber((Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", ""))) * (dr.Item("tax_val") / 100))
            If chkTax.Checked = False Then
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")))
            Else
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")) + Val(Replace(txtTaxValue.Text, ",", "")))
            End If
        End If
        'If lvParts.Items.Count = 0 Then
        '    visiblesParts(False)
        'End If
        'txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")))

    End Sub
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        If lvServices.SelectedItems.Count = 0 Then
            MsgBox("Please select a service to be removed.", vbExclamation + vbOKOnly, "Select")
            Exit Sub
        End If
        Select Case MsgBox("Remove this service?" & vbCrLf & "- " & lvServices.FocusedItem.SubItems(1).Text _
                           , vbInformation + vbYesNo, "Are you sure?")
            Case vbYes
                lvServices.FocusedItem.Remove()
            Case vbNo
                Exit Sub
        End Select
        Dim totalservicesfee As Double = 0
        For x = 1 To lvServices.Items.Count
            totalservicesfee += Val(Replace(lvServices.Items(x - 1).SubItems(2).Text, ",", ""))
        Next
        txtTotalServices.Text = FormatNumber(totalservicesfee)
        'txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")))
        If lblAddedit.Text = "   Add new job order" Then
            txtTaxValue.Text = FormatNumber((Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", ""))) * (getTax() / 100))
            If chkTax.Checked = False Then
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")))
            Else
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")) + Val(Replace(txtTaxValue.Text, ",", "")))
            End If
        Else
            dr = db.ExecuteReader("SELECT tax_val FROM tbl_job_orders WHERE job_id= " & txtJobID.Text)
            dr.Read()
            txtTaxValue.Text = FormatNumber((Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", ""))) * (dr.Item("tax_val") / 100))
            If chkTax.Checked = False Then
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")))
            Else
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")) + Val(Replace(txtTaxValue.Text, ",", "")))
            End If
        End If
        'If lvServices.Items.Count = 0 Then
        '    visiblesServices(False)
        'End If
    End Sub
    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If lblQuanPrice.Text = "Enter Quantity" Then
            If Asc(e.KeyChar) <> 8 Then
                If e.Handled = (Char.IsDigit(e.KeyChar)) Then
                    e.Handled = True
                End If
            End If
        Else
            If Asc(e.KeyChar) <> 8 Then
                If e.Handled = (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                    e.Handled = True
                End If
            End If
        End If

    End Sub
    Private Sub btnViewImg_Click(sender As Object, e As EventArgs) Handles btnViewImg.Click
        Try


            If lblInspectForm.Text = "Upload inspection form" Then
                'ito file path muna :3
                If txtImage.Text <> "" Then
                    frmPreviewImg.PictureBox1.Load(txtImage.Text)
                    frmPreviewImg.ShowDialog()
                ElseIf txtImage.Text = "" Then
                    MsgBox("No attach file", vbExclamation + vbOKOnly, "Insert image first")
                End If
            Else 'update inspection form

                If txtImage.Text = "To preview, click the view icon." Then 'ilabas ang sa database
                    'query


                    dr = db.ExecuteReader("SELECT inspection_img FROM tbl_job_orders WHERE job_id =" & txtJobID.Text)
                    dr.Read()
                    If dr.HasRows Then
                        Dim imagestream As System.IO.MemoryStream = New System.IO.MemoryStream
                        Dim imgbyte As Byte()
                        imgbyte = dr.Item("inspection_img")
                        imagestream = New System.IO.MemoryStream(imgbyte)
                        frmPreviewImg.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                        frmPreviewImg.PictureBox1.Image = Drawing.Image.FromStream(imagestream)
                        frmPreviewImg.ShowDialog()
                    End If
                ElseIf txtImage.Text = "" Then
                    MsgBox("No attach file")
                Else 'update ang image 
                    'query
                    frmPreviewImg.PictureBox1.Load(txtImage.Text)
                    frmPreviewImg.ShowDialog()
                End If
                'may form na lalabas pero sa database na ang lalabas
                'condition pa if ilalabas kung sa db or openfile dialog
            End If
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub

    'methods
    Public Sub loadJobsOrder()
        Try
            lvJobOrderList.Items.Clear()
            dr = db.ExecuteReader("SELECT job_id , last_name + ', '+ first_name + ' ' + middle_name as name , car_model_year, plate_no, status " & _
                                  "FROM tbl_job_orders INNER JOIN tbl_cars on tbl_job_orders.car_id = tbl_cars.car_id WHERE status =  1 ORDER BY job_id DESC") 'pendings lang muna
            If dr.HasRows Then
                Do While dr.Read
                    itm = lvJobOrderList.Items.Add(dr.Item("job_id"))
                    itm.SubItems.Add(dr.Item("name"))
                    itm.SubItems.Add(dr.Item("car_model_year"))
                    itm.SubItems.Add(dr.Item("plate_no"))
                    itm.SubItems.Add("Unpaid") ' condition if filter na.
                Loop
            Else
                MsgBox("No orders!", vbInformation + vbOKOnly, "No record(s)")
            End If
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
        cbxOrdertype.Text = Nothing
        lvParts.Items.Clear()
        lvServices.Items.Clear()
        chkTax.Checked = False
    End Sub
  

    Private Function validationTechnique()
        If txtPlateno.Text = "" Then
            MsgBox("Please select a car", vbExclamation + vbOKOnly, "Select")
            btnSearchPlate.Focus()
            Return False
            Exit Function
        End If
        If txtMechanic.Text = "" And txtElectrician.Text = "" And txtDetailing.Text = "" Then
            MsgBox("Please assigned at least 1 employee in the following:" & vbCrLf & "- Mechanic" & _
                   vbCrLf & "- Electrician" & vbCrLf & "- Detailing", vbExclamation + vbOKOnly, "Assign")
            Return False
            Exit Function
        End If
        
        If lvParts.Items.Count = 0 And lvServices.Items.Count = 0 Then
            MsgBox("No jobs order.", vbExclamation + vbOKOnly, "Please specify!")
            Return False
            Exit Function
        End If
        If txtFindings.Text = "" Then
            MsgBox("Please input the findings/recommendations.", vbExclamation + vbOKOnly, "Input")
            Return False
            Exit Function
        End If
        Return True
    End Function
    Dim imgbyte As Byte() = Nothing
    Private Sub saveJobsOrder()
        Try

            Dim query, fState, lState As String
            fState = "BEGIN TRANSACTION"
            lState = "COMMIT"
            data.Add("date_received", DateToStr(dtReceived.Value))
            data.Add("mechanic", Trim(txtMechanic.Text))
            data.Add("electrician", Trim(txtElectrician.Text))
            data.Add("detailing", Trim(txtDetailing.Text))
            data.Add("trans_type", cbxOrdertype.SelectedIndex)
            data.Add("car_id", lblCarId.Text)
            data.Add("findings", Trim(txtFindings.Text))
            data.Add("remarks", Trim(txtRemarks.Text))
            data.Add("mark_up_val", txtMarkup.Text)

            If lblAddedit.Text = "   Add new job order" Then

                If txtImage.Text = "" Then
                    data.Add("inspection_img", imgbyte) 'sana gumana
                Else
                    Dim myimage As Image = Image.FromFile(uscJobOrder.txtImage.Text)
                    Dim imagestream As System.IO.MemoryStream = New System.IO.MemoryStream
                    myimage.Save(imagestream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    imgbyte = imagestream.GetBuffer()
                    imagestream = New System.IO.MemoryStream(imgbyte)
                    data.Add("inspection_img", imgbyte)
                End If

                If cbxOrdertype.SelectedIndex = 0 Then
                    data.Add("status", 2)
                Else
                    data.Add("status", 1)
                End If
                If chkTax.Checked = True Then
                    data.Add("tax_val", getTax())
                    data.Add("w_tax", 1)
                Else
                    data.Add("tax_val", getTax())
                    data.Add("w_tax", 0)
                End If

                query = "INSERT INTO tbl_job_orders(date_received , mechanic, electrician, detailing, trans_type, " & _
                                         "car_id, findings, remarks, inspection_img,mark_up_val, status,tax_val,w_tax) VALUES(@date_received, @mechanic, @electrician, @detailing, " & _
                                         "@trans_type, @car_id, @findings, @remarks, @inspection_img, @mark_up_val, @status, @tax_val, @w_tax)" & vbCrLf & _
                " DECLARE @c_id INT " & vbCrLf &
                " SET @c_id = SCOPE_IDENTITY()" & vbCrLf
                'loop ng mga items at services
                If lvParts.Items.Count <> 0 Then
                    If trans_type = 0 Then
                        For x = 1 To lvParts.Items.Count Step 1
                            'dbtime_stmp = (lvParts.Items(x - 1).SubItems(1).Text)
                            query += "INSERT INTO tbl_ordered_items(jo_item_id,job_id,name,price,quantity) " & _
                                "values (" & lvParts.Items(x - 1).Text & ", @c_id, '" & validateQoutes(lvParts.Items(x - 1).SubItems(2).Text) & "', '" & _
                               NumToStr(lvParts.Items(x - 1).SubItems(3).Text) & "', " & lvParts.Items(x - 1).SubItems(1).Text & ") " & vbCrLf
                        Next
                    Else
                        For x = 1 To lvParts.Items.Count Step 1
                            'dbtime_stmp = (lvParts.Items(x - 1).SubItems(1).Text)
                            query += "INSERT INTO tbl_ordered_items(jo_item_id,job_id,name,price,quantity) " & _
                                "values (" & lvParts.Items(x - 1).Text & ", @c_id, '" & validateQoutes(lvParts.Items(x - 1).SubItems(2).Text) & "', '" & _
                               NumToStr(lvParts.Items(x - 1).SubItems(3).Text) & "', " & lvParts.Items(x - 1).SubItems(1).Text & ") " & vbCrLf & _
                            " UPDATE tbl_items set quantity -= " & Val(lvParts.Items(x - 1).SubItems(1).Text) & vbCrLf & _
                            ", time_stamp= '" & Date.Now & "' WHERE item_id= " & lvParts.Items(x - 1).Text & vbCrLf
                        Next
                    End If
                End If
                If lvServices.Items.Count <> 0 Then
                    For x = 1 To lvServices.Items.Count Step 1
                        query += "INSERT INTO tbl_ordered_services(jo_service_id,job_id,service_name,service_fee) " & _
                            "values (" & lvServices.Items(x - 1).Text & ", @c_id, '" & validateQoutes(lvServices.Items(x - 1).SubItems(1).Text) & "', '" & _
                             NumToStr(lvServices.Items(x - 1).SubItems(2).Text) & "' ) " & vbCrLf
                    Next
                End If

                rec = db.ExecuteNonQuery(fState & vbCrLf & query & vbCrLf & lState, data)
                log("User_id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "; add new job order; plate_no:" & txtPlateno.Text)
                MsgBox("Record saved!", vbInformation + vbOKOnly, "Saved")

            Else

                If user_type = 3 Then
                    SetCueText(txtUsername, "Username")
                    SetCueText(txtPassword, "Password")
                    showVerifyAcc(True)
                    tempDs = ds.Copy
                    data.Clear()
                    Exit Sub
                End If

                If txtStatus.Text = "Paid" Then
                    data.Add("status", 0)
                ElseIf txtStatus.Text = "Unpaid" Then
                    data.Add("status", 1)
                ElseIf txtStatus.Text = "For quotation" Then
                    data.Add("status", 2)
                Else
                    data.Add("status", 3)
                End If
                If chkTax.Checked = False Then
                    data.Add("w_tax", 0)
                Else
                    data.Add("w_tax", 1)
                End If

                If txtImage.Text <> "To preview, click the view icon." Then
                    Dim myimage As Image = Image.FromFile(uscJobOrder.txtImage.Text)
                    Dim imagestream As System.IO.MemoryStream = New System.IO.MemoryStream
                    myimage.Save(imagestream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    imgbyte = imagestream.GetBuffer()
                    imagestream = New System.IO.MemoryStream(imgbyte)
                    data.Add("inspection_img", imgbyte)
                    query = "UPDATE tbl_job_orders set date_received = @date_received, mechanic=@mechanic, electrician=@electrician, " & _
                    "detailing = @detailing, trans_type=@trans_type, car_id=@car_id, findings=@findings, remarks=@remarks, " & _
                    "mark_up_val= @mark_up_val ,inspection_img= @inspection_img, status= @status, w_tax = @w_tax WHERE job_id = " & txtJobID.Text & vbCrLf
                Else
                    query = "UPDATE tbl_job_orders set date_received = @date_received, mechanic=@mechanic, electrician=@electrician, " & _
                    "detailing = @detailing, trans_type=@trans_type, car_id=@car_id, findings=@findings, remarks=@remarks, " & _
                    "mark_up_val= @mark_up_val, status= @status, w_tax = @w_tax WHERE job_id = " & txtJobID.Text & vbCrLf
                End If
                'dagdag items
                'For x = 1 To ds.Tables("lvItems").Rows.Count Step 1
                '    query += "UPDATE tbl_items SET quantity += " & ds.Tables("lvItems").Rows(x - 1).Item("quantity").ToString & _
                '        ", time_stamp= '" & Date.Now & "' WHERE item_id= " & ds.Tables("lvItems").Rows(x - 1).Item("item_id").ToString & vbCrLf  'time stamp
                'Next
                'bawas items
                'For x = 1 To lvParts.Items.Count Step 1
                '    query += "INSERT INTO tbl_ordered_items(jo_item_id,job_id,name,price,quantity) " & _
                '        "values (" & lvParts.Items(x - 1).Text & "," & txtJobID.Text & ", '" & lvParts.Items(x - 1).SubItems(2).Text & "', '" & _
                '        NumToStr(lvParts.Items(x - 1).SubItems(3).Text) & "', " & lvParts.Items(x - 1).SubItems(1).Text & ") " & vbCrLf & _
                '    " UPDATE tbl_items set quantity -= " & Val(lvParts.Items(x - 1).SubItems(1).Text) & vbCrLf & _
                '    ", time_stamp= '" & Date.Now & "' WHERE item_id= " & lvParts.Items(x - 1).Text & vbCrLf
                'Next

                query += "DELETE FROM tbl_ordered_items WHERE job_id =" & txtJobID.Text & vbCrLf
                query += "DELETE FROM tbl_ordered_services WHERE job_id =" & txtJobID.Text & vbCrLf

                If lvParts.Items.Count <> 0 Then
                    If trans_type = 0 And cbxOrdertype.SelectedIndex = 1 Then
                        For x = 1 To lvParts.Items.Count Step 1
                            query += "INSERT INTO tbl_ordered_items(jo_item_id,job_id,name,price,quantity) " & _
                                "values (" & lvParts.Items(x - 1).Text & "," & txtJobID.Text & ", '" & validateQoutes(lvParts.Items(x - 1).SubItems(2).Text) & "', '" & _
                                NumToStr(lvParts.Items(x - 1).SubItems(3).Text) & "', " & lvParts.Items(x - 1).SubItems(1).Text & ") " & vbCrLf & _
                            " UPDATE tbl_items set quantity -= " & Val(lvParts.Items(x - 1).SubItems(1).Text) & vbCrLf & _
                            ", time_stamp= '" & Date.Now & "' WHERE item_id= " & lvParts.Items(x - 1).Text & vbCrLf
                        Next
                    ElseIf trans_type = 1 And cbxOrdertype.SelectedIndex = 0 Then
                        For x = 1 To ds.Tables("lvItems").Rows.Count Step 1
                            query += "UPDATE tbl_items SET quantity += " & ds.Tables("lvItems").Rows(x - 1).Item("quantity").ToString & _
                                ", time_stamp= '" & Date.Now & "' WHERE item_id= " & ds.Tables("lvItems").Rows(x - 1).Item("item_id").ToString & vbCrLf  'time stamp
                        Next

                        For x = 1 To lvParts.Items.Count Step 1
                            query += "INSERT INTO tbl_ordered_items(jo_item_id,job_id,name,price,quantity) " & _
                                "values (" & lvParts.Items(x - 1).Text & "," & txtJobID.Text & ", '" & validateQoutes(lvParts.Items(x - 1).SubItems(2).Text) & "', '" & _
                                NumToStr(lvParts.Items(x - 1).SubItems(3).Text) & "', " & lvParts.Items(x - 1).SubItems(1).Text & ") " & vbCrLf
                        Next

                    ElseIf trans_type = 0 And cbxOrdertype.SelectedIndex = 0 Then
                        For x = 1 To lvParts.Items.Count Step 1
                            query += "INSERT INTO tbl_ordered_items(jo_item_id,job_id,name,price,quantity) " & _
                                "values (" & lvParts.Items(x - 1).Text & "," & txtJobID.Text & ", '" & validateQoutes(lvParts.Items(x - 1).SubItems(2).Text) & "', '" & _
                                NumToStr(lvParts.Items(x - 1).SubItems(3).Text) & "', " & lvParts.Items(x - 1).SubItems(1).Text & ") " & vbCrLf
                        Next
                    ElseIf trans_type = 1 And cbxOrdertype.SelectedIndex = 1 Then
                        For x = 1 To ds.Tables("lvItems").Rows.Count Step 1
                            query += "UPDATE tbl_items SET quantity += " & ds.Tables("lvItems").Rows(x - 1).Item("quantity").ToString & _
                                ", time_stamp= '" & Date.Now & "' WHERE item_id= " & ds.Tables("lvItems").Rows(x - 1).Item("item_id").ToString & vbCrLf  'time stamp
                        Next

                        For x = 1 To lvParts.Items.Count Step 1
                            query += "INSERT INTO tbl_ordered_items(jo_item_id,job_id,name,price,quantity) " & _
                                "values (" & lvParts.Items(x - 1).Text & "," & txtJobID.Text & ", '" & validateQoutes(lvParts.Items(x - 1).SubItems(2).Text) & "', '" & _
                                NumToStr(lvParts.Items(x - 1).SubItems(3).Text) & "', " & lvParts.Items(x - 1).SubItems(1).Text & ") " & vbCrLf & _
                            " UPDATE tbl_items set quantity -= " & Val(lvParts.Items(x - 1).SubItems(1).Text) & vbCrLf & _
                            ", time_stamp= '" & Date.Now & "' WHERE item_id= " & lvParts.Items(x - 1).Text & vbCrLf
                        Next
                    End If

                End If

                If lvServices.Items.Count <> 0 Then
                    For x = 1 To lvServices.Items.Count Step 1
                        query += "INSERT INTO tbl_ordered_services(jo_service_id,job_id,service_name,service_fee) " & _
                            "values (" & lvServices.Items(x - 1).Text & "," & txtJobID.Text & ", '" & validateQoutes(lvServices.Items(x - 1).SubItems(1).Text) & "', '" & _
                             NumToStr(lvServices.Items(x - 1).SubItems(2).Text) & "' ) " & vbCrLf
                    Next
                End If
                rec = db.ExecuteNonQuery(fState & vbCrLf & query & vbCrLf & lState, data)
                log("User_id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "; update job order; Job_id:" & txtJobID.Text)
                MsgBox("Record updated!", vbInformation + vbOKOnly, "Updated")

            End If
            data.Clear()
            ClearTextBoxes()
            lblCarId.Text = ""
            lvParts.Items.Clear()
            lvServices.Items.Clear()
            uscMainmenu.get_notifications()
            showAddEdit(False)

        Catch ex As Exception
            data.Clear()
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
            ds.Tables.Clear()
        End Try
    End Sub




    Private Sub btnBrowseInspect_Click(sender As Object, e As EventArgs) Handles btnBrowseInspect.Click
        OpenFileDialog1.ShowDialog()
        txtImage.Text = OpenFileDialog1.FileName
    End Sub






    Public Sub chkTax_CheckedChanged(sender As Object, e As EventArgs) Handles chkTax.CheckedChanged
        If lblAddedit.Text = "   Add new job order" Then
            Dim taxval As Double = CDbl("1." & getTax())
            txtTaxValue.Text = FormatNumber((Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", ""))) - _
                                            ((Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", ""))) _
                                             / taxval))
            If chkTax.Checked = False Then
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")))
            Else
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")) + Val(Replace(txtTaxValue.Text, ",", "")))
            End If
        Else
            dr = db.ExecuteReader("SELECT tax_val FROM tbl_job_orders WHERE job_id= " & txtJobID.Text)
            dr.Read()
            Dim taxval As Double = CDbl("1." & dr.Item("tax_val"))
            txtTaxValue.Text = FormatNumber((Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", ""))) - _
                                            ((Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", ""))) _
                                             / taxval))
            txtTaxValue.Text = FormatNumber((Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", ""))) * (dr.Item("tax_val") / 100))
            If chkTax.Checked = False Then
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")))
            Else
                txtOverallAmount.Text = FormatNumber(Val(Replace(txtTotalOrder.Text, ",", "")) + Val(Replace(txtTotalServices.Text, ",", "")) + Val(Replace(txtTaxValue.Text, ",", "")))
            End If
        End If
    End Sub

    'Private Function getTimeStamp(item_id As String)
    '    dr = db.ExecuteReader("SELECT time_stamp FROM tbl_items WHERE item_id=" & item_id)
    '    dr.Read()
    '    Return dr.Item("time_stamp")
    'End Function

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If txtStatus.Text = "Voided" Then
            frm_payment.gpb_payment.Enabled = False
            frm_payment.btn_add.Enabled = False
            frm_payment.btn_edit.Enabled = False
            frm_payment.btn_delete.Enabled = False
        End If
        frm_payment.ShowDialog()
    End Sub

    Private Sub btnEditPrice_Click(sender As Object, e As EventArgs) Handles btnEditPrice.Click
        UnitPriceToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub btnEditQuantity_Click(sender As Object, e As EventArgs) Handles btnEditQuantity.Click
        QuantityToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        RemoveItemToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub btnEditServiceFee_Click(sender As Object, e As EventArgs) Handles btnEditServiceFee.Click
        ToolStripMenuItem1_Click(sender, e)
    End Sub

    Private Sub btnRemoveServices_Click(sender As Object, e As EventArgs) Handles btnRemoveServices.Click
        ToolStripMenuItem4_Click(sender, e)
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            Dim query, fState, lState As String
            Dim parameters As New Dictionary(Of String, Object)()
            Dim encryptPass = Encrypt(txtPassword.Text, "Keys")
            parameters.Add("user_name", txtUsername.Text)
            parameters.Add("user_password", encryptPass)
            If boolVoid = True Then
                Select Case MsgBox("Are you sure you want to void this order? :" & vbCrLf & _
                               "- Job id: " & lvJobOrderList.FocusedItem.Text & vbCrLf & _
                               "- Car owner " & lvJobOrderList.FocusedItem.SubItems(1).Text & vbCrLf & _
                               "- Car model/year and plate_no." & lvJobOrderList.FocusedItem.SubItems(2).Text & "/" & lvJobOrderList.FocusedItem.SubItems(3).Text _
                               , vbQuestion + vbYesNo, "Void?")
                    Case vbYes
                        dr = db.ExecuteReader("SELECT * FROM tbl_users WHERE user_name=@user_name AND user_password=@user_password AND user_type <> 2", parameters)
                        If dr.HasRows Then
                            dr.Read()
                            fState = "BEGIN TRANSACTION"
                            lState = "COMMIT"
                            query = "SELECT * FROM tbl_ordered_items WHERE job_id= " & lvJobOrderList.FocusedItem.Text & vbCrLf
                            da = New SqlDataAdapter(query, My.Settings.DBconn)
                            da.Fill(ds, "tbl_ordered_items")
                            For x = 1 To ds.Tables("tbl_ordered_items").Rows.Count Step 1
                                query += "UPDATE tbl_items set quantity +=" & ds.Tables("tbl_ordered_items").Rows(x - 1).Item("quantity").ToString & vbCrLf
                            Next
                            query += "UPDATE tbl_job_orders SET status = 3 WHERE job_id = " & lvJobOrderList.FocusedItem.Text & vbCrLf
                            log("User_id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "; voided job order. Granted by admin/superadmin:" & _
                                "User_id:" & dr.Item("user_id") & "; User_name:" & txtUsername.Text & " ; Job_id:" & lvJobOrderList.FocusedItem.Text)
                            rec = db.ExecuteNonQuery(fState & vbCrLf & query & vbCrLf & lState)
                            MsgBox("Record updated!", vbInformation + vbOKOnly, "Updated")
                        Else
                            MsgBox("Invalid Super admin/Admin Username/Password", MsgBoxStyle.Exclamation, "Invalid Username/Password")
                            txtUsername.Clear()
                            txtPassword.Clear()
                            showVerifyAcc(False)
                        End If

                End Select
                boolVoid = False
                Exit Sub

            End If
            
            

            dr = db.ExecuteReader("SELECT * FROM tbl_users WHERE user_name=@user_name AND user_password=@user_password AND user_type <> 2", parameters)
            If dr.HasRows Then
                'tuloy
                dr.Read()
                Select Case MsgBox("Update the record?", vbQuestion + vbYesNo, "Update?")

                    Case vbYes
                        fState = "BEGIN TRANSACTION"
                        lState = "COMMIT"
                        data.Add("date_received", DateToStr(dtReceived.Value))
                        data.Add("mechanic", Trim(txtMechanic.Text))
                        data.Add("electrician", Trim(txtElectrician.Text))
                        data.Add("detailing", Trim(txtDetailing.Text))
                        data.Add("trans_type", cbxOrdertype.SelectedIndex)
                        data.Add("car_id", lblCarId.Text)
                        data.Add("findings", Trim(txtFindings.Text))
                        data.Add("remarks", Trim(txtRemarks.Text))
                        data.Add("mark_up_val", txtMarkup.Text)
                        If txtStatus.Text = "Paid" Then
                            data.Add("status", 0)
                        ElseIf txtStatus.Text = "Unpaid" Then
                            data.Add("status", 1)
                        ElseIf txtStatus.Text = "For quotation" Then
                            data.Add("status", 2)
                        Else
                            data.Add("status", 3)
                        End If
                        If chkTax.Checked = False Then
                            data.Add("w_tax", 0)
                        Else
                            data.Add("w_tax", 1)
                        End If

                        If txtImage.Text <> "To preview, click the view icon." Then
                            Dim myimage As Image = Image.FromFile(uscJobOrder.txtImage.Text)
                            Dim imagestream As System.IO.MemoryStream = New System.IO.MemoryStream
                            myimage.Save(imagestream, System.Drawing.Imaging.ImageFormat.Jpeg)
                            imgbyte = imagestream.GetBuffer()
                            imagestream = New System.IO.MemoryStream(imgbyte)
                            data.Add("inspection_img", imgbyte)
                            query = "UPDATE tbl_job_orders set date_received = @date_received, mechanic=@mechanic, electrician=@electrician, " & _
                            "detailing = @detailing, trans_type=@trans_type, car_id=@car_id, findings=@findings, remarks=@remarks, " & _
                            "mark_up_val= @mark_up_val ,inspection_img= @inspection_img, status= @status, w_tax = @w_tax WHERE job_id = " & txtJobID.Text & vbCrLf
                        Else
                            query = "UPDATE tbl_job_orders set date_received = @date_received, mechanic=@mechanic, electrician=@electrician, " & _
                            "detailing = @detailing, trans_type=@trans_type, car_id=@car_id, findings=@findings, remarks=@remarks, " & _
                            "mark_up_val= @mark_up_val, status= @status, w_tax += @w_tax WHERE job_id = " & txtJobID.Text & vbCrLf
                        End If
                        'dagdag items
                        'For x = 1 To ds.Tables("lvItems").Rows.Count Step 1
                        '    query += "UPDATE tbl_items SET quantity += " & ds.Tables("lvItems").Rows(x - 1).Item("quantity").ToString & _
                        '        ", time_stamp= '" & Date.Now & "' WHERE item_id= " & ds.Tables("lvItems").Rows(x - 1).Item("item_id").ToString & vbCrLf  'time stamp
                        'Next
                        'bawas items
                        'For x = 1 To lvParts.Items.Count Step 1
                        '    query += "INSERT INTO tbl_ordered_items(jo_item_id,job_id,name,price,quantity) " & _
                        '        "values (" & lvParts.Items(x - 1).Text & "," & txtJobID.Text & ", '" & lvParts.Items(x - 1).SubItems(2).Text & "', '" & _
                        '        NumToStr(lvParts.Items(x - 1).SubItems(3).Text) & "', " & lvParts.Items(x - 1).SubItems(1).Text & ") " & vbCrLf & _
                        '    " UPDATE tbl_items set quantity -= " & Val(lvParts.Items(x - 1).SubItems(1).Text) & vbCrLf & _
                        '    ", time_stamp= '" & Date.Now & "' WHERE item_id= " & lvParts.Items(x - 1).Text & vbCrLf
                        'Next

                        query += "DELETE FROM tbl_ordered_items WHERE job_id =" & txtJobID.Text & vbCrLf
                        query += "DELETE FROM tbl_ordered_services WHERE job_id =" & txtJobID.Text & vbCrLf

                        If lvParts.Items.Count <> 0 Then
                            If trans_type = 0 And cbxOrdertype.SelectedIndex = 1 Then
                                For x = 1 To lvParts.Items.Count Step 1
                                    query += "INSERT INTO tbl_ordered_items(jo_item_id,job_id,name,price,quantity) " & _
                                        "values (" & lvParts.Items(x - 1).Text & "," & txtJobID.Text & ", '" & validateQoutes(lvParts.Items(x - 1).SubItems(2).Text) & "', '" & _
                                        NumToStr(lvParts.Items(x - 1).SubItems(3).Text) & "', " & lvParts.Items(x - 1).SubItems(1).Text & ") " & vbCrLf & _
                                    " UPDATE tbl_items set quantity -= " & Val(lvParts.Items(x - 1).SubItems(1).Text) & vbCrLf & _
                                    ", time_stamp= '" & Date.Now & "' WHERE item_id= " & lvParts.Items(x - 1).Text & vbCrLf
                                Next
                            ElseIf trans_type = 1 And cbxOrdertype.SelectedIndex = 0 Then
                                For x = 1 To tempDs.Tables("lvItems").Rows.Count Step 1
                                    query += "UPDATE tbl_items SET quantity += " & tempDs.Tables("lvItems").Rows(x - 1).Item("quantity").ToString & _
                                        ", time_stamp= '" & Date.Now & "' WHERE item_id= " & tempDs.Tables("lvItems").Rows(x - 1).Item("item_id").ToString & vbCrLf  'time stamp
                                Next

                                For x = 1 To lvParts.Items.Count Step 1
                                    query += "INSERT INTO tbl_ordered_items(jo_item_id,job_id,name,price,quantity) " & _
                                        "values (" & lvParts.Items(x - 1).Text & "," & txtJobID.Text & ", '" & validateQoutes(lvParts.Items(x - 1).SubItems(2).Text) & "', '" & _
                                        NumToStr(lvParts.Items(x - 1).SubItems(3).Text) & "', " & lvParts.Items(x - 1).SubItems(1).Text & ") " & vbCrLf
                                Next

                            ElseIf trans_type = 0 And cbxOrdertype.SelectedIndex = 0 Then
                                For x = 1 To lvParts.Items.Count Step 1
                                    query += "INSERT INTO tbl_ordered_items(jo_item_id,job_id,name,price,quantity) " & _
                                        "values (" & lvParts.Items(x - 1).Text & "," & txtJobID.Text & ", '" & validateQoutes(lvParts.Items(x - 1).SubItems(2).Text) & "', '" & _
                                        NumToStr(lvParts.Items(x - 1).SubItems(3).Text) & "', " & lvParts.Items(x - 1).SubItems(1).Text & ") " & vbCrLf
                                Next
                            ElseIf trans_type = 1 And cbxOrdertype.SelectedIndex = 1 Then
                                For x = 1 To tempDs.Tables("lvItems").Rows.Count Step 1
                                    query += "UPDATE tbl_items SET quantity += " & tempDs.Tables("lvItems").Rows(x - 1).Item("quantity").ToString & _
                                        ", time_stamp= '" & Date.Now & "' WHERE item_id= " & tempDs.Tables("lvItems").Rows(x - 1).Item("item_id").ToString & vbCrLf  'time stamp
                                Next

                                For x = 1 To lvParts.Items.Count Step 1
                                    query += "INSERT INTO tbl_ordered_items(jo_item_id,job_id,name,price,quantity) " & _
                                        "values (" & lvParts.Items(x - 1).Text & "," & txtJobID.Text & ", '" & validateQoutes(lvParts.Items(x - 1).SubItems(2).Text) & "', '" & _
                                        NumToStr(lvParts.Items(x - 1).SubItems(3).Text) & "', " & lvParts.Items(x - 1).SubItems(1).Text & ") " & vbCrLf & _
                                    " UPDATE tbl_items set quantity -= " & Val(lvParts.Items(x - 1).SubItems(1).Text) & vbCrLf & _
                                    ", time_stamp= '" & Date.Now & "' WHERE item_id= " & lvParts.Items(x - 1).Text & vbCrLf
                                Next
                            End If

                        End If

                        If lvServices.Items.Count <> 0 Then
                            For x = 1 To lvServices.Items.Count Step 1
                                query += "INSERT INTO tbl_ordered_services(jo_service_id,job_id,service_name,service_fee) " & _
                                    "values (" & lvServices.Items(x - 1).Text & "," & txtJobID.Text & ", '" & validateQoutes(lvServices.Items(x - 1).SubItems(1).Text) & "', '" & _
                                     NumToStr(lvServices.Items(x - 1).SubItems(2).Text) & "' ) " & vbCrLf
                            Next
                        End If
                        rec = db.ExecuteNonQuery(fState & vbCrLf & query & vbCrLf & lState, data)
                        log("User_id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "; voided job order. Granted by admin/superadmin:" & _
                                "User_id:" & dr.Item("user_id") & "; User_name:" & txtUsername.Text & " ; Job_id:" & lvJobOrderList.FocusedItem.Text)
                        MsgBox("Record updated!", vbInformation + vbOKOnly, "Updated")

                End Select
                showVerifyAcc(False)
                data.Clear()
                ClearTextBoxes()
                lblCarId.Text = ""
                lvParts.Items.Clear()
                lvServices.Items.Clear()
                showAddEdit(False)
                uscMainmenu.get_notifications()

            Else
                MsgBox("Invalid Super admin/Admin Username/Password", MsgBoxStyle.Exclamation, "Invalid Username/Password")
                txtUsername.Clear()
                txtPassword.Clear()
                showVerifyAcc(False)

            End If

        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
            tempDs.Tables.Clear()
            ds.Clear()
        End Try


        'Do While dr.Read
        '    MsgBox(dr.Item(1).ToString)
        'Loop  

    End Sub
   
    Private Sub btnCancelVeri_Click(sender As Object, e As EventArgs) Handles btnCancelVeri.Click
        showVerifyAcc(False)
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If user_type <> 1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ContextMenuStrip2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
        If user_type <> 1 Then
            e.Cancel = True
        End If
    End Sub


    Private Sub lvJobOrderList_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lvJobOrderList.ColumnWidthChanging
        e.Cancel = True
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim rptItems As New Orders
        showPrintOrders(True)
        pnlPrintOrders.BringToFront()
        Try
            ds.Tables.Clear()

            Dim row As DataRow = Nothing
            ds.Tables.Add("Orders")
            With ds.Tables(0).Columns
                .Add("job_id")
                .Add("name")
                .Add("yr/model")
                .Add("plate_no")
                .Add("status")

            End With

            For x = 1 To lvJobOrderList.Items.Count Step 1
                row = ds.Tables(0).NewRow
                row(0) = lvJobOrderList.Items(x - 1).Text
                row(1) = lvJobOrderList.Items(x - 1).SubItems(1).Text
                row(2) = lvJobOrderList.Items(x - 1).SubItems(2).Text
                row(3) = lvJobOrderList.Items(x - 1).SubItems(3).Text
                row(4) = lvJobOrderList.Items(x - 1).SubItems(4).Text

                ds.Tables(0).Rows.Add(row)
            Next

            ds.WriteXml("XML\Orders.xml")
            Dim dsItem As New DataSet
            dsItem = New dsReportJobsOrder
            Dim dsItemTemp As New DataSet
            dsItemTemp = New DataSet()
            dsItemTemp.ReadXml("XML\Orders.xml")
            dsItem.Merge(dsItemTemp.Tables(0))
            rptItems = New Orders
            rptItems.SetDataSource(dsItem)
            crvOrders.ReportSource = rptItems
            Exit Sub
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        End Try

    End Sub
    Private Sub showPrintOrders(mode As Boolean)
        pnlPrintOrders.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub
    Private Sub showPrintMe(mode As Boolean)
        pnlPrint.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click

        Try
            If lvJobOrderList.SelectedItems.Count = 0 Then
                MsgBox("Please select an order.", vbExclamation + vbOKOnly, "Select")
                Exit Sub
            End If
            If lvJobOrderList.FocusedItem.SubItems(4).Text = "For quotation" Then
                MsgBox("The order status is for quotation only it cannot be void.", vbExclamation + vbOKOnly, "Can't void")
                Exit Sub
            ElseIf lvJobOrderList.FocusedItem.SubItems(4).Text = "Voided" Then
                MsgBox("Order was voided already.", vbExclamation + vbOKOnly, "Can't void")
                Exit Sub
            End If
            If user_type = 3 Then
                showVerifyAcc(True)
                boolVoid = True
                Exit Sub
            End If
            Select Case MsgBox("Are you sure you want to void this order? :" & vbCrLf & _
                               "- Job id: " & lvJobOrderList.FocusedItem.Text & vbCrLf & _
                               "- Car owner " & lvJobOrderList.FocusedItem.SubItems(1).Text & vbCrLf & _
                               "- Car model/year and plate_no." & lvJobOrderList.FocusedItem.SubItems(2).Text & "/" & lvJobOrderList.FocusedItem.SubItems(3).Text _
                               , vbQuestion + vbYesNo, "Void?")
                Case vbYes
                    Dim query, fState, lState As String
                    fState = "BEGIN TRANSACTION"
                    lState = "COMMIT"
                    query = "SELECT * FROM tbl_ordered_items WHERE job_id= " & lvJobOrderList.FocusedItem.Text & vbCrLf
                    da = New SqlDataAdapter(query, My.Settings.DBconn)
                    da.Fill(ds, "tbl_ordered_items")
                    For x = 1 To ds.Tables("tbl_ordered_items").Rows.Count Step 1
                        query += "UPDATE tbl_items set quantity +=" & ds.Tables("tbl_ordered_items").Rows(x - 1).Item("quantity").ToString & vbCrLf
                    Next
                    query += "UPDATE tbl_job_orders SET status = 3 WHERE job_id = " & lvJobOrderList.FocusedItem.Text & vbCrLf
                    log("User_id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "; Job_id:" & lvJobOrderList.FocusedItem.Text)
                    rec = db.ExecuteNonQuery(fState & vbCrLf & query & vbCrLf & lState)
                    MsgBox("Record updated!", vbInformation + vbOKOnly, "Updated")
            End Select

        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical)
        Finally
            db.Dispose()
            ds.Clear()
        End Try
    End Sub

    Private Sub btnCancelPrintattack_Click(sender As Object, e As EventArgs)
        showPrintMe(False)
    End Sub

    Private Sub btnPrintJO_Click(sender As Object, e As EventArgs) Handles btnPrintJO.Click
        showPrintMe(True)
        Dim total_price_item, total_price_service As Double
        pnlPrint.BringToFront()
        If validationTechnique() = False Then
            Exit Sub
        End If
        Try
            showPrintMe(True)
            Dim row1 As DataRow = Nothing

            Dim DS As New DataSet
            Dim rptOrder As New OrderReport
            DS.Tables.Add("OrderDetails")
            With DS.Tables(0).Columns
                .Add("job_id")
                .Add("jo_date")
                .Add("name")
                .Add("car_model_year")
                .Add("plate_no")
                .Add("color")
                .Add("mechanic")
                .Add("electrician")
                .Add("detailing")
                .Add("group_type")
                .Add("items")
                .Add("price")
                .Add("quantity")
                .Add("total_items")
                .Add("total_price")
                .Add("chassis_no")
                .Add("disp_tax")
                .Add("tax_val")
                .Add("contact_no")
            End With

            For x = 1 To lvParts.Items.Count Step 1
                row1 = DS.Tables(0).NewRow
                row1(0) = txtJobID.Text
                row1(1) = dtReceived.Value
                row1(2) = txtName.Text
                row1(3) = txtCarMod.Text
                row1(4) = txtPlateno.Text
                row1(5) = txtColor.Text
                row1(6) = txtMechanic.Text
                row1(7) = txtElectrician.Text
                row1(8) = txtDetailing.Text
                Dim amt, qty, total As Double
                amt = lvParts.Items(x - 1).SubItems(3).Text
                qty = lvParts.Items(x - 1).SubItems(1).Text
                total = amt * qty
                total_price_item += total
                row1(9) = "Parts"
                row1(10) = lvParts.Items(x - 1).SubItems(2).Text
                row1(11) = FormatNumber(amt, 2)
                row1(12) = qty
                row1(13) = FormatNumber(total, 2)
                row1(14) = FormatNumber(total_price_item, 2)
                row1(15) = txtVin.Text
                row1(16) = chkTax.Text
                row1(18) = txtContact.Text
                DS.Tables(0).Rows.Add(row1)
            Next
            
            For x = 1 To lvServices.Items.Count Step 1
                row1 = DS.Tables(0).NewRow
                row1(0) = txtJobID.Text
                row1(1) = dtReceived.Value
                row1(2) = txtName.Text
                row1(3) = txtCarMod.Text
                row1(4) = txtPlateno.Text
                row1(5) = txtColor.Text
                row1(6) = txtMechanic.Text
                row1(7) = txtElectrician.Text
                row1(8) = txtDetailing.Text
                Dim amt, qty, total As Double
                amt = lvServices.Items(x - 1).SubItems(2).Text
                qty = 1
                total = amt * qty
                total_price_service += total
                row1(9) = "Services"
                row1(10) = lvServices.Items(x - 1).SubItems(1).Text
                row1(11) = FormatNumber(amt, 2)
                row1(12) = qty
                row1(13) = FormatNumber(total, 2)
                If chkTax.Checked = True Then
                    row1(14) = FormatNumber(total_price_service + total_price_item + txtTaxValue.Text, 2)
                    row1(15) = txtVin.Text
                    row1(16) = chkTax.Text
                    row1(17) = txtTaxValue.Text

                Else
                    row1(14) = FormatNumber(total_price_service + total_price_item, 2)
                    row1(16) = ""
                    row1(17) = ""
                End If
               
               
                DS.Tables(0).Rows.Add(row1)
            Next
            
            DS.WriteXml("XML\OrderReport.xml")

            Dim dsSoa As New DataSet
            dsSoa = New dsReportJobsOrder
            Dim dsSoaTemp As New DataSet
            dsSoaTemp = New DataSet()
            dsSoaTemp.ReadXml("XML\OrderReport.xml")
            dsSoa.Merge(dsSoaTemp.Tables(0))
            'dsSoa.Merge(dsSoaTemp.Tables(1))
            rptOrder = New OrderReport
            rptOrder.SetDataSource(dsSoa)
            crvOrderReport.ReportSource = rptOrder
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub btnPrintAttack_Click(sender As Object, e As EventArgs)
        crvOrderReport.PrintReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        showPrintOrders(False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        crvOrders.PrintReport()
    End Sub

    Private Sub btnPrintAttack_Click_1(sender As Object, e As EventArgs) Handles btnPrintAttack.Click
        crvOrderReport.PrintReport()
    End Sub

    Private Sub btnCancelPrintattack_Click_1(sender As Object, e As EventArgs) Handles btnCancelPrintattack.Click
        showPrintMe(False)
    End Sub

    'Private Sub lvParts_Click(sender As Object, e As EventArgs) Handles lvParts.Click
    '    If lvParts.Items.Count <> 0 Then
    '        visiblesParts(True)
    '    Else
    '        visiblesParts(False)
    '    End If
    'End Sub
    'Private Sub lvServices_Click(sender As Object, e As EventArgs) Handles lvServices.Click
    '    If lvServices.Items.Count <> 0 Then
    '        visiblesServices(True)
    '    Else
    '        visiblesServices(False)
    '    End If
    'End Sub
    'Public Sub visiblesParts(mode As Boolean)
    '    Me.btnEditPrice.Top = 156
    '    Me.btnEditPrice.Left = 733
    '    Me.btnEditQuantity.Top = 156
    '    Me.btnEditQuantity.Left = 767
    '    Me.btnRemoveItem.Left = 801
    '    Me.btnRemoveItem.Top = 156


    '    If user_type = 2 Then
    '        With Me '<3
    '            .btnEditQuantity.Visible = mode
    '            .btnRemoveItem.Visible = mode
    '        End With
    '    Else
    '        With Me ' <3
    '            .btnEditQuantity.Visible = mode
    '            .btnEditPrice.Visible = mode
    '            .btnRemoveItem.Visible = mode
    '        End With
    '    End If
    'End Sub
    'Public Sub visiblesServices(mode As Boolean)
    '    Me.btnEditServiceFee.Top = 419
    '    Me.btnEditServiceFee.Left = 767
    '    Me.btnRemoveServices.Top = 419
    '    Me.btnRemoveServices.Left = 801
    '    If user_type = 2 Then
    '        With Me '<3
    '            .btnRemoveServices.Visible = mode
    '        End With
    '    Else
    '        With Me ' <3
    '            .btnRemoveServices.Visible = mode
    '            .btnEditServiceFee.Visible = mode
    '        End With
    '    End If
    'End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        showPrintOrders(False)
    End Sub
End Class
