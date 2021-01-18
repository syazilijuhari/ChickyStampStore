<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu_a173630
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu_a173630))
        Me.lbl_mainmenu = New System.Windows.Forms.Label()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_insertproduct = New System.Windows.Forms.Button()
        Me.panel_product = New System.Windows.Forms.Panel()
        Me.btn_productlist = New System.Windows.Forms.Button()
        Me.btn_updateproduct = New System.Windows.Forms.Button()
        Me.timer_btnproduct = New System.Windows.Forms.Timer(Me.components)
        Me.panel_customer = New System.Windows.Forms.Panel()
        Me.btn_customerlist = New System.Windows.Forms.Button()
        Me.btn_updatecustomer = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_insertcustomer = New System.Windows.Forms.Button()
        Me.panel_staff = New System.Windows.Forms.Panel()
        Me.btn_stafflist = New System.Windows.Forms.Button()
        Me.btn_updatestaff = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_insertstaff = New System.Windows.Forms.Button()
        Me.timer_btncustomer = New System.Windows.Forms.Timer(Me.components)
        Me.timer_btnstaff = New System.Windows.Forms.Timer(Me.components)
        Me.panel_order = New System.Windows.Forms.Panel()
        Me.btn_makeorder = New System.Windows.Forms.Button()
        Me.btn_orderhistory = New System.Windows.Forms.Button()
        Me.btn_vieworder = New System.Windows.Forms.Button()
        Me.timer_btnorder = New System.Windows.Forms.Timer(Me.components)
        Me.panel_product.SuspendLayout()
        Me.panel_customer.SuspendLayout()
        Me.panel_staff.SuspendLayout()
        Me.panel_order.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_mainmenu
        '
        Me.lbl_mainmenu.AutoSize = True
        Me.lbl_mainmenu.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mainmenu.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mainmenu.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_mainmenu.Image = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.lbl_mainmenu.Location = New System.Drawing.Point(240, 119)
        Me.lbl_mainmenu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_mainmenu.Name = "lbl_mainmenu"
        Me.lbl_mainmenu.Size = New System.Drawing.Size(150, 31)
        Me.lbl_mainmenu.TabIndex = 1
        Me.lbl_mainmenu.Text = "Main Menu"
        '
        'btn_product
        '
        Me.btn_product.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_product.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_product.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_product.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_product.Image = Global.prj_chickystampstore_a173630.My.Resources.Resources.product
        Me.btn_product.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_product.Location = New System.Drawing.Point(0, 0)
        Me.btn_product.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(118, 72)
        Me.btn_product.TabIndex = 2
        Me.btn_product.Text = "Product"
        Me.btn_product.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_product.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.Color.PeachPuff
        Me.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_title.Font = New System.Drawing.Font("Old English Text MT", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_title.Image = CType(resources.GetObject("lbl_title.Image"), System.Drawing.Image)
        Me.lbl_title.Location = New System.Drawing.Point(190, 7)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(250, 93)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Chicky Stamp Store"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_order
        '
        Me.btn_order.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_order.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_order.Image = Global.prj_chickystampstore_a173630.My.Resources.Resources.order
        Me.btn_order.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_order.Location = New System.Drawing.Point(0, 0)
        Me.btn_order.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(118, 72)
        Me.btn_order.TabIndex = 5
        Me.btn_order.Text = "Order"
        Me.btn_order.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'btn_insertproduct
        '
        Me.btn_insertproduct.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_insertproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_insertproduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insertproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_insertproduct.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertproduct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_insertproduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertproduct.Location = New System.Drawing.Point(0, 116)
        Me.btn_insertproduct.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insertproduct.Name = "btn_insertproduct"
        Me.btn_insertproduct.Size = New System.Drawing.Size(118, 44)
        Me.btn_insertproduct.TabIndex = 7
        Me.btn_insertproduct.Text = "Insert Product"
        Me.btn_insertproduct.UseVisualStyleBackColor = True
        '
        'panel_product
        '
        Me.panel_product.BackColor = System.Drawing.Color.Transparent
        Me.panel_product.Controls.Add(Me.btn_productlist)
        Me.panel_product.Controls.Add(Me.btn_updateproduct)
        Me.panel_product.Controls.Add(Me.btn_product)
        Me.panel_product.Controls.Add(Me.btn_insertproduct)
        Me.panel_product.Location = New System.Drawing.Point(72, 172)
        Me.panel_product.MinimumSize = New System.Drawing.Size(118, 72)
        Me.panel_product.Name = "panel_product"
        Me.panel_product.Size = New System.Drawing.Size(120, 73)
        Me.panel_product.TabIndex = 10
        '
        'btn_productlist
        '
        Me.btn_productlist.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_productlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_productlist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_productlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_productlist.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productlist.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_productlist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_productlist.Location = New System.Drawing.Point(0, 72)
        Me.btn_productlist.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_productlist.Name = "btn_productlist"
        Me.btn_productlist.Size = New System.Drawing.Size(118, 44)
        Me.btn_productlist.TabIndex = 9
        Me.btn_productlist.Text = "Product List"
        Me.btn_productlist.UseVisualStyleBackColor = True
        '
        'btn_updateproduct
        '
        Me.btn_updateproduct.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_updateproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_updateproduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_updateproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_updateproduct.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateproduct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_updateproduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateproduct.Location = New System.Drawing.Point(0, 160)
        Me.btn_updateproduct.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_updateproduct.Name = "btn_updateproduct"
        Me.btn_updateproduct.Size = New System.Drawing.Size(118, 44)
        Me.btn_updateproduct.TabIndex = 8
        Me.btn_updateproduct.Text = "Update Product"
        Me.btn_updateproduct.UseVisualStyleBackColor = True
        '
        'timer_btnproduct
        '
        '
        'panel_customer
        '
        Me.panel_customer.BackColor = System.Drawing.Color.Transparent
        Me.panel_customer.Controls.Add(Me.btn_customerlist)
        Me.panel_customer.Controls.Add(Me.btn_updatecustomer)
        Me.panel_customer.Controls.Add(Me.btn_customer)
        Me.panel_customer.Controls.Add(Me.btn_insertcustomer)
        Me.panel_customer.Location = New System.Drawing.Point(195, 172)
        Me.panel_customer.MinimumSize = New System.Drawing.Size(118, 72)
        Me.panel_customer.Name = "panel_customer"
        Me.panel_customer.Size = New System.Drawing.Size(120, 73)
        Me.panel_customer.TabIndex = 11
        '
        'btn_customerlist
        '
        Me.btn_customerlist.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_customerlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_customerlist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_customerlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_customerlist.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customerlist.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_customerlist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_customerlist.Location = New System.Drawing.Point(0, 72)
        Me.btn_customerlist.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_customerlist.Name = "btn_customerlist"
        Me.btn_customerlist.Size = New System.Drawing.Size(118, 44)
        Me.btn_customerlist.TabIndex = 9
        Me.btn_customerlist.Text = "Customer List"
        Me.btn_customerlist.UseVisualStyleBackColor = True
        '
        'btn_updatecustomer
        '
        Me.btn_updatecustomer.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_updatecustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_updatecustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_updatecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_updatecustomer.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updatecustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_updatecustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updatecustomer.Location = New System.Drawing.Point(0, 160)
        Me.btn_updatecustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_updatecustomer.Name = "btn_updatecustomer"
        Me.btn_updatecustomer.Size = New System.Drawing.Size(118, 44)
        Me.btn_updatecustomer.TabIndex = 8
        Me.btn_updatecustomer.Text = "Update Customer"
        Me.btn_updatecustomer.UseVisualStyleBackColor = True
        '
        'btn_customer
        '
        Me.btn_customer.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_customer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_customer.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_customer.Image = Global.prj_chickystampstore_a173630.My.Resources.Resources.customer
        Me.btn_customer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_customer.Location = New System.Drawing.Point(0, 0)
        Me.btn_customer.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(118, 72)
        Me.btn_customer.TabIndex = 2
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_insertcustomer
        '
        Me.btn_insertcustomer.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_insertcustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_insertcustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insertcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_insertcustomer.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertcustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_insertcustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertcustomer.Location = New System.Drawing.Point(0, 116)
        Me.btn_insertcustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insertcustomer.Name = "btn_insertcustomer"
        Me.btn_insertcustomer.Size = New System.Drawing.Size(118, 44)
        Me.btn_insertcustomer.TabIndex = 7
        Me.btn_insertcustomer.Text = "Insert Customer"
        Me.btn_insertcustomer.UseVisualStyleBackColor = True
        '
        'panel_staff
        '
        Me.panel_staff.BackColor = System.Drawing.Color.Transparent
        Me.panel_staff.Controls.Add(Me.btn_stafflist)
        Me.panel_staff.Controls.Add(Me.btn_updatestaff)
        Me.panel_staff.Controls.Add(Me.btn_staff)
        Me.panel_staff.Controls.Add(Me.btn_insertstaff)
        Me.panel_staff.Location = New System.Drawing.Point(318, 172)
        Me.panel_staff.MinimumSize = New System.Drawing.Size(118, 72)
        Me.panel_staff.Name = "panel_staff"
        Me.panel_staff.Size = New System.Drawing.Size(120, 73)
        Me.panel_staff.TabIndex = 11
        '
        'btn_stafflist
        '
        Me.btn_stafflist.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_stafflist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_stafflist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_stafflist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stafflist.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stafflist.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_stafflist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stafflist.Location = New System.Drawing.Point(0, 72)
        Me.btn_stafflist.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_stafflist.Name = "btn_stafflist"
        Me.btn_stafflist.Size = New System.Drawing.Size(118, 44)
        Me.btn_stafflist.TabIndex = 9
        Me.btn_stafflist.Text = "Staff List"
        Me.btn_stafflist.UseVisualStyleBackColor = True
        '
        'btn_updatestaff
        '
        Me.btn_updatestaff.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_updatestaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_updatestaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_updatestaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_updatestaff.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updatestaff.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_updatestaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updatestaff.Location = New System.Drawing.Point(0, 160)
        Me.btn_updatestaff.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_updatestaff.Name = "btn_updatestaff"
        Me.btn_updatestaff.Size = New System.Drawing.Size(118, 44)
        Me.btn_updatestaff.TabIndex = 8
        Me.btn_updatestaff.Text = "Update Staff"
        Me.btn_updatestaff.UseVisualStyleBackColor = True
        '
        'btn_staff
        '
        Me.btn_staff.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_staff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_staff.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_staff.Image = Global.prj_chickystampstore_a173630.My.Resources.Resources.staff
        Me.btn_staff.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_staff.Location = New System.Drawing.Point(0, 0)
        Me.btn_staff.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(118, 72)
        Me.btn_staff.TabIndex = 2
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_staff.UseVisualStyleBackColor = True
        '
        'btn_insertstaff
        '
        Me.btn_insertstaff.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_insertstaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_insertstaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insertstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_insertstaff.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertstaff.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_insertstaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertstaff.Location = New System.Drawing.Point(0, 116)
        Me.btn_insertstaff.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insertstaff.Name = "btn_insertstaff"
        Me.btn_insertstaff.Size = New System.Drawing.Size(118, 44)
        Me.btn_insertstaff.TabIndex = 7
        Me.btn_insertstaff.Text = "Insert Staff"
        Me.btn_insertstaff.UseVisualStyleBackColor = True
        '
        'timer_btncustomer
        '
        '
        'timer_btnstaff
        '
        '
        'panel_order
        '
        Me.panel_order.BackColor = System.Drawing.Color.Transparent
        Me.panel_order.Controls.Add(Me.btn_makeorder)
        Me.panel_order.Controls.Add(Me.btn_orderhistory)
        Me.panel_order.Controls.Add(Me.btn_vieworder)
        Me.panel_order.Controls.Add(Me.btn_order)
        Me.panel_order.Location = New System.Drawing.Point(441, 172)
        Me.panel_order.MinimumSize = New System.Drawing.Size(118, 72)
        Me.panel_order.Name = "panel_order"
        Me.panel_order.Size = New System.Drawing.Size(118, 72)
        Me.panel_order.TabIndex = 12
        '
        'btn_makeorder
        '
        Me.btn_makeorder.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_makeorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_makeorder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_makeorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_makeorder.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_makeorder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_makeorder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_makeorder.Location = New System.Drawing.Point(0, 72)
        Me.btn_makeorder.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_makeorder.Name = "btn_makeorder"
        Me.btn_makeorder.Size = New System.Drawing.Size(118, 44)
        Me.btn_makeorder.TabIndex = 9
        Me.btn_makeorder.Text = "Make Order"
        Me.btn_makeorder.UseVisualStyleBackColor = True
        '
        'btn_orderhistory
        '
        Me.btn_orderhistory.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_orderhistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_orderhistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_orderhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_orderhistory.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orderhistory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_orderhistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_orderhistory.Location = New System.Drawing.Point(0, 160)
        Me.btn_orderhistory.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_orderhistory.Name = "btn_orderhistory"
        Me.btn_orderhistory.Size = New System.Drawing.Size(118, 44)
        Me.btn_orderhistory.TabIndex = 8
        Me.btn_orderhistory.Text = "Order History"
        Me.btn_orderhistory.UseVisualStyleBackColor = True
        '
        'btn_vieworder
        '
        Me.btn_vieworder.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_vieworder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_vieworder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_vieworder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vieworder.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vieworder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_vieworder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_vieworder.Location = New System.Drawing.Point(0, 116)
        Me.btn_vieworder.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_vieworder.Name = "btn_vieworder"
        Me.btn_vieworder.Size = New System.Drawing.Size(118, 44)
        Me.btn_vieworder.TabIndex = 7
        Me.btn_vieworder.Text = "View Order"
        Me.btn_vieworder.UseVisualStyleBackColor = True
        '
        'timer_btnorder
        '
        '
        'frm_mainmenu_a173630
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.mainmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(630, 420)
        Me.Controls.Add(Me.panel_order)
        Me.Controls.Add(Me.panel_staff)
        Me.Controls.Add(Me.panel_customer)
        Me.Controls.Add(Me.panel_product)
        Me.Controls.Add(Me.lbl_mainmenu)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_mainmenu_a173630"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAIN MENU"
        Me.panel_product.ResumeLayout(False)
        Me.panel_customer.ResumeLayout(False)
        Me.panel_staff.ResumeLayout(False)
        Me.panel_order.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_mainmenu As Label
    Friend WithEvents btn_product As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_insertproduct As Button
    Friend WithEvents panel_product As Panel
    Friend WithEvents btn_updateproduct As Button
    Friend WithEvents timer_btnproduct As Timer
    Friend WithEvents btn_productlist As Button
    Friend WithEvents panel_customer As Panel
    Friend WithEvents btn_customerlist As Button
    Friend WithEvents btn_updatecustomer As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_insertcustomer As Button
    Friend WithEvents panel_staff As Panel
    Friend WithEvents btn_stafflist As Button
    Friend WithEvents btn_updatestaff As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_insertstaff As Button
    Friend WithEvents timer_btncustomer As Timer
    Friend WithEvents timer_btnstaff As Timer
    Friend WithEvents panel_order As Panel
    Friend WithEvents btn_makeorder As Button
    Friend WithEvents btn_orderhistory As Button
    Friend WithEvents btn_vieworder As Button
    Friend WithEvents timer_btnorder As Timer
End Class
