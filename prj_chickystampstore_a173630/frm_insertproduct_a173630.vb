Public Class frm_insertproduct_a173630

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_insertproduct_a173630_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grid_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A173630 ORDER BY FLD_PRODUCT_ID ASC")

        txt_id.Text = generate_id()
        txt_name.Text = ""
        txt_price.Text = ""
        txt_region.Text = ""
        txt_year.Text = ""
        txt_era.Text = ""
        txt_condition.Text = ""
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

        grid_products.Columns(0).HeaderText = "ID"
        grid_products.Columns(1).HeaderText = "Name"
        grid_products.Columns(2).HeaderText = "Price"
        grid_products.Columns(3).HeaderText = "Region"
        grid_products.Columns(4).HeaderText = "Year"
        grid_products.Columns(5).HeaderText = "Era"
        grid_products.Columns(6).HeaderText = "Condition"
    End Sub

    Private Function generate_id() As String

        Dim lastID As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A173630").Rows(0).Item("LASTID")
        Dim newID As String = "SID" & Mid(lastID, 4) + 1
        Return newID

    End Function

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A173630 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_price.Text & "', '" & txt_region.Text & "', '" & txt_year.Text & "', '" & txt_era.Text & "', '" & txt_condition.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

            grid_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A173630 ORDER BY FLD_PRODUCT_ID ASC")
            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_price.Text = ""
            txt_region.Text = ""
            txt_year.Text = ""
            txt_era.Text = ""
            txt_condition.Text = ""
            txt_picture.Text = defaultpicture

            pic_product.BackgroundImage = Image.FromFile(defaultpicture)

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a173630.Show()
        Me.Close()

    End Sub

    Private Sub lbl_id_Click(sender As Object, e As EventArgs) Handles lbl_id.Click

    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged

    End Sub

    Private Sub lbl_name_Click(sender As Object, e As EventArgs) Handles lbl_name.Click

    End Sub

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged

    End Sub

    Private Sub lbl_price_Click(sender As Object, e As EventArgs) Handles lbl_price.Click

    End Sub

    Private Sub txt_price_TextChanged(sender As Object, e As EventArgs) Handles txt_price.TextChanged

    End Sub

    Private Sub frm_insertproduct_a173630_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frm_mainmenu_a173630.Show()

    End Sub
End Class