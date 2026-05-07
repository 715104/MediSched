<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logout))
        Label1 = New Label()
        Label2 = New Label()
        btnFinalLogout = New Button()
        Label7 = New Label()
        Label3 = New Label()
        btnCancelLogout = New Button()
        PictureBox6 = New PictureBox()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 23)
        Label1.TabIndex = 0
        Label1.Text = "Logout"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 19)
        Label2.TabIndex = 1
        Label2.Text = "Please Confirm"
        ' 
        ' btnFinalLogout
        ' 
        btnFinalLogout.BackColor = Color.MidnightBlue
        btnFinalLogout.FlatAppearance.BorderColor = Color.MidnightBlue
        btnFinalLogout.FlatAppearance.BorderSize = 2
        btnFinalLogout.Font = New Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFinalLogout.ForeColor = Color.White
        btnFinalLogout.Location = New Point(12, 111)
        btnFinalLogout.Name = "btnFinalLogout"
        btnFinalLogout.Size = New Size(110, 34)
        btnFinalLogout.TabIndex = 2
        btnFinalLogout.Text = "Logout"
        btnFinalLogout.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Bahnschrift SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DimGray
        Label7.Location = New Point(12, 75)
        Label7.Name = "Label7"
        Label7.Size = New Size(306, 13)
        Label7.TabIndex = 12
        Label7.Text = "You are about to close all pages and logout from MediSched."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ButtonShadow
        Label3.Location = New Point(12, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(492, 15)
        Label3.TabIndex = 14
        Label3.Text = "_________________________________________________________________________________________________"
        ' 
        ' btnCancelLogout
        ' 
        btnCancelLogout.BackColor = Color.MidnightBlue
        btnCancelLogout.FlatAppearance.BorderColor = Color.MidnightBlue
        btnCancelLogout.FlatAppearance.BorderSize = 2
        btnCancelLogout.Font = New Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelLogout.ForeColor = Color.White
        btnCancelLogout.Location = New Point(128, 111)
        btnCancelLogout.Name = "btnCancelLogout"
        btnCancelLogout.Size = New Size(110, 34)
        btnCancelLogout.TabIndex = 15
        btnCancelLogout.Text = "Cancel"
        btnCancelLogout.UseVisualStyleBackColor = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImageLayout = ImageLayout.Center
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(321, 6)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(34, 32)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 17
        PictureBox6.TabStop = False
        ' 
        ' Logout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(362, 156)
        Controls.Add(PictureBox6)
        Controls.Add(btnCancelLogout)
        Controls.Add(Label3)
        Controls.Add(Label7)
        Controls.Add(btnFinalLogout)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Logout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Logout"
        TopMost = True
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFinalLogout As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancelLogout As Button
    Friend WithEvents PictureBox6 As PictureBox
End Class
