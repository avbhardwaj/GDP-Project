<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frndprof
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frndprof))
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblmob = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblname1 = New System.Windows.Forms.Label()
        Me.lblusername1 = New System.Windows.Forms.Label()
        Me.lblemail1 = New System.Windows.Forms.Label()
        Me.lblmob1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pmpic = New System.Windows.Forms.PictureBox()
        Me.frnddp = New System.Windows.Forms.PictureBox()
        CType(Me.pmpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frnddp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(190, 87)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(46, 20)
        Me.lblemail.TabIndex = 15
        Me.lblemail.Text = "Email"
        '
        'lblmob
        '
        Me.lblmob.AutoSize = True
        Me.lblmob.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmob.Location = New System.Drawing.Point(190, 124)
        Me.lblmob.Name = "lblmob"
        Me.lblmob.Size = New System.Drawing.Size(122, 20)
        Me.lblmob.TabIndex = 14
        Me.lblmob.Text = "Mobile Number"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(190, 47)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(83, 20)
        Me.lblusername.TabIndex = 13
        Me.lblusername.Text = "Username"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(190, 9)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(79, 20)
        Me.lblname.TabIndex = 12
        Me.lblname.Text = "Full Name"
        '
        'lblname1
        '
        Me.lblname1.AutoSize = True
        Me.lblname1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname1.Location = New System.Drawing.Point(337, 9)
        Me.lblname1.Name = "lblname1"
        Me.lblname1.Size = New System.Drawing.Size(79, 20)
        Me.lblname1.TabIndex = 16
        Me.lblname1.Text = "Full Name"
        '
        'lblusername1
        '
        Me.lblusername1.AutoSize = True
        Me.lblusername1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername1.Location = New System.Drawing.Point(337, 47)
        Me.lblusername1.Name = "lblusername1"
        Me.lblusername1.Size = New System.Drawing.Size(83, 20)
        Me.lblusername1.TabIndex = 17
        Me.lblusername1.Text = "Username"
        '
        'lblemail1
        '
        Me.lblemail1.AutoSize = True
        Me.lblemail1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail1.Location = New System.Drawing.Point(337, 87)
        Me.lblemail1.Name = "lblemail1"
        Me.lblemail1.Size = New System.Drawing.Size(46, 20)
        Me.lblemail1.TabIndex = 18
        Me.lblemail1.Text = "Email"
        '
        'lblmob1
        '
        Me.lblmob1.AutoSize = True
        Me.lblmob1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmob1.Location = New System.Drawing.Point(337, 124)
        Me.lblmob1.Name = "lblmob1"
        Me.lblmob1.Size = New System.Drawing.Size(122, 20)
        Me.lblmob1.TabIndex = 19
        Me.lblmob1.Text = "Mobile Number"
        '
        'pmpic
        '
        Me.pmpic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pmpic.Image = CType(resources.GetObject("pmpic.Image"), System.Drawing.Image)
        Me.pmpic.Location = New System.Drawing.Point(573, 129)
        Me.pmpic.Name = "pmpic"
        Me.pmpic.Size = New System.Drawing.Size(42, 31)
        Me.pmpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pmpic.TabIndex = 21
        Me.pmpic.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pmpic, "Send a Private Message")
        '
        'frnddp
        '
        Me.frnddp.Dock = System.Windows.Forms.DockStyle.Left
        Me.frnddp.Location = New System.Drawing.Point(0, 0)
        Me.frnddp.Name = "frnddp"
        Me.frnddp.Size = New System.Drawing.Size(184, 172)
        Me.frnddp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.frnddp.TabIndex = 20
        Me.frnddp.TabStop = False
        '
        'frndprof
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(627, 172)
        Me.Controls.Add(Me.pmpic)
        Me.Controls.Add(Me.frnddp)
        Me.Controls.Add(Me.lblmob1)
        Me.Controls.Add(Me.lblemail1)
        Me.Controls.Add(Me.lblusername1)
        Me.Controls.Add(Me.lblname1)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblmob)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.lblname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frndprof"
        Me.ShowInTaskbar = False
        Me.Text = "Profile"
        CType(Me.pmpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frnddp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblmob As System.Windows.Forms.Label
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblname1 As System.Windows.Forms.Label
    Friend WithEvents lblusername1 As System.Windows.Forms.Label
    Friend WithEvents lblemail1 As System.Windows.Forms.Label
    Friend WithEvents lblmob1 As System.Windows.Forms.Label
    Friend WithEvents frnddp As System.Windows.Forms.PictureBox
    Friend WithEvents pmpic As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
