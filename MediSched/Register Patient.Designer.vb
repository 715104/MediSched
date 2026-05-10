<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_Patient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register_Patient))
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
        Label2 = New Label()
        pnlMain = New Panel()
        Panel1 = New Panel()
        lblTotalAppoinments = New Label()
        Label7 = New Label()
        Label10 = New Label()
        Panel4 = New Panel()
        lblCancelled = New Label()
        Label5 = New Label()
        Label8 = New Label()
        Panel3 = New Panel()
        lblCompleted = New Label()
        Label4 = New Label()
        Label9 = New Label()
        Panel2 = New Panel()
        lblPending = New Label()
        Label3 = New Label()
        Label6 = New Label()
        pnlNavigation.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlNavigation
        ' 
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
        pnlNavigation.Location = New Point(-5, -1)
        pnlNavigation.Name = "pnlNavigation"
        pnlNavigation.Size = New Size(192, 481)
        pnlNavigation.TabIndex = 0
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
        Label11.Location = New Point(-1, 64)
        Label11.Name = "Label11"
        Label11.Size = New Size(202, 15)
        Label11.TabIndex = 16
        Label11.Text = "_______________________________________"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.Font = New Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(23, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 25)
        Label2.TabIndex = 11
        Label2.Text = "Overview"
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.WhiteSmoke
        pnlMain.Controls.Add(Panel1)
        pnlMain.Controls.Add(Panel4)
        pnlMain.Controls.Add(Panel3)
        pnlMain.Controls.Add(Panel2)
        pnlMain.Controls.Add(Label2)
        pnlMain.Location = New Point(188, -4)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(621, 481)
        pnlMain.TabIndex = 12
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(lblTotalAppoinments)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label10)
        Panel1.Location = New Point(48, 82)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(234, 151)
        Panel1.TabIndex = 17
        ' 
        ' lblTotalAppoinments
        ' 
        lblTotalAppoinments.AutoSize = True
        lblTotalAppoinments.Font = New Font("Bahnschrift", 39.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalAppoinments.ForeColor = Color.DarkBlue
        lblTotalAppoinments.Location = New Point(12, 46)
        lblTotalAppoinments.Name = "lblTotalAppoinments"
        lblTotalAppoinments.Size = New Size(56, 64)
        lblTotalAppoinments.TabIndex = 12
        lblTotalAppoinments.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Bahnschrift SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DimGray
        Label7.Location = New Point(3, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 13)
        Label7.TabIndex = 11
        Label7.Text = "Total Appointments"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.ForeColor = SystemColors.ControlDark
        Label10.Location = New Point(4, 17)
        Label10.Name = "Label10"
        Label10.Size = New Size(227, 15)
        Label10.TabIndex = 15
        Label10.Text = "____________________________________________"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(lblCancelled)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(327, 278)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(234, 152)
        Panel4.TabIndex = 16
        ' 
        ' lblCancelled
        ' 
        lblCancelled.AutoSize = True
        lblCancelled.Font = New Font("Bahnschrift", 39.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCancelled.ForeColor = Color.Crimson
        lblCancelled.Location = New Point(12, 55)
        lblCancelled.Name = "lblCancelled"
        lblCancelled.Size = New Size(56, 64)
        lblCancelled.TabIndex = 14
        lblCancelled.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Bahnschrift SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(3, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 13)
        Label5.TabIndex = 13
        Label5.Text = "Cancelled"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = SystemColors.ControlDark
        Label8.Location = New Point(3, 17)
        Label8.Name = "Label8"
        Label8.Size = New Size(227, 15)
        Label8.TabIndex = 15
        Label8.Text = "____________________________________________"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(lblCompleted)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label9)
        Panel3.Location = New Point(48, 278)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(234, 152)
        Panel3.TabIndex = 15
        ' 
        ' lblCompleted
        ' 
        lblCompleted.AutoSize = True
        lblCompleted.Font = New Font("Bahnschrift", 39.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCompleted.ForeColor = Color.DarkBlue
        lblCompleted.Location = New Point(12, 55)
        lblCompleted.Name = "lblCompleted"
        lblCompleted.Size = New Size(56, 64)
        lblCompleted.TabIndex = 13
        lblCompleted.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Bahnschrift SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(3, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 13)
        Label4.TabIndex = 12
        Label4.Text = "Completed"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = SystemColors.ControlDark
        Label9.Location = New Point(3, 17)
        Label9.Name = "Label9"
        Label9.Size = New Size(227, 15)
        Label9.TabIndex = 15
        Label9.Text = "____________________________________________"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(lblPending)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(327, 82)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(234, 153)
        Panel2.TabIndex = 14
        ' 
        ' lblPending
        ' 
        lblPending.AutoSize = True
        lblPending.Font = New Font("Bahnschrift", 39.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPending.ForeColor = Color.DarkBlue
        lblPending.Location = New Point(12, 46)
        lblPending.Name = "lblPending"
        lblPending.Size = New Size(56, 64)
        lblPending.TabIndex = 12
        lblPending.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bahnschrift SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(3, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 13)
        Label3.TabIndex = 11
        Label3.Text = "Pending"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = SystemColors.ControlDark
        Label6.Location = New Point(3, 17)
        Label6.Name = "Label6"
        Label6.Size = New Size(227, 15)
        Label6.TabIndex = 14
        Label6.Text = "____________________________________________"
        ' 
        ' Register_Patient
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(804, 477)
        Controls.Add(pnlMain)
        Controls.Add(pnlNavigation)
        Name = "Register_Patient"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register_Patient"
        pnlNavigation.ResumeLayout(False)
        pnlNavigation.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlNavigation As Panel
    Friend WithEvents MediSched As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnReport As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnPatients As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotalAppoinments As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblCancelled As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCompleted As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblPending As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
End Class
