Imports System.Diagnostics.Eventing.Reader
Imports System.Runtime.ConstrainedExecution

Public Class Logout
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelLogout.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFinalLogout.Click
        Me.Close()
        Register_Patient.Hide()
        Register_Patient_2.Hide()
        Register_Patient_3.Hide()
        Add_Patient.Hide()
        Update_Patient.Hide()
        Form1.Show()

        Form1.txtUsername.Text = "Username"
        Form1.txtUsername.ForeColor = Color.Gray

        Form1.txtPassword.UseSystemPasswordChar = False
        Form1.txtPassword.Text = "Password"
        Form1.txtPassword.ForeColor = Color.Gray
    End Sub
End Class