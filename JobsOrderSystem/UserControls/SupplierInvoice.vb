Imports System.Data.SqlClient
Public Class SupplierInvoice

    Dim timerStopper As String
    Dim btnAddNewClick, btnEditClick, btnPrintClick, btnAddEditClosed As Boolean
    Dim imgbyte As Byte() = Nothing
    Private Sub showAddEdit(mode As Boolean)
        pnlAddEdit.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        showUSC(uscMainmenu)
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        btnAddNewClick = True
        showAddEdit(True)
        lblAddedit.Text = "Add new supplier's sales invoice"
        If pnlAddEdit.Height <> 450 Then
            timerAnimate.Start()
        End If
    End Sub
    Private Sub btnAddEditClose_Click(sender As Object, e As EventArgs) Handles btnAddEditClose.Click
        clearData()
        btnAddEditClosed = True
        If pnlAddEdit.Height <> 0 Then
            timerAnimate.Start()
        End If
        pnlMain.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        EditItemInListView()
        If pnlAddEdit.Height <> 450 Then
            timerAnimate.Start()
        End If
    End Sub
    Private Sub EditItemInListView()
        pnlAddEdit.BringToFront()
        clearPanel()
        lblAddedit.Text = "Update supplier's sales invoice"
        If lvInvoice.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify
            btnAddNewClick = True
            Dim y As Integer
            y = lvInvoice.FocusedItem.Text
            Try
                dr = db.ExecuteReader("Select * from tbl_supsales_invoices WHERE invoice_id=" & y)
                'If dr.HasRows Then
                dr.Read()
                showAddEdit(True)
                pnlAddEdit.Visible = True
                txtID.Text = dr.Item("invoice_id").ToString
                txtfname.Text = dr.Item("img_name").ToString
                txtPrice.Text = StrToNum(dr.Item("price"))
                txtsupName.Text = dr.Item("supplier_name").ToString
                txtInvoiceNo.Text = dr.Item("invoice_no").ToString
                txtreceiptNo.Text = dr.Item("receipt_no").ToString
                dtDueDate.Text = StrToDate(dr.Item("due_date"))
                Dim stat = dr.Item("is_paid")
                If stat = "1" Then
                    dtPaidDate.Text = StrToDate(dr.Item("paid_date"))
                    cbPaid.Checked = True
                End If

                Dim imagestream As System.IO.MemoryStream = New System.IO.MemoryStream
                imgbyte = dr.Item("invoice_img")
                imagestream = New System.IO.MemoryStream(imgbyte)
                frmPreviewImg.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                frmPreviewImg.PictureBox1.Image = Drawing.Image.FromStream(imagestream)
                'frmPreviewImg.ShowDialog()


                'txtfname.Text = lvInvoice.SelectedItems(0).SubItems(1).Text
                'txtsupName.Text = lvInvoice.SelectedItems(0).SubItems(2).Text
                'txtInvoiceNo.Text = lvInvoice.SelectedItems(0).SubItems(3).Text
                'dtDueDate.Text = lvInvoice.SelectedItems(0).SubItems(4).Text
                'End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Dispose() '<--------CHECK THIS!
            End Try

        Else
            MessageBox.Show("Please select record to update.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
    End Sub
    Private Sub clearPanel()

        For Each Control In pnlAddEdit.Controls
            If TypeOf Control Is ComboBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

        For Each Control In pnlAddEdit.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control
    End Sub
    Private Sub clearPanel()

        For Each Control In pnlAddEdit.Controls
            If TypeOf Control Is ComboBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

        For Each Control In pnlAddEdit.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control
    End Sub
    Private Sub timerAnimate_Tick(sender As Object, e As EventArgs) Handles timerAnimate.Tick
        'opening
        If btnAddNewClick = True Then
            timerStopper = pnlAddEdit.Height
            If timerStopper = 450 Then
                timerAnimate.Stop()
                btnAddNewClick = False
                Exit Sub
            End If
            pnlAddEdit.Height += 50

        ElseIf btnEditClick = True Then
            timerStopper = pnlAddEdit.Height
            If timerStopper = 450 Then

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
    Public Function DateToStr(petsa As Date) As String
        Return Format(petsa, "yyyyMMdd")
    End Function

    '    imagestream = New System.IO.MemoryStream(imgbyte)
    '    'PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    '    'PictureBox1.Image = Drawing.Image.FromStream(imagestream)
    '    frmPreviewImg.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    '    frmPreviewImg.PictureBox1.Image = Drawing.Image.FromStream(imagestream)
    '    txtfname.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim data As New Dictionary(Of String, Object)

        If txtsupName.Text = "" Or txtPrice.Text = "" Or txtInvoiceNo.Text = "" Or txtfname.Text = "" Then
            MessageBox.Show("Some fields are empty.", "Fill up the Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        Try
            data.Add("supplier_name", Trim(txtsupName.Text))
            data.Add("price", NumToStr(txtPrice.Text))
            data.Add("invoice_no", Trim(txtInvoiceNo.Text))
            data.Add("receipt_no", txtreceiptNo.Text)
            data.Add("due_date", DateToStr(dtDueDate.Value))
            If cbPaid.Checked = True Then
                data.Add("paid_date", DateToStr(dtPaidDate.Value))
                data.Add("is_paid", "1")
            Else
                data.Add("paid_date", "")
                data.Add("is_paid", "0")
            End If
            data.Add("img_name", txtfname.Text)
            data.Add("invoice_img", imgbyte)

            'data.Add("", )
            If lblAddedit.Text = "Add new supplier's sales invoice" Then

                rec = db.ExecuteNonQuery("INSERT INTO tbl_supsales_invoices (supplier_name , invoice_no, receipt_no, due_date, paid_date, is_paid,img_name,invoice_img,price) VALUES " & _
                                         "(@supplier_name , @invoice_no, @receipt_no, @due_date, @paid_date, @is_paid, @img_name, @invoice_img,@price)", data)
                log("User_id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "add supplier invoice; 'Invoice_no'-'Receipt_no:" & "'" & Trim(txtInvoiceNo.Text) & "'-'" & _
                    Trim(txtreceiptNo.Text) & "'")
                MessageBox.Show("Invoice was recorded successfully.", "Invoice was added.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                'MsgBox("Invoice was recorded successfully.", vbInformation + vbOKOnly, "Invoice was added.")
            ElseIf lblAddedit.Text = "Update supplier's sales invoice" Then
                rec = db.ExecuteNonQuery("UPDATE tbl_supsales_invoices SET supplier_name=@supplier_name, invoice_no=@invoice_no, receipt_no=@receipt_no, due_date=@due_date, paid_date=@paid_date,is_paid=@is_paid,img_name=@img_name,invoice_img=@invoice_img,price=@price WHERE invoice_id=" & txtID.Text, data)
                log("User_id:" & user_id & "; User_name:" & frmLogin.txtUsername.Text & "update supplier invoice.; Supplier_id" & txtID.Text)
                If Not rec < 1 Then
                    MessageBox.Show("Record updated!", "Invoice was updated.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    lvInvoice.SelectedItems.Clear()
                End If
            End If
            data.Clear()
            showAddEdit(False)
            LoadListview()
            clearData()
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        Finally
            db.Dispose()
        End Try



        'Try
        '    data.Add("supplier_name", txtsupName.Text)
        '    data.Add("invoice_no", txtInvoiceNo.Text)
        '    data.Add("receipt_no", txtreceiptNo.Text)
        '    data.Add("due_date", DateToStr(dtDueDate.Value))
        '    If cbPaid.Checked = True Then
        '        data.Add("paid_date", DateToStr(dtPaidDate.Value))
        '        data.Add("is_paid", "1")
        '    Else
        '        data.Add("paid_date", " ")
        '        data.Add("is_paid", "0")
        '    End If
        '    'data.Add("", )
        '    data.Add("img_name", txtfname.Text)
        '    data.Add("invoice_img", imgbyte)

        '    rec = db.ExecuteNonQuery("UPDATE tbl_supsales_invoices SET supplier_name=@supplier_name, invoice_no=@invoice_no, receipt_no=@receipt_no, due_date=@due_date, paid_date=@paid_date,is_paid=@is_paid,img_name=@img_name,invoice_img=@invoice_img WHERE invoice_id=" & txtID.Text, data)
        '    If Not rec < 1 Then
        '        MessageBox.Show("Record updated!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        '        showAddEdit(False)
        '        clearPanel()
        '        LoadListview()
        '        lvInvoice.SelectedItems.Clear()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'Finally
        '    db.Dispose()
        'End Try
    End Sub

    Private Sub clearData()
        For Each Control In pnlAddEdit.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control
    End Sub

    Private Sub SupplierInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadListview()
    End Sub
    Private Sub LoadListview()
        Dim paidTotal, notPaidTotal As Double
        lvInvoice.Items.Clear()
        Try
            dr = db.ExecuteReader("SELECT * FROM tbl_supsales_invoices")
            If dr.HasRows Then
                Do While dr.Read

                    Dim paidStat = (dr.Item("is_paid"))
                    Dim presyo = StrToNum(dr.Item("price").ToString)

                    itm = Me.lvInvoice.Items.Add(dr.Item("invoice_id").ToString)
                    itm.SubItems.Add(dr.Item("img_name").ToString)
                    itm.SubItems.Add(dr.Item("supplier_name").ToString)
                    itm.SubItems.Add(presyo)
                    itm.SubItems.Add(dr.Item("invoice_no").ToString)
                    itm.SubItems.Add(dr.Item("receipt_no").ToString)
                    itm.SubItems.Add(StrToDate(dr.Item("due_date").ToString))
                    'para sa paid date
                    Dim pdate = dr.Item("paid_date").ToString
                    If pdate = Nothing Then
                        itm.SubItems.Add(" ")
                    Else
                        itm.SubItems.Add(StrToDate(dr.Item("paid_date")))
                    End If
                    'para sa status
                    If paidStat = "0" Then
                        itm.SubItems.Add("Not yet Paid")
                        notPaidTotal += presyo
                    ElseIf paidStat = "1" Then
                        itm.SubItems.Add("Paid")
                        paidTotal += presyo
                    End If
                Loop
                lblPaidTotal.Text = FormatNumber(paidTotal, 2)
                lblnotPaidTotal.Text = FormatNumber(notPaidTotal, 2)
                lblTotal.Text = paidTotal + notPaidTotal
            Else
                MessageBox.Show("No record of Invoices", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbPaid_CheckedChanged(sender As Object, e As EventArgs) Handles cbPaid.CheckedChanged
        If cbPaid.Checked = True Then
            dtPaidDate.Enabled = True
        ElseIf cbPaid.Checked = False Then
            dtPaidDate.Enabled = False
        End If
    End Sub
    Private Sub btnBrowseInvoice_Click(sender As Object, e As EventArgs) Handles btnBrowseInvoice.Click
        OpenFileDialog1.ShowDialog()
        txtfname.Text = OpenFileDialog1.FileName
        Dim myimage As Image = Image.FromFile(uscSupplierInvoice.txtfname.Text)
        Dim imagestream As System.IO.MemoryStream = New System.IO.MemoryStream
        myimage.Save(imagestream, System.Drawing.Imaging.ImageFormat.Jpeg)
        imgbyte = imagestream.GetBuffer()
        imagestream = New System.IO.MemoryStream(imgbyte)
        frmPreviewImg.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        frmPreviewImg.PictureBox1.Image = Drawing.Image.FromStream(imagestream)
        txtfname.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)

        'If OpenFileDialog1.ShowDialog = vbOK Then
        '    Dim myimage As Image = Image.FromFile(OpenFileDialog1.FileName)
        '    Dim imagestream As System.IO.MemoryStream = New System.IO.MemoryStream

        '    myimage.Save(imagestream, System.Drawing.Imaging.ImageFormat.Jpeg)
        '    imgbyte = imagestream.GetBuffer()

        '    imagestream = New System.IO.MemoryStream(imgbyte)
        '    'PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        '    'PictureBox1.Image = Drawing.Image.FromStream(imagestream)
        '    frmPreviewImg.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        '    frmPreviewImg.PictureBox1.Image = Drawing.Image.FromStream(imagestream)
        '    txtfname.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)

        'End If
    End Sub

    Private Sub btnViewImg_Click(sender As Object, e As EventArgs) Handles btnViewImg.Click
        frmPreviewImg.ShowDialog()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim paidTotal, notPaidTotal As Double
        data.Add("keyword", "%" & Trim(txtSearch.Text) & "%")
        Try
            Dim stat As Integer
            If txtSearch.Text = "paid" Then
                stat = "1"
            ElseIf txtSearch.Text = "not paid" Then
                stat = "0"
            End If
            dr = db.ExecuteReader("SELECT * FROM tbl_supsales_invoices WHERE invoice_id LIKE '%" & txt & "%' OR " & _
                                  " invoice_no LIKE @keyword OR " & _
                                  " supplier_name LIKE @keyword OR " & _
                                  " receipt_no LIKE @keyword OR " & _
                                  " is_paid LIKE @keyword ", data)
            lvInvoice.Items.Clear()
            If dr.HasRows Then
                Do While dr.Read
                    Dim paidStat = (dr.Item("is_paid"))
                    Dim presyo = StrToNum(dr.Item("price").ToString)

                    itm = Me.lvInvoice.Items.Add(dr.Item("invoice_id").ToString)
                    itm.SubItems.Add(dr.Item("img_name").ToString)
                    itm.SubItems.Add(dr.Item("supplier_name").ToString)
                    itm.SubItems.Add(presyo)
                    itm.SubItems.Add(dr.Item("invoice_no").ToString)
                    itm.SubItems.Add(dr.Item("receipt_no").ToString)
                    itm.SubItems.Add(StrToDate(dr.Item("due_date").ToString))
                    'para sa paid date
                    Dim pdate = dr.Item("paid_date").ToString
                    If pdate = Nothing Then
                        itm.SubItems.Add(" ")
                    Else
                        itm.SubItems.Add(StrToDate(dr.Item("paid_date")))
                    End If
                    'para sa status
                    If paidStat = "0" Then
                        itm.SubItems.Add("Not yet Paid")
                        notPaidTotal += presyo
                    ElseIf paidStat = "1" Then
                        itm.SubItems.Add("Paid")
                        paidTotal += presyo
                    End If
                Loop
                lblPaidTotal.Text = FormatNumber(paidTotal, 2)
                lblnotPaidTotal.Text = FormatNumber(notPaidTotal, 2)
                lblTotal.Text = paidTotal + notPaidTotal
            Else
                MsgBox("No results found", vbExclamation + vbOKOnly, "No invoice.")
            End If
            data.Clear()
        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            showPrintMe(True)
            Dim row1 As DataRow = Nothing
            Dim DS As New DataSet
            Dim rptINC As New InvoiceReport
            'mag a-add na sa dataset (DS)
            DS.Tables.Add("SupInvoice")
            'lagay tayo ng columns
            With DS.Tables(0).Columns
                .Add("invoice_id")
                .Add("supplier_name")
                .Add("invoice_no")
                .Add("receipt_no")
                .Add("due_date")
                .Add("paid_date")
                .Add("is_paid")
                .Add("price")
                .Add("tPrice")
            End With
            For x = 1 To lvInvoice.Items.Count Step 1
                Dim stat = lvInvoice.Items(x - 1).SubItems(8).Text
                row1 = DS.Tables(0).NewRow
                row1(0) = lvInvoice.Items(x - 1).Text
                row1(1) = lvInvoice.Items(x - 1).SubItems(2).Text
                row1(2) = lvInvoice.Items(x - 1).SubItems(4).Text
                row1(3) = lvInvoice.Items(x - 1).SubItems(5).Text
                row1(4) = lvInvoice.Items(x - 1).SubItems(6).Text
                row1(5) = lvInvoice.Items(x - 1).SubItems(7).Text
                row1(6) = stat
                row1(7) = lvInvoice.Items(x - 1).SubItems(3).Text
                If stat = "Paid" Then
                    row1(8) = lblPaidTotal.Text
                ElseIf stat = "Not yet Paid" Then
                    row1(8) = lblnotPaidTotal.Text
                End If

                DS.Tables(0).Rows.Add(row1)
            Next

            DS.WriteXml("XML\SupplierInvoice.xml")

            Dim dsINC As New DataSet
            dsINC = New dsReportJobsOrder
            Dim dsINCTemp As New DataSet
            dsINCTemp = New DataSet()
            'dsINCTemp = New DSreports
            dsINCTemp.ReadXml("XML\SupplierInvoice.xml")
            dsINC.Merge(dsINCTemp.Tables(0))

            'MsgBox(dsINCTemp.Tables(0).Rows(0).Item(0).ToString)
            rptINC = New InvoiceReport
            rptINC.SetDataSource(dsINCTemp.Tables(0))
            crvInvoice.ReportSource = rptINC

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub showPrintMe(mode As Boolean)
        pnlPrint.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub

    Private Sub btnCancelPrintattack_Click(sender As Object, e As EventArgs) Handles btnCancelPrintattack.Click
        showPrintMe(False)
    End Sub

    Private Sub pnlPrint_Paint(sender As Object, e As PaintEventArgs) Handles pnlPrint.Paint

    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If e.Handled = (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
        End If
    End Sub
End Class
