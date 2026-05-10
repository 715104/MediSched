<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_Doctor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register_Doctor))
        pnlMain = New Panel()
        pnlFilter = New Panel()
        chkAccepted = New CheckBox()
        chkPending = New CheckBox()
        btnFilter = New Button()
        lsvPatient = New ListView()
        lsvPatientName = New ColumnHeader()
        lsvContactInfo = New ColumnHeader()
        lsvSchedule = New ColumnHeader()
        lsvStatus = New ColumnHeader()
        btnAccept = New Button()
        Label2 = New Label()
        Label3 = New Label()
        pnlNavigation = New Panel()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        btnLogout = New Button()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        btnPatients = New Button()
        Button3 = New Button()
        Label1 = New Label()
        MediSched = New Label()
        Label11 = New Label()
        pnlMain.SuspendLayout()
        pnlFilter.SuspendLayout()
        pnlNavigation.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.WhiteSmoke
        pnlMain.BorderStyle = BorderStyle.FixedSingle
        pnlMain.Controls.Add(pnlFilter)
        pnlMain.Controls.Add(btnFilter)
        pnlMain.Controls.Add(lsvPatient)
        pnlMain.Controls.Add(btnAccept)
        pnlMain.Controls.Add(Label2)
        pnlMain.Controls.Add(Label3)
        pnlMain.Location = New Point(188, -2)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(622, 481)
        pnlMain.TabIndex = 16
        ' 
        ' pnlFilter
        ' 
        pnlFilter.BorderStyle = BorderStyle.FixedSingle
        pnlFilter.Controls.Add(chkAccepted)
        pnlFilter.Controls.Add(chkPending)
        pnlFilter.Location = New Point(480, 126)
        pnlFilter.Name = "pnlFilter"
        pnlFilter.Size = New Size(116, 74)
        pnlFilter.TabIndex = 22
        pnlFilter.Visible = False
        ' 
        ' chkAccepted
        ' 
        chkAccepted.AutoSize = True
        chkAccepted.Font = New Font("Bahnschrift", 9.75F)
        chkAccepted.Location = New Point(11, 38)
        chkAccepted.Name = "chkAccepted"
        chkAccepted.Size = New Size(78, 20)
        chkAccepted.TabIndex = 2
        chkAccepted.Text = "Accepted"
        chkAccepted.UseVisualStyleBackColor = True
        ' 
        ' chkPending
        ' 
        chkPending.AutoSize = True
        chkPending.Font = New Font("Bahnschrift", 9.75F)
        chkPending.Location = New Point(11, 9)
        chkPending.Name = "chkPending"
        chkPending.Size = New Size(71, 20)
        chkPending.TabIndex = 0
        chkPending.Text = "Pending"
        chkPending.UseVisualStyleBackColor = True
        ' 
        ' btnFilter
        ' 
        btnFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnFilter.BackColor = Color.White
        btnFilter.BackgroundImageLayout = ImageLayout.Stretch
        btnFilter.FlatAppearance.BorderColor = Color.White
        btnFilter.FlatStyle = FlatStyle.Flat
        btnFilter.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFilter.ForeColor = Color.Black
        btnFilter.Location = New Point(574, 107)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(22, 25)
        btnFilter.TabIndex = 21
        btnFilter.Text = "▼"
        btnFilter.TextAlign = ContentAlignment.TopCenter
        btnFilter.UseVisualStyleBackColor = False
        ' 
        ' lsvPatient
        ' 
        lsvPatient.BackColor = SystemColors.Window
        lsvPatient.Columns.AddRange(New ColumnHeader() {lsvPatientName, lsvContactInfo, lsvSchedule, lsvStatus})
        lsvPatient.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lsvPatient.ForeColor = SystemColors.MenuText
        lsvPatient.FullRowSelect = True
        lsvPatient.GridLines = True
        lsvPatient.Location = New Point(16, 104)
        lsvPatient.Name = "lsvPatient"
        lsvPatient.Size = New Size(582, 264)
        lsvPatient.TabIndex = 23
        lsvPatient.UseCompatibleStateImageBehavior = False
        lsvPatient.View = View.Details
        ' 
        ' lsvPatientName
        ' 
        lsvPatientName.Text = "Patient Name"
        lsvPatientName.Width = 180
        ' 
        ' lsvContactInfo
        ' 
        lsvContactInfo.Text = "Contact Information"
        lsvContactInfo.Width = 150
        ' 
        ' lsvSchedule
        ' 
        lsvSchedule.Text = "Schedule of Appointment"
        lsvSchedule.Width = 160
        ' 
        ' lsvStatus
        ' 
        lsvStatus.Text = "Status"
        lsvStatus.Width = 100
        ' 
        ' btnAccept
        ' 
        btnAccept.BackColor = Color.MidnightBlue
        btnAccept.FlatAppearance.BorderColor = Color.White
        btnAccept.FlatStyle = FlatStyle.Flat
        btnAccept.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAccept.ForeColor = Color.White
        btnAccept.Location = New Point(245, 400)
        btnAccept.Name = "btnAccept"
        btnAccept.Size = New Size(145, 37)
        btnAccept.TabIndex = 18
        btnAccept.Text = "Accept Patient"
        btnAccept.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bahnschrift SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(25, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 13)
        Label2.TabIndex = 13
        Label2.Text = "Manage and view all clinic patients."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(16, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(169, 25)
        Label3.TabIndex = 12
        Label3.Text = "Patient Directory"
        ' 
        ' pnlNavigation
        ' 
        pnlNavigation.BackColor = Color.White
        pnlNavigation.BorderStyle = BorderStyle.FixedSingle
        pnlNavigation.Controls.Add(PictureBox6)
        pnlNavigation.Controls.Add(PictureBox5)
        pnlNavigation.Controls.Add(btnLogout)
        pnlNavigation.Controls.Add(PictureBox4)
        pnlNavigation.Controls.Add(PictureBox3)
        pnlNavigation.Controls.Add(btnPatients)
        pnlNavigation.Controls.Add(Button3)
        pnlNavigation.Controls.Add(Label1)
        pnlNavigation.Controls.Add(MediSched)
        pnlNavigation.Controls.Add(Label11)
        pnlNavigation.ForeColor = Color.Black
        pnlNavigation.Location = New Point(-5, -2)
        pnlNavigation.Name = "pnlNavigation"
        pnlNavigation.Size = New Size(192, 481)
        pnlNavigation.TabIndex = 15
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImageLayout = ImageLayout.Center
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(118, 27)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(34, 37)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 17
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(11, 156)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(32, 31)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 9
        PictureBox5.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderColor = Color.White
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Gray
        btnLogout.Location = New Point(12, 156)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(176, 29)
        btnLogout.TabIndex = 10
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(12, 107)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(32, 31)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(12, 105)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(32, 31)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' btnPatients
        ' 
        btnPatients.FlatAppearance.BorderColor = Color.White
        btnPatients.FlatStyle = FlatStyle.Flat
        btnPatients.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPatients.ForeColor = Color.Gray
        btnPatients.Location = New Point(11, 107)
        btnPatients.Name = "btnPatients"
        btnPatients.Size = New Size(176, 29)
        btnPatients.TabIndex = 8
        btnPatients.Text = "Patients"
        btnPatients.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderColor = Color.White
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Gray
        Button3.Location = New Point(11, 105)
        Button3.Name = "Button3"
        Button3.Size = New Size(176, 29)
        Button3.TabIndex = 8
        Button3.Text = "Patients"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bahnschrift SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(11, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 13)
        Label1.TabIndex = 3
        Label1.Text = " CLINIC DOCTOR"
        ' 
        ' MediSched
        ' 
        MediSched.AutoSize = True
        MediSched.BackColor = Color.Transparent
        MediSched.Font = New Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MediSched.ForeColor = Color.DarkBlue
        MediSched.Location = New Point(11, 26)
        MediSched.Name = "MediSched"
        MediSched.Size = New Size(101, 25)
        MediSched.TabIndex = 2
        MediSched.Text = "MediSched"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.ForeColor = SystemColors.ControlDark
        Label11.Location = New Point(-8, 64)
        Label11.Name = "Label11"
        Label11.Size = New Size(202, 15)
        Label11.TabIndex = 16
        Label11.Text = "_______________________________________"
        ' 
        ' Register_Doctor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(804, 477)
        Controls.Add(pnlMain)
        Controls.Add(pnlNavigation)
        Name = "Register_Doctor"
        Text = "Register_Doctor"
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlFilter.ResumeLayout(False)
        pnlFilter.PerformLayout()
        pnlNavigation.ResumeLayout(False)
        pnlNavigation.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlFilter As Panel
    Friend WithEvents chkPending As CheckBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents lsvPatient As ListView
    Friend WithEvents lsvPatientName As ColumnHeader
    Friend WithEvents lsvContactInfo As ColumnHeader
    Friend WithEvents lsvSchedule As ColumnHeader
    Friend WithEvents lsvStatus As ColumnHeader
    Friend WithEvents btnAccept As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlNavigation As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnPatients As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MediSched As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents chkAccepted As CheckBox
End Class
