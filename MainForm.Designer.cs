using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Aerotec
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MainForm : Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Aerotec.My.MySettings mySettings1 = new Aerotec.My.MySettings();
            this.AerotecLogoPicture = new System.Windows.Forms.PictureBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ContactInformationLabel = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.RectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.RectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.RectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.AircraftPicture = new System.Windows.Forms.PictureBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.ControllerLabel = new System.Windows.Forms.Label();
            this.ControllerIdLabel = new System.Windows.Forms.Label();
            this.ControllerIdTextBox = new System.Windows.Forms.TextBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.InputDataGroupBox = new System.Windows.Forms.GroupBox();
            this.BTIDTextBox = new System.Windows.Forms.TextBox();
            this.BTIDLabel = new System.Windows.Forms.Label();
            this.HTZTextBox = new System.Windows.Forms.TextBox();
            this.HTZLabel = new System.Windows.Forms.Label();
            this.ANRTextBox = new System.Windows.Forms.TextBox();
            this.ANRLabel = new System.Windows.Forms.Label();
            this.QuantityGroupBox = new System.Windows.Forms.GroupBox();
            this.ExpectedQuantityTxtBox = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.StartProductionButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.MachinePicture = new System.Windows.Forms.PictureBox();
            this.BlajSAPicture = new System.Windows.Forms.PictureBox();
            this.DeveloperLabel = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.TextBox14 = new System.Windows.Forms.TextBox();
            this.Button7 = new System.Windows.Forms.Button();
            this.Label15 = new System.Windows.Forms.Label();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.ShapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.RectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ControllerTextBox = new System.Windows.Forms.TextBox();
            this.TextBox16 = new System.Windows.Forms.TextBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.TextBox18 = new System.Windows.Forms.TextBox();
            this.TextBox19 = new System.Windows.Forms.TextBox();
            this.SizeBigChkBox = new System.Windows.Forms.CheckBox();
            this.SizeSmallChkBox = new System.Windows.Forms.CheckBox();
            this.SizeStandardChkBox = new System.Windows.Forms.CheckBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AerotecLogoPicture)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AircraftPicture)).BeginInit();
            this.InputDataGroupBox.SuspendLayout();
            this.QuantityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MachinePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlajSAPicture)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // AerotecLogoPicture
            // 
            this.AerotecLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("AerotecLogoPicture.Image")));
            this.AerotecLogoPicture.Location = new System.Drawing.Point(648, 26);
            this.AerotecLogoPicture.Name = "AerotecLogoPicture";
            this.AerotecLogoPicture.Size = new System.Drawing.Size(397, 120);
            this.AerotecLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AerotecLogoPicture.TabIndex = 0;
            this.AerotecLogoPicture.TabStop = false;
            this.AerotecLogoPicture.Click += new System.EventHandler(this.AerotecLogoPicture_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ContactInformationLabel);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(5, 515);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(179, 181);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "BLAJ SA ";
            // 
            // ContactInformationLabel
            // 
            this.ContactInformationLabel.AutoSize = true;
            this.ContactInformationLabel.Location = new System.Drawing.Point(6, 16);
            this.ContactInformationLabel.Name = "ContactInformationLabel";
            this.ContactInformationLabel.Size = new System.Drawing.Size(218, 204);
            this.ContactInformationLabel.TabIndex = 0;
            this.ContactInformationLabel.Text = resources.GetString("ContactInformationLabel.Text");
            // 
            // TextBox1
            // 
            this.TextBox1.Enabled = false;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(15, 36);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(190, 30);
            this.TextBox1.TabIndex = 2;
            // 
            // TextBox2
            // 
            this.TextBox2.Enabled = false;
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.Location = new System.Drawing.Point(14, 68);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(116, 30);
            this.TextBox2.TabIndex = 3;
            // 
            // TextBox3
            // 
            this.TextBox3.Enabled = false;
            this.TextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.Location = new System.Drawing.Point(15, 100);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(272, 30);
            this.TextBox3.TabIndex = 4;
            // 
            // ShapeContainer1
            // 
            this.ShapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer1.Name = "ShapeContainer1";
            this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.RectangleShape4,
            this.RectangleShape3,
            this.RectangleShape1});
            this.ShapeContainer1.Size = new System.Drawing.Size(1310, 749);
            this.ShapeContainer1.TabIndex = 5;
            this.ShapeContainer1.TabStop = false;
            // 
            // RectangleShape4
            // 
            this.RectangleShape4.Location = new System.Drawing.Point(6, 168);
            this.RectangleShape4.Name = "RectangleShape4";
            this.RectangleShape4.Size = new System.Drawing.Size(292, 84);
            // 
            // RectangleShape3
            // 
            this.RectangleShape3.Location = new System.Drawing.Point(324, 246);
            this.RectangleShape3.Name = "RectangleShape3";
            this.RectangleShape3.Size = new System.Drawing.Size(308, 262);
            // 
            // RectangleShape1
            // 
            this.RectangleShape1.Location = new System.Drawing.Point(6, 26);
            this.RectangleShape1.Name = "RectangleShape1";
            this.RectangleShape1.Size = new System.Drawing.Size(291, 119);
            // 
            // AircraftPicture
            // 
            this.AircraftPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AircraftPicture.Image = ((System.Drawing.Image)(resources.GetObject("AircraftPicture.Image")));
            this.AircraftPicture.Location = new System.Drawing.Point(320, 26);
            this.AircraftPicture.Name = "AircraftPicture";
            this.AircraftPicture.Size = new System.Drawing.Size(276, 120);
            this.AircraftPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AircraftPicture.TabIndex = 6;
            this.AircraftPicture.TabStop = false;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLabel.Location = new System.Drawing.Point(12, 152);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(50, 20);
            this.DataLabel.TabIndex = 9;
            this.DataLabel.Text = "Data:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(58, 152);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 20);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Label3";
            // 
            // ControllerLabel
            // 
            this.ControllerLabel.AutoSize = true;
            this.ControllerLabel.Location = new System.Drawing.Point(8, 187);
            this.ControllerLabel.Name = "ControllerLabel";
            this.ControllerLabel.Size = new System.Drawing.Size(95, 16);
            this.ControllerLabel.TabIndex = 11;
            this.ControllerLabel.Text = "CONTROLOR:";
            // 
            // ControllerIdLabel
            // 
            this.ControllerIdLabel.AutoSize = true;
            this.ControllerIdLabel.Location = new System.Drawing.Point(65, 226);
            this.ControllerIdLabel.Name = "ControllerIdLabel";
            this.ControllerIdLabel.Size = new System.Drawing.Size(23, 16);
            this.ControllerIdLabel.TabIndex = 13;
            this.ControllerIdLabel.Text = "ID:";
            // 
            // ControllerIdTextBox
            // 
            this.ControllerIdTextBox.Location = new System.Drawing.Point(92, 223);
            this.ControllerIdTextBox.Name = "ControllerIdTextBox";
            this.ControllerIdTextBox.Size = new System.Drawing.Size(121, 22);
            this.ControllerIdTextBox.TabIndex = 14;
            this.ControllerIdTextBox.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // InputDataGroupBox
            // 
            this.InputDataGroupBox.Controls.Add(this.BTIDTextBox);
            this.InputDataGroupBox.Controls.Add(this.BTIDLabel);
            this.InputDataGroupBox.Controls.Add(this.HTZTextBox);
            this.InputDataGroupBox.Controls.Add(this.HTZLabel);
            this.InputDataGroupBox.Controls.Add(this.ANRTextBox);
            this.InputDataGroupBox.Controls.Add(this.ANRLabel);
            this.InputDataGroupBox.Location = new System.Drawing.Point(5, 264);
            this.InputDataGroupBox.Name = "InputDataGroupBox";
            this.InputDataGroupBox.Size = new System.Drawing.Size(292, 245);
            this.InputDataGroupBox.TabIndex = 1;
            this.InputDataGroupBox.TabStop = false;
            this.InputDataGroupBox.Text = "INFORMATII COMANDA DE LUCRU";
            // 
            // BTIDTextBox
            // 
            this.BTIDTextBox.Location = new System.Drawing.Point(56, 168);
            this.BTIDTextBox.Name = "BTIDTextBox";
            this.BTIDTextBox.Size = new System.Drawing.Size(116, 22);
            this.BTIDTextBox.TabIndex = 3;
            this.BTIDTextBox.TextChanged += new System.EventHandler(this.TextBox8_TextChanged);
            // 
            // BTIDLabel
            // 
            this.BTIDLabel.AutoSize = true;
            this.BTIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTIDLabel.Location = new System.Drawing.Point(11, 171);
            this.BTIDLabel.Name = "BTIDLabel";
            this.BTIDLabel.Size = new System.Drawing.Size(53, 17);
            this.BTIDLabel.TabIndex = 6;
            this.BTIDLabel.Text = "BTIDX";
            // 
            // HTZTextBox
            // 
            this.HTZTextBox.Location = new System.Drawing.Point(55, 103);
            this.HTZTextBox.Name = "HTZTextBox";
            this.HTZTextBox.Size = new System.Drawing.Size(174, 22);
            this.HTZTextBox.TabIndex = 2;
            this.HTZTextBox.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // HTZLabel
            // 
            this.HTZLabel.AutoSize = true;
            this.HTZLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTZLabel.Location = new System.Drawing.Point(20, 106);
            this.HTZLabel.Name = "HTZLabel";
            this.HTZLabel.Size = new System.Drawing.Size(39, 17);
            this.HTZLabel.TabIndex = 2;
            this.HTZLabel.Text = "HTZ";
            // 
            // ANRTextBox
            // 
            this.ANRTextBox.Location = new System.Drawing.Point(56, 36);
            this.ANRTextBox.Name = "ANRTextBox";
            this.ANRTextBox.Size = new System.Drawing.Size(116, 22);
            this.ANRTextBox.TabIndex = 1;
            this.ANRTextBox.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // ANRLabel
            // 
            this.ANRLabel.AutoSize = true;
            this.ANRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANRLabel.Location = new System.Drawing.Point(3, 39);
            this.ANRLabel.Name = "ANRLabel";
            this.ANRLabel.Size = new System.Drawing.Size(68, 17);
            this.ANRLabel.TabIndex = 0;
            this.ANRLabel.Text = "ANR-Nr.";
            // 
            // QuantityGroupBox
            // 
            this.QuantityGroupBox.Controls.Add(this.ExpectedQuantityTxtBox);
            this.QuantityGroupBox.Controls.Add(this.Label12);
            this.QuantityGroupBox.Location = new System.Drawing.Point(390, 312);
            this.QuantityGroupBox.Name = "QuantityGroupBox";
            this.QuantityGroupBox.Size = new System.Drawing.Size(162, 100);
            this.QuantityGroupBox.TabIndex = 2;
            this.QuantityGroupBox.TabStop = false;
            this.QuantityGroupBox.Text = "Cantitate";
            // 
            // ExpectedQuantityTxtBox
            // 
            this.ExpectedQuantityTxtBox.Location = new System.Drawing.Point(62, 50);
            this.ExpectedQuantityTxtBox.Name = "ExpectedQuantityTxtBox";
            this.ExpectedQuantityTxtBox.Size = new System.Drawing.Size(94, 22);
            this.ExpectedQuantityTxtBox.TabIndex = 4;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(6, 55);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(72, 16);
            this.Label12.TabIndex = 0;
            this.Label12.Text = "NECESAR";
            // 
            // StartProductionButton
            // 
            this.StartProductionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartProductionButton.Location = new System.Drawing.Point(390, 429);
            this.StartProductionButton.Name = "StartProductionButton";
            this.StartProductionButton.Size = new System.Drawing.Size(162, 23);
            this.StartProductionButton.TabIndex = 17;
            this.StartProductionButton.Text = "START PRODUCTIE";
            this.StartProductionButton.UseVisualStyleBackColor = false;
            this.StartProductionButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Red;
            this.StopButton.Location = new System.Drawing.Point(441, 472);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 18;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // MachinePicture
            // 
            this.MachinePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MachinePicture.Image = ((System.Drawing.Image)(resources.GetObject("MachinePicture.Image")));
            this.MachinePicture.Location = new System.Drawing.Point(658, 246);
            this.MachinePicture.Name = "MachinePicture";
            this.MachinePicture.Size = new System.Drawing.Size(319, 263);
            this.MachinePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MachinePicture.TabIndex = 19;
            this.MachinePicture.TabStop = false;
            // 
            // BlajSAPicture
            // 
            this.BlajSAPicture.Image = ((System.Drawing.Image)(resources.GetObject("BlajSAPicture.Image")));
            this.BlajSAPicture.Location = new System.Drawing.Point(908, 603);
            this.BlajSAPicture.Name = "BlajSAPicture";
            this.BlajSAPicture.Size = new System.Drawing.Size(117, 111);
            this.BlajSAPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlajSAPicture.TabIndex = 22;
            this.BlajSAPicture.TabStop = false;
            // 
            // DeveloperLabel
            // 
            this.DeveloperLabel.AutoSize = true;
            this.DeveloperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeveloperLabel.Location = new System.Drawing.Point(872, 576);
            this.DeveloperLabel.Name = "DeveloperLabel";
            this.DeveloperLabel.Size = new System.Drawing.Size(244, 29);
            this.DeveloperLabel.TabIndex = 23;
            this.DeveloperLabel.Text = "Dezvoltat de BLAJ SA";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.PictureBox5);
            this.Panel1.Controls.Add(this.TextBox14);
            this.Panel1.Controls.Add(this.Button7);
            this.Panel1.Controls.Add(this.Label15);
            this.Panel1.Controls.Add(this.ComboBox2);
            this.Panel1.Controls.Add(this.Label17);
            this.Panel1.Controls.Add(this.ShapeContainer2);
            this.Panel1.Location = new System.Drawing.Point(0, 603);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(234, 146);
            this.Panel1.TabIndex = 24;
            // 
            // PictureBox5
            // 
            this.PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox5.Image")));
            this.PictureBox5.Location = new System.Drawing.Point(664, 46);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(313, 154);
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox5.TabIndex = 8;
            this.PictureBox5.TabStop = false;
            // 
            // TextBox14
            // 
            this.TextBox14.BackColor = System.Drawing.Color.Lime;
            mySettings1.a = true;
            mySettings1.pr = "standard";
            mySettings1.SettingsKey = "";
            mySettings1.t1 = "192.168.127.254";
            this.TextBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", mySettings1, "t1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextBox14.Location = new System.Drawing.Point(304, 46);
            this.TextBox14.Name = "TextBox14";
            this.TextBox14.Size = new System.Drawing.Size(100, 22);
            this.TextBox14.TabIndex = 5;
            this.TextBox14.Text = mySettings1.t1;
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.ForeColor = System.Drawing.Color.Blue;
            this.Button7.Location = new System.Drawing.Point(391, 339);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(348, 115);
            this.Button7.TabIndex = 4;
            this.Button7.Text = "APASATI PENTRU CONECTARE SI INITIALIZARE JET3UP";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(460, 203);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(257, 39);
            this.Label15.TabIndex = 1;
            this.Label15.Text = "Nume Controlor";
            // 
            // ComboBox2
            // 
            this.ComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Items.AddRange(new object[] {
            "ALECU",
            "DOHOTARU",
            "BACIU",
            "NEGOESCU",
            "POENARIU",
            "CIREASA"});
            this.ComboBox2.Location = new System.Drawing.Point(391, 238);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(348, 47);
            this.ComboBox2.TabIndex = 0;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(191, 49);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(132, 16);
            this.Label17.TabIndex = 6;
            this.Label17.Text = "ADRESA IP JET3UP";
            // 
            // ShapeContainer2
            // 
            this.ShapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.ShapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer2.Name = "ShapeContainer2";
            this.ShapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.RectangleShape2});
            this.ShapeContainer2.Size = new System.Drawing.Size(234, 146);
            this.ShapeContainer2.TabIndex = 9;
            this.ShapeContainer2.TabStop = false;
            // 
            // RectangleShape2
            // 
            this.RectangleShape2.Location = new System.Drawing.Point(174, 25);
            this.RectangleShape2.Name = "RectangleShape2";
            this.RectangleShape2.Size = new System.Drawing.Size(816, 484);
            // 
            // ControllerTextBox
            // 
            this.ControllerTextBox.Location = new System.Drawing.Point(92, 184);
            this.ControllerTextBox.Name = "ControllerTextBox";
            this.ControllerTextBox.Size = new System.Drawing.Size(121, 22);
            this.ControllerTextBox.TabIndex = 25;
            // 
            // TextBox16
            // 
            this.TextBox16.Location = new System.Drawing.Point(6, 4);
            this.TextBox16.Name = "TextBox16";
            this.TextBox16.Size = new System.Drawing.Size(1039, 22);
            this.TextBox16.TabIndex = 26;
            this.TextBox16.Text = "LEIBINGER JET3UP ACTIV";
            this.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Location = new System.Drawing.Point(725, 515);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(437, 48);
            this.WarningLabel.TabIndex = 28;
            this.WarningLabel.Text = resources.GetString("WarningLabel.Text");
            this.WarningLabel.Visible = false;
            // 
            // TextBox7
            // 
            this.TextBox7.Enabled = false;
            this.TextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox7.Location = new System.Drawing.Point(136, 68);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(69, 30);
            this.TextBox7.TabIndex = 29;
            // 
            // TextBox18
            // 
            this.TextBox18.Enabled = false;
            this.TextBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox18.Location = new System.Drawing.Point(211, 68);
            this.TextBox18.Name = "TextBox18";
            this.TextBox18.Size = new System.Drawing.Size(76, 30);
            this.TextBox18.TabIndex = 30;
            // 
            // TextBox19
            // 
            this.TextBox19.Enabled = false;
            this.TextBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox19.Location = new System.Drawing.Point(211, 36);
            this.TextBox19.Name = "TextBox19";
            this.TextBox19.Size = new System.Drawing.Size(76, 30);
            this.TextBox19.TabIndex = 31;
            this.TextBox19.Text = "PA";
            this.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SizeBigChkBox
            // 
            this.SizeBigChkBox.AutoSize = true;
            this.SizeBigChkBox.Location = new System.Drawing.Point(556, 280);
            this.SizeBigChkBox.Name = "SizeBigChkBox";
            this.SizeBigChkBox.Size = new System.Drawing.Size(68, 20);
            this.SizeBigChkBox.TabIndex = 3;
            this.SizeBigChkBox.Text = "MARE";
            this.SizeBigChkBox.UseVisualStyleBackColor = true;
            this.SizeBigChkBox.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // SizeSmallChkBox
            // 
            this.SizeSmallChkBox.AutoSize = true;
            this.SizeSmallChkBox.Location = new System.Drawing.Point(342, 280);
            this.SizeSmallChkBox.Name = "SizeSmallChkBox";
            this.SizeSmallChkBox.Size = new System.Drawing.Size(52, 20);
            this.SizeSmallChkBox.TabIndex = 1;
            this.SizeSmallChkBox.Text = "MIC";
            this.SizeSmallChkBox.UseVisualStyleBackColor = true;
            this.SizeSmallChkBox.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // SizeStandardChkBox
            // 
            this.SizeStandardChkBox.AutoSize = true;
            this.SizeStandardChkBox.Checked = mySettings1.a;
            this.SizeStandardChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SizeStandardChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", mySettings1, "a", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SizeStandardChkBox.Location = new System.Drawing.Point(431, 280);
            this.SizeStandardChkBox.Name = "SizeStandardChkBox";
            this.SizeStandardChkBox.Size = new System.Drawing.Size(105, 20);
            this.SizeStandardChkBox.TabIndex = 2;
            this.SizeStandardChkBox.Text = "STANDARD";
            this.SizeStandardChkBox.UseVisualStyleBackColor = true;
            this.SizeStandardChkBox.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label8.Location = new System.Drawing.Point(339, 259);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(233, 17);
            this.Label8.TabIndex = 32;
            this.Label8.Text = "SELECTATI MARIMEA DORITA:";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1310, 749);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DeveloperLabel);
            this.Controls.Add(this.BlajSAPicture);
            this.Controls.Add(this.MachinePicture);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartProductionButton);
            this.Controls.Add(this.QuantityGroupBox);
            this.Controls.Add(this.InputDataGroupBox);
            this.Controls.Add(this.ControllerIdTextBox);
            this.Controls.Add(this.ControllerIdLabel);
            this.Controls.Add(this.ControllerLabel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.AircraftPicture);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.AerotecLogoPicture);
            this.Controls.Add(this.ControllerTextBox);
            this.Controls.Add(this.TextBox16);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.TextBox19);
            this.Controls.Add(this.TextBox18);
            this.Controls.Add(this.TextBox7);
            this.Controls.Add(this.SizeBigChkBox);
            this.Controls.Add(this.SizeStandardChkBox);
            this.Controls.Add(this.SizeSmallChkBox);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.ShapeContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AerotecLogoPicture)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AircraftPicture)).EndInit();
            this.InputDataGroupBox.ResumeLayout(false);
            this.InputDataGroupBox.PerformLayout();
            this.QuantityGroupBox.ResumeLayout(false);
            this.QuantityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MachinePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlajSAPicture)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal PictureBox AerotecLogoPicture;
        internal GroupBox GroupBox1;
        internal Label ContactInformationLabel;
        internal TextBox TextBox1;
        internal TextBox TextBox2;
        internal TextBox TextBox3;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape1;
        internal PictureBox AircraftPicture;
        internal Label DataLabel;
        internal Label Label3;
        internal Label ControllerLabel;
        internal Label ControllerIdLabel;
        internal TextBox ControllerIdTextBox;
        internal Timer Timer1;
        internal GroupBox InputDataGroupBox;
        internal TextBox BTIDTextBox;
        internal Label BTIDLabel;
        internal TextBox HTZTextBox;
        internal Label HTZLabel;
        internal TextBox ANRTextBox;
        internal Label ANRLabel;
        internal GroupBox QuantityGroupBox;
        internal TextBox ExpectedQuantityTxtBox;
        internal Label Label12;
        internal Button StartProductionButton;
        internal Button StopButton;
        internal PictureBox MachinePicture;
        internal PictureBox BlajSAPicture;
        internal Label DeveloperLabel;
        internal Panel Panel1;
        internal Button Button7;
        internal Label Label15;
        internal ComboBox ComboBox2;
        internal Label Label17;
        internal TextBox TextBox14;
        internal TextBox ControllerTextBox;
        internal TextBox TextBox16;
        internal Label WarningLabel;
        internal TextBox TextBox7;
        internal TextBox TextBox18;
        internal TextBox TextBox19;
        internal CheckBox SizeBigChkBox;
        internal CheckBox SizeStandardChkBox;
        internal CheckBox SizeSmallChkBox;
        internal PictureBox PictureBox5;
        internal Label Label8;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape3;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer2;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape2;
        internal Timer Timer2;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape4;

    }
}