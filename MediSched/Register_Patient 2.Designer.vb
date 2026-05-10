<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_Patient_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register_Patient_2))
        pnlMain = New Panel()
        pnlFilter = New Panel()
        chkCancelled = New CheckBox()
        chkCompleted = New CheckBox()
        chkPending = New CheckBox()
        btnFilter = New Button()
        lsvPatient = New ListView()
        lsvPatientName = New ColumnHeader()
        lsvContactInfo = New ColumnHeader()
        lsvSchedule = New ColumnHeader()
        lsvStatus = New ColumnHeader()
        btnAddPatient = New Button()
        btnUpdate = New Button()
        txtSearch = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        btnSearch = New Button()
        pnlNavigation = New Panel()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        btnLogout = New Button()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        btnPatients = New Button()
        Button3 = New Button()
        PictureBox2 = New PictureBox()
        btnReport = New Button()
        PictureBox1 = New PictureBox()
        btnDashboard = New Button()
        Label1 = New Label()
        MediSched = New Label()
        Label11 = New Label()
        CheckBox1 = New CheckBox()
        pnlMain.SuspendLayout()
        pnlFilter.SuspendLayout()
        pnlNavigation.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.WhiteSmoke
        pnlMain.BorderStyle = BorderStyle.FixedSingle
        pnlMain.Controls.Add(pnlFilter)
        pnlMain.Controls.Add(btnFilter)
        pnlMain.Controls.Add(lsvPatient)
        pnlMain.Controls.Add(btnAddPatient)
        pnlMain.Controls.Add(btnUpdate)
        pnlMain.Controls.Add(txtSearch)
        pnlMain.Controls.Add(Label2)
        pnlMain.Controls.Add(Label3)
        pnlMain.Controls.Add(btnSearch)
        pnlMain.Location = New Point(192, -2)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(622, 481)
        pnlMain.TabIndex = 14
        ' 
        ' pnlFilter
        ' 
        pnlFilter.BorderStyle = BorderStyle.FixedSingle
        pnlFilter.Controls.Add(CheckBox1)
        pnlFilter.Controls.Add(chkCancelled)
        pnlFilter.Controls.Add(chkCompleted)
        pnlFilter.Controls.Add(chkPending)
        pnlFilter.Location = New Point(480, 126)
        pnlFilter.Name = "pnlFilter"
        pnlFilter.Size = New Size(116, 112)
        pnlFilter.TabIndex = 22
        pnlFilter.Visible = False
        ' 
        ' chkCancelled
        ' 
        chkCancelled.AutoSize = True
        chkCancelled.Font = New Font("Bahnschrift", 9.75F)
        chkCancelled.Location = New Point(11, 82)
        chkCancelled.Name = "chkCancelled"
        chkCancelled.Size = New Size(83, 20)
        chkCancelled.TabIndex = 2
        chkCancelled.Text = "Cancelled"
        chkCancelled.UseVisualStyleBackColor = True
        ' 
        ' chkCompleted
        ' 
        chkCompleted.AutoSize = True
        chkCompleted.Font = New Font("Bahnschrift", 9.75F)
        chkCompleted.Location = New Point(11, 56)
        chkCompleted.Name = "chkCompleted"
        chkCompleted.Size = New Size(88, 20)
        chkCompleted.TabIndex = 1
        chkCompleted.Text = "Completed"
        chkCompleted.UseVisualStyleBackColor = True
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
        ' btnAddPatient
        ' 
        btnAddPatient.BackColor = Color.MidnightBlue
        btnAddPatient.FlatAppearance.BorderColor = Color.White
        btnAddPatient.FlatStyle = FlatStyle.Flat
        btnAddPatient.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddPatient.ForeColor = Color.White
        btnAddPatient.Location = New Point(337, 399)
        btnAddPatient.Name = "btnAddPatient"
        btnAddPatient.Size = New Size(145, 37)
        btnAddPatient.TabIndex = 20
        btnAddPatient.Text = "Add Patient"
        btnAddPatient.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.MidnightBlue
        btnUpdate.FlatAppearance.BorderColor = Color.White
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(108, 399)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(145, 37)
        btnUpdate.TabIndex = 18
        btnUpdate.Text = "Update Patient"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.DarkGray
        txtSearch.Location = New Point(394, 52)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(173, 22)
        txtSearch.TabIndex = 14
        txtSearch.Text = "Search patients..."
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
        ' btnSearch
        ' 
        btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSearch.BackColor = Color.Transparent
        btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), Image)
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.Black
        btnSearch.Location = New Point(368, 52)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(22, 21)
        btnSearch.TabIndex = 16
        btnSearch.TextAlign = ContentAlignment.TopCenter
        btnSearch.UseVisualStyleBackColor = False
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
        pnlNavigation.Controls.Add(PictureBox2)
        pnlNavigation.Controls.Add(btnReport)
        pnlNavigation.Controls.Add(PictureBox1)
        pnlNavigation.Controls.Add(btnDashboard)
        pnlNavigation.Controls.Add(Label1)
        pnlNavigation.Controls.Add(MediSched)
        pnlNavigation.Controls.Add(Label11)
        pnlNavigation.ForeColor = Color.Black
        pnlNavigation.Location = New Point(-1, -2)
        pnlNavigation.Name = "pnlNavigation"
        pnlNavigation.Size = New Size(192, 481)
        pnlNavigation.TabIndex = 13
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
        PictureBox5.Location = New Point(10, 262)
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
        btnLogout.Location = New Point(10, 262)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(176, 29)
        btnLogout.TabIndex = 10
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(11, 156)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(32, 31)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(11, 154)
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
        btnPatients.Location = New Point(10, 156)
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
        Button3.Location = New Point(10, 154)
        Button3.Name = "Button3"
        Button3.Size = New Size(176, 29)
        Button3.TabIndex = 8
        Button3.Text = "Patients"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(11, 209)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(32, 31)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' btnReport
        ' 
        btnReport.FlatAppearance.BorderColor = Color.White
        btnReport.FlatStyle = FlatStyle.Flat
        btnReport.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReport.ForeColor = Color.Gray
        btnReport.Location = New Point(11, 209)
        btnReport.Name = "btnReport"
        btnReport.Size = New Size(176, 29)
        btnReport.TabIndex = 6
        btnReport.Text = "Reports"
        btnReport.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(10, 104)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 31)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.FlatAppearance.BorderColor = Color.White
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.Gray
        btnDashboard.Location = New Point(10, 106)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(176, 29)
        btnDashboard.TabIndex = 4
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bahnschrift SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(11, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 13)
        Label1.TabIndex = 3
        Label1.Text = " CLINIC ADMIN"
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
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Bahnschrift", 9.75F)
        CheckBox1.Location = New Point(11, 32)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(78, 20)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Accepted"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Register_Patient_2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(804, 477)
        Controls.Add(pnlMain)
        Controls.Add(pnlNavigation)
        Name = "Register_Patient_2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register_Patient_2"
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
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlNavigation As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnPatients As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnReport As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MediSched As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvPatientData As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAddPatient As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents pnlFilter As Panel
    Friend WithEvents chkCancelled As CheckBox
    Friend WithEvents chkCompleted As CheckBox
    Friend WithEvents chkPending As CheckBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents lsvPatient As ListView
    Friend WithEvents lsvPatientName As ColumnHeader
    Friend WithEvents lsvContactInfo As ColumnHeader
    Friend WithEvents lsvSchedule As ColumnHeader
    Friend WithEvents lsvStatus As ColumnHeader
    Friend WithEvents CheckBox1 As CheckBox
End Class
