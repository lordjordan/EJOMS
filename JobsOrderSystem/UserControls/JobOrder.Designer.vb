<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JobOrder))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cbxFilter = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvJobOrderList = New System.Windows.Forms.ListView()
        Me.chJobID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlAddEdit = New System.Windows.Forms.Panel()
        Me.btnEditPrice = New System.Windows.Forms.Button()
        Me.btnEditServiceFee = New System.Windows.Forms.Button()
        Me.btnRemoveServices = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnEditQuantity = New System.Windows.Forms.Button()
        Me.btnPrintJO = New System.Windows.Forms.Button()
        Me.chkTax = New System.Windows.Forms.CheckBox()
        Me.txtTaxValue = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtOverallAmount = New System.Windows.Forms.TextBox()
        Me.txtTotalServices = New System.Windows.Forms.TextBox()
        Me.txtTotalOrder = New System.Windows.Forms.TextBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.cbxOrdertype = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblCarId = New System.Windows.Forms.Label()
        Me.txtTransmission = New System.Windows.Forms.TextBox()
        Me.txtFuel = New System.Windows.Forms.TextBox()
        Me.txtMarkup = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dtReceived = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDetailing = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtMechanic = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtElectrician = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lbltotalServices = New System.Windows.Forms.Label()
        Me.lblTotalOrder = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnSearchService = New System.Windows.Forms.Button()
        Me.btnSearchParts = New System.Windows.Forms.Button()
        Me.txtCarMod = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtFindings = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnViewImg = New System.Windows.Forms.Button()
        Me.lvServices = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chJOSFee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMServiceFee = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lvParts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chJOUnitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chJOTotalPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditQuantityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMUnitPrice = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuantityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSearchPlate = New System.Windows.Forms.Button()
        Me.btnBrowseInspect = New System.Windows.Forms.Button()
        Me.txtImage = New System.Windows.Forms.TextBox()
        Me.lblInspectForm = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEngine = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMileage = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtVin = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPlateno = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJobID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddEditClose = New System.Windows.Forms.Button()
        Me.lblAddedit = New System.Windows.Forms.Label()
        Me.timerAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.pnlCar = New System.Windows.Forms.Panel()
        Me.btn_Searchcar = New System.Windows.Forms.Button()
        Me.txtSearchCar = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnSelectCar = New System.Windows.Forms.Button()
        Me.btnCloseBrand = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lvCars = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlQuan = New System.Windows.Forms.Panel()
        Me.txtSelecteditem = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnx = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuanPrice = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pnlVerify = New System.Windows.Forms.Panel()
        Me.btnCancelVeri = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.pnlPrintOrders = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.crvOrders = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnlPrint = New System.Windows.Forms.Panel()
        Me.crvOrderReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnPrintAttack = New System.Windows.Forms.Button()
        Me.btnCancelPrintattack = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlMain.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlAddEdit.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnlCar.SuspendLayout()
        Me.pnlQuan.SuspendLayout()
        Me.pnlVerify.SuspendLayout()
        Me.pnlPrintOrders.SuspendLayout()
        Me.pnlPrint.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(-3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1030, 51)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "  Job order"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Gold
        Me.btnBack.Location = New System.Drawing.Point(923, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(102, 51)
        Me.btnBack.TabIndex = 187
        Me.btnBack.Text = "&Back"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.BackColor = System.Drawing.Color.Silver
        Me.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlMain.Controls.Add(Me.btnVoid)
        Me.pnlMain.Controls.Add(Me.btnUpdate)
        Me.pnlMain.Controls.Add(Me.Label33)
        Me.pnlMain.Controls.Add(Me.cbxFilter)
        Me.pnlMain.Controls.Add(Me.StatusStrip1)
        Me.pnlMain.Controls.Add(Me.btnPrint)
        Me.pnlMain.Controls.Add(Me.btnSearch)
        Me.pnlMain.Controls.Add(Me.btnBack)
        Me.pnlMain.Controls.Add(Me.txtSearch)
        Me.pnlMain.Controls.Add(Me.btnAddNew)
        Me.pnlMain.Controls.Add(Me.Label3)
        Me.pnlMain.Controls.Add(Me.Label1)
        Me.pnlMain.Controls.Add(Me.lvJobOrderList)
        Me.pnlMain.Location = New System.Drawing.Point(3, 24)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1030, 673)
        Me.pnlMain.TabIndex = 193
        '
        'btnVoid
        '
        Me.btnVoid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoid.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnVoid.FlatAppearance.BorderSize = 0
        Me.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoid.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.ForeColor = System.Drawing.Color.Gold
        Me.btnVoid.Location = New System.Drawing.Point(707, 2)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(102, 51)
        Me.btnVoid.TabIndex = 240
        Me.btnVoid.Text = "V&oid"
        Me.btnVoid.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Gold
        Me.btnUpdate.Location = New System.Drawing.Point(599, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 51)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "&View"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(18, 124)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(41, 21)
        Me.Label33.TabIndex = 238
        Me.Label33.Text = "Filter"
        '
        'cbxFilter
        '
        Me.cbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxFilter.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFilter.FormattingEnabled = True
        Me.cbxFilter.Items.AddRange(New Object() {"All", "Paid", "Unpaid", "For Quotation", "Voided"})
        Me.cbxFilter.Location = New System.Drawing.Point(108, 121)
        Me.cbxFilter.Name = "cbxFilter"
        Me.cbxFilter.Size = New System.Drawing.Size(250, 29)
        Me.cbxFilter.TabIndex = 237
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 651)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1030, 22)
        Me.StatusStrip1.TabIndex = 219
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel1.Text = "Count"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(815, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(102, 51)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = False
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
        Me.btnSearch.Location = New System.Drawing.Point(330, 87)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(28, 26)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(108, 87)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(222, 26)
        Me.txtSearch.TabIndex = 4
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnAddNew.FlatAppearance.BorderSize = 0
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.Gold
        Me.btnAddNew.Location = New System.Drawing.Point(491, 2)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(102, 51)
        Me.btnAddNew.TabIndex = 7
        Me.btnAddNew.Text = "&Add new"
        Me.btnAddNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Search"
        '
        'lvJobOrderList
        '
        Me.lvJobOrderList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvJobOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvJobOrderList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chJobID, Me.chName, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.lvJobOrderList.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvJobOrderList.FullRowSelect = True
        Me.lvJobOrderList.GridLines = True
        Me.lvJobOrderList.Location = New System.Drawing.Point(14, 159)
        Me.lvJobOrderList.MultiSelect = False
        Me.lvJobOrderList.Name = "lvJobOrderList"
        Me.lvJobOrderList.Size = New System.Drawing.Size(1001, 480)
        Me.lvJobOrderList.TabIndex = 6
        Me.lvJobOrderList.UseCompatibleStateImageBehavior = False
        Me.lvJobOrderList.View = System.Windows.Forms.View.Details
        '
        'chJobID
        '
        Me.chJobID.Text = "Job ID"
        '
        'chName
        '
        Me.chName.Text = "Name"
        Me.chName.Width = 302
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Car model/ Year"
        Me.ColumnHeader14.Width = 227
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Plate no."
        Me.ColumnHeader15.Width = 131
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Status"
        Me.ColumnHeader16.Width = 279
        '
        'pnlAddEdit
        '
        Me.pnlAddEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlAddEdit.AutoScroll = True
        Me.pnlAddEdit.BackColor = System.Drawing.Color.Silver
        Me.pnlAddEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAddEdit.Controls.Add(Me.btnEditPrice)
        Me.pnlAddEdit.Controls.Add(Me.btnEditServiceFee)
        Me.pnlAddEdit.Controls.Add(Me.btnRemoveServices)
        Me.pnlAddEdit.Controls.Add(Me.btnRemoveItem)
        Me.pnlAddEdit.Controls.Add(Me.btnEditQuantity)
        Me.pnlAddEdit.Controls.Add(Me.btnPrintJO)
        Me.pnlAddEdit.Controls.Add(Me.chkTax)
        Me.pnlAddEdit.Controls.Add(Me.txtTaxValue)
        Me.pnlAddEdit.Controls.Add(Me.Label37)
        Me.pnlAddEdit.Controls.Add(Me.Label17)
        Me.pnlAddEdit.Controls.Add(Me.txtOverallAmount)
        Me.pnlAddEdit.Controls.Add(Me.txtTotalServices)
        Me.pnlAddEdit.Controls.Add(Me.txtTotalOrder)
        Me.pnlAddEdit.Controls.Add(Me.lblTotalAmount)
        Me.pnlAddEdit.Controls.Add(Me.txtStatus)
        Me.pnlAddEdit.Controls.Add(Me.btnPayment)
        Me.pnlAddEdit.Controls.Add(Me.cbxOrdertype)
        Me.pnlAddEdit.Controls.Add(Me.Label34)
        Me.pnlAddEdit.Controls.Add(Me.lblCarId)
        Me.pnlAddEdit.Controls.Add(Me.txtTransmission)
        Me.pnlAddEdit.Controls.Add(Me.txtFuel)
        Me.pnlAddEdit.Controls.Add(Me.txtMarkup)
        Me.pnlAddEdit.Controls.Add(Me.Label32)
        Me.pnlAddEdit.Controls.Add(Me.dtReceived)
        Me.pnlAddEdit.Controls.Add(Me.GroupBox1)
        Me.pnlAddEdit.Controls.Add(Me.Label26)
        Me.pnlAddEdit.Controls.Add(Me.lbltotalServices)
        Me.pnlAddEdit.Controls.Add(Me.lblTotalOrder)
        Me.pnlAddEdit.Controls.Add(Me.txtBrand)
        Me.pnlAddEdit.Controls.Add(Me.Label23)
        Me.pnlAddEdit.Controls.Add(Me.Label22)
        Me.pnlAddEdit.Controls.Add(Me.Label21)
        Me.pnlAddEdit.Controls.Add(Me.btnSearchService)
        Me.pnlAddEdit.Controls.Add(Me.btnSearchParts)
        Me.pnlAddEdit.Controls.Add(Me.txtCarMod)
        Me.pnlAddEdit.Controls.Add(Me.Label20)
        Me.pnlAddEdit.Controls.Add(Me.txtRemarks)
        Me.pnlAddEdit.Controls.Add(Me.Label19)
        Me.pnlAddEdit.Controls.Add(Me.txtFindings)
        Me.pnlAddEdit.Controls.Add(Me.Label18)
        Me.pnlAddEdit.Controls.Add(Me.btnViewImg)
        Me.pnlAddEdit.Controls.Add(Me.lvServices)
        Me.pnlAddEdit.Controls.Add(Me.Label5)
        Me.pnlAddEdit.Controls.Add(Me.lvParts)
        Me.pnlAddEdit.Controls.Add(Me.btnSave)
        Me.pnlAddEdit.Controls.Add(Me.btnSearchPlate)
        Me.pnlAddEdit.Controls.Add(Me.btnBrowseInspect)
        Me.pnlAddEdit.Controls.Add(Me.txtImage)
        Me.pnlAddEdit.Controls.Add(Me.lblInspectForm)
        Me.pnlAddEdit.Controls.Add(Me.Label16)
        Me.pnlAddEdit.Controls.Add(Me.txtEngine)
        Me.pnlAddEdit.Controls.Add(Me.Label15)
        Me.pnlAddEdit.Controls.Add(Me.txtColor)
        Me.pnlAddEdit.Controls.Add(Me.Label14)
        Me.pnlAddEdit.Controls.Add(Me.txtMileage)
        Me.pnlAddEdit.Controls.Add(Me.Label13)
        Me.pnlAddEdit.Controls.Add(Me.txtVin)
        Me.pnlAddEdit.Controls.Add(Me.Label12)
        Me.pnlAddEdit.Controls.Add(Me.txtPlateno)
        Me.pnlAddEdit.Controls.Add(Me.Label11)
        Me.pnlAddEdit.Controls.Add(Me.txtAddress)
        Me.pnlAddEdit.Controls.Add(Me.Label9)
        Me.pnlAddEdit.Controls.Add(Me.txtContact)
        Me.pnlAddEdit.Controls.Add(Me.Label8)
        Me.pnlAddEdit.Controls.Add(Me.txtEmail)
        Me.pnlAddEdit.Controls.Add(Me.Label7)
        Me.pnlAddEdit.Controls.Add(Me.txtName)
        Me.pnlAddEdit.Controls.Add(Me.Label6)
        Me.pnlAddEdit.Controls.Add(Me.Label2)
        Me.pnlAddEdit.Controls.Add(Me.txtJobID)
        Me.pnlAddEdit.Controls.Add(Me.Label4)
        Me.pnlAddEdit.Controls.Add(Me.btnAddEditClose)
        Me.pnlAddEdit.Controls.Add(Me.lblAddedit)
        Me.pnlAddEdit.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAddEdit.Location = New System.Drawing.Point(0, 26)
        Me.pnlAddEdit.Name = "pnlAddEdit"
        Me.pnlAddEdit.Size = New System.Drawing.Size(1030, 0)
        Me.pnlAddEdit.TabIndex = 194
        Me.pnlAddEdit.Visible = False
        '
        'btnEditPrice
        '
        Me.btnEditPrice.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEditPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditPrice.FlatAppearance.BorderSize = 0
        Me.btnEditPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPrice.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditPrice.Image = CType(resources.GetObject("btnEditPrice.Image"), System.Drawing.Image)
        Me.btnEditPrice.Location = New System.Drawing.Point(732, 155)
        Me.btnEditPrice.Name = "btnEditPrice"
        Me.btnEditPrice.Size = New System.Drawing.Size(28, 26)
        Me.btnEditPrice.TabIndex = 277
        Me.btnEditPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditPrice.UseVisualStyleBackColor = False
        Me.btnEditPrice.Visible = False
        '
        'btnEditServiceFee
        '
        Me.btnEditServiceFee.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEditServiceFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditServiceFee.FlatAppearance.BorderSize = 0
        Me.btnEditServiceFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditServiceFee.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditServiceFee.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditServiceFee.Image = Global.JobsOrderSystem.My.Resources.Resources.Editprice1
        Me.btnEditServiceFee.Location = New System.Drawing.Point(766, 418)
        Me.btnEditServiceFee.Name = "btnEditServiceFee"
        Me.btnEditServiceFee.Size = New System.Drawing.Size(28, 26)
        Me.btnEditServiceFee.TabIndex = 276
        Me.btnEditServiceFee.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditServiceFee.UseVisualStyleBackColor = False
        Me.btnEditServiceFee.Visible = False
        '
        'btnRemoveServices
        '
        Me.btnRemoveServices.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRemoveServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemoveServices.FlatAppearance.BorderSize = 0
        Me.btnRemoveServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveServices.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveServices.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRemoveServices.Image = CType(resources.GetObject("btnRemoveServices.Image"), System.Drawing.Image)
        Me.btnRemoveServices.Location = New System.Drawing.Point(800, 418)
        Me.btnRemoveServices.Name = "btnRemoveServices"
        Me.btnRemoveServices.Size = New System.Drawing.Size(28, 26)
        Me.btnRemoveServices.TabIndex = 275
        Me.btnRemoveServices.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveServices.UseVisualStyleBackColor = False
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemoveItem.FlatAppearance.BorderSize = 0
        Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveItem.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRemoveItem.Image = CType(resources.GetObject("btnRemoveItem.Image"), System.Drawing.Image)
        Me.btnRemoveItem.Location = New System.Drawing.Point(800, 155)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(28, 26)
        Me.btnRemoveItem.TabIndex = 274
        Me.btnRemoveItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveItem.UseVisualStyleBackColor = False
        '
        'btnEditQuantity
        '
        Me.btnEditQuantity.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEditQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditQuantity.FlatAppearance.BorderSize = 0
        Me.btnEditQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditQuantity.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditQuantity.Image = Global.JobsOrderSystem.My.Resources.Resources.EditQuan
        Me.btnEditQuantity.Location = New System.Drawing.Point(766, 155)
        Me.btnEditQuantity.Name = "btnEditQuantity"
        Me.btnEditQuantity.Size = New System.Drawing.Size(28, 26)
        Me.btnEditQuantity.TabIndex = 273
        Me.btnEditQuantity.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditQuantity.UseVisualStyleBackColor = False
        '
        'btnPrintJO
        '
        Me.btnPrintJO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintJO.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnPrintJO.FlatAppearance.BorderSize = 0
        Me.btnPrintJO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintJO.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintJO.ForeColor = System.Drawing.Color.Gold
        Me.btnPrintJO.Location = New System.Drawing.Point(690, -1)
        Me.btnPrintJO.Name = "btnPrintJO"
        Me.btnPrintJO.Size = New System.Drawing.Size(102, 51)
        Me.btnPrintJO.TabIndex = 272
        Me.btnPrintJO.Text = "P&rint"
        Me.btnPrintJO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintJO.UseVisualStyleBackColor = False
        '
        'chkTax
        '
        Me.chkTax.AutoSize = True
        Me.chkTax.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTax.Location = New System.Drawing.Point(868, 716)
        Me.chkTax.Name = "chkTax"
        Me.chkTax.Size = New System.Drawing.Size(112, 17)
        Me.chkTax.TabIndex = 271
        Me.chkTax.Text = "With % tax amt.:"
        Me.chkTax.UseVisualStyleBackColor = True
        '
        'txtTaxValue
        '
        Me.txtTaxValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtTaxValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTaxValue.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxValue.Location = New System.Drawing.Point(868, 739)
        Me.txtTaxValue.Name = "txtTaxValue"
        Me.txtTaxValue.ReadOnly = True
        Me.txtTaxValue.Size = New System.Drawing.Size(135, 26)
        Me.txtTaxValue.TabIndex = 270
        Me.txtTaxValue.Text = "0.00"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(407, 418)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(63, 21)
        Me.Label37.TabIndex = 268
        Me.Label37.Text = "Services"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(607, 126)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 21)
        Me.Label17.TabIndex = 267
        Me.Label17.Text = "%"
        '
        'txtOverallAmount
        '
        Me.txtOverallAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtOverallAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOverallAmount.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOverallAmount.Location = New System.Drawing.Point(868, 827)
        Me.txtOverallAmount.Name = "txtOverallAmount"
        Me.txtOverallAmount.ReadOnly = True
        Me.txtOverallAmount.Size = New System.Drawing.Size(135, 26)
        Me.txtOverallAmount.TabIndex = 266
        Me.txtOverallAmount.Text = "0.00"
        '
        'txtTotalServices
        '
        Me.txtTotalServices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtTotalServices.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalServices.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalServices.Location = New System.Drawing.Point(868, 468)
        Me.txtTotalServices.Name = "txtTotalServices"
        Me.txtTotalServices.ReadOnly = True
        Me.txtTotalServices.Size = New System.Drawing.Size(135, 26)
        Me.txtTotalServices.TabIndex = 265
        Me.txtTotalServices.Text = "0.00"
        '
        'txtTotalOrder
        '
        Me.txtTotalOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtTotalOrder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalOrder.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalOrder.Location = New System.Drawing.Point(868, 210)
        Me.txtTotalOrder.Name = "txtTotalOrder"
        Me.txtTotalOrder.ReadOnly = True
        Me.txtTotalOrder.Size = New System.Drawing.Size(135, 26)
        Me.txtTotalOrder.TabIndex = 264
        Me.txtTotalOrder.Text = "0.00"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(864, 803)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(116, 21)
        Me.lblTotalAmount.TabIndex = 263
        Me.lblTotalAmount.Text = "Total Amount:"
        '
        'txtStatus
        '
        Me.txtStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(515, 88)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(244, 26)
        Me.txtStatus.TabIndex = 260
        '
        'btnPayment
        '
        Me.btnPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnPayment.FlatAppearance.BorderSize = 0
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.Gold
        Me.btnPayment.Location = New System.Drawing.Point(582, -2)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(102, 51)
        Me.btnPayment.TabIndex = 259
        Me.btnPayment.Text = "&Payment"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'cbxOrdertype
        '
        Me.cbxOrdertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOrdertype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxOrdertype.FormattingEnabled = True
        Me.cbxOrdertype.Items.AddRange(New Object() {"Quotation", "Order"})
        Me.cbxOrdertype.Location = New System.Drawing.Point(126, 295)
        Me.cbxOrdertype.Name = "cbxOrdertype"
        Me.cbxOrdertype.Size = New System.Drawing.Size(246, 29)
        Me.cbxOrdertype.TabIndex = 258
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(16, 298)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(81, 21)
        Me.Label34.TabIndex = 257
        Me.Label34.Text = "Trans. type"
        '
        'lblCarId
        '
        Me.lblCarId.AutoSize = True
        Me.lblCarId.Location = New System.Drawing.Point(895, 850)
        Me.lblCarId.Name = "lblCarId"
        Me.lblCarId.Size = New System.Drawing.Size(52, 21)
        Me.lblCarId.TabIndex = 256
        Me.lblCarId.Text = "Car ID"
        Me.lblCarId.Visible = False
        '
        'txtTransmission
        '
        Me.txtTransmission.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtTransmission.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTransmission.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransmission.Location = New System.Drawing.Point(126, 747)
        Me.txtTransmission.Name = "txtTransmission"
        Me.txtTransmission.ReadOnly = True
        Me.txtTransmission.Size = New System.Drawing.Size(244, 26)
        Me.txtTransmission.TabIndex = 255
        '
        'txtFuel
        '
        Me.txtFuel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtFuel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFuel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuel.Location = New System.Drawing.Point(126, 715)
        Me.txtFuel.Name = "txtFuel"
        Me.txtFuel.ReadOnly = True
        Me.txtFuel.Size = New System.Drawing.Size(244, 26)
        Me.txtFuel.TabIndex = 254
        '
        'txtMarkup
        '
        Me.txtMarkup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtMarkup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMarkup.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarkup.Location = New System.Drawing.Point(515, 123)
        Me.txtMarkup.Name = "txtMarkup"
        Me.txtMarkup.ReadOnly = True
        Me.txtMarkup.Size = New System.Drawing.Size(92, 26)
        Me.txtMarkup.TabIndex = 253
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(405, 126)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 21)
        Me.Label32.TabIndex = 252
        Me.Label32.Text = "Mark-up value"
        '
        'dtReceived
        '
        Me.dtReceived.Location = New System.Drawing.Point(126, 120)
        Me.dtReceived.Name = "dtReceived"
        Me.dtReceived.Size = New System.Drawing.Size(244, 29)
        Me.dtReceived.TabIndex = 251
        Me.dtReceived.Value = New Date(2016, 1, 4, 10, 7, 47, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDetailing)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txtMechanic)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtElectrician)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 136)
        Me.GroupBox1.TabIndex = 250
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assigned"
        '
        'txtDetailing
        '
        Me.txtDetailing.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDetailing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDetailing.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetailing.Location = New System.Drawing.Point(118, 92)
        Me.txtDetailing.Name = "txtDetailing"
        Me.txtDetailing.Size = New System.Drawing.Size(244, 26)
        Me.txtDetailing.TabIndex = 222
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(9, 91)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(69, 21)
        Me.Label29.TabIndex = 221
        Me.Label29.Text = "Detailing"
        '
        'txtMechanic
        '
        Me.txtMechanic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtMechanic.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMechanic.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMechanic.Location = New System.Drawing.Point(118, 28)
        Me.txtMechanic.Name = "txtMechanic"
        Me.txtMechanic.Size = New System.Drawing.Size(244, 26)
        Me.txtMechanic.TabIndex = 220
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(9, 32)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(74, 21)
        Me.Label30.TabIndex = 219
        Me.Label30.Text = "Mechanic"
        '
        'txtElectrician
        '
        Me.txtElectrician.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtElectrician.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtElectrician.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElectrician.Location = New System.Drawing.Point(118, 60)
        Me.txtElectrician.Name = "txtElectrician"
        Me.txtElectrician.Size = New System.Drawing.Size(244, 26)
        Me.txtElectrician.TabIndex = 218
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(9, 60)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(76, 21)
        Me.Label31.TabIndex = 217
        Me.Label31.Text = "Electrician"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(962, 851)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(0, 21)
        Me.Label26.TabIndex = 249
        '
        'lbltotalServices
        '
        Me.lbltotalServices.AutoSize = True
        Me.lbltotalServices.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalServices.Location = New System.Drawing.Point(864, 444)
        Me.lbltotalServices.Name = "lbltotalServices"
        Me.lbltotalServices.Size = New System.Drawing.Size(114, 21)
        Me.lbltotalServices.TabIndex = 248
        Me.lbltotalServices.Text = "Total services:"
        '
        'lblTotalOrder
        '
        Me.lblTotalOrder.AutoSize = True
        Me.lblTotalOrder.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOrder.Location = New System.Drawing.Point(868, 186)
        Me.lblTotalOrder.Name = "lblTotalOrder"
        Me.lblTotalOrder.Size = New System.Drawing.Size(103, 21)
        Me.lblTotalOrder.TabIndex = 247
        Me.lblTotalOrder.Text = "Total orders:"
        '
        'txtBrand
        '
        Me.txtBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBrand.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrand.Location = New System.Drawing.Point(126, 523)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.ReadOnly = True
        Me.txtBrand.Size = New System.Drawing.Size(244, 26)
        Me.txtBrand.TabIndex = 246
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(16, 526)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 21)
        Me.Label23.TabIndex = 245
        Me.Label23.Text = "Brand"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(405, 91)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 21)
        Me.Label22.TabIndex = 243
        Me.Label22.Text = "Status"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(15, 750)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 21)
        Me.Label21.TabIndex = 240
        Me.Label21.Text = "Transmission"
        '
        'btnSearchService
        '
        Me.btnSearchService.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSearchService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSearchService.FlatAppearance.BorderSize = 0
        Me.btnSearchService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchService.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchService.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearchService.Image = CType(resources.GetObject("btnSearchService.Image"), System.Drawing.Image)
        Me.btnSearchService.Location = New System.Drawing.Point(834, 418)
        Me.btnSearchService.Name = "btnSearchService"
        Me.btnSearchService.Size = New System.Drawing.Size(28, 26)
        Me.btnSearchService.TabIndex = 239
        Me.btnSearchService.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearchService.UseVisualStyleBackColor = False
        '
        'btnSearchParts
        '
        Me.btnSearchParts.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSearchParts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSearchParts.FlatAppearance.BorderSize = 0
        Me.btnSearchParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchParts.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchParts.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearchParts.Image = CType(resources.GetObject("btnSearchParts.Image"), System.Drawing.Image)
        Me.btnSearchParts.Location = New System.Drawing.Point(834, 155)
        Me.btnSearchParts.Name = "btnSearchParts"
        Me.btnSearchParts.Size = New System.Drawing.Size(28, 26)
        Me.btnSearchParts.TabIndex = 238
        Me.btnSearchParts.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearchParts.UseVisualStyleBackColor = False
        '
        'txtCarMod
        '
        Me.txtCarMod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCarMod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCarMod.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarMod.Location = New System.Drawing.Point(126, 555)
        Me.txtCarMod.Name = "txtCarMod"
        Me.txtCarMod.ReadOnly = True
        Me.txtCarMod.Size = New System.Drawing.Size(244, 26)
        Me.txtCarMod.TabIndex = 237
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 558)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(113, 21)
        Me.Label20.TabIndex = 236
        Me.Label20.Text = "Car model/Year"
        '
        'txtRemarks
        '
        Me.txtRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(409, 796)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(453, 58)
        Me.txtRemarks.TabIndex = 233
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(405, 772)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 21)
        Me.Label19.TabIndex = 232
        Me.Label19.Text = "Remarks:"
        '
        'txtFindings
        '
        Me.txtFindings.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtFindings.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFindings.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFindings.Location = New System.Drawing.Point(410, 708)
        Me.txtFindings.Multiline = True
        Me.txtFindings.Name = "txtFindings"
        Me.txtFindings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFindings.Size = New System.Drawing.Size(452, 58)
        Me.txtFindings.TabIndex = 231
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(407, 684)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(200, 21)
        Me.Label18.TabIndex = 230
        Me.Label18.Text = "Findings/Recommendations:"
        '
        'btnViewImg
        '
        Me.btnViewImg.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnViewImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnViewImg.FlatAppearance.BorderSize = 0
        Me.btnViewImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewImg.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewImg.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnViewImg.Image = Global.JobsOrderSystem.My.Resources.Resources.View
        Me.btnViewImg.Location = New System.Drawing.Point(343, 827)
        Me.btnViewImg.Name = "btnViewImg"
        Me.btnViewImg.Size = New System.Drawing.Size(28, 26)
        Me.btnViewImg.TabIndex = 228
        Me.btnViewImg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnViewImg, "View image")
        Me.btnViewImg.UseVisualStyleBackColor = False
        '
        'lvServices
        '
        Me.lvServices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.chJOSFee})
        Me.lvServices.ContextMenuStrip = Me.ContextMenuStrip2
        Me.lvServices.FullRowSelect = True
        Me.lvServices.GridLines = True
        Me.lvServices.Location = New System.Drawing.Point(411, 444)
        Me.lvServices.MultiSelect = False
        Me.lvServices.Name = "lvServices"
        Me.lvServices.Size = New System.Drawing.Size(451, 225)
        Me.lvServices.TabIndex = 226
        Me.lvServices.UseCompatibleStateImageBehavior = False
        Me.lvServices.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ServiceID"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Service"
        Me.ColumnHeader4.Width = 220
        '
        'chJOSFee
        '
        Me.chJOSFee.Text = "Service fee"
        Me.chJOSFee.Width = 242
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMServiceFee, Me.ToolStripMenuItem4})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(153, 48)
        '
        'TSMServiceFee
        '
        Me.TSMServiceFee.Name = "TSMServiceFee"
        Me.TSMServiceFee.Size = New System.Drawing.Size(152, 22)
        Me.TSMServiceFee.Text = "Edit service fee"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem4.Text = "Remove service"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(405, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 21)
        Me.Label5.TabIndex = 225
        Me.Label5.Text = "Items"
        '
        'lvParts
        '
        Me.lvParts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader2, Me.chJOUnitPrice, Me.chJOTotalPrice})
        Me.lvParts.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvParts.FullRowSelect = True
        Me.lvParts.GridLines = True
        Me.lvParts.Location = New System.Drawing.Point(410, 180)
        Me.lvParts.MultiSelect = False
        Me.lvParts.Name = "lvParts"
        Me.lvParts.Size = New System.Drawing.Size(452, 225)
        Me.lvParts.TabIndex = 224
        Me.lvParts.UseCompatibleStateImageBehavior = False
        Me.lvParts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Qty"
        Me.ColumnHeader5.Width = 54
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 161
        '
        'chJOUnitPrice
        '
        Me.chJOUnitPrice.Text = "Unit price"
        Me.chJOUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chJOUnitPrice.Width = 106
        '
        'chJOTotalPrice
        '
        Me.chJOTotalPrice.Text = "Total price"
        Me.chJOTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chJOTotalPrice.Width = 126
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditQuantityToolStripMenuItem, Me.RemoveItemToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(141, 48)
        '
        'EditQuantityToolStripMenuItem
        '
        Me.EditQuantityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMUnitPrice, Me.QuantityToolStripMenuItem})
        Me.EditQuantityToolStripMenuItem.Name = "EditQuantityToolStripMenuItem"
        Me.EditQuantityToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EditQuantityToolStripMenuItem.Text = "Edit"
        '
        'TSMUnitPrice
        '
        Me.TSMUnitPrice.Name = "TSMUnitPrice"
        Me.TSMUnitPrice.Size = New System.Drawing.Size(121, 22)
        Me.TSMUnitPrice.Text = "Unit Price"
        '
        'QuantityToolStripMenuItem
        '
        Me.QuantityToolStripMenuItem.Name = "QuantityToolStripMenuItem"
        Me.QuantityToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.QuantityToolStripMenuItem.Text = "Quantity"
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.RemoveItemToolStripMenuItem.Text = "Remove item"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(798, -1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 51)
        Me.btnSave.TabIndex = 223
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnSearchPlate
        '
        Me.btnSearchPlate.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSearchPlate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSearchPlate.FlatAppearance.BorderSize = 0
        Me.btnSearchPlate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchPlate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPlate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearchPlate.Image = CType(resources.GetObject("btnSearchPlate.Image"), System.Drawing.Image)
        Me.btnSearchPlate.Location = New System.Drawing.Point(342, 330)
        Me.btnSearchPlate.Name = "btnSearchPlate"
        Me.btnSearchPlate.Size = New System.Drawing.Size(28, 26)
        Me.btnSearchPlate.TabIndex = 222
        Me.btnSearchPlate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearchPlate.UseVisualStyleBackColor = False
        '
        'btnBrowseInspect
        '
        Me.btnBrowseInspect.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBrowseInspect.FlatAppearance.BorderSize = 0
        Me.btnBrowseInspect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseInspect.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseInspect.ForeColor = System.Drawing.Color.Gold
        Me.btnBrowseInspect.Location = New System.Drawing.Point(252, 795)
        Me.btnBrowseInspect.Name = "btnBrowseInspect"
        Me.btnBrowseInspect.Size = New System.Drawing.Size(119, 26)
        Me.btnBrowseInspect.TabIndex = 221
        Me.btnBrowseInspect.Text = "Browse..."
        Me.btnBrowseInspect.UseVisualStyleBackColor = False
        '
        'txtImage
        '
        Me.txtImage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtImage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImage.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImage.Location = New System.Drawing.Point(19, 827)
        Me.txtImage.Name = "txtImage"
        Me.txtImage.ReadOnly = True
        Me.txtImage.Size = New System.Drawing.Size(324, 26)
        Me.txtImage.TabIndex = 220
        '
        'lblInspectForm
        '
        Me.lblInspectForm.AutoSize = True
        Me.lblInspectForm.Location = New System.Drawing.Point(15, 798)
        Me.lblInspectForm.Name = "lblInspectForm"
        Me.lblInspectForm.Size = New System.Drawing.Size(166, 21)
        Me.lblInspectForm.TabIndex = 219
        Me.lblInspectForm.Text = "Upload Inspection form"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 718)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 21)
        Me.Label16.TabIndex = 217
        Me.Label16.Text = "Fuel"
        '
        'txtEngine
        '
        Me.txtEngine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtEngine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEngine.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEngine.Location = New System.Drawing.Point(126, 683)
        Me.txtEngine.Name = "txtEngine"
        Me.txtEngine.ReadOnly = True
        Me.txtEngine.Size = New System.Drawing.Size(244, 26)
        Me.txtEngine.TabIndex = 216
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 681)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 21)
        Me.Label15.TabIndex = 215
        Me.Label15.Text = "Engine no."
        '
        'txtColor
        '
        Me.txtColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtColor.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(126, 619)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.ReadOnly = True
        Me.txtColor.Size = New System.Drawing.Size(244, 26)
        Me.txtColor.TabIndex = 214
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 622)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 21)
        Me.Label14.TabIndex = 213
        Me.Label14.Text = "Color"
        '
        'txtMileage
        '
        Me.txtMileage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtMileage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMileage.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMileage.Location = New System.Drawing.Point(126, 651)
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.ReadOnly = True
        Me.txtMileage.Size = New System.Drawing.Size(244, 26)
        Me.txtMileage.TabIndex = 212
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 650)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 21)
        Me.Label13.TabIndex = 211
        Me.Label13.Text = "Mileage"
        '
        'txtVin
        '
        Me.txtVin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtVin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVin.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVin.Location = New System.Drawing.Point(126, 587)
        Me.txtVin.Name = "txtVin"
        Me.txtVin.ReadOnly = True
        Me.txtVin.Size = New System.Drawing.Size(244, 26)
        Me.txtVin.TabIndex = 210
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 590)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 21)
        Me.Label12.TabIndex = 209
        Me.Label12.Text = "Vin/Chassis no."
        '
        'txtPlateno
        '
        Me.txtPlateno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPlateno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlateno.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlateno.Location = New System.Drawing.Point(126, 330)
        Me.txtPlateno.Name = "txtPlateno"
        Me.txtPlateno.ReadOnly = True
        Me.txtPlateno.Size = New System.Drawing.Size(216, 26)
        Me.txtPlateno.TabIndex = 208
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 333)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 21)
        Me.Label11.TabIndex = 207
        Me.Label11.Text = "Plate no."
        '
        'txtAddress
        '
        Me.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(126, 458)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(244, 58)
        Me.txtAddress.TabIndex = 203
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 461)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 21)
        Me.Label9.TabIndex = 202
        Me.Label9.Text = "Address:"
        '
        'txtContact
        '
        Me.txtContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContact.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(126, 394)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(244, 26)
        Me.txtContact.TabIndex = 201
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 395)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 21)
        Me.Label8.TabIndex = 200
        Me.Label8.Text = "Contact no."
        '
        'txtEmail
        '
        Me.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(126, 426)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(244, 26)
        Me.txtEmail.TabIndex = 199
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 429)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 21)
        Me.Label7.TabIndex = 198
        Me.Label7.Text = "Email"
        '
        'txtName
        '
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(126, 362)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(244, 26)
        Me.txtName.TabIndex = 197
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 21)
        Me.Label6.TabIndex = 196
        Me.Label6.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Date received"
        '
        'txtJobID
        '
        Me.txtJobID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtJobID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJobID.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobID.Location = New System.Drawing.Point(126, 88)
        Me.txtJobID.Name = "txtJobID"
        Me.txtJobID.ReadOnly = True
        Me.txtJobID.Size = New System.Drawing.Size(244, 26)
        Me.txtJobID.TabIndex = 190
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 21)
        Me.Label4.TabIndex = 189
        Me.Label4.Text = "Job ID"
        '
        'btnAddEditClose
        '
        Me.btnAddEditClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEditClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnAddEditClose.FlatAppearance.BorderSize = 0
        Me.btnAddEditClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEditClose.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEditClose.ForeColor = System.Drawing.Color.Gold
        Me.btnAddEditClose.Location = New System.Drawing.Point(906, -1)
        Me.btnAddEditClose.Name = "btnAddEditClose"
        Me.btnAddEditClose.Size = New System.Drawing.Size(102, 51)
        Me.btnAddEditClose.TabIndex = 188
        Me.btnAddEditClose.Text = "&Close"
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
        Me.lblAddedit.Location = New System.Drawing.Point(-1, -1)
        Me.lblAddedit.Name = "lblAddedit"
        Me.lblAddedit.Size = New System.Drawing.Size(1046, 51)
        Me.lblAddedit.TabIndex = 0
        Me.lblAddedit.Text = "Add new Job Order"
        Me.lblAddedit.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'timerAnimate
        '
        Me.timerAnimate.Interval = 1
        '
        'pnlCar
        '
        Me.pnlCar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCar.Controls.Add(Me.btn_Searchcar)
        Me.pnlCar.Controls.Add(Me.txtSearchCar)
        Me.pnlCar.Controls.Add(Me.Label27)
        Me.pnlCar.Controls.Add(Me.btnSelectCar)
        Me.pnlCar.Controls.Add(Me.btnCloseBrand)
        Me.pnlCar.Controls.Add(Me.Label28)
        Me.pnlCar.Controls.Add(Me.lvCars)
        Me.pnlCar.Location = New System.Drawing.Point(111, 25)
        Me.pnlCar.Name = "pnlCar"
        Me.pnlCar.Size = New System.Drawing.Size(828, 545)
        Me.pnlCar.TabIndex = 220
        Me.pnlCar.Visible = False
        '
        'btn_Searchcar
        '
        Me.btn_Searchcar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_Searchcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Searchcar.FlatAppearance.BorderSize = 0
        Me.btn_Searchcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Searchcar.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Searchcar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Searchcar.Image = CType(resources.GetObject("btn_Searchcar.Image"), System.Drawing.Image)
        Me.btn_Searchcar.Location = New System.Drawing.Point(288, 83)
        Me.btn_Searchcar.Name = "btn_Searchcar"
        Me.btn_Searchcar.Size = New System.Drawing.Size(28, 26)
        Me.btn_Searchcar.TabIndex = 230
        Me.btn_Searchcar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Searchcar.UseVisualStyleBackColor = False
        '
        'txtSearchCar
        '
        Me.txtSearchCar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearchCar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchCar.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCar.Location = New System.Drawing.Point(65, 83)
        Me.txtSearchCar.Name = "txtSearchCar"
        Me.txtSearchCar.Size = New System.Drawing.Size(222, 26)
        Me.txtSearchCar.TabIndex = 229
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(13, 86)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(55, 21)
        Me.Label27.TabIndex = 228
        Me.Label27.Text = "Search"
        '
        'btnSelectCar
        '
        Me.btnSelectCar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectCar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSelectCar.FlatAppearance.BorderSize = 0
        Me.btnSelectCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectCar.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectCar.ForeColor = System.Drawing.Color.Gold
        Me.btnSelectCar.Location = New System.Drawing.Point(618, -1)
        Me.btnSelectCar.Name = "btnSelectCar"
        Me.btnSelectCar.Size = New System.Drawing.Size(102, 51)
        Me.btnSelectCar.TabIndex = 227
        Me.btnSelectCar.Text = "Select"
        Me.btnSelectCar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSelectCar.UseVisualStyleBackColor = False
        '
        'btnCloseBrand
        '
        Me.btnCloseBrand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnCloseBrand.FlatAppearance.BorderSize = 0
        Me.btnCloseBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseBrand.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseBrand.ForeColor = System.Drawing.Color.Gold
        Me.btnCloseBrand.Location = New System.Drawing.Point(723, 0)
        Me.btnCloseBrand.Name = "btnCloseBrand"
        Me.btnCloseBrand.Size = New System.Drawing.Size(102, 51)
        Me.btnCloseBrand.TabIndex = 226
        Me.btnCloseBrand.Text = "Close"
        Me.btnCloseBrand.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCloseBrand.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Gold
        Me.Label28.Location = New System.Drawing.Point(0, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(828, 51)
        Me.Label28.TabIndex = 225
        Me.Label28.Text = "Select a car"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lvCars
        '
        Me.lvCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader13, Me.ColumnHeader12})
        Me.lvCars.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCars.FullRowSelect = True
        Me.lvCars.GridLines = True
        Me.lvCars.Location = New System.Drawing.Point(15, 117)
        Me.lvCars.Name = "lvCars"
        Me.lvCars.Size = New System.Drawing.Size(796, 407)
        Me.lvCars.TabIndex = 0
        Me.lvCars.UseCompatibleStateImageBehavior = False
        Me.lvCars.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Car id"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Car owner"
        Me.ColumnHeader11.Width = 322
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Car Model/Year"
        Me.ColumnHeader13.Width = 255
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Plate no."
        Me.ColumnHeader12.Width = 203
        '
        'pnlQuan
        '
        Me.pnlQuan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlQuan.Controls.Add(Me.txtSelecteditem)
        Me.pnlQuan.Controls.Add(Me.Label35)
        Me.pnlQuan.Controls.Add(Me.btnEdit)
        Me.pnlQuan.Controls.Add(Me.btnx)
        Me.pnlQuan.Controls.Add(Me.txtQuantity)
        Me.pnlQuan.Controls.Add(Me.lblQuanPrice)
        Me.pnlQuan.Location = New System.Drawing.Point(432, 192)
        Me.pnlQuan.Name = "pnlQuan"
        Me.pnlQuan.Size = New System.Drawing.Size(270, 176)
        Me.pnlQuan.TabIndex = 231
        Me.pnlQuan.Visible = False
        '
        'txtSelecteditem
        '
        Me.txtSelecteditem.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelecteditem.Location = New System.Drawing.Point(20, 68)
        Me.txtSelecteditem.Name = "txtSelecteditem"
        Me.txtSelecteditem.ReadOnly = True
        Me.txtSelecteditem.Size = New System.Drawing.Size(231, 29)
        Me.txtSelecteditem.TabIndex = 245
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(16, 44)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(103, 21)
        Me.Label35.TabIndex = 244
        Me.Label35.Text = "Selected item:"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Gold
        Me.btnEdit.Location = New System.Drawing.Point(189, 135)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(62, 30)
        Me.btnEdit.TabIndex = 243
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnx
        '
        Me.btnx.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnx.FlatAppearance.BorderSize = 0
        Me.btnx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnx.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnx.ForeColor = System.Drawing.Color.Gold
        Me.btnx.Location = New System.Drawing.Point(232, -1)
        Me.btnx.Name = "btnx"
        Me.btnx.Size = New System.Drawing.Size(35, 30)
        Me.btnx.TabIndex = 242
        Me.btnx.Text = "x"
        Me.btnx.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(20, 103)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(231, 26)
        Me.txtQuantity.TabIndex = 222
        '
        'lblQuanPrice
        '
        Me.lblQuanPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuanPrice.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblQuanPrice.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuanPrice.ForeColor = System.Drawing.Color.Gold
        Me.lblQuanPrice.Location = New System.Drawing.Point(0, 0)
        Me.lblQuanPrice.Name = "lblQuanPrice"
        Me.lblQuanPrice.Size = New System.Drawing.Size(269, 29)
        Me.lblQuanPrice.TabIndex = 219
        Me.lblQuanPrice.Text = "Enter Quantity"
        Me.lblQuanPrice.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Image file | *.jpeg;*.jpg"
        '
        'pnlVerify
        '
        Me.pnlVerify.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlVerify.Controls.Add(Me.btnCancelVeri)
        Me.pnlVerify.Controls.Add(Me.btn_ok)
        Me.pnlVerify.Controls.Add(Me.txtPassword)
        Me.pnlVerify.Controls.Add(Me.txtUsername)
        Me.pnlVerify.Controls.Add(Me.Label24)
        Me.pnlVerify.Location = New System.Drawing.Point(360, 237)
        Me.pnlVerify.Name = "pnlVerify"
        Me.pnlVerify.Size = New System.Drawing.Size(402, 178)
        Me.pnlVerify.TabIndex = 232
        Me.pnlVerify.Visible = False
        '
        'btnCancelVeri
        '
        Me.btnCancelVeri.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCancelVeri.FlatAppearance.BorderSize = 0
        Me.btnCancelVeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelVeri.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelVeri.ForeColor = System.Drawing.Color.Gold
        Me.btnCancelVeri.Location = New System.Drawing.Point(297, 130)
        Me.btnCancelVeri.Name = "btnCancelVeri"
        Me.btnCancelVeri.Size = New System.Drawing.Size(75, 37)
        Me.btnCancelVeri.TabIndex = 191
        Me.btnCancelVeri.Text = "C&ancel"
        Me.btnCancelVeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelVeri.UseVisualStyleBackColor = False
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.Gold
        Me.btn_ok.Location = New System.Drawing.Point(216, 130)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 37)
        Me.btn_ok.TabIndex = 190
        Me.btn_ok.Text = "&Ok"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(31, 95)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(341, 29)
        Me.txtPassword.TabIndex = 189
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(31, 63)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(341, 29)
        Me.txtUsername.TabIndex = 188
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Gold
        Me.Label24.Location = New System.Drawing.Point(1, 12)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(416, 27)
        Me.Label24.TabIndex = 187
        Me.Label24.Text = "Verify superadmin/ admin account"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlPrintOrders
        '
        Me.pnlPrintOrders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrintOrders.BackColor = System.Drawing.Color.Silver
        Me.pnlPrintOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrintOrders.Controls.Add(Me.Button3)
        Me.pnlPrintOrders.Controls.Add(Me.Label25)
        Me.pnlPrintOrders.Controls.Add(Me.crvOrders)
        Me.pnlPrintOrders.Controls.Add(Me.Button1)
        Me.pnlPrintOrders.Controls.Add(Me.Button2)
        Me.pnlPrintOrders.Location = New System.Drawing.Point(101, 23)
        Me.pnlPrintOrders.Name = "pnlPrintOrders"
        Me.pnlPrintOrders.Size = New System.Drawing.Size(793, 659)
        Me.pnlPrintOrders.TabIndex = 234
        Me.pnlPrintOrders.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Gold
        Me.Button3.Location = New System.Drawing.Point(686, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 51)
        Me.Button3.TabIndex = 188
        Me.Button3.Text = "&Back"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Light", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Gold
        Me.Label25.Location = New System.Drawing.Point(0, 1)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(791, 52)
        Me.Label25.TabIndex = 85
        Me.Label25.Text = "Jobs Order Report"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'crvOrders
        '
        Me.crvOrders.ActiveViewIndex = -1
        Me.crvOrders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvOrders.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvOrders.Location = New System.Drawing.Point(-1, 63)
        Me.crvOrders.Name = "crvOrders"
        Me.crvOrders.Size = New System.Drawing.Size(792, 591)
        Me.crvOrders.TabIndex = 82
        Me.crvOrders.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(555, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 51)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "&Print"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gold
        Me.Button2.Location = New System.Drawing.Point(676, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 50)
        Me.Button2.TabIndex = 83
        Me.Button2.Text = "&Cancel"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'pnlPrint
        '
        Me.pnlPrint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrint.BackColor = System.Drawing.Color.Silver
        Me.pnlPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrint.Controls.Add(Me.crvOrderReport)
        Me.pnlPrint.Controls.Add(Me.btnPrintAttack)
        Me.pnlPrint.Controls.Add(Me.btnCancelPrintattack)
        Me.pnlPrint.Controls.Add(Me.Label10)
        Me.pnlPrint.Location = New System.Drawing.Point(101, 24)
        Me.pnlPrint.Name = "pnlPrint"
        Me.pnlPrint.Size = New System.Drawing.Size(793, 648)
        Me.pnlPrint.TabIndex = 234
        Me.pnlPrint.Visible = False
        '
        'crvOrderReport
        '
        Me.crvOrderReport.ActiveViewIndex = -1
        Me.crvOrderReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvOrderReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvOrderReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvOrderReport.Location = New System.Drawing.Point(-1, 63)
        Me.crvOrderReport.Name = "crvOrderReport"
        Me.crvOrderReport.Size = New System.Drawing.Size(792, 559)
        Me.crvOrderReport.TabIndex = 82
        Me.crvOrderReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnPrintAttack
        '
        Me.btnPrintAttack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintAttack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPrintAttack.FlatAppearance.BorderSize = 0
        Me.btnPrintAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintAttack.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintAttack.ForeColor = System.Drawing.Color.Gold
        Me.btnPrintAttack.Location = New System.Drawing.Point(555, 4)
        Me.btnPrintAttack.Name = "btnPrintAttack"
        Me.btnPrintAttack.Size = New System.Drawing.Size(115, 48)
        Me.btnPrintAttack.TabIndex = 84
        Me.btnPrintAttack.Text = "&Print"
        Me.btnPrintAttack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintAttack.UseVisualStyleBackColor = False
        '
        'btnCancelPrintattack
        '
        Me.btnCancelPrintattack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelPrintattack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCancelPrintattack.FlatAppearance.BorderSize = 0
        Me.btnCancelPrintattack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPrintattack.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPrintattack.ForeColor = System.Drawing.Color.Gold
        Me.btnCancelPrintattack.Location = New System.Drawing.Point(676, 4)
        Me.btnCancelPrintattack.Name = "btnCancelPrintattack"
        Me.btnCancelPrintattack.Size = New System.Drawing.Size(115, 48)
        Me.btnCancelPrintattack.TabIndex = 83
        Me.btnCancelPrintattack.Text = "&Cancel"
        Me.btnCancelPrintattack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelPrintattack.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(0, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(791, 52)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Jobs Order Report"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'JobOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.pnlAddEdit)
        Me.Controls.Add(Me.pnlVerify)
        Me.Controls.Add(Me.pnlQuan)
        Me.Controls.Add(Me.pnlPrint)
        Me.Controls.Add(Me.pnlCar)
        Me.Controls.Add(Me.pnlPrintOrders)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "JobOrder"
        Me.Size = New System.Drawing.Size(1030, 697)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlAddEdit.ResumeLayout(False)
        Me.pnlAddEdit.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnlCar.ResumeLayout(False)
        Me.pnlCar.PerformLayout()
        Me.pnlQuan.ResumeLayout(False)
        Me.pnlQuan.PerformLayout()
        Me.pnlVerify.ResumeLayout(False)
        Me.pnlVerify.PerformLayout()
        Me.pnlPrintOrders.ResumeLayout(False)
        Me.pnlPrint.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvJobOrderList As System.Windows.Forms.ListView
    Friend WithEvents chJobID As System.Windows.Forms.ColumnHeader
    Friend WithEvents chName As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents pnlAddEdit As System.Windows.Forms.Panel
    Friend WithEvents timerAnimate As System.Windows.Forms.Timer
    Friend WithEvents btnAddEditClose As System.Windows.Forms.Button
    Friend WithEvents lblAddedit As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtJobID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtEngine As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMileage As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtVin As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPlateno As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseInspect As System.Windows.Forms.Button
    Friend WithEvents txtImage As System.Windows.Forms.TextBox
    Friend WithEvents lblInspectForm As System.Windows.Forms.Label
    Friend WithEvents btnSearchPlate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lvServices As System.Windows.Forms.ListView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lvParts As System.Windows.Forms.ListView
    Friend WithEvents btnViewImg As System.Windows.Forms.Button
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtFindings As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtCarMod As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnSearchService As System.Windows.Forms.Button
    Friend WithEvents btnSearchParts As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtBrand As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents chJOSFee As System.Windows.Forms.ColumnHeader
    Friend WithEvents chJOUnitPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents chJOTotalPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lbltotalServices As System.Windows.Forms.Label
    Friend WithEvents lblTotalOrder As System.Windows.Forms.Label
    Friend WithEvents pnlCar As System.Windows.Forms.Panel
    Friend WithEvents btn_Searchcar As System.Windows.Forms.Button
    Friend WithEvents txtSearchCar As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btnSelectCar As System.Windows.Forms.Button
    Friend WithEvents btnCloseBrand As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lvCars As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDetailing As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtMechanic As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtElectrician As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents dtReceived As System.Windows.Forms.DateTimePicker
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtMarkup As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtTransmission As System.Windows.Forms.TextBox
    Friend WithEvents txtFuel As System.Windows.Forms.TextBox
    Friend WithEvents lblCarId As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cbxFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents cbxOrdertype As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditQuantityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMUnitPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuantityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlQuan As System.Windows.Forms.Panel
    Friend WithEvents txtSelecteditem As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnx As System.Windows.Forms.Button
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lblQuanPrice As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TSMServiceFee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents txtOverallAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalServices As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalOrder As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents chkTax As System.Windows.Forms.CheckBox
    Friend WithEvents txtTaxValue As System.Windows.Forms.TextBox
    Friend WithEvents btnPrintJO As System.Windows.Forms.Button
    Friend WithEvents btnEditQuantity As System.Windows.Forms.Button
    Friend WithEvents btnEditServiceFee As System.Windows.Forms.Button
    Friend WithEvents btnRemoveServices As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents btnEditPrice As System.Windows.Forms.Button
    Friend WithEvents pnlVerify As System.Windows.Forms.Panel
    Friend WithEvents btnCancelVeri As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnVoid As System.Windows.Forms.Button
    Friend WithEvents pnlPrintOrders As System.Windows.Forms.Panel
    Friend WithEvents crvOrders As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents pnlPrint As System.Windows.Forms.Panel
    Friend WithEvents crvOrderReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnPrintAttack As System.Windows.Forms.Button
    Friend WithEvents btnCancelPrintattack As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
