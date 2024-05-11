<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Daytime_Option
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Daytime_Option))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(484, 610)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MuseoModerno", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(490, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(319, 54)
        Label1.TabIndex = 1
        Label1.Text = "Seaside Cove Villa"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MuseoModerno", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(490, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(278, 43)
        Label2.TabIndex = 2
        Label2.Text = "Maximum Capacity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(763, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 30)
        Label3.TabIndex = 3
        Label3.Text = "10 People "
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(490, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(479, 313)
        Label4.TabIndex = 4
        Label4.Text = resources.GetString("Label4.Text")
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Transparent
        Label5.Location = New Point(505, 292)
        Label5.Name = "Label5"
        Label5.Size = New Size(415, 149)
        Label5.TabIndex = 5
        Label5.Text = resources.GetString("Label5.Text")
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Poppins", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Transparent
        Label6.Location = New Point(490, 465)
        Label6.Name = "Label6"
        Label6.Size = New Size(415, 55)
        Label6.TabIndex = 6
        Label6.Text = "Experience the beauty of our coastal paradise in the comfort " & vbCrLf & "of this charming villa retreat." & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.CadetBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(690, 537)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(215, 40)
        Button1.TabIndex = 7
        Button1.Text = "PROCEED TO BOOKING"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Transparent
        Label7.Location = New Point(521, 544)
        Label7.Name = "Label7"
        Label7.Size = New Size(163, 37)
        Label7.TabIndex = 8
        Label7.Text = "PRICE PHP 10,000"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Daytime_Option
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(981, 612)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Daytime_Option"
        Text = "Daytime_Option"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
End Class
