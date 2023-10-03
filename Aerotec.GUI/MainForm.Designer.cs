// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

namespace Aerotec.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            INFORMATI = new GroupBox();
            DataANRTextBox = new TextBox();
            DataBTIDTextBox = new TextBox();
            DataControllerIdTextBox = new TextBox();
            SignatureTextBox = new TextBox();
            DataHTZTextBox = new TextBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            ControllerIdTextBox = new TextBox();
            ControllerTextBox = new TextBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            BTIDTextBox = new TextBox();
            HTZTextBox = new TextBox();
            ANRTextBox = new TextBox();
            label6 = new Label();
            groupBox4 = new GroupBox();
            label8 = new Label();
            CurrentQuantityTextBox = new TextBox();
            SizeComboBox = new ComboBox();
            ExpectedQuantityTxtBox = new TextBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            StartStopButton = new Button();
            ContactButton = new Button();
            INFORMATI.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // INFORMATI
            // 
            INFORMATI.Anchor = AnchorStyles.Top;
            INFORMATI.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            INFORMATI.Controls.Add(DataANRTextBox);
            INFORMATI.Controls.Add(DataBTIDTextBox);
            INFORMATI.Controls.Add(DataControllerIdTextBox);
            INFORMATI.Controls.Add(SignatureTextBox);
            INFORMATI.Controls.Add(DataHTZTextBox);
            INFORMATI.Location = new Point(27, 13);
            INFORMATI.Name = "INFORMATI";
            INFORMATI.Size = new Size(332, 105);
            INFORMATI.TabIndex = 0;
            INFORMATI.TabStop = false;
            INFORMATI.Text = "PREVIZUALIZARE:";
            // 
            // DataANRTextBox
            // 
            DataANRTextBox.Location = new Point(14, 63);
            DataANRTextBox.Name = "DataANRTextBox";
            DataANRTextBox.ReadOnly = true;
            DataANRTextBox.Size = new Size(115, 27);
            DataANRTextBox.TabIndex = 5;
            DataANRTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DataBTIDTextBox
            // 
            DataBTIDTextBox.Location = new Point(135, 63);
            DataBTIDTextBox.Name = "DataBTIDTextBox";
            DataBTIDTextBox.ReadOnly = true;
            DataBTIDTextBox.Size = new Size(73, 27);
            DataBTIDTextBox.TabIndex = 4;
            DataBTIDTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DataControllerIdTextBox
            // 
            DataControllerIdTextBox.Location = new Point(214, 63);
            DataControllerIdTextBox.Name = "DataControllerIdTextBox";
            DataControllerIdTextBox.ReadOnly = true;
            DataControllerIdTextBox.Size = new Size(112, 27);
            DataControllerIdTextBox.TabIndex = 3;
            DataControllerIdTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SignatureTextBox
            // 
            SignatureTextBox.Location = new Point(214, 23);
            SignatureTextBox.Name = "SignatureTextBox";
            SignatureTextBox.ReadOnly = true;
            SignatureTextBox.Size = new Size(112, 27);
            SignatureTextBox.TabIndex = 2;
            SignatureTextBox.Text = "PA";
            SignatureTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DataHTZTextBox
            // 
            DataHTZTextBox.Location = new Point(14, 23);
            DataHTZTextBox.Name = "DataHTZTextBox";
            DataHTZTextBox.ReadOnly = true;
            DataHTZTextBox.Size = new Size(194, 27);
            DataHTZTextBox.TabIndex = 0;
            DataHTZTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(ControllerIdTextBox);
            groupBox2.Controls.Add(ControllerTextBox);
            groupBox2.Location = new Point(27, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 122);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "UTILIZATOR";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(102, 72);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 6;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 5;
            label1.Text = "CONTROLOR:";
            // 
            // ControllerIdTextBox
            // 
            ControllerIdTextBox.Anchor = AnchorStyles.Left;
            ControllerIdTextBox.Location = new Point(168, 69);
            ControllerIdTextBox.Name = "ControllerIdTextBox";
            ControllerIdTextBox.ReadOnly = true;
            ControllerIdTextBox.Size = new Size(158, 27);
            ControllerIdTextBox.TabIndex = 4;
            // 
            // ControllerTextBox
            // 
            ControllerTextBox.Anchor = AnchorStyles.Left;
            ControllerTextBox.Location = new Point(168, 33);
            ControllerTextBox.Name = "ControllerTextBox";
            ControllerTextBox.ReadOnly = true;
            ControllerTextBox.Size = new Size(158, 27);
            ControllerTextBox.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(BTIDTextBox);
            groupBox3.Controls.Add(HTZTextBox);
            groupBox3.Controls.Add(ANRTextBox);
            groupBox3.Location = new Point(27, 299);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(332, 139);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "COMANDA DE LUCRU";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 105);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 9;
            label5.Text = "INDEX COMANDA:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(126, 72);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 8;
            label4.Text = "HTZ:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 40);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 7;
            label3.Text = "NUMAR COMADA:";
            // 
            // BTIDTextBox
            // 
            BTIDTextBox.Anchor = AnchorStyles.Bottom;
            BTIDTextBox.Location = new Point(168, 102);
            BTIDTextBox.Name = "BTIDTextBox";
            BTIDTextBox.Size = new Size(158, 27);
            BTIDTextBox.TabIndex = 6;
            // 
            // HTZTextBox
            // 
            HTZTextBox.Anchor = AnchorStyles.Bottom;
            HTZTextBox.Location = new Point(168, 69);
            HTZTextBox.Name = "HTZTextBox";
            HTZTextBox.Size = new Size(158, 27);
            HTZTextBox.TabIndex = 5;
            // 
            // ANRTextBox
            // 
            ANRTextBox.Anchor = AnchorStyles.Right;
            ANRTextBox.Location = new Point(168, 36);
            ANRTextBox.Name = "ANRTextBox";
            ANRTextBox.Size = new Size(158, 27);
            ANRTextBox.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 33);
            label6.Name = "label6";
            label6.Size = new Size(214, 17);
            label6.TabIndex = 3;
            label6.Text = "SELECTATI MARIMEA DORITA:";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Right;
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(CurrentQuantityTextBox);
            groupBox4.Controls.Add(SizeComboBox);
            groupBox4.Controls.Add(ExpectedQuantityTxtBox);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(393, 170);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(395, 148);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "MARIMEA SI CANTITATE";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(33, 79);
            label8.Name = "label8";
            label8.Size = new Size(181, 17);
            label8.TabIndex = 10;
            label8.Text = "TOTAL PIESE COMANDA:";
            // 
            // CurrentQuantityTextBox
            // 
            CurrentQuantityTextBox.Anchor = AnchorStyles.Right;
            CurrentQuantityTextBox.Location = new Point(220, 115);
            CurrentQuantityTextBox.Name = "CurrentQuantityTextBox";
            CurrentQuantityTextBox.ReadOnly = true;
            CurrentQuantityTextBox.Size = new Size(151, 27);
            CurrentQuantityTextBox.TabIndex = 9;
            CurrentQuantityTextBox.Text = "0";
            // 
            // SizeComboBox
            // 
            SizeComboBox.Anchor = AnchorStyles.Right;
            SizeComboBox.FormattingEnabled = true;
            SizeComboBox.Location = new Point(220, 26);
            SizeComboBox.Name = "SizeComboBox";
            SizeComboBox.Size = new Size(151, 28);
            SizeComboBox.TabIndex = 8;
            // 
            // ExpectedQuantityTxtBox
            // 
            ExpectedQuantityTxtBox.Anchor = AnchorStyles.Right;
            ExpectedQuantityTxtBox.Location = new Point(220, 69);
            ExpectedQuantityTxtBox.Name = "ExpectedQuantityTxtBox";
            ExpectedQuantityTxtBox.Size = new Size(151, 27);
            ExpectedQuantityTxtBox.TabIndex = 7;
            ExpectedQuantityTxtBox.Text = "0";
            ExpectedQuantityTxtBox.KeyPress += ExpectedQuantityTxtBox_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(86, 115);
            label7.Name = "label7";
            label7.Size = new Size(128, 17);
            label7.TabIndex = 6;
            label7.Text = "PIESE MARCATE:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(672, 339);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 115);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(393, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(395, 112);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // StartStopButton
            // 
            StartStopButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            StartStopButton.Location = new Point(393, 361);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(157, 63);
            StartStopButton.TabIndex = 7;
            StartStopButton.Text = "START";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStopButton_Click;
            // 
            // ContactButton
            // 
            ContactButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ContactButton.Location = new Point(571, 361);
            ContactButton.Name = "ContactButton";
            ContactButton.Size = new Size(86, 63);
            ContactButton.TabIndex = 8;
            ContactButton.Text = "CONTACT";
            ContactButton.UseVisualStyleBackColor = true;
            ContactButton.Click += ContactButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            Controls.Add(ContactButton);
            Controls.Add(StartStopButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(INFORMATI);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Interfata Jet3Up";
            INFORMATI.ResumeLayout(false);
            INFORMATI.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox INFORMATI;
        private TextBox DataANRTextBox;
        private TextBox DataBTIDTextBox;
        private TextBox DataControllerIdTextBox;
        private TextBox SignatureTextBox;
        private TextBox DataHTZTextBox;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private TextBox ControllerIdTextBox;
        private TextBox ControllerTextBox;
        private GroupBox groupBox3;
        private TextBox ANRTextBox;
        private Label label3;
        private TextBox BTIDTextBox;
        private TextBox HTZTextBox;
        private Label label5;
        private Label label4;
        private Label label6;
        private GroupBox groupBox4;
        private ComboBox SizeComboBox;
        private TextBox ExpectedQuantityTxtBox;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button StartStopButton;
        private Button ContactButton;
        private Label label8;
        private TextBox CurrentQuantityTextBox;
    }
}