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
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvJobOrderList = New System.Windows.Forms.ListView()
        Me.chJobID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlAddEdit = New System.Windows.Forms.Panel()
        Me.btnSearchService = New System.Windows.Forms.Button()
        Me.btnSearchParts = New System.Windows.Forms.Button()
        Me.txtCarMod = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtFindings = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnViewImg = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lvServices = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lvParts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSearchPlate = New System.Windows.Forms.Button()
        Me.btnBrowseInspect = New System.Windows.Forms.Button()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbxFuel = New System.Windows.Forms.ComboBox()
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
        Me.txtDateReceived = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJobID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddEditClose = New System.Windows.Forms.Button()
        Me.lblAddedit = New System.Windows.Forms.Label()
        Me.timerAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMain.SuspendLayout()
        Me.pnlAddEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(1, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1030, 51)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "  Job order"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Gold
        Me.btnBack.Location = New System.Drawing.Point(930, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(102, 51)
        Me.btnBack.TabIndex = 187
        Me.btnBack.Text = "Back"
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
        Me.pnlMain.Controls.Add(Me.btnPrint)
        Me.pnlMain.Controls.Add(Me.btnUpdate)
        Me.pnlMain.Controls.Add(Me.btnSearch)
        Me.pnlMain.Controls.Add(Me.btnBack)
        Me.pnlMain.Controls.Add(Me.txtSearch)
        Me.pnlMain.Controls.Add(Me.btnAddNew)
        Me.pnlMain.Controls.Add(Me.Label3)
        Me.pnlMain.Controls.Add(Me.Label1)
        Me.pnlMain.Controls.Add(Me.lvJobOrderList)
        Me.pnlMain.Location = New System.Drawing.Point(0, 24)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1030, 670)
        Me.pnlMain.TabIndex = 193
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(829, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(102, 51)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Gold
        Me.btnUpdate.Location = New System.Drawing.Point(728, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 51)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdate.UseVisualStyleBackColor = False
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
        Me.btnSearch.Location = New System.Drawing.Point(299, 87)
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
        Me.txtSearch.Location = New System.Drawing.Point(77, 87)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(222, 26)
        Me.txtSearch.TabIndex = 4
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNew.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddNew.FlatAppearance.BorderSize = 0
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.Gold
        Me.btnAddNew.Location = New System.Drawing.Point(627, 2)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(102, 51)
        Me.btnAddNew.TabIndex = 7
        Me.btnAddNew.Text = "Add new"
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
        Me.lvJobOrderList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chJobID, Me.chName})
        Me.lvJobOrderList.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvJobOrderList.GridLines = True
        Me.lvJobOrderList.Location = New System.Drawing.Point(14, 119)
        Me.lvJobOrderList.Name = "lvJobOrderList"
        Me.lvJobOrderList.Size = New System.Drawing.Size(1001, 536)
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
        'pnlAddEdit
        '
        Me.pnlAddEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlAddEdit.BackColor = System.Drawing.Color.Silver
        Me.pnlAddEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAddEdit.Controls.Add(Me.btnSearchService)
        Me.pnlAddEdit.Controls.Add(Me.btnSearchParts)
        Me.pnlAddEdit.Controls.Add(Me.txtCarMod)
        Me.pnlAddEdit.Controls.Add(Me.Label20)
        Me.pnlAddEdit.Controls.Add(Me.txtRemarks)
        Me.pnlAddEdit.Controls.Add(Me.Label19)
        Me.pnlAddEdit.Controls.Add(Me.txtFindings)
        Me.pnlAddEdit.Controls.Add(Me.Label18)
        Me.pnlAddEdit.Controls.Add(Me.btnViewImg)
        Me.pnlAddEdit.Controls.Add(Me.Label10)
        Me.pnlAddEdit.Controls.Add(Me.lvServices)
        Me.pnlAddEdit.Controls.Add(Me.Label5)
        Me.pnlAddEdit.Controls.Add(Me.lvParts)
        Me.pnlAddEdit.Controls.Add(Me.btnSave)
        Me.pnlAddEdit.Controls.Add(Me.btnSearchPlate)
        Me.pnlAddEdit.Controls.Add(Me.btnBrowseInspect)
        Me.pnlAddEdit.Controls.Add(Me.TextBox14)
        Me.pnlAddEdit.Controls.Add(Me.Label17)
        Me.pnlAddEdit.Controls.Add(Me.cbxFuel)
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
        Me.pnlAddEdit.Controls.Add(Me.txtDateReceived)
        Me.pnlAddEdit.Controls.Add(Me.Label2)
        Me.pnlAddEdit.Controls.Add(Me.txtJobID)
        Me.pnlAddEdit.Controls.Add(Me.Label4)
        Me.pnlAddEdit.Controls.Add(Me.btnAddEditClose)
        Me.pnlAddEdit.Controls.Add(Me.lblAddedit)
        Me.pnlAddEdit.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAddEdit.Location = New System.Drawing.Point(0, 26)
        Me.pnlAddEdit.Name = "pnlAddEdit"
        Me.pnlAddEdit.Size = New System.Drawing.Size(1030, 650)
        Me.pnlAddEdit.TabIndex = 194
        Me.pnlAddEdit.Visible = False
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
        Me.btnSearchService.Location = New System.Drawing.Point(980, 87)
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
        Me.btnSearchParts.Location = New System.Drawing.Point(680, 88)
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
        Me.txtCarMod.Location = New System.Drawing.Point(135, 337)
        Me.txtCarMod.Name = "txtCarMod"
        Me.txtCarMod.Size = New System.Drawing.Size(244, 26)
        Me.txtCarMod.TabIndex = 237
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(24, 340)
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
        Me.txtRemarks.Location = New System.Drawing.Point(442, 471)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(566, 55)
        Me.txtRemarks.TabIndex = 233
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(438, 447)
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
        Me.txtFindings.Location = New System.Drawing.Point(442, 385)
        Me.txtFindings.Multiline = True
        Me.txtFindings.Name = "txtFindings"
        Me.txtFindings.Size = New System.Drawing.Size(566, 52)
        Me.txtFindings.TabIndex = 231
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(438, 361)
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
        Me.btnViewImg.Location = New System.Drawing.Point(351, 595)
        Me.btnViewImg.Name = "btnViewImg"
        Me.btnViewImg.Size = New System.Drawing.Size(28, 26)
        Me.btnViewImg.TabIndex = 228
        Me.btnViewImg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewImg.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(738, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 21)
        Me.Label10.TabIndex = 227
        Me.Label10.Text = "Services"
        '
        'lvServices
        '
        Me.lvServices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvServices.FullRowSelect = True
        Me.lvServices.GridLines = True
        Me.lvServices.Location = New System.Drawing.Point(742, 113)
        Me.lvServices.Name = "lvServices"
        Me.lvServices.Size = New System.Drawing.Size(266, 218)
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
        Me.ColumnHeader4.Width = 262
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(438, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 21)
        Me.Label5.TabIndex = 225
        Me.Label5.Text = "Parts"
        '
        'lvParts
        '
        Me.lvParts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvParts.FullRowSelect = True
        Me.lvParts.GridLines = True
        Me.lvParts.Location = New System.Drawing.Point(442, 113)
        Me.lvParts.Name = "lvParts"
        Me.lvParts.Size = New System.Drawing.Size(266, 218)
        Me.lvParts.TabIndex = 224
        Me.lvParts.UseCompatibleStateImageBehavior = False
        Me.lvParts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 261
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(824, -1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 51)
        Me.btnSave.TabIndex = 223
        Me.btnSave.Text = "Save"
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
        Me.btnSearchPlate.Location = New System.Drawing.Point(351, 145)
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
        Me.btnBrowseInspect.Location = New System.Drawing.Point(260, 563)
        Me.btnBrowseInspect.Name = "btnBrowseInspect"
        Me.btnBrowseInspect.Size = New System.Drawing.Size(119, 26)
        Me.btnBrowseInspect.TabIndex = 221
        Me.btnBrowseInspect.Text = "Browse..."
        Me.btnBrowseInspect.UseVisualStyleBackColor = False
        '
        'TextBox14
        '
        Me.TextBox14.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox14.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(32, 595)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(319, 26)
        Me.TextBox14.TabIndex = 220
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(28, 566)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(166, 21)
        Me.Label17.TabIndex = 219
        Me.Label17.Text = "Upload Inspection form"
        '
        'cbxFuel
        '
        Me.cbxFuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxFuel.FormattingEnabled = True
        Me.cbxFuel.Location = New System.Drawing.Point(135, 497)
        Me.cbxFuel.Name = "cbxFuel"
        Me.cbxFuel.Size = New System.Drawing.Size(244, 29)
        Me.cbxFuel.TabIndex = 218
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 500)
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
        Me.txtEngine.Location = New System.Drawing.Point(135, 465)
        Me.txtEngine.Name = "txtEngine"
        Me.txtEngine.Size = New System.Drawing.Size(244, 26)
        Me.txtEngine.TabIndex = 216
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 463)
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
        Me.txtColor.Location = New System.Drawing.Point(135, 401)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(244, 26)
        Me.txtColor.TabIndex = 214
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 404)
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
        Me.txtMileage.Location = New System.Drawing.Point(135, 433)
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.Size = New System.Drawing.Size(244, 26)
        Me.txtMileage.TabIndex = 212
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 432)
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
        Me.txtVin.Location = New System.Drawing.Point(135, 369)
        Me.txtVin.Name = "txtVin"
        Me.txtVin.Size = New System.Drawing.Size(244, 26)
        Me.txtVin.TabIndex = 210
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 372)
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
        Me.txtPlateno.Location = New System.Drawing.Point(135, 145)
        Me.txtPlateno.Name = "txtPlateno"
        Me.txtPlateno.Size = New System.Drawing.Size(216, 26)
        Me.txtPlateno.TabIndex = 208
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 148)
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
        Me.txtAddress.Location = New System.Drawing.Point(135, 273)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(244, 58)
        Me.txtAddress.TabIndex = 203
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 276)
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
        Me.txtContact.Location = New System.Drawing.Point(135, 209)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(244, 26)
        Me.txtContact.TabIndex = 201
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 210)
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
        Me.txtEmail.Location = New System.Drawing.Point(135, 241)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(244, 26)
        Me.txtEmail.TabIndex = 199
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 244)
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
        Me.txtName.Location = New System.Drawing.Point(135, 177)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(244, 26)
        Me.txtName.TabIndex = 197
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 21)
        Me.Label6.TabIndex = 196
        Me.Label6.Text = "Name"
        '
        'txtDateReceived
        '
        Me.txtDateReceived.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDateReceived.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDateReceived.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateReceived.Location = New System.Drawing.Point(135, 113)
        Me.txtDateReceived.Name = "txtDateReceived"
        Me.txtDateReceived.Size = New System.Drawing.Size(244, 26)
        Me.txtDateReceived.TabIndex = 192
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 116)
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
        Me.txtJobID.Location = New System.Drawing.Point(135, 81)
        Me.txtJobID.Name = "txtJobID"
        Me.txtJobID.ReadOnly = True
        Me.txtJobID.Size = New System.Drawing.Size(244, 26)
        Me.txtJobID.TabIndex = 190
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 21)
        Me.Label4.TabIndex = 189
        Me.Label4.Text = "Job ID"
        '
        'btnAddEditClose
        '
        Me.btnAddEditClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEditClose.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddEditClose.FlatAppearance.BorderSize = 0
        Me.btnAddEditClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEditClose.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEditClose.ForeColor = System.Drawing.Color.Gold
        Me.btnAddEditClose.Location = New System.Drawing.Point(925, -1)
        Me.btnAddEditClose.Name = "btnAddEditClose"
        Me.btnAddEditClose.Size = New System.Drawing.Size(102, 51)
        Me.btnAddEditClose.TabIndex = 188
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
        Me.lblAddedit.Location = New System.Drawing.Point(-1, 0)
        Me.lblAddedit.Name = "lblAddedit"
        Me.lblAddedit.Size = New System.Drawing.Size(1030, 50)
        Me.lblAddedit.TabIndex = 0
        Me.lblAddedit.Text = "Add new Job Order"
        Me.lblAddedit.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'timerAnimate
        '
        Me.timerAnimate.Interval = 1
        '
        'JobOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.pnlAddEdit)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "JobOrder"
        Me.Size = New System.Drawing.Size(1030, 697)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlAddEdit.ResumeLayout(False)
        Me.pnlAddEdit.PerformLayout()
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
    Friend WithEvents txtDateReceived As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxFuel As System.Windows.Forms.ComboBox
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
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnSearchPlate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
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

End Class
