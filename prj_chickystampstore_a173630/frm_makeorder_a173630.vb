Public Class frm_makeorder_a173630

    Dim num As Integer
    Dim price As Double
    Dim current_date As String
    Dim current_order_id

    Private Sub frm_makeorder_a173630_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A173630 ORDER BY FLD_PRODUCT_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        get_staff_id()
        txt_orderid.Text = generate_id()

        refresh_grid_cust()
        get_cust_info()
        current_date = Date.Today
        txt_date.Text = current_date

        lb_productid.DataSource = mydatatable
        lb_productid.DisplayMember = "FLD_PRODUCT_ID"

        get_product(lb_productid.Text)

        num_quantity.Value = 0

        refresh_grid_cart()

    End Sub

    Private Sub clear_fields()

        txt_orderquantity.Text = ""
        txt_subtotal.Text = ""
        num_quantity.Value = 0

    End Sub

    Private Sub get_staff_id()

        Dim mysql As String = "SELECT *  FROM TBL_STAFF_A173630 ORDER BY FLD_STAFF_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        cb_staffid.DataSource = mydatatable
        cb_staffid.DisplayMember = "FLD_STAFF_ID"

    End Sub

    Private Function generate_id() As String

        Try

            Dim lastID As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A173630").Rows(0).Item("LASTID")
            Dim newID As String = "OID" & Mid(lastID, 4) + 1
            Return newID

        Catch ex As Exception

            Return "OID1"

        End Try

    End Function

    Private Sub refresh_grid_cust()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A173630 ORDER BY FLD_CUSTOMER_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grid_customers.DataSource = mydatatable

        grid_customers.Columns(0).HeaderText = "ID"
        grid_customers.Columns(1).HeaderText = "Name"
        grid_customers.Columns(2).HeaderText = "Phone No"

    End Sub

    Private Sub get_cust_info()

        Dim current_row As Integer = grid_customers.CurrentRow.Index
        current_order_id = grid_customers(0, current_row).Value
        txt_custid.Text = current_order_id
        txt_customername.Text = grid_customers(1, current_row).Value

        grid_cart.Rows.Clear()

    End Sub

    Private Sub grid_customers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_customers.CellClick

        get_cust_info()

    End Sub

    Private Sub get_product(id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A173630 WHERE FLD_PRODUCT_ID = '" & id & "'"
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

        txt_productprice.Text = txt_price.Text
        txt_orderquantity.Text = num_quantity.Value
        txt_subtotal.Text = num * price

        clear_fields()

        Try

            pic_product.BackgroundImage = Image.FromFile("pictures/" & id & ".jpg")

        Catch ex As Exception

            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

        End Try

    End Sub
    Private Sub lb_productid_MouseClick(sender As Object, e As MouseEventArgs) Handles lb_productid.MouseClick

        get_product(lb_productid.Text)

    End Sub

    Private Sub num_quantity_ValueChanged(sender As Object, e As EventArgs) Handles num_quantity.ValueChanged

        num = num_quantity.Value
        txt_orderquantity.Text = num_quantity.Value
        price = txt_price.Text
        txt_subtotal.Text = num * price

    End Sub

    Private Sub num_quantity_KeyUp(sender As Object, e As KeyEventArgs) Handles num_quantity.KeyUp

        num = num_quantity.Value
        txt_orderquantity.Text = num_quantity.Value
        price = txt_price.Text
        txt_subtotal.Text = num * price

    End Sub

    Private Sub btn_addtocart_Click(sender As Object, e As EventArgs) Handles btn_addtocart.Click

        For Each row As DataGridViewRow In grid_cart.Rows
            If (row.Cells(0).Value = txt_orderid.Text And row.Cells(1).Value = txt_id.Text) Then
                row.Cells(2).Value = Val(row.Cells(2).Value) + num_quantity.Value
                row.Cells(3).Value = row.Cells(2).Value * txt_price.Text
                txt_totalprice.Text = Val(txt_subtotal.Text) + Val(txt_totalprice.Text)
                num_quantity.Value = 0
                txt_subtotal.Text = ""
                txt_productprice.Text = ""
                Return

            End If

        Next

        grid_cart.Rows.Add(txt_orderid.Text, txt_id.Text, num_quantity.Value, txt_subtotal.Text)
        txt_totalprice.Text = Val(txt_subtotal.Text) + Val(txt_totalprice.Text)
        num_quantity.Value = 0
        txt_subtotal.Text = ""
        txt_productprice.Text = ""

    End Sub

    Private Sub refresh_grid_cart()

        grid_cart.ColumnCount = 4
        grid_cart.Columns(0).HeaderText = "Order ID"
        grid_cart.Columns(1).HeaderText = "Product ID"
        grid_cart.Columns(2).HeaderText = "Quantity"
        grid_cart.Columns(3).HeaderText = "Price (RM)"

    End Sub

    Private Sub btn_removeitem_Click(sender As Object, e As EventArgs) Handles btn_removeitem.Click

        Try

            Dim i As Integer = grid_cart.SelectedRows(0).Index
            txt_totalprice.Text = Val(txt_totalprice.Text) - Val(grid_cart.Rows(i).Cells(3).Value)
            grid_cart.Rows.RemoveAt(i)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_confirmorder_Click(sender As Object, e As EventArgs) Handles btn_confirmorder.Click

        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction

        Try

            Dim orderid As String = txt_orderid.Text
            Dim orderdate As String = Date.Today
            Dim customerid As String = txt_custid.Text
            Dim staffid As String = cb_staffid.Text

            Dim mysql As String = "INSERT INTO TBL_ORDER_A173630(FLD_ORDER_ID, FLD_ORDER_DATE, FLD_CUSTOMER_ID, FLD_STAFF_ID) VALUES ('" & orderid & "', '" & orderdate & "', '" & customerid & "', '" & staffid & "')"
            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
            mywriter.ExecuteNonQuery()

            For i As Integer = 0 To grid_cart.RowCount - 1
                Dim orderid_details As String = grid_cart(0, i).Value
                Dim productid_details As String = grid_cart(1, i).Value
                Dim quantity_details As String = grid_cart(2, i).Value
                Dim price_details As String = grid_cart(3, i).Value

                Dim mysql2 As String = "INSERT INTO TBL_ORDER_DETAILS_A173630 VALUES ('" & orderid_details & "', '" & productid_details & "' , '" & quantity_details & "', '" & price_details & "')"
                Dim mywriter2 As New OleDb.OleDbCommand(mysql2, myconnection2, mytransaction)
                mywriter2.ExecuteNonQuery()

            Next

            mytransaction.Commit()
            myconnection2.Close()

            Beep()
            MsgBox("Order received!")
            grid_cart.Rows.Clear()

            txt_orderid.Text = generate_id()

        Catch ex As Exception

            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()

        End Try

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a173630.Show()
        Me.Close()

    End Sub

    Private Sub frm_makeorder_a173630_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frm_mainmenu_a173630.Show()

    End Sub

End Class