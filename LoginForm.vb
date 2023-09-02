Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Panel1.Visible = False
        If ComboBox1.Text = "ALECU" Then
            TextBox1.Text = "B 115"
        End If
        If ComboBox1.Text = "DOHOTARU" Then
            TextBox4.Text = "B 093"
        End If
        If ComboBox2.Text = "BACIU" Then
            TextBox4.Text = "B 041"
        End If
        If ComboBox2.Text = "NEGOESCU" Then
            TextBox4.Text = "B 110"
        End If
        If ComboBox2.Text = "POENARIU" Then
            TextBox4.Text = "B 105"
        End If
        If ComboBox2.Text = "CIREASA" Then
            TextBox4.Text = "B 066"
        End If
        If ComboBox2.Text = "" Then
            MessageBox.Show("VA RUGAM SELECTATI UN CONTROLOR")
            Panel1.Visible = True
        End If


        TcpClient = New Sockets.TcpClient(TextBox14.Text, 3000)
        TCPCLIENTSTREAM = TcpClient.GetStream
        TextBox15.Text = ComboBox2.Text
        TextBox16.BackColor = Color.LimeGreen
        Timer1.Enabled = True
        Timer2.Enabled = True


    End Sub
End Class