using System;
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
    public partial class Donors : MetroFramework.Forms.MetroForm
    {
        public Donors()
        {
            InitializeComponent();
        }

        private void Donors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registerDBDataSet2.RDBTable' table. You can move, or remove it, as needed.
            this.rDBTableTableAdapter2.Fill(this.registerDBDataSet2.RDBTable);
            // TODO: This line of code loads data into the 'registerDBDataSet1.RDBTable' table. You can move, or remove it, as needed.
            this.rDBTableTableAdapter1.Fill(this.registerDBDataSet1.RDBTable);
            // TODO: This line of code loads data into the 'registerDBDataSet.RDBTable' table. You can move, or remove it, as needed.
            this.rDBTableTableAdapter.Fill(this.registerDBDataSet.RDBTable);

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register RegisterObj = new Register();
            RegisterObj.Show();
            this.Hide();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patients patientsObj = new patients();
            patientsObj.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search SearchObj = new Search();
            SearchObj.Show();
            this.Hide();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Register RegisterObj = new Register();
            RegisterObj.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            patients patientsObj = new patients();
            patientsObj.Show();
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
