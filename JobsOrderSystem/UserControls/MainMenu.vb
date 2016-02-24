Imports System.Data.SqlClient

Public Class MainMenu
    Dim timerStopper As String
    Dim btnNoti As Boolean = False

    Private Sub btnJobOrderList_Click(sender As Object, e As EventArgs) Handles btnJobOrderList.Click

        showUSC(uscJobOrder)
        uscJobOrder.loadJobsOrder()
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click

        showUSC(uscItem)
        uscItem.load_items()
    End Sub

    Private Sub btnServices_Click(sender As Object, e As EventArgs) Handles btnServices.Click

        showUSC(uscServices)
        uscServices.load_Listview()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Select Case MessageBox.Show("Log out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                log("User_id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "; Logged-out.")
                frmLogin.reset()
                frmLogin.Show()

                frmMain.Hide()
        End Select


    End Sub

    Private Sub btnClients_Click(sender As Object, e As EventArgs)
        showUSC(uscCars)
    End Sub

    Private Sub btnSalesInvoice_Click(sender As Object, e As EventArgs) Handles btnSalesInvoice.Click
        showUSC(uscSupplierInvoice)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        showUSC(uscSystemUsers)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        showUSC(uscReports)
        uscReports.LoadListview()
    End Sub



    Private Sub tmrTimeDate_Tick(sender As Object, e As EventArgs) Handles timerAnimate.Tick
        timerAnimate.Enabled = False
        'lblDate.Text = Now.DayOfWeek.ToString & ", " & Now.Day.ToString & " " & Now.mo.ToString
        lblTime.Text = Format(Now, "long time") 'Now.Hour.ToString & ":" & Now.Minute.ToString
        'lblDate.Text = Format(Now, "dddd, d MMMM")
        lblDate.Text = Format(Now, "long date")

        timerAnimate.Enabled = True
    End Sub
    Public Sub get_notifications()
        '## RETURN TRUE if there are any notifications 

        Dim db As New DBHelper(My.Settings.DBconn)
        Dim dr As SqlDataReader
        Dim end_date, start_date As String
        Dim past_due_invoice, close_invoice, critical_items

        '# GET unpaid invoices 
        start_date = DateToStr(Now)
        end_date = DateToStr(DateAdd(DateInterval.Day, 3, Now))
        dr = db.ExecuteReader("SELECT COUNT(invoice_id) unpaid FROM tbl_supsales_invoices WHERE is_paid=0 AND due_date < '" & start_date & "'")
        dr.Read()
        past_due_invoice = dr.Item("unpaid")

        '# GET unpaid invoices 3 days
        start_date = DateToStr(Now)
        end_date = DateToStr(DateAdd(DateInterval.Day, 3, Now))
        dr = db.ExecuteReader("SELECT COUNT(invoice_id) unpaid FROM tbl_supsales_invoices WHERE is_paid=0 AND due_date BETWEEN '" & start_date & "' AND '" & end_date & "'")
        dr.Read()
        close_invoice = dr.Item("unpaid")

        '#GET critical items
        dr = db.ExecuteReader("SELECT COUNT(item_id) as critical_level FROM tbl_items WHERE quantity<=critical_level")
        dr.Read()
        critical_items = dr.Item("critical_level")
        If user_type = 3 Or user_type = 0 Then
            btnNotification.Visible = False

        Else
            If past_due_invoice = 0 And close_invoice = 0 And critical_items = 0 Then
                btnNotification.Visible = False
                If flwpnl_notifications.Height <> 0 Then
                    flwpnl_notifications.Height = 0
                End If
            Else
                btnNotification.Visible = True

            End If
        End If


    End Sub

    Private Sub show_notifications()

        Dim db As New DBHelper(My.Settings.DBconn)
        Dim dr As SqlDataReader
        Dim end_date, start_date As String
        Dim invoice_msg, item_msg As String
        Dim btn As Button
        Dim button_height = 60, button_width = 250, btn_bg = System.Drawing.Color.MidnightBlue, btn_font_face = New Font("Segoe UI", 10), btn_font_color = System.Drawing.Color.Gold, btn_font_size = 10, btn_text_align = ContentAlignment.MiddleRight
        Dim btn_border = System.Drawing.Color.MidnightBlue, btn_flatstyle = FlatStyle.Flat
        Dim past_due_invoice, close_invoice, critical_items

        flwpnl_notifications.Controls.Clear()
     

        '# GET unpaid invoices 
        start_date = DateToStr(Now)
        end_date = DateToStr(DateAdd(DateInterval.Day, 3, Now))
        dr = db.ExecuteReader("SELECT COUNT(invoice_id) unpaid FROM tbl_supsales_invoices WHERE is_paid=0 AND due_date < '" & start_date & "'")
        dr.Read()
        past_due_invoice = dr.Item("unpaid")

        '# GET unpaid invoices 3 days
        start_date = DateToStr(Now)
        end_date = DateToStr(DateAdd(DateInterval.Day, 3, Now))
        dr = db.ExecuteReader("SELECT COUNT(invoice_id) unpaid FROM tbl_supsales_invoices WHERE is_paid=0 AND due_date BETWEEN '" & start_date & "' AND '" & end_date & "'")
        dr.Read()
        close_invoice = dr.Item("unpaid")

        '#GET critical items
        dr = db.ExecuteReader("SELECT COUNT(item_id) as critical_level FROM tbl_items WHERE quantity<=critical_level")
        dr.Read()
        critical_items = dr.Item("critical_level")

        'If past_due_invoice = 0 And close_invoice = 0 And critical_items = 0 Then
        '    'btn = New Button()
        '    'btn.Text = " 0 Notifications"
        '    'btn.Height = button_height
        '    'btn.Width = button_width
        '    'btn.BackColor = btn_bg
        '    'btn.ForeColor = btn_font_color
        '    'btn.TextAlign = btn_text_align
        '    'btn.FlatStyle = btn_flatstyle
        '    'btn.FlatAppearance.BorderColor = btn_border
        '    'btn.Font = btn_font_face

        '    'flwpnl_notifications.Controls.Add(btn)
        '    btnNotification.Visible = False
        '    Exit Sub
        'Else
        '    btnNotification.Visible = True
        'End If

        If past_due_invoice > 0 Then
            invoice_msg = "You have " & past_due_invoice & " unpaid invoice/s past due."
            btn = New Button()
            btn.Text = invoice_msg
            btn.Height = button_height
            btn.Width = button_width
            btn.BackColor = btn_bg
            btn.ForeColor = btn_font_color
            btn.TextAlign = btn_text_align
            btn.FlatStyle = btn_flatstyle
            btn.FlatAppearance.BorderColor = btn_border
            btn.Font = btn_font_face
            AddHandler btn.Click, AddressOf Me.btnSalesInvoice_Click

            flwpnl_notifications.Controls.Add(btn)

        End If


        If close_invoice > 0 Then
            invoice_msg = "You have " & close_invoice & " invoice/s due within the next three days."
            btn = New Button()
            btn.Text = invoice_msg
            btn.Height = button_height
            btn.Width = button_width
            btn.BackColor = btn_bg
            btn.ForeColor = btn_font_color
            btn.Font = btn_font_face
            btn.TextAlign = btn_text_align
            btn.FlatStyle = btn_flatstyle
            btn.FlatAppearance.BorderColor = btn_border
            AddHandler btn.Click, AddressOf Me.btnSalesInvoice_Click


            flwpnl_notifications.Controls.Add(btn)


        End If


        If critical_items > 0 Then
            item_msg = "You have " & critical_items & " item/s in critical level."
            btn = New Button()
            btn.Text = item_msg
            btn.Width = button_width
            btn.Height = button_height
            btn.BackColor = btn_bg
            btn.ForeColor = btn_font_color
            btn.Font = btn_font_face
            btn.TextAlign = btn_text_align
            btn.FlatStyle = btn_flatstyle
            btn.FlatAppearance.BorderColor = btn_border
            AddHandler btn.Click, AddressOf Me.btnItems_Click


            flwpnl_notifications.Controls.Add(btn)
        End If


    End Sub
    Private Sub btnClients_Click_1(sender As Object, e As EventArgs) Handles btnClients.Click
        uscCars.loadCars()
        showUSC(uscCars)
    End Sub

    Private Sub btnCarBrands_Click(sender As Object, e As EventArgs) Handles btnCarBrands.Click
        showUSC(uscCarBrands)
        uscCarBrands.loadCarBrands()
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
    Private Sub btnAddNewJO_Click(sender As Object, e As EventArgs) Handles btnAddNewJO.Click
        showUSC(uscJobOrder)

        uscJobOrder.btnAddNew.PerformClick()
    End Sub

    Private Sub btnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click
        If btnNoti = False Then
            btnNoti = True
            show_notifications()
        Else
            btnNoti = False
        End If
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If btnNoti = True Then
            timerStopper = flwpnl_notifications.Height
            If timerStopper = 250 Then
                Timer1.Stop()
                Exit Sub
            End If
            flwpnl_notifications.Height += 50
        Else
            timerStopper = flwpnl_notifications.Height
            If timerStopper = 0 Then
                Timer1.Stop()
                Exit Sub
            End If
            flwpnl_notifications.Height -= 50
        End If
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        showUSC(uscSettings)
    End Sub
End Class
