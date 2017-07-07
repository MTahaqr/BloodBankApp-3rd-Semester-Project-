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
    public partial class MatchBlood : MetroFramework.Forms.MetroForm
    {
        public MatchBlood()
        {
            InitializeComponent();
            this.matchBloodToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchBloodToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.matchBloodToolStripMenuItem.BackColor = Color.Crimson;

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register RegisterObj = new Register();
            RegisterObj.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search SearchObj = new Search();
            SearchObj.Show();
            this.Hide();
        }

        private void viewAllDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donors DonorsObj = new Donors();
            DonorsObj.Show();
            this.Hide();

        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change ChangeObj = new Change();
            ChangeObj.Show();
            this.Hide();
        }

        private void matchBloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MatchBlood MatchBloodObj = new MatchBlood();
            //MatchBloodObj.Show();
            //this.Hide();
        }

        private void toDonateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDonate ToDonateObj = new ToDonate();
            ToDonateObj.Show();
            this.Hide();
        }
    }
}
