<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invalid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invalid))
        PictureBox6 = New PictureBox()
        Label3 = New Label()
        Label7 = New Label()
        btnOkay = New Button()
        Label2 = New Label()
        Label1 = New Label()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImageLayout = ImageLayout.Center
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(321, 7)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(34, 32)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 24
        PictureBox6.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ButtonShadow
        Label3.Location = New Point(12, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(492, 15)
        Label3.TabIndex = 22
        Label3.Text = "_________________________________________________________________________________________________"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Bahnschrift SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DimGray
        Label7.Location = New Point(12, 76)
        Label7.Name = "Label7"
        Label7.Size = New Size(162, 13)
        Label7.TabIndex = 21
        Label7.Text = "Invalid username or password."
        ' 
        ' btnOkay
        ' 
        btnOkay.BackColor = Color.MidnightBlue
        btnOkay.FlatAppearance.BorderColor = Color.MidnightBlue
        btnOkay.FlatAppearance.BorderSize = 2
        btnOkay.Font = New Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOkay.ForeColor = Color.White
        btnOkay.Location = New Point(122, 110)
        btnOkay.Name = "btnOkay"
        btnOkay.Size = New Size(110, 34)
        btnOkay.TabIndex = 20
        btnOkay.Text = "OK"
        btnOkay.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 19)
        Label2.TabIndex = 19
        Label2.Text = "Login Failed"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(12, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 23)
        Label1.TabIndex = 18
        Label1.Text = "Invalid"
        ' 
        ' Invalid
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(362, 156)
        Controls.Add(PictureBox6)
        Controls.Add(Label3)
        Controls.Add(Label7)
        Controls.Add(btnOkay)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Invalid"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Invalid"
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnCancelLogout As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnOkay As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
