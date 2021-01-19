<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_a173630
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a173630))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_makeorder = New System.Windows.Forms.Label()
        Me.lb_productid = New System.Windows.Forms.ListBox()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_region = New System.Windows.Forms.Label()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.lbl_era = New System.Windows.Forms.Label()
        Me.lbl_condition = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_era = New System.Windows.Forms.TextBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_region = New System.Windows.Forms.TextBox()
        Me.txt_condition = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.gb_basic = New System.Windows.Forms.GroupBox()
        Me.cb_staffid = New System.Windows.Forms.ComboBox()
        Me.txt_orderid = New System.Windows.Forms.TextBox()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.gb_cust = New System.Windows.Forms.GroupBox()
        Me.txt_custid = New System.Windows.Forms.TextBox()
        Me.grid_customers = New System.Windows.Forms.DataGridView()
        Me.lbl_customername = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.txt_customername = New System.Windows.Forms.TextBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_customerid = New System.Windows.Forms.Label()
        Me.gb_item = New System.Windows.Forms.GroupBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.btn_addtocart = New System.Windows.Forms.Button()
        Me.lb_name = New System.Windows.Forms.Label()
        Me.num_quantity = New System.Windows.Forms.NumericUpDown()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.gb_cart = New System.Windows.Forms.GroupBox()
        Me.btn_removeitem = New System.Windows.Forms.Button()
        Me.grid_cart = New System.Windows.Forms.DataGridView()
        Me.gb_ordersum = New System.Windows.Forms.GroupBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.btn_confirmorder = New System.Windows.Forms.Button()
        Me.txt_totalprice = New System.Windows.Forms.TextBox()
        Me.lbl_productprice = New System.Windows.Forms.Label()
        Me.txt_productprice = New System.Windows.Forms.TextBox()
        Me.lbl_orderquantity = New System.Windows.Forms.Label()
        Me.txt_orderquantity = New System.Windows.Forms.TextBox()
        Me.lbl_totalprice = New System.Windows.Forms.Label()
        Me.gb_basic.SuspendLayout()
        Me.gb_cust.SuspendLayout()
        CType(Me.grid_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_item.SuspendLayout()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_cart.SuspendLayout()
        CType(Me.grid_cart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_ordersum.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_title.Font = New System.Drawing.Font("Old English Text MT", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_title.Location = New System.Drawing.Point(413, 9)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(250, 93)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Chicky Stamp Store"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Image = Global.prj_chickystampstore_a173630.My.Resources.Resources.backbutton
        Me.btn_back.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_back.Location = New System.Drawing.Point(11, 11)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(128, 43)
        Me.btn_back.TabIndex = 5
        Me.btn_back.Text = "Main Menu"
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_makeorder
        '
        Me.lbl_makeorder.AutoSize = True
        Me.lbl_makeorder.BackColor = System.Drawing.Color.Transparent
        Me.lbl_makeorder.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_makeorder.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_makeorder.Location = New System.Drawing.Point(459, 111)
        Me.lbl_makeorder.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_makeorder.Name = "lbl_makeorder"
        Me.lbl_makeorder.Size = New System.Drawing.Size(159, 31)
        Me.lbl_makeorder.TabIndex = 6
        Me.lbl_makeorder.Text = "Make Order"
        '
        'lb_productid
        '
        Me.lb_productid.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lb_productid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_productid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_productid.FormattingEnabled = True
        Me.lb_productid.ItemHeight = 20
        Me.lb_productid.Location = New System.Drawing.Point(11, 36)
        Me.lb_productid.Name = "lb_productid"
        Me.lb_productid.Size = New System.Drawing.Size(104, 244)
        Me.lb_productid.TabIndex = 7
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_staffid.Location = New System.Drawing.Point(32, 40)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(63, 19)
        Me.lbl_staffid.TabIndex = 34
        Me.lbl_staffid.Text = "Staff ID"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_price.Location = New System.Drawing.Point(327, 104)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(43, 19)
        Me.lbl_price.TabIndex = 33
        Me.lbl_price.Text = "Price"
        '
        'lbl_region
        '
        Me.lbl_region.AutoSize = True
        Me.lbl_region.BackColor = System.Drawing.Color.Transparent
        Me.lbl_region.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_region.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_region.Location = New System.Drawing.Point(314, 136)
        Me.lbl_region.Name = "lbl_region"
        Me.lbl_region.Size = New System.Drawing.Size(57, 19)
        Me.lbl_region.TabIndex = 32
        Me.lbl_region.Text = "Region"
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.BackColor = System.Drawing.Color.Transparent
        Me.lbl_year.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_year.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_year.Location = New System.Drawing.Point(329, 168)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(39, 19)
        Me.lbl_year.TabIndex = 31
        Me.lbl_year.Text = "Year"
        '
        'lbl_era
        '
        Me.lbl_era.AutoSize = True
        Me.lbl_era.BackColor = System.Drawing.Color.Transparent
        Me.lbl_era.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_era.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_era.Location = New System.Drawing.Point(335, 203)
        Me.lbl_era.Name = "lbl_era"
        Me.lbl_era.Size = New System.Drawing.Size(33, 19)
        Me.lbl_era.TabIndex = 30
        Me.lbl_era.Text = "Era"
        '
        'lbl_condition
        '
        Me.lbl_condition.AutoSize = True
        Me.lbl_condition.BackColor = System.Drawing.Color.Transparent
        Me.lbl_condition.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_condition.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_condition.Location = New System.Drawing.Point(297, 235)
        Me.lbl_condition.Name = "lbl_condition"
        Me.lbl_condition.Size = New System.Drawing.Size(73, 19)
        Me.lbl_condition.TabIndex = 29
        Me.lbl_condition.Text = "Condition"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_id.Location = New System.Drawing.Point(341, 43)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(27, 19)
        Me.lbl_id.TabIndex = 28
        Me.lbl_id.Text = "ID"
        '
        'txt_era
        '
        Me.txt_era.Location = New System.Drawing.Point(385, 196)
        Me.txt_era.Name = "txt_era"
        Me.txt_era.ReadOnly = True
        Me.txt_era.Size = New System.Drawing.Size(266, 26)
        Me.txt_era.TabIndex = 27
        '
        'txt_year
        '
        Me.txt_year.Location = New System.Drawing.Point(385, 164)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.ReadOnly = True
        Me.txt_year.Size = New System.Drawing.Size(266, 26)
        Me.txt_year.TabIndex = 26
        '
        'txt_region
        '
        Me.txt_region.Location = New System.Drawing.Point(385, 132)
        Me.txt_region.Name = "txt_region"
        Me.txt_region.ReadOnly = True
        Me.txt_region.Size = New System.Drawing.Size(266, 26)
        Me.txt_region.TabIndex = 25
        '
        'txt_condition
        '
        Me.txt_condition.Location = New System.Drawing.Point(385, 228)
        Me.txt_condition.Name = "txt_condition"
        Me.txt_condition.ReadOnly = True
        Me.txt_condition.Size = New System.Drawing.Size(266, 26)
        Me.txt_condition.TabIndex = 24
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(385, 68)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(266, 26)
        Me.txt_name.TabIndex = 23
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(385, 100)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(266, 26)
        Me.txt_price.TabIndex = 22
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(385, 36)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(266, 26)
        Me.txt_id.TabIndex = 21
        '
        'gb_basic
        '
        Me.gb_basic.BackColor = System.Drawing.Color.Transparent
        Me.gb_basic.Controls.Add(Me.cb_staffid)
        Me.gb_basic.Controls.Add(Me.txt_orderid)
        Me.gb_basic.Controls.Add(Me.lbl_orderid)
        Me.gb_basic.Controls.Add(Me.lbl_staffid)
        Me.gb_basic.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_basic.Location = New System.Drawing.Point(12, 150)
        Me.gb_basic.Name = "gb_basic"
        Me.gb_basic.Size = New System.Drawing.Size(380, 80)
        Me.gb_basic.TabIndex = 35
        Me.gb_basic.TabStop = False
        Me.gb_basic.Text = "Basic Informations"
        '
        'cb_staffid
        '
        Me.cb_staffid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_staffid.FormattingEnabled = True
        Me.cb_staffid.Location = New System.Drawing.Point(101, 37)
        Me.cb_staffid.Name = "cb_staffid"
        Me.cb_staffid.Size = New System.Drawing.Size(81, 27)
        Me.cb_staffid.TabIndex = 38
        '
        'txt_orderid
        '
        Me.txt_orderid.Location = New System.Drawing.Point(266, 37)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.ReadOnly = True
        Me.txt_orderid.Size = New System.Drawing.Size(81, 26)
        Me.txt_orderid.TabIndex = 37
        '
        'lbl_orderid
        '
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_orderid.Location = New System.Drawing.Point(189, 41)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(71, 19)
        Me.lbl_orderid.TabIndex = 36
        Me.lbl_orderid.Text = "Order ID"
        '
        'gb_cust
        '
        Me.gb_cust.BackColor = System.Drawing.Color.Transparent
        Me.gb_cust.Controls.Add(Me.txt_custid)
        Me.gb_cust.Controls.Add(Me.grid_customers)
        Me.gb_cust.Controls.Add(Me.lbl_customername)
        Me.gb_cust.Controls.Add(Me.txt_date)
        Me.gb_cust.Controls.Add(Me.txt_customername)
        Me.gb_cust.Controls.Add(Me.lbl_date)
        Me.gb_cust.Controls.Add(Me.lbl_customerid)
        Me.gb_cust.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_cust.Location = New System.Drawing.Point(12, 250)
        Me.gb_cust.Name = "gb_cust"
        Me.gb_cust.Size = New System.Drawing.Size(380, 256)
        Me.gb_cust.TabIndex = 36
        Me.gb_cust.TabStop = False
        Me.gb_cust.Text = "1. Customer Informations"
        '
        'txt_custid
        '
        Me.txt_custid.Location = New System.Drawing.Point(131, 157)
        Me.txt_custid.Name = "txt_custid"
        Me.txt_custid.ReadOnly = True
        Me.txt_custid.Size = New System.Drawing.Size(170, 26)
        Me.txt_custid.TabIndex = 66
        '
        'grid_customers
        '
        Me.grid_customers.AllowUserToAddRows = False
        Me.grid_customers.AllowUserToDeleteRows = False
        Me.grid_customers.AllowUserToResizeColumns = False
        Me.grid_customers.AllowUserToResizeRows = False
        Me.grid_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_customers.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grid_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_customers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grid_customers.Location = New System.Drawing.Point(5, 23)
        Me.grid_customers.Margin = New System.Windows.Forms.Padding(2)
        Me.grid_customers.Name = "grid_customers"
        Me.grid_customers.ReadOnly = True
        Me.grid_customers.RowHeadersWidth = 51
        Me.grid_customers.RowTemplate.Height = 24
        Me.grid_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_customers.Size = New System.Drawing.Size(370, 131)
        Me.grid_customers.TabIndex = 65
        '
        'lbl_customername
        '
        Me.lbl_customername.AutoSize = True
        Me.lbl_customername.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customername.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_customername.Location = New System.Drawing.Point(76, 196)
        Me.lbl_customername.Name = "lbl_customername"
        Me.lbl_customername.Size = New System.Drawing.Size(49, 19)
        Me.lbl_customername.TabIndex = 44
        Me.lbl_customername.Text = "Name"
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(131, 221)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.ReadOnly = True
        Me.txt_date.Size = New System.Drawing.Size(170, 26)
        Me.txt_date.TabIndex = 40
        '
        'txt_customername
        '
        Me.txt_customername.Location = New System.Drawing.Point(131, 189)
        Me.txt_customername.Name = "txt_customername"
        Me.txt_customername.ReadOnly = True
        Me.txt_customername.Size = New System.Drawing.Size(170, 26)
        Me.txt_customername.TabIndex = 41
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_date.Location = New System.Drawing.Point(39, 225)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(86, 19)
        Me.lbl_date.TabIndex = 43
        Me.lbl_date.Text = "Order Date"
        '
        'lbl_customerid
        '
        Me.lbl_customerid.AutoSize = True
        Me.lbl_customerid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customerid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerid.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_customerid.Location = New System.Drawing.Point(98, 164)
        Me.lbl_customerid.Name = "lbl_customerid"
        Me.lbl_customerid.Size = New System.Drawing.Size(27, 19)
        Me.lbl_customerid.TabIndex = 42
        Me.lbl_customerid.Text = "ID"
        '
        'gb_item
        '
        Me.gb_item.BackColor = System.Drawing.Color.Transparent
        Me.gb_item.Controls.Add(Me.pic_product)
        Me.gb_item.Controls.Add(Me.btn_addtocart)
        Me.gb_item.Controls.Add(Me.lb_name)
        Me.gb_item.Controls.Add(Me.num_quantity)
        Me.gb_item.Controls.Add(Me.lbl_quantity)
        Me.gb_item.Controls.Add(Me.lb_productid)
        Me.gb_item.Controls.Add(Me.txt_id)
        Me.gb_item.Controls.Add(Me.txt_price)
        Me.gb_item.Controls.Add(Me.txt_name)
        Me.gb_item.Controls.Add(Me.lbl_price)
        Me.gb_item.Controls.Add(Me.txt_condition)
        Me.gb_item.Controls.Add(Me.lbl_region)
        Me.gb_item.Controls.Add(Me.txt_region)
        Me.gb_item.Controls.Add(Me.lbl_year)
        Me.gb_item.Controls.Add(Me.txt_year)
        Me.gb_item.Controls.Add(Me.lbl_era)
        Me.gb_item.Controls.Add(Me.txt_era)
        Me.gb_item.Controls.Add(Me.lbl_condition)
        Me.gb_item.Controls.Add(Me.lbl_id)
        Me.gb_item.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_item.Location = New System.Drawing.Point(398, 150)
        Me.gb_item.Name = "gb_item"
        Me.gb_item.Size = New System.Drawing.Size(666, 356)
        Me.gb_item.TabIndex = 37
        Me.gb_item.TabStop = False
        Me.gb_item.Text = "2. Choose Item(s)"
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.SystemColors.Control
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(128, 81)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(169, 175)
        Me.pic_product.TabIndex = 64
        Me.pic_product.TabStop = False
        '
        'btn_addtocart
        '
        Me.btn_addtocart.BackColor = System.Drawing.Color.Transparent
        Me.btn_addtocart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addtocart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addtocart.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addtocart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_addtocart.Location = New System.Drawing.Point(440, 305)
        Me.btn_addtocart.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_addtocart.Name = "btn_addtocart"
        Me.btn_addtocart.Size = New System.Drawing.Size(169, 31)
        Me.btn_addtocart.TabIndex = 62
        Me.btn_addtocart.Text = "ADD TO CART"
        Me.btn_addtocart.UseVisualStyleBackColor = False
        '
        'lb_name
        '
        Me.lb_name.AutoSize = True
        Me.lb_name.BackColor = System.Drawing.Color.Transparent
        Me.lb_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_name.ForeColor = System.Drawing.Color.Maroon
        Me.lb_name.Location = New System.Drawing.Point(319, 75)
        Me.lb_name.Name = "lb_name"
        Me.lb_name.Size = New System.Drawing.Size(49, 19)
        Me.lb_name.TabIndex = 38
        Me.lb_name.Text = "Name"
        '
        'num_quantity
        '
        Me.num_quantity.Location = New System.Drawing.Point(385, 260)
        Me.num_quantity.Name = "num_quantity"
        Me.num_quantity.Size = New System.Drawing.Size(266, 26)
        Me.num_quantity.TabIndex = 37
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_quantity.Location = New System.Drawing.Point(301, 267)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(67, 19)
        Me.lbl_quantity.TabIndex = 36
        Me.lbl_quantity.Text = "Quantity"
        '
        'gb_cart
        '
        Me.gb_cart.BackColor = System.Drawing.Color.Transparent
        Me.gb_cart.Controls.Add(Me.btn_removeitem)
        Me.gb_cart.Controls.Add(Me.grid_cart)
        Me.gb_cart.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_cart.Location = New System.Drawing.Point(12, 512)
        Me.gb_cart.Name = "gb_cart"
        Me.gb_cart.Size = New System.Drawing.Size(529, 195)
        Me.gb_cart.TabIndex = 38
        Me.gb_cart.TabStop = False
        Me.gb_cart.Text = "3. Item(s) on cart"
        '
        'btn_removeitem
        '
        Me.btn_removeitem.BackColor = System.Drawing.Color.Transparent
        Me.btn_removeitem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_removeitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_removeitem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removeitem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_removeitem.Location = New System.Drawing.Point(397, 61)
        Me.btn_removeitem.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_removeitem.Name = "btn_removeitem"
        Me.btn_removeitem.Size = New System.Drawing.Size(120, 83)
        Me.btn_removeitem.TabIndex = 63
        Me.btn_removeitem.Text = "REMOVE ITEM"
        Me.btn_removeitem.UseVisualStyleBackColor = False
        '
        'grid_cart
        '
        Me.grid_cart.AllowUserToAddRows = False
        Me.grid_cart.AllowUserToDeleteRows = False
        Me.grid_cart.AllowUserToResizeColumns = False
        Me.grid_cart.AllowUserToResizeRows = False
        Me.grid_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_cart.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grid_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_cart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grid_cart.Location = New System.Drawing.Point(9, 24)
        Me.grid_cart.Margin = New System.Windows.Forms.Padding(2)
        Me.grid_cart.Name = "grid_cart"
        Me.grid_cart.ReadOnly = True
        Me.grid_cart.RowHeadersWidth = 51
        Me.grid_cart.RowTemplate.Height = 24
        Me.grid_cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_cart.Size = New System.Drawing.Size(370, 163)
        Me.grid_cart.TabIndex = 10
        '
        'gb_ordersum
        '
        Me.gb_ordersum.BackColor = System.Drawing.Color.Transparent
        Me.gb_ordersum.Controls.Add(Me.txt_subtotal)
        Me.gb_ordersum.Controls.Add(Me.lbl_subtotal)
        Me.gb_ordersum.Controls.Add(Me.btn_confirmorder)
        Me.gb_ordersum.Controls.Add(Me.txt_totalprice)
        Me.gb_ordersum.Controls.Add(Me.lbl_productprice)
        Me.gb_ordersum.Controls.Add(Me.txt_productprice)
        Me.gb_ordersum.Controls.Add(Me.lbl_orderquantity)
        Me.gb_ordersum.Controls.Add(Me.txt_orderquantity)
        Me.gb_ordersum.Controls.Add(Me.lbl_totalprice)
        Me.gb_ordersum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_ordersum.Location = New System.Drawing.Point(547, 512)
        Me.gb_ordersum.Name = "gb_ordersum"
        Me.gb_ordersum.Size = New System.Drawing.Size(517, 195)
        Me.gb_ordersum.TabIndex = 39
        Me.gb_ordersum.TabStop = False
        Me.gb_ordersum.Text = "4. Order Summary"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(163, 119)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(173, 26)
        Me.txt_subtotal.TabIndex = 39
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subtotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_subtotal.Location = New System.Drawing.Point(76, 126)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(72, 19)
        Me.lbl_subtotal.TabIndex = 40
        Me.lbl_subtotal.Text = "Sub Total"
        '
        'btn_confirmorder
        '
        Me.btn_confirmorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_confirmorder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirmorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmorder.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmorder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_confirmorder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_confirmorder.Location = New System.Drawing.Point(375, 61)
        Me.btn_confirmorder.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_confirmorder.Name = "btn_confirmorder"
        Me.btn_confirmorder.Size = New System.Drawing.Size(116, 83)
        Me.btn_confirmorder.TabIndex = 38
        Me.btn_confirmorder.Text = "CONFIRM ORDER"
        Me.btn_confirmorder.UseVisualStyleBackColor = True
        '
        'txt_totalprice
        '
        Me.txt_totalprice.Location = New System.Drawing.Point(163, 151)
        Me.txt_totalprice.Name = "txt_totalprice"
        Me.txt_totalprice.ReadOnly = True
        Me.txt_totalprice.Size = New System.Drawing.Size(173, 26)
        Me.txt_totalprice.TabIndex = 32
        '
        'lbl_productprice
        '
        Me.lbl_productprice.AutoSize = True
        Me.lbl_productprice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productprice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productprice.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_productprice.Location = New System.Drawing.Point(50, 61)
        Me.lbl_productprice.Name = "lbl_productprice"
        Me.lbl_productprice.Size = New System.Drawing.Size(98, 19)
        Me.lbl_productprice.TabIndex = 37
        Me.lbl_productprice.Text = "Product Price"
        '
        'txt_productprice
        '
        Me.txt_productprice.Location = New System.Drawing.Point(163, 54)
        Me.txt_productprice.Name = "txt_productprice"
        Me.txt_productprice.ReadOnly = True
        Me.txt_productprice.Size = New System.Drawing.Size(173, 26)
        Me.txt_productprice.TabIndex = 33
        '
        'lbl_orderquantity
        '
        Me.lbl_orderquantity.AutoSize = True
        Me.lbl_orderquantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderquantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderquantity.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_orderquantity.Location = New System.Drawing.Point(81, 93)
        Me.lbl_orderquantity.Name = "lbl_orderquantity"
        Me.lbl_orderquantity.Size = New System.Drawing.Size(67, 19)
        Me.lbl_orderquantity.TabIndex = 36
        Me.lbl_orderquantity.Text = "Quantity"
        '
        'txt_orderquantity
        '
        Me.txt_orderquantity.Location = New System.Drawing.Point(163, 86)
        Me.txt_orderquantity.Name = "txt_orderquantity"
        Me.txt_orderquantity.ReadOnly = True
        Me.txt_orderquantity.Size = New System.Drawing.Size(173, 26)
        Me.txt_orderquantity.TabIndex = 34
        '
        'lbl_totalprice
        '
        Me.lbl_totalprice.AutoSize = True
        Me.lbl_totalprice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_totalprice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalprice.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_totalprice.Location = New System.Drawing.Point(67, 158)
        Me.lbl_totalprice.Name = "lbl_totalprice"
        Me.lbl_totalprice.Size = New System.Drawing.Size(81, 19)
        Me.lbl_totalprice.TabIndex = 35
        Me.lbl_totalprice.Text = "Total Price"
        '
        'frm_makeorder_a173630
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1076, 719)
        Me.Controls.Add(Me.gb_ordersum)
        Me.Controls.Add(Me.gb_cart)
        Me.Controls.Add(Me.gb_item)
        Me.Controls.Add(Me.gb_cust)
        Me.Controls.Add(Me.gb_basic)
        Me.Controls.Add(Me.lbl_makeorder)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_makeorder_a173630"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAKE ORDER"
        Me.gb_basic.ResumeLayout(False)
        Me.gb_basic.PerformLayout()
        Me.gb_cust.ResumeLayout(False)
        Me.gb_cust.PerformLayout()
        CType(Me.grid_customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_item.ResumeLayout(False)
        Me.gb_item.PerformLayout()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_cart.ResumeLayout(False)
        CType(Me.grid_cart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_ordersum.ResumeLayout(False)
        Me.gb_ordersum.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_makeorder As Label
    Friend WithEvents lb_productid As ListBox
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_region As Label
    Friend WithEvents lbl_year As Label
    Friend WithEvents lbl_era As Label
    Friend WithEvents lbl_condition As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_era As TextBox
    Friend WithEvents txt_year As TextBox
    Friend WithEvents txt_region As TextBox
    Friend WithEvents txt_condition As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents gb_basic As GroupBox
    Friend WithEvents gb_cust As GroupBox
    Friend WithEvents gb_item As GroupBox
    Friend WithEvents num_quantity As NumericUpDown
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents gb_cart As GroupBox
    Friend WithEvents gb_ordersum As GroupBox
    Friend WithEvents lb_name As Label
    Friend WithEvents txt_orderid As TextBox
    Friend WithEvents lbl_orderid As Label
    Friend WithEvents lbl_customername As Label
    Friend WithEvents txt_date As TextBox
    Friend WithEvents txt_customername As TextBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_customerid As Label
    Friend WithEvents grid_cart As DataGridView
    Friend WithEvents txt_totalprice As TextBox
    Friend WithEvents lbl_productprice As Label
    Friend WithEvents txt_productprice As TextBox
    Friend WithEvents lbl_orderquantity As Label
    Friend WithEvents txt_orderquantity As TextBox
    Friend WithEvents lbl_totalprice As Label
    Friend WithEvents btn_addtocart As Button
    Friend WithEvents btn_confirmorder As Button
    Friend WithEvents btn_removeitem As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents cb_staffid As ComboBox
    Friend WithEvents grid_customers As DataGridView
    Friend WithEvents txt_custid As TextBox
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents lbl_subtotal As Label
End Class
