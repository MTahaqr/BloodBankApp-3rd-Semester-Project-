﻿namespace BloodBankApp_FinalProject_
{
    partial class Search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllDonorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registeredAsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDBTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registerDBDataSet15 = new BloodBankApp_FinalProject_.RegisterDBDataSet15();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchBloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDonateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerDBDataSet10 = new BloodBankApp_FinalProject_.RegisterDBDataSet10();
            this.rDBTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDBTableTableAdapter = new BloodBankApp_FinalProject_.RegisterDBDataSet10TableAdapters.RDBTableTableAdapter();
            this.rDBTableTableAdapter1 = new BloodBankApp_FinalProject_.RegisterDBDataSet15TableAdapters.RDBTableTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.matchBloodToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDBTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDBDataSet15)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerDBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDBTableBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.viewAllDonorsToolStripMenuItem,
            this.matchBloodToolStripMenuItem1,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 7);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1250, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.AutoSize = false;
            this.registerToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(65, 0, 117, 0);
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(203, 35);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.AutoSize = false;
            this.patientsToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.patientsToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(140, 0, 117, 0);
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(203, 35);
            this.patientsToolStripMenuItem.Text = "Patients";
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.AutoSize = false;
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Padding = new System.Windows.Forms.Padding(115, 0, 117, 0);
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(203, 35);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // viewAllDonorsToolStripMenuItem
            // 
            this.viewAllDonorsToolStripMenuItem.AutoSize = false;
            this.viewAllDonorsToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.viewAllDonorsToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.viewAllDonorsToolStripMenuItem.Name = "viewAllDonorsToolStripMenuItem";
            this.viewAllDonorsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(97, 0, 118, 0);
            this.viewAllDonorsToolStripMenuItem.Size = new System.Drawing.Size(203, 35);
            this.viewAllDonorsToolStripMenuItem.Text = "Donors";
            this.viewAllDonorsToolStripMenuItem.Click += new System.EventHandler(this.viewAllDonorsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(275, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Search  By :";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Name",
            "Father\'sName",
            "Age",
            "City",
            "Phone",
            "DateOfBirth",
            "Gender",
            "BloodGroup"});
            this.metroComboBox1.Location = new System.Drawing.Point(275, 150);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(30, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Search  :";
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton1.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroRadioButton1.Location = new System.Drawing.Point(15, 4);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(89, 26);
            this.metroRadioButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroRadioButton1.TabIndex = 4;
            this.metroRadioButton1.Text = "Donor";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton2.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroRadioButton2.Location = new System.Drawing.Point(108, 5);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(89, 25);
            this.metroRadioButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroRadioButton2.TabIndex = 5;
            this.metroRadioButton2.Text = "Patient";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DisplayIcon = true;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBox1.ForeColor = System.Drawing.Color.Crimson;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(446, 149);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(270, 30);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox1.TabIndex = 6;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.Navy;
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Crimson;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(764, 121);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(230, 58);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Search";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.metroGrid1.ColumnHeadersHeight = 35;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.fathersNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.registeredAsDataGridViewTextBoxColumn,
            this.donatedDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.rDBTableBindingSource1;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle23;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(30, 206);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Red;
            this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.metroGrid1.RowTemplate.Height = 40;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1276, 386);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroGrid1.TabIndex = 8;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.DividerWidth = 1;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // fathersNameDataGridViewTextBoxColumn
            // 
            this.fathersNameDataGridViewTextBoxColumn.DataPropertyName = "FathersName";
            this.fathersNameDataGridViewTextBoxColumn.DividerWidth = 1;
            this.fathersNameDataGridViewTextBoxColumn.HeaderText = "FathersName";
            this.fathersNameDataGridViewTextBoxColumn.Name = "fathersNameDataGridViewTextBoxColumn";
            this.fathersNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.DividerWidth = 1;
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 120;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.DividerWidth = 1;
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 120;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.DividerWidth = 1;
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.DividerWidth = 1;
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 120;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.DividerWidth = 1;
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 120;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.DividerWidth = 1;
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.Width = 120;
            // 
            // registeredAsDataGridViewTextBoxColumn
            // 
            this.registeredAsDataGridViewTextBoxColumn.DataPropertyName = "RegisteredAs";
            this.registeredAsDataGridViewTextBoxColumn.DividerWidth = 1;
            this.registeredAsDataGridViewTextBoxColumn.HeaderText = "RegisteredAs";
            this.registeredAsDataGridViewTextBoxColumn.Name = "registeredAsDataGridViewTextBoxColumn";
            this.registeredAsDataGridViewTextBoxColumn.Width = 120;
            // 
            // donatedDataGridViewTextBoxColumn
            // 
            this.donatedDataGridViewTextBoxColumn.DataPropertyName = "Donated";
            this.donatedDataGridViewTextBoxColumn.DividerWidth = 1;
            this.donatedDataGridViewTextBoxColumn.HeaderText = "Donated";
            this.donatedDataGridViewTextBoxColumn.Name = "donatedDataGridViewTextBoxColumn";
            this.donatedDataGridViewTextBoxColumn.Width = 120;
            // 
            // rDBTableBindingSource1
            // 
            this.rDBTableBindingSource1.DataMember = "RDBTable";
            this.rDBTableBindingSource1.DataSource = this.registerDBDataSet15;
            // 
            // registerDBDataSet15
            // 
            this.registerDBDataSet15.DataSetName = "RegisterDBDataSet15";
            this.registerDBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.changeDetailsToolStripMenuItem,
            this.matchBloodToolStripMenuItem,
            this.toDonateToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 7);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1250, 35);
            this.menuStrip2.TabIndex = 42;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Crimson;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(65, 0, 117, 0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 35);
            this.toolStripMenuItem1.Text = "Register";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Crimson;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Padding = new System.Windows.Forms.Padding(140, 0, 117, 0);
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 35);
            this.toolStripMenuItem2.Text = "Patients";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Crimson;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Padding = new System.Windows.Forms.Padding(115, 0, 117, 0);
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 35);
            this.toolStripMenuItem3.Text = "Search";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AutoSize = false;
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.Crimson;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Padding = new System.Windows.Forms.Padding(97, 0, 118, 0);
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 35);
            this.toolStripMenuItem4.Text = "Donors";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // changeDetailsToolStripMenuItem
            // 
            this.changeDetailsToolStripMenuItem.AutoSize = false;
            this.changeDetailsToolStripMenuItem.CheckOnClick = true;
            this.changeDetailsToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.changeDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.changeDetailsToolStripMenuItem.Name = "changeDetailsToolStripMenuItem";
            this.changeDetailsToolStripMenuItem.Size = new System.Drawing.Size(177, 35);
            this.changeDetailsToolStripMenuItem.Text = "Change Data";
            this.changeDetailsToolStripMenuItem.Click += new System.EventHandler(this.changeDetailsToolStripMenuItem_Click);
            // 
            // matchBloodToolStripMenuItem
            // 
            this.matchBloodToolStripMenuItem.AutoSize = false;
            this.matchBloodToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.matchBloodToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.matchBloodToolStripMenuItem.Name = "matchBloodToolStripMenuItem";
            this.matchBloodToolStripMenuItem.Size = new System.Drawing.Size(177, 35);
            this.matchBloodToolStripMenuItem.Text = "Match Blood";
            this.matchBloodToolStripMenuItem.Click += new System.EventHandler(this.matchBloodToolStripMenuItem_Click);
            // 
            // toDonateToolStripMenuItem
            // 
            this.toDonateToolStripMenuItem.AutoSize = false;
            this.toDonateToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDonateToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.toDonateToolStripMenuItem.Name = "toDonateToolStripMenuItem";
            this.toDonateToolStripMenuItem.Size = new System.Drawing.Size(178, 35);
            this.toDonateToolStripMenuItem.Text = "To Donate";
            this.toDonateToolStripMenuItem.Click += new System.EventHandler(this.toDonateToolStripMenuItem_Click);
            // 
            // registerDBDataSet10
            // 
            this.registerDBDataSet10.DataSetName = "RegisterDBDataSet10";
            this.registerDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rDBTableBindingSource
            // 
            this.rDBTableBindingSource.DataMember = "RDBTable";
            this.rDBTableBindingSource.DataSource = this.registerDBDataSet10;
            // 
            // rDBTableTableAdapter
            // 
            this.rDBTableTableAdapter.ClearBeforeFill = true;
            // 
            // rDBTableTableAdapter1
            // 
            this.rDBTableTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroRadioButton2);
            this.panel1.Controls.Add(this.metroRadioButton1);
            this.panel1.Location = new System.Drawing.Point(30, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 42);
            this.panel1.TabIndex = 43;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(446, 120);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 44;
            this.metroLabel3.Text = "Search  For:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BloodBankApp_FinalProject_.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(479, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // matchBloodToolStripMenuItem1
            // 
            this.matchBloodToolStripMenuItem1.AutoSize = false;
            this.matchBloodToolStripMenuItem1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchBloodToolStripMenuItem1.ForeColor = System.Drawing.Color.Crimson;
            this.matchBloodToolStripMenuItem1.Name = "matchBloodToolStripMenuItem1";
            this.matchBloodToolStripMenuItem1.Size = new System.Drawing.Size(203, 35);
            this.matchBloodToolStripMenuItem1.Text = "Match Blood";
            this.matchBloodToolStripMenuItem1.Click += new System.EventHandler(this.matchBloodToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AutoSize = false;
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(203, 35);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 614);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Search";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Search_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDBTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDBDataSet15)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerDBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDBTableBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllDonorsToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem changeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchBloodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDonateToolStripMenuItem;
        private RegisterDBDataSet10 registerDBDataSet10;
        private System.Windows.Forms.BindingSource rDBTableBindingSource;
        private RegisterDBDataSet10TableAdapters.RDBTableTableAdapter rDBTableTableAdapter;
        private RegisterDBDataSet15 registerDBDataSet15;
        private System.Windows.Forms.BindingSource rDBTableBindingSource1;
        private RegisterDBDataSet15TableAdapters.RDBTableTableAdapter rDBTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathersNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registeredAsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem matchBloodToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}