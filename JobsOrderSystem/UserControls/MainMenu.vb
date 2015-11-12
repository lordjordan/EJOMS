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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmLogin.Show()
        frmMain.Hide()

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

    Private Sub btnCarBrands_Click(sender As Object, e As EventArgs) Handles btnCarBrands.Click
        showUSC(uscCarBrands)
    End Sub
End Class
