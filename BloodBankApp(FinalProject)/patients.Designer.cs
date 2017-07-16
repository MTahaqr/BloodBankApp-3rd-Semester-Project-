namespace BloodBankApp_FinalProject_
{
    partial class patients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllDonorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registeredAsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPDBTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.regPatDBDataSet7 = new BloodBankApp_FinalProject_.RegPatDBDataSet7();
            this.rPDBTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.regPatDBDataSet5 = new BloodBankApp_FinalProject_.RegPatDBDataSet5();
            this.rPDBTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regPatDBDataSet = new BloodBankApp_FinalProject_.RegPatDBDataSet();
            this.rPDBTableTableAdapter = new BloodBankApp_FinalProject_.RegPatDBDataSetTableAdapters.RPDBTableTableAdapter();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchBloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDonateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rPDBTableTableAdapter1 = new BloodBankApp_FinalProject_.RegPatDBDataSet5TableAdapters.RPDBTableTableAdapter();
            this.regPatDBDataSet6 = new BloodBankApp_FinalProject_.RegPatDBDataSet6();
            this.rPDBTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rPDBTableTableAdapter2 = new BloodBankApp_FinalProject_.RegPatDBDataSet6TableAdapters.RPDBTableTableAdapter();
            this.rPDBTableTableAdapter3 = new BloodBankApp_FinalProject_.RegPatDBDataSet7TableAdapters.RPDBTableTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.matchBloodToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPDBTableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPatDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPDBTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPatDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPDBTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPatDBDataSet)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regPatDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPDBTableBindingSource2)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1249, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.AutoSize = false;
            this.registerToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.registerToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(65, 0, 117, 0);
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(208, 35);
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
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(208, 35);
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
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(208, 35);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // viewAllDonorsToolStripMenuItem
            // 
            this.viewAllDonorsToolStripMenuItem.AutoSize = false;
            this.viewAllDonorsToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.viewAllDonorsToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.viewAllDonorsToolStripMenuItem.Name = "viewAllDonorsToolStripMenuItem";
            this.viewAllDonorsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(97, 0, 118, 0);
            this.viewAllDonorsToolStripMenuItem.Size = new System.Drawing.Size(208, 35);
            this.viewAllDonorsToolStripMenuItem.Text = "Donors";
            this.viewAllDonorsToolStripMenuItem.Click += new System.EventHandler(this.viewAllDonorsToolStripMenuItem_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid1.ColumnHeadersHeight = 35;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.fathersNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.City,
            this.phoneDataGridViewTextBoxColumn,
            this.dateofBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.registeredAsDataGridViewTextBoxColumn,
            this.Donated});
            this.metroGrid1.DataSource = this.rPDBTableBindingSource3;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(13, 118);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Red;
            this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid1.RowTemplate.Height = 40;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1280, 443);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroGrid1.TabIndex = 3;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
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
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.DividerWidth = 1;
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.Width = 120;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.DividerWidth = 1;
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // dateofBirthDataGridViewTextBoxColumn
            // 
            this.dateofBirthDataGridViewTextBoxColumn.DataPropertyName = "DateofBirth";
            this.dateofBirthDataGridViewTextBoxColumn.DividerWidth = 1;
            this.dateofBirthDataGridViewTextBoxColumn.HeaderText = "DateofBirth";
            this.dateofBirthDataGridViewTextBoxColumn.Name = "dateofBirthDataGridViewTextBoxColumn";
            this.dateofBirthDataGridViewTextBoxColumn.Width = 125;
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
            this.registeredAsDataGridViewTextBoxColumn.Width = 125;
            // 
            // Donated
            // 
            this.Donated.DataPropertyName = "Donated";
            this.Donated.DividerWidth = 1;
            this.Donated.HeaderText = "Donated";
            this.Donated.Name = "Donated";
            this.Donated.Width = 120;
            // 
            // rPDBTableBindingSource3
            // 
            this.rPDBTableBindingSource3.DataMember = "RPDBTable";
            this.rPDBTableBindingSource3.DataSource = this.regPatDBDataSet7;
            // 
            // regPatDBDataSet7
            // 
            this.regPatDBDataSet7.DataSetName = "RegPatDBDataSet7";
            this.regPatDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPDBTableBindingSource1
            // 
            this.rPDBTableBindingSource1.DataMember = "RPDBTable";
            this.rPDBTableBindingSource1.DataSource = this.regPatDBDataSet5;
            // 
            // regPatDBDataSet5
            // 
            this.regPatDBDataSet5.DataSetName = "RegPatDBDataSet5";
            this.regPatDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPDBTableBindingSource
            // 
            this.rPDBTableBindingSource.DataMember = "RPDBTable";
            this.rPDBTableBindingSource.DataSource = this.regPatDBDataSet;
            // 
            // regPatDBDataSet
            // 
            this.regPatDBDataSet.DataSetName = "RegPatDBDataSet";
            this.regPatDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPDBTableTableAdapter
            // 
            this.rPDBTableTableAdapter.ClearBeforeFill = true;
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
            this.menuStrip2.Size = new System.Drawing.Size(1249, 35);
            this.menuStrip2.TabIndex = 42;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
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
            this.toDonateToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.toDonateToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.toDonateToolStripMenuItem.Name = "toDonateToolStripMenuItem";
            this.toDonateToolStripMenuItem.Size = new System.Drawing.Size(177, 35);
            this.toDonateToolStripMenuItem.Text = "To Donate";
            this.toDonateToolStripMenuItem.Click += new System.EventHandler(this.toDonateToolStripMenuItem_Click);
            // 
            // rPDBTableTableAdapter1
            // 
            this.rPDBTableTableAdapter1.ClearBeforeFill = true;
            // 
            // regPatDBDataSet6
            // 
            this.regPatDBDataSet6.DataSetName = "RegPatDBDataSet6";
            this.regPatDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPDBTableBindingSource2
            // 
            this.rPDBTableBindingSource2.DataMember = "RPDBTable";
            this.rPDBTableBindingSource2.DataSource = this.regPatDBDataSet6;
            // 
            // rPDBTableTableAdapter2
            // 
            this.rPDBTableTableAdapter2.ClearBeforeFill = true;
            // 
            // rPDBTableTableAdapter3
            // 
            this.rPDBTableTableAdapter3.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BloodBankApp_FinalProject_.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(457, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // matchBloodToolStripMenuItem1
            // 
            this.matchBloodToolStripMenuItem1.AutoSize = false;
            this.matchBloodToolStripMenuItem1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchBloodToolStripMenuItem1.ForeColor = System.Drawing.Color.Crimson;
            this.matchBloodToolStripMenuItem1.Name = "matchBloodToolStripMenuItem1";
            this.matchBloodToolStripMenuItem1.Size = new System.Drawing.Size(208, 35);
            this.matchBloodToolStripMenuItem1.Text = "Match Blood";
            this.matchBloodToolStripMenuItem1.Click += new System.EventHandler(this.matchBloodToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AutoSize = false;
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(200, 35);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 614);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "patients";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.patients_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPDBTableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPatDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPDBTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPatDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPDBTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPatDBDataSet)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regPatDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPDBTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllDonorsToolStripMenuItem;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private RegPatDBDataSet regPatDBDataSet;
        private System.Windows.Forms.BindingSource rPDBTableBindingSource;
        private RegPatDBDataSetTableAdapters.RPDBTableTableAdapter rPDBTableTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem changeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchBloodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDonateToolStripMenuItem;
        private RegPatDBDataSet5 regPatDBDataSet5;
        private System.Windows.Forms.BindingSource rPDBTableBindingSource1;
        private RegPatDBDataSet5TableAdapters.RPDBTableTableAdapter rPDBTableTableAdapter1;
        private RegPatDBDataSet6 regPatDBDataSet6;
        private System.Windows.Forms.BindingSource rPDBTableBindingSource2;
        private RegPatDBDataSet6TableAdapters.RPDBTableTableAdapter rPDBTableTableAdapter2;
        private RegPatDBDataSet7 regPatDBDataSet7;
        private System.Windows.Forms.BindingSource rPDBTableBindingSource3;
        private RegPatDBDataSet7TableAdapters.RPDBTableTableAdapter rPDBTableTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathersNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registeredAsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donated;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem matchBloodToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}