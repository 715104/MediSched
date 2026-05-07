Public Class Add_Patient
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If txtPatientName.Text.Trim() = "" OrElse txtPatientName.Text = "Name" Then
            MessageBox.Show("Please enter patient name.")
            Exit Sub
        End If

        If txtPatientContact.Text.Trim() = "" OrElse txtPatientContact.Text = "Contact" Then
            MessageBox.Show("Please enter contact number.")
            Exit Sub
        End If

        If Not IsNumeric(txtPatientContact.Text) Then
            MessageBox.Show("Contact information must contain numbers only.")
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

            Register_Patient_2.patientName(Register_Patient_2.patientCount) = txtPatientName.Text
            Register_Patient_2.patientContact(Register_Patient_2.patientCount) = txtPatientContact.Text
            Register_Patient_2.patientSchedule(Register_Patient_2.patientCount) = dtpSchedule.Value
            Register_Patient_2.patientStatus(Register_Patient_2.patientCount) = cmbStatus.Text

            Register_Patient_2.patientCount += 1

            Register_Patient_2.LoadPatients()
            Register_Patient_2.UpdateStatusCounts()

            MessageBox.Show("Added Successfully")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
    End Sub



    Private Sub txtPatientName_GotFocus(sender As Object, e As EventArgs) Handles txtPatientName.GotFocus
        If txtPatientName.Text.Trim() = "Name" Then
            txtPatientName.Text = ""
            txtPatientName.ForeColor = Color.Black
        End If
    End Sub



    Private Sub txtPatientContact_GotFocus(sender As Object, e As EventArgs) Handles txtPatientContact.GotFocus
        If txtPatientContact.Text.Trim() = "Contact" Then
            txtPatientContact.Text = ""
            txtPatientContact.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPatientName_Leave(sender As Object, e As EventArgs) Handles txtPatientName.Leave
        If txtPatientName.Text.Trim() = "" Then
            txtPatientName.Text = "Name"
            txtPatientName.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtPatientContact_Leave(sender As Object, e As EventArgs) Handles txtPatientContact.Leave
        If txtPatientContact.Text.Trim() = "" Then
            txtPatientContact.Text = "Contact"
            txtPatientContact.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Add_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class