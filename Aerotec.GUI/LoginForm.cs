using Aerotec.Data.Factories;
using Aerotec.Data.Model;
using System.Net;

namespace Aerotec.GUI
{
    public partial class LoginForm : Form
    {
        private List<string> comboBoxNames;
        public LoginForm()
        {
            InitializeComponent();

            // Initialize the ComboBox with some initial data (if needed)
            comboBoxNames = UserFactory.GetUserNames();

            // Assign the DataSource
            LoginUserComboBox.DataSource = comboBoxNames;

            // Setup keyu press event handler to deal with Not number characters
            LogInIPTextBox.KeyPress += LogInIPTextBox_KeyPress;

            // Set the form's border style to FixedSingle
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // Disable the Maximize button
            MaximizeBox = false;

            LoginUserComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            if (LoginUserComboBox.SelectedItem == null)
            {
                _ = MessageBox.Show("Va rugam selectati un utilizator");
                return;
            }
            if (!IPAddress.TryParse(LogInIPTextBox.Text, out IPAddress ipAddress))
            {
                _ = MessageBox.Show("Adresa IP a utilajului nu este corecta");
                return;
            }
            try
            {
                var logInInfo = new LogInInformation(
                UserFactory.GetUsers().First(x => string.Equals(x.Name, LoginUserComboBox.SelectedItem.ToString())),
                LogInIPTextBox.Text);
                var mainForm = new MainForm(logInInfo);
                mainForm.FormClosed += MainForm_FormClosed;
                Visible = false;
                mainForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Eroare de conectare la masina \n{ex.Message}", "Eroare conectare", MessageBoxButtons.OK);
            }
            
        }

        private void MainForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void LogInIPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a dot (decimal point)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Prevent the character from being entered into the TextBox
                e.Handled = true;
            }
        }
    }
}