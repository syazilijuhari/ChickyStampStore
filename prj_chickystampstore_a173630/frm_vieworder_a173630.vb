Public Class frm_vieworder_a173630

    Dim current_orderid As String
    Dim totalprice As Double

    Private Sub frm_orderlist_a173630_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT *  FROM TBL_ORDER_A173630 ORDER BY FLD_ORDER_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lb_orderid.DataSource = mydatatable
        lb_orderid.DisplayMember = "FLD_ORDER_ID"

        refresh_text(lb_orderid.Text)

    End Sub

    Private Sub refresh_text(order_id As String)

        Dim mysql2 As DataTable = run_sql_query("SELECT * FROM TBL_ORDER_A173630 WHERE FLD_ORDER_ID = '" & order_id & "'")
        txt_custid.Text = mysql2.Rows(0).Item("FLD_CUSTOMER_ID")
        txt_staffid.Text = mysql2.Rows(0).Item("FLD_STAFF_ID")
        txt_date.Text = mysql2.Rows(0).Item("FLD_ORDER_DATE")

        Dim mysql As String = "SELECT *  FROM TBL_ORDER_DETAILS_A173630 WHERE FLD_ORDER_ID = '" & order_id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        grid_orders.DataSource = mydatatable
        grid_orders.Columns(0).HeaderText = "Order ID"
        grid_orders.Columns(1).HeaderText = "Product ID"
        grid_orders.Columns(2).HeaderText = "Quantity"
        grid_orders.Columns(3).HeaderText = "Price (RM)"

        txt_orderid.Text = order_id
        txt_totalprice.Text = ""

        If grid_orders.RowCount > 0 Then

            totalprice = 0
            For index As Integer = 0 To grid_orders.RowCount - 1
                totalprice += Convert.ToDouble(grid_orders.Rows(index).Cells(3).Value)
            Next
            txt_totalprice.Text = totalprice

        End If

    End Sub

    Private Sub lb_orderid_MouseClick(sender As Object, e As MouseEventArgs) Handles lb_orderid.MouseClick

        refresh_text(lb_orderid.Text)

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a173630.Show()
        Me.Close()

    End Sub

    Private Sub frm_orderlist_a173630_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frm_mainmenu_a173630.Show()

    End Sub

End Class