Public Class MainMenu
    Private Sub btnJobOrderList_Click(sender As Object, e As EventArgs) Handles btnJobOrderList.Click
        showUSC(uscJobOrder)
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        showUSC(uscItem)
    End Sub

    Private Sub btnServices_Click(sender As Object, e As EventArgs) Handles btnServices.Click
        showUSC(uscServices)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Select Case MessageBox.Show("Log out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                frmLogin.Show()
                frmMain.Hide()
        End Select


    End Sub

    Private Sub btnClients_Click(sender As Object, e As EventArgs)
        showUSC(uscClients)
    End Sub

    Private Sub btnSalesInvoice_Click(sender As Object, e As EventArgs) Handles btnSalesInvoice.Click
        showUSC(uscSupplierInvoice)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        showUSC(uscSystemUsers)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        showUSC(uscReports)
    End Sub



    Private Sub tmrTimeDate_Tick(sender As Object, e As EventArgs) Handles tmrTimeDate.Tick
        tmrTimeDate.Enabled = False
        'lblDate.Text = Now.DayOfWeek.ToString & ", " & Now.Day.ToString & " " & Now.mo.ToString
        lblTime.Text = Format(Now, "long time") 'Now.Hour.ToString & ":" & Now.Minute.ToString
        'lblDate.Text = Format(Now, "dddd, d MMMM")
        lblDate.Text = Format(Now, "long date")

        tmrTimeDate.Enabled = True
    End Sub

 
    Private Sub btnClients_Click_1(sender As Object, e As EventArgs) Handles btnClients.Click
        showUSC(uscClients)
    End Sub

    Private Sub btnCarBrands_Click(sender As Object, e As EventArgs) Handles btnCarBrands.Click
        showUSC(uscCarBrands)
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MainMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If lblTime.Location.X < 613 Or lblTime.Location.Y < 572 Then
            lblTime.Visible = False
            lblDate.Visible = False
        Else
            lblTime.Visible = True
            lblDate.Visible = True
        End If

    End Sub

   
    Private Sub MainMenu_Scroll(sender As Object, e As ScrollEventArgs) Handles Me.Scroll

    End Sub
End Class
