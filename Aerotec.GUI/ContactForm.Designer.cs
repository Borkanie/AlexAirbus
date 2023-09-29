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
            ContactTextBox = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            ContactTextBox.Location = new Point(12, 12);
            ContactTextBox.Multiline = true;
            ContactTextBox.Name = "textBox1";
            ContactTextBox.ReadOnly = true;
            ContactTextBox.Size = new Size(327, 220);
            ContactTextBox.TabIndex = 0;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 244);
            Controls.Add(ContactTextBox);
            Name = "ContactForm";
            Text = "ContactForm";
            Load += ContactForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ContactTextBox;
    }
}