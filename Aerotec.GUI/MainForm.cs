// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Aerotec.Data.Factories;
using Aerotec.Data.Helper;
using Aerotec.Data.Interface.Services;
using Aerotec.Data.Model;
using Aerotec.Data.Resources;
using Aerotec.Data.Services;
using Aerotec.GUI.Resources.Helper;
using Aerotec.GUI.ViewModel;
using Microsoft.VisualBasic;

namespace Aerotec.GUI
{
    public partial class MainForm : Form
    {
        private IClientService jet3UpClientService;
        private bool working = false;
        private ContactForm contactForm;
        private TextBindingModel ControllerId = new();
        private TextBindingModel ControllerName = new();
        private TextBindingModel BTID = new();
        private TextBindingModel HTZ = new();
        private TextBindingModel ANR = new();
        private bool DEBUG = true;
        private const int OriginalFontSize = 9;
        public MainForm(LogInInformation logInInfo)
        {
            InitializeComponent();
            LinkTextBoxes();
            SetupFontSizeCombobox();

            ControllerId.Content = logInInfo.User.Id;
            ControllerName.Content = logInInfo.User.Name;
            ActiveControl = ExpectedQuantityTxtBox;

            SetUpQuantityButtonAndStartbutton();
            StartJet3UpClient(logInInfo);
            SetUpResize();
        }

        #region OnLoad

