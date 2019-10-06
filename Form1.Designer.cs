namespace CSharpArmadaBot
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ResetAnimalsButton = new System.Windows.Forms.Button();
            this.AddAnimalTextBox = new System.Windows.Forms.TextBox();
            this.AddNpcTextBox = new System.Windows.Forms.TextBox();
            this.ResetNpcsButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.XMinutesTextBox = new System.Windows.Forms.TextBox();
            this.EveryXMinutesRadioButton = new System.Windows.Forms.RadioButton();
            this.WhenNearBorderRadioButton = new System.Windows.Forms.RadioButton();
            this.UpDownCheckBox = new System.Windows.Forms.CheckBox();
            this.LeftRightCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FightUntilTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StartFightWhenTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RepairingWhenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.AddAnimalsButton = new System.Windows.Forms.Button();
            this.AnimalsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddNpcsButton = new System.Windows.Forms.Button();
            this.NpcsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AvoidIslandsCheckBox = new System.Windows.Forms.CheckBox();
            this.ShootAnimalsCheckBox = new System.Windows.Forms.CheckBox();
            this.ShootNpcsCheckBox = new System.Windows.Forms.CheckBox();
            this.CollectEventChestsCheckBox = new System.Windows.Forms.CheckBox();
            this.CollectChestsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoginComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.debugGridView = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.CollectChestsPriorityTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CollectEventChestsPriorityTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NpcsDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debugGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1239, 539);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1231, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sea Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1231, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Main Site";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ResetAnimalsButton);
            this.tabPage3.Controls.Add(this.AddAnimalTextBox);
            this.tabPage3.Controls.Add(this.AddNpcTextBox);
            this.tabPage3.Controls.Add(this.ResetNpcsButton);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.SaveSettingsButton);
            this.tabPage3.Controls.Add(this.AddAnimalsButton);
            this.tabPage3.Controls.Add(this.AnimalsDataGridView);
            this.tabPage3.Controls.Add(this.AddNpcsButton);
            this.tabPage3.Controls.Add(this.NpcsDataGridView);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1231, 513);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ResetAnimalsButton
            // 
            this.ResetAnimalsButton.Location = new System.Drawing.Point(641, 341);
            this.ResetAnimalsButton.Name = "ResetAnimalsButton";
            this.ResetAnimalsButton.Size = new System.Drawing.Size(300, 23);
            this.ResetAnimalsButton.TabIndex = 21;
            this.ResetAnimalsButton.Text = "Reset";
            this.ResetAnimalsButton.UseVisualStyleBackColor = true;
            this.ResetAnimalsButton.Click += new System.EventHandler(this.ResetAnimalsButton_Click);
            // 
            // AddAnimalTextBox
            // 
            this.AddAnimalTextBox.Location = new System.Drawing.Point(641, 316);
            this.AddAnimalTextBox.Name = "AddAnimalTextBox";
            this.AddAnimalTextBox.Size = new System.Drawing.Size(195, 20);
            this.AddAnimalTextBox.TabIndex = 19;
            // 
            // AddNpcTextBox
            // 
            this.AddNpcTextBox.Location = new System.Drawing.Point(335, 315);
            this.AddNpcTextBox.Name = "AddNpcTextBox";
            this.AddNpcTextBox.Size = new System.Drawing.Size(195, 20);
            this.AddNpcTextBox.TabIndex = 16;
            // 
            // ResetNpcsButton
            // 
            this.ResetNpcsButton.Location = new System.Drawing.Point(335, 341);
            this.ResetNpcsButton.Name = "ResetNpcsButton";
            this.ResetNpcsButton.Size = new System.Drawing.Size(300, 23);
            this.ResetNpcsButton.TabIndex = 18;
            this.ResetNpcsButton.Text = "Reset";
            this.ResetNpcsButton.UseVisualStyleBackColor = true;
            this.ResetNpcsButton.Click += new System.EventHandler(this.ResetNpcsButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.XMinutesTextBox);
            this.groupBox4.Controls.Add(this.EveryXMinutesRadioButton);
            this.groupBox4.Controls.Add(this.WhenNearBorderRadioButton);
            this.groupBox4.Controls.Add(this.UpDownCheckBox);
            this.groupBox4.Controls.Add(this.LeftRightCheckBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(169, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 125);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Changing maps";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "minutes";
            // 
            // XMinutesTextBox
            // 
            this.XMinutesTextBox.Location = new System.Drawing.Point(54, 102);
            this.XMinutesTextBox.MaxLength = 3;
            this.XMinutesTextBox.Name = "XMinutesTextBox";
            this.XMinutesTextBox.Size = new System.Drawing.Size(26, 20);
            this.XMinutesTextBox.TabIndex = 15;
            this.XMinutesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits);
            // 
            // EveryXMinutesRadioButton
            // 
            this.EveryXMinutesRadioButton.AutoSize = true;
            this.EveryXMinutesRadioButton.Location = new System.Drawing.Point(5, 102);
            this.EveryXMinutesRadioButton.Name = "EveryXMinutesRadioButton";
            this.EveryXMinutesRadioButton.Size = new System.Drawing.Size(55, 17);
            this.EveryXMinutesRadioButton.TabIndex = 14;
            this.EveryXMinutesRadioButton.TabStop = true;
            this.EveryXMinutesRadioButton.Text = "Every ";
            this.EveryXMinutesRadioButton.UseVisualStyleBackColor = true;
            // 
            // WhenNearBorderRadioButton
            // 
            this.WhenNearBorderRadioButton.AutoSize = true;
            this.WhenNearBorderRadioButton.Checked = true;
            this.WhenNearBorderRadioButton.Location = new System.Drawing.Point(5, 82);
            this.WhenNearBorderRadioButton.Name = "WhenNearBorderRadioButton";
            this.WhenNearBorderRadioButton.Size = new System.Drawing.Size(111, 17);
            this.WhenNearBorderRadioButton.TabIndex = 13;
            this.WhenNearBorderRadioButton.TabStop = true;
            this.WhenNearBorderRadioButton.Text = "When near border";
            this.WhenNearBorderRadioButton.UseVisualStyleBackColor = true;
            // 
            // UpDownCheckBox
            // 
            this.UpDownCheckBox.AutoSize = true;
            this.UpDownCheckBox.Location = new System.Drawing.Point(5, 59);
            this.UpDownCheckBox.Name = "UpDownCheckBox";
            this.UpDownCheckBox.Size = new System.Drawing.Size(73, 17);
            this.UpDownCheckBox.TabIndex = 12;
            this.UpDownCheckBox.Text = "Up/Down";
            this.UpDownCheckBox.UseVisualStyleBackColor = true;
            // 
            // LeftRightCheckBox
            // 
            this.LeftRightCheckBox.AutoSize = true;
            this.LeftRightCheckBox.Location = new System.Drawing.Point(5, 36);
            this.LeftRightCheckBox.Name = "LeftRightCheckBox";
            this.LeftRightCheckBox.Size = new System.Drawing.Size(74, 17);
            this.LeftRightCheckBox.TabIndex = 11;
            this.LeftRightCheckBox.Text = "Left/Right";
            this.LeftRightCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Change map:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.FightUntilTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.StartFightWhenTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.RepairingWhenTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(3, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 84);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repairing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "%";
            // 
            // FightUntilTextBox
            // 
            this.FightUntilTextBox.Location = new System.Drawing.Point(84, 58);
            this.FightUntilTextBox.MaxLength = 2;
            this.FightUntilTextBox.Name = "FightUntilTextBox";
            this.FightUntilTextBox.Size = new System.Drawing.Size(26, 20);
            this.FightUntilTextBox.TabIndex = 10;
            this.FightUntilTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "%";
            // 
            // StartFightWhenTextBox
            // 
            this.StartFightWhenTextBox.Location = new System.Drawing.Point(114, 38);
            this.StartFightWhenTextBox.MaxLength = 2;
            this.StartFightWhenTextBox.Name = "StartFightWhenTextBox";
            this.StartFightWhenTextBox.Size = new System.Drawing.Size(26, 20);
            this.StartFightWhenTextBox.TabIndex = 9;
            this.StartFightWhenTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Start fight when hp > ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fight until hp > ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "%";
            // 
            // RepairingWhenTextBox
            // 
            this.RepairingWhenTextBox.Location = new System.Drawing.Point(99, 18);
            this.RepairingWhenTextBox.MaxLength = 2;
            this.RepairingWhenTextBox.Name = "RepairingWhenTextBox";
            this.RepairingWhenTextBox.Size = new System.Drawing.Size(26, 20);
            this.RepairingWhenTextBox.TabIndex = 8;
            this.RepairingWhenTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Repair when hp < ";
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(4, 464);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(1224, 46);
            this.SaveSettingsButton.TabIndex = 100;
            this.SaveSettingsButton.Text = "Save settings";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // AddAnimalsButton
            // 
            this.AddAnimalsButton.Location = new System.Drawing.Point(842, 315);
            this.AddAnimalsButton.Name = "AddAnimalsButton";
            this.AddAnimalsButton.Size = new System.Drawing.Size(99, 23);
            this.AddAnimalsButton.TabIndex = 20;
            this.AddAnimalsButton.Text = "Add Animals";
            this.AddAnimalsButton.UseVisualStyleBackColor = true;
            this.AddAnimalsButton.Click += new System.EventHandler(this.AddAnimalsButton_Click);
            // 
            // AnimalsDataGridView
            // 
            this.AnimalsDataGridView.AllowUserToAddRows = false;
            this.AnimalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnimalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.AnimalsDataGridView.Location = new System.Drawing.Point(641, 4);
            this.AnimalsDataGridView.Name = "AnimalsDataGridView";
            this.AnimalsDataGridView.RowHeadersVisible = false;
            this.AnimalsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AnimalsDataGridView.Size = new System.Drawing.Size(300, 306);
            this.AnimalsDataGridView.TabIndex = 99;
            this.AnimalsDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Animal name";
            this.Column4.Name = "Column4";
            this.Column4.Width = 190;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Shoot";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 40;
            // 
            // Column6
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column6.HeaderText = "Priority";
            this.Column6.MaxInputLength = 3;
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // AddNpcsButton
            // 
            this.AddNpcsButton.Location = new System.Drawing.Point(536, 313);
            this.AddNpcsButton.Name = "AddNpcsButton";
            this.AddNpcsButton.Size = new System.Drawing.Size(99, 23);
            this.AddNpcsButton.TabIndex = 17;
            this.AddNpcsButton.Text = "Add NPCs";
            this.AddNpcsButton.UseVisualStyleBackColor = true;
            this.AddNpcsButton.Click += new System.EventHandler(this.AddNpcsButton_Click);
            // 
            // NpcsDataGridView
            // 
            this.NpcsDataGridView.AllowUserToAddRows = false;
            this.NpcsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NpcsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.NpcsDataGridView.Location = new System.Drawing.Point(335, 4);
            this.NpcsDataGridView.Name = "NpcsDataGridView";
            this.NpcsDataGridView.RowHeadersVisible = false;
            this.NpcsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NpcsDataGridView.Size = new System.Drawing.Size(300, 306);
            this.NpcsDataGridView.TabIndex = 99;
            this.NpcsDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NPC name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 190;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Shoot";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Priority";
            this.Column3.MaxInputLength = 3;
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CollectEventChestsPriorityTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.CollectChestsPriorityTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.AvoidIslandsCheckBox);
            this.groupBox2.Controls.Add(this.ShootAnimalsCheckBox);
            this.groupBox2.Controls.Add(this.ShootNpcsCheckBox);
            this.groupBox2.Controls.Add(this.CollectEventChestsCheckBox);
            this.groupBox2.Controls.Add(this.CollectChestsCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 175);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasks";
            // 
            // AvoidIslandsCheckBox
            // 
            this.AvoidIslandsCheckBox.AutoSize = true;
            this.AvoidIslandsCheckBox.Location = new System.Drawing.Point(6, 154);
            this.AvoidIslandsCheckBox.Name = "AvoidIslandsCheckBox";
            this.AvoidIslandsCheckBox.Size = new System.Drawing.Size(88, 17);
            this.AvoidIslandsCheckBox.TabIndex = 7;
            this.AvoidIslandsCheckBox.Text = "Avoid islands";
            this.AvoidIslandsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShootAnimalsCheckBox
            // 
            this.ShootAnimalsCheckBox.AutoSize = true;
            this.ShootAnimalsCheckBox.Location = new System.Drawing.Point(6, 131);
            this.ShootAnimalsCheckBox.Name = "ShootAnimalsCheckBox";
            this.ShootAnimalsCheckBox.Size = new System.Drawing.Size(92, 17);
            this.ShootAnimalsCheckBox.TabIndex = 6;
            this.ShootAnimalsCheckBox.Text = "Shoot animals";
            this.ShootAnimalsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShootNpcsCheckBox
            // 
            this.ShootNpcsCheckBox.AutoSize = true;
            this.ShootNpcsCheckBox.Location = new System.Drawing.Point(6, 108);
            this.ShootNpcsCheckBox.Name = "ShootNpcsCheckBox";
            this.ShootNpcsCheckBox.Size = new System.Drawing.Size(84, 17);
            this.ShootNpcsCheckBox.TabIndex = 5;
            this.ShootNpcsCheckBox.Text = "Shoot NPCs";
            this.ShootNpcsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CollectEventChestsCheckBox
            // 
            this.CollectEventChestsCheckBox.AutoSize = true;
            this.CollectEventChestsCheckBox.Location = new System.Drawing.Point(7, 65);
            this.CollectEventChestsCheckBox.Name = "CollectEventChestsCheckBox";
            this.CollectEventChestsCheckBox.Size = new System.Drawing.Size(121, 17);
            this.CollectEventChestsCheckBox.TabIndex = 4;
            this.CollectEventChestsCheckBox.Text = "Collect event glitters";
            this.CollectEventChestsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CollectChestsCheckBox
            // 
            this.CollectChestsCheckBox.AutoSize = true;
            this.CollectChestsCheckBox.Location = new System.Drawing.Point(7, 18);
            this.CollectChestsCheckBox.Name = "CollectChestsCheckBox";
            this.CollectChestsCheckBox.Size = new System.Drawing.Size(92, 17);
            this.CollectChestsCheckBox.TabIndex = 3;
            this.CollectChestsCheckBox.Text = "Collect chests";
            this.CollectChestsCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoginComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LoginButton);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Data";
            // 
            // LoginComboBox
            // 
            this.LoginComboBox.FormattingEnabled = true;
            this.LoginComboBox.Location = new System.Drawing.Point(9, 31);
            this.LoginComboBox.Name = "LoginComboBox";
            this.LoginComboBox.Size = new System.Drawing.Size(145, 21);
            this.LoginComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(6, 97);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(148, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(6, 71);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(148, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.debugGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1231, 513);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DEBUG";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // debugGridView
            // 
            this.debugGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debugGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.debugGridView.Location = new System.Drawing.Point(4, 4);
            this.debugGridView.Name = "debugGridView";
            this.debugGridView.Size = new System.Drawing.Size(647, 385);
            this.debugGridView.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ID";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Nickname";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "HP/MaxHP";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "X";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Y";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Type";
            this.Column12.Name = "Column12";
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.BackColor = System.Drawing.SystemColors.Window;
            this.LogBox.Location = new System.Drawing.Point(13, 558);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(1239, 112);
            this.LogBox.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(0, 0);
            this.StartButton.Margin = new System.Windows.Forms.Padding(0);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(150, 22);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(163, 0);
            this.StopButton.Margin = new System.Windows.Forms.Padding(0);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(150, 22);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "notifyIcon1";
            this.NotifyIcon.Click += new System.EventHandler(this.NotifyIcon_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Location = new System.Drawing.Point(483, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 21);
            this.panel1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Priority";
            // 
            // CollectChestsPriorityTextBox
            // 
            this.CollectChestsPriorityTextBox.Location = new System.Drawing.Point(50, 39);
            this.CollectChestsPriorityTextBox.Name = "CollectChestsPriorityTextBox";
            this.CollectChestsPriorityTextBox.Size = new System.Drawing.Size(26, 20);
            this.CollectChestsPriorityTextBox.TabIndex = 9;
            this.CollectChestsPriorityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Priority";
            // 
            // CollectEventChestsPriorityTextBox
            // 
            this.CollectEventChestsPriorityTextBox.Location = new System.Drawing.Point(50, 82);
            this.CollectEventChestsPriorityTextBox.Name = "CollectEventChestsPriorityTextBox";
            this.CollectEventChestsPriorityTextBox.Size = new System.Drawing.Size(26, 20);
            this.CollectEventChestsPriorityTextBox.TabIndex = 11;
            this.CollectEventChestsPriorityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "MainForm";
            this.Text = "ArmadaBot v.0.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NpcsDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.debugGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.DataGridView NpcsDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ShootAnimalsCheckBox;
        private System.Windows.Forms.CheckBox ShootNpcsCheckBox;
        private System.Windows.Forms.CheckBox CollectEventChestsCheckBox;
        private System.Windows.Forms.CheckBox CollectChestsCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddAnimalsButton;
        private System.Windows.Forms.DataGridView AnimalsDataGridView;
        private System.Windows.Forms.Button AddNpcsButton;
        private System.Windows.Forms.CheckBox AvoidIslandsCheckBox;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.ComboBox LoginComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FightUntilTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StartFightWhenTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RepairingWhenTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox XMinutesTextBox;
        private System.Windows.Forms.RadioButton EveryXMinutesRadioButton;
        private System.Windows.Forms.RadioButton WhenNearBorderRadioButton;
        private System.Windows.Forms.CheckBox UpDownCheckBox;
        private System.Windows.Forms.CheckBox LeftRightCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ResetAnimalsButton;
        private System.Windows.Forms.TextBox AddAnimalTextBox;
        private System.Windows.Forms.TextBox AddNpcTextBox;
        private System.Windows.Forms.Button ResetNpcsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView debugGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.TextBox CollectEventChestsPriorityTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CollectChestsPriorityTextBox;
        private System.Windows.Forms.Label label11;
    }
}

