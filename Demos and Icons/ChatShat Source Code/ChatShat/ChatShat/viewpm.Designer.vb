<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewpm
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
        Me.lstmsgs = New System.Windows.Forms.ListView()
        Me.cluser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clsub = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.msgcontext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.delmsg = New System.Windows.Forms.ToolStripMenuItem()
        Me.msgcontext.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstmsgs
        '
        Me.lstmsgs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cluser, Me.clsub})
        Me.lstmsgs.ContextMenuStrip = Me.msgcontext
        Me.lstmsgs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstmsgs.FullRowSelect = True
        Me.lstmsgs.Location = New System.Drawing.Point(12, 12)
        Me.lstmsgs.Name = "lstmsgs"
        Me.lstmsgs.Size = New System.Drawing.Size(605, 204)
        Me.lstmsgs.TabIndex = 0
        Me.lstmsgs.UseCompatibleStateImageBehavior = False
        Me.lstmsgs.View = System.Windows.Forms.View.Details
        '
        'cluser
        '
        Me.cluser.Text = "Sender"
        Me.cluser.Width = 100
        '
        'clsub
        '
        Me.clsub.Text = "Subject"
        Me.clsub.Width = 500
        '
        'msgcontext
        '
        Me.msgcontext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.delmsg})
        Me.msgcontext.Name = "msgcontext"
        Me.msgcontext.Size = New System.Drawing.Size(153, 48)
        '
        'delmsg
        '
        Me.delmsg.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delmsg.Name = "delmsg"
        Me.delmsg.Size = New System.Drawing.Size(152, 22)
        Me.delmsg.Text = "Delete"
        '
        'viewpm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(629, 228)
        Me.Controls.Add(Me.lstmsgs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "viewpm"
        Me.ShowInTaskbar = False
        Me.Text = "Private Messages"
        Me.msgcontext.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstmsgs As System.Windows.Forms.ListView
    Friend WithEvents cluser As System.Windows.Forms.ColumnHeader
    Friend WithEvents clsub As System.Windows.Forms.ColumnHeader
    Friend WithEvents msgcontext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents delmsg As System.Windows.Forms.ToolStripMenuItem
End Class
