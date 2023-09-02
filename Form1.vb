Imports System.Net
Imports System.Windows.Forms
Imports System.Threading.Tasks
Imports System.IO
Imports System.Threading
Imports System.Text
Imports System.Media






Public Class Form1
    Dim TCPCLIENT As Sockets.TcpClient
    Dim TCPCLIENTSTREAM As Sockets.NetworkStream

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label3.Text = DateTime.Now.ToString("dd/MM/yyy")

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        TextBox2.Text = TextBox5.Text

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        TextBox1.Text = TextBox6.Text
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        If ComboBox2.Text = "ALECU" Then
            TextBox4.Text = "B 115"

        End If
        If ComboBox2.Text = "DOHOTARU" Then
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


        TCPCLIENT = New Sockets.TcpClient(TextBox14.Text, 3000)
        TCPCLIENTSTREAM = TCPCLIENT.GetStream
        TextBox15.Text = ComboBox2.Text
        TextBox16.BackColor = Color.LimeGreen
        Timer1.Enabled = True
        Timer2.Enabled = True


    End Sub



    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        TextBox7.Text = TextBox8.Text
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox18.Text = TextBox4.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.BackColor = Color.Lime
        If CheckBox3.Checked = True Then

            Dim SENDBYTES() As Byte = System.Text.Encoding.ASCII.GetBytes("^0!GO" + vbCrLf + "^0*BEGINLJSCRIPT [()]" + vbCrLf + "^0*JLPAR [ 90 1 0 3 1000 180 0 30000 00:00 0 30000 0 0 1000 0]" + vbCrLf + "^0*BEGINJOB [ 0 () ]" + vbCrLf + "^0*JOBPAR [ 2000 0 0 420 0 0 0 1 1 0 -1 () 1 1 55000 0 16 0 1 0 100 0 1 0 ]" + vbCrLf + "^0*OBJ [1 0 13 0 (ISO1_7x5)  (" + TextBox6.Text + " ) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*OBJ [2 168 13 0 (ISO1_7x5)  (PA) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*OBJ [3 0 0 0 (ISO1_7x5)  (" + TextBox5.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*OBJ [4 131 0 0 (ISO1_7x5)  (" + TextBox8.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*OBJ [5 163 1 0 (ISO1_7x5)  (" + TextBox4.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*ENDJOB []" + vbCrLf + "^0*ENDLJSCRIPT []" + vbCrLf)
            TCPCLIENT.Client.Send(SENDBYTES)

        End If

        If CheckBox2.Checked = True Then
            Dim SENDBYTES() As Byte = System.Text.Encoding.ASCII.GetBytes("^0!GO" + vbCrLf + "^0*BEGINLJSCRIPT [()]" + vbCrLf + "^0*JLPAR [ 60 1 0 3 10 180 0 30000 00:00 0 30000 0 0 1000 0]" + vbCrLf + "^0*BEGINJOB [ 0 () ]" + vbCrLf + "^0*JOBPAR [ 2000 0 0 280 0 0 0 1 1 0 -1 () 1 1 55000 0 9 0 1 0 100 0 1 0 ]" + vbCrLf + "^0*OBJ [1 0 11 0 (ISO1_7x5)  (" + TextBox6.Text + " ) 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*OBJ [2 89 11 0 (ISO1_7x5)  (PA) 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*OBJ [3 0 0 0 (ISO1_7x5)  (" + TextBox5.Text + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*OBJ [4 64 0 0 (ISO1_7x5)  (" + TextBox8.Text + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*OBJ [5 87 0 0 (ISO1_7x5)  (" + TextBox4.Text + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*ENDJOB []" + vbCrLf + "^0*ENDLJSCRIPT []" + vbCrLf)
            TCPCLIENT.Client.Send(SENDBYTES)
        End If

        If CheckBox4.Checked = True Then
            Dim SENDBYTES() As Byte = System.Text.Encoding.ASCII.GetBytes("^0!GO" + vbCrLf + "^0*BEGINLJSCRIPT [()]" + vbCrLf + "^0*JLPAR [ 90 1 0 3 1000 180 0 30000 00:00 0 30000 0 0 1000 0]" + vbCrLf + "^0*BEGINJOB [ 0 () ]" + vbCrLf + "^0*JOBPAR [ 2000 0 0 380 0 0 0 1 1 0 -1 () 1 1 55000 0 21 0 1 0 100 0 1 0 ]" + vbCrLf + "^0*OBJ [1 0 16 0 (ISO1_9x7)  (" + TextBox6.Text + " ) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*OBJ [2 251 16 0 (ISO1_9x7)  (PA) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*OBJ [3 0 0 0 (ISO1_9x7)  (" + TextBox5.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*OBJ [4 176 0 0 (ISO1_9x7)  (" + TextBox8.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*OBJ [5 242 0 0 (ISO1_9x7)  (" + TextBox4.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + vbCrLf + "^0*ENDJOB []" + vbCrLf + "^0*ENDLJSCRIPT []" + vbCrLf)
            TCPCLIENT.Client.Send(SENDBYTES)

        End If

        Dim SENDBYTES2() As Byte = System.Text.Encoding.ASCII.GetBytes("^0=CC0" + vbTab + TextBox11.Text + vbTab + "3999" + vbCrLf)
        TCPCLIENT.Client.Send(SENDBYTES2)

        Dim SENDBYTES3() As Byte = System.Text.Encoding.ASCII.GetBytes("^0!EQ" + vbCrLf)
        TCPCLIENT.Client.Send(SENDBYTES3)


    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox2.Checked = False
            CheckBox4.Checked = False

        End If
    End Sub

  

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox3.Checked = False
            CheckBox4.Checked = False

        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox3.Checked = False
            CheckBox2.Checked = False

        End If
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button3.BackColor = Color.Gray
        TextBox5.ResetText()
        TextBox6.ResetText()
        TextBox8.ResetText()
        TextBox11.ResetText()

    End Sub
  
  

  
End Class

