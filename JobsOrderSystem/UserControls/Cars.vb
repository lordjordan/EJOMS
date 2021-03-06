﻿Imports System.Data.SqlClient

Public Class Cars
    Dim timerStopper As String
    Dim btnAddNewClick, btnEditClick, btnPrintClick, btnAddEditClosed As Boolean



    Private Sub showAddEdit(mode As Boolean)
        pnlAddEdit.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub
    Private Sub showBrands(mode As Boolean)
        pnlBrand.BringToFront()
        pnlBrand.Visible = mode
        pnlAddEdit.Enabled = Not mode
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        showUSC(uscMainmenu)
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        btnAddNewClick = True
        Label4.Visible = False
        txtCarID.Visible = False
        lblAddedit.Text = "   Add new car"

        showAddEdit(True)
        If pnlAddEdit.Height <> 450 Then

            timerAnimate.Start()
        End If

    End Sub
    Private Sub btnAddEditClose_Click(sender As Object, e As EventArgs) Handles btnAddEditClose.Click

        btnAddEditClosed = True
        If pnlAddEdit.Height <> 0 Then

            timerAnimate.Start()

        End If
        ClearTextBoxes()
        pnlMain.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lvCars.SelectedItems.Count = 0 Then
            MsgBox("Please select a car to update", vbExclamation + vbOKOnly, "Select please")
            Exit Sub
        End If
        btnAddNewClick = True
        Label4.Visible = True
        txtCarID.Visible = True
        txtCarID.Text = lvCars.FocusedItem.Text
        lblAddedit.Text = "   Update car"
        'query update
        Try
            dr = db.ExecuteReader("SELECT tbl_cars.car_brand_id as brand_id ,car_model_year ,plate_no,vin_chassis_no, " & _
            "color, mileage, engine_no, fuel_type, transmission, first_name, middle_name, " & _
            "last_name, contact_no, email, address, name " & _
            "FROM [EJOMSdb].[dbo].[tbl_cars] inner join tbl_car_brands " & _
            "ON tbl_cars.car_brand_id = tbl_car_brands.car_brand_id WHERE car_id=" & lvCars.FocusedItem.Text)

            dr.Read()
            lblbrand_id.Text = dr.Item("brand_id")
            txtBrand.Text = dr.Item("name")
            txtCarmodel.Text = dr.Item("car_model_year")
            txtPlate.Text = dr.Item("plate_no")
            txtVin.Text = dr.Item("vin_chassis_no")
            txtColor.Text = dr.Item("color")
            txtMileage.Text = dr.Item("mileage")
            txtEngine.Text = dr.Item("engine_no")
            If dr.Item("fuel_type") = 0 Then
                cbxFuel.Text = cbxFuel.Items(0).ToString
            ElseIf dr.Item("fuel_type") = 1 Then
                cbxFuel.Text = cbxFuel.Items(1).ToString
            ElseIf dr.Item("fuel_type") = 2 Then
                cbxFuel.Text = cbxFuel.Items(1).ToString
            End If
            If dr.Item("transmission") = 0 Then
                cbxTrans.Text = cbxTrans.Items(0).ToString
            Else
                cbxTrans.Text = cbxTrans.Items(1).ToString
            End If
            txtFirstname.Text = dr.Item("first_name")
            txtMiddlename.Text = dr.Item("middle_name")
            txtLastname.Text = dr.Item("last_name")
            txtContact.Text = dr.Item("contact_no")
            txtEmail.Text = dr.Item("email")
            txtAddress.Text = dr.Item("address")

        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error!")
        Finally
            db.Dispose()
        End Try
        showAddEdit(True)
        If pnlAddEdit.Height <> 450 Then
            timerAnimate.Start()
        End If
    End Sub
    Private Sub timerAnimate_Tick(sender As Object, e As EventArgs) Handles timerAnimate.Tick
        'opening
        If btnAddNewClick = True Then
            timerStopper = pnlAddEdit.Height
            If timerStopper = 450 Then
                timerAnimate.Stop()
                btnAddNewClick = False
                Exit Sub
            End If
            pnlAddEdit.Height += 50

        ElseIf btnEditClick = True Then
            timerStopper = pnlAddEdit.Height
            If timerStopper = 450 Then

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
        saveCars()

    End Sub


    'methods
    Public Sub loadCars()
        Try
            lvCars.Items.Clear()
            dr = db.ExecuteReader("SELECT car_id, last_name + ',' + first_name + ' ' + middle_name as name , car_model_year, plate_no FROM tbl_cars")
            If dr.HasRows Then
                Do While dr.Read

                    itm = lvCars.Items.Add(dr.Item("car_id"))
                    itm.SubItems.Add(dr.Item("name"))
                    itm.SubItems.Add(dr.Item("car_model_year"))
                    itm.SubItems.Add(dr.Item("plate_no"))

                Loop
            Else
                MsgBox("No car found!", vbInformation + vbOKOnly, "No record(s)")
            End If
            ToolStripStatusLabel1.Text = "Count: " & lvCars.Items.Count
        Catch ex As Exception
            MsgBox("Error occured!" & ex.ToString, vbCritical + vbOKOnly, "Error!")
        Finally
            db.Dispose()
        End Try
    End Sub
    Private Sub saveCars()
        If correctinputs() = False Then Exit Sub
        Try

            data.Add("car_brand_id", lblbrand_id.Text)
            data.Add("car_model_year", Trim(txtCarmodel.Text))
            data.Add("plate_no", Trim(txtPlate.Text))
            data.Add("vin_chassis_no", Trim(txtVin.Text))
            data.Add("color", Trim(txtColor.Text))
            data.Add("mileage", Trim(txtMileage.Text))
            data.Add("engine_no", Trim(txtEngine.Text))
            data.Add("fuel_type", cbxFuel.SelectedIndex)
            data.Add("transmission", cbxTrans.SelectedIndex)
            data.Add("first_name", Trim(txtFirstname.Text))
            data.Add("middle_name", Trim(txtMiddlename.Text))
            data.Add("last_name", Trim(txtLastname.Text))
            data.Add("contact_no", Trim(txtContact.Text))
            data.Add("email", Trim(txtEmail.Text)) '' VALIDATION
            data.Add("address", Trim(txtAddress.Text))
            If lblAddedit.Text = "   Add new car" Then
                dr = db.ExecuteReader("SELECT plate_no from tbl_cars WHERE plate_no = '" & validateQoutes(txtPlate.text) & "'")
                If dr.HasRows Then
                    MsgBox("Plate no. is already existed!", vbExclamation + vbOKOnly, "Unable to register")
                    Exit Sub
                End If
                rec = db.ExecuteNonQuery("INSERT INTO tbl_cars(car_brand_id, car_model_year, plate_no, vin_chassis_no, color, mileage, engine_no, fuel_type, " & _
                                         "transmission , first_name, middle_name , last_name, contact_no, email , address) VALUES(@car_brand_id,  " & _
                                         "@car_model_year, @plate_no, @vin_chassis_no, @color, @mileage, @engine_no, " & _
                                         "@fuel_type, @transmission, @first_name, @middle_name, @last_name, @contact_no, @email, @address)", data)
                log("User id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "; add new car; Car_name:" & txtCarmodel.Text & _
                    "; Plate_no:" & txtPlate.Text)
                MsgBox("Record saved!", vbInformation + vbOKOnly, "Saved!")
            ElseIf lblAddedit.Text = "   Update car" Then

                rec = db.ExecuteNonQuery("UPDATE tbl_cars set car_brand_id= @car_brand_id , car_model_year= @car_model_year, plate_no= @plate_no, " & _
                                         "vin_chassis_no= @vin_chassis_no, color= @color, mileage= @mileage, engine_no=@engine_no, fuel_type= @fuel_type, " & _
                                         "transmission = @transmission, first_name= @first_name, middle_name= @middle_name, last_name = @last_name, " & _
                                         "contact_no =@contact_no, email= @email, address= @address  WHERE car_id = " & txtCarID.Text, data)
                log("User id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "; update car; car_id:" & txtCarID.Text)
                MsgBox("Record updated!", vbInformation + vbOKOnly, "Updated!")
            End If

            showAddEdit(False)
            loadCars()
            data.Clear()
            ClearTextBoxes()

        Catch ex As Exception
            data.Clear()
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
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
        lblbrand_id.Text = "???"
        cbxFuel.Text = Nothing
        cbxTrans.Text = Nothing
    End Sub
    Private Function correctinputs()
        If txtBrand.Text = "" Then
            MsgBox("Please select brand", vbExclamation + vbOKOnly, "Blank")
            txtBrand.Focus()
            Return False
        End If

        If txtCarmodel.Text = "" Then
            MsgBox("Car model didn't specified", vbExclamation + vbOKOnly, "Blank")
            txtCarmodel.Focus()
            Return False
        End If

        If txtPlate.Text = "" Then
            MsgBox("Please input the plate number!", vbExclamation + vbOKOnly, "Blank")
            txtPlate.Focus()
            Return False
        End If

        If txtColor.Text = "" Then
            MsgBox("Please type the color.", vbExclamation + vbOKOnly, "Blank")
            txtColor.Focus()
            Return False
        End If

        If txtFirstname.Text = "" Then
            MsgBox("Please type the first name", vbExclamation + vbOKOnly, "Blank")
            txtFirstname.Focus()
            Return False
        End If
        If txtLastname.Text = "" Then
            MsgBox("Please type the last name", vbExclamation + vbOKOnly, "Blank")
            txtLastname.Focus()
            Return False
        End If

        If txtContact.Text = "" And txtEmail.Text = "" And txtAddress.Text = "" Then
            MsgBox("Please input at least one of the following:" & vbCrLf & "-Contact" & vbCrLf & "-E-mail" & vbCrLf & "-Address")
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub btnBrowseBrand_Click(sender As Object, e As EventArgs) Handles btnBrowseBrand.Click
        showBrands(True)
    End Sub

    Private Sub btn_SearchBrand_Click(sender As Object, e As EventArgs) Handles btn_SearchBrand.Click
        Try
            lvCarBrands.Items.Clear()
            dr = db.ExecuteReader("SELECT * FROM tbl_car_brands WHERE name LIKE '%" & _
                                 validateQoutes(txtSearchBrand.Text) & "%'")
            If dr.HasRows Then
                Do While dr.Read
                    itm = lvCarBrands.Items.Add(dr.Item("car_brand_id"))
                    itm.SubItems.Add(dr.Item("name"))
                    itm.SubItems.Add(dr.Item("percentage"))
                Loop
            Else
                MsgBox("No result(s) found!", vbExclamation + vbOKOnly, "No record(s)")
            End If
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub txtSearchBrand_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchBrand.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_SearchBrand_Click(sender, e)
        End If
    End Sub


    Private Sub btnCloseBrand_Click(sender As Object, e As EventArgs) Handles btnCloseCar.Click
        showBrands(False)
    End Sub


    Private Sub btnSelectCarBrand_Click(sender As Object, e As EventArgs) Handles btnSelectCarBrand.Click

        lblbrand_id.Text = lvCarBrands.FocusedItem.Text
        txtBrand.Text = lvCarBrands.FocusedItem.SubItems(1).Text
        showBrands(False)
    End Sub

    Private Sub lvCarBrands_DoubleClick(sender As Object, e As EventArgs) Handles lvCarBrands.DoubleClick
        btnSelectCarBrand_Click(sender, e)
    End Sub

    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If e.Handled = (Char.IsDigit(e.KeyChar) Or e.KeyChar = "-") Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            showPrintMe(True)
            Dim row1 As DataRow = Nothing
            Dim DS As New DataSet
            Dim rptINC As New CarsReport
            'mag a-add na sa dataset (DS)
            DS.Tables.Add("CarsReport")
            'lagay tayo ng columns
            With DS.Tables(0).Columns
                .Add("car_id")
                .Add("name")
                .Add("car_model")
                .Add("plate_no")
            End With
            For x = 1 To lvCars.Items.Count Step 1
                row1 = DS.Tables(0).NewRow
                row1(0) = lvCars.Items(x - 1).Text
                row1(1) = lvCars.Items(x - 1).SubItems(1).Text
                row1(2) = lvCars.Items(x - 1).SubItems(2).Text
                row1(3) = lvCars.Items(x - 1).SubItems(3).Text
                DS.Tables(0).Rows.Add(row1)
            Next

            DS.WriteXml("XML\CarsReport.xml")

            Dim dsINC As New DataSet
            dsINC = New dsReportJobsOrder
            Dim dsINCTemp As New DataSet
            dsINCTemp = New DataSet()
            'dsINCTemp = New DSreports
            dsINCTemp.ReadXml("XML\CarsReport.xml")
            dsINC.Merge(dsINCTemp.Tables(0))

            'MsgBox(dsINCTemp.Tables(0).Rows(0).Item(0).ToString)
            rptINC = New CarsReport
            rptINC.SetDataSource(dsINCTemp.Tables(0))
            crvCars.ReportSource = rptINC

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub showPrintMe(mode As Boolean)
        pnlPrint.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try

            lvCars.Items.Clear()
            data.Add("keyword", "%" & Trim(txtSearch.Text) & "%")
            dr = db.ExecuteReader("SELECT car_id, last_name + ',' + first_name + ' ' + middle_name as name , car_model_year, plate_no FROM tbl_cars " & _
                                  "WHERE car_id LIKE @keyword OR " & _
                                  "last_name LIKE @keyword OR " & _
                                  "middle_name LIKE @keyword OR " & _
                                  "first_name LIKE @keyword OR " & _
                                  "car_model_year LIKE @keyword OR " & _
                                  "plate_no LIKE @keyword", data)
            If dr.HasRows Then
                Do While dr.Read

                    itm = lvCars.Items.Add(dr.Item("car_id"))
                    itm.SubItems.Add(dr.Item("name"))
                    itm.SubItems.Add(dr.Item("car_model_year"))
                    itm.SubItems.Add(dr.Item("plate_no"))

                Loop
            Else
                MsgBox("No car found!", vbInformation + vbOKOnly, "No record(s)")
            End If
            data.Clear()
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub btnCancelPrintattack_Click(sender As Object, e As EventArgs) Handles btnCancelPrintattack.Click
        showPrintMe(False)
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnSearch_Click(sender, e)
        End If
    End Sub



End Class
