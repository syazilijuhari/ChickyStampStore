Public Class frm_mainmenu_a173630


    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click

        panel_customer.Size = panel_customer.MinimumSize
        panel_staff.Size = panel_staff.MinimumSize
        panel_order.Size = panel_order.MinimumSize

        timer_btnproduct.Start()
        If Not panel_product.Height = 73 Then
            panel_product.Height = 73
        End If

    End Sub

    Private Sub timer_btnproduct_Tick(sender As Object, e As EventArgs) Handles timer_btnproduct.Tick

        panel_product.Height = 206
        timer_btnproduct.Stop()

    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click

        panel_product.Size = panel_product.MinimumSize
        panel_staff.Size = panel_staff.MinimumSize
        panel_order.Size = panel_order.MinimumSize

        timer_btncustomer.Start()
        If Not panel_customer.Height = 73 Then
            panel_customer.Height = 73
        End If

    End Sub

    Private Sub timer_btncustomer_Tick(sender As Object, e As EventArgs) Handles timer_btncustomer.Tick

        panel_customer.Height = 206
        timer_btncustomer.Stop()

    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click

        panel_product.Size = panel_product.MinimumSize
        panel_customer.Size = panel_customer.MinimumSize
        panel_order.Size = panel_order.MinimumSize

        timer_btnstaff.Start()
        If Not panel_staff.Height = 73 Then
            panel_staff.Height = 73
        End If

    End Sub

    Private Sub timer_btnstaff_Tick(sender As Object, e As EventArgs) Handles timer_btnstaff.Tick

        panel_staff.Height = 206
        timer_btnstaff.Stop()

    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click

        panel_product.Size = panel_product.MinimumSize
        panel_customer.Size = panel_customer.MinimumSize
        panel_staff.Size = panel_staff.MinimumSize

        timer_btnorder.Start()
        If Not panel_staff.Height = 73 Then
            panel_order.Height = 73
        End If

    End Sub

    Private Sub timer_btnorder_Tick(sender As Object, e As EventArgs) Handles timer_btnorder.Tick

        panel_order.Height = 206
        timer_btnorder.Stop()

    End Sub

    Private Sub btn_productlist_Click(sender As Object, e As EventArgs) Handles btn_productlist.Click

        frm_productlist_a173630.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insertproduct_Click(sender As Object, e As EventArgs) Handles btn_insertproduct.Click

        frm_insertproduct_a173630.Show()
        Me.Hide()

    End Sub

    Private Sub btn_updateproduct_Click(sender As Object, e As EventArgs) Handles btn_updateproduct.Click

        frm_updateproduct_a173630.Show()
        Me.Hide()

    End Sub

    Private Sub btn_customerlist_Click(sender As Object, e As EventArgs) Handles btn_customerlist.Click

        frm_customerlist_a173630.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insertcustomer_Click(sender As Object, e As EventArgs) Handles btn_insertcustomer.Click

        frm_insertcustomer_a173630.Show()
        Me.Hide()

    End Sub

    Private Sub btn_updatecustomer_Click(sender As Object, e As EventArgs) Handles btn_updatecustomer.Click

        frm_updatecustomer_a173630.Show()
        Me.Hide()

    End Sub

    Private Sub btn_stafflist_Click(sender As Object, e As EventArgs) Handles btn_stafflist.Click

        frm_stafflist_a173630.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insertstaff_Click(sender As Object, e As EventArgs) Handles btn_insertstaff.Click

        frm_insertstaff_a173630.Show()
        Me.Hide()

    End Sub

    Private Sub btn_updatestaff_Click(sender As Object, e As EventArgs) Handles btn_updatestaff.Click

        frm_updatestaff_a173630.Show()
        Me.Hide()

    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click

        frm_makeorder_a173630.Show()
        Me.Hide()

    End Sub

    Private Sub btn_vieworder_Click(sender As Object, e As EventArgs) Handles btn_vieworder.Click

        frm_vieworder_a173630.Show()
        Me.Hide()

    End Sub

    Private Sub btn_orderdetails_Click(sender As Object, e As EventArgs) Handles btn_orderhistory.Click

        frm_order_a173630.Show()
        Me.Hide()

    End Sub

    Private Sub frm_mainmenu_a173630_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover

        panel_product.Size = panel_product.MinimumSize
        panel_customer.Size = panel_customer.MinimumSize
        panel_staff.Size = panel_staff.MinimumSize
        panel_order.Size = panel_order.MinimumSize

    End Sub

    Private Sub frm_mainmenu_a173630_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frm_mainmenu_a173630_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frm_splashscreen_A173630.Show()

    End Sub
End Class
