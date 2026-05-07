<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        btnLogin = New Button()
        txtPassword = New TextBox()
        Label3 = New Label()
        txtUsername = New TextBox()
        Label2 = New Label()
        MediSched = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label4 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(260, 161)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(282, 254)
        Panel1.TabIndex = 0
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.HotTrack
        btnLogin.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(22, 177)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(232, 35)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Login →"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.WhiteSmoke
        txtPassword.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.DarkGray
        txtPassword.Location = New Point(21, 119)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(231, 22)
        txtPassword.TabIndex = 9
        txtPassword.Text = " Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(21, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 14)
        Label3.TabIndex = 7
        Label3.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.WhiteSmoke
        txtUsername.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.DarkGray
        txtUsername.Location = New Point(22, 48)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(231, 22)
        txtUsername.TabIndex = 8
        txtUsername.Text = " Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(21, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 14)
        Label2.TabIndex = 5
        Label2.Text = "Username"
        ' 
        ' MediSched
        ' 
        MediSched.AutoSize = True
        MediSched.BackColor = Color.Transparent
        MediSched.Font = New Font("Bahnschrift SemiCondensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MediSched.ForeColor = Color.White
        MediSched.Location = New Point(335, 83)
        MediSched.Name = "MediSched"
        MediSched.Size = New Size(130, 33)
        MediSched.TabIndex = 1
        MediSched.Text = "MediSched"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(325, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 14)
        Label1.TabIndex = 2
        Label1.Text = "Clinic Appointment System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(21, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(34, 37)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(358, 29)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(77, 51)
        Panel2.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Gainsboro
        Label4.Location = New Point(305, 440)
        Label4.Name = "Label4"
        Label4.Size = New Size(193, 14)
        Label4.TabIndex = 5
        Label4.Text = "@2026 Clinic Appointment System."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(804, 477)
        Controls.Add(Label4)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(MediSched)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MediSched As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label

End Class
