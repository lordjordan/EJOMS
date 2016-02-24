Imports System.Data.SqlClient
Public Class Reports

    Private Sub showPrintMe(mode As Boolean)
        pnlPrint.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub

   

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        showPrintMe(True)
        Try
            Dim row1 As DataRow = Nothing
            Dim DS As New DataSet
            Dim rptINC As New SalesReport
            'mag a-add na sa dataset (DS)
            DS.Tables.Add("SalesReport")
            'lagay tayo ng columns
            With DS.Tables(0).Columns
                .Add("job_id")
                .Add("Name")
                .Add("car_model")
                .Add("sales_revenue")
                .Add("balance")
                .Add("date_From")
                .Add("date_To")
            End With

            For x = 1 To lvSales.Items.Count Step 1
                If lvSales.Items(x - 1).SubItems(3).Text Then

                End If
                row1 = DS.Tables(0).NewRow
                row1(0) = lvSales.Items(x - 1).Text
                row1(1) = lvSales.Items(x - 1).SubItems(1).Text
                row1(2) = lvSales.Items(x - 1).SubItems(2).Text
                row1(3) = lvSales.Items(x - 1).SubItems(3).Text
                row1(4) = lvSales.Items(x - 1).SubItems(4).Text
                row1(5) = Format(dtFromDate.Value, "MM/dd/yyyy")
                row1(6) = Format(dtToDate.Value, "MM/dd/yyyy")
                DS.Tables(0).Rows.Add(row1)
            Next
            If DS.Tables(0).Rows.Count = 0 Then
                'condition
            End If

            DS.WriteXml("XML\SalesReport.xml")

            Dim dsINC As New DataSet
            dsINC = New dsReportJobsOrder
            Dim dsINCTemp As New DataSet
            dsINCTemp = New DataSet()
            'dsINCTemp = New DSreports
            dsINCTemp.ReadXml("XML\SalesReport.xml")
            dsINC.Merge(dsINCTemp.Tables(0))

            'MsgBox(dsINCTemp.Tables(0).Rows(0).Item(0).ToString)
            rptINC = New SalesReport
            rptINC.SetDataSource(dsINCTemp.Tables(0))
            crvSalesReport.ReportSource = rptINC

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancelPrintattack_Click(sender As Object, e As EventArgs) Handles btnCancelPrintattack.Click
        showPrintMe(False)
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        showUSC(uscMainmenu)
    End Sub
    Public Sub LoadListview(Optional search = False)
        'my version eom later
        Try
            lvSales.Items.Clear()
            Dim thedate As String

            thedate = Format(Date.Now, "yyyyMM") & "01"
            dtFromDate.Value = Format(Date.Now, "MM") & "-01-" & Format(Date.Now, "yyyy")
            dr = db.ExecuteReader("SELECT DISTINCT  tbl_job_orders.job_id as 'JO_id' , last_name + ', ' + first_name + ' ' + middle_name as name, car_model_year + '/' + plate_no as 'Car model/Year/Plate no.'," & _
                 "(select isnull(sum(cast (amount as bigint) ),0) as y from tbl_payments where tbl_payments.job_id = tbl_job_orders.job_id " & _
                 "and payment_date between '" & thedate & "' and  '" & Format(Date.Now, "yyyyMMdd") & "') as 'Sales revenue' " & _
                 ",((SELECT sum(cast(price as bigint) * cast(quantity as bigint))  from tbl_ordered_items where tbl_ordered_items.job_id=tbl_job_orders.job_id ) +  " & _
                "(SELECT sum(cast(service_fee as bigint) )from tbl_ordered_services where tbl_ordered_services.job_id=tbl_job_orders.job_id )) - " & _
                "(select isnull(sum(cast (amount as bigint) ),0)  from tbl_payments where tbl_payments.job_id = tbl_job_orders.job_id " & _
                 ") as 'Balance' " & _
                "FROM  tbl_job_orders  inner JOIN tbl_cars   on tbl_job_orders.car_id  = tbl_cars.car_id " & _
                "inner Join " & _
                "tbl_payments on tbl_job_orders.job_id = tbl_payments.job_id " & _
                "inner JOIN tbl_ordered_items on tbl_job_orders.job_id = tbl_ordered_items.job_id " & _
                "inner join tbl_ordered_services on tbl_job_orders.job_id = tbl_ordered_services.job_id " & _
                "WHERE tbl_job_orders.status = 0 or  tbl_job_orders.status = 1")
            If dr.HasRows Then
                Do While dr.Read
                    If dr.Item("Sales Revenue") = 0 And dr.Item("Balance") = 0 Then
                        Continue Do
                    Else
                        itm = lvSales.Items.Add(dr.Item("JO_id"))
                        itm.SubItems.Add(dr.Item("name"))
                        itm.SubItems.Add(dr.Item("Car model/Year/Plate no."))
                        If dr.Item("Sales Revenue") = 0 Then
                            itm.SubItems.Add(FormatNumber(dr.Item("Sales Revenue")))
                        Else
                            itm.SubItems.Add(FormatNumber(StrToNum(dr.Item("Sales Revenue"))))
                        End If
                        If dr.Item("Balance") = 0 Then
                            itm.SubItems.Add(FormatNumber(dr.Item("Balance")))
                        Else
                            itm.SubItems.Add(FormatNumber(StrToNum(dr.Item("Balance"))))
                        End If
                    End If
                Loop
            Else
                MsgBox("No record of sales for the month of " & Format(dtFromDate.Value, "MM-dd-yyyy") & " and " & _
                        Format(dtToDate.Value, "MM-dd-yyyy"), vbExclamation + vbOKOnly, "No record.")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try






        'Dim trevenue, tbalance As Double
        'Dim totalamount = uscJobOrder.txtOverallAmount.Text
        'Dim parameters As New Dictionary(Of String, Object)
        'lvSales.Items.Clear()
        'Dim itm As ListViewItem
        ''parameters.add("keyword", "%" & txtsearch.text & "%")
        'Try
        '    'dr = db.executereader("select tbl_job_orders.job_id , last_name + ', '+ first_name + ' ' + middle_name as name , " & _
        '    '                      "car_model_year, service_fee, price, quantity " & _
        '    '                      "from tbl_job_orders inner join tbl_cars on tbl_job_orders.car_id = tbl_cars.car_id " & _
        '    '                      "inner join tbl_ordered_items on tbl_job_orders.job_id = tbl_ordered_items.job_id " & _
        '    '                      "inner join tbl_ordered_services on tbl_job_orders.job_id = tbl_ordered_services.job_id") 'pendings lang muna

        '    If search = True Then
        '        Dim from_date, to_date As String
        '        from_date = DateToStr(dtFromDate.Text)
        '        to_date = DateToStr(dtToDate.Text)
        '        dr = db.ExecuteReader("select tbl_job_orders.job_id , last_name + ', '+ first_name + ' ' + middle_name as name, car_model_year, service_fee, price, quantity, " & _
        '                         "(select isnull(sum(cast (amount as bigint) ),0) from tbl_payments where tbl_payments.job_id=tbl_job_orders.job_id) as balance " & _
        '                         "from tbl_job_orders inner join tbl_cars on tbl_job_orders.car_id = tbl_cars.car_id " & _
        '                         "inner join tbl_ordered_items on tbl_job_orders.job_id = tbl_ordered_items.job_id " & _
        '                         "inner join tbl_ordered_services on tbl_job_orders.job_id = tbl_ordered_services.job_id  where tbl_job_orders.job_id in ( select distinct(job_id) from tbl_payments where payment_date between '" & from_date & "' and '" & to_date & "') " & _
        '                         "and status= 0 or status = 1")
        '    Else
        '        Dim thedate As String
        '        thedate = Format(Date.Now, "MM") & "-01-" & Format(Date.Now, "yyyy hh:mm:ss.fff")
        '        dr = db.ExecuteReader("select tbl_job_orders.job_id , last_name + ', '+ first_name + ' ' + middle_name as name, car_model_year, service_fee, price, quantity, " & _
        '                         "(select isnull(sum(cast (amount as bigint) ),0) from tbl_payments where tbl_payments.job_id=tbl_job_orders.job_id) as balance " & _
        '                         "from tbl_job_orders inner join tbl_cars on tbl_job_orders.car_id = tbl_cars.car_id " & _
        '                         "inner join tbl_ordered_items on tbl_job_orders.job_id = tbl_ordered_items.job_id " & _
        '                         "inner join tbl_ordered_services on tbl_job_orders.job_id = tbl_ordered_services.job_id where tbl_job_orders.job_id in ( select distinct(job_id) from tbl_payments where payment_date > '" & thedate & "') " & " and status= 0 or status = 1")
        '    End If
        '    '"where tbl_job_orders.job_id in (select tbl_payments.job_id from tbl_payments)")
        '    If dr.HasRows Then
        '        Do While dr.Read
        '            itm = lvSales.Items.Add(dr.Item("job_id"))
        '            itm.SubItems.Add(dr.Item("name"))
        '            itm.SubItems.Add(dr.Item("car_model_year"))
        '            Dim itmprice, itmquantity, servicefee, totalsales, bal, totalbalance As Double
        '            itmprice = (StrToNum(dr.Item("price")))
        '            itmquantity = (dr.Item("quantity"))
        '            servicefee = (StrToNum(dr.Item("service_fee")))
        '            totalsales = (itmprice * itmquantity) + servicefee
        '            itm.SubItems.Add(FormatNumber(totalsales, 2))

        '            Dim bals As Double = (dr.Item("balance"))
        '            If bals = "0" Then
        '                itm.SubItems.Add(FormatNumber(totalsales, 2))
        '                'exit sub
        '            Else
        '                bal = (StrToNum(dr.Item("balance")))
        '                If totalsales = bal Then
        '                    itm.SubItems.Add("0.00")
        '                ElseIf totalsales > bal Then
        '                    totalbalance = totalsales - bal
        '                    itm.SubItems.Add(FormatNumber(totalbalance, 2))
        '                ElseIf bal = 0 Then
        '                    itm.SubItems.Add(FormatNumber(totalsales, 2))
        '                End If
        '            End If
        '            trevenue += totalsales
        '            tbalance += totalbalance
        '        Loop

        '    Else
        '        MsgBox("no sales report to show.", vbInformation + vbOKOnly, "no record(s)")
        '    End If
        '    lblTotalRevenue.Text = FormatNumber(trevenue, 2)
        '    lblbalance.Text = FormatNumber(tbalance, 2)
        'Catch ex As Exception
        '    MsgBox("error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "error")
        'Finally
        '    db.Dispose()
        'End Try
    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try

            lvSales.Items.Clear()
            dr = db.ExecuteReader("SELECT DISTINCT  tbl_job_orders.job_id as 'JO_id' , last_name + ', ' + first_name + ' ' + middle_name as name, car_model_year + '/' + plate_no as 'Car model/Year/Plate no.'," & _
                 "(select isnull(sum(cast (amount as bigint) ),0) as y from tbl_payments where tbl_payments.job_id = tbl_job_orders.job_id " & _
                 "and payment_date between '" & Format(dtFromDate.Value, "yyyyMMdd") & "' and  '" & Format(dtToDate.Value, "yyyyMMdd") & "') as 'Sales revenue' " & _
                 ",((SELECT sum(cast(price as bigint) * cast(quantity as bigint))  from tbl_ordered_items where tbl_ordered_items.job_id=tbl_job_orders.job_id ) +  " & _
                "(SELECT sum(cast(service_fee as bigint) )from tbl_ordered_services where tbl_ordered_services.job_id=tbl_job_orders.job_id )) - " & _
                "(select isnull(sum(cast (amount as bigint) ),0)  from tbl_payments where tbl_payments.job_id = tbl_job_orders.job_id " & _
                 ") as 'Balance' " & _
                "FROM  tbl_job_orders  inner JOIN tbl_cars   on tbl_job_orders.car_id  = tbl_cars.car_id " & _
                "inner Join " & _
                "tbl_payments on tbl_job_orders.job_id = tbl_payments.job_id " & _
                "inner JOIN tbl_ordered_items on tbl_job_orders.job_id = tbl_ordered_items.job_id " & _
                "inner join tbl_ordered_services on tbl_job_orders.job_id = tbl_ordered_services.job_id " & _
                "WHERE tbl_job_orders.status = 0 or  tbl_job_orders.status = 1")
            If dr.HasRows Then
                
                Do While dr.Read
                   
                    If dr.Item("Sales Revenue") = 0 And dr.Item("Balance") = 0 Then
                        Continue Do
                    Else
                        itm = lvSales.Items.Add(dr.Item("JO_id"))
                        itm.SubItems.Add(dr.Item("name"))
                        itm.SubItems.Add(dr.Item("Car model/Year/Plate no."))
                        If dr.Item("Sales Revenue") = 0 Then
                            itm.SubItems.Add(FormatNumber(dr.Item("Sales Revenue")))
                        Else
                            itm.SubItems.Add(FormatNumber(StrToNum(dr.Item("Sales Revenue"))))
                        End If
                        If dr.Item("Balance") = 0 Then
                            itm.SubItems.Add(FormatNumber(dr.Item("Balance")))
                        Else
                            itm.SubItems.Add(FormatNumber(StrToNum(dr.Item("Balance"))))
                        End If

                    End If
                Loop
            Else
                MsgBox("No record of sales for the month of " & Format(dtFromDate, "MM-dd-yyyy") & " and " & _
                        Format(dtToDate, "MM-dd-yyyy"), vbExclamation + vbOKOnly, "No record.")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub btnPrintAttack_Click(sender As Object, e As EventArgs) Handles btnPrintAttack.Click
        crvSalesReport.PrintReport()
    End Sub
End Class
