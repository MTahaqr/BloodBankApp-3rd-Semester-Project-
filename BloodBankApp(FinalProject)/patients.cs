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
            this.Hide();
            DonorsObj.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register RegisterObj = new Register();
            this.Hide();
            RegisterObj.Show();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search SearchObj = new Search();
            this.Hide();
            SearchObj.Show();
        }

        private void patients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'regPatDBDataSet.RPDBTable' table. You can move, or remove it, as needed.
            this.rPDBTableTableAdapter.Fill(this.regPatDBDataSet.RPDBTable);

        }
    }
}
