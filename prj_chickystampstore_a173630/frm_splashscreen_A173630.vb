Public Class frm_splashscreen_A173630

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        frm_mainmenu_a173630.Show()
        Me.Hide()

    End Sub

    Private Sub frm_splashscreen_A173630_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frm_splashscreen_A173630_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frm_mainmenu_a173630.Show()

    End Sub
End Class