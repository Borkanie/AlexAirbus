namespace Aerotec.GUI
{
    public partial class ContactForm : Form
    {
        private const string contactString = "Departament Tehnic\r\n\r\n" +
            "Ionescu Octavian - 0758.075.812\r\n" +
            "Stefan Cosmin -    0758.075.811\r\n" +
            "Militaru Andrei -  0745.186.686\r\n\r\n" +
            "Departament IT\r\n" +
            "Mihailov George - 0723.364.507\r\n\r\n" +
            "Comenzi \r\n" +
            "E-mail: office@blajsa.ro\r\n" +
            "Telefon : 031/423.14.11\r\n";

        public ContactForm()
        {
            InitializeComponent();

            // Set the form's border style to FixedSingle
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // Disable the Maximize button
            MaximizeBox = false;

            // Calculate the required size based on the content
            int width = 400; // Set a reasonable width
            int height = CalculateRequiredHeight(contactString, width);

            // Set the form's size
            Size = new Size(width, height);
            ContactTextBox.Dock = DockStyle.Fill; // Set Dock property to Fill
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            this.ContactTextBox.Text = contactString;
        }

        private int CalculateRequiredHeight(string text, int width)
        {
            // Create a temporary TextBox to measure the size
            using (var tempTextBox = new TextBox())
            {
                tempTextBox.Multiline = true;
                tempTextBox.Width = width;
                tempTextBox.Text = text;
                tempTextBox.WordWrap = true;
                tempTextBox.ScrollBars = ScrollBars.Vertical;

                // Measure the preferred size
                var preferredSize = tempTextBox.PreferredSize;

                // Add some extra height for padding
                return (int)preferredSize.Height + 20;
            }
        }
    }

}
