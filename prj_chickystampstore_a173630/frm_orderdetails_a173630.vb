Public Class frm_orderdetails_a173630
    Private Sub frm_orderdetailslist_a173630_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT *  FROM TBL_ORDER_DETAILS_A173630"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grid_orderdetails.DataSource = mydatatable

        grid_orderdetails.Columns(0).HeaderText = "Order ID"
        grid_orderdetails.Columns(1).HeaderText = "Product ID"
        grid_orderdetails.Columns(2).HeaderText = "Quantity"
        grid_orderdetails.Columns(3).HeaderText = "Price"

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a173630.Show()
        Me.Close()

    End Sub

    Private Sub frm_orderdetailslist_a173630_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frm_mainmenu_a173630.Show()

    End Sub
End Class