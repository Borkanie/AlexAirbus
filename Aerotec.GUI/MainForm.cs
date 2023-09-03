using Aerotec.Data.Factories;
using Aerotec.Data.Model;
using Aerotec.GUI.Resources.Helper;
using Aerotec.GUI.ViewModel;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aerotec.GUI
{
    public partial class MainForm : Form
    {
        private TcpClient TCPCLIENT;
        private bool working = false;
        private ContactForm contactForm;
        private MyDataModel Id = new MyDataModel();
        private MyDataModel BTID = new MyDataModel();
        private MyDataModel HTZ = new MyDataModel();
        private MyDataModel ANR = new MyDataModel();

        public MainForm(LogInInformation logInInfo)
        {
            InitializeComponent();
            // Populate the ComboBox with enum values
            foreach (var size in Enum.GetValues(typeof(SizeEnum)))
            {
                SizeComboBox.Items.Add(size);
            }
            
            LinkTextBoxes();
            Id.MyTextProperty = logInInfo.User.Id;
        }

        private void LinkTextBoxes()
        {
            ControllerIdTextBox.DataBindings.Add("Text", Id, "MyTextProperty", true, DataSourceUpdateMode.OnPropertyChanged);
            DataControllerIdTextBox.DataBindings.Add("Text", Id, "MyTextProperty", true, DataSourceUpdateMode.OnPropertyChanged);

            BTIDTextBox.DataBindings.Add("Text", BTID, "MyTextProperty", true, DataSourceUpdateMode.OnPropertyChanged);
            DataBTIDTextBox.DataBindings.Add("Text", BTID, "MyTextProperty", true, DataSourceUpdateMode.OnPropertyChanged);

            HTZTextBox.DataBindings.Add("Text", HTZ, "MyTextProperty", true, DataSourceUpdateMode.OnPropertyChanged);
            DataHTZTextBox.DataBindings.Add("Text", HTZ, "MyTextProperty", true, DataSourceUpdateMode.OnPropertyChanged);

            ANRTextBox.DataBindings.Add("Text", ANR, "MyTextProperty", true, DataSourceUpdateMode.OnPropertyChanged);
            DataANRTextBox.DataBindings.Add("Text", ANR, "MyTextProperty", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void ExpectedQuantityTxtBox_Click(object sender, EventArgs e)
        {
            if (!working)
            {
                byte[] SENDBYTES;
                switch (SizeComboBox.SelectedItem)
                {
                    case SizeEnum.Mic:
                        SENDBYTES = Encoding.ASCII.GetBytes("^0!GO" + Constants.vbCrLf
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
                        break;
                    case SizeEnum.Standard:
                        SENDBYTES = Encoding.ASCII.GetBytes("^0!GO" + Constants.vbCrLf
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
                        break;
                    case SizeEnum.Mare:
                        SENDBYTES = Encoding.ASCII.GetBytes("^0!GO" + Constants.vbCrLf
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
                        break;
                    default:
                        SENDBYTES = null;
                        break;
                }
                if (SENDBYTES != null)
                {
                    TCPCLIENT.Client.Send(SENDBYTES);
                }
                byte[] SENDBYTES2 = Encoding.ASCII.GetBytes("^0=CC0" + Constants.vbTab + ExpectedQuantityTxtBox.Text + Constants.vbTab + "3999" + Constants.vbCrLf);
                TCPCLIENT.Client.Send(SENDBYTES2);

                byte[] SENDBYTES3 = Encoding.ASCII.GetBytes("^0!EQ" + Constants.vbCrLf);
                TCPCLIENT.Client.Send(SENDBYTES3);

            }
            else
            {

            }
            working = !working;
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            if (contactForm == null)
            {
                contactForm = new ContactForm();
                contactForm.FormClosed += ContactForm_FormClosed;
                contactForm.Show();
            }
            else
            {
                contactForm.Show();
            }
        }

        private void ContactForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            contactForm = null;
        }
    }
}
