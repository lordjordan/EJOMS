<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmrTimeDate = New System.Windows.Forms.Timer(Me.components)
        Me.btnSalesInvoice = New System.Windows.Forms.Button()
        Me.btnAddNewJO = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnServices = New System.Windows.Forms.Button()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.btnClients = New System.Windows.Forms.Button()
        Me.btnJobOrderList = New System.Windows.Forms.Button()
        Me.btnCarBrands = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMainMenu
        '
        Me.lblMainMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMainMenu.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblMainMenu.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.ForeColor = System.Drawing.Color.Gold
        Me.lblMainMenu.Location = New System.Drawing.Point(0, 27)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(1000, 51)
        Me.lblMainMenu.TabIndex = 175
        Me.lblMainMenu.Text = "  Main Menu"
        Me.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Gold
        Me.btnLogOut.Location = New System.Drawing.Point(876, 27)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(76, 51)
        Me.btnLogOut.TabIndex = 193
        Me.btnLogOut.Text = "Log out"
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDate.Location = New System.Drawing.Point(459, 622)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(528, 59)
        Me.lblDate.TabIndex = 195
        Me.lblDate.Text = "Calculating the date..."
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTime.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblTime.Location = New System.Drawing.Point(649, 572)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(338, 55)
        Me.lblTime.TabIndex = 194
        Me.lblTime.Text = "Setting up the time..."
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tmrTimeDate
        '
        Me.tmrTimeDate.Enabled = True
        Me.tmrTimeDate.Interval = 1000
        '
        'btnSalesInvoice
        '
        Me.btnSalesInvoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalesInvoice.FlatAppearance.BorderSize = 0
        Me.btnSalesInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesInvoice.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesInvoice.ForeColor = System.Drawing.Color.White
        Me.btnSalesInvoice.Image = CType(resources.GetObject("btnSalesInvoice.Image"), System.Drawing.Image)
        Me.btnSalesInvoice.Location = New System.Drawing.Point(320, 492)
        Me.btnSalesInvoice.Name = "btnSalesInvoice"
        Me.btnSalesInvoice.Size = New System.Drawing.Size(140, 123)
        Me.btnSalesInvoice.TabIndex = 187
        Me.btnSalesInvoice.Text = "Supplier invoice"
        Me.btnSalesInvoice.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnSalesInvoice.UseVisualStyleBackColor = False
        '
        'btnAddNewJO
        '
        Me.btnAddNewJO.BackColor = System.Drawing.Color.Green
        Me.btnAddNewJO.FlatAppearance.BorderSize = 0
        Me.btnAddNewJO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewJO.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewJO.ForeColor = System.Drawing.Color.White
        Me.btnAddNewJO.Image = Global.JobsOrderSystem.My.Resources.Resources.new_jobOrder
        Me.btnAddNewJO.Location = New System.Drawing.Point(320, 109)
        Me.btnAddNewJO.Name = "btnAddNewJO"
        Me.btnAddNewJO.Size = New System.Drawing.Size(287, 123)
        Me.btnAddNewJO.TabIndex = 186
        Me.btnAddNewJO.Text = "New job order"
        Me.btnAddNewJO.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAddNewJO.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Image = Global.JobsOrderSystem.My.Resources.Resources.report
        Me.btnReports.Location = New System.Drawing.Point(613, 109)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(287, 248)
        Me.btnReports.TabIndex = 184
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.Image = Global.JobsOrderSystem.My.Resources.Resources.userS
        Me.btnUsers.Location = New System.Drawing.Point(467, 492)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(140, 123)
        Me.btnUsers.TabIndex = 183
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'btnServices
        '
        Me.btnServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnServices.FlatAppearance.BorderSize = 0
        Me.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServices.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServices.ForeColor = System.Drawing.Color.White
        Me.btnServices.Image = Global.JobsOrderSystem.My.Resources.Resources.serviceSM
        Me.btnServices.Location = New System.Drawing.Point(27, 492)
        Me.btnServices.Name = "btnServices"
        Me.btnServices.Size = New System.Drawing.Size(287, 123)
        Me.btnServices.TabIndex = 182
        Me.btnServices.Text = "Services"
        Me.btnServices.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnServices.UseVisualStyleBackColor = False
        '
        'btnItems
        '
        Me.btnItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnItems.FlatAppearance.BorderSize = 0
        Me.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItems.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItems.ForeColor = System.Drawing.Color.White
        Me.btnItems.Image = Global.JobsOrderSystem.My.Resources.Resources.spark
        Me.btnItems.Location = New System.Drawing.Point(27, 363)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(287, 123)
        Me.btnItems.TabIndex = 181
        Me.btnItems.Text = "Parts"
        Me.btnItems.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnItems.UseVisualStyleBackColor = False
        '
        'btnClients
        '
        Me.btnClients.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClients.FlatAppearance.BorderSize = 0
        Me.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClients.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClients.ForeColor = System.Drawing.Color.White
        Me.btnClients.Image = Global.JobsOrderSystem.My.Resources.Resources.carS
        Me.btnClients.Location = New System.Drawing.Point(320, 238)
        Me.btnClients.Name = "btnClients"
        Me.btnClients.Size = New System.Drawing.Size(287, 248)
        Me.btnClients.TabIndex = 178
        Me.btnClients.Text = "Car List"
        Me.btnClients.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnClients.UseVisualStyleBackColor = False
        '
        'btnJobOrderList
        '
        Me.btnJobOrderList.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnJobOrderList.FlatAppearance.BorderSize = 0
        Me.btnJobOrderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJobOrderList.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobOrderList.ForeColor = System.Drawing.Color.White
        Me.btnJobOrderList.Image = Global.JobsOrderSystem.My.Resources.Resources.job
        Me.btnJobOrderList.Location = New System.Drawing.Point(27, 109)
        Me.btnJobOrderList.Name = "btnJobOrderList"
        Me.btnJobOrderList.Size = New System.Drawing.Size(287, 248)
        Me.btnJobOrderList.TabIndex = 177
        Me.btnJobOrderList.Text = "Job Order List"
        Me.btnJobOrderList.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnJobOrderList.UseVisualStyleBackColor = False
        '
        'btnCarBrands
        '
        Me.btnCarBrands.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCarBrands.FlatAppearance.BorderSize = 0
        Me.btnCarBrands.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarBrands.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarBrands.ForeColor = System.Drawing.Color.White
        Me.btnCarBrands.Image = CType(resources.GetObject("btnCarBrands.Image"), System.Drawing.Image)
        Me.btnCarBrands.Location = New System.Drawing.Point(613, 363)
        Me.btnCarBrands.Name = "btnCarBrands"
        Me.btnCarBrands.Size = New System.Drawing.Size(287, 123)
        Me.btnCarBrands.TabIndex = 185
        Me.btnCarBrands.Text = "Car brands"
        Me.btnCarBrands.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCarBrands.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnSalesInvoice)
        Me.Controls.Add(Me.btnAddNewJO)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.btnServices)
        Me.Controls.Add(Me.btnItems)
        Me.Controls.Add(Me.btnClients)
        Me.Controls.Add(Me.btnJobOrderList)
        Me.Controls.Add(Me.lblMainMenu)
        Me.Controls.Add(Me.btnCarBrands)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainMenu"
        Me.Size = New System.Drawing.Size(1000, 696)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMainMenu As System.Windows.Forms.Label
    Friend WithEvents btnJobOrderList As System.Windows.Forms.Button
    Friend WithEvents btnClients As System.Windows.Forms.Button
    Friend WithEvents btnItems As System.Windows.Forms.Button
    Friend WithEvents btnServices As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnCarBrands As System.Windows.Forms.Button
    Friend WithEvents btnAddNewJO As System.Windows.Forms.Button
    Friend WithEvents btnSalesInvoice As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents tmrTimeDate As System.Windows.Forms.Timer

End Class
