// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Aerotec.Data.Helper;
using Aerotec.Data.Interface.Services;
using Aerotec.Data.Model;
using Aerotec.Data.Resources;
using Aerotec.Data.Services;
using Aerotec.GUI.Resources.Helper;
using Aerotec.GUI.ViewModel;
using System.Security.Cryptography.Xml;

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

        /// <summary>
        /// Links up Text boxes to they're desired Dendent properties.
        /// </summary>
        private void LinkTextBoxes()
        {
            _ = ControllerTextBox.DataBindings.Add("Text", ControllerName, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);

            _ = ControllerIdTextBox.DataBindings.Add("Text", ControllerId, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            _ = DataControllerIdTextBox.DataBindings.Add("Text", ControllerId, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);

            _ = BTIDTextBox.DataBindings.Add("Text", BTID, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            _ = DataBTIDTextBox.DataBindings.Add("Text", BTID, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            BTIDTextBox.PreviewKeyDown += Scannare_PreviewKey;

            _ = HTZTextBox.DataBindings.Add("Text", HTZ, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            _ = DataHTZTextBox.DataBindings.Add("Text", HTZ, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            HTZTextBox.PreviewKeyDown += Scannare_PreviewKey;

            _ = ANRTextBox.DataBindings.Add("Text", ANR, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            _ = DataANRTextBox.DataBindings.Add("Text", ANR, nameof(TextBindingModel.Content), true, DataSourceUpdateMode.OnPropertyChanged);
            ANRTextBox.PreviewKeyDown += Scannare_PreviewKey;

        }

        private void Scannare_PreviewKey(object? sender, PreviewKeyDownEventArgs e)
        {


            if (e.KeyValue <= 20 && e.KeyValue!=8)
            {
                if(sender == ANRTextBox)
                {
                    HTZTextBox.Focus();
                    return;
                }
                if (sender == HTZTextBox)
                {
                    BTIDTextBox.Focus();
                    return;
                }
                if (sender == BTIDTextBox)
                {
                    ExpectedQuantityTxtBox.Focus();
                    return;
                }
                if (sender == ExpectedQuantityTxtBox)
                {
                    ANRTextBox.Focus();
                    return;
                }
            }
            
        }

        /// <summary>
        /// Sets up quantity button and start button color and text.
        /// Also links <see cref="CurrentQuantityTextBox.TextChanged"/> tp <see cref="PrintedQuantityTextBox_TextChanged(object?, EventArgs)"/>
        /// </summary>
        private void SetUpQuantityButtonAndStartbutton()
        {
            CurrentQuantityTextBox.Text = "0";
            StartStopButton.BackColor = Color.Green;
            StartStopButton.Text = "START PRODUCTIE";
            CurrentQuantityTextBox.TextChanged += PrintedQuantityTextBox_TextChanged;
        }

        /// <summary>
        /// Fills up ComboBoxes with values and selects default index.
        /// </summary>
        private void SetupComboBoxes()
        {
            // Populate the ComboBox with enum values
            foreach (var size in Enum.GetValues(typeof(SizeEnum)))
            {
                _ = SizeComboBox.Items.Add(size);
            }
            SizeComboBox.SelectedIndex = 1;
            SizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Populate the ComboBox with enum values
            foreach (var size in Enum.GetValues(typeof(MachineTypeEnum)))
            {
                _ = ComboBoxMachine.Items.Add(size);
            }
            ComboBoxMachine.SelectedIndex = 1;
            ComboBoxMachine.DropDownStyle = ComboBoxStyle.DropDownList;


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

            ComboBoxRotation.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Configures linkage for resize of the UI.
        /// </summary>
        private void SetUpResize()
        {
            MinimumSize = Size;
            SetMinim(this);
            ResizeEnd += Form1_Resize;
        }

        /// <summary>
        /// Sets up connection to Jet3Up client.
        /// </summary>
        private void StartJet3UpClient(LogInInformation logInInfo)
        {
            if (Log.DEBUG)
            {
                jet3UpClientService = new TCPMockUpClient();
            }
            else
            {
                jet3UpClientService = new TCPClientService();               
            }
            _ = jet3UpClientService.Connect(logInInfo.Address.ToString(), 3000);
            jet3UpClientService.Jet3UpMessageHendler += Jet3UpMessageHandler;
            jet3UpClientService.Jet3UpCommunicationInterrupted += Jet3UpClientService_Jet3UpCommunicationInterrupted;
        }

        /// <summary>
        /// Registeres the current size and location of a control as his minimum size and default location to be later used on resize.
        /// </summary>
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
        /// <summary>
        /// An event handler that will be called each time the communication to the machine will be interrupted.
        /// </summary>
        private void Jet3UpClientService_Jet3UpCommunicationInterrupted(object? sender, Jet3UpCommunicationInterruptedErrorEventArgs e)
        {
            if (jet3UpClientService is TCPClientService && e.ErrorWhenReading == false)
            {
                ((TCPClientService)jet3UpClientService).StopListening();
            }
            _ = MessageBox.Show(this, $"Eroare de comunicare cu aparatul procesul a fost intrerupt cu eroare \n{e.Exception.Message}", "Eroare de comunicare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Triggered each time <see cref="MainForm"/> finishes resizing.
        /// </summary>
        /// <param name="e">Contains information about the resize event.</param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            ScaleControls();
        }

        /// <summary>
        /// Checks if last command has been reached.
        /// </summary>
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

        /// <summary>
        /// Only allows digits.
        /// </summary>
        private void ExpectedQuantityTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == 16) && !(e.KeyChar == 20))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// An event handler that will interpret a message recieved by the <see cref="IClientService"/> used.
        /// </summary>
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

        /// <summary>
        /// Show a small form with contact information for BLAJ.SA to allow for maintenance.
        /// </summary>
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

        /// <summary>
        /// An event that cloeses the connection to the jet3UpCLientService if it is still available.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if(contactForm!= null)
            {
                contactForm.Close();
            }
            contactForm = null;
            jet3UpClientService.StopCommand();
        }

        /// <summary>
        /// Changes the state of the applicaiton from working to waiting.
        /// </summary>
        private void StartStopButton_Click(object sender, EventArgs e)
        {
            Working = !Working;
        }
        #endregion

        #region Helpers

        /// <summary>
        /// COmmand that will show a popup to the user that the application has finished orinting and that will reset UI elements.
        /// </summary>
        private void ComandIsComplete()
        {
            jet3UpClientService.StopCommand();
            Working = false;
            StartStopButton.BackColor = Color.Green;
            StartStopButton.Text = "START PRODUCTIE";
            CurrentQuantityTextBox.Text = "0";
            _ = MessageBox.Show("Comanda inscriptionata cu succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Asks the user for permission and tries to print FinalCommand message using black ink settings.
        /// It's only called when black ink is chosen.
        /// </summary>
        private void FinalComand()
        {
            jet3UpClientService.StopCommand();
            var dialog = MessageBox.Show("Doriti sa marcati finalul de comanda?", "Ultima piesa", MessageBoxButtons.YesNo);
            switch (dialog)
            {
                case DialogResult.Yes:
                    DateTime currentDate = DateTime.Now;
                    var formattedDate = currentDate.ToString("dd/MM/yyyy");

                    var anzahl = formattedDate + $" Anzahl Soll:{ExpectedQuantityTxtBox.Text} Ist:{CurrentQuantityTextBox.Text}";
                    jet3UpClientService.StartWriting((FontSizeEnum)SizeComboBox.SelectedItem, (int)ComboBoxRotation.SelectedItem, MachineTypeEnum.Neagra, HTZTextBox.Text, SignatureTextBox.Text, ANRTextBox.Text, BTIDTextBox.Text, ControllerIdTextBox.Text, 1, anzahl);
                    sentFinal = true;
                    var Stand = int.Parse(CurrentQuantityTextBox.Text) == int.Parse(ExpectedQuantityTxtBox.Text) ? "Fertig" : "Fahlend";
                    //$"Auftrag                                  HTZ-Nr.                 Index           PKZ         Soll        Ist     Stand"
                    WriteOnTxtFile($"{ANRTextBox.Text}                      {HTZTextBox.Text}                  {BTIDTextBox.Text}          {ControllerIdTextBox.Text}            {ExpectedQuantityTxtBox.Text}        {CurrentQuantityTextBox.Text}     {Stand}");
                    return;
                default:
                    StartStopWorking(false);
                    return;
            }
        }

        private void WriteOnTxtFile(string message)
        {
            try
            {

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string currentDate = DateTime.Now.ToString("dd.MM.yyyy");
                string filePath = Path.Combine(desktopPath, $"{currentDate}A.txt");
                // Check if the file exists, and if not, create it
                if (!File.Exists(filePath))
                {
                    using (StreamWriter writer = File.CreateText(filePath))
                    {
                        writer.WriteLine($"TargetsProtokill vom {currentDate}");
                        writer.WriteLine($"Auftrag                                  HTZ-Nr.                 Index           PKZ         Soll        Ist     Stand");
                        writer.WriteLine(message);
                    }
                }
                else
                {
                    // If the file already exists, append to it
                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        writer.WriteLine(message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Scales up a given control with the same ration as the <see cref="MainForm"/>
        /// </summary>
        private void ScaleControls()
        {
            float scaleX = (float)Width / MinimumSize.Width;
            float scaleY = (float)Height / MinimumSize.Height;

            ScaleControl(this, scaleX, scaleY);
        }

        /// <summary>
        /// Scales up and moves a control following a given scaling on each axis.
        /// Will call himself recusively for each child with the same scaling.
        /// </summary>
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

        /// <summary>
        /// Changes the applicaiton state from working to hold.
        /// </summary>
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

        /// <summary>
        /// Enables or disables features in the UI depending on the state.
        /// Sends start or stop message to <see cref="IClientService"/>.
        /// </summary>
        /// <param name="start">Desired state.</param>
        private void StartStopWorking(bool start)
        {
            sentFinal = false;
            SizeComboBox.Enabled = !start;
            HTZTextBox.Enabled = !start;
            BTIDTextBox.Enabled = !start;
            ANRTextBox.Enabled = !start;
            ComboBoxMachine.Enabled = !start;
            ComboBoxRotation.Enabled = !start;
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
                HTZTextBox.Text = "";
                BTIDTextBox.Text = "";
                ANRTextBox.Text = "";
                jet3UpClientService.StopCommand();
                StartStopButton.BackColor = Color.Green;
                StartStopButton.Text = "START PRODUCTIE";
                CurrentQuantityTextBox.Text = "0";
            }
        }
        #endregion

    }
}
