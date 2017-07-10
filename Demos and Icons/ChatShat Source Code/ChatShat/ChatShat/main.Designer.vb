<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.user = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.btnSignin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tb_inv = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_acnt = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.t1 = New System.Windows.Forms.Timer(Me.components)
        Me.t2 = New System.Windows.Forms.Timer(Me.components)
        Me.wartooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblstatus = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.White
        Me.user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.user.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.Silver
        Me.user.Location = New System.Drawing.Point(200, 133)
        Me.user.Multiline = True
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(278, 37)
        Me.user.TabIndex = 1
        Me.user.Text = "username"
        Me.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.user.WordWrap = False
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.White
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pass.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.Color.Silver
        Me.pass.Location = New System.Drawing.Point(200, 195)
        Me.pass.Multiline = True
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(278, 37)
        Me.pass.TabIndex = 2
        Me.pass.Text = "password"
        Me.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pass.WordWrap = False
        '
        'btnSignin
        '
        Me.btnSignin.BackColor = System.Drawing.Color.Transparent
        Me.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignin.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSignin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSignin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignin.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignin.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSignin.Location = New System.Drawing.Point(200, 256)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(278, 35)
        Me.btnSignin.TabIndex = 4
        Me.btnSignin.Text = "Sign In"
        Me.btnSignin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(217, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 93)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'tb_inv
        '
        Me.tb_inv.Location = New System.Drawing.Point(720, -13)
        Me.tb_inv.Name = "tb_inv"
        Me.tb_inv.Size = New System.Drawing.Size(25, 20)
        Me.tb_inv.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_acnt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 390)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 57)
        Me.Panel1.TabIndex = 4
        '
        'lbl_acnt
        '
        Me.lbl_acnt.AutoSize = True
        Me.lbl_acnt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_acnt.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_acnt.ForeColor = System.Drawing.Color.White
        Me.lbl_acnt.Location = New System.Drawing.Point(280, 15)
        Me.lbl_acnt.Name = "lbl_acnt"
        Me.lbl_acnt.Size = New System.Drawing.Size(118, 20)
        Me.lbl_acnt.TabIndex = 0
        Me.lbl_acnt.Text = "Create Account"
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.White
        Me.email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.email.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.Silver
        Me.email.Location = New System.Drawing.Point(-300, 253)
        Me.email.Multiline = True
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(278, 37)
        Me.email.TabIndex = 3
        Me.email.Text = "email"
        Me.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.email.WordWrap = False
        '
        't1
        '
        Me.t1.Interval = 15
        '
        't2
        '
        Me.t2.Interval = 15
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.Brown
        Me.lblstatus.Location = New System.Drawing.Point(198, 107)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(284, 20)
        Me.lblstatus.TabIndex = 8
        Me.lblstatus.Text = "Account created. You can now login."
        Me.lblstatus.Visible = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 447)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tb_inv)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSignin)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.user)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Text = "ChatShat"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents btnSignin As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tb_inv As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_acnt As System.Windows.Forms.Label
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents t1 As System.Windows.Forms.Timer
    Friend WithEvents t2 As System.Windows.Forms.Timer
    Friend WithEvents wartooltip As System.Windows.Forms.ToolTip
    Friend WithEvents lblstatus As System.Windows.Forms.Label

End Class
