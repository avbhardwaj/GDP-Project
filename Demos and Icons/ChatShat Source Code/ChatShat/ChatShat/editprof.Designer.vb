<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editprof
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
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.txtconpass = New System.Windows.Forms.TextBox()
        Me.lblconpass = New System.Windows.Forms.Label()
        Me.chkpass = New System.Windows.Forms.CheckBox()
        Me.txtmob = New System.Windows.Forms.TextBox()
        Me.lblmob = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.btnapply = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(12, 9)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(79, 20)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Full Name"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(16, 32)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(177, 27)
        Me.txtname.TabIndex = 1
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(203, 32)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(177, 27)
        Me.txtusername.TabIndex = 3
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(199, 9)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(83, 20)
        Me.lblusername.TabIndex = 2
        Me.lblusername.Text = "Username"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(16, 94)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.ReadOnly = True
        Me.txtpass.Size = New System.Drawing.Size(177, 27)
        Me.txtpass.TabIndex = 5
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.Location = New System.Drawing.Point(12, 71)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(79, 20)
        Me.lblpass.TabIndex = 4
        Me.lblpass.Text = "Password"
        '
        'txtconpass
        '
        Me.txtconpass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconpass.Location = New System.Drawing.Point(203, 94)
        Me.txtconpass.Name = "txtconpass"
        Me.txtconpass.ReadOnly = True
        Me.txtconpass.Size = New System.Drawing.Size(177, 27)
        Me.txtconpass.TabIndex = 7
        '
        'lblconpass
        '
        Me.lblconpass.AutoSize = True
        Me.lblconpass.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconpass.Location = New System.Drawing.Point(199, 71)
        Me.lblconpass.Name = "lblconpass"
        Me.lblconpass.Size = New System.Drawing.Size(140, 20)
        Me.lblconpass.TabIndex = 6
        Me.lblconpass.Text = "Confirm Password"
        '
        'chkpass
        '
        Me.chkpass.AutoSize = True
        Me.chkpass.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkpass.Location = New System.Drawing.Point(97, 73)
        Me.chkpass.Name = "chkpass"
        Me.chkpass.Size = New System.Drawing.Size(79, 20)
        Me.chkpass.TabIndex = 8
        Me.chkpass.Text = "Change?"
        Me.chkpass.UseVisualStyleBackColor = True
        '
        'txtmob
        '
        Me.txtmob.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmob.Location = New System.Drawing.Point(16, 155)
        Me.txtmob.Name = "txtmob"
        Me.txtmob.Size = New System.Drawing.Size(177, 27)
        Me.txtmob.TabIndex = 10
        '
        'lblmob
        '
        Me.lblmob.AutoSize = True
        Me.lblmob.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmob.Location = New System.Drawing.Point(12, 132)
        Me.lblmob.Name = "lblmob"
        Me.lblmob.Size = New System.Drawing.Size(122, 20)
        Me.lblmob.TabIndex = 9
        Me.lblmob.Text = "Mobile Number"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(203, 155)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(177, 27)
        Me.txtemail.TabIndex = 12
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(199, 132)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(46, 20)
        Me.lblemail.TabIndex = 11
        Me.lblemail.Text = "Email"
        '
        'btnapply
        '
        Me.btnapply.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnapply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnapply.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnapply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnapply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnapply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnapply.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnapply.ForeColor = System.Drawing.Color.White
        Me.btnapply.Location = New System.Drawing.Point(59, 192)
        Me.btnapply.Name = "btnapply"
        Me.btnapply.Size = New System.Drawing.Size(278, 35)
        Me.btnapply.TabIndex = 13
        Me.btnapply.Text = "Apply"
        Me.btnapply.UseVisualStyleBackColor = False
        '
        'editprof
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(395, 236)
        Me.Controls.Add(Me.btnapply)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.txtmob)
        Me.Controls.Add(Me.lblmob)
        Me.Controls.Add(Me.chkpass)
        Me.Controls.Add(Me.txtconpass)
        Me.Controls.Add(Me.lblconpass)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "editprof"
        Me.ShowInTaskbar = False
        Me.Text = "Edit Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents txtconpass As System.Windows.Forms.TextBox
    Friend WithEvents lblconpass As System.Windows.Forms.Label
    Friend WithEvents chkpass As System.Windows.Forms.CheckBox
    Friend WithEvents txtmob As System.Windows.Forms.TextBox
    Friend WithEvents lblmob As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents btnapply As System.Windows.Forms.Button
End Class
