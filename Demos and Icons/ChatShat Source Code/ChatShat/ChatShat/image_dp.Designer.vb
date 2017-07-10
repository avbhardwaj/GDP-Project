<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class image_dp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(image_dp))
        Me.pp = New System.Windows.Forms.PictureBox()
        Me.chnagedp = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imgchoose = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chnagedp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pp
        '
        Me.pp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pp.Location = New System.Drawing.Point(0, 0)
        Me.pp.Name = "pp"
        Me.pp.Size = New System.Drawing.Size(288, 215)
        Me.pp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pp.TabIndex = 0
        Me.pp.TabStop = False
        '
        'chnagedp
        '
        Me.chnagedp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chnagedp.Image = CType(resources.GetObject("chnagedp.Image"), System.Drawing.Image)
        Me.chnagedp.Location = New System.Drawing.Point(253, 184)
        Me.chnagedp.Name = "chnagedp"
        Me.chnagedp.Size = New System.Drawing.Size(29, 27)
        Me.chnagedp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.chnagedp.TabIndex = 1
        Me.chnagedp.TabStop = False
        Me.ToolTip1.SetToolTip(Me.chnagedp, "Change Profile Pic")
        '
        'imgchoose
        '
        Me.imgchoose.Filter = "Image Files|*.jpg; *.png; *.jpeg; *.bmp"
        Me.imgchoose.Title = "Choose Profile Picture"
        '
        'image_dp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 215)
        Me.Controls.Add(Me.chnagedp)
        Me.Controls.Add(Me.pp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "image_dp"
        Me.ShowInTaskbar = False
        Me.Text = "Profile Picture"
        CType(Me.pp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chnagedp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pp As System.Windows.Forms.PictureBox
    Friend WithEvents chnagedp As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents imgchoose As System.Windows.Forms.OpenFileDialog
End Class
