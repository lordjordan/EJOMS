<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cars
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cars))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvCars = New System.Windows.Forms.ListView()
        Me.chCBID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlAddEdit = New System.Windows.Forms.Panel()
        Me.lblbrand_id = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.cbxTrans = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnBrowseBrand = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxFuel = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEngine = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMileage = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPlate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCarmodel = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCarID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddEditClose = New System.Windows.Forms.Button()
        Me.lblAddedit = New System.Windows.Forms.Label()
        Me.timerAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlBrand = New System.Windows.Forms.Panel()
        Me.btn_SearchBrand = New System.Windows.Forms.Button()
        Me.txtSearchBrand = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnSelectBrand = New System.Windows.Forms.Button()
        Me.btnCloseBrand = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lvCarBrands = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlMain.SuspendLayout()
        Me.pnlAddEdit.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlBrand.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(0, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1001, 51)
        Me.Label1.TabIndex = 195
        Me.Label1.Text = "  Cars"
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNew.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddNew.FlatAppearance.BorderSize = 0
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.Gold
        Me.btnAddNew.Location = New System.Drawing.Point(599, 1)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(102, 51)
        Me.btnAddNew.TabIndex = 211
        Me.btnAddNew.Text = "Add new"
        Me.btnAddNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(801, 1)
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
        Me.btnUpdate.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Gold
        Me.btnUpdate.Location = New System.Drawing.Point(700, 1)
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
        Me.txtSearch.Location = New System.Drawing.Point(61, 80)
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
        'lvCars
        '
        Me.lvCars.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvCars.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCBID, Me.chName, Me.ColumnHeader1})
        Me.lvCars.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCars.FullRowSelect = True
        Me.lvCars.GridLines = True
        Me.lvCars.Location = New System.Drawing.Point(13, 112)
        Me.lvCars.Name = "lvCars"
        Me.lvCars.Size = New System.Drawing.Size(983, 415)
        Me.lvCars.TabIndex = 210
        Me.lvCars.UseCompatibleStateImageBehavior = False
        Me.lvCars.View = System.Windows.Forms.View.Details
        '
        'chCBID
        '
        Me.chCBID.Text = "Car ID"
        Me.chCBID.Width = 127
        '
        'chName
        '
        Me.chName.Text = "Car owner"
        Me.chName.Width = 321
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Car name"
        Me.ColumnHeader1.Width = 514
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.BackColor = System.Drawing.Color.Silver
        Me.pnlMain.Controls.Add(Me.btnAddNew)
        Me.pnlMain.Controls.Add(Me.btnBack)
        Me.pnlMain.Controls.Add(Me.btnSearch)
        Me.pnlMain.Controls.Add(Me.btnPrint)
        Me.pnlMain.Controls.Add(Me.btnUpdate)
        Me.pnlMain.Controls.Add(Me.txtSearch)
        Me.pnlMain.Controls.Add(Me.Label3)
        Me.pnlMain.Controls.Add(Me.lvCars)
        Me.pnlMain.Controls.Add(Me.Label1)
        Me.pnlMain.Location = New System.Drawing.Point(0, 26)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1004, 565)
        Me.pnlMain.TabIndex = 206
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Gold
        Me.btnBack.Location = New System.Drawing.Point(902, 1)
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
        'pnlAddEdit
        '
        Me.pnlAddEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlAddEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAddEdit.Controls.Add(Me.lblbrand_id)
        Me.pnlAddEdit.Controls.Add(Me.txtBrand)
        Me.pnlAddEdit.Controls.Add(Me.cbxTrans)
        Me.pnlAddEdit.Controls.Add(Me.Label21)
        Me.pnlAddEdit.Controls.Add(Me.btnBrowseBrand)
        Me.pnlAddEdit.Controls.Add(Me.Label17)
        Me.pnlAddEdit.Controls.Add(Me.GroupBox1)
        Me.pnlAddEdit.Controls.Add(Me.cbxFuel)
        Me.pnlAddEdit.Controls.Add(Me.Label16)
        Me.pnlAddEdit.Controls.Add(Me.txtEngine)
        Me.pnlAddEdit.Controls.Add(Me.Label15)
        Me.pnlAddEdit.Controls.Add(Me.txtColor)
        Me.pnlAddEdit.Controls.Add(Me.Label13)
        Me.pnlAddEdit.Controls.Add(Me.txtMileage)
        Me.pnlAddEdit.Controls.Add(Me.Label7)
        Me.pnlAddEdit.Controls.Add(Me.txtVin)
        Me.pnlAddEdit.Controls.Add(Me.Label6)
        Me.pnlAddEdit.Controls.Add(Me.txtPlate)
        Me.pnlAddEdit.Controls.Add(Me.Label5)
        Me.pnlAddEdit.Controls.Add(Me.txtCarmodel)
        Me.pnlAddEdit.Controls.Add(Me.Label11)
        Me.pnlAddEdit.Controls.Add(Me.txtCarID)
        Me.pnlAddEdit.Controls.Add(Me.Label4)
        Me.pnlAddEdit.Controls.Add(Me.btnSave)
        Me.pnlAddEdit.Controls.Add(Me.btnAddEditClose)
        Me.pnlAddEdit.Controls.Add(Me.lblAddedit)
        Me.pnlAddEdit.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAddEdit.Location = New System.Drawing.Point(107, 27)
        Me.pnlAddEdit.Name = "pnlAddEdit"
        Me.pnlAddEdit.Size = New System.Drawing.Size(810, 450)
        Me.pnlAddEdit.TabIndex = 215
        Me.pnlAddEdit.Visible = False
        '
        'lblbrand_id
        '
        Me.lblbrand_id.AutoSize = True
        Me.lblbrand_id.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbrand_id.Location = New System.Drawing.Point(321, 99)
        Me.lblbrand_id.Name = "lblbrand_id"
        Me.lblbrand_id.Size = New System.Drawing.Size(31, 21)
        Me.lblbrand_id.TabIndex = 252
        Me.lblbrand_id.Text = "???"
        '
        'txtBrand
        '
        Me.txtBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBrand.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrand.Location = New System.Drawing.Point(138, 128)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.ReadOnly = True
        Me.txtBrand.Size = New System.Drawing.Size(214, 26)
        Me.txtBrand.TabIndex = 229
        '
        'cbxTrans
        '
        Me.cbxTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxTrans.FormattingEnabled = True
        Me.cbxTrans.Items.AddRange(New Object() {"Manual", "Automatic"})
        Me.cbxTrans.Location = New System.Drawing.Point(138, 389)
        Me.cbxTrans.Name = "cbxTrans"
        Me.cbxTrans.Size = New System.Drawing.Size(244, 29)
        Me.cbxTrans.TabIndex = 237
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(19, 392)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 21)
        Me.Label21.TabIndex = 249
        Me.Label21.Text = "Transmission"
        '
        'btnBrowseBrand
        '
        Me.btnBrowseBrand.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBrowseBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBrowseBrand.FlatAppearance.BorderSize = 0
        Me.btnBrowseBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseBrand.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseBrand.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBrowseBrand.Image = Global.JobsOrderSystem.My.Resources.Resources.searchs
        Me.btnBrowseBrand.Location = New System.Drawing.Point(352, 128)
        Me.btnBrowseBrand.Name = "btnBrowseBrand"
        Me.btnBrowseBrand.Size = New System.Drawing.Size(30, 26)
        Me.btnBrowseBrand.TabIndex = 248
        Me.btnBrowseBrand.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBrowseBrand.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(19, 131)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 21)
        Me.Label17.TabIndex = 246
        Me.Label17.Text = "Brand"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtLastname)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtMiddlename)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(397, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 338)
        Me.GroupBox1.TabIndex = 245
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Car owner Info"
        '
        'txtAddress
        '
        Me.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(27, 230)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(343, 90)
        Me.txtAddress.TabIndex = 243
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 210)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 21)
        Me.Label14.TabIndex = 243
        Me.Label14.Text = "Address:"
        '
        'txtEmail
        '
        Me.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(126, 178)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(244, 26)
        Me.txtEmail.TabIndex = 242
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 21)
        Me.Label12.TabIndex = 241
        Me.Label12.Text = "Email"
        '
        'txtContact
        '
        Me.txtContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContact.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(126, 146)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(244, 26)
        Me.txtContact.TabIndex = 241
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 21)
        Me.Label10.TabIndex = 239
        Me.Label10.Text = "Contact no."
        '
        'txtLastname
        '
        Me.txtLastname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastname.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(126, 114)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(244, 26)
        Me.txtLastname.TabIndex = 240
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 21)
        Me.Label9.TabIndex = 237
        Me.Label9.Text = "Last name"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMiddlename.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.Location = New System.Drawing.Point(126, 82)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(244, 26)
        Me.txtMiddlename.TabIndex = 239
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 21)
        Me.Label8.TabIndex = 235
        Me.Label8.Text = "Middle name"
        '
        'txtFirstname
        '
        Me.txtFirstname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstname.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(126, 50)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(244, 26)
        Me.txtFirstname.TabIndex = 238
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 233
        Me.Label2.Text = "First name"
        '
        'cbxFuel
        '
        Me.cbxFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxFuel.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFuel.FormattingEnabled = True
        Me.cbxFuel.Items.AddRange(New Object() {"Gas", "Diesel"})
        Me.cbxFuel.Location = New System.Drawing.Point(138, 354)
        Me.cbxFuel.Name = "cbxFuel"
        Me.cbxFuel.Size = New System.Drawing.Size(244, 29)
        Me.cbxFuel.TabIndex = 236
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(19, 357)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 21)
        Me.Label16.TabIndex = 243
        Me.Label16.Text = "Fuel"
        '
        'txtEngine
        '
        Me.txtEngine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtEngine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEngine.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEngine.Location = New System.Drawing.Point(138, 322)
        Me.txtEngine.Name = "txtEngine"
        Me.txtEngine.Size = New System.Drawing.Size(244, 26)
        Me.txtEngine.TabIndex = 235
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 322)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 21)
        Me.Label15.TabIndex = 241
        Me.Label15.Text = "Engine no."
        '
        'txtColor
        '
        Me.txtColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtColor.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(138, 258)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(244, 26)
        Me.txtColor.TabIndex = 233
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 21)
        Me.Label13.TabIndex = 239
        Me.Label13.Text = "Mileage"
        '
        'txtMileage
        '
        Me.txtMileage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtMileage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMileage.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMileage.Location = New System.Drawing.Point(138, 290)
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.Size = New System.Drawing.Size(244, 26)
        Me.txtMileage.TabIndex = 234
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 21)
        Me.Label7.TabIndex = 237
        Me.Label7.Text = "Color"
        '
        'txtVin
        '
        Me.txtVin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtVin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVin.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVin.Location = New System.Drawing.Point(138, 226)
        Me.txtVin.Name = "txtVin"
        Me.txtVin.Size = New System.Drawing.Size(244, 26)
        Me.txtVin.TabIndex = 232
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 21)
        Me.Label6.TabIndex = 235
        Me.Label6.Text = "Vin/Chassis no."
        '
        'txtPlate
        '
        Me.txtPlate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPlate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlate.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlate.Location = New System.Drawing.Point(138, 194)
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(244, 26)
        Me.txtPlate.TabIndex = 231
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 21)
        Me.Label5.TabIndex = 233
        Me.Label5.Text = "Plate no."
        '
        'txtCarmodel
        '
        Me.txtCarmodel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCarmodel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCarmodel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarmodel.Location = New System.Drawing.Point(138, 162)
        Me.txtCarmodel.Name = "txtCarmodel"
        Me.txtCarmodel.Size = New System.Drawing.Size(244, 26)
        Me.txtCarmodel.TabIndex = 230
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 21)
        Me.Label11.TabIndex = 231
        Me.Label11.Text = "Car model/Year"
        '
        'txtCarID
        '
        Me.txtCarID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCarID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCarID.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarID.Location = New System.Drawing.Point(138, 96)
        Me.txtCarID.Name = "txtCarID"
        Me.txtCarID.Size = New System.Drawing.Size(128, 26)
        Me.txtCarID.TabIndex = 228
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 21)
        Me.Label4.TabIndex = 227
        Me.Label4.Text = "Car ID"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(606, -1)
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
        Me.btnAddEditClose.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddEditClose.FlatAppearance.BorderSize = 0
        Me.btnAddEditClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEditClose.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEditClose.ForeColor = System.Drawing.Color.Gold
        Me.btnAddEditClose.Location = New System.Drawing.Point(707, -1)
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
        Me.lblAddedit.Size = New System.Drawing.Size(808, 51)
        Me.lblAddedit.TabIndex = 224
        Me.lblAddedit.Text = "  Add cars"
        Me.lblAddedit.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'timerAnimate
        '
        Me.timerAnimate.Interval = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 569)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1004, 22)
        Me.StatusStrip1.TabIndex = 218
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel1.Text = "Count"
        '
        'pnlBrand
        '
        Me.pnlBrand.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBrand.Controls.Add(Me.btn_SearchBrand)
        Me.pnlBrand.Controls.Add(Me.txtSearchBrand)
        Me.pnlBrand.Controls.Add(Me.Label19)
        Me.pnlBrand.Controls.Add(Me.btnSelectBrand)
        Me.pnlBrand.Controls.Add(Me.btnCloseBrand)
        Me.pnlBrand.Controls.Add(Me.Label18)
        Me.pnlBrand.Controls.Add(Me.lvCarBrands)
        Me.pnlBrand.Location = New System.Drawing.Point(240, 27)
        Me.pnlBrand.Name = "pnlBrand"
        Me.pnlBrand.Size = New System.Drawing.Size(567, 433)
        Me.pnlBrand.TabIndex = 219
        Me.pnlBrand.Visible = False
        '
        'btn_SearchBrand
        '
        Me.btn_SearchBrand.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_SearchBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_SearchBrand.FlatAppearance.BorderSize = 0
        Me.btn_SearchBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SearchBrand.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SearchBrand.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_SearchBrand.Image = CType(resources.GetObject("btn_SearchBrand.Image"), System.Drawing.Image)
        Me.btn_SearchBrand.Location = New System.Drawing.Point(288, 83)
        Me.btn_SearchBrand.Name = "btn_SearchBrand"
        Me.btn_SearchBrand.Size = New System.Drawing.Size(28, 26)
        Me.btn_SearchBrand.TabIndex = 230
        Me.btn_SearchBrand.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_SearchBrand.UseVisualStyleBackColor = False
        '
        'txtSearchBrand
        '
        Me.txtSearchBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearchBrand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchBrand.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBrand.Location = New System.Drawing.Point(65, 83)
        Me.txtSearchBrand.Name = "txtSearchBrand"
        Me.txtSearchBrand.Size = New System.Drawing.Size(222, 26)
        Me.txtSearchBrand.TabIndex = 229
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(13, 86)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 21)
        Me.Label19.TabIndex = 228
        Me.Label19.Text = "Search"
        '
        'btnSelectBrand
        '
        Me.btnSelectBrand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectBrand.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSelectBrand.FlatAppearance.BorderSize = 0
        Me.btnSelectBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectBrand.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectBrand.ForeColor = System.Drawing.Color.Gold
        Me.btnSelectBrand.Location = New System.Drawing.Point(352, 1)
        Me.btnSelectBrand.Name = "btnSelectBrand"
        Me.btnSelectBrand.Size = New System.Drawing.Size(102, 51)
        Me.btnSelectBrand.TabIndex = 227
        Me.btnSelectBrand.Text = "Select"
        Me.btnSelectBrand.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSelectBrand.UseVisualStyleBackColor = False
        '
        'btnCloseBrand
        '
        Me.btnCloseBrand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseBrand.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCloseBrand.FlatAppearance.BorderSize = 0
        Me.btnCloseBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseBrand.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseBrand.ForeColor = System.Drawing.Color.Gold
        Me.btnCloseBrand.Location = New System.Drawing.Point(460, 1)
        Me.btnCloseBrand.Name = "btnCloseBrand"
        Me.btnCloseBrand.Size = New System.Drawing.Size(102, 51)
        Me.btnCloseBrand.TabIndex = 226
        Me.btnCloseBrand.Text = "Close"
        Me.btnCloseBrand.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCloseBrand.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Gold
        Me.Label18.Location = New System.Drawing.Point(1, 1)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(567, 51)
        Me.Label18.TabIndex = 225
        Me.Label18.Text = "Select car brand"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lvCarBrands
        '
        Me.lvCarBrands.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvCarBrands.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCarBrands.FullRowSelect = True
        Me.lvCarBrands.GridLines = True
        Me.lvCarBrands.Location = New System.Drawing.Point(13, 113)
        Me.lvCarBrands.Name = "lvCarBrands"
        Me.lvCarBrands.Size = New System.Drawing.Size(540, 301)
        Me.lvCarBrands.TabIndex = 0
        Me.lvCarBrands.UseCompatibleStateImageBehavior = False
        Me.lvCarBrands.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "id"
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Brand name"
        Me.ColumnHeader2.Width = 439
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Percentage"
        Me.ColumnHeader3.Width = 184
        '
        'Cars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.pnlAddEdit)
        Me.Controls.Add(Me.pnlBrand)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Cars"
        Me.Size = New System.Drawing.Size(1004, 591)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlAddEdit.ResumeLayout(False)
        Me.pnlAddEdit.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlBrand.ResumeLayout(False)
        Me.pnlBrand.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvCars As System.Windows.Forms.ListView
    Friend WithEvents chCBID As System.Windows.Forms.ColumnHeader
    Friend WithEvents chName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pnlAddEdit As System.Windows.Forms.Panel
    Friend WithEvents txtCarmodel As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCarID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddEditClose As System.Windows.Forms.Button
    Friend WithEvents lblAddedit As System.Windows.Forms.Label
    Friend WithEvents txtPlate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMileage As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxFuel As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtEngine As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMiddlename As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents timerAnimate As System.Windows.Forms.Timer
    Friend WithEvents btnBrowseBrand As System.Windows.Forms.Button
    Friend WithEvents cbxTrans As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtBrand As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblbrand_id As System.Windows.Forms.Label
    Friend WithEvents pnlBrand As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lvCarBrands As System.Windows.Forms.ListView
    Friend WithEvents btnSelectBrand As System.Windows.Forms.Button
    Friend WithEvents btnCloseBrand As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_SearchBrand As System.Windows.Forms.Button
    Friend WithEvents txtSearchBrand As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader

End Class
