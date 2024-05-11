<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnLogout = New Button()
        btnContact = New Button()
        btnAboutUs = New Button()
        btnRooms = New Button()
        btnBooking = New Button()
        cmbCheckout2 = New ComboBox()
        cmbCheckout1 = New ComboBox()
        cmbCheckin2 = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        cmbCheckin1 = New ComboBox()
        PictureBox1 = New PictureBox()
        pbHomepage = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbHomepage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(btnBooking)
        Panel1.Controls.Add(cmbCheckout2)
        Panel1.Controls.Add(cmbCheckout1)
        Panel1.Controls.Add(cmbCheckin2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(cmbCheckin1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(pbHomepage)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(914, 600)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkGoldenrod
        Panel2.Controls.Add(btnLogout)
        Panel2.Controls.Add(btnContact)
        Panel2.Controls.Add(btnAboutUs)
        Panel2.Controls.Add(btnRooms)
        Panel2.Location = New Point(25, 16)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(455, 69)
        Panel2.TabIndex = 22
        ' 
        ' btnLogout
        ' 
        btnLogout.AutoSize = True
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(336, 4)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(113, 61)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnContact
        ' 
        btnContact.AutoSize = True
        btnContact.BackColor = Color.Transparent
        btnContact.FlatStyle = FlatStyle.Flat
        btnContact.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnContact.ForeColor = Color.White
        btnContact.Location = New Point(222, 4)
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
        ' btnBooking
        ' 
        btnBooking.BackColor = Color.DarkSeaGreen
        btnBooking.FlatStyle = FlatStyle.Flat
        btnBooking.Font = New Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBooking.ForeColor = Color.White
        btnBooking.Location = New Point(530, 455)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(143, 68)
        btnBooking.TabIndex = 19
        btnBooking.Text = "Book Now"
        btnBooking.UseVisualStyleBackColor = False
        ' 
        ' cmbCheckout2
        ' 
        cmbCheckout2.DropDownHeight = 50
        cmbCheckout2.DropDownWidth = 70
        cmbCheckout2.FormattingEnabled = True
        cmbCheckout2.IntegralHeight = False
        cmbCheckout2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        cmbCheckout2.Location = New Point(433, 492)
        cmbCheckout2.Margin = New Padding(3, 4, 3, 4)
        cmbCheckout2.Name = "cmbCheckout2"
        cmbCheckout2.Size = New Size(47, 28)
        cmbCheckout2.TabIndex = 17
        ' 
        ' cmbCheckout1
        ' 
        cmbCheckout1.BackColor = SystemColors.Window
        cmbCheckout1.DropDownHeight = 50
        cmbCheckout1.FlatStyle = FlatStyle.System
        cmbCheckout1.FormattingEnabled = True
        cmbCheckout1.IntegralHeight = False
        cmbCheckout1.Items.AddRange(New Object() {"JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEPT", "OCT", "NOV", "DEC"})
        cmbCheckout1.Location = New Point(361, 492)
        cmbCheckout1.Margin = New Padding(3, 4, 3, 4)
        cmbCheckout1.Name = "cmbCheckout1"
        cmbCheckout1.Size = New Size(63, 28)
        cmbCheckout1.TabIndex = 16
        ' 
        ' cmbCheckin2
        ' 
        cmbCheckin2.DropDownHeight = 50
        cmbCheckin2.DropDownWidth = 70
        cmbCheckin2.FormattingEnabled = True
        cmbCheckin2.IntegralHeight = False
        cmbCheckin2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        cmbCheckin2.Location = New Point(294, 492)
        cmbCheckin2.Margin = New Padding(3, 4, 3, 4)
        cmbCheckin2.Name = "cmbCheckin2"
        cmbCheckin2.Size = New Size(47, 28)
        cmbCheckin2.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DarkSeaGreen
        Label2.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(223, 455)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 34)
        Label2.TabIndex = 7
        Label2.Text = "CHECK IN"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkSeaGreen
        Label1.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(361, 455)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 34)
        Label1.TabIndex = 6
        Label1.Text = "CHECK OUT"
        ' 
        ' cmbCheckin1
        ' 
        cmbCheckin1.BackColor = SystemColors.Window
        cmbCheckin1.DropDownHeight = 50
        cmbCheckin1.FlatStyle = FlatStyle.System
        cmbCheckin1.FormattingEnabled = True
        cmbCheckin1.IntegralHeight = False
        cmbCheckin1.Items.AddRange(New Object() {"JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEPT", "OCT", "NOV", "DEC"})
        cmbCheckin1.Location = New Point(223, 492)
        cmbCheckin1.Margin = New Padding(3, 4, 3, 4)
        cmbCheckin1.Name = "cmbCheckin1"
        cmbCheckin1.Size = New Size(63, 28)
        cmbCheckin1.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DarkSeaGreen
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(202, 431)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(492, 117)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' pbHomepage
        ' 
        pbHomepage.BackgroundImage = CType(resources.GetObject("pbHomepage.BackgroundImage"), Image)
        pbHomepage.BackgroundImageLayout = ImageLayout.Center
        pbHomepage.BorderStyle = BorderStyle.FixedSingle
        pbHomepage.Dock = DockStyle.Fill
        pbHomepage.Image = CType(resources.GetObject("pbHomepage.Image"), Image)
        pbHomepage.Location = New Point(0, 0)
        pbHomepage.Margin = New Padding(3, 4, 3, 4)
        pbHomepage.Name = "pbHomepage"
        pbHomepage.Size = New Size(914, 600)
        pbHomepage.SizeMode = PictureBoxSizeMode.StretchImage
        pbHomepage.TabIndex = 3
        pbHomepage.TabStop = False
        ' 
        ' Homepage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Homepage"
        Text = "Home Page"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbHomepage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbHomepage As PictureBox
    Friend WithEvents cmbCheckin1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCheckin2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBooking As Button
    Friend WithEvents cmbCheckout2 As ComboBox
    Friend WithEvents cmbCheckout1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnContact As Button
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents btnRooms As Button

End Class
