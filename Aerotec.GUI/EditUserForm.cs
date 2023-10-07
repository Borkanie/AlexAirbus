using Aerotec.Data.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerotec
{
    public partial class EditUserForm : Form
    {
        private List<User> people;
        public EditUserForm()
        {
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            // Load the JSON data from the file
            string jsonFilePath = "Resources/Controllers.json";
            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                people = JsonConvert.DeserializeObject<List<User>>(jsonData);
            }
            else
            {
                people = new List<User>();
            }

            // Bind the DataGridView to the list of people
            dataGridView1.DataSource = people;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (string.IsNullOrEmpty(people[i].Id) || string.IsNullOrEmpty(people[i].Name))
                {
                    MessageBox.Show("Nu puteti alsa campuri incomplete.");
                    return;
                }
            }
            // Serialize the list of people back to JSON
            string jsonData = JsonConvert.SerializeObject(people, Formatting.Indented);
            File.WriteAllText("Resources/Controllers.json", jsonData);

            MessageBox.Show("Lista de controllori a fost updatata!");

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add a new empty person to the list and refresh the DataGridView
            people.Add(new User());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = people;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Remove the selected person(s) from the list and refresh the DataGridView
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    people.RemoveAt(row.Index);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = people;
            }
        }
    }
}
