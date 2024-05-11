<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Client
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
        Panel1 = New Panel()
        Label1 = New Label()
        Panel3 = New Panel()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        lblWelcome = New Label()
        Panel5 = New Panel()
        Label3 = New Label()
        Panel6 = New Panel()
        lblViewdetails = New Label()
        lblCheckOut = New Label()
        lblCheckIn = New Label()
        lblDate = New Label()
        lblName = New Label()
        Panel7 = New Panel()
        Label27 = New Label()
        Label26 = New Label()
        Label25 = New Label()
        Label24 = New Label()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        lblChild = New Label()
        lblAdult = New Label()
        Label15 = New Label()
        lblAddress = New Label()
        lblPhoneno = New Label()
        lblBday = New Label()
        lblAge = New Label()
        lblSex = New Label()
        lblFullName = New Label()
        lblLogout = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 450)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MuseoModerno Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(66, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 25)
        Label1.TabIndex = 4
        Label1.Text = "Client "
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Panel2)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 124)
        Panel3.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MuseoModerno Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(-1, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(184, 50)
        Label2.TabIndex = 3
        Label2.Text = "San Antonio" & vbCrLf & "Management System"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(200, 50)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 100)
        Panel2.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(lblLogout)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(200, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(600, 50)
        Panel4.TabIndex = 1
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AccessibleRole = AccessibleRole.None
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("MuseoModerno", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(19, 19)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(115, 33)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome:"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Teal
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(lblWelcome)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(200, 50)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(600, 71)
        Panel5.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AccessibleRole = AccessibleRole.None
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(141, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 37)
        Label3.TabIndex = 1
        Label3.Text = "-"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.WhiteSmoke
        Panel6.Controls.Add(lblViewdetails)
        Panel6.Controls.Add(lblCheckOut)
        Panel6.Controls.Add(lblCheckIn)
        Panel6.Controls.Add(lblDate)
        Panel6.Controls.Add(lblName)
        Panel6.Controls.Add(Panel7)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(200, 121)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(600, 329)
        Panel6.TabIndex = 15
        ' 
        ' lblViewdetails
        ' 
        lblViewdetails.AutoSize = True
        lblViewdetails.Font = New Font("Poppins SemiBold", 8.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblViewdetails.ForeColor = Color.Teal
        lblViewdetails.Location = New Point(463, 14)
        lblViewdetails.Name = "lblViewdetails"
        lblViewdetails.Size = New Size(77, 19)
        lblViewdetails.TabIndex = 26
        lblViewdetails.Text = "View Details"
        ' 
        ' lblCheckOut
        ' 
        lblCheckOut.AutoSize = True
        lblCheckOut.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCheckOut.ForeColor = Color.Black
        lblCheckOut.Location = New Point(339, 15)
        lblCheckOut.Name = "lblCheckOut"
        lblCheckOut.Size = New Size(71, 19)
        lblCheckOut.TabIndex = 25
        lblCheckOut.Text = "Check OUT:"
        ' 
        ' lblCheckIn
        ' 
        lblCheckIn.AutoSize = True
        lblCheckIn.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCheckIn.ForeColor = Color.Black
        lblCheckIn.Location = New Point(223, 15)
        lblCheckIn.Name = "lblCheckIn"
        lblCheckIn.Size = New Size(60, 19)
        lblCheckIn.TabIndex = 24
        lblCheckIn.Text = "Check IN:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = Color.Black
        lblDate.Location = New Point(122, 15)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(37, 19)
        lblDate.TabIndex = 23
        lblDate.Text = "Date:"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = Color.Black
        lblName.Location = New Point(15, 15)
        lblName.Name = "lblName"
        lblName.Size = New Size(47, 19)
        lblName.TabIndex = 22
        lblName.Text = " Name:"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(Label27)
        Panel7.Controls.Add(Label26)
        Panel7.Controls.Add(Label25)
        Panel7.Controls.Add(Label24)
        Panel7.Controls.Add(Label23)
        Panel7.Controls.Add(Label22)
        Panel7.Controls.Add(Label21)
        Panel7.Controls.Add(Label20)
        Panel7.Controls.Add(lblChild)
        Panel7.Controls.Add(lblAdult)
        Panel7.Controls.Add(Label15)
        Panel7.Controls.Add(lblAddress)
        Panel7.Controls.Add(lblPhoneno)
        Panel7.Controls.Add(lblBday)
        Panel7.Controls.Add(lblAge)
        Panel7.Controls.Add(lblSex)
        Panel7.Controls.Add(lblFullName)
        Panel7.Location = New Point(19, 68)
        Panel7.Margin = New Padding(3, 2, 3, 2)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(289, 132)
        Panel7.TabIndex = 0
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label27.Location = New Point(249, 50)
        Label27.Name = "Label27"
        Label27.Size = New Size(15, 19)
        Label27.TabIndex = 19
        Label27.Text = "-"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(249, 33)
        Label26.Name = "Label26"
        Label26.Size = New Size(15, 19)
        Label26.TabIndex = 18
        Label26.Text = "-"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(104, 98)
        Label25.Name = "Label25"
        Label25.Size = New Size(15, 19)
        Label25.TabIndex = 17
        Label25.Text = "-"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(104, 81)
        Label24.Name = "Label24"
        Label24.Size = New Size(15, 19)
        Label24.TabIndex = 16
        Label24.Text = "-"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(104, 64)
        Label23.Name = "Label23"
        Label23.Size = New Size(15, 19)
        Label23.TabIndex = 15
        Label23.Text = "-"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(104, 45)
        Label22.Name = "Label22"
        Label22.Size = New Size(15, 19)
        Label22.TabIndex = 14
        Label22.Text = "-"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(104, 29)
        Label21.Name = "Label21"
        Label21.Size = New Size(15, 19)
        Label21.TabIndex = 13
        Label21.Text = "-"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(104, 12)
        Label20.Name = "Label20"
        Label20.Size = New Size(15, 19)
        Label20.TabIndex = 11
        Label20.Text = "-"
        ' 
        ' lblChild
        ' 
        lblChild.AutoSize = True
        lblChild.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblChild.Location = New Point(176, 50)
        lblChild.Name = "lblChild"
        lblChild.Size = New Size(57, 19)
        lblChild.TabIndex = 8
        lblChild.Text = "Children:"
        ' 
        ' lblAdult
        ' 
        lblAdult.AutoSize = True
        lblAdult.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAdult.Location = New Point(176, 31)
        lblAdult.Name = "lblAdult"
        lblAdult.Size = New Size(39, 19)
        lblAdult.TabIndex = 7
        lblAdult.Text = "Adult:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(204, 12)
        Label15.Name = "Label15"
        Label15.Size = New Size(43, 19)
        Label15.TabIndex = 6
        Label15.Text = "GUEST"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAddress.Location = New Point(30, 98)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(55, 19)
        lblAddress.TabIndex = 5
        lblAddress.Text = "Address:"
        ' 
        ' lblPhoneno
        ' 
        lblPhoneno.AutoSize = True
        lblPhoneno.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPhoneno.Location = New Point(17, 81)
        lblPhoneno.Name = "lblPhoneno"
        lblPhoneno.Size = New Size(63, 19)
        lblPhoneno.TabIndex = 4
        lblPhoneno.Text = "Phone No:"
        ' 
        ' lblBday
        ' 
        lblBday.AutoSize = True
        lblBday.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBday.Location = New Point(24, 64)
        lblBday.Name = "lblBday"
        lblBday.Size = New Size(56, 19)
        lblBday.TabIndex = 3
        lblBday.Text = "Birthday:"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAge.Location = New Point(49, 45)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(32, 19)
        lblAge.TabIndex = 2
        lblAge.Text = "Age:"
        ' 
        ' lblSex
        ' 
        lblSex.AutoSize = True
        lblSex.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSex.Location = New Point(52, 29)
        lblSex.Name = "lblSex"
        lblSex.Size = New Size(29, 19)
        lblSex.TabIndex = 1
        lblSex.Text = "Sex:"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFullName.Location = New Point(17, 12)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(66, 19)
        lblFullName.TabIndex = 0
        lblFullName.Text = "Full Name:"
        ' 
        ' lblLogout
        ' 
        lblLogout.AutoSize = True
        lblLogout.Font = New Font("Poppins Medium", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblLogout.ForeColor = Color.Teal
        lblLogout.Location = New Point(518, 9)
        lblLogout.Name = "lblLogout"
        lblLogout.Size = New Size(70, 23)
        lblLogout.TabIndex = 0
        lblLogout.Text = "Log Out "
        ' 
        ' Client
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Name = "Client"
        Text = "Client"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblSex As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblPhoneno As Label
    Friend WithEvents lblBday As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblChild As Label
    Friend WithEvents lblAdult As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCheckIn As Label
    Friend WithEvents lblViewdetails As Label
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLogout As Label
End Class
