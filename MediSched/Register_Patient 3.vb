Public Class Register_Patient_3
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        Register_Patient.Show()
    End Sub

    Private Sub btnPatients_Click(sender As Object, e As EventArgs) Handles btnPatients.Click
        Me.Hide()
        Register_Patient_2.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Logout.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Me.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblTotalAppoinments_Click(sender As Object, e As EventArgs) Handles lblTotalAppoinments.Click

    End Sub

    Private Sub lblPending_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblCompleted_Click(sender As Object, e As EventArgs) Handles lblCompleted.Click

    End Sub

    Private Sub lblCancelled_Click(sender As Object, e As EventArgs)

    End Sub
End Class