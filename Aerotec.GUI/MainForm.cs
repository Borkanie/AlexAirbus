using Aerotec.Data.Factories;
using Aerotec.Data.Helper;
using Aerotec.Data.Interface.Services;
using Aerotec.Data.Model;
using Aerotec.Data.Services;
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
        private IClientService jet3UpClientService;
        private bool working = false;
        private ContactForm contactForm;
        private TextBindingModel ControllerId = new TextBindingModel();
        private TextBindingModel ControllerName = new TextBindingModel();
        private TextBindingModel BTID = new TextBindingModel();
        private TextBindingModel HTZ = new TextBindingModel();
        private TextBindingModel ANR = new TextBindingModel();
        private bool DEBUG = true;
        public MainForm(LogInInformation logInInfo)
        {
            InitializeComponent();
            // Populate the ComboBox with enum values
            foreach (var size in Enum.GetValues(typeof(SizeEnum)))
            {
                SizeComboBox.Items.Add(size);
            }
            SizeComboBox.SelectedIndex = 0;
            LinkTextBoxes();
            ControllerId.Content = logInInfo.User.Id;
            ControllerName.Content = logInInfo.User.Name;

            CurrentQuantityTextBox.Text = "0";
            StartStopButton.BackColor = Color.Green;
            StartStopButton.Text = "START PRODUCTIE";
            CurrentQuantityTextBox.TextChanged += PrintedQuantityTextBox_TextChanged;
            if (!DEBUG)
            {
                jet3UpClientService = new TCPClientService();

            }
            else
            {
                jet3UpClientService = new TCPMockUpClient();
            }
            jet3UpClientService.Connect(logInInfo.Address.ToString(), 3000);
        }

        private void PrintedQuantityTextBox_TextChanged(object? sender, EventArgs e)
        {
            int expected = 0;
            int current = 0;
            if (int.TryParse(ExpectedQuantityTxtBox.Text, out expected) && int.TryParse(CurrentQuantityTextBox.Text, out current))
            {
                if (current == expected)
                {
                    var dialog = MessageBox.Show("Doriti sa marcati finalul de comanda?", "Ultima piesa", MessageBoxButtons.YesNoCancel);
                    switch (dialog)
                    {
                        case DialogResult.Yes:
                            WriteFinal();
                            break;
                        case DialogResult.No:
                            StartWriting();
                            break;
                        default:

                            break;
                    }
                    StartStopButton.BackColor = Color.Green;
                    StartStopButton.Text = "START PRODUCTIE";

                    working = !working;
                }
                if (current > expected)
                {
                    MessageBox.Show("Eroare in operatia de printare, numarul de piese printate nu are voie sa depaseasca numarul de piese din comanda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Caractere gresite in casuta cu numarul de piese din comanda sau cu numarul actual de peise printate", "Caracter Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartWriting()
        {
            switch (SizeComboBox.SelectedItem)
            {
                case SizeEnum.Mic:
                    jet3UpClientService.StartWriting(FontSizeEnum.ISO1_5x3, HTZTextBox.Text, SignatureTextBox.Text, ANRTextBox.Text, BTIDTextBox.Text, ControllerIdTextBox.Text, int.Parse(ExpectedQuantityTxtBox.Text));
                    break;
                case SizeEnum.Standard:
                    jet3UpClientService.StartWriting(FontSizeEnum.ISO1_5x3, HTZTextBox.Text, SignatureTextBox.Text, ANRTextBox.Text, BTIDTextBox.Text, ControllerIdTextBox.Text, int.Parse(ExpectedQuantityTxtBox.Text));
                    break;
                case SizeEnum.Mare:
                    jet3UpClientService.StartWriting(FontSizeEnum.ISO1_5x3, HTZTextBox.Text, SignatureTextBox.Text, ANRTextBox.Text, BTIDTextBox.Text, ControllerIdTextBox.Text, int.Parse(ExpectedQuantityTxtBox.Text));
                    break;
                default:
                    
                    break;
            }
        }

        private string GetFinalMessage()
        {
            DateTime currentDate = DateTime.Now;
            var formattedDate = currentDate.ToString("dd/MM/yyyy");

            return formattedDate + $" Anzahl Soll:{ExpectedQuantityTxtBox.Text} Ist:{CurrentQuantityTextBox.Text}";
        }

        private void WriteFinal()
        {
            var fin = GetFinalMessage();
            string message;
            switch (SizeComboBox.SelectedItem)
            {
                case SizeEnum.Mic:
                    
                    message = Jet3UpMessageBuilder.Start().Create().SetSize(FontSizeEnum.ISO1_5x3).Write(HTZTextBox.Text, SignatureTextBox.Text, ANRTextBox.Text, BTIDTextBox.Text, ControllerIdTextBox.Text, fin).End();
                    break;
                case SizeEnum.Standard:
                    message = Jet3UpMessageBuilder.Start().Create().SetSize(FontSizeEnum.ISO1_7x5).Write(HTZTextBox.Text, SignatureTextBox.Text, ANRTextBox.Text, BTIDTextBox.Text, ControllerIdTextBox.Text, fin).End();
                    break;
                case SizeEnum.Mare:
                    message = Jet3UpMessageBuilder.Start().Create().SetSize(FontSizeEnum.ISO1_9x7).Write(HTZTextBox.Text, SignatureTextBox.Text, ANRTextBox.Text, BTIDTextBox.Text, ControllerIdTextBox.Text, fin).End();
                    break;
                default:
                    message = null;
                    break;
            }
            if (message != null)
            {
                jet3UpClientService.Send(message);
            }
            jet3UpClientService.Send("^0=CC0" + Constants.vbTab + ExpectedQuantityTxtBox.Text + Constants.vbTab + "3999" + Constants.vbCrLf);

            jet3UpClientService.Send("^0!EQ" + Constants.vbCrLf);

            Thread.Sleep(1000);

            StartStopButton.BackColor = Color.Green;
            StartStopButton.Text = "START";

            working = false;
        }

        private void LinkTextBoxes()
        {
            ControllerTextBox.DataBindings.Add("Text", ControllerName, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);

            ControllerIdTextBox.DataBindings.Add("Text", ControllerId, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            DataControllerIdTextBox.DataBindings.Add("Text", ControllerId, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);

            BTIDTextBox.DataBindings.Add("Text", BTID, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            DataBTIDTextBox.DataBindings.Add("Text", BTID, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);

            HTZTextBox.DataBindings.Add("Text", HTZ, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            DataHTZTextBox.DataBindings.Add("Text", HTZ, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);

            ANRTextBox.DataBindings.Add("Text", ANR, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            DataANRTextBox.DataBindings.Add("Text", ANR, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ExpectedQuantityTxtBox_Click(object sender, EventArgs e)
        {
            if (!working)
            {
                StartWriting();
                StartStopButton.BackColor = Color.Red;
                StartStopButton.Text = "STOP";
            }
            else
            {
                StopWriting();
                StartStopButton.BackColor = Color.Green;
                StartStopButton.Text = "START";
            }
            working = !working;
        }

        private void StopWriting()
        {
            jet3UpClientService.StopCommand();
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
