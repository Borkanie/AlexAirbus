using Aerotec.Data;
using System.Net;

namespace Aerotec.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoginUserComboBox.DataSource = new List<string>()
            {
            "ALECU",
            "DOHOTARU",
            "BACIU",
            "NEGOESCU",
            "POENARIU",
            "CIREASA"
            };
            LogInIPTextBox.KeyPress += LogInIPTextBox_KeyPress;
            // Set the form's border style to FixedSingle
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // Disable the Maximize button
            MaximizeBox = false;

            LoginUserComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(LoginUserComboBox.SelectedItem == null)
            {
                MessageBox.Show("Va rugam selectati un utilizator");
                return;
            }
            if(!IPAddress.TryParse(LogInIPTextBox.Text, out IPAddress ipAddress))
            {
                MessageBox.Show("Adresa IP a utilajului nu este corecta");
                return;
            }
            var logInInfo = new LogInInformation(LoginUserComboBox.SelectedItem.ToString(),LogInIPTextBox.Text);
            var mainForm = new MainForm(logInInfo);
            mainForm.FormClosed += MainForm_FormClosed;
            Visible = false;
            mainForm.Show();
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