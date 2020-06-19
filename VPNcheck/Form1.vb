﻿Imports System.IO
Imports System.Net.NetworkInformation

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String
        filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\vpncheck\vpnname.txt"
        TextBox1.Text = System.IO.File.ReadAllText(filePath).Trim
        Timer1.Interval = 10000 '10 seconds
        Timer1.Enabled = True

        Timer2.Interval = 600000 '10 min
        Timer2.Enabled = True
        Timer3.Enabled = True
        If TextBox1.Text = "" Then
            Timer3.Enabled = False
            MsgBox("It looks like you have not selceted which VPN needs to be monitored. Please go through setup process. ")
            'Form2.Show()
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button5.Visible = False
            CheckBox1.Visible = False
            TextBox1.Visible = False
            Label2.Visible = False
            Label1.Visible = False
            Label3.Visible = True
            Label4.Visible = True
        End If

        Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces
        Dim isVpnExist As Boolean = nics.AsEnumerable().Any(Function(x) x.Name = TextBox1.Text)



        If isVpnExist = True Then
            Label1.Text = "VPN IS ON"
            'NotifyIcon2.Visible = True
            NotifyIcon1.Icon = My.Resources.connected
            NotifyIcon1.Text = "VPN CONNECTED"
        Else
            ' vpn is not exist do something
            Label1.Text = "VPN IS OFF"
            'NotifyIcon2.Visible = False
            NotifyIcon1.Icon = My.Resources.notconnected
            NotifyIcon1.Text = "VPN DISCONNECTED"
        End If
    End Sub

    'Private Sub Form1_resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '    Me.Visible = False
    '    NotifyIcon1.Visible = True

    'End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub OpenProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProgramToolStripMenuItem.Click
        Me.Visible = True

        Me.WindowState = FormWindowState.Normal
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces
        Dim isVpnExist As Boolean = nics.AsEnumerable().Any(Function(x) x.Name = TextBox1.Text)


        If isVpnExist = True Then
            Label1.Text = "VPN IS ON"
            'NotifyIcon2.Visible = True
            NotifyIcon1.Icon = My.Resources.connected
            NotifyIcon1.Text = "VPN CONNECTED"

        Else
            ' vpn is not exist do something
            Label1.Text = "VPN IS OFF"
            'NotifyIcon2.Visible = False
            NotifyIcon1.Icon = My.Resources.notconnected
            NotifyIcon1.Text = "VPN DISCONNECTED"
        End If
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces
        Dim isVpnExist As Boolean = nics.AsEnumerable().Any(Function(x) x.Name = TextBox1.Text)

        If isVpnExist = True Then
            If NotifyEvery10MinsIfConnectedToolStripMenuItem.Checked = True Then
                Label1.Text = "VPN IS ON"
                'NotifyIcon2.Visible = True
                NotifyIcon1.ShowBalloonTip(1, "VPN", "VPN is running", ToolTipIcon.None)
                NotifyIcon1.Icon = My.Resources.connected
            Else
            End If
        Else
                ' vpn is not exist do something
                Label1.Text = "VPN IS OFF"
            'NotifyIcon2.Visible = False
            NotifyIcon1.Icon = My.Resources.notconnected
        End If
    End Sub

    Private Sub ConnectToVpnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToVpnToolStripMenuItem.Click
        Shell("rasdial " & """" & TextBox1.Text & """")

    End Sub

    Private Sub DisconnectVPNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisconnectVPNToolStripMenuItem.Click
        Shell("rasdial  /disconnect")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Visible = False
        Timer3.Enabled = False
        NotifyIcon1.ShowBalloonTip(3, "VPN-Check", "Program is running from System Tray", ToolTipIcon.None)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("rasdial " & """" & TextBox1.Text & """")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("rasdial  /disconnect")
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Shell("explorer shell:::{05d7b0f4-2121-4eff-bf6b-ed3f69b894d9}")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.digitalcitizen.life/how-set-which-icons-are-shown-windows-10s-notification-area")
    End Sub



    Private Sub NotifyEvery10MinsIfConnectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotifyEvery10MinsIfConnectedToolStripMenuItem.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button5.Enabled = True
        Else
            Button5.Enabled = False

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Program will now close. The VPN status icon will no longer be available. Remember to open VPNcheck if you want to monitor your VPN status")

        Me.Close()
    End Sub
End Class
