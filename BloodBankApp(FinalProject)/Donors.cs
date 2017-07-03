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
            this.Hide();
            RegisterObj.Show();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patients patientsObj = new patients();
            this.Hide();
            patientsObj.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search SearchObj = new Search();
            this.Hide();
            SearchObj.Show();
        }
    }
}
