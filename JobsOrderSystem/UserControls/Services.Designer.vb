<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Services
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Services))
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btn_PricePerCarBrand = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvServices = New System.Windows.Forms.ListView()
        Me.chSerID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timerAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.pnlAddEdit = New System.Windows.Forms.Panel()
        Me.txtServiceFee = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtServiceName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtServiceID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddEditClose = New System.Windows.Forms.Button()
        Me.lblAddedit = New System.Windows.Forms.Label()
        Me.pnl_PerCarBrand = New System.Windows.Forms.Panel()
        Me.pnl_PerCarBrandForm = New System.Windows.Forms.Panel()
        Me.lbl_scb_id = New System.Windows.Forms.Label()
        Me.btn_PerCarBrandCancel = New System.Windows.Forms.Button()
        Me.cbo_carbrand = New System.Windows.Forms.ComboBox()
        Me.txt_adjusted_price = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_PerCarBrandSave = New System.Windows.Forms.Button()
        Me.txt_PCB_service_fee = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_PCB_service_name = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_PCB_ID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_PerCarBrandAddNew = New System.Windows.Forms.Button()
        Me.btn_PerCarBrandUpdate = New System.Windows.Forms.Button()
        Me.btn_PerCarBrandClose = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lvw_PerCarBrand = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlPrint = New System.Windows.Forms.Panel()
        Me.crvServices = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnPrintAttack = New System.Windows.Forms.Button()
        Me.btnCancelPrintattack = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.pnlMain.SuspendLayout()
        Me.pnlAddEdit.SuspendLayout()
        Me.pnl_PerCarBrand.SuspendLayout()
        Me.pnl_PerCarBrandForm.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlPrint.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.BackColor = System.Drawing.Color.Silver
        Me.pnlMain.Controls.Add(Me.btn_PricePerCarBrand)
        Me.pnlMain.Controls.Add(Me.btnAddNew)
        Me.pnlMain.Controls.Add(Me.btnBack)
        Me.pnlMain.Controls.Add(Me.btnSearch)
        Me.pnlMain.Controls.Add(Me.btnPrint)
        Me.pnlMain.Controls.Add(Me.btnUpdate)
        Me.pnlMain.Controls.Add(Me.txtSearch)
        Me.pnlMain.Controls.Add(Me.Label3)
        Me.pnlMain.Controls.Add(Me.lvServices)
        Me.pnlMain.Controls.Add(Me.Label2)
        Me.pnlMain.Location = New System.Drawing.Point(0, 30)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1072, 479)
        Me.pnlMain.TabIndex = 208
        '
        'btn_PricePerCarBrand
        '
        Me.btn_PricePerCarBrand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_PricePerCarBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_PricePerCarBrand.FlatAppearance.BorderSize = 0
        Me.btn_PricePerCarBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PricePerCarBrand.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PricePerCarBrand.ForeColor = System.Drawing.Color.Gold
        Me.btn_PricePerCarBrand.Location = New System.Drawing.Point(475, 1)
        Me.btn_PricePerCarBrand.Name = "btn_PricePerCarBrand"
        Me.btn_PricePerCarBrand.Size = New System.Drawing.Size(147, 51)
        Me.btn_PricePerCarBrand.TabIndex = 214
        Me.btn_PricePerCarBrand.Text = "Price per Carbrand"
        Me.btn_PricePerCarBrand.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_PricePerCarBrand.UseVisualStyleBackColor = False
        Me.btn_PricePerCarBrand.Visible = False
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnAddNew.FlatAppearance.BorderSize = 0
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.Gold
        Me.btnAddNew.Location = New System.Drawing.Point(628, 1)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(102, 51)
        Me.btnAddNew.TabIndex = 211
        Me.btnAddNew.Text = "Add new"
        Me.btnAddNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Gold
        Me.btnBack.Location = New System.Drawing.Point(952, 1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(102, 51)
        Me.btnBack.TabIndex = 205
        Me.btnBack.Text = "Back"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(284, 80)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(28, 26)
        Me.btnSearch.TabIndex = 209
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(844, 1)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(102, 51)
        Me.btnPrint.TabIndex = 213
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Gold
        Me.btnUpdate.Location = New System.Drawing.Point(736, 1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 51)
        Me.btnUpdate.TabIndex = 212
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(62, 80)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(222, 26)
        Me.txtSearch.TabIndex = 208
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 21)
        Me.Label3.TabIndex = 207
        Me.Label3.Text = "Search"
        '
        'lvServices
        '
        Me.lvServices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvServices.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvServices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chSerID, Me.chSerName, Me.ColumnHeader1})
        Me.lvServices.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvServices.FullRowSelect = True
        Me.lvServices.GridLines = True
        Me.lvServices.HideSelection = False
        Me.lvServices.Location = New System.Drawing.Point(3, 112)
        Me.lvServices.MultiSelect = False
        Me.lvServices.Name = "lvServices"
        Me.lvServices.Size = New System.Drawing.Size(1051, 354)
        Me.lvServices.TabIndex = 210
        Me.lvServices.UseCompatibleStateImageBehavior = False
        Me.lvServices.View = System.Windows.Forms.View.Details
        '
        'chSerID
        '
        Me.chSerID.Text = "Service ID"
        Me.chSerID.Width = 127
        '
        'chSerName
        '
        Me.chSerName.Text = "Service name"
        Me.chSerName.Width = 511
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Service fee"
        Me.ColumnHeader1.Width = 412
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(0, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1072, 51)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = " Services"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'timerAnimate
        '
        Me.timerAnimate.Interval = 1
        '
        'pnlAddEdit
        '
        Me.pnlAddEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlAddEdit.BackColor = System.Drawing.Color.Silver
        Me.pnlAddEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAddEdit.Controls.Add(Me.txtServiceFee)
        Me.pnlAddEdit.Controls.Add(Me.Label5)
        Me.pnlAddEdit.Controls.Add(Me.txtServiceName)
        Me.pnlAddEdit.Controls.Add(Me.Label11)
        Me.pnlAddEdit.Controls.Add(Me.txtServiceID)
        Me.pnlAddEdit.Controls.Add(Me.Label4)
        Me.pnlAddEdit.Controls.Add(Me.btnSave)
        Me.pnlAddEdit.Controls.Add(Me.btnAddEditClose)
        Me.pnlAddEdit.Controls.Add(Me.lblAddedit)
        Me.pnlAddEdit.Font = New System.Drawing.Font("Symbol", 8.25!)
        Me.pnlAddEdit.Location = New System.Drawing.Point(318, 30)
        Me.pnlAddEdit.Name = "pnlAddEdit"
        Me.pnlAddEdit.Size = New System.Drawing.Size(437, 0)
        Me.pnlAddEdit.TabIndex = 217
        Me.pnlAddEdit.Visible = False
        '
        'txtServiceFee
        '
        Me.txtServiceFee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtServiceFee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtServiceFee.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceFee.Location = New System.Drawing.Point(163, 137)
        Me.txtServiceFee.Name = "txtServiceFee"
        Me.txtServiceFee.Size = New System.Drawing.Size(128, 26)
        Me.txtServiceFee.TabIndex = 234
        Me.txtServiceFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 21)
        Me.Label5.TabIndex = 233
        Me.Label5.Text = "Service fee"
        '
        'txtServiceName
        '
        Me.txtServiceName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtServiceName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtServiceName.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceName.Location = New System.Drawing.Point(163, 105)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.Size = New System.Drawing.Size(244, 26)
        Me.txtServiceName.TabIndex = 232
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(58, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 21)
        Me.Label11.TabIndex = 231
        Me.Label11.Text = "Service name"
        '
        'txtServiceID
        '
        Me.txtServiceID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtServiceID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtServiceID.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceID.Location = New System.Drawing.Point(163, 73)
        Me.txtServiceID.Name = "txtServiceID"
        Me.txtServiceID.ReadOnly = True
        Me.txtServiceID.Size = New System.Drawing.Size(128, 26)
        Me.txtServiceID.TabIndex = 228
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 227
        Me.Label4.Text = "Service ID"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(224, -1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 51)
        Me.btnSave.TabIndex = 226
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAddEditClose
        '
        Me.btnAddEditClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEditClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnAddEditClose.FlatAppearance.BorderSize = 0
        Me.btnAddEditClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEditClose.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEditClose.ForeColor = System.Drawing.Color.Gold
        Me.btnAddEditClose.Location = New System.Drawing.Point(332, -1)
        Me.btnAddEditClose.Name = "btnAddEditClose"
        Me.btnAddEditClose.Size = New System.Drawing.Size(102, 51)
        Me.btnAddEditClose.TabIndex = 225
        Me.btnAddEditClose.Text = "Close"
        Me.btnAddEditClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddEditClose.UseVisualStyleBackColor = False
        '
        'lblAddedit
        '
        Me.lblAddedit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddedit.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblAddedit.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddedit.ForeColor = System.Drawing.Color.Gold
        Me.lblAddedit.Location = New System.Drawing.Point(0, -1)
        Me.lblAddedit.Name = "lblAddedit"
        Me.lblAddedit.Size = New System.Drawing.Size(435, 51)
        Me.lblAddedit.TabIndex = 224
        Me.lblAddedit.Text = "  Add services"
        Me.lblAddedit.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'pnl_PerCarBrand
        '
        Me.pnl_PerCarBrand.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_PerCarBrand.BackColor = System.Drawing.Color.Silver
        Me.pnl_PerCarBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_PerCarBrand.Controls.Add(Me.pnl_PerCarBrandForm)
        Me.pnl_PerCarBrand.Controls.Add(Me.btn_PerCarBrandAddNew)
        Me.pnl_PerCarBrand.Controls.Add(Me.btn_PerCarBrandUpdate)
        Me.pnl_PerCarBrand.Controls.Add(Me.btn_PerCarBrandClose)
        Me.pnl_PerCarBrand.Controls.Add(Me.Label8)
        Me.pnl_PerCarBrand.Controls.Add(Me.lvw_PerCarBrand)
        Me.pnl_PerCarBrand.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_PerCarBrand.Location = New System.Drawing.Point(3, 30)
        Me.pnl_PerCarBrand.Name = "pnl_PerCarBrand"
        Me.pnl_PerCarBrand.Size = New System.Drawing.Size(1017, 492)
        Me.pnl_PerCarBrand.TabIndex = 240
        Me.pnl_PerCarBrand.Visible = False
        '
        'pnl_PerCarBrandForm
        '
        Me.pnl_PerCarBrandForm.Controls.Add(Me.lbl_scb_id)
        Me.pnl_PerCarBrandForm.Controls.Add(Me.btn_PerCarBrandCancel)
        Me.pnl_PerCarBrandForm.Controls.Add(Me.cbo_carbrand)
        Me.pnl_PerCarBrandForm.Controls.Add(Me.txt_adjusted_price)
        Me.pnl_PerCarBrandForm.Controls.Add(Me.Label10)
        Me.pnl_PerCarBrandForm.Controls.Add(Me.Label9)
        Me.pnl_PerCarBrandForm.Controls.Add(Me.btn_PerCarBrandSave)
        Me.pnl_PerCarBrandForm.Controls.Add(Me.txt_PCB_service_fee)
        Me.pnl_PerCarBrandForm.Controls.Add(Me.Label1)
        Me.pnl_PerCarBrandForm.Controls.Add(Me.txt_PCB_service_name)
        Me.pnl_PerCarBrandForm.Controls.Add(Me.Label6)
        Me.pnl_PerCarBrandForm.Controls.Add(Me.txt_PCB_ID)
        Me.pnl_PerCarBrandForm.Controls.Add(Me.Label7)
        Me.pnl_PerCarBrandForm.Enabled = False
        Me.pnl_PerCarBrandForm.Location = New System.Drawing.Point(717, 69)
        Me.pnl_PerCarBrandForm.Name = "pnl_PerCarBrandForm"
        Me.pnl_PerCarBrandForm.Size = New System.Drawing.Size(291, 416)
        Me.pnl_PerCarBrandForm.TabIndex = 243
        '
        'lbl_scb_id
        '
        Me.lbl_scb_id.AutoSize = True
        Me.lbl_scb_id.Location = New System.Drawing.Point(183, 39)
        Me.lbl_scb_id.Name = "lbl_scb_id"
        Me.lbl_scb_id.Size = New System.Drawing.Size(0, 25)
        Me.lbl_scb_id.TabIndex = 256
        Me.lbl_scb_id.Visible = False
        '
        'btn_PerCarBrandCancel
        '
        Me.btn_PerCarBrandCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_PerCarBrandCancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_PerCarBrandCancel.FlatAppearance.BorderSize = 0
        Me.btn_PerCarBrandCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PerCarBrandCancel.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PerCarBrandCancel.ForeColor = System.Drawing.Color.Gold
        Me.btn_PerCarBrandCancel.Location = New System.Drawing.Point(163, 352)
        Me.btn_PerCarBrandCancel.Name = "btn_PerCarBrandCancel"
        Me.btn_PerCarBrandCancel.Size = New System.Drawing.Size(115, 51)
        Me.btn_PerCarBrandCancel.TabIndex = 255
        Me.btn_PerCarBrandCancel.Text = "Cancel"
        Me.btn_PerCarBrandCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_PerCarBrandCancel.UseVisualStyleBackColor = False
        '
        'cbo_carbrand
        '
        Me.cbo_carbrand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbo_carbrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_carbrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_carbrand.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_carbrand.FormattingEnabled = True
        Me.cbo_carbrand.ItemHeight = 20
        Me.cbo_carbrand.Location = New System.Drawing.Point(34, 225)
        Me.cbo_carbrand.MinimumSize = New System.Drawing.Size(244, 0)
        Me.cbo_carbrand.Name = "cbo_carbrand"
        Me.cbo_carbrand.Size = New System.Drawing.Size(244, 28)
        Me.cbo_carbrand.TabIndex = 254
        '
        'txt_adjusted_price
        '
        Me.txt_adjusted_price.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_adjusted_price.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_adjusted_price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_adjusted_price.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_adjusted_price.Location = New System.Drawing.Point(34, 287)
        Me.txt_adjusted_price.Name = "txt_adjusted_price"
        Me.txt_adjusted_price.ReadOnly = True
        Me.txt_adjusted_price.Size = New System.Drawing.Size(244, 26)
        Me.txt_adjusted_price.TabIndex = 253
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 263)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 21)
        Me.Label10.TabIndex = 252
        Me.Label10.Text = "Adjusted Price"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 21)
        Me.Label9.TabIndex = 251
        Me.Label9.Text = "Carbrand"
        '
        'btn_PerCarBrandSave
        '
        Me.btn_PerCarBrandSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_PerCarBrandSave.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_PerCarBrandSave.FlatAppearance.BorderSize = 0
        Me.btn_PerCarBrandSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PerCarBrandSave.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PerCarBrandSave.ForeColor = System.Drawing.Color.Gold
        Me.btn_PerCarBrandSave.Location = New System.Drawing.Point(34, 352)
        Me.btn_PerCarBrandSave.Name = "btn_PerCarBrandSave"
        Me.btn_PerCarBrandSave.Size = New System.Drawing.Size(115, 51)
        Me.btn_PerCarBrandSave.TabIndex = 244
        Me.btn_PerCarBrandSave.Text = "Save"
        Me.btn_PerCarBrandSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_PerCarBrandSave.UseVisualStyleBackColor = False
        '
        'txt_PCB_service_fee
        '
        Me.txt_PCB_service_fee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PCB_service_fee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_PCB_service_fee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_PCB_service_fee.Enabled = False
        Me.txt_PCB_service_fee.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PCB_service_fee.Location = New System.Drawing.Point(34, 163)
        Me.txt_PCB_service_fee.Name = "txt_PCB_service_fee"
        Me.txt_PCB_service_fee.ReadOnly = True
        Me.txt_PCB_service_fee.Size = New System.Drawing.Size(244, 26)
        Me.txt_PCB_service_fee.TabIndex = 250
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = "Service fee"
        '
        'txt_PCB_service_name
        '
        Me.txt_PCB_service_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PCB_service_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_PCB_service_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_PCB_service_name.Enabled = False
        Me.txt_PCB_service_name.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PCB_service_name.Location = New System.Drawing.Point(34, 101)
        Me.txt_PCB_service_name.Name = "txt_PCB_service_name"
        Me.txt_PCB_service_name.ReadOnly = True
        Me.txt_PCB_service_name.Size = New System.Drawing.Size(244, 26)
        Me.txt_PCB_service_name.TabIndex = 248
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 21)
        Me.Label6.TabIndex = 247
        Me.Label6.Text = "Service name"
        '
        'txt_PCB_ID
        '
        Me.txt_PCB_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PCB_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_PCB_ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_PCB_ID.Enabled = False
        Me.txt_PCB_ID.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PCB_ID.Location = New System.Drawing.Point(34, 37)
        Me.txt_PCB_ID.Name = "txt_PCB_ID"
        Me.txt_PCB_ID.ReadOnly = True
        Me.txt_PCB_ID.Size = New System.Drawing.Size(128, 26)
        Me.txt_PCB_ID.TabIndex = 246
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 21)
        Me.Label7.TabIndex = 245
        Me.Label7.Text = "Service ID"
        '
        'btn_PerCarBrandAddNew
        '
        Me.btn_PerCarBrandAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_PerCarBrandAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_PerCarBrandAddNew.FlatAppearance.BorderSize = 0
        Me.btn_PerCarBrandAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PerCarBrandAddNew.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PerCarBrandAddNew.ForeColor = System.Drawing.Color.Gold
        Me.btn_PerCarBrandAddNew.Location = New System.Drawing.Point(698, 12)
        Me.btn_PerCarBrandAddNew.Name = "btn_PerCarBrandAddNew"
        Me.btn_PerCarBrandAddNew.Size = New System.Drawing.Size(102, 38)
        Me.btn_PerCarBrandAddNew.TabIndex = 242
        Me.btn_PerCarBrandAddNew.Text = "Add New"
        Me.btn_PerCarBrandAddNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_PerCarBrandAddNew.UseVisualStyleBackColor = False
        '
        'btn_PerCarBrandUpdate
        '
        Me.btn_PerCarBrandUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_PerCarBrandUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_PerCarBrandUpdate.FlatAppearance.BorderSize = 0
        Me.btn_PerCarBrandUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PerCarBrandUpdate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PerCarBrandUpdate.ForeColor = System.Drawing.Color.Gold
        Me.btn_PerCarBrandUpdate.Location = New System.Drawing.Point(806, 12)
        Me.btn_PerCarBrandUpdate.Name = "btn_PerCarBrandUpdate"
        Me.btn_PerCarBrandUpdate.Size = New System.Drawing.Size(102, 38)
        Me.btn_PerCarBrandUpdate.TabIndex = 241
        Me.btn_PerCarBrandUpdate.Text = "Update"
        Me.btn_PerCarBrandUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_PerCarBrandUpdate.UseVisualStyleBackColor = False
        '
        'btn_PerCarBrandClose
        '
        Me.btn_PerCarBrandClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_PerCarBrandClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_PerCarBrandClose.FlatAppearance.BorderSize = 0
        Me.btn_PerCarBrandClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PerCarBrandClose.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PerCarBrandClose.ForeColor = System.Drawing.Color.Gold
        Me.btn_PerCarBrandClose.Location = New System.Drawing.Point(914, 12)
        Me.btn_PerCarBrandClose.Name = "btn_PerCarBrandClose"
        Me.btn_PerCarBrandClose.Size = New System.Drawing.Size(102, 38)
        Me.btn_PerCarBrandClose.TabIndex = 225
        Me.btn_PerCarBrandClose.Text = "Close"
        Me.btn_PerCarBrandClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_PerCarBrandClose.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(-3, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1015, 38)
        Me.Label8.TabIndex = 224
        Me.Label8.Text = "Price per Carbrand"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lvw_PerCarBrand
        '
        Me.lvw_PerCarBrand.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvw_PerCarBrand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvw_PerCarBrand.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvw_PerCarBrand.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvw_PerCarBrand.FullRowSelect = True
        Me.lvw_PerCarBrand.GridLines = True
        Me.lvw_PerCarBrand.HideSelection = False
        Me.lvw_PerCarBrand.Location = New System.Drawing.Point(28, 67)
        Me.lvw_PerCarBrand.Name = "lvw_PerCarBrand"
        Me.lvw_PerCarBrand.Size = New System.Drawing.Size(694, 404)
        Me.lvw_PerCarBrand.TabIndex = 235
        Me.lvw_PerCarBrand.UseCompatibleStateImageBehavior = False
        Me.lvw_PerCarBrand.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ICB_ID"
        Me.ColumnHeader2.Width = 127
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Carbrand"
        Me.ColumnHeader3.Width = 364
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Adjusted Service fee"
        Me.ColumnHeader4.Width = 154
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 512)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1072, 22)
        Me.StatusStrip1.TabIndex = 241
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel1.Text = "Count"
        '
        'pnlPrint
        '
        Me.pnlPrint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrint.BackColor = System.Drawing.Color.Silver
        Me.pnlPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrint.Controls.Add(Me.crvServices)
        Me.pnlPrint.Controls.Add(Me.btnPrintAttack)
        Me.pnlPrint.Controls.Add(Me.btnCancelPrintattack)
        Me.pnlPrint.Controls.Add(Me.Label20)
        Me.pnlPrint.Location = New System.Drawing.Point(72, 30)
        Me.pnlPrint.Name = "pnlPrint"
        Me.pnlPrint.Size = New System.Drawing.Size(892, 562)
        Me.pnlPrint.TabIndex = 222
        Me.pnlPrint.Visible = False
        '
        'crvServices
        '
        Me.crvServices.ActiveViewIndex = -1
        Me.crvServices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvServices.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvServices.Location = New System.Drawing.Point(-1, 63)
        Me.crvServices.Name = "crvServices"
        Me.crvServices.Size = New System.Drawing.Size(891, 491)
        Me.crvServices.TabIndex = 82
        Me.crvServices.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnPrintAttack
        '
        Me.btnPrintAttack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintAttack.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnPrintAttack.FlatAppearance.BorderSize = 0
        Me.btnPrintAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintAttack.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintAttack.ForeColor = System.Drawing.Color.Gold
        Me.btnPrintAttack.Location = New System.Drawing.Point(654, 0)
        Me.btnPrintAttack.Name = "btnPrintAttack"
        Me.btnPrintAttack.Size = New System.Drawing.Size(115, 50)
        Me.btnPrintAttack.TabIndex = 84
        Me.btnPrintAttack.Text = "&Print"
        Me.btnPrintAttack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintAttack.UseVisualStyleBackColor = False
        '
        'btnCancelPrintattack
        '
        Me.btnCancelPrintattack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelPrintattack.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnCancelPrintattack.FlatAppearance.BorderSize = 0
        Me.btnCancelPrintattack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPrintattack.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPrintattack.ForeColor = System.Drawing.Color.Gold
        Me.btnCancelPrintattack.Location = New System.Drawing.Point(775, 0)
        Me.btnCancelPrintattack.Name = "btnCancelPrintattack"
        Me.btnCancelPrintattack.Size = New System.Drawing.Size(115, 50)
        Me.btnCancelPrintattack.TabIndex = 83
        Me.btnCancelPrintattack.Text = "&Cancel"
        Me.btnCancelPrintattack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelPrintattack.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Gold
        Me.Label20.Location = New System.Drawing.Point(0, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(890, 51)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = " Services"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pnlAddEdit)
        Me.Controls.Add(Me.pnlPrint)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnl_PerCarBrand)
        Me.Name = "Services"
        Me.Size = New System.Drawing.Size(1072, 534)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlAddEdit.ResumeLayout(False)
        Me.pnlAddEdit.PerformLayout()
        Me.pnl_PerCarBrand.ResumeLayout(False)
        Me.pnl_PerCarBrandForm.ResumeLayout(False)
        Me.pnl_PerCarBrandForm.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlPrint.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvServices As System.Windows.Forms.ListView
    Friend WithEvents chSerID As System.Windows.Forms.ColumnHeader
    Friend WithEvents chSerName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents timerAnimate As System.Windows.Forms.Timer
    Friend WithEvents pnlAddEdit As System.Windows.Forms.Panel
    Friend WithEvents txtServiceFee As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtServiceName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtServiceID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddEditClose As System.Windows.Forms.Button
    Friend WithEvents lblAddedit As System.Windows.Forms.Label
    Friend WithEvents btn_PricePerCarBrand As System.Windows.Forms.Button
    Friend WithEvents pnl_PerCarBrand As System.Windows.Forms.Panel
    Friend WithEvents pnl_PerCarBrandForm As System.Windows.Forms.Panel
    Friend WithEvents btn_PerCarBrandCancel As System.Windows.Forms.Button
    Friend WithEvents cbo_carbrand As System.Windows.Forms.ComboBox
    Friend WithEvents txt_adjusted_price As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_PerCarBrandSave As System.Windows.Forms.Button
    Friend WithEvents txt_PCB_service_fee As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_PCB_service_name As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_PCB_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_PerCarBrandAddNew As System.Windows.Forms.Button
    Friend WithEvents btn_PerCarBrandUpdate As System.Windows.Forms.Button
    Friend WithEvents btn_PerCarBrandClose As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lvw_PerCarBrand As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_scb_id As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlPrint As System.Windows.Forms.Panel
    Friend WithEvents crvServices As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnPrintAttack As System.Windows.Forms.Button
    Friend WithEvents btnCancelPrintattack As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label

End Class
