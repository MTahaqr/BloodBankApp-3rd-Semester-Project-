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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllDonorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registeredAsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPDBTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPatDBDataSet)).BeginInit();
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.viewAllDonorsToolStripMenuItem.Click += new System.EventHandler(this.viewAllDonorsToolStripMenuItem_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.metroGrid1.ColumnHeadersHeight = 35;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.fathersNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.dateofBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.registeredAsDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.rPDBTableBindingSource;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle48;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 137);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle50;
            this.metroGrid1.RowTemplate.Height = 40;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1252, 443);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroGrid1.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // fathersNameDataGridViewTextBoxColumn
            // 
            this.fathersNameDataGridViewTextBoxColumn.DataPropertyName = "FathersName";
            this.fathersNameDataGridViewTextBoxColumn.HeaderText = "FathersName";
            this.fathersNameDataGridViewTextBoxColumn.Name = "fathersNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // dateofBirthDataGridViewTextBoxColumn
            // 
            this.dateofBirthDataGridViewTextBoxColumn.DataPropertyName = "DateofBirth";
            this.dateofBirthDataGridViewTextBoxColumn.HeaderText = "DateofBirth";
            this.dateofBirthDataGridViewTextBoxColumn.Name = "dateofBirthDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            // 
            // registeredAsDataGridViewTextBoxColumn
            // 
            this.registeredAsDataGridViewTextBoxColumn.DataPropertyName = "RegisteredAs";
            this.registeredAsDataGridViewTextBoxColumn.HeaderText = "RegisteredAs";
            this.registeredAsDataGridViewTextBoxColumn.Name = "registeredAsDataGridViewTextBoxColumn";
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
            this.menuStrip2.TabIndex = 42;
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
            // patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 614);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "patients";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.patients_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPDBTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPatDBDataSet)).EndInit();
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
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private RegPatDBDataSet regPatDBDataSet;
        private System.Windows.Forms.BindingSource rPDBTableBindingSource;
        private RegPatDBDataSetTableAdapters.RPDBTableTableAdapter rPDBTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathersNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registeredAsDataGridViewTextBoxColumn;
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