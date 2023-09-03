using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aerotec
{
    public partial class MainForm
    {
        private System.Net.Sockets.TcpClient TCPCLIENT;
        private System.Net.Sockets.NetworkStream TCPCLIENTSTREAM;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Label3.Text = DateTime.Now.ToString("dd/MM/yyy");

            // Dock Panel1 to fill the form
            Panel1.Dock = DockStyle.Fill;

            // Adjust the size of the form to match its size
            AutoSize = true;
            Panel1.BringToFront();

            HideOrShowPanel1(true);
            Visible = true;

        }

        private void HideOrShowPanel1(bool show)
        {
            // Hide all controls except Panel1 and its children
            foreach (Control control in this.Controls)
            {
                if (control != Panel1 && control.Parent != Panel1)
                {
                    control.Visible = !show;
                }
            }


            // Show the controls you want to be visible initially
            Panel1.Visible = show;
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

            TextBox2.Text = ANRTextBox.Text;

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            TextBox1.Text = HTZTextBox.Text;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //Panel1.Visible = false;
            switch (ComboBox2.Text)
            {
                case "ALECU":
                    ControllerIdTextBox.Text = "B 115";
                    break;

                case "DOHOTARU":
                    ControllerIdTextBox.Text = "B 093";
                    break;

                case "BACIU":
                    ControllerIdTextBox.Text = "B 041";
                    break;

                case "NEGOESCU":
                    ControllerIdTextBox.Text = "B 110";
                    break;

                case "POENARIU":
                    ControllerIdTextBox.Text = "B 105";
                    break;

                case "CIREASA":
                    ControllerIdTextBox.Text = "B 066";
                    break;

                default:
                    MessageBox.Show("VA RUGAM SELECTATI UN CONTROLOR");
                    //Panel1.Visible = true;
                    return;
            }



            TCPCLIENT = new System.Net.Sockets.TcpClient(TextBox14.Text, 3000);
            TCPCLIENTSTREAM = TCPCLIENT.GetStream();
            ControllerTextBox.Text = ComboBox2.Text;
            TextBox16.BackColor = Color.LimeGreen;
            Timer1.Enabled = true;
            Timer2.Enabled = true;

            HideOrShowPanel1(false);

        }



        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
            TextBox7.Text = BTIDTextBox.Text;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox18.Text = ControllerIdTextBox.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            StartProductionButton.BackColor = Color.Lime;
            if (SizeStandardChkBox.Checked == true)
            {

                byte[] SENDBYTES = Encoding.ASCII.GetBytes("^0!GO" + Constants.vbCrLf
                                     + "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf
                                     + "^0*JLPAR [ 90 1 0 3 1000 180 0 30000 00:00 0 30000 0 0 1000 0]" + Constants.vbCrLf
                                     + "^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf
                                     + "^0*JOBPAR [ 2000 0 0 420 0 0 0 1 1 0 -1 () 1 1 55000 0 16 0 1 0 100 0 1 0 ]" + Constants.vbCrLf
                                     + "^0*OBJ [1 0 13 0 (ISO1_7x5)  (" + HTZTextBox.Text + " ) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*OBJ [2 168 13 0 (ISO1_7x5)  (PA) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*OBJ [3 0 0 0 (ISO1_7x5)  (" + ANRTextBox.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*OBJ [4 131 0 0 (ISO1_7x5)  (" + BTIDTextBox.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*OBJ [5 163 1 0 (ISO1_7x5)  (" + ControllerIdTextBox.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*ENDJOB []" + Constants.vbCrLf
                                     + "^0*ENDLJSCRIPT []" + Constants.vbCrLf
                                    );
                TCPCLIENT.Client.Send(SENDBYTES);

            }

            if (SizeSmallChkBox.Checked == true)
            {
                byte[] SENDBYTES = Encoding.ASCII.GetBytes("^0!GO" + Constants.vbCrLf
                                     + "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf
                                     + "^0*JLPAR [ 60 1 0 3 10 180 0 30000 00:00 0 30000 0 0 1000 0]" + Constants.vbCrLf
                                     + "^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf
                                     + "^0*JOBPAR [ 2000 0 0 280 0 0 0 1 1 0 -1 () 1 1 55000 0 9 0 1 0 100 0 1 0 ]" + Constants.vbCrLf
                                     + "^0*OBJ [1 0 11 0 (ISO1_7x5)  (" + HTZTextBox.Text + " ) 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*OBJ [2 89 11 0 (ISO1_7x5)  (PA) 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*OBJ [3 0 0 0 (ISO1_7x5)  (" + ANRTextBox.Text + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*OBJ [4 64 0 0 (ISO1_7x5)  (" + BTIDTextBox.Text + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*OBJ [5 87 0 0 (ISO1_7x5)  (" + ControllerIdTextBox.Text + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*ENDJOB []" + Constants.vbCrLf
                                     + "^0*ENDLJSCRIPT []" + Constants.vbCrLf
                                    );
                TCPCLIENT.Client.Send(SENDBYTES);
            }

            if (SizeBigChkBox.Checked == true)
            {
                byte[] SENDBYTES = Encoding.ASCII.GetBytes("^0!GO" + Constants.vbCrLf
                                     + "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf
                                     + "^0*JLPAR [ 90 1 0 3 1000 180 0 30000 00:00 0 30000 0 0 1000 0]" + Constants.vbCrLf
                                     + "^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf
                                     + "^0*JOBPAR [ 2000 0 0 380 0 0 0 1 1 0 -1 () 1 1 55000 0 21 0 1 0 100 0 1 0 ]" + Constants.vbCrLf
                                     + "^0*OBJ [1 0 16 0 (ISO1_9x7)  (" + HTZTextBox.Text + " ) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*OBJ [2 251 16 0 (ISO1_9x7)  (PA) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*OBJ [3 0 0 0 (ISO1_9x7)  (" + ANRTextBox.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*OBJ [4 176 0 0 (ISO1_9x7)  (" + BTIDTextBox.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*OBJ [5 242 0 0 (ISO1_9x7)  (" + ControllerIdTextBox.Text + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                                     + "^0*ENDJOB []" + Constants.vbCrLf
                                     + "^0*ENDLJSCRIPT []" + Constants.vbCrLf
                                    );
                TCPCLIENT.Client.Send(SENDBYTES);

            }

            byte[] SENDBYTES2 = Encoding.ASCII.GetBytes("^0=CC0" + Constants.vbTab + ExpectedQuantityTxtBox.Text + Constants.vbTab + "3999" + Constants.vbCrLf
);
            TCPCLIENT.Client.Send(SENDBYTES2);

            byte[] SENDBYTES3 = Encoding.ASCII.GetBytes("^0!EQ" + Constants.vbCrLf
);
            TCPCLIENT.Client.Send(SENDBYTES3);


        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (SizeStandardChkBox.Checked == true)
            {
                SizeSmallChkBox.Checked = false;
                SizeBigChkBox.Checked = false;

            }
        }



        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (SizeSmallChkBox.Checked == true)
            {
                SizeStandardChkBox.Checked = false;
                SizeBigChkBox.Checked = false;

            }

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (SizeBigChkBox.Checked == true)
            {
                SizeStandardChkBox.Checked = false;
                SizeSmallChkBox.Checked = false;

            }
        }



        private void Button4_Click(object sender, EventArgs e)
        {
            StartProductionButton.BackColor = Color.Gray;
            ANRTextBox.ResetText();
            HTZTextBox.ResetText();
            BTIDTextBox.ResetText();
            ExpectedQuantityTxtBox.ResetText();

        }

        private void AerotecLogoPicture_Click(object sender, EventArgs e)
        {

        }

        private void ContactInformationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}