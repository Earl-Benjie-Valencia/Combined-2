﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Label7 = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        btnSignUp = New Button()
        txtPhoneno = New TextBox()
        txtEmail = New TextBox()
        txtLname = New TextBox()
        txtFname = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(29, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 22)
        Label1.TabIndex = 2
        Label1.Text = "First name*"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(161, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 22)
        Label2.TabIndex = 3
        Label2.Text = "Last name*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Teal
        Label3.Location = New Point(32, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 22)
        Label3.TabIndex = 4
        Label3.Text = "Username*"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Teal
        Label4.Location = New Point(32, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 22)
        Label4.TabIndex = 5
        Label4.Text = "Email "
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(btnSignUp)
        Panel1.Controls.Add(txtPhoneno)
        Panel1.Controls.Add(txtEmail)
        Panel1.Controls.Add(txtLname)
        Panel1.Controls.Add(txtFname)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(232, 77)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(294, 344)
        Panel1.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Poppins", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Teal
        Label7.Location = New Point(161, 110)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 22)
        Label7.TabIndex = 16
        Label7.Text = "Password*"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(161, 135)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(107, 23)
        txtPassword.TabIndex = 15
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(32, 135)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(107, 23)
        txtUsername.TabIndex = 14
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.Teal
        btnSignUp.FlatStyle = FlatStyle.Popup
        btnSignUp.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignUp.ForeColor = Color.White
        btnSignUp.Location = New Point(96, 286)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(93, 37)
        btnSignUp.TabIndex = 13
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' txtPhoneno
        ' 
        txtPhoneno.Location = New Point(32, 246)
        txtPhoneno.Name = "txtPhoneno"
        txtPhoneno.Size = New Size(236, 23)
        txtPhoneno.TabIndex = 12
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(32, 186)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(236, 23)
        txtEmail.TabIndex = 11
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(161, 85)
        txtLname.Multiline = True
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(107, 23)
        txtLname.TabIndex = 9
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(31, 84)
        txtFname.Multiline = True
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(107, 23)
        txtFname.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("MuseoModerno", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Teal
        Label6.Location = New Point(85, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 43)
        Label6.TabIndex = 7
        Label6.Text = "Register"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Poppins", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Teal
        Label5.Location = New Point(32, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 22)
        Label5.TabIndex = 6
        Label5.Text = "Phone number"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Register"
        Text = "Register"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPhoneno As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
End Class
