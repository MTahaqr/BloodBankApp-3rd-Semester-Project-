namespace BloodBankApp_FinalProject_
{
    partial class Donors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllDonorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerDBDataSet = new BloodBankApp_FinalProject_.RegisterDBDataSet();
            this.rDBTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDBTableTableAdapter = new BloodBankApp_FinalProject_.RegisterDBDataSetTableAdapters.RDBTableTableAdapter();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerAsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDBTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.registerDBDataSet2 = new BloodBankApp_FinalProject_.RegisterDBDataSet2();
            this.rDBTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registerDBDataSet1 = new BloodBankApp_FinalProject_.RegisterDBDataSet1();
            this.rDBTableTableAdapter1 = new BloodBankApp_FinalProject_.RegisterDBDataSet1TableAdapters.RDBTableTableAdapter();
            this.rDBTableTableAdapter2 = new BloodBankApp_FinalProject_.RegisterDBDataSet2TableAdapters.RDBTableTableAdapter();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchBloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDonateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDBTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDBTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDBTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDBDataSet1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.viewAllDonorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 7);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1219, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.AutoSize = false;
            this.registerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.registerToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(65, 0, 117, 0);
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(253, 25);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.AutoSize = false;
            this.patientsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.patientsToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(140, 0, 117, 0);
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(325, 25);
            this.patientsToolStripMenuItem.Text = "Patients";
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.AutoSize = false;
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Padding = new System.Windows.Forms.Padding(115, 0, 117, 0);
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(293, 25);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // viewAllDonorsToolStripMenuItem
            // 
            this.viewAllDonorsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.viewAllDonorsToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.viewAllDonorsToolStripMenuItem.Name = "viewAllDonorsToolStripMenuItem";
            this.viewAllDonorsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(97, 0, 118, 0);
            this.viewAllDonorsToolStripMenuItem.Size = new System.Drawing.Size(340, 25);
            this.viewAllDonorsToolStripMenuItem.Text = "View All Donors";
            // 
            // registerDBDataSet
            // 
            this.registerDBDataSet.DataSetName = "RegisterDBDataSet";
            this.registerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rDBTableBindingSource
            // 
            this.rDBTableBindingSource.DataMember = "RDBTable";
            this.rDBTableBindingSource.DataSource = this.registerDBDataSet;
            // 
            // rDBTableTableAdapter
            // 
            this.rDBTableTableAdapter.ClearBeforeFill = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.metroGrid1.ColumnHeadersHeight = 35;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.fathersNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.registerAsDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.rDBTableBindingSource2;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle38;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(46, 132);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.metroGrid1.RowTemplate.Height = 40;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1229, 430);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroGrid1.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.DividerWidth = 1;
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.Width = 130;
            // 
            // fathersNameDataGridViewTextBoxColumn
            // 
            this.fathersNameDataGridViewTextBoxColumn.DataPropertyName = "fathersName";
            this.fathersNameDataGridViewTextBoxColumn.DividerWidth = 1;
            this.fathersNameDataGridViewTextBoxColumn.HeaderText = "fathersName";
            this.fathersNameDataGridViewTextBoxColumn.Name = "fathersNameDataGridViewTextBoxColumn";
            this.fathersNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.DividerWidth = 1;
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 130;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.DividerWidth = 1;
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 130;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.DividerWidth = 1;
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 130;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.DividerWidth = 1;
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.Width = 130;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.DividerWidth = 1;
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 130;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "bloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.DividerWidth = 1;
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "bloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.Width = 130;
            // 
            // registerAsDataGridViewTextBoxColumn
            // 
            this.registerAsDataGridViewTextBoxColumn.DataPropertyName = "registerAs";
            this.registerAsDataGridViewTextBoxColumn.DividerWidth = 1;
            this.registerAsDataGridViewTextBoxColumn.HeaderText = "registerAs";
            this.registerAsDataGridViewTextBoxColumn.Name = "registerAsDataGridViewTextBoxColumn";
            this.registerAsDataGridViewTextBoxColumn.Width = 130;
            // 
            // rDBTableBindingSource2
            // 
            this.rDBTableBindingSource2.DataMember = "RDBTable";
            this.rDBTableBindingSource2.DataSource = this.registerDBDataSet2;
            // 
            // registerDBDataSet2
            // 
            this.registerDBDataSet2.DataSetName = "RegisterDBDataSet2";
            this.registerDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rDBTableBindingSource1
            // 
            this.rDBTableBindingSource1.DataMember = "RDBTable";
            this.rDBTableBindingSource1.DataSource = this.registerDBDataSet1;
            // 
            // registerDBDataSet1
            // 
            this.registerDBDataSet1.DataSetName = "RegisterDBDataSet1";
            this.registerDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rDBTableTableAdapter1
            // 
            this.rDBTableTableAdapter1.ClearBeforeFill = true;
            // 
            // rDBTableTableAdapter2
            // 
            this.rDBTableTableAdapter2.ClearBeforeFill = true;
            // 
            // menuStrip2
            // 
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
            this.menuStrip2.Size = new System.Drawing.Size(1315, 29);
            this.menuStrip2.TabIndex = 43;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Crimson;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(65, 0, 117, 0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 25);
            this.toolStripMenuItem1.Text = "Register";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Crimson;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Padding = new System.Windows.Forms.Padding(140, 0, 117, 0);
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 25);
            this.toolStripMenuItem2.Text = "Patients";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Crimson;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Padding = new System.Windows.Forms.Padding(115, 0, 117, 0);
            this.toolStripMenuItem3.Size = new System.Drawing.Size(173, 25);
            this.toolStripMenuItem3.Text = "Search";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AutoSize = false;
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.Crimson;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Padding = new System.Windows.Forms.Padding(97, 0, 118, 0);
            this.toolStripMenuItem4.Size = new System.Drawing.Size(173, 25);
            this.toolStripMenuItem4.Text = "View All Donors";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // changeDetailsToolStripMenuItem
            // 
            this.changeDetailsToolStripMenuItem.AutoSize = false;
            this.changeDetailsToolStripMenuItem.CheckOnClick = true;
            this.changeDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.changeDetailsToolStripMenuItem.Name = "changeDetailsToolStripMenuItem";
            this.changeDetailsToolStripMenuItem.Size = new System.Drawing.Size(173, 25);
            this.changeDetailsToolStripMenuItem.Text = "Change Data";
            this.changeDetailsToolStripMenuItem.Click += new System.EventHandler(this.changeDetailsToolStripMenuItem_Click);
            // 
            // matchBloodToolStripMenuItem
            // 
            this.matchBloodToolStripMenuItem.AutoSize = false;
            this.matchBloodToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchBloodToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.matchBloodToolStripMenuItem.Name = "matchBloodToolStripMenuItem";
            this.matchBloodToolStripMenuItem.Size = new System.Drawing.Size(173, 25);
            this.matchBloodToolStripMenuItem.Text = "Match Blood";
            this.matchBloodToolStripMenuItem.Click += new System.EventHandler(this.matchBloodToolStripMenuItem_Click);
            // 
            // toDonateToolStripMenuItem
            // 
            this.toDonateToolStripMenuItem.AutoSize = false;
            this.toDonateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDonateToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.toDonateToolStripMenuItem.Name = "toDonateToolStripMenuItem";
            this.toDonateToolStripMenuItem.Size = new System.Drawing.Size(173, 25);
            this.toDonateToolStripMenuItem.Text = "To Donate";
            this.toDonateToolStripMenuItem.Click += new System.EventHandler(this.toDonateToolStripMenuItem_Click);
            // 
            // Donors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 614);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Donors";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Donors_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDBTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDBTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDBTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDBDataSet1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllDonorsToolStripMenuItem;
        private RegisterDBDataSet registerDBDataSet;
        private System.Windows.Forms.BindingSource rDBTableBindingSource;
        private RegisterDBDataSetTableAdapters.RDBTableTableAdapter rDBTableTableAdapter;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private RegisterDBDataSet1 registerDBDataSet1;
        private System.Windows.Forms.BindingSource rDBTableBindingSource1;
        private RegisterDBDataSet1TableAdapters.RDBTableTableAdapter rDBTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathersNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerAsDataGridViewTextBoxColumn;
        private RegisterDBDataSet2 registerDBDataSet2;
        private System.Windows.Forms.BindingSource rDBTableBindingSource2;
        private RegisterDBDataSet2TableAdapters.RDBTableTableAdapter rDBTableTableAdapter2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem changeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchBloodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDonateToolStripMenuItem;
    }
}