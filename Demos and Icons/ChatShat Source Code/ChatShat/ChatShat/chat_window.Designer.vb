<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chat_window
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(chat_window))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl0 = New System.Windows.Forms.Label()
        Me.lstfrnds = New System.Windows.Forms.ListBox()
        Me.usr_mob = New System.Windows.Forms.Label()
        Me.usr_email = New System.Windows.Forms.Label()
        Me.usr_name = New System.Windows.Forms.Label()
        Me.dppic = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chfontcolor = New System.Windows.Forms.PictureBox()
        Me.sendmsj = New System.Windows.Forms.PictureBox()
        Me.chatbox = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chatboxbackend = New System.Windows.Forms.RichTextBox()
        Me.msjbox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bwchat = New System.ComponentModel.BackgroundWorker()
        Me.tmchat = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.vpm = New System.Windows.Forms.ToolStripMenuItem()
        Me.edprof = New System.Windows.Forms.ToolStripMenuItem()
        Me.mycolor = New System.Windows.Forms.ColorDialog()
        Me.myfont = New System.Windows.Forms.FontDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.dppic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chfontcolor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sendmsj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl0)
        Me.Panel1.Controls.Add(Me.lstfrnds)
        Me.Panel1.Controls.Add(Me.usr_mob)
        Me.Panel1.Controls.Add(Me.usr_email)
        Me.Panel1.Controls.Add(Me.usr_name)
        Me.Panel1.Controls.Add(Me.dppic)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 490)
        Me.Panel1.TabIndex = 0
        '
        'lbl0
        '
        Me.lbl0.AutoSize = True
        Me.lbl0.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl0.ForeColor = System.Drawing.Color.White
        Me.lbl0.Location = New System.Drawing.Point(3, 107)
        Me.lbl0.Name = "lbl0"
        Me.lbl0.Size = New System.Drawing.Size(74, 22)
        Me.lbl0.TabIndex = 4
        Me.lbl0.Text = "Friends"
        '
        'lstfrnds
        '
        Me.lstfrnds.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lstfrnds.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstfrnds.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstfrnds.ForeColor = System.Drawing.Color.White
        Me.lstfrnds.FormattingEnabled = True
        Me.lstfrnds.ItemHeight = 20
        Me.lstfrnds.Location = New System.Drawing.Point(10, 127)
        Me.lstfrnds.Name = "lstfrnds"
        Me.lstfrnds.Size = New System.Drawing.Size(257, 360)
        Me.lstfrnds.TabIndex = 1
        '
        'usr_mob
        '
        Me.usr_mob.AutoSize = True
        Me.usr_mob.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usr_mob.ForeColor = System.Drawing.Color.White
        Me.usr_mob.Location = New System.Drawing.Point(91, 48)
        Me.usr_mob.Name = "usr_mob"
        Me.usr_mob.Size = New System.Drawing.Size(37, 14)
        Me.usr_mob.TabIndex = 3
        Me.usr_mob.Text = "mobile"
        '
        'usr_email
        '
        Me.usr_email.AutoSize = True
        Me.usr_email.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usr_email.ForeColor = System.Drawing.Color.White
        Me.usr_email.Location = New System.Drawing.Point(91, 34)
        Me.usr_email.Name = "usr_email"
        Me.usr_email.Size = New System.Drawing.Size(31, 14)
        Me.usr_email.TabIndex = 2
        Me.usr_email.Text = "email"
        '
        'usr_name
        '
        Me.usr_name.AutoSize = True
        Me.usr_name.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usr_name.ForeColor = System.Drawing.Color.White
        Me.usr_name.Location = New System.Drawing.Point(90, 12)
        Me.usr_name.Name = "usr_name"
        Me.usr_name.Size = New System.Drawing.Size(60, 22)
        Me.usr_name.TabIndex = 1
        Me.usr_name.Text = "Name"
        '
        'dppic
        '
        Me.dppic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dppic.Location = New System.Drawing.Point(12, 12)
        Me.dppic.Name = "dppic"
        Me.dppic.Size = New System.Drawing.Size(72, 65)
        Me.dppic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dppic.TabIndex = 0
        Me.dppic.TabStop = False
        Me.ToolTip1.SetToolTip(Me.dppic, "Click to view image")
        '
        'chfontcolor
        '
        Me.chfontcolor.Image = CType(resources.GetObject("chfontcolor.Image"), System.Drawing.Image)
        Me.chfontcolor.Location = New System.Drawing.Point(276, 339)
        Me.chfontcolor.Name = "chfontcolor"
        Me.chfontcolor.Size = New System.Drawing.Size(56, 50)
        Me.chfontcolor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.chfontcolor.TabIndex = 8
        Me.chfontcolor.TabStop = False
        Me.ToolTip1.SetToolTip(Me.chfontcolor, "Change Font and Color")
        '
        'sendmsj
        '
        Me.sendmsj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sendmsj.Image = CType(resources.GetObject("sendmsj.Image"), System.Drawing.Image)
        Me.sendmsj.Location = New System.Drawing.Point(598, 15)
        Me.sendmsj.Name = "sendmsj"
        Me.sendmsj.Size = New System.Drawing.Size(54, 48)
        Me.sendmsj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.sendmsj.TabIndex = 4
        Me.sendmsj.TabStop = False
        Me.ToolTip1.SetToolTip(Me.sendmsj, "Send")
        '
        'chatbox
        '
        Me.chatbox.BackColor = System.Drawing.Color.White
        Me.chatbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chatbox.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chatbox.Location = New System.Drawing.Point(6, 12)
        Me.chatbox.Name = "chatbox"
        Me.chatbox.ReadOnly = True
        Me.chatbox.Size = New System.Drawing.Size(643, 315)
        Me.chatbox.TabIndex = 1
        Me.chatbox.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chatbox)
        Me.GroupBox1.Controls.Add(Me.chatboxbackend)
        Me.GroupBox1.Location = New System.Drawing.Point(276, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 333)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'chatboxbackend
        '
        Me.chatboxbackend.Location = New System.Drawing.Point(241, 19)
        Me.chatboxbackend.Name = "chatboxbackend"
        Me.chatboxbackend.Size = New System.Drawing.Size(140, 61)
        Me.chatboxbackend.TabIndex = 2
        Me.chatboxbackend.Text = ""
        '
        'msjbox
        '
        Me.msjbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.msjbox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msjbox.Location = New System.Drawing.Point(5, 11)
        Me.msjbox.Multiline = True
        Me.msjbox.Name = "msjbox"
        Me.msjbox.Size = New System.Drawing.Size(588, 58)
        Me.msjbox.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sendmsj)
        Me.GroupBox2.Controls.Add(Me.msjbox)
        Me.GroupBox2.Location = New System.Drawing.Point(275, 412)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(655, 74)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'bwchat
        '
        Me.bwchat.WorkerReportsProgress = True
        Me.bwchat.WorkerSupportsCancellation = True
        '
        'tmchat
        '
        Me.tmchat.Enabled = True
        Me.tmchat.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 490)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(937, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.vpm, Me.edprof})
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'vpm
        '
        Me.vpm.Name = "vpm"
        Me.vpm.Size = New System.Drawing.Size(192, 22)
        Me.vpm.Text = "View Private Messages"
        '
        'edprof
        '
        Me.edprof.Name = "edprof"
        Me.edprof.Size = New System.Drawing.Size(192, 22)
        Me.edprof.Text = "Edit Profile"
        '
        'chat_window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(937, 514)
        Me.Controls.Add(Me.chfontcolor)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "chat_window"
        Me.Text = "ChatShat"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dppic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chfontcolor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sendmsj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dppic As System.Windows.Forms.PictureBox
    Friend WithEvents usr_name As System.Windows.Forms.Label
    Friend WithEvents usr_email As System.Windows.Forms.Label
    Friend WithEvents usr_mob As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lstfrnds As System.Windows.Forms.ListBox
    Friend WithEvents lbl0 As System.Windows.Forms.Label
    Friend WithEvents chatbox As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents msjbox As System.Windows.Forms.TextBox
    Friend WithEvents sendmsj As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bwchat As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmchat As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vpm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents edprof As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chfontcolor As System.Windows.Forms.PictureBox
    Friend WithEvents mycolor As System.Windows.Forms.ColorDialog
    Friend WithEvents myfont As System.Windows.Forms.FontDialog
    Friend WithEvents chatboxbackend As System.Windows.Forms.RichTextBox
End Class
