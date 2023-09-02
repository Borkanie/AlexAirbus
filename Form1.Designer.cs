using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Aerotec
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PictureBox1 = new PictureBox();
            GroupBox1 = new GroupBox();
            Label1 = new Label();
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            TextBox3 = new TextBox();
            ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            RectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            RectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            RectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            PictureBox2 = new PictureBox();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            TextBox4 = new TextBox();
            TextBox4.TextChanged += new EventHandler(TextBox4_TextChanged);
            Timer1 = new Timer(components);
            GroupBox2 = new GroupBox();
            TextBox8 = new TextBox();
            TextBox8.TextChanged += new EventHandler(TextBox8_TextChanged);
            Label9 = new Label();
            TextBox6 = new TextBox();
            TextBox6.TextChanged += new EventHandler(TextBox6_TextChanged);
            Label7 = new Label();
            TextBox5 = new TextBox();
            TextBox5.TextChanged += new EventHandler(TextBox5_TextChanged);
            Label6 = new Label();
            GroupBox3 = new GroupBox();
            TextBox11 = new TextBox();
            Label12 = new Label();
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            PictureBox3 = new PictureBox();
            PictureBox4 = new PictureBox();
            Label14 = new Label();
            Panel1 = new Panel();
            PictureBox5 = new PictureBox();
            TextBox14 = new TextBox();
            Button7 = new Button();
            Button7.Click += new EventHandler(Button7_Click);
            Label15 = new Label();
            ComboBox2 = new ComboBox();
            Label17 = new Label();
            ShapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            RectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            TextBox15 = new TextBox();
            TextBox16 = new TextBox();
            Label18 = new Label();
            TextBox7 = new TextBox();
            TextBox18 = new TextBox();
            TextBox19 = new TextBox();
            CheckBox4 = new CheckBox();
            CheckBox4.CheckedChanged += new EventHandler(CheckBox4_CheckedChanged);
            CheckBox2 = new CheckBox();
            CheckBox2.CheckedChanged += new EventHandler(CheckBox2_CheckedChanged);
            CheckBox3 = new CheckBox();
            CheckBox3.CheckedChanged += new EventHandler(CheckBox3_CheckedChanged);
            Label8 = new Label();
            Timer2 = new Timer(components);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            GroupBox2.SuspendLayout();
            GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox4).BeginInit();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox5).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(648, 26);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(397, 120);
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Italic, GraphicsUnit.Point, 0);
            GroupBox1.Location = new Point(5, 515);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(179, 181);
            GroupBox1.TabIndex = 1;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "BLAJ SA ";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(6, 16);
            Label1.Name = "Label1";
            Label1.Size = new Size(166, 156);
            Label1.TabIndex = 0;
            Label1.Text = resources.GetString("Label1.Text");
            // 
            // TextBox1
            // 
            TextBox1.Enabled = false;
            TextBox1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox1.Location = new Point(15, 36);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(190, 26);
            TextBox1.TabIndex = 2;
            // 
            // TextBox2
            // 
            TextBox2.Enabled = false;
            TextBox2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox2.Location = new Point(14, 68);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(116, 26);
            TextBox2.TabIndex = 3;
            // 
            // TextBox3
            // 
            TextBox3.Enabled = false;
            TextBox3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox3.Location = new Point(15, 100);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(272, 26);
            TextBox3.TabIndex = 4;
            // 
            // ShapeContainer1
            // 
            ShapeContainer1.Location = new Point(0, 0);
            ShapeContainer1.Margin = new Padding(0);
            ShapeContainer1.Name = "ShapeContainer1";
            ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] { RectangleShape4, RectangleShape3, RectangleShape1 });
            ShapeContainer1.Size = new Size(1310, 749);
            ShapeContainer1.TabIndex = 5;
            ShapeContainer1.TabStop = false;
            // 
            // RectangleShape4
            // 
            RectangleShape4.Location = new Point(6, 168);
            RectangleShape4.Name = "RectangleShape4";
            RectangleShape4.Size = new Size(292, 84);
            // 
            // RectangleShape3
            // 
            RectangleShape3.Location = new Point(324, 246);
            RectangleShape3.Name = "RectangleShape3";
            RectangleShape3.Size = new Size(308, 262);
            // 
            // RectangleShape1
            // 
            RectangleShape1.Location = new Point(6, 26);
            RectangleShape1.Name = "RectangleShape1";
            RectangleShape1.Size = new Size(291, 119);
            // 
            // PictureBox2
            // 
            PictureBox2.BorderStyle = BorderStyle.FixedSingle;
            PictureBox2.Image = (Image)resources.GetObject("PictureBox2.Image");
            PictureBox2.Location = new Point(320, 26);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(276, 120);
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox2.TabIndex = 6;
            PictureBox2.TabStop = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(12, 152);
            Label2.Name = "Label2";
            Label2.Size = new Size(40, 16);
            Label2.TabIndex = 9;
            Label2.Text = "Data:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(58, 152);
            Label3.Name = "Label3";
            Label3.Size = new Size(55, 16);
            Label3.TabIndex = 10;
            Label3.Text = "Label3";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(8, 187);
            Label4.Name = "Label4";
            Label4.Size = new Size(78, 13);
            Label4.TabIndex = 11;
            Label4.Text = "CONTROLOR:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(65, 226);
            Label5.Name = "Label5";
            Label5.Size = new Size(21, 13);
            Label5.TabIndex = 13;
            Label5.Text = "ID:";
            // 
            // TextBox4
            // 
            TextBox4.Location = new Point(92, 223);
            TextBox4.Name = "TextBox4";
            TextBox4.Size = new Size(121, 20);
            TextBox4.TabIndex = 14;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(TextBox8);
            GroupBox2.Controls.Add(Label9);
            GroupBox2.Controls.Add(TextBox6);
            GroupBox2.Controls.Add(Label7);
            GroupBox2.Controls.Add(TextBox5);
            GroupBox2.Controls.Add(Label6);
            GroupBox2.Location = new Point(5, 264);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(292, 245);
            GroupBox2.TabIndex = 1;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "INFORMATII COMANDA DE LUCRU";
            // 
            // TextBox8
            // 
            TextBox8.Location = new Point(56, 168);
            TextBox8.Name = "TextBox8";
            TextBox8.Size = new Size(116, 20);
            TextBox8.TabIndex = 3;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label9.Location = new Point(11, 171);
            Label9.Name = "Label9";
            Label9.Size = new Size(44, 13);
            Label9.TabIndex = 6;
            Label9.Text = "BTIDX";
            // 
            // TextBox6
            // 
            TextBox6.Location = new Point(55, 103);
            TextBox6.Name = "TextBox6";
            TextBox6.Size = new Size(174, 20);
            TextBox6.TabIndex = 2;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(20, 106);
            Label7.Name = "Label7";
            Label7.Size = new Size(32, 13);
            Label7.TabIndex = 2;
            Label7.Text = "HTZ";
            // 
            // TextBox5
            // 
            TextBox5.Location = new Point(56, 36);
            TextBox5.Name = "TextBox5";
            TextBox5.Size = new Size(116, 20);
            TextBox5.TabIndex = 1;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(3, 39);
            Label6.Name = "Label6";
            Label6.Size = new Size(54, 13);
            Label6.TabIndex = 0;
            Label6.Text = "ANR-Nr.";
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(TextBox11);
            GroupBox3.Controls.Add(Label12);
            GroupBox3.Location = new Point(390, 312);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(162, 100);
            GroupBox3.TabIndex = 2;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Cantitate";
            // 
            // TextBox11
            // 
            TextBox11.Location = new Point(62, 50);
            TextBox11.Name = "TextBox11";
            TextBox11.Size = new Size(94, 20);
            TextBox11.TabIndex = 4;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(6, 55);
            Label12.Name = "Label12";
            Label12.Size = new Size(58, 13);
            Label12.TabIndex = 0;
            Label12.Text = "NECESAR";
            // 
            // Button3
            // 
            Button3.BackColor = Color.FromArgb(224, 224, 224);
            Button3.Location = new Point(390, 429);
            Button3.Name = "Button3";
            Button3.Size = new Size(162, 23);
            Button3.TabIndex = 17;
            Button3.Text = "START PRODUCTIE";
            Button3.UseVisualStyleBackColor = false;
            // 
            // Button4
            // 
            Button4.BackColor = Color.Red;
            Button4.Location = new Point(441, 472);
            Button4.Name = "Button4";
            Button4.Size = new Size(75, 23);
            Button4.TabIndex = 18;
            Button4.Text = "STOP";
            Button4.UseVisualStyleBackColor = false;
            // 
            // PictureBox3
            // 
            PictureBox3.BorderStyle = BorderStyle.FixedSingle;
            PictureBox3.Image = (Image)resources.GetObject("PictureBox3.Image");
            PictureBox3.Location = new Point(658, 246);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(319, 263);
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox3.TabIndex = 19;
            PictureBox3.TabStop = false;
            // 
            // PictureBox4
            // 
            PictureBox4.Image = (Image)resources.GetObject("PictureBox4.Image");
            PictureBox4.Location = new Point(908, 603);
            PictureBox4.Name = "PictureBox4";
            PictureBox4.Size = new Size(117, 111);
            PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox4.TabIndex = 22;
            PictureBox4.TabStop = false;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Italic, GraphicsUnit.Point, 0);
            Label14.Location = new Point(872, 576);
            Label14.Name = "Label14";
            Label14.Size = new Size(191, 24);
            Label14.TabIndex = 23;
            Label14.Text = "Dezvoltat de BLAJ SA";
            // 
            // Panel1
            // 
            Panel1.Controls.Add(PictureBox5);
            Panel1.Controls.Add(TextBox14);
            Panel1.Controls.Add(Button7);
            Panel1.Controls.Add(Label15);
            Panel1.Controls.Add(ComboBox2);
            Panel1.Controls.Add(Label17);
            Panel1.Controls.Add(ShapeContainer2);
            Panel1.Location = new Point(0, 603);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(234, 146);
            Panel1.TabIndex = 24;
            // 
            // PictureBox5
            // 
            PictureBox5.Image = (Image)resources.GetObject("PictureBox5.Image");
            PictureBox5.Location = new Point(664, 46);
            PictureBox5.Name = "PictureBox5";
            PictureBox5.Size = new Size(313, 154);
            PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox5.TabIndex = 8;
            PictureBox5.TabStop = false;
            // 
            // TextBox14
            // 
            TextBox14.BackColor = Color.Lime;
            TextBox14.DataBindings.Add(new Binding("Text", My.MySettings.Default, "t1", true, DataSourceUpdateMode.OnPropertyChanged));
            TextBox14.Location = new Point(304, 46);
            TextBox14.Name = "TextBox14";
            TextBox14.Size = new Size(100, 20);
            TextBox14.TabIndex = 5;
            TextBox14.Text = My.MySettings.Default.t1;
            // 
            // Button7
            // 
            Button7.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button7.ForeColor = Color.Blue;
            Button7.Location = new Point(391, 339);
            Button7.Name = "Button7";
            Button7.Size = new Size(348, 115);
            Button7.TabIndex = 4;
            Button7.Text = "APASATI PENTRU CONECTARE SI INITIALIZARE JET3UP";
            Button7.UseVisualStyleBackColor = true;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label15.Location = new Point(460, 203);
            Label15.Name = "Label15";
            Label15.Size = new Size(205, 31);
            Label15.TabIndex = 1;
            Label15.Text = "Nume Controlor";
            // 
            // ComboBox2
            // 
            ComboBox2.BackColor = Color.FromArgb(224, 224, 224);
            ComboBox2.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboBox2.FormattingEnabled = true;
            ComboBox2.Items.AddRange(new object[] { "ALECU", "DOHOTARU", "BACIU", "NEGOESCU", "POENARIU", "CIREASA" });
            ComboBox2.Location = new Point(391, 238);
            ComboBox2.Name = "ComboBox2";
            ComboBox2.Size = new Size(348, 39);
            ComboBox2.TabIndex = 0;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Location = new Point(191, 49);
            Label17.Name = "Label17";
            Label17.Size = new Size(107, 13);
            Label17.TabIndex = 6;
            Label17.Text = "ADRESA IP JET3UP";
            // 
            // ShapeContainer2
            // 
            ShapeContainer2.Location = new Point(0, 0);
            ShapeContainer2.Margin = new Padding(0);
            ShapeContainer2.Name = "ShapeContainer2";
            ShapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] { RectangleShape2 });
            ShapeContainer2.Size = new Size(234, 146);
            ShapeContainer2.TabIndex = 9;
            ShapeContainer2.TabStop = false;
            // 
            // RectangleShape2
            // 
            RectangleShape2.Location = new Point(174, 25);
            RectangleShape2.Name = "RectangleShape2";
            RectangleShape2.Size = new Size(816, 484);
            // 
            // TextBox15
            // 
            TextBox15.Location = new Point(92, 184);
            TextBox15.Name = "TextBox15";
            TextBox15.Size = new Size(121, 20);
            TextBox15.TabIndex = 25;
            // 
            // TextBox16
            // 
            TextBox16.Location = new Point(6, 4);
            TextBox16.Name = "TextBox16";
            TextBox16.Size = new Size(1039, 20);
            TextBox16.TabIndex = 26;
            TextBox16.Text = "LEIBINGER JET3UP ACTIV";
            TextBox16.TextAlign = HorizontalAlignment.Center;
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Location = new Point(725, 515);
            Label18.Name = "Label18";
            Label18.Size = new Size(347, 39);
            Label18.TabIndex = 28;
            Label18.Text = resources.GetString("Label18.Text");
            Label18.Visible = false;
            // 
            // TextBox7
            // 
            TextBox7.Enabled = false;
            TextBox7.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox7.Location = new Point(136, 68);
            TextBox7.Name = "TextBox7";
            TextBox7.Size = new Size(69, 26);
            TextBox7.TabIndex = 29;
            // 
            // TextBox18
            // 
            TextBox18.Enabled = false;
            TextBox18.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox18.Location = new Point(211, 68);
            TextBox18.Name = "TextBox18";
            TextBox18.Size = new Size(76, 26);
            TextBox18.TabIndex = 30;
            // 
            // TextBox19
            // 
            TextBox19.Enabled = false;
            TextBox19.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox19.Location = new Point(211, 36);
            TextBox19.Name = "TextBox19";
            TextBox19.Size = new Size(76, 26);
            TextBox19.TabIndex = 31;
            TextBox19.Text = "PA";
            TextBox19.TextAlign = HorizontalAlignment.Center;
            // 
            // CheckBox4
            // 
            CheckBox4.AutoSize = true;
            CheckBox4.Location = new Point(556, 280);
            CheckBox4.Name = "CheckBox4";
            CheckBox4.Size = new Size(57, 17);
            CheckBox4.TabIndex = 3;
            CheckBox4.Text = "MARE";
            CheckBox4.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            CheckBox2.AutoSize = true;
            CheckBox2.Location = new Point(342, 280);
            CheckBox2.Name = "CheckBox2";
            CheckBox2.Size = new Size(45, 17);
            CheckBox2.TabIndex = 1;
            CheckBox2.Text = "MIC";
            CheckBox2.UseVisualStyleBackColor = true;
            // 
            // CheckBox3
            // 
            CheckBox3.AutoSize = true;
            CheckBox3.Checked = My.MySettings.Default.a;
            CheckBox3.CheckState = CheckState.Checked;
            CheckBox3.DataBindings.Add(new Binding("Checked", My.MySettings.Default, "a", true, DataSourceUpdateMode.OnPropertyChanged));
            CheckBox3.Location = new Point(431, 280);
            CheckBox3.Name = "CheckBox3";
            CheckBox3.Size = new Size(86, 17);
            CheckBox3.TabIndex = 2;
            CheckBox3.Text = "STANDARD";
            CheckBox3.UseVisualStyleBackColor = true;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.ForeColor = Color.FromArgb(0, 0, 192);
            Label8.Location = new Point(339, 259);
            Label8.Name = "Label8";
            Label8.Size = new Size(190, 13);
            Label8.TabIndex = 32;
            Label8.Text = "SELECTATI MARIMEA DORITA:";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1310, 749);
            Controls.Add(GroupBox1);
            Controls.Add(Panel1);
            Controls.Add(Label14);
            Controls.Add(PictureBox4);
            Controls.Add(PictureBox3);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(GroupBox3);
            Controls.Add(GroupBox2);
            Controls.Add(TextBox4);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(PictureBox2);
            Controls.Add(TextBox3);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Controls.Add(PictureBox1);
            Controls.Add(TextBox15);
            Controls.Add(TextBox16);
            Controls.Add(Label18);
            Controls.Add(TextBox19);
            Controls.Add(TextBox18);
            Controls.Add(TextBox7);
            Controls.Add(CheckBox4);
            Controls.Add(CheckBox3);
            Controls.Add(CheckBox2);
            Controls.Add(Label8);
            Controls.Add(ShapeContainer1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox4).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox5).EndInit();
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal PictureBox PictureBox1;
        internal GroupBox GroupBox1;
        internal Label Label1;
        internal TextBox TextBox1;
        internal TextBox TextBox2;
        internal TextBox TextBox3;
        internal Global.Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Global.Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape1;
        internal PictureBox PictureBox2;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal TextBox TextBox4;
        internal Timer Timer1;
        internal GroupBox GroupBox2;
        internal TextBox TextBox8;
        internal Label Label9;
        internal TextBox TextBox6;
        internal Label Label7;
        internal TextBox TextBox5;
        internal Label Label6;
        internal GroupBox GroupBox3;
        internal TextBox TextBox11;
        internal Label Label12;
        internal Button Button3;
        internal Button Button4;
        internal PictureBox PictureBox3;
        internal PictureBox PictureBox4;
        internal Label Label14;
        internal Panel Panel1;
        internal Button Button7;
        internal Label Label15;
        internal ComboBox ComboBox2;
        internal Label Label17;
        internal TextBox TextBox14;
        internal TextBox TextBox15;
        internal TextBox TextBox16;
        internal Label Label18;
        internal TextBox TextBox7;
        internal TextBox TextBox18;
        internal TextBox TextBox19;
        internal CheckBox CheckBox4;
        internal CheckBox CheckBox3;
        internal CheckBox CheckBox2;
        internal PictureBox PictureBox5;
        internal Label Label8;
        internal Global.Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape3;
        internal Global.Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer2;
        internal Global.Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape2;
        internal Timer Timer2;
        internal Global.Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape4;

    }
}