<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pm_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pm_form))
        Me.txtsub = New System.Windows.Forms.TextBox()
        Me.lblsub = New System.Windows.Forms.Label()
        Me.txtmsg = New System.Windows.Forms.TextBox()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.sendbtn = New System.Windows.Forms.PictureBox()
        CType(Me.sendbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsub
        '
        Me.txtsub.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsub.Location = New System.Drawing.Point(12, 32)
        Me.txtsub.Name = "txtsub"
        Me.txtsub.Size = New System.Drawing.Size(499, 27)
        Me.txtsub.TabIndex = 3
        '
        'lblsub
        '
        Me.lblsub.AutoSize = True
        Me.lblsub.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsub.Location = New System.Drawing.Point(8, 9)
        Me.lblsub.Name = "lblsub"
        Me.lblsub.Size = New System.Drawing.Size(63, 20)
        Me.lblsub.TabIndex = 2
        Me.lblsub.Text = "Subject"
        '
        'txtmsg
        '
        Me.txtmsg.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmsg.Location = New System.Drawing.Point(12, 86)
        Me.txtmsg.Multiline = True
        Me.txtmsg.Name = "txtmsg"
        Me.txtmsg.Size = New System.Drawing.Size(499, 111)
        Me.txtmsg.TabIndex = 5
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.Location = New System.Drawing.Point(8, 63)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(76, 20)
        Me.lblmsg.TabIndex = 4
        Me.lblmsg.Text = "Message"
        '
        'sendbtn
        '
        Me.sendbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sendbtn.Image = CType(resources.GetObject("sendbtn.Image"), System.Drawing.Image)
        Me.sendbtn.Location = New System.Drawing.Point(453, 201)
        Me.sendbtn.Name = "sendbtn"
        Me.sendbtn.Size = New System.Drawing.Size(65, 36)
        Me.sendbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.sendbtn.TabIndex = 6
        Me.sendbtn.TabStop = False
        Me.ToolTip1.SetToolTip(Me.sendbtn, "Send")
        '
        'pm_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(523, 241)
        Me.Controls.Add(Me.sendbtn)
        Me.Controls.Add(Me.txtmsg)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.txtsub)
        Me.Controls.Add(Me.lblsub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pm_form"
        Me.ShowInTaskbar = False
        Me.Text = "Send a Private Message to "
        CType(Me.sendbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsub As System.Windows.Forms.TextBox
    Friend WithEvents lblsub As System.Windows.Forms.Label
    Friend WithEvents txtmsg As System.Windows.Forms.TextBox
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents sendbtn As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
