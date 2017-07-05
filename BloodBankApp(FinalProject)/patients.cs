﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankApp_FinalProject_
{
    public partial class patients : MetroFramework.Forms.MetroForm
    {
        public patients()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewAllDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donors DonorsObj = new Donors();
            DonorsObj.Show();
            this.Hide();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register RegisterObj = new Register();
            RegisterObj.Show();
            this.Hide();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search SearchObj = new Search();
            SearchObj.Show();
            this.Hide();
        }

        private void patients_Load(object sender, EventArgs e)
        {
            menuStrip2.Visible = LoginData.checkLoginAs();
            // TODO: This line of code loads data into the 'regPatDBDataSet.RPDBTable' table. You can move, or remove it, as needed.
            this.rPDBTableTableAdapter.Fill(this.regPatDBDataSet.RPDBTable);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Register RegisterObj = new Register();
            RegisterObj.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Search SearchObj = new Search();
            SearchObj.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Donors DonorsObj = new Donors();
            DonorsObj.Show();
            this.Hide();
        }

        private void changeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change ChangeObj = new Change();
            ChangeObj.Show();
            this.Hide();
        }

        private void matchBloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatchBlood MatchBloodObj = new MatchBlood();
            MatchBloodObj.Show();
            this.Hide();
        }

        private void toDonateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDonate ToDonateObj = new ToDonate();
            ToDonateObj.Show();
            this.Hide();
        }
    }
}
