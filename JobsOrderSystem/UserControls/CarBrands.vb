Imports System.Data.SqlClient
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Xml
Imports System.Data
Public Class CarBrands
    Dim timerStopper As String
    Dim btnAddNewClick, btnEditClick, btnPrintClick, btnAddEditClosed As Boolean


    Dim itm As ListViewItem

    Dim ds As New DataSet
    Dim con As New SqlClient.SqlConnection
    Dim da As SqlClient.SqlDataAdapter
    Dim rptItems As New CarBrandsReport

    Public Sub loadCarBrands()
        'Dim parameters As New Dictionary(Of String, Object)()
        Dim itm As ListViewItem

        ' parameters.Add("keyword", "%" & txtSearch.Text & "%")
        lvCarBrands.Items.Clear()

        Try

            dr = db.ExecuteReader("SELECT * FROM tbl_car_brands")
            If dr.HasRows Then
                Do While dr.Read
                    itm = Me.lvCarBrands.Items.Add(dr.Item("car_brand_id").ToString)
                    With itm
                        .SubItems.Add(dr.Item("name"))
                        .SubItems.Add(dr.Item("percentage"))
                    End With
                Loop
                ToolStripStatusLabel1.Text = "Count: " & lvCarBrands.Items.Count
            Else
                MsgBox("No records of car brands", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Car Brands")
            End If
        Catch ex As Exception
            MsgBox("Error occured" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try

    End Sub
    Private Sub reset_frm_carbrand()
        txtCarName.Text = ""
        txtCBID.Text = ""
        txtPercent.Clear()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        showUSC(uscMainmenu)
    End Sub

    Private Sub showAddEdit(mode As Boolean)
        pnlAddEdit.Visible = mode
        pnlMain.Enabled = Not mode

    End Sub
    Private Sub showPrint(mode As Boolean)
        pnlMain.Enabled = Not mode
        pnl_car_brand_report.Visible = mode
        pnl_car_brand_report.BringToFront()
    End Sub
    Private Sub load_report()
        Try
            ds.Tables.Clear()

            Dim row As DataRow = Nothing
            ds.Tables.Add("CarBrandReport")
            With ds.Tables(0).Columns
                .Add("car_brand_id")
                .Add("name")
                .Add("percentage")

            End With

            For x = 1 To lvCarBrands.Items.Count Step 1
                row = ds.Tables(0).NewRow
                row(0) = lvCarBrands.Items(x - 1).SubItems(0).Text
                row(1) = lvCarBrands.Items(x - 1).SubItems(1).Text
                row(2) = lvCarBrands.Items(x - 1).SubItems(2).Text

                ds.Tables(0).Rows.Add(row)
            Next

            ds.WriteXml("XML\CarBrandsReport.xml")
            Dim dsItem As New DataSet
            dsItem = New dsReportJobsOrder
            Dim dsItemTemp As New DataSet
            dsItemTemp = New DataSet()
            dsItemTemp.ReadXml("XML\CarBrandsReport.xml")
            dsItem.Merge(dsItemTemp.Tables(0))
            rptItems = New CarBrandsReport
            rptItems.SetDataSource(dsItem)
            cr_viewer.ReportSource = rptItems
            Exit Sub
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        lvCarBrands.SelectedItems.Clear()
        btnAddNewClick = True
        lblAddedit.Text = "   Add new car brand"
        Label4.Visible = False
        txtCBID.Visible = False
        showAddEdit(True)
        If pnlAddEdit.Height <> 950 Then
            timerAnimate.Start()
        End If

    End Sub
    Private Sub btnAddEditClose_Click(sender As Object, e As EventArgs) Handles btnAddEditClose.Click

        btnAddEditClosed = True
        If pnlAddEdit.Height <> 0 Then
            timerAnimate.Start()
        End If
        lvCarBrands.SelectedItems.Clear()
        ClearTextBoxes()
        pnlMain.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lvCarBrands.SelectedItems.Count = 1 Then
            Label4.Visible = True
            txtCBID.Text = True
            With lvCarBrands.SelectedItems.Item(0)
                txtCBID.Text = .SubItems(0).Text
                txtCarName.Text = .SubItems(1).Text
                txtPercent.Text = .SubItems(2).Text
                btnAddNewClick = True
                showAddEdit(True)
            End With
            lblAddedit.Text = "   Update car brand"
            If pnlAddEdit.Height <> 650 Then

                timerAnimate.Start()
            End If

        ElseIf lvCarBrands.SelectedItems.Count > 1 Then
            MsgBox("Multiple records selected. Please select one record to update. ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Else
            MsgBox("Select car brand to edit", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Carbrand Selected")
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
        Dim affected_row As Integer
        Dim parameters As New Dictionary(Of String, Object)
        parameters.Add("name", Trim(txtCarName.Text.ToString))
        parameters.Add("percentage", txtPercent.Text)
        If txtCBID.Text <> "" Then
            parameters.Add("car_brand_id", txtCBID.Text)

            affected_row = db.ExecuteNonQuery("UPDATE tbl_car_brands SET name=@name, percentage=@percentage WHERE car_brand_id=@car_brand_id", parameters)
            If affected_row > 0 Then
                MsgBox("Record Update!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Save Successful")
                log("User ID:" & user_id & "; User name:" & frmLogin.txtUsername.Text & "; update carbrand; car_brand_ID:" & txtCBID.Text)
                loadCarBrands()

            End If
        Else
            If db.ExecuteNonQuery("INSERT INTO tbl_car_brands(name,percentage) VALUES(@name, @percentage)", parameters) > 0 Then
                MsgBox("New Record Added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Succesful")
                log("User ID:" & user_id & "; User name:" & frmLogin.txtUsername.Text & "; add carbrand; car_brand_name:" & txtCarName.Text)
                loadCarBrands()
            End If
        End If
        parameters.Clear()
        btnAddEditClose_Click(sender, e)
    End Sub

    Private Sub CarBrands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' loadCarListview()
        ' Me.keyPreview = True
        
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'loadCarListview()
        Try
            Dim txt As String
            If txtSearch.Text.Contains("'") Then
                txt = Replace(Trim(txtSearch.Text), "'", "''")
            Else
                txt = Trim(txtSearch.Text)
            End If
            lvCarBrands.Items.Clear()
            dr = db.ExecuteReader("SELECT * FROM tbl_car_brands WHERE car_brand_id LIKE '%" & txt & "%' OR name LIKE '%" & _
                                 txt & "%'")
            If dr.HasRows Then
                Do While dr.Read
                    itm = lvCarBrands.Items.Add(dr.Item("car_brand_id"))
                    itm.SubItems.Add(dr.Item("name"))
                    itm.SubItems.Add(dr.Item("percentage"))
                Loop

            Else
                MsgBox("No item found!", vbExclamation + vbOKOnly, "No record(s)")
            End If
            ToolStripStatusLabel1.Text = "Count: " & lvCarBrands.Items.Count
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
    Private Sub txtPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPercent.KeyPress
        if e.KeyChar <> ControlChars.Back then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub
    Private Function correctInputs()
        If txtCarName.Text = "" Or txtPercent.Text = "" Then
            MsgBox("Some fields are empty.", vbExclamation + vbOKOnly, "Blank fields")
            Return False
        Else
            If txtPercent.Text > 100 Or txtPercent.Text < 0 Then
                MsgBox("Invalid percentage", vbExclamation + vbOKOnly, "INVALID PERCENTAGE")
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
        End If
    End Sub



    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        showPrint(True)
        load_report()
    End Sub

    Private Sub btn_report_back_Click(sender As Object, e As EventArgs) Handles btn_report_back.Click
        showPrint(False)
    End Sub

    Private Sub btn_print_report_Click(sender As Object, e As EventArgs) Handles btn_print_report.Click
        cr_viewer.PrintReport()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnSearch_Click(sender, e)
        End If
    End Sub

  
End Class
