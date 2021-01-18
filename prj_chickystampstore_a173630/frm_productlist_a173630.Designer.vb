<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_productlist_a173630
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productlist_a173630))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_productlist = New System.Windows.Forms.Label()
        Me.grid_products = New System.Windows.Forms.DataGridView()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_condition = New System.Windows.Forms.TextBox()
        Me.txt_region = New System.Windows.Forms.TextBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_era = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_condition = New System.Windows.Forms.Label()
        Me.lbl_era = New System.Windows.Forms.Label()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.lbl_region = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        CType(Me.grid_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Chicky Stamp Store"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_productlist
        '
        Me.lbl_productlist.AutoSize = True
        Me.lbl_productlist.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productlist.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productlist.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_productlist.Location = New System.Drawing.Point(458, 114)
        Me.lbl_productlist.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_productlist.Name = "lbl_productlist"
        Me.lbl_productlist.Size = New System.Drawing.Size(161, 31)
        Me.lbl_productlist.TabIndex = 2
        Me.lbl_productlist.Text = "Product List"
        '
        'grid_products
        '
        Me.grid_products.AllowUserToAddRows = False
        Me.grid_products.AllowUserToDeleteRows = False
        Me.grid_products.AllowUserToResizeColumns = False
        Me.grid_products.AllowUserToResizeRows = False
        Me.grid_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_products.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grid_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_products.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_products.DefaultCellStyle = DataGridViewCellStyle1
        Me.grid_products.Location = New System.Drawing.Point(27, 147)
        Me.grid_products.Margin = New System.Windows.Forms.Padding(2)
        Me.grid_products.Name = "grid_products"
        Me.grid_products.ReadOnly = True
        Me.grid_products.RowHeadersWidth = 51
        Me.grid_products.RowTemplate.Height = 24
        Me.grid_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_products.Size = New System.Drawing.Size(1022, 258)
        Me.grid_products.TabIndex = 3
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
        Me.btn_back.TabIndex = 4
        Me.btn_back.Text = "Main Menu"
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(206, 457)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(169, 175)
        Me.pic_product.TabIndex = 5
        Me.pic_product.TabStop = False
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(490, 454)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(380, 20)
        Me.txt_id.TabIndex = 6
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(490, 506)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(380, 20)
        Me.txt_price.TabIndex = 7
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(490, 480)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(380, 20)
        Me.txt_name.TabIndex = 8
        '
        'txt_condition
        '
        Me.txt_condition.Location = New System.Drawing.Point(490, 609)
        Me.txt_condition.Name = "txt_condition"
        Me.txt_condition.Size = New System.Drawing.Size(380, 20)
        Me.txt_condition.TabIndex = 9
        '
        'txt_region
        '
        Me.txt_region.Location = New System.Drawing.Point(490, 532)
        Me.txt_region.Name = "txt_region"
        Me.txt_region.Size = New System.Drawing.Size(380, 20)
        Me.txt_region.TabIndex = 10
        '
        'txt_year
        '
        Me.txt_year.Location = New System.Drawing.Point(490, 558)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(380, 20)
        Me.txt_year.TabIndex = 11
        '
        'txt_era
        '
        Me.txt_era.Location = New System.Drawing.Point(490, 583)
        Me.txt_era.Name = "txt_era"
        Me.txt_era.Size = New System.Drawing.Size(380, 20)
        Me.txt_era.TabIndex = 12
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_id.Location = New System.Drawing.Point(446, 454)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(27, 19)
        Me.lbl_id.TabIndex = 13
        Me.lbl_id.Text = "ID"
        '
        'lbl_condition
        '
        Me.lbl_condition.AutoSize = True
        Me.lbl_condition.BackColor = System.Drawing.Color.Transparent
        Me.lbl_condition.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_condition.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_condition.Location = New System.Drawing.Point(400, 613)
        Me.lbl_condition.Name = "lbl_condition"
        Me.lbl_condition.Size = New System.Drawing.Size(73, 19)
        Me.lbl_condition.TabIndex = 14
        Me.lbl_condition.Text = "Condition"
        '
        'lbl_era
        '
        Me.lbl_era.AutoSize = True
        Me.lbl_era.BackColor = System.Drawing.Color.Transparent
        Me.lbl_era.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_era.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_era.Location = New System.Drawing.Point(440, 584)
        Me.lbl_era.Name = "lbl_era"
        Me.lbl_era.Size = New System.Drawing.Size(33, 19)
        Me.lbl_era.TabIndex = 15
        Me.lbl_era.Text = "Era"
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.BackColor = System.Drawing.Color.Transparent
        Me.lbl_year.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_year.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_year.Location = New System.Drawing.Point(434, 562)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(39, 19)
        Me.lbl_year.TabIndex = 16
        Me.lbl_year.Text = "Year"
        '
        'lbl_region
        '
        Me.lbl_region.AutoSize = True
        Me.lbl_region.BackColor = System.Drawing.Color.Transparent
        Me.lbl_region.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_region.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_region.Location = New System.Drawing.Point(419, 536)
        Me.lbl_region.Name = "lbl_region"
        Me.lbl_region.Size = New System.Drawing.Size(57, 19)
        Me.lbl_region.TabIndex = 17
        Me.lbl_region.Text = "Region"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_price.Location = New System.Drawing.Point(432, 510)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(43, 19)
        Me.lbl_price.TabIndex = 18
        Me.lbl_price.Text = "Price"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_name.Location = New System.Drawing.Point(426, 484)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(49, 19)
        Me.lbl_name.TabIndex = 19
        Me.lbl_name.Text = "Name"
        '
        'frm_productlist_a173630
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1076, 719)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_region)
        Me.Controls.Add(Me.lbl_year)
        Me.Controls.Add(Me.lbl_era)
        Me.Controls.Add(Me.lbl_condition)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_era)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_region)
        Me.Controls.Add(Me.txt_condition)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grid_products)
        Me.Controls.Add(Me.lbl_productlist)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_productlist_a173630"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCT LIST"
        CType(Me.grid_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_productlist As Label
    Friend WithEvents grid_products As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_condition As TextBox
    Friend WithEvents txt_region As TextBox
    Friend WithEvents txt_year As TextBox
    Friend WithEvents txt_era As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_condition As Label
    Friend WithEvents lbl_era As Label
    Friend WithEvents lbl_year As Label
    Friend WithEvents lbl_region As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_name As Label
End Class