        private void LinkTextBoxes()
        {
            _ = ControllerTextBox.DataBindings.Add("Text", ControllerName, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);

            _ = ControllerIdTextBox.DataBindings.Add("Text", ControllerId, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            _ = DataControllerIdTextBox.DataBindings.Add("Text", ControllerId, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);

            _ = BTIDTextBox.DataBindings.Add("Text", BTID, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            _ = DataBTIDTextBox.DataBindings.Add("Text", BTID, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);

            _ = HTZTextBox.DataBindings.Add("Text", HTZ, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            _ = DataHTZTextBox.DataBindings.Add("Text", HTZ, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);

            _ = ANRTextBox.DataBindings.Add("Text", ANR, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            _ = DataANRTextBox.DataBindings.Add("Text", ANR, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void SetUpQuantityButtonAndStartbutton()
        {
            CurrentQuantityTextBox.Text = "0";
            StartStopButton.BackColor = Color.Green;
            StartStopButton.Text = "START PRODUCTIE";
            CurrentQuantityTextBox.TextChanged += PrintedQuantityTextBox_TextChanged;
        }

        private void SetupFontSizeCombobox()
        {
            // Populate the ComboBox with enum values
            foreach (var size in Enum.GetValues(typeof(SizeEnum)))
            {
                _ = SizeComboBox.Items.Add(size);
            }
            SizeComboBox.SelectedIndex = 0;
        }

        private void SetUpResize()
        {
            MinimumSize = Size;
            SetMinim(this);
            ResizeEnd += Form1_Resize;
        }

        private void StartJet3UpClient(LogInInformation logInInfo)
        {
            if (!DEBUG)
            {
                jet3UpClientService = new TCPClientService();

            }
            else
            {
                jet3UpClientService = new TCPMockUpClient();
            }
            _ = jet3UpClientService.Connect(logInInfo.Address.ToString(), 3000);
            jet3UpClientService.Jet3UpMessageHendler += Jet3UpMessageHandler;
        }

        private void SetMinim(Control control)
        {
            foreach (Control child in control.Controls)
            {
                child.MinimumSize = child.Size;
                if (child.Controls.Count > 0)
                {
                    SetMinim(child);
                }
            }
        }
        #endregion

        #region Events
        private void Form1_Resize(object sender, EventArgs e)
        {
            ScaleControls();
        }
        private void PrintedQuantityTextBox_TextChanged(object? sender, EventArgs e)
        {
            int expected;
            int current;
            if (int.TryParse(ExpectedQuantityTxtBox.Text, out expected) && int.TryParse(CurrentQuantityTextBox.Text, out current))
            {
                if (current == expected - 1)
                {
                    StopWriting();
                    var dialog = MessageBox.Show("Doriti sa marcati finalul de comanda?", "Ultima piesa", MessageBoxButtons.YesNoCancel);
                    switch (dialog)
                    {
                        case DialogResult.Yes:
                            WriteFinal();
                            return;
                        case DialogResult.No:
                            StartWriting(1);
                            return;
                        default:
                            ResetUiElements();
                            Working = false;
                            return;
                    }
                }
                else
                {
                    if (current > expected - 1)
                    {
                        StopWriting();
                        Working = false;
                        ResetUiElements();
                        if (current == expected)
                        {
                            _ = MessageBox.Show("Comanda inscriptionata cu succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            _ = MessageBox.Show("Eroare in operatia de printare, numarul de piese printate nu are voie sa depaseasca numarul de piese din comanda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            else
            {
                if (expected != 0)
                {
                    _ = MessageBox.Show("Caractere gresite in casuta cu numarul de piese din comanda sau cu numarul actual de peise printate", "Caracter Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void ExpectedQuantityTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Jet3UpMessageHandler(object? sender, Jet3UpMessageHendlerEventArgs e)
        {
            if (e.Type == Jet3UpStatusMessageType.Error)
            {

                Working = false;

                _ = MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CurrentQuantityTextBox.Invoke(() =>
                {
                    CurrentQuantityTextBox.Text = (int.Parse(CurrentQuantityTextBox.Text) + 1).ToString();
                });

            }
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

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            Working = !Working;
        }
        #endregion

        #region Helpers
        private void ScaleControls()
        {
            float scaleX = (float)this.Width / this.MinimumSize.Width;
            float scaleY = (float)this.Height / this.MinimumSize.Height;

            ScaleControl(this, scaleX, scaleY);
        }

        private void ScaleControl(Control control, float scaleX, float scaleY)
        {
            foreach (Control child in control.Controls)
            {
                if (child.Anchor == AnchorStyles.Top || child.Anchor == AnchorStyles.Bottom)
                    child.Width = (int)(child.MinimumSize.Width * scaleX);
                if (child.Anchor == AnchorStyles.Left || child.Anchor == AnchorStyles.Right)
                    child.Height = (int)(child.MinimumSize.Height * scaleY);

                ScaleFont(child, scaleY);
                if (child.Controls.Count > 0)
                {
                    ScaleControl(child, scaleX, scaleY);
                }
            }
        }

        private void ScaleFont(Control control, float scale)
        {
            control.Font = new Font(control.Font.FontFamily, OriginalFontSize * scale, control.Font.Style, control.Font.Unit);
        }

        private void ResetUiElements()
        {
            StartStopButton.BackColor = Color.Green;
            StartStopButton.Text = "START PRODUCTIE";
            CurrentQuantityTextBox.Text = "0";
            Working = false;
        }

        private void StartWriting(int number = 0)
        {
            switch (SizeComboBox.SelectedItem)
            {
                case SizeEnum.Mic:
                    jet3UpClientService.StartWriting(FontSizeEnum.ISO1_5x3, HTZTextBox.Text, SignatureTextBox.Text, ANRTextBox.Text, BTIDTextBox.Text, ControllerIdTextBox.Text, number);
                    break;
                case SizeEnum.Standard:
                    jet3UpClientService.StartWriting(FontSizeEnum.ISO1_7x5, HTZTextBox.Text, SignatureTextBox.Text, ANRTextBox.Text, BTIDTextBox.Text, ControllerIdTextBox.Text, number);
                    break;
                case SizeEnum.Mare:
                    jet3UpClientService.StartWriting(FontSizeEnum.ISO1_9x7, HTZTextBox.Text, SignatureTextBox.Text, ANRTextBox.Text, BTIDTextBox.Text, ControllerIdTextBox.Text, number);
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
                jet3UpClientService.Send(message, true);
            }
            jet3UpClientService.Send("^0=CC0" + Constants.vbTab + ExpectedQuantityTxtBox.Text + Constants.vbTab + "3999" + Constants.vbCrLf);

            jet3UpClientService.Send("^0!EQ" + Constants.vbCrLf);

            Thread.Sleep(1000);

            StartStopButton.BackColor = Color.Green;
            StartStopButton.Text = "START";

            Working = false;
        }

        private void StopWriting()
        {
            jet3UpClientService.StopCommand();
        }

        private bool Working
        {
            get
            {
                return working;
            }
            set
            {
                if (working != value)
                {
                    if (value)
                    {
                        int res;
                        if (int.TryParse(ExpectedQuantityTxtBox.Text, out res) || res == 0)
                        {
                            _ = MessageBox.Show("Totalul de piese din comanda rtebuie sa fie un numar mai amre ca 0", "Eroare", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    StartStopWorking(value);
                    working = value;
                }
            }
        }

        private void StartStopWorking(bool start)
        {
            SizeComboBox.Enabled = !start;
            ControllerIdTextBox.Enabled = !start;
            HTZTextBox.Enabled = !start;
            BTIDTextBox.Enabled = !start;
            ANRTextBox.Enabled = !start;
            if (start)
            {
                StartWriting(int.Parse(ExpectedQuantityTxtBox.Text) - 1);
                StartStopButton.BackColor = Color.Red;
                StartStopButton.Text = "STOP";
            }
            else
            {
                StopWriting();
                StartStopButton.BackColor = Color.Green;
                StartStopButton.Text = "START";
                ResetUiElements();
            }
        }
        #endregion
    }
}
