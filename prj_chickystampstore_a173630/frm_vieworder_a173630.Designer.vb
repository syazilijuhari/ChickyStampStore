<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_vieworder_a173630
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_vieworder_a173630))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_orderlist = New System.Windows.Forms.Label()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.lb_orderid = New System.Windows.Forms.ListBox()
        Me.grid_orders = New System.Windows.Forms.DataGridView()
        Me.lbl_orderid2 = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.txt_orderid = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lbl_invoice = New System.Windows.Forms.Label()
        Me.txt_staffid = New System.Windows.Forms.Label()
        Me.txt_custid = New System.Windows.Forms.Label()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.lbl_custid = New System.Windows.Forms.Label()
        Me.txt_totalprice = New System.Windows.Forms.Label()
        Me.lbl_totalprice = New System.Windows.Forms.Label()
        Me.lbl_rm = New System.Windows.Forms.Label()
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Image = Global.prj_chickystampstore_a173630.My.Resources.Resources.backbutton
        Me.btn_back.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_back.Location = New System.Drawing.Point(9, 10)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(128, 43)
        Me.btn_back.TabIndex = 6
        Me.btn_back.Text = "Main Menu"
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_title.Font = New System.Drawing.Font("Old English Text MT", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_title.Location = New System.Drawing.Point(306, 7)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(250, 93)
        Me.lbl_title.TabIndex = 7
        Me.lbl_title.Text = "Chicky Stamp Store"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_orderlist
        '
        Me.lbl_orderlist.AutoSize = True
        Me.lbl_orderlist.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderlist.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderlist.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_orderlist.Location = New System.Drawing.Point(356, 109)
        Me.lbl_orderlist.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_orderlist.Name = "lbl_orderlist"
        Me.lbl_orderlist.Size = New System.Drawing.Size(150, 31)
        Me.lbl_orderlist.TabIndex = 8
        Me.lbl_orderlist.Text = "View Order"
        '
        'lbl_orderid
        '
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_orderid.Location = New System.Drawing.Point(89, 331)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(86, 22)
        Me.lbl_orderid.TabIndex = 37
        Me.lbl_orderid.Text = "Order ID"
        '
        'lb_orderid
        '
        Me.lb_orderid.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lb_orderid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_orderid.FormattingEnabled = True
        Me.lb_orderid.ItemHeight = 20
        Me.lb_orderid.Location = New System.Drawing.Point(74, 356)
        Me.lb_orderid.Name = "lb_orderid"
        Me.lb_orderid.Size = New System.Drawing.Size(120, 244)
        Me.lb_orderid.TabIndex = 38
        '
        'grid_orders
        '
        Me.grid_orders.AllowUserToAddRows = False
        Me.grid_orders.AllowUserToDeleteRows = False
        Me.grid_orders.AllowUserToResizeColumns = False
        Me.grid_orders.AllowUserToResizeRows = False
        Me.grid_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_orders.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_orders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_orders.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_orders.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_orders.Location = New System.Drawing.Point(199, 357)
        Me.grid_orders.Margin = New System.Windows.Forms.Padding(2)
        Me.grid_orders.Name = "grid_orders"
        Me.grid_orders.ReadOnly = True
        Me.grid_orders.RowHeadersWidth = 51
        Me.grid_orders.RowTemplate.Height = 24
        Me.grid_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_orders.Size = New System.Drawing.Size(589, 243)
        Me.grid_orders.TabIndex = 39
        '
        'lbl_orderid2
        '
        Me.lbl_orderid2.AutoSize = True
        Me.lbl_orderid2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid2.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_orderid2.Location = New System.Drawing.Point(216, 301)
        Me.lbl_orderid2.Name = "lbl_orderid2"
        Me.lbl_orderid2.Size = New System.Drawing.Size(31, 22)
        Me.lbl_orderid2.TabIndex = 40
        Me.lbl_orderid2.Text = "ID"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_date.Location = New System.Drawing.Point(198, 329)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(49, 22)
        Me.lbl_date.TabIndex = 45
        Me.lbl_date.Text = "Date"
        '
        'txt_orderid
        '
        Me.txt_orderid.AutoSize = True
        Me.txt_orderid.BackColor = System.Drawing.Color.Transparent
        Me.txt_orderid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orderid.Location = New System.Drawing.Point(253, 301)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.Size = New System.Drawing.Size(31, 22)
        Me.txt_orderid.TabIndex = 46
        Me.txt_orderid.Text = "ID"
        '
        'txt_date
        '
        Me.txt_date.AutoSize = True
        Me.txt_date.BackColor = System.Drawing.Color.Transparent
        Me.txt_date.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Location = New System.Drawing.Point(253, 330)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(49, 22)
        Me.txt_date.TabIndex = 47
        Me.txt_date.Text = "Date"
        '
        'lbl_address
        '
        Me.lbl_address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_address.Location = New System.Drawing.Point(293, 151)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(277, 114)
        Me.lbl_address.TabIndex = 48
        Me.lbl_address.Text = "Chicky Stamp Store," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Universiti Kebangsaan Malaysia," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "43600 UKM," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bangi, Selangor" &
    ", Malaysia." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_invoice
        '
        Me.lbl_invoice.AutoSize = True
        Me.lbl_invoice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_invoice.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invoice.Location = New System.Drawing.Point(366, 272)
        Me.lbl_invoice.Name = "lbl_invoice"
        Me.lbl_invoice.Size = New System.Drawing.Size(131, 31)
        Me.lbl_invoice.TabIndex = 49
        Me.lbl_invoice.Text = "INVOICE"
        '
        'txt_staffid
        '
        Me.txt_staffid.AutoSize = True
        Me.txt_staffid.BackColor = System.Drawing.Color.Transparent
        Me.txt_staffid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staffid.Location = New System.Drawing.Point(735, 331)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.Size = New System.Drawing.Size(31, 22)
        Me.txt_staffid.TabIndex = 53
        Me.txt_staffid.Text = "ID"
        '
        'txt_custid
        '
        Me.txt_custid.AutoSize = True
        Me.txt_custid.BackColor = System.Drawing.Color.Transparent
        Me.txt_custid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custid.Location = New System.Drawing.Point(735, 301)
        Me.txt_custid.Name = "txt_custid"
        Me.txt_custid.Size = New System.Drawing.Size(31, 22)
        Me.txt_custid.TabIndex = 52
        Me.txt_custid.Text = "ID"
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_staffid.Location = New System.Drawing.Point(654, 329)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(75, 22)
        Me.lbl_staffid.TabIndex = 51
        Me.lbl_staffid.Text = "Staff ID"
        '
        'lbl_custid
        '
        Me.lbl_custid.AutoSize = True
        Me.lbl_custid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_custid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custid.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_custid.Location = New System.Drawing.Point(613, 301)
        Me.lbl_custid.Name = "lbl_custid"
        Me.lbl_custid.Size = New System.Drawing.Size(116, 22)
        Me.lbl_custid.TabIndex = 50
        Me.lbl_custid.Text = "Customer ID"
        '
        'txt_totalprice
        '
        Me.txt_totalprice.AutoSize = True
        Me.txt_totalprice.BackColor = System.Drawing.Color.Transparent
        Me.txt_totalprice.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalprice.Location = New System.Drawing.Point(703, 607)
        Me.txt_totalprice.Name = "txt_totalprice"
        Me.txt_totalprice.Size = New System.Drawing.Size(53, 22)
        Me.txt_totalprice.TabIndex = 55
        Me.txt_totalprice.Text = "Price"
        '
        'lbl_totalprice
        '
        Me.lbl_totalprice.AutoSize = True
        Me.lbl_totalprice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_totalprice.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalprice.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_totalprice.Location = New System.Drawing.Point(558, 607)
        Me.lbl_totalprice.Name = "lbl_totalprice"
        Me.lbl_totalprice.Size = New System.Drawing.Size(100, 22)
        Me.lbl_totalprice.TabIndex = 54
        Me.lbl_totalprice.Text = "Total Price"
        '
        'lbl_rm
        '
        Me.lbl_rm.AutoSize = True
        Me.lbl_rm.BackColor = System.Drawing.Color.Transparent
        Me.lbl_rm.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rm.Location = New System.Drawing.Point(658, 607)
        Me.lbl_rm.Name = "lbl_rm"
        Me.lbl_rm.Size = New System.Drawing.Size(42, 22)
        Me.lbl_rm.TabIndex = 56
        Me.lbl_rm.Text = "RM"
        '
        'frm_vieworder_a173630
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(863, 709)
        Me.Controls.Add(Me.lbl_rm)
        Me.Controls.Add(Me.txt_totalprice)
        Me.Controls.Add(Me.lbl_totalprice)
        Me.Controls.Add(Me.txt_staffid)
        Me.Controls.Add(Me.txt_custid)
        Me.Controls.Add(Me.lbl_staffid)
        Me.Controls.Add(Me.lbl_custid)
        Me.Controls.Add(Me.lbl_invoice)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.txt_orderid)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_orderid2)
        Me.Controls.Add(Me.grid_orders)
        Me.Controls.Add(Me.lb_orderid)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.lbl_orderlist)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_vieworder_a173630"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VIEW ORDER"
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_orderlist As Label
    Friend WithEvents lbl_orderid As Label
    Friend WithEvents lb_orderid As ListBox
    Friend WithEvents grid_orders As DataGridView
    Friend WithEvents lbl_orderid2 As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents txt_orderid As Label
    Friend WithEvents txt_date As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents lbl_invoice As Label
    Friend WithEvents txt_staffid As Label
    Friend WithEvents txt_custid As Label
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents lbl_custid As Label
    Friend WithEvents txt_totalprice As Label
    Friend WithEvents lbl_totalprice As Label
    Friend WithEvents lbl_rm As Label
End Class
