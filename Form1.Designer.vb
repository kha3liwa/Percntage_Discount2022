<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtPerc = New System.Windows.Forms.TextBox()
        Me.txtSal = New System.Windows.Forms.TextBox()
        Me.txtDis = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(135, 133)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.Percntage_Discount.My.Resources.Resources._1416085765_exit
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(153, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(305, 130)
        Me.Panel2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Orange
        Me.Label9.Location = New System.Drawing.Point(171, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 33)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "EX أمثلة"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(18, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "0.4 * 850=340"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(18, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(274, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "$16....70% || 0.3*$16=$4.80"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.txtPercentage)
        Me.Panel3.Controls.Add(Me.txtSalary)
        Me.Panel3.Controls.Add(Me.txtDiscount)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Panel3.Location = New System.Drawing.Point(15, 165)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(443, 144)
        Me.Panel3.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(347, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Clean"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label10.Location = New System.Drawing.Point(320, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 24)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Percentage"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(347, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "النسبة المئوية"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPercentage
        '
        Me.txtPercentage.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtPercentage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPercentage.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtPercentage.Location = New System.Drawing.Point(212, 86)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.ReadOnly = True
        Me.txtPercentage.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentage.TabIndex = 5
        Me.txtPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtSalary.Location = New System.Drawing.Point(211, 53)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 27)
        Me.txtSalary.TabIndex = 4
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtDiscount.Location = New System.Drawing.Point(211, 22)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 27)
        Me.txtDiscount.TabIndex = 3
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(18, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Percentage النسبة المئوية"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(18, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salary المرتب"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Discount الخصم"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.txtPerc)
        Me.Panel4.Controls.Add(Me.txtSal)
        Me.Panel4.Controls.Add(Me.txtDis)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Panel4.ForeColor = System.Drawing.Color.Sienna
        Me.Panel4.Location = New System.Drawing.Point(15, 324)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(443, 144)
        Me.Panel4.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Button4.Location = New System.Drawing.Point(375, 87)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(55, 29)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Clean"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label11.Location = New System.Drawing.Point(343, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 24)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Discount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(294, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 19)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "%"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(294, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 28)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "قيمة الخصم"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtPerc
        '
        Me.txtPerc.BackColor = System.Drawing.SystemColors.Window
        Me.txtPerc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPerc.Location = New System.Drawing.Point(211, 20)
        Me.txtPerc.Multiline = True
        Me.txtPerc.Name = "txtPerc"
        Me.txtPerc.Size = New System.Drawing.Size(77, 24)
        Me.txtPerc.TabIndex = 8
        Me.txtPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSal
        '
        Me.txtSal.Location = New System.Drawing.Point(212, 54)
        Me.txtSal.Multiline = True
        Me.txtSal.Name = "txtSal"
        Me.txtSal.Size = New System.Drawing.Size(77, 24)
        Me.txtSal.TabIndex = 7
        Me.txtSal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDis
        '
        Me.txtDis.BackColor = System.Drawing.Color.PeachPuff
        Me.txtDis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDis.Location = New System.Drawing.Point(211, 91)
        Me.txtDis.Name = "txtDis"
        Me.txtDis.ReadOnly = True
        Me.txtDis.Size = New System.Drawing.Size(77, 20)
        Me.txtDis.TabIndex = 6
        Me.txtDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Percentage النسبة المئوية"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Salary المرتب\المبلغ كامل"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Discount الخصم"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(18, 471)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 14)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "BY:kha3iwa 012022"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 494)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Percntage & Discount 2022"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPercentage As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents txtPerc As TextBox
    Friend WithEvents txtSal As TextBox
    Friend WithEvents txtDis As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label13 As Label
End Class
