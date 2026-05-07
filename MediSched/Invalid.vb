Public Class Invalid
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Form1.txtUsername.Text = "Username"
        Form1.txtUsername.ForeColor = Color.Gray
        Form1.txtPassword.Text = "Password"
        Form1.txtPassword.ForeColor = Color.Gray
        Form1.txtPassword.UseSystemPasswordChar = False
        Me.Hide()
    End Sub
End Class