Public Class CarBrands
    Dim timerStopper As String
    Dim btnAddNewClick, btnEditClick, btnPrintClick, btnAddEditClosed As Boolean
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        showUSC(uscMainmenu)
    End Sub

    Private Sub showAddEdit(mode As Boolean)
        pnlAddEdit.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
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
        pnlMain.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        btnAddNewClick = True
        showAddEdit(True)
        If pnlAddEdit.Height <> 650 Then
            lblAddedit.Text = "   Update car brand"
            timerAnimate.Start()
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
        MsgBox("Save!")
        btnAddEditClose_Click(sender, e)
    End Sub

    Private Sub CarBrands_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
