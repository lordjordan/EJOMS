Imports System.IO
Imports System.Data.SqlClient
Module GeneralMethods
    Public user_type As String
    Public user_id As String
    Public db As New DBHelper(My.Settings.DBconn)
    Public dr As SqlDataReader
    Public rec As Integer
    Public itm As New ListViewItem
    Public data As New Dictionary(Of String, Object)
    Public forPaymentPurpose As Boolean
    Public trans_type As Byte
    Public Function NumToStr(number As String, Optional size As Byte = 12) As String
        number = FormatNumber(number, 2)
        number = Replace(number, ".", "")
        number = Replace(number, ",", "")
        number = "000000000000" & number
        Return number.Substring(number.Length - size)
    End Function
    Public Function validateQoutes(txt As String)
        If txt.Contains("'") Then
            txt = Replace(txt, "'", "''")
        End If
        Return Trim(txt)
    End Function
    Public Function StrToNum(str As String, Optional decimalplace As Byte = 2, Optional withComma As Boolean = True) As String
        str = str.Substring(0, str.Length - decimalplace) & "." & str.Substring(str.Length - decimalplace)
        If withComma Then
            Return FormatNumber(Val(str), 2)
        Else
            Return Val(str)
        End If
    End Function

    Public Function StrToDate(str As String) As Date
        str = str.Substring(4, 2) & "/" & str.Substring(6, 2) & "/" & str.Substring(0, 4)
        Return Format(str, "Short date")
    End Function

    Public Function DateToStr(petsa As Date) As String
        Return Format(petsa, "yyyyMMdd")
    End Function
    Public Sub userRightAccess(user_type As String)
        If user_type = 0 Then 'Admin try ko ipakita add lang ng user at settings lang 
            With uscMainmenu
                .btnReports.Visible = False
                .btnItems.Visible = False
                .btnServices.Visible = False
                .btnSalesInvoice.Visible = False
                .btnCarBrands.Visible = False
                .btnClients.Visible = False
                .btnUsers.Top = 109
                .btnUsers.Left = 27
                .btnSettings.Left = 320
                .btnSettings.Top = 109
                .btnUsers.Width = 287
                .btnUsers.Height = 248
                .btnSettings.Width = 287
                .btnSettings.Height = 248
                .btnUsers.Visible = True
                .btnSettings.Visible = True
            End With

            With uscSettings
                .btnAuditTrail.Visible = True
                .btnTax.Visible = False
                .btnDbBackRes.Visible = True
            End With
        ElseIf user_type = 1 Then 'General manager jobs order kagaya ng bills kaso may special sila nakakapag edit sila ng price
            With uscMainmenu
                .btnReports.Visible = True
                .btnItems.Visible = True
                .btnServices.Visible = True
                .btnSalesInvoice.Visible = True
                .btnCarBrands.Visible = True
                .btnClients.Visible = True
                .btnSettings.Left = 467
                .btnSettings.Top = 492
                .btnUsers.Top = 492
                .btnUsers.Left = 467
                .btnSettings.Width = 140
                .btnSettings.Height = 123
                .btnUsers.Width = 140
                .btnUsers.Height = 123
                .btnUsers.Visible = False
                .btnSettings.Visible = True
            End With
            With uscSettings
                .btnAuditTrail.Visible = True
                .btnTax.Visible = True
                .btnDbBackRes.Visible = True
            End With
            With uscJobOrder ' mga ifafalse ang pag edit ng price
                .btnEditPrice.Visible = True
                .btnEditServiceFee.Visible = True
                .btnPayment.Visible = True

                .btnPrintJO.Visible = True
                .chJOUnitPrice.Width = 106
                .chJOTotalPrice.Width = 126
                .chJOSFee.Width = 242
                .lblTotalOrder.Visible = True
                .lbltotalServices.Visible = True
                .lblTotalAmount.Visible = True
                .txtTotalOrder.Visible = True
                .txtTotalServices.Visible = True
                .txtTaxValue.Visible = True
                .txtOverallAmount.Visible = True
                .chkTax.Visible = True
                .TSMUnitPrice.Visible = True
                .TSMServiceFee.Visible = True
            End With

            With frmItems
                .chItemPrice.Width = 147
                .chItemQuantity.Width = 220
            End With
        ElseIf user_type = 2 Then 'Bills and Purchasing
            With uscMainmenu
                .btnReports.Visible = True
                .btnItems.Visible = True
                .btnServices.Visible = True
                .btnSalesInvoice.Visible = True
                .btnCarBrands.Visible = True
                .btnClients.Visible = True
                .btnSettings.Left = 467
                .btnSettings.Top = 492
                .btnUsers.Top = 492
                .btnUsers.Left = 467
                .btnSettings.Width = 140
                .btnSettings.Height = 123
                .btnUsers.Width = 140
                .btnUsers.Height = 123
                .btnUsers.Visible = False
                .btnSettings.Visible = True
            End With
            With uscSettings
                .btnAuditTrail.Visible = True
                .btnTax.Visible = True
                .btnDbBackRes.Visible = True
            End With
            With uscJobOrder ' mga ifafalse ang pag edit ng price
                .btnEditPrice.Visible = False
                .btnEditServiceFee.Visible = False
                .btnPayment.Visible = True
                .btnPrintJO.Visible = True
                .chJOUnitPrice.Width = 106
                .chJOTotalPrice.Width = 126
                .chJOSFee.Width = 242
                .lblTotalOrder.Visible = True
                .lbltotalServices.Visible = True
                .lblTotalAmount.Visible = True
                .txtTotalOrder.Visible = True
                .txtTotalServices.Visible = True
                .txtTaxValue.Visible = True
                .txtOverallAmount.Visible = True
                .chkTax.Visible = True
                .TSMUnitPrice.Visible = True
                .TSMServiceFee.Visible = True
            End With

            With frmItems
                .chItemPrice.Width = 147
                .chItemQuantity.Width = 220
            End With
        ElseIf user_type = 3 Then 'encoder
            With uscMainmenu
                .btnClients.Visible = True
                .btnReports.Visible = False
                .btnItems.Visible = False
                .btnServices.Visible = False
                .btnSalesInvoice.Visible = False
                .btnUsers.Visible = False
                .btnCarBrands.Visible = False
                .btnSettings.Left = 27
                .btnSettings.Top = 363
            End With

            With uscSettings
                .btnAuditTrail.Visible = False
                .btnTax.Visible = False
                .btnDbBackRes.Visible = False
            End With

            With uscJobOrder

                .btnEditPrice.Visible = False
                .btnEditServiceFee.Visible = False
                .btnPayment.Visible = False
                .btnPrintJO.Visible = False
                .chJOUnitPrice.Width = 0
                .chJOTotalPrice.Width = 0
                .chJOSFee.Width = 0
                .lblTotalOrder.Visible = False
                .lbltotalServices.Visible = False
                .lblTotalAmount.Visible = False
                .txtTotalOrder.Visible = False
                .txtOverallAmount.Visible = False
                .txtTotalServices.Visible = False
                .txtTaxValue.Visible = False
                .chkTax.Visible = False
                .TSMUnitPrice.Visible = False
                .TSMServiceFee.Visible = False

            End With

            With frmItems
                .chItemPrice.Width = 0
                .chItemQuantity.Width = 0
            End With
        End If

    End Sub

    'Call this method for logging user activities
    Public Sub log(msg As String, Optional logType As String = "EVENT")
        Dim curDirectory As String = My.Settings.logPath
        If System.IO.File.Exists(curDirectory) = False Then
            System.IO.Directory.CreateDirectory(curDirectory)
        End If

        Dim fs As FileStream = New FileStream(curDirectory + "LOGS_" + Format(Now, "yyyyMMdd") + ".log", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim s As StreamWriter = New StreamWriter(fs)
        s.Close()
        fs.Close()

        Dim fs1 As FileStream = New FileStream(curDirectory + "LOGS_" + Format(Now, "yyyyMMdd") + ".log", FileMode.Append, FileAccess.Write)
        Dim s1 As StreamWriter = New StreamWriter(fs1)

        msg.Replace(Chr(0), "")
        s1.WriteLine(Now + " #" + logType.ToUpper + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name + " - " + msg)
        s1.Close()
        fs1.Close()


    End Sub





End Module
