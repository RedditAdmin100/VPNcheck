<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToVpnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectVPNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VPN Status"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "VPN Status"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenProgramToolStripMenuItem, Me.ConnectToVpnToolStripMenuItem, Me.DisconnectVPNToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(160, 70)
        '
        'OpenProgramToolStripMenuItem
        '
        Me.OpenProgramToolStripMenuItem.Name = "OpenProgramToolStripMenuItem"
        Me.OpenProgramToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.OpenProgramToolStripMenuItem.Text = "Open Program"
        '
        'ConnectToVpnToolStripMenuItem
        '
        Me.ConnectToVpnToolStripMenuItem.Name = "ConnectToVpnToolStripMenuItem"
        Me.ConnectToVpnToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ConnectToVpnToolStripMenuItem.Text = "Connect to VPN"
        '
        'DisconnectVPNToolStripMenuItem
        '
        Me.DisconnectVPNToolStripMenuItem.Name = "DisconnectVPNToolStripMenuItem"
        Me.DisconnectVPNToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.DisconnectVPNToolStripMenuItem.Text = "Disconnect VPN"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-1, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(312, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Minimize to System Tray to Monitor in Background"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        Me.Timer3.Interval = 5000
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(-1, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(312, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Connect to VPN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(-1, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(312, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Disconnect from VPN"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 316)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(288, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name of VPN connection being monitored"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(-1, 260)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(312, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Setup "
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "- VPNcheck -"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Please go through setup process"
        Me.Label4.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 363)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VPNcheck"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenProgramToolStripMenuItem As ToolStripMenuItem
    Private WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ConnectToVpnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisconnectVPNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
