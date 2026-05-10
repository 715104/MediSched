<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Patient
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
        cmbStatus = New ComboBox()
        Label5 = New Label()
        btnConfirm = New Button()
        dtpSchedule = New DateTimePicker()
        Label4 = New Label()
        Label1 = New Label()
        txtPatientContact = New TextBox()
        Label2 = New Label()
        txtPatientName = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' cmbStatus
        ' 
        cmbStatus.DisplayMember = "Pending"
        cmbStatus.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Pending"})
        cmbStatus.Location = New Point(19, 242)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(131, 24)
        cmbStatus.TabIndex = 35
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(18, 225)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 14)
        Label5.TabIndex = 33
        Label5.Text = "Status"
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.MidnightBlue
        btnConfirm.FlatAppearance.BorderColor = Color.White
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfirm.ForeColor = Color.White
        btnConfirm.Location = New Point(68, 280)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(114, 26)
        btnConfirm.TabIndex = 26
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' dtpSchedule
        ' 
        dtpSchedule.CalendarFont = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpSchedule.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpSchedule.Location = New Point(19, 189)
        dtpSchedule.Name = "dtpSchedule"
        dtpSchedule.Size = New Size(232, 23)
        dtpSchedule.TabIndex = 34
        dtpSchedule.Value = New Date(2026, 4, 25, 14, 15, 54, 0)
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(18, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 14)
        Label4.TabIndex = 30
        Label4.Text = "Schedule of Appointment"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(18, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 14)
        Label1.TabIndex = 29
        Label1.Text = "Contact Information"
        ' 
        ' txtPatientContact
        ' 
        txtPatientContact.BackColor = Color.WhiteSmoke
        txtPatientContact.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPatientContact.ForeColor = Color.DarkGray
        txtPatientContact.Location = New Point(18, 134)
        txtPatientContact.Name = "txtPatientContact"
        txtPatientContact.Size = New Size(219, 22)
        txtPatientContact.TabIndex = 33
        txtPatientContact.Text = "Contact"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(19, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 14)
        Label2.TabIndex = 27
        Label2.Text = "Patient Name"
        ' 
        ' txtPatientName
        ' 
        txtPatientName.BackColor = Color.WhiteSmoke
        txtPatientName.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPatientName.ForeColor = Color.DarkGray
        txtPatientName.Location = New Point(19, 74)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(219, 22)
        txtPatientName.TabIndex = 32
        txtPatientName.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(48, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 25)
        Label3.TabIndex = 25
        Label3.Text = "Add Patient Info"
        ' 
        ' Add_Patient
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(269, 316)
        Controls.Add(cmbStatus)
        Controls.Add(Label5)
        Controls.Add(btnConfirm)
        Controls.Add(dtpSchedule)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(txtPatientContact)
        Controls.Add(Label2)
        Controls.Add(txtPatientName)
        Controls.Add(Label3)
        Name = "Add_Patient"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add_Patient"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents dtpSchedule As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPatientContact As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents Label3 As Label
End Class
