<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        btnBookIn = New Button()
        lblCheckout = New Label()
        lblCheckIn = New Label()
        lblRoomnum = New Label()
        lblDate = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(699, 429)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.WhiteSmoke
        GroupBox1.Controls.Add(btnBookIn)
        GroupBox1.Controls.Add(lblCheckout)
        GroupBox1.Controls.Add(lblCheckIn)
        GroupBox1.Controls.Add(lblRoomnum)
        GroupBox1.Controls.Add(lblDate)
        GroupBox1.Font = New Font("MuseoModerno", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Teal
        GroupBox1.Location = New Point(71, 82)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(564, 300)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Booking History"
        ' 
        ' btnBookIn
        ' 
        btnBookIn.BackColor = Color.Teal
        btnBookIn.FlatStyle = FlatStyle.Flat
        btnBookIn.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBookIn.ForeColor = SystemColors.ControlLightLight
        btnBookIn.Location = New Point(421, 253)
        btnBookIn.Name = "btnBookIn"
        btnBookIn.Size = New Size(125, 31)
        btnBookIn.TabIndex = 4
        btnBookIn.Text = "Book In"
        btnBookIn.UseVisualStyleBackColor = False
        ' 
        ' lblCheckout
        ' 
        lblCheckout.AutoSize = True
        lblCheckout.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCheckout.ForeColor = SystemColors.ActiveCaptionText
        lblCheckout.Location = New Point(405, 37)
        lblCheckout.Name = "lblCheckout"
        lblCheckout.Size = New Size(87, 23)
        lblCheckout.TabIndex = 3
        lblCheckout.Text = "Check-OUT:"
        ' 
        ' lblCheckIn
        ' 
        lblCheckIn.AutoSize = True
        lblCheckIn.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCheckIn.ForeColor = SystemColors.ActiveCaptionText
        lblCheckIn.Location = New Point(285, 37)
        lblCheckIn.Name = "lblCheckIn"
        lblCheckIn.Size = New Size(73, 23)
        lblCheckIn.TabIndex = 2
        lblCheckIn.Text = "Check-IN:"
        ' 
        ' lblRoomnum
        ' 
        lblRoomnum.AutoSize = True
        lblRoomnum.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRoomnum.ForeColor = SystemColors.ActiveCaptionText
        lblRoomnum.Location = New Point(123, 37)
        lblRoomnum.Name = "lblRoomnum"
        lblRoomnum.Size = New Size(95, 23)
        lblRoomnum.TabIndex = 1
        lblRoomnum.Text = "Room numer:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = SystemColors.ActiveCaptionText
        lblDate.Location = New Point(6, 37)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(44, 23)
        lblDate.TabIndex = 0
        lblDate.Text = "Date:"
        ' 
        ' User
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(699, 429)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Name = "User"
        Text = "User"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCheckIn As Label
    Friend WithEvents lblRoomnum As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnBookIn As Button
    Friend WithEvents lblCheckout As Label
End Class
