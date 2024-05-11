<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Billing_Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing_Payment))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        btnUpdate = New Button()
        btnDetails = New Button()
        Label2 = New Label()
        Panel3 = New Panel()
        cmbAddGuest = New ComboBox()
        Label19 = New Label()
        btnCancel2 = New Button()
        btnAddRoom = New Button()
        cmbChildren = New ComboBox()
        Label18 = New Label()
        cmbAdult = New ComboBox()
        Label16 = New Label()
        cmbRoomType = New ComboBox()
        Label15 = New Label()
        Label17 = New Label()
        Panel2 = New Panel()
        lblCvc = New Label()
        lblEncryptedCard = New Label()
        lblPhoneNum = New Label()
        lblEmail = New Label()
        lblFullName = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        btnCancel = New Button()
        btnSave = New Button()
        cmbCvc = New TextBox()
        cmbYear = New ComboBox()
        cmbMonth = New ComboBox()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        txtCardnum = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(939, 579)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnDetails)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(56, 121)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(356, 202)
        Panel1.TabIndex = 2
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(283, 21)
        Label14.Name = "Label14"
        Label14.Size = New Size(24, 30)
        Label14.TabIndex = 21
        Label14.Text = "0"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(283, 49)
        Label13.Name = "Label13"
        Label13.Size = New Size(24, 30)
        Label13.TabIndex = 20
        Label13.Text = "0"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(38, 60)
        Label12.Name = "Label12"
        Label12.Size = New Size(117, 30)
        Label12.TabIndex = 19
        Label12.Text = "Rate x Night"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("MuseoModerno", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(38, 29)
        Label11.Name = "Label11"
        Label11.Size = New Size(107, 29)
        Label11.TabIndex = 18
        Label11.Text = "Room Type"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.Teal
        btnUpdate.Location = New Point(184, 96)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(133, 36)
        btnUpdate.TabIndex = 17
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDetails
        ' 
        btnDetails.BackColor = Color.Teal
        btnDetails.FlatStyle = FlatStyle.Flat
        btnDetails.Font = New Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDetails.ForeColor = Color.Transparent
        btnDetails.Location = New Point(41, 96)
        btnDetails.Name = "btnDetails"
        btnDetails.Size = New Size(136, 36)
        btnDetails.TabIndex = 17
        btnDetails.Text = "View Details"
        btnDetails.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(14, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(329, 46)
        Label2.TabIndex = 0
        Label2.Text = "Cancellation Policy:100% cancellation fee until " & vbCrLf & "2024-04-01 100% cancellation fee from 2024-04-10"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(cmbAddGuest)
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(btnCancel2)
        Panel3.Controls.Add(btnAddRoom)
        Panel3.Controls.Add(cmbChildren)
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(cmbAdult)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(cmbRoomType)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(Label17)
        Panel3.Location = New Point(61, 121)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(351, 219)
        Panel3.TabIndex = 22
        ' 
        ' cmbAddGuest
        ' 
        cmbAddGuest.FormattingEnabled = True
        cmbAddGuest.Location = New Point(194, 111)
        cmbAddGuest.Name = "cmbAddGuest"
        cmbAddGuest.Size = New Size(69, 28)
        cmbAddGuest.TabIndex = 19
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(191, 83)
        Label19.Name = "Label19"
        Label19.Size = New Size(137, 26)
        Label19.TabIndex = 18
        Label19.Text = "Additional Guest"
        ' 
        ' btnCancel2
        ' 
        btnCancel2.FlatStyle = FlatStyle.Flat
        btnCancel2.Font = New Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel2.ForeColor = Color.Teal
        btnCancel2.Location = New Point(181, 155)
        btnCancel2.Name = "btnCancel2"
        btnCancel2.Size = New Size(123, 47)
        btnCancel2.TabIndex = 17
        btnCancel2.Text = "Cancel"
        btnCancel2.UseVisualStyleBackColor = True
        ' 
        ' btnAddRoom
        ' 
        btnAddRoom.BackColor = Color.Teal
        btnAddRoom.FlatStyle = FlatStyle.Flat
        btnAddRoom.Font = New Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddRoom.ForeColor = Color.Transparent
        btnAddRoom.Location = New Point(53, 155)
        btnAddRoom.Name = "btnAddRoom"
        btnAddRoom.Size = New Size(123, 47)
        btnAddRoom.TabIndex = 17
        btnAddRoom.Text = "Add Room"
        btnAddRoom.UseVisualStyleBackColor = False
        ' 
        ' cmbChildren
        ' 
        cmbChildren.FormattingEnabled = True
        cmbChildren.Location = New Point(107, 115)
        cmbChildren.Name = "cmbChildren"
        cmbChildren.Size = New Size(69, 28)
        cmbChildren.TabIndex = 6
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(107, 83)
        Label18.Name = "Label18"
        Label18.Size = New Size(77, 26)
        Label18.TabIndex = 5
        Label18.Text = "Children"
        ' 
        ' cmbAdult
        ' 
        cmbAdult.FormattingEnabled = True
        cmbAdult.Location = New Point(18, 111)
        cmbAdult.Name = "cmbAdult"
        cmbAdult.Size = New Size(69, 28)
        cmbAdult.TabIndex = 3
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(22, 55)
        Label16.Name = "Label16"
        Label16.Size = New Size(259, 26)
        Label16.TabIndex = 2
        Label16.Text = "Kindly enter the number of Guest"
        ' 
        ' cmbRoomType
        ' 
        cmbRoomType.FormattingEnabled = True
        cmbRoomType.Location = New Point(131, 15)
        cmbRoomType.Name = "cmbRoomType"
        cmbRoomType.Size = New Size(151, 28)
        cmbRoomType.TabIndex = 1
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(22, 19)
        Label15.Name = "Label15"
        Label15.Size = New Size(109, 30)
        Label15.TabIndex = 0
        Label15.Text = "Room Type"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(22, 83)
        Label17.Name = "Label17"
        Label17.Size = New Size(51, 26)
        Label17.TabIndex = 4
        Label17.Text = "Adult"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(lblCvc)
        Panel2.Controls.Add(lblEncryptedCard)
        Panel2.Controls.Add(lblPhoneNum)
        Panel2.Controls.Add(lblEmail)
        Panel2.Controls.Add(lblFullName)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(cmbCvc)
        Panel2.Controls.Add(cmbYear)
        Panel2.Controls.Add(cmbMonth)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(txtCardnum)
        Panel2.Location = New Point(481, 121)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(420, 379)
        Panel2.TabIndex = 3
        ' 
        ' lblCvc
        ' 
        lblCvc.AutoSize = True
        lblCvc.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCvc.Location = New Point(214, 301)
        lblCvc.Name = "lblCvc"
        lblCvc.Size = New Size(39, 23)
        lblCvc.TabIndex = 16
        lblCvc.Text = "CVC"
        ' 
        ' lblEncryptedCard
        ' 
        lblEncryptedCard.AutoSize = True
        lblEncryptedCard.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEncryptedCard.Location = New Point(214, 277)
        lblEncryptedCard.Name = "lblEncryptedCard"
        lblEncryptedCard.Size = New Size(116, 23)
        lblEncryptedCard.TabIndex = 15
        lblEncryptedCard.Text = "Encypted card#"
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPhoneNum.Location = New Point(30, 324)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(104, 23)
        lblPhoneNum.TabIndex = 14
        lblPhoneNum.Text = "Phone number"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(30, 301)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(45, 23)
        lblEmail.TabIndex = 13
        lblEmail.Text = "Email"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFullName.Location = New Point(30, 277)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(73, 23)
        lblFullName.TabIndex = 12
        lblFullName.Text = "Full Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Teal
        Label3.Location = New Point(214, 253)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 26)
        Label3.TabIndex = 11
        Label3.Text = "Credit Card Info"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(27, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 36)
        Label1.TabIndex = 10
        Label1.Text = "Pay with Credit Card"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Teal
        Label5.Location = New Point(26, 253)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 26)
        Label5.TabIndex = 4
        Label5.Text = "Billing Contact"
        ' 
        ' btnCancel
        ' 
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.Teal
        btnCancel.Location = New Point(205, 195)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(133, 43)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Teal
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.Transparent
        btnSave.Location = New Point(66, 195)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(133, 43)
        btnSave.TabIndex = 8
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' cmbCvc
        ' 
        cmbCvc.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbCvc.Location = New Point(251, 137)
        cmbCvc.Multiline = True
        cmbCvc.Name = "cmbCvc"
        cmbCvc.Size = New Size(113, 40)
        cmbCvc.TabIndex = 7
        cmbCvc.Text = "CVC"
        ' 
        ' cmbYear
        ' 
        cmbYear.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbYear.FormattingEnabled = True
        cmbYear.Location = New Point(130, 139)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(107, 34)
        cmbYear.TabIndex = 6
        cmbYear.Text = "YYYY"
        ' 
        ' cmbMonth
        ' 
        cmbMonth.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbMonth.FormattingEnabled = True
        cmbMonth.ItemHeight = 26
        cmbMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        cmbMonth.Location = New Point(27, 139)
        cmbMonth.Name = "cmbMonth"
        cmbMonth.Size = New Size(95, 34)
        cmbMonth.TabIndex = 5
        cmbMonth.Text = "MM"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Teal
        Label4.Location = New Point(26, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 30)
        Label4.TabIndex = 4
        Label4.Text = "Expires on"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(322, 60)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(77, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' txtCardnum
        ' 
        txtCardnum.Font = New Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCardnum.Location = New Point(26, 60)
        txtCardnum.Multiline = True
        txtCardnum.Name = "txtCardnum"
        txtCardnum.Size = New Size(274, 33)
        txtCardnum.TabIndex = 2
        txtCardnum.Text = "Card Number"
        ' 
        ' Billing_Payment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(939, 579)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Billing_Payment"
        Text = "Billing_Payment"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtCardnum As TextBox
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cmbCvc As TextBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblCvc As Label
    Friend WithEvents lblEncryptedCard As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbRoomType As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbAdult As ComboBox
    Friend WithEvents btnCancel2 As Button
    Friend WithEvents btnAddRoom As Button
    Friend WithEvents cmbChildren As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbAddGuest As ComboBox
    Friend WithEvents btnDetails As Button
End Class
