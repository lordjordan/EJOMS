Public Class CarBrands
    Dim timerStopper As String
    Dim btnAddNewClick, btnEditClick, btnPrintClick, btnAddEditClosed As Boolean

    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand


    Private Sub loadCarListview()
        Dim parameters As New Dictionary(Of String, Object)()
        Dim itm As ListViewItem

        parameters.Add("keyword", "%" & txtSearch.Text & "%")
        lvCarBrands.Items.Clear()

        Try

            dr = db.ExecuteReader("SELECT car_brand_id,name FROM tbl_car_brands WHERE name LIKE @keyword", parameters)
            If dr.HasRows Then
                Do While dr.Read
                    itm = Me.lvCarBrands.Items.Add(dr.Item("car_brand_id").ToString)
                    With itm
                        .SubItems.Add(dr.Item("name").ToString)
                    End With
                Loop

            Else
                MsgBox("No records of car brands", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Car Brands")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try

    End Sub
    Private Sub reset_frm_carbrand()
        txtCarName.Text = ""
        txtCBID.Text = ""
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
        showAddEdit(True)
        If pnlAddEdit.Height <> 950 Then
            lblAddedit.Text = "   Add new car brand"

            timerAnimate.Start()
        End If

    End Sub
    Private Sub btnAddEditClose_Click(sender As Object, e As EventArgs) Handles btnAddEditClose.Click

        btnAddEditClosed = True
        If pnlAddEdit.Height <> 0 Then

            timerAnimate.Start()

        End If
        lvCarBrands.SelectedItems.Clear()
        reset_frm_carbrand()
            pnlMain.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lvCarBrands.SelectedItems.Count = 1 Then
            With lvCarBrands.SelectedItems.Item(0)
                txtCBID.Text = .SubItems(0).Text.ToString
                txtCarName.Text = .SubItems(1).Text.ToString
                btnAddNewClick = True
                showAddEdit(True)
            End With
            If pnlAddEdit.Height <> 650 Then
                lblAddedit.Text = "   Update car brand"
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
        Dim affected_row As Integer
        Dim parameters As New Dictionary(Of String, Object)
        parameters.Add("name", txtCarName.Text.ToString)
        If txtCBID.Text <> "" Then
            parameters.Add("car_brand_id", txtCBID.Text.ToString)
            affected_row = db.ExecuteNonQuery("UPDATE tbl_car_brands SET name=@name WHERE car_brand_id=@car_brand_id", parameters)
            If affected_row > 0 Then
                MsgBox("Record Update!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Save Succesful")
                loadCarListview()
            End If
        Else
            If db.ExecuteNonQuery("INSERT INTO tbl_car_brands(name) VALUES(@name)", parameters) > 0 Then
                MsgBox("New Record Added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Succesful")
                loadCarListview()
            End If
        End If
        btnAddEditClose_Click(sender, e)
    End Sub

    Private Sub CarBrands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCarListview()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        loadCarListview()
    End Sub

    Private Sub lvCarBrands_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCarBrands.SelectedIndexChanged

    End Sub
End Class
