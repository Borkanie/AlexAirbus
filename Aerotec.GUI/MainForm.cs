// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Aerotec.Data.Helper;
using Aerotec.Data.Interface.Services;
using Aerotec.Data.Model;
using Aerotec.Data.Resources;
using Aerotec.Data.Services;
using Aerotec.GUI.Resources.Helper;
using Aerotec.GUI.ViewModel;

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
        private bool sentFinal = false;
        private readonly Dictionary<Control, Tuple<Point, Size>> OriginalElements = new();
        public MainForm(LogInInformation logInInfo)
        {
            InitializeComponent();
            LinkTextBoxes();
            SetupComboBoxes();

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

        private void SetupComboBoxes()
        {
            // Populate the ComboBox with enum values
            foreach (var size in Enum.GetValues(typeof(SizeEnum)))
            {
                _ = SizeComboBox.Items.Add(size);
            }
            SizeComboBox.SelectedIndex = 1;

            // Populate the ComboBox with enum values
            foreach (var size in Enum.GetValues(typeof(MachineTypeEnum)))
            {
                _ = ComboBoxMachine.Items.Add(size);
            }
            ComboBoxMachine.SelectedIndex = 0;

            var rotationArray = new int[]
            {
                0,
                90,
                180,
                270
            };

            // Populate the ComboBox with enum values
            foreach (var size in rotationArray)
            {
                _ = ComboBoxRotation.Items.Add(size);
            }
            ComboBoxRotation.SelectedIndex = 0;
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
            jet3UpClientService.Jet3UpCommunicationInterrupted += Jet3UpClientService_Jet3UpCommunicationInterrupted;
        }

        private void SetMinim(Control control)
        {
            foreach (Control child in control.Controls)
            {
                if (!OriginalElements.ContainsKey(child))
                {
                    OriginalElements.Add(child, new Tuple<Point, Size>(child.Location, child.Size));
                    if (child.Controls.Count > 0)
                    {
                        SetMinim(child);
                    }
                }

            }
        }
        #endregion

        #region Events
        private void Jet3UpClientService_Jet3UpCommunicationInterrupted(object? sender, Jet3UpCommunicationInterruptedErrorEventArgs e)
        {
            if (jet3UpClientService is TCPClientService && e.ErrorWhenReading == false)
            {
                ((TCPClientService)jet3UpClientService).StopListening();
            }
            _ = MessageBox.Show(this, $"Eroare de comunicare cu aparatul procesul a fost intrerupt cu eroare \n{e.Exception.Message}", "Eroare de comunicare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            ScaleControls();
        }
        private void PrintedQuantityTextBox_TextChanged(object? sender, EventArgs e)
        {
            int expected;
            int current;
            if (CurrentQuantityTextBox.Text == "0")
            {
                return;
            }
            if (int.TryParse(ExpectedQuantityTxtBox.Text, out expected) && int.TryParse(CurrentQuantityTextBox.Text, out current))
            {
                if (current == expected)
                {
                    if ((MachineTypeEnum)ComboBoxMachine.SelectedItem == MachineTypeEnum.Neagra)
                    {
                        FinalComand();
                    }
                    else
                    {
                        ComandIsComplete();
                    }
                    return;
                }
                else
                {
                    if (current > expected)
                    {
                        ComandIsComplete();
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
                if (!sentFinal)
                {
                    CurrentQuantityTextBox.Invoke(() =>
                    {
                        CurrentQuantityTextBox.Text = e.Message;
                    });
                }
                else
                {
                    CurrentQuantityTextBox.Invoke(() =>
                    {
                        CurrentQuantityTextBox.Text = (int.Parse(CurrentQuantityTextBox.Text) + 1).ToString();
                    });
                }

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
            if (jet3UpClientService is TCPClientService)
            {
                ((TCPClientService)jet3UpClientService).StopListening();
            }
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            Working = !Working;
        }
        #endregion

        #region Helpers
        private void ComandIsComplete()
        {
            StopWriting();
            Working = false;
            ResetUiElements();
            CurrentQuantityTextBox.Text = "0";
            _ = MessageBox.Show("Comanda inscriptionata cu succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FinalComand()
        {
            StopWriting();
            var dialog = MessageBox.Show("Doriti sa marcati finalul de comanda?", "Ultima piesa", MessageBoxButtons.YesNo);
            switch (dialog)
            {
                case DialogResult.Yes:
                    DateTime currentDate = DateTime.Now;
                    var formattedDate = currentDate.ToString("dd/MM/yyyy");

                    var anzahl = formattedDate + $" Anzahl Soll:{ExpectedQuantityTxtBox.Text} Ist:{CurrentQuantityTextBox.Text}";
                    jet3UpClientService.StartWriting((FontSizeEnum)SizeComboBox.SelectedItem, (int)ComboBoxRotation.SelectedItem, MachineTypeEnum.Neagra, HTZTextBox.Text, SignatureTextBox.Text, ANRTextBox.Text, BTIDTextBox.Text, ControllerIdTextBox.Text, 1, anzahl);
                    sentFinal = true;
                    return;
                default:
                    StartStopWorking(false);
                    return;
            }
        }
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
                var originalLocation = OriginalElements[child].Item1;
                var originalSize = OriginalElements[child].Item2;

                child.Location = new Point((int)(originalLocation.X * scaleX), (int)(originalLocation.Y * scaleY));
                child.Size = new Size((int)(originalSize.Width * scaleX), (int)(originalSize.Height * scaleY));

                child.Font = new Font(child.Font.FontFamily, OriginalFontSize * scaleY, child.Font.Style);

                ScaleControl(child, scaleX, scaleY);
            }
        }

        private void ResetUiElements()
        {
            StartStopButton.BackColor = Color.Green;
            StartStopButton.Text = "START PRODUCTIE";
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
                        if (!int.TryParse(ExpectedQuantityTxtBox.Text, out res) || res == 0)
                        {
                            _ = MessageBox.Show("Totalul de piese din comanda trebuie sa fie un numar mai mare ca 0", "Eroare", MessageBoxButtons.OK);
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
            sentFinal = false;
            SizeComboBox.Enabled = !start;
            ControllerIdTextBox.Enabled = !start;
            HTZTextBox.Enabled = !start;
            BTIDTextBox.Enabled = !start;
            ANRTextBox.Enabled = !start;
            if (start)
            {


                jet3UpClientService.StartWriting((FontSizeEnum)SizeComboBox.SelectedItem,
                                                    (int)ComboBoxRotation.SelectedItem,
                                                    (MachineTypeEnum)ComboBoxMachine.SelectedItem,
                                                    HTZTextBox.Text,
                                                    SignatureTextBox.Text,
                                                    ANRTextBox.Text,
                                                    BTIDTextBox.Text,
                                                    ControllerIdTextBox.Text,
                                                    int.Parse(ExpectedQuantityTxtBox.Text),
                                                    null);

                StartStopButton.BackColor = Color.Red;
                StartStopButton.Text = "STOP";
            }
            else
            {
                StopWriting();
                ResetUiElements();
                CurrentQuantityTextBox.Text = "0";
            }
        }
        #endregion

    }
}
