Public Class frm_updatestaff_a173630

    Dim current_id As String

    Private Sub frm_updatestaff_a173630_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()
        get_current_id()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A173630 ORDER BY FLD_STAFF_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grid_staff.DataSource = mydatatable

        grid_staff.Columns(0).HeaderText = "ID"
        grid_staff.Columns(1).HeaderText = "Name"
        grid_staff.Columns(2).HeaderText = "Phone No"

    End Sub

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_phone.Text = ""

    End Sub

    Private Sub get_current_id()
        Dim current_row As Integer = grid_staff.CurrentRow.Index
        current_id = grid_staff(0, current_row).Value
        txt_id.Text = current_id
        txt_name.Text = grid_staff(1, current_row).Value
        txt_phone.Text = grid_staff(2, current_row).Value

    End Sub

    Private Sub grid_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_staff.CellClick

        get_current_id()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_STAFF_A173630 SET FLD_STAFF_NAME='" & txt_name.Text & "', FLD_STAFF_PHONE='" & txt_phone.Text & "' WHERE FLD_STAFF_ID='" & current_id & "'")
        Beep()
        MsgBox("You have successfully updated the staff """ & current_id & """.")
        refresh_grid()
        clear_fields()
        get_current_id()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff """ & current_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_STAFF_A173630 WHERE FLD_STAFF_ID='" & current_id & "'")

            Beep()
            MsgBox("The staff """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()
        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a173630.Show()
        Me.Close()

    End Sub

    Private Sub frm_updatestaff_a173630_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frm_mainmenu_a173630.Show()

    End Sub
End Class