Public Class CarBrands
    Dim timerStopper As String
    Dim btnAddNewClick, btnEditClick, btnPrintClick, btnAddEditClosed As Boolean

    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader

    Dim cmd As SqlClient.SqlCommand
    Dim itm As ListViewItem

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
        parameters.Add("name", txtCarName.Text.ToString)
        parameters.Add("percentage", txtPercent.Text)
        If txtCBID.Text <> "" Then
            parameters.Add("car_brand_id", txtCBID.Text)

            affected_row = db.ExecuteNonQuery("UPDATE tbl_car_brands SET name=@name, percentage=@percentage WHERE car_brand_id=@car_brand_id", parameters)
            If affected_row > 0 Then
                MsgBox("Record Update!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Save Succesful")

                loadCarBrands()

            End If
        Else
            If db.ExecuteNonQuery("INSERT INTO tbl_car_brands(name,percentage) VALUES(@name, @percentage)", parameters) > 0 Then
                MsgBox("New Record Added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Succesful")

                loadCarBrands()
            End If
        End If
        parameters.Clear()
        btnAddEditClose_Click(sender, e)
    End Sub

    Private Sub CarBrands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' loadCarListview()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'loadCarListview()
        Try
            lvCarBrands.Items.Clear()
            dr = db.ExecuteReader("SELECT * FROM tbl_car_brands WHERE car_brand_id LIKE '%" & txtSearch.Text & "%' OR name LIKE '%" & _
                                 txtSearch.Text & "%'")
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
        If Asc(e.KeyChar) <> 8 Then
            If e.Handled = (Char.IsDigit(e.KeyChar)) Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Function correctInputs()
        If txtCarName.Text = "" Or txtPercent.Text = "" Then
            MsgBox("Some fields are empty.", vbExclamation + vbOKOnly, "Blank fields")
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

  
  
End Class
