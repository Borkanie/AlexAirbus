namespace Aerotec
{
    partial class EditUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            CancelButton = new Button();
            SaveButton = new Button();
            btnAdd = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(443, 275);
            dataGridView1.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(261, 310);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Anulare";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(361, 310);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Salvati";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 293);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Adauga Utilizator";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 331);
            button1.Name = "button1";
            button1.Size = new Size(139, 29);
            button1.TabIndex = 4;
            button1.Text = "Sterge Utilizator";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRemove_Click;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 372);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(dataGridView1);
            Name = "EditUserForm";
            Text = "EditUserForm";
            Load += EditUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button CancelButton;
        private Button SaveButton;
        private Button btnAdd;
        private Button button1;
    }
}