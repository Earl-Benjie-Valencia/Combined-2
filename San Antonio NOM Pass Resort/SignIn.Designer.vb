<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignIn))
        Panel2 = New Panel()
        btnContact = New Button()
        btnAboutUs = New Button()
        btnRooms = New Button()
        Panel1 = New Panel()
        lblRegister = New Label()
        btnSignIn = New Button()
        Label3 = New Label()
        txtPassword = New TextBox()
        Label2 = New Label()
        txtUsername = New TextBox()
        Label1 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkGoldenrod
        Panel2.Controls.Add(btnContact)
        Panel2.Controls.Add(btnAboutUs)
        Panel2.Controls.Add(btnRooms)
        Panel2.Location = New Point(266, 511)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(335, 68)
        Panel2.TabIndex = 21
        ' 
        ' btnContact
        ' 
        btnContact.AutoSize = True
        btnContact.BackColor = Color.Transparent
        btnContact.FlatStyle = FlatStyle.Flat
        btnContact.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnContact.ForeColor = Color.White
        btnContact.Location = New Point(211, 4)
        btnContact.Margin = New Padding(3, 4, 3, 4)
        btnContact.Name = "btnContact"
        btnContact.Size = New Size(120, 61)
        btnContact.TabIndex = 2
        btnContact.Text = "Contact"
        btnContact.UseVisualStyleBackColor = False
        ' 
        ' btnAboutUs
        ' 
        btnAboutUs.AutoSize = True
        btnAboutUs.BackColor = Color.Transparent
        btnAboutUs.FlatStyle = FlatStyle.Flat
        btnAboutUs.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAboutUs.ForeColor = Color.White
        btnAboutUs.Location = New Point(99, 4)
        btnAboutUs.Margin = New Padding(3, 4, 3, 4)
        btnAboutUs.Name = "btnAboutUs"
        btnAboutUs.Size = New Size(128, 61)
        btnAboutUs.TabIndex = 1
        btnAboutUs.Text = "About Us"
        btnAboutUs.UseVisualStyleBackColor = False
        ' 
        ' btnRooms
        ' 
        btnRooms.AutoSize = True
        btnRooms.BackColor = Color.Transparent
        btnRooms.FlatStyle = FlatStyle.Flat
        btnRooms.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRooms.ForeColor = Color.White
        btnRooms.Location = New Point(3, 4)
        btnRooms.Margin = New Padding(3, 4, 3, 4)
        btnRooms.Name = "btnRooms"
        btnRooms.Size = New Size(106, 61)
        btnRooms.TabIndex = 0
        btnRooms.Text = "Rooms"
        btnRooms.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lblRegister)
        Panel1.Controls.Add(btnSignIn)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(297, 103)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(275, 387)
        Panel1.TabIndex = 22
        ' 
        ' lblRegister
        ' 
        lblRegister.AutoSize = True
        lblRegister.BackColor = Color.Transparent
        lblRegister.Font = New Font("Poppins", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblRegister.ForeColor = Color.Teal
        lblRegister.Location = New Point(67, 337)
        lblRegister.Name = "lblRegister"
        lblRegister.Size = New Size(146, 30)
        lblRegister.TabIndex = 10
        lblRegister.Text = "REGISTER NOW!"
        ' 
        ' btnSignIn
        ' 
        btnSignIn.BackColor = Color.Teal
        btnSignIn.FlatStyle = FlatStyle.Flat
        btnSignIn.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignIn.ForeColor = SystemColors.ControlLightLight
        btnSignIn.Location = New Point(78, 267)
        btnSignIn.Margin = New Padding(3, 4, 3, 4)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(106, 55)
        btnSignIn.TabIndex = 9
        btnSignIn.Text = "Sign In"
        btnSignIn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("MuseoModerno", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Teal
        Label3.Location = New Point(81, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 54)
        Label3.TabIndex = 8
        Label3.Text = "Login"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(46, 208)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(177, 39)
        txtPassword.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(46, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 30)
        Label2.TabIndex = 6
        Label2.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(46, 111)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(177, 39)
        txtUsername.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(46, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 30)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' SignIn
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(889, 616)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        DoubleBuffered = True
        ForeColor = SystemColors.ControlLightLight
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "SignIn"
        Text = "Admin"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnContact As Button
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents btnRooms As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRegister As Label
    Friend WithEvents btnSignIn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
End Class
