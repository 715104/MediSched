<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Patient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label3 = New Label()
        txtPatientName = New TextBox()
        Label2 = New Label()
        txtPatientContact = New TextBox()
        Label1 = New Label()
        Label4 = New Label()
        dtpSchedule = New DateTimePicker()
        btnUpdate = New Button()
        Label5 = New Label()
        cmbStatus = New ComboBox()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(39, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(190, 25)
        Label3.TabIndex = 13
        Label3.Text = "Update Patient Info"
        ' 
        ' txtPatientName
        ' 
        txtPatientName.BackColor = Color.WhiteSmoke
        txtPatientName.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPatientName.ForeColor = Color.Black
        txtPatientName.Location = New Point(26, 72)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(219, 22)
        txtPatientName.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(26, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 14)
        Label2.TabIndex = 15
        Label2.Text = "Patient Name"
        ' 
        ' txtPatientContact
        ' 
        txtPatientContact.BackColor = Color.WhiteSmoke
        txtPatientContact.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPatientContact.ForeColor = Color.Black
        txtPatientContact.Location = New Point(25, 132)
        txtPatientContact.Name = "txtPatientContact"
        txtPatientContact.Size = New Size(219, 22)
        txtPatientContact.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(25, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 14)
        Label1.TabIndex = 17
        Label1.Text = "Contact Information"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(25, 170)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 14)
        Label4.TabIndex = 19
        Label4.Text = "Schedule of Appointment"
        ' 
        ' dtpSchedule
        ' 
        dtpSchedule.CalendarFont = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpSchedule.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpSchedule.Location = New Point(26, 187)
        dtpSchedule.Name = "dtpSchedule"
        dtpSchedule.Size = New Size(232, 23)
        dtpSchedule.TabIndex = 23
        dtpSchedule.Value = New Date(2026, 4, 25, 14, 15, 54, 0)
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.MidnightBlue
        btnUpdate.FlatAppearance.BorderColor = Color.White
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(75, 278)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(114, 26)
        btnUpdate.TabIndex = 14
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(25, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 14)
        Label5.TabIndex = 23
        Label5.Text = "Status"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.DisplayMember = "Pending"
        cmbStatus.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Pending", "Completed", "Cancelled"})
        cmbStatus.Location = New Point(26, 240)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(131, 24)
        cmbStatus.TabIndex = 24
        ' 
        ' Update_Patient
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(269, 316)
        Controls.Add(cmbStatus)
        Controls.Add(Label5)
        Controls.Add(btnUpdate)
        Controls.Add(dtpSchedule)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(txtPatientContact)
        Controls.Add(Label2)
        Controls.Add(txtPatientName)
        Controls.Add(Label3)
        Name = "Update_Patient"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Update_Patient"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPatientContact As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpSchedule As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbStatus As ComboBox
End Class
