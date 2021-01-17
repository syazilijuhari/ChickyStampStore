Public Class frm_customerlist_a173630
    Private Sub frm_customerlist_a173630_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT *  FROM TBL_CUSTOMER_A173630 ORDER BY FLD_CUSTOMER_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grid_customers.DataSource = mydatatable

        grid_customers.Columns(0).HeaderText = "ID"
        grid_customers.Columns(1).HeaderText = "Name"
        grid_customers.Columns(2).HeaderText = "Phone No"

    End Sub

    Private Sub grid_customers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_customers.CellContentClick

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a173630.Show()
        Me.Close()

    End Sub

    Private Sub frm_customerlist_a173630_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frm_mainmenu_a173630.Show()

    End Sub
End Class