// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

namespace Aerotec.GUI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginButton = new Button();
            LogInIPTextBox = new TextBox();
            LoginIPLabel = new Label();
            LoginUserName = new Label();
            pictureBox1 = new PictureBox();
            LoginUserComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(103, 255);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(272, 84);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "APASATI PENTRU CONECTAREA LA JET3UP";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LogInIPTextBox
            // 
            LogInIPTextBox.Location = new Point(204, 187);
            LogInIPTextBox.Name = "LogInIPTextBox";
            LogInIPTextBox.Size = new Size(171, 27);
            LogInIPTextBox.TabIndex = 2;
            LogInIPTextBox.Text = "192.168.127.254";
            // 
            // LoginIPLabel
            // 
            LoginIPLabel.AutoSize = true;
            LoginIPLabel.Location = new Point(158, 190);
            LoginIPLabel.Name = "LoginIPLabel";
            LoginIPLabel.Size = new Size(24, 20);
            LoginIPLabel.TabIndex = 3;
            LoginIPLabel.Text = "IP:";
            // 
            // LoginUserName
            // 
            LoginUserName.AutoSize = true;
            LoginUserName.Location = new Point(103, 133);
            LoginUserName.Name = "LoginUserName";
            LoginUserName.Size = new Size(79, 20);
            LoginUserName.TabIndex = 4;
            LoginUserName.Text = "Controllor:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 97);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LoginUserComboBox
            // 
            LoginUserComboBox.FormattingEnabled = true;
            LoginUserComboBox.Location = new Point(204, 130);
            LoginUserComboBox.Name = "LoginUserComboBox";
            LoginUserComboBox.Size = new Size(171, 28);
            LoginUserComboBox.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 368);
            Controls.Add(pictureBox1);
            Controls.Add(LoginUserName);
            Controls.Add(LoginIPLabel);
            Controls.Add(LogInIPTextBox);
            Controls.Add(LoginButton);
            Controls.Add(LoginUserComboBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LoginButton;
        private TextBox LogInIPTextBox;
        private Label LoginIPLabel;
        private Label LoginUserName;
        private PictureBox pictureBox1;
        private ComboBox LoginUserComboBox;
    }
}