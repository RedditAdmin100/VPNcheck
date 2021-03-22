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
        Me.NotifyEvery10MinsIfConnectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 12)
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
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenProgramToolStripMenuItem, Me.ConnectToVpnToolStripMenuItem, Me.DisconnectVPNToolStripMenuItem, Me.NotifyEvery10MinsIfConnectedToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(252, 114)
        '
        'OpenProgramToolStripMenuItem
        '
        Me.OpenProgramToolStripMenuItem.Name = "OpenProgramToolStripMenuItem"
        Me.OpenProgramToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.OpenProgramToolStripMenuItem.Text = "Open Program"
        '
        'ConnectToVpnToolStripMenuItem
        '
        Me.ConnectToVpnToolStripMenuItem.Name = "ConnectToVpnToolStripMenuItem"
        Me.ConnectToVpnToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.ConnectToVpnToolStripMenuItem.Text = "Connect to VPN"
        '
        'DisconnectVPNToolStripMenuItem
        '
        Me.DisconnectVPNToolStripMenuItem.Name = "DisconnectVPNToolStripMenuItem"
        Me.DisconnectVPNToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.DisconnectVPNToolStripMenuItem.Text = "Disconnect VPN"
        '
        'NotifyEvery10MinsIfConnectedToolStripMenuItem
        '
        Me.NotifyEvery10MinsIfConnectedToolStripMenuItem.Checked = Global.VPNcheck.My.MySettings.Default.notify10min
        Me.NotifyEvery10MinsIfConnectedToolStripMenuItem.CheckOnClick = True
        Me.NotifyEvery10MinsIfConnectedToolStripMenuItem.CheckState = Global.VPNcheck.My.MySettings.Default.notify1
        Me.NotifyEvery10MinsIfConnectedToolStripMenuItem.Name = Global.VPNcheck.My.MySettings.Default.Notify10
        Me.NotifyEvery10MinsIfConnectedToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.NotifyEvery10MinsIfConnectedToolStripMenuItem.Text = "Notify every 10 mins if connected"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(-1, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(336, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Minimize to System Tray to Monitor in Background"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 5000
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(-1, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(336, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Connect to VPN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(-1, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(336, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Disconnect from VPN"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 316)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(310, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name of VPN connection being monitored"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(-1, 260)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(336, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Setup "
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 32)
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
        Me.Label4.Location = New System.Drawing.Point(44, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Please go through setup process"
        Me.Label4.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 465)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(321, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Make sure VPNcheck is set to always have its taskbar icon shown"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(1, 487)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(145, 13)
        Me.LinkLabel2.TabIndex = 14
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Open Taskbar Icons Settings"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 488)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "- Win 7 and older versions of Win 10"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1, 501)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(213, 13)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Taskbar Icons for newer versions of Win 10"
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(-1, 406)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(336, 23)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Close Program and Stop Monitoring"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(4, 382)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(327, 18)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Allow program closure (VPN will no longer be monitored)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 519)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LinkLabel2)
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
    Friend WithEvents Label8 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents NotifyEvery10MinsIfConnectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button5 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
