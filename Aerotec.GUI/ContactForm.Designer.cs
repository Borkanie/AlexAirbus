// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

namespace Aerotec.GUI
{
    partial class ContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            ContactTextBox = new TextBox();
            SuspendLayout();
            // 
            // ContactTextBox
            // 
            ContactTextBox.Location = new Point(12, 12);
            ContactTextBox.Multiline = true;
            ContactTextBox.Name = "ContactTextBox";
            ContactTextBox.ReadOnly = true;
            ContactTextBox.Size = new Size(382, 253);
            ContactTextBox.TabIndex = 0;
            ContactTextBox.TextChanged += ContactTextBox_TextChanged;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 277);
            Controls.Add(ContactTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ContactForm";
            Text = "Contact";
            Load += ContactForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ContactTextBox;
    }
}