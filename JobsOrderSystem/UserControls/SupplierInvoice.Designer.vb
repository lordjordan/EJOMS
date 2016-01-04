<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplierInvoice))
        Me.pnlAddEdit = New System.Windows.Forms.Panel()
        Me.btnViewImg = New System.Windows.Forms.Button()
        Me.btnBrowseInvoice = New System.Windows.Forms.Button()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.dtDueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddEditClose = New System.Windows.Forms.Button()
        Me.lblAddedit = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvCarBrands = New System.Windows.Forms.ListView()
        Me.chRef = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuppInvoiceno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timerAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlAddEdit.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAddEdit
        '
        Me.pnlAddEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlAddEdit.BackColor = System.Drawing.Color.Silver
        Me.pnlAddEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAddEdit.Controls.Add(Me.TextBox1)
        Me.pnlAddEdit.Controls.Add(Me.Label1)
        Me.pnlAddEdit.Controls.Add(Me.btnViewImg)
        Me.pnlAddEdit.Controls.Add(Me.btnBrowseInvoice)
        Me.pnlAddEdit.Controls.Add(Me.TextBox14)
        Me.pnlAddEdit.Controls.Add(Me.Label17)
        Me.pnlAddEdit.Controls.Add(Me.CheckBox1)
        Me.pnlAddEdit.Controls.Add(Me.dtDueDate)
        Me.pnlAddEdit.Controls.Add(Me.txtPrice)
        Me.pnlAddEdit.Controls.Add(Me.Label5)
        Me.pnlAddEdit.Controls.Add(Me.Label11)
        Me.pnlAddEdit.Controls.Add(Me.txtID)
        Me.pnlAddEdit.Controls.Add(Me.Label4)
        Me.pnlAddEdit.Controls.Add(Me.btnSave)
        Me.pnlAddEdit.Controls.Add(Me.btnAddEditClose)
        Me.pnlAddEdit.Controls.Add(Me.lblAddedit)
        Me.pnlAddEdit.Font = New System.Drawing.Font("Symbol", 8.25!)
        Me.pnlAddEdit.Location = New System.Drawing.Point(301, 27)
        Me.pnlAddEdit.Name = "pnlAddEdit"
        Me.pnlAddEdit.Size = New System.Drawing.Size(557, 350)
        Me.pnlAddEdit.TabIndex = 219
        Me.pnlAddEdit.Visible = False
        '
        'btnViewImg
        '
        Me.btnViewImg.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnViewImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnViewImg.FlatAppearance.BorderSize = 0
        Me.btnViewImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewImg.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewImg.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnViewImg.Location = New System.Drawing.Point(428, 280)
        Me.btnViewImg.Name = "btnViewImg"
        Me.btnViewImg.Size = New System.Drawing.Size(28, 26)
        Me.btnViewImg.TabIndex = 240
        Me.btnViewImg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewImg.UseVisualStyleBackColor = False
        '
        'btnBrowseInvoice
        '
        Me.btnBrowseInvoice.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBrowseInvoice.FlatAppearance.BorderSize = 0
        Me.btnBrowseInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseInvoice.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseInvoice.ForeColor = System.Drawing.Color.Gold
        Me.btnBrowseInvoice.Location = New System.Drawing.Point(337, 248)
        Me.btnBrowseInvoice.Name = "btnBrowseInvoice"
        Me.btnBrowseInvoice.Size = New System.Drawing.Size(119, 26)
        Me.btnBrowseInvoice.TabIndex = 239
        Me.btnBrowseInvoice.Text = "Browse..."
        Me.btnBrowseInvoice.UseVisualStyleBackColor = False
        '
        'TextBox14
        '
        Me.TextBox14.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox14.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(109, 280)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(319, 26)
        Me.TextBox14.TabIndex = 238
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(105, 251)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(216, 21)
        Me.Label17.TabIndex = 237
        Me.Label17.Text = "Upload Supplier's Sales Invoice:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(399, 312)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(57, 25)
        Me.CheckBox1.TabIndex = 236
        Me.CheckBox1.Text = "Paid"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'dtDueDate
        '
        Me.dtDueDate.CalendarForeColor = System.Drawing.Color.Gold
        Me.dtDueDate.CalendarTitleBackColor = System.Drawing.Color.MidnightBlue
        Me.dtDueDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtDueDate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDueDate.Location = New System.Drawing.Point(212, 197)
        Me.dtDueDate.Name = "dtDueDate"
        Me.dtDueDate.Size = New System.Drawing.Size(244, 29)
        Me.dtDueDate.TabIndex = 235
        '
        'txtPrice
        '
        Me.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(212, 124)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(244, 26)
        Me.txtPrice.TabIndex = 234
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(107, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 233
        Me.Label5.Text = "Due date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(107, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 42)
        Me.Label11.TabIndex = 231
        Me.Label11.Text = "Supplier's " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Invoice no."
        '
        'txtID
        '
        Me.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(212, 75)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(128, 26)
        Me.txtID.TabIndex = 228
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 21)
        Me.Label4.TabIndex = 227
        Me.Label4.Text = "Reference no."
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(353, -1)
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
        Me.btnAddEditClose.Location = New System.Drawing.Point(454, -1)
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
        Me.lblAddedit.Size = New System.Drawing.Size(555, 51)
        Me.lblAddedit.TabIndex = 224
        Me.lblAddedit.Text = "  Add invoice"
        Me.lblAddedit.TextAlign = System.Drawing.ContentAlignment.BottomLeft
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
        Me.pnlMain.Controls.Add(Me.lvCarBrands)
        Me.pnlMain.Controls.Add(Me.Label2)
        Me.pnlMain.Location = New System.Drawing.Point(0, 26)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1116, 438)
        Me.pnlMain.TabIndex = 218
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNew.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddNew.FlatAppearance.BorderSize = 0
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.Gold
        Me.btnAddNew.Location = New System.Drawing.Point(711, 1)
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
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Gold
        Me.btnBack.Location = New System.Drawing.Point(1014, 1)
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
        Me.btnPrint.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(913, 1)
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
        Me.btnUpdate.Location = New System.Drawing.Point(812, 1)
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
        'lvCarBrands
        '
        Me.lvCarBrands.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvCarBrands.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvCarBrands.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chRef, Me.ColumnHeader3, Me.SuppInvoiceno, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvCarBrands.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCarBrands.GridLines = True
        Me.lvCarBrands.Location = New System.Drawing.Point(13, 112)
        Me.lvCarBrands.Name = "lvCarBrands"
        Me.lvCarBrands.Size = New System.Drawing.Size(1095, 313)
        Me.lvCarBrands.TabIndex = 210
        Me.lvCarBrands.UseCompatibleStateImageBehavior = False
        Me.lvCarBrands.View = System.Windows.Forms.View.Details
        '
        'chRef
        '
        Me.chRef.Text = "Ref no."
        Me.chRef.Width = 127
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Image name"
        Me.ColumnHeader3.Width = 329
        '
        'SuppInvoiceno
        '
        Me.SuppInvoiceno.Text = "Supplier's Invoice no."
        Me.SuppInvoiceno.Width = 265
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Due date"
        Me.ColumnHeader1.Width = 192
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Status"
        Me.ColumnHeader2.Width = 174
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
        Me.Label2.Size = New System.Drawing.Size(1116, 51)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Supplier's invoice"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'timerAnimate
        '
        Me.timerAnimate.Interval = 1
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(212, 159)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(244, 26)
        Me.TextBox1.TabIndex = 242
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "Receipt no."
        '
        'SupplierInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.pnlAddEdit)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "SupplierInvoice"
        Me.Size = New System.Drawing.Size(1116, 464)
        Me.pnlAddEdit.ResumeLayout(False)
        Me.pnlAddEdit.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAddEdit As System.Windows.Forms.Panel
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddEditClose As System.Windows.Forms.Button
    Friend WithEvents lblAddedit As System.Windows.Forms.Label
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvCarBrands As System.Windows.Forms.ListView
    Friend WithEvents chRef As System.Windows.Forms.ColumnHeader
    Friend WithEvents SuppInvoiceno As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnViewImg As System.Windows.Forms.Button
    Friend WithEvents btnBrowseInvoice As System.Windows.Forms.Button
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents timerAnimate As System.Windows.Forms.Timer
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
