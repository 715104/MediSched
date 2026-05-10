Public Class Register_Patient_2

    Public patientName(100) As String
    Public patientContact(100) As String
    Public patientSchedule(100) As Date
    Public patientStatus(100) As String
    Public patientCount As Integer = 0
    Public selectedIndex As Integer = -1

    Public Sub LoadPatients()
        dgvPatientData.Rows.Clear()

        For i As Integer = 0 To patientCount - 1

            Dim rowIndex As Integer = dgvPatientData.Rows.Add(
            patientName(i),
            patientContact(i),
            patientSchedule(i).ToShortDateString(),
            patientStatus(i)
        )

            dgvPatientData.Rows(rowIndex).Tag = i

        Next

    End Sub


    Public Sub UpdateStatusCounts()

        Dim pending As Integer = 0
        Dim completed As Integer = 0
        Dim cancelled As Integer = 0

        For i As Integer = 0 To patientCount - 1

            Dim status As String = patientStatus(i).ToString().ToLower()

            Select Case status
                Case "pending"
                    pending += 1
                Case "completed"
                    completed += 1
                Case "cancelled"
                    cancelled += 1
            End Select

        Next

        Dim total As Integer = patientCount

        Register_Patient.lblPending.Text = pending
        Register_Patient.lblCompleted.Text = completed
        Register_Patient.lblCancelled.Text = cancelled
        Register_Patient_3.lblPending.Text = pending
        Register_Patient_3.lblCompleted.Text = completed
        Register_Patient_3.lblCancelled.Text = cancelled
        Register_Patient_3.lblTotalAppoinments.Text = total

    End Sub


    Private Sub Register_Patient_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadPatients()
        UpdateStatusCounts()

    End Sub







    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        Register_Patient.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedIndex >= 0 Then
            Update_Patient.ShowDialog()
        Else
            MessageBox.Show("Select a patient first.")
        End If
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        Add_Patient.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Me.Hide()
        Register_Patient_3.Show()
    End Sub

    Private Sub btnPatients_Click(sender As Object, e As EventArgs) Handles btnPatients.Click
        Me.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Logout.Show()
    End Sub

    Private Sub dgvPatientData_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            selectedIndex = CInt(dgvPatientData.Rows(e.RowIndex).Tag)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim keyword As String = txtSearch.Text.Trim().ToLower()
        dgvPatientData.Rows.Clear()

        If keyword = "" OrElse keyword = "search patients..." Then
            LoadPatients()
            Exit Sub
        End If

        For i As Integer = 0 To patientCount - 1

            If patientName(i).ToLower().Contains(keyword) OrElse
           patientContact(i).ToLower().Contains(keyword) OrElse
           patientStatus(i).ToLower().Contains(keyword) Then

                Dim rowIndex As Integer = dgvPatientData.Rows.Add(
                patientName(i),
                patientContact(i),
                patientSchedule(i).ToShortDateString(),
                patientStatus(i)
            )

                dgvPatientData.Rows(rowIndex).Tag = i

            End If

        Next

    End Sub



    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        pnlFilter.Visible = Not pnlFilter.Visible
    End Sub


    Public Sub FilterStatus()

        dgvPatientData.Rows.Clear()

        Dim anyChecked As Boolean =
        chkPending.Checked OrElse chkCompleted.Checked OrElse chkCancelled.Checked

        For i As Integer = 0 To patientCount - 1

            Dim status As String = patientStatus(i).ToLower()

            If Not anyChecked OrElse
           (chkPending.Checked AndAlso status = "pending") OrElse
           (chkCompleted.Checked AndAlso status = "completed") OrElse
           (chkCancelled.Checked AndAlso status = "cancelled") Then

                Dim rowIndex As Integer = dgvPatientData.Rows.Add(
                patientName(i),
                patientContact(i),
                patientSchedule(i).ToShortDateString(),
                patientStatus(i)
            )

                dgvPatientData.Rows(rowIndex).Tag = i

            End If

        Next

    End Sub



    Private Sub chkPending_CheckedChanged(sender As Object, e As EventArgs) Handles chkPending.CheckedChanged
        FilterStatus()
    End Sub

    Private Sub chkCompleted_CheckedChanged(sender As Object, e As EventArgs) Handles chkCompleted.CheckedChanged
        FilterStatus
    End Sub

    Private Sub chkCancelled_CheckedChanged(sender As Object, e As EventArgs) Handles chkCancelled.CheckedChanged
        FilterStatus()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        If txtSearch.Text = "Search patients..." Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text.Trim() = "" Then
            txtSearch.Text = "Search patients..."
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Dim keyword As String = txtSearch.Text.Trim()

        If keyword = "" OrElse keyword = "Search patients..." Then
            LoadPatients()
        End If

    End Sub

    Private Sub dgvPatientData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class