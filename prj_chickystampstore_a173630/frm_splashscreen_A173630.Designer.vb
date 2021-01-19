<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_splashscreen_A173630
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_splashscreen_A173630))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_mainmenu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.Color.PeachPuff
        Me.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_title.Font = New System.Drawing.Font("Old English Text MT", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_title.Image = CType(resources.GetObject("lbl_title.Image"), System.Drawing.Image)
        Me.lbl_title.Location = New System.Drawing.Point(171, 30)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(250, 93)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Chicky Stamp Store"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_mainmenu
        '
        Me.lbl_mainmenu.AutoSize = True
        Me.lbl_mainmenu.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mainmenu.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mainmenu.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_mainmenu.Image = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.lbl_mainmenu.Location = New System.Drawing.Point(134, 155)
        Me.lbl_mainmenu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_mainmenu.Name = "lbl_mainmenu"
        Me.lbl_mainmenu.Size = New System.Drawing.Size(324, 22)
        Me.lbl_mainmenu.TabIndex = 2
        Me.lbl_mainmenu.Text = "MUHAMMAD SYAZILI BIN JUHARI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Image = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.Label1.Location = New System.Drawing.Point(256, 193)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "A173630"
        '
        'btn_start
        '
        Me.btn_start.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.background
        Me.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_start.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_start.Location = New System.Drawing.Point(254, 235)
        Me.btn_start.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(85, 41)
        Me.btn_start.TabIndex = 4
        Me.btn_start.Text = "START"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'frm_splashscreen_A173630
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_chickystampstore_a173630.My.Resources.Resources.mainmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(593, 305)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_mainmenu)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_splashscreen_A173630"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHICKY STAMP STORE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_mainmenu As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_start As Button
End Class
