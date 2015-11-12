Module MainPanelController

    Public uscMainmenu As New MainMenu
    Public uscJobOrder As New JobOrder
    Public uscItem As New Items
    Public uscServices As New Services
    Public uscClients As New Clients
    Public uscSupplierInvoice As New SupplierInvoice
    Public uscSystemUsers As New SystemUsers
    Public uscReports As New Reports
    Public uscCarBrands As New CarBrands

    Public currentUSC As Control

    Sub clearMainPanel()
        frmMain.pnlMain.Controls.Clear()
    End Sub
    Sub showUSC(usc As Control)
        currentUSC = usc
        clearMainPanel()
        currentUSC.Parent = frmMain.pnlMain
        currentUSC.Width = frmMain.pnlMain.Width
        currentUSC.Height = frmMain.pnlMain.Height
    End Sub
End Module
