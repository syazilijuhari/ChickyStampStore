﻿Public Class frm_insertstaff_a173630
    Private Sub fm_insertstaff_a173630_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grid_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A173630 ORDER BY FLD_STAFF_ID ASC")

        txt_id.Text = generate_id()
        txt_name.Text = ""
        txt_phone.Text = ""

        grid_staff.Columns(0).HeaderText = "ID"
        grid_staff.Columns(1).HeaderText = "Name"
        grid_staff.Columns(2).HeaderText = "Phone No"

    End Sub

    Private Function generate_id() As String

        Dim lastID As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A173630").Rows(0).Item("LASTID")
        Dim newID As String = "SS0" & Mid(lastID, 4) + 1
        Return newID

    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_STAFF_A173630 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_phone.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            grid_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A173630 ORDER BY FLD_STAFF_ID ASC")
            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_phone.Text = ""

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

    Private Sub frm_insertstaff_a173630_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frm_mainmenu_a173630.Show()

    End Sub
End Class