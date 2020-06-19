Imports System.IO
Imports System.Net.NetworkInformation

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces
        Dim isVpnExist As Boolean = nics.AsEnumerable().Any(Function(x) x.Name = TextBox1.Text)


        For Each vpn As NetworkInterface In nics
            ListBox1.Items.Add(vpn.Name)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strFile As String
        strFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\vpncheck\vpnname.txt"
        Dim sw As StreamWriter

        If (Not File.Exists(strFile)) Then
            sw = File.CreateText(strFile)

        Else
            sw = File.CreateText(strFile)
        End If
        sw.WriteLine(TextBox1.Text)
        sw.Close()
        Form1.TextBox1.Text = TextBox1.Text.Trim
        Me.Close()
        Form1.Button1.Visible = True
        Form1.Button2.Visible = True
        Form1.Button3.Visible = True
        Form1.TextBox1.Visible = True
        Form1.Label2.Visible = True
        Form1.Label1.Visible = True
        Form1.Label3.Visible = False
        Form1.Label4.Visible = False
        Form1.Button5.Visible = True
        Form1.CheckBox1.Visible = True

        Form1.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Clear()
        For Each Item As Object In ListBox1.SelectedItems
            TextBox1.AppendText(Item.ToString + Environment.NewLine)
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/RedditAdmin100/VPNcheck")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Shell("explorer shell:::{05d7b0f4-2121-4eff-bf6b-ed3f69b894d9}")
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://www.digitalcitizen.life/how-set-which-icons-are-shown-windows-10s-notification-area")
    End Sub
End Class