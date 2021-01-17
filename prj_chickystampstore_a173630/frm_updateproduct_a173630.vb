Public Class frm_updateproduct_a173630

    Dim current_id As String

    Private Sub frm_updateproduct_a173630_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()
        get_current_id()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A173630 ORDER BY FLD_PRODUCT_ID ASC"
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

    Private Sub display_pic(id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A173630 WHERE FLD_PRODUCT_ID ='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)


        Try
            pic_product.BackgroundImage = SafeImageFromFile("pictures/" & id & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = SafeImageFromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_region.Text = ""
        txt_year.Text = ""
        txt_era.Text = ""
        txt_condition.Text = ""

    End Sub

    Private Sub get_current_id()
        Dim current_row As Integer = grid_products.CurrentRow.Index
        current_id = grid_products(0, current_row).Value
        txt_id.Text = current_id
        txt_name.Text = grid_products(1, current_row).Value
        txt_price.Text = grid_products(2, current_row).Value
        txt_region.Text = grid_products(3, current_row).Value
        txt_year.Text = grid_products(4, current_row).Value
        txt_era.Text = grid_products(5, current_row).Value
        txt_condition.Text = grid_products(6, current_row).Value

    End Sub

    Private Sub grid_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_products.CellClick

        get_current_id()

        Try
            Dim value As String = grid_products.Rows(e.RowIndex).Cells(0).Value.ToString
            If IsDBNull(value) Then

            Else
                display_pic(value)

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_PRODUCTS_A173630 SET FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRICE='" & txt_price.Text & "', FLD_REGION='" & txt_region.Text & "', FLD_YEAR='" & txt_year.Text & "', FLD_ERA='" & txt_era.Text & "', FLD_CONDITION='" & txt_condition.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
        Beep()
        MsgBox("You have successfully updated the product """ & current_id & """.")
        refresh_grid()
        clear_fields()
        get_current_id()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then


            pic_product.BackgroundImage = Nothing
            My.Computer.FileSystem.DeleteFile("pictures\" & txt_id.Text & ".jpg")

            run_sql_command("DELETE FROM TBL_PRODUCTS_A173630 WHERE FLD_PRODUCT_ID='" & current_id & "'")
            Beep()
            MsgBox("The product """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()
        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a173630.Show()
        Me.Close()

    End Sub

    Private Sub frm_updateproduct_a173630_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frm_mainmenu_a173630.Show()

    End Sub
End Class