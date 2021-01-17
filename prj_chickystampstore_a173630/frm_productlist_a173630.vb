Public Class frm_productlist_a173630
    Private Sub frm_productlist_a173630_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT *  FROM TBL_PRODUCTS_A173630 ORDER BY FLD_PRODUCT_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grid_products.DataSource = mydatatable

        grid_products.Columns(0).HeaderText = "ID"
        grid_products.Columns(1).HeaderText = "Name"
        grid_products.Columns(2).HeaderText = "Price"
        grid_products.Columns(3).HeaderText = "Region"
        grid_products.Columns(4).HeaderText = "Year"
        grid_products.Columns(5).HeaderText = "Era"
        grid_products.Columns(6).HeaderText = "Condition"

    End Sub

    Private Sub refresh_grid(id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A173630 WHERE FLD_PRODUCT_ID ='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_region.Text = mydatatable.Rows(0).Item("FLD_REGION")
        txt_year.Text = mydatatable.Rows(0).Item("FLD_YEAR")
        txt_era.Text = mydatatable.Rows(0).Item("FLD_ERA")
        txt_condition.Text = mydatatable.Rows(0).Item("FLD_CONDITION")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & id & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try


    End Sub

    Private Sub grid_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_products.CellClick

        Try
            Dim value As String = grid_products.Rows(e.RowIndex).Cells(0).Value.ToString
            If IsDBNull(value) Then

            Else
                refresh_grid(value)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a173630.Show()
        Me.Close()

    End Sub

    Private Sub frm_productlist_a173630_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frm_mainmenu_a173630.Show()

    End Sub
End Class