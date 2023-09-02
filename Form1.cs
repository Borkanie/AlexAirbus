using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Aerotec
{






    public partial class Form1
    {
        private System.Net.Sockets.TcpClient TCPCLIENT;
        private System.Net.Sockets.NetworkStream TCPCLIENTSTREAM;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Label3.Text = DateTime.Now.ToString("dd/MM/yyy");

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            TextBox2.Text = TextBox5.Text;

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox6.Text;
        }

        private void Button7_Click(object sender, EventArgs e)
        {

            if (ComboBox2.Text == "ALECU")
            {
                TextBox4.Text = "B 115";

            }
            if (ComboBox2.Text == "DOHOTARU")
            {
                TextBox4.Text = "B 093";
            }
            if (ComboBox2.Text == "BACIU")
            {
                TextBox4.Text = "B 041";
            }
            if (ComboBox2.Text == "NEGOESCU")
            {
                TextBox4.Text = "B 110";
            }
            if (ComboBox2.Text == "POENARIU")
            {
                TextBox4.Text = "B 105";
            }
            if (ComboBox2.Text == "CIREASA")
            {
                TextBox4.Text = "B 066";
            }
            if (string.IsNullOrEmpty(ComboBox2.Text))
            {
                MessageBox.Show("VA RUGAM SELECTATI UN CONTROLOR");
                Panel1.Visible = true;
            }


            TCPCLIENT = new System.Net.Sockets.TcpClient(TextBox14.Text, 3000);
            TCPCLIENTSTREAM = TCPCLIENT.GetStream();
            TextBox15.Text = ComboBox2.Text;
            TextBox16.BackColor = Color.LimeGreen;
            Timer1.Enabled = true;
            Timer2.Enabled = true;


        }



        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
            TextBox7.Text = TextBox8.Text;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox18.Text = TextBox4.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button3.BackColor = Color.Lime;
            if (CheckBox3.Checked == true)
            {

                byte[] SENDBYTES = Encoding.ASCII.GetBytes("^0!GO" + Constants.vbCrLf + "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf + "^0*JLPAR [ 90 1 0 3 1000 180 0 30000 00:00 0 30000 0 0 1000 0]" + Constants.vbCrLf + "^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf + "^0*JOBPAR [ 2000 0 0 420 0 0 0 1 1 0 -1 () 1 1 55000 0 16 0 1 0 100 0 1 0 ]" + Constants.vbCrLf + "^0*OBJ [1 0 13 0 (ISO1_7x5)  (" + TextBox6.Text + " ) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*OBJ [2 168 13 0 (ISO1_7x5)  (PA) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*OBJ [3 0 0 0 (ISO1_7x5)  (" + TextBox5.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*OBJ [4 131 0 0 (ISO1_7x5)  (" + TextBox8.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*OBJ [5 163 1 0 (ISO1_7x5)  (" + TextBox4.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*ENDJOB []" + Constants.vbCrLf + "^0*ENDLJSCRIPT []" + Constants.vbCrLf);
                TCPCLIENT.Client.Send(SENDBYTES);

            }

            if (CheckBox2.Checked == true)
            {
                byte[] SENDBYTES = Encoding.ASCII.GetBytes("^0!GO" + Constants.vbCrLf + "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf + "^0*JLPAR [ 60 1 0 3 10 180 0 30000 00:00 0 30000 0 0 1000 0]" + Constants.vbCrLf + "^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf + "^0*JOBPAR [ 2000 0 0 280 0 0 0 1 1 0 -1 () 1 1 55000 0 9 0 1 0 100 0 1 0 ]" + Constants.vbCrLf + "^0*OBJ [1 0 11 0 (ISO1_7x5)  (" + TextBox6.Text + " ) 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*OBJ [2 89 11 0 (ISO1_7x5)  (PA) 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*OBJ [3 0 0 0 (ISO1_7x5)  (" + TextBox5.Text + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*OBJ [4 64 0 0 (ISO1_7x5)  (" + TextBox8.Text + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*OBJ [5 87 0 0 (ISO1_7x5)  (" + TextBox4.Text + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*ENDJOB []" + Constants.vbCrLf + "^0*ENDLJSCRIPT []" + Constants.vbCrLf);
                TCPCLIENT.Client.Send(SENDBYTES);
            }

            if (CheckBox4.Checked == true)
            {
                byte[] SENDBYTES = Encoding.ASCII.GetBytes("^0!GO" + Constants.vbCrLf + "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf + "^0*JLPAR [ 90 1 0 3 1000 180 0 30000 00:00 0 30000 0 0 1000 0]" + Constants.vbCrLf + "^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf + "^0*JOBPAR [ 2000 0 0 380 0 0 0 1 1 0 -1 () 1 1 55000 0 21 0 1 0 100 0 1 0 ]" + Constants.vbCrLf + "^0*OBJ [1 0 16 0 (ISO1_9x7)  (" + TextBox6.Text + " ) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*OBJ [2 251 16 0 (ISO1_9x7)  (PA) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*OBJ [3 0 0 0 (ISO1_9x7)  (" + TextBox5.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*OBJ [4 176 0 0 (ISO1_9x7)  (" + TextBox8.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*OBJ [5 242 0 0 (ISO1_9x7)  (" + TextBox4.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf + "^0*ENDJOB []" + Constants.vbCrLf + "^0*ENDLJSCRIPT []" + Constants.vbCrLf);
                TCPCLIENT.Client.Send(SENDBYTES);

            }

            byte[] SENDBYTES2 = Encoding.ASCII.GetBytes("^0=CC0" + Constants.vbTab + TextBox11.Text + Constants.vbTab + "3999" + Constants.vbCrLf);
            TCPCLIENT.Client.Send(SENDBYTES2);

            byte[] SENDBYTES3 = Encoding.ASCII.GetBytes("^0!EQ" + Constants.vbCrLf);
            TCPCLIENT.Client.Send(SENDBYTES3);


        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == true)
            {
                CheckBox2.Checked = false;
                CheckBox4.Checked = false;

            }
        }



        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                CheckBox3.Checked = false;
                CheckBox4.Checked = false;

            }

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox4.Checked == true)
            {
                CheckBox3.Checked = false;
                CheckBox2.Checked = false;

            }
        }



        private void Button4_Click(object sender, EventArgs e)
        {
            Button3.BackColor = Color.Gray;
            TextBox5.ResetText();
            TextBox6.ResetText();
            TextBox8.ResetText();
            TextBox11.ResetText();

        }




    }
}