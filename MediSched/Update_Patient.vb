Public Class Update_Patient


    Private Sub Update_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = Register_Patient_2.selectedIndex

        If i < 0 OrElse i >= Register_Patient_2.patientCount Then
            MessageBox.Show("No patient selected.")
            Me.Close()
            Exit Sub
        End If

        txtPatientName.Text = Register_Patient_2.patientName(i)
        txtPatientContact.Text = Register_Patient_2.patientContact(i)
        dtpSchedule.Value = Register_Patient_2.patientSchedule(i)
        cmbStatus.Text = Register_Patient_2.patientStatus(i)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim i As Integer = Register_Patient_2.selectedIndex


        If i < 0 OrElse i >= Register_Patient_2.patientCount Then
            MessageBox.Show("Invalid selection.")
            Exit Sub
        End If


        If txtPatientName.Text.Trim() = "" Then
            MessageBox.Show("Please enter patient name.")
            Exit Sub
        End If


        If txtPatientContact.Text.Trim() = "" Then
            MessageBox.Show("Contact information must contain numbers only.")
            Exit Sub
        End If

        If Not IsNumeric(txtPatientContact.Text) Then
            MessageBox.Show("Please enter contact number.")
            Exit Sub
        End If

        If txtPatientContact.Text.Length < 10 Or txtPatientContact.Text.Length > 11 Then
            MessageBox.Show("Invalid contact number length.")
            Exit Sub
        End If

        If cmbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select status.")
            Exit Sub
        End If

        Try

            Register_Patient_2.patientName(i) = txtPatientName.Text
            Register_Patient_2.patientContact(i) = txtPatientContact.Text
            Register_Patient_2.patientSchedule(i) = dtpSchedule.Value
            Register_Patient_2.patientStatus(i) = cmbStatus.Text

            Register_Patient_2.LoadPatients()
            Register_Patient_2.UpdateStatusCounts()

            MessageBox.Show("Updated Successfully")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        End Try

    End Sub


End Class