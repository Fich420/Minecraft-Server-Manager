namespace Minecraft_Server_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.playerTxtOutput = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gameRulesTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.siticoneLabel2 = new ns1.SiticoneLabel();
            this.weatherComboBox = new ns1.SiticoneComboBox();
            this.siticoneGradientButton1 = new ns1.SiticoneGradientButton();
            this.siticoneGradientButton4 = new ns1.SiticoneGradientButton();
            this.siticoneGradientButton5 = new ns1.SiticoneGradientButton();
            this.siticoneGradientButton6 = new ns1.SiticoneGradientButton();
            this.siticoneGroupBox1 = new ns1.SiticoneGroupBox();
            this.siticoneVSeparator2 = new ns1.SiticoneVSeparator();
            this.siticoneVSeparator1 = new ns1.SiticoneVSeparator();
            this.siticoneCheckBox2 = new ns1.SiticoneCheckBox();
            this.startServerCheckbox = new ns1.SiticoneCheckBox();
            this.siticoneGradientButton8 = new ns1.SiticoneGradientButton();
            this.siticoneGradientButton7 = new ns1.SiticoneGradientButton();
            this.txtInputCommand = new ns1.SiticoneMaterialTextBox();
            this.siticoneGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtOutput.ForeColor = System.Drawing.Color.White;
            this.txtOutput.Location = new System.Drawing.Point(9, 186);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(528, 378);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server Controls";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(6, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Server Output";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(771, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Command  ↓";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(738, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Players Online:";
            // 
            // playerTxtOutput
            // 
            this.playerTxtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playerTxtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.playerTxtOutput.ForeColor = System.Drawing.Color.White;
            this.playerTxtOutput.Location = new System.Drawing.Point(741, 186);
            this.playerTxtOutput.Multiline = true;
            this.playerTxtOutput.Name = "playerTxtOutput";
            this.playerTxtOutput.Size = new System.Drawing.Size(162, 338);
            this.playerTxtOutput.TabIndex = 22;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // gameRulesTxt
            // 
            this.gameRulesTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gameRulesTxt.ForeColor = System.Drawing.Color.White;
            this.gameRulesTxt.Location = new System.Drawing.Point(544, 187);
            this.gameRulesTxt.Multiline = true;
            this.gameRulesTxt.Name = "gameRulesTxt";
            this.gameRulesTxt.Size = new System.Drawing.Size(191, 363);
            this.gameRulesTxt.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(541, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Current Game Rules";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 29);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.Value = new System.DateTime(2020, 1, 18, 4, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "Automatic Backup time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(794, 538);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 26);
            this.label8.TabIndex = 30;
            this.label8.Text = "Made By:  Benjerman,\r\nImproved by Fich420\r\n";
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Location = new System.Drawing.Point(0, 0);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(3, 2);
            this.siticoneLabel2.TabIndex = 57;
            this.siticoneLabel2.Text = null;
            // 
            // weatherComboBox
            // 
            this.weatherComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.weatherComboBox.BorderColor = System.Drawing.Color.White;
            this.weatherComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.weatherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weatherComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.weatherComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.weatherComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.weatherComboBox.FormattingEnabled = true;
            this.weatherComboBox.HoveredState.Parent = this.weatherComboBox;
            this.weatherComboBox.ItemHeight = 30;
            this.weatherComboBox.ItemsAppearance.Parent = this.weatherComboBox;
            this.weatherComboBox.Location = new System.Drawing.Point(13, 99);
            this.weatherComboBox.Name = "weatherComboBox";
            this.weatherComboBox.ShadowDecoration.Parent = this.weatherComboBox;
            this.weatherComboBox.Size = new System.Drawing.Size(117, 36);
            this.weatherComboBox.TabIndex = 38;
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.CheckedState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.CustomImages.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton1.HoveredState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Location = new System.Drawing.Point(13, 52);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(117, 41);
            this.siticoneGradientButton1.TabIndex = 39;
            this.siticoneGradientButton1.Text = "Set Weather";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // siticoneGradientButton4
            // 
            this.siticoneGradientButton4.CheckedState.Parent = this.siticoneGradientButton4;
            this.siticoneGradientButton4.CustomImages.Parent = this.siticoneGradientButton4;
            this.siticoneGradientButton4.FillColor = System.Drawing.Color.Lime;
            this.siticoneGradientButton4.FillColor2 = System.Drawing.Color.Green;
            this.siticoneGradientButton4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.siticoneGradientButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton4.HoveredState.Parent = this.siticoneGradientButton4;
            this.siticoneGradientButton4.Location = new System.Drawing.Point(9, 32);
            this.siticoneGradientButton4.Name = "siticoneGradientButton4";
            this.siticoneGradientButton4.ShadowDecoration.Parent = this.siticoneGradientButton4;
            this.siticoneGradientButton4.Size = new System.Drawing.Size(96, 35);
            this.siticoneGradientButton4.TabIndex = 48;
            this.siticoneGradientButton4.Text = "Start";
            this.siticoneGradientButton4.Click += new System.EventHandler(this.siticoneGradientButton4_Click);
            // 
            // siticoneGradientButton5
            // 
            this.siticoneGradientButton5.CheckedState.Parent = this.siticoneGradientButton5;
            this.siticoneGradientButton5.CustomImages.Parent = this.siticoneGradientButton5;
            this.siticoneGradientButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.siticoneGradientButton5.FillColor2 = System.Drawing.Color.Red;
            this.siticoneGradientButton5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.siticoneGradientButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton5.HoveredState.Parent = this.siticoneGradientButton5;
            this.siticoneGradientButton5.Location = new System.Drawing.Point(9, 73);
            this.siticoneGradientButton5.Name = "siticoneGradientButton5";
            this.siticoneGradientButton5.ShadowDecoration.Parent = this.siticoneGradientButton5;
            this.siticoneGradientButton5.Size = new System.Drawing.Size(96, 35);
            this.siticoneGradientButton5.TabIndex = 49;
            this.siticoneGradientButton5.Text = "Stop";
            this.siticoneGradientButton5.Click += new System.EventHandler(this.siticoneGradientButton5_Click);
            // 
            // siticoneGradientButton6
            // 
            this.siticoneGradientButton6.CheckedState.Parent = this.siticoneGradientButton6;
            this.siticoneGradientButton6.CustomImages.Parent = this.siticoneGradientButton6;
            this.siticoneGradientButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.siticoneGradientButton6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneGradientButton6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.siticoneGradientButton6.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton6.HoveredState.Parent = this.siticoneGradientButton6;
            this.siticoneGradientButton6.Location = new System.Drawing.Point(10, 114);
            this.siticoneGradientButton6.Name = "siticoneGradientButton6";
            this.siticoneGradientButton6.ShadowDecoration.Parent = this.siticoneGradientButton6;
            this.siticoneGradientButton6.Size = new System.Drawing.Size(96, 35);
            this.siticoneGradientButton6.TabIndex = 50;
            this.siticoneGradientButton6.Text = "Backup";
            this.siticoneGradientButton6.Click += new System.EventHandler(this.siticoneGradientButton6_Click);
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.Controls.Add(this.siticoneVSeparator2);
            this.siticoneGroupBox1.Controls.Add(this.siticoneVSeparator1);
            this.siticoneGroupBox1.Controls.Add(this.siticoneCheckBox2);
            this.siticoneGroupBox1.Controls.Add(this.dateTimePicker1);
            this.siticoneGroupBox1.Controls.Add(this.label7);
            this.siticoneGroupBox1.Controls.Add(this.startServerCheckbox);
            this.siticoneGroupBox1.Controls.Add(this.siticoneGradientButton8);
            this.siticoneGroupBox1.Controls.Add(this.siticoneGradientButton1);
            this.siticoneGroupBox1.Controls.Add(this.siticoneLabel2);
            this.siticoneGroupBox1.Controls.Add(this.weatherComboBox);
            this.siticoneGroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.White;
            this.siticoneGroupBox1.Location = new System.Drawing.Point(135, 5);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.ShadowDecoration.Parent = this.siticoneGroupBox1;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(600, 155);
            this.siticoneGroupBox1.TabIndex = 51;
            this.siticoneGroupBox1.Text = "Admin options";
            this.siticoneGroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.siticoneGroupBox1.TextTransform = ns5.TextTransform.UpperCase;
            this.siticoneGroupBox1.Click += new System.EventHandler(this.siticoneGroupBox1_Click);
            // 
            // siticoneVSeparator2
            // 
            this.siticoneVSeparator2.Location = new System.Drawing.Point(319, 48);
            this.siticoneVSeparator2.Name = "siticoneVSeparator2";
            this.siticoneVSeparator2.Size = new System.Drawing.Size(10, 105);
            this.siticoneVSeparator2.TabIndex = 60;
            // 
            // siticoneVSeparator1
            // 
            this.siticoneVSeparator1.Location = new System.Drawing.Point(136, 47);
            this.siticoneVSeparator1.Name = "siticoneVSeparator1";
            this.siticoneVSeparator1.Size = new System.Drawing.Size(12, 105);
            this.siticoneVSeparator1.TabIndex = 59;
            // 
            // siticoneCheckBox2
            // 
            this.siticoneCheckBox2.AutoSize = true;
            this.siticoneCheckBox2.Checked = true;
            this.siticoneCheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox2.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox2.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.siticoneCheckBox2.Location = new System.Drawing.Point(154, 52);
            this.siticoneCheckBox2.Name = "siticoneCheckBox2";
            this.siticoneCheckBox2.Size = new System.Drawing.Size(163, 25);
            this.siticoneCheckBox2.TabIndex = 58;
            this.siticoneCheckBox2.Text = "Auto backup server";
            this.siticoneCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox2.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.UseVisualStyleBackColor = true;
            this.siticoneCheckBox2.CheckedChanged += new System.EventHandler(this.siticoneCheckBox2_CheckedChanged);
            // 
            // startServerCheckbox
            // 
            this.startServerCheckbox.AutoSize = true;
            this.startServerCheckbox.Checked = true;
            this.startServerCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.startServerCheckbox.CheckedState.BorderRadius = 2;
            this.startServerCheckbox.CheckedState.BorderThickness = 0;
            this.startServerCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.startServerCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startServerCheckbox.Location = new System.Drawing.Point(335, 52);
            this.startServerCheckbox.Name = "startServerCheckbox";
            this.startServerCheckbox.Size = new System.Drawing.Size(261, 25);
            this.startServerCheckbox.TabIndex = 56;
            this.startServerCheckbox.Text = "Start server when program open?";
            this.startServerCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.startServerCheckbox.UncheckedState.BorderRadius = 2;
            this.startServerCheckbox.UncheckedState.BorderThickness = 0;
            this.startServerCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.startServerCheckbox.UseVisualStyleBackColor = true;
            this.startServerCheckbox.CheckedChanged += new System.EventHandler(this.startServerCheckbox_CheckedChanged);
            // 
            // siticoneGradientButton8
            // 
            this.siticoneGradientButton8.CheckedState.Parent = this.siticoneGradientButton8;
            this.siticoneGradientButton8.CustomImages.Parent = this.siticoneGradientButton8;
            this.siticoneGradientButton8.FillColor = System.Drawing.Color.Red;
            this.siticoneGradientButton8.FillColor2 = System.Drawing.Color.Maroon;
            this.siticoneGradientButton8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.siticoneGradientButton8.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton8.HoveredState.Parent = this.siticoneGradientButton8;
            this.siticoneGradientButton8.Location = new System.Drawing.Point(335, 99);
            this.siticoneGradientButton8.Name = "siticoneGradientButton8";
            this.siticoneGradientButton8.ShadowDecoration.Parent = this.siticoneGradientButton8;
            this.siticoneGradientButton8.Size = new System.Drawing.Size(249, 36);
            this.siticoneGradientButton8.TabIndex = 54;
            this.siticoneGradientButton8.Text = "Delete log file";
            this.siticoneGradientButton8.Click += new System.EventHandler(this.siticoneGradientButton8_Click);
            // 
            // siticoneGradientButton7
            // 
            this.siticoneGradientButton7.CheckedState.Parent = this.siticoneGradientButton7;
            this.siticoneGradientButton7.CustomImages.Parent = this.siticoneGradientButton7;
            this.siticoneGradientButton7.FillColor = System.Drawing.Color.Gray;
            this.siticoneGradientButton7.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneGradientButton7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGradientButton7.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton7.HoveredState.Parent = this.siticoneGradientButton7;
            this.siticoneGradientButton7.Location = new System.Drawing.Point(741, 97);
            this.siticoneGradientButton7.Name = "siticoneGradientButton7";
            this.siticoneGradientButton7.ShadowDecoration.Parent = this.siticoneGradientButton7;
            this.siticoneGradientButton7.Size = new System.Drawing.Size(162, 21);
            this.siticoneGradientButton7.TabIndex = 52;
            this.siticoneGradientButton7.Text = "Send";
            this.siticoneGradientButton7.Click += new System.EventHandler(this.siticoneGradientButton7_Click);
            // 
            // txtInputCommand
            // 
            this.txtInputCommand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInputCommand.DefaultText = "";
            this.txtInputCommand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInputCommand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInputCommand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInputCommand.DisabledState.Parent = this.txtInputCommand;
            this.txtInputCommand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInputCommand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtInputCommand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInputCommand.FocusedState.Parent = this.txtInputCommand;
            this.txtInputCommand.ForeColor = System.Drawing.Color.White;
            this.txtInputCommand.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInputCommand.HoveredState.Parent = this.txtInputCommand;
            this.txtInputCommand.Location = new System.Drawing.Point(741, 48);
            this.txtInputCommand.Name = "txtInputCommand";
            this.txtInputCommand.PasswordChar = '\0';
            this.txtInputCommand.PlaceholderText = "";
            this.txtInputCommand.SelectedText = "";
            this.txtInputCommand.ShadowDecoration.Parent = this.txtInputCommand;
            this.txtInputCommand.Size = new System.Drawing.Size(162, 31);
            this.txtInputCommand.TabIndex = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(917, 576);
            this.Controls.Add(this.txtInputCommand);
            this.Controls.Add(this.siticoneGradientButton7);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.siticoneGradientButton6);
            this.Controls.Add(this.siticoneGradientButton5);
            this.Controls.Add(this.siticoneGradientButton4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gameRulesTxt);
            this.Controls.Add(this.playerTxtOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Bedrock Server Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox playerTxtOutput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox gameRulesTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ns1.SiticoneLabel siticoneLabel2;
        private ns1.SiticoneComboBox weatherComboBox;
        private ns1.SiticoneGradientButton siticoneGradientButton1;
        private ns1.SiticoneGradientButton siticoneGradientButton4;
        private ns1.SiticoneGradientButton siticoneGradientButton5;
        private ns1.SiticoneGradientButton siticoneGradientButton6;
        private ns1.SiticoneGroupBox siticoneGroupBox1;
        private ns1.SiticoneGradientButton siticoneGradientButton7;
        private ns1.SiticoneMaterialTextBox txtInputCommand;
        private ns1.SiticoneGradientButton siticoneGradientButton8;
        private ns1.SiticoneCheckBox startServerCheckbox;
        private ns1.SiticoneCheckBox siticoneCheckBox2;
        private ns1.SiticoneVSeparator siticoneVSeparator1;
        private ns1.SiticoneVSeparator siticoneVSeparator2;
    }
}

