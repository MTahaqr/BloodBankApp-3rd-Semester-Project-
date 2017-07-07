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
    public partial class ToDonate : MetroFramework.Forms.MetroForm
    {
        public ToDonate()
        {
            InitializeComponent();
            this.toDonateToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDonateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toDonateToolStripMenuItem.BackColor = Color.Crimson;


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
            
        }

        private void ToDonate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'regPatDBDataSet4.RPDBTable' table. You can move, or remove it, as needed.
            this.rPDBTableTableAdapter1.Fill(this.regPatDBDataSet4.RPDBTable);
            // TODO: This line of code loads data into the 'registerDBDataSet7.RDBTable' table. You can move, or remove it, as needed.
            this.rDBTableTableAdapter1.Fill(this.registerDBDataSet7.RDBTable);
            // TODO: This line of code loads data into the 'regPatDBDataSet3.RPDBTable' table. You can move, or remove it, as needed.
            this.rPDBTableTableAdapter.Fill(this.regPatDBDataSet3.RPDBTable);
            // TODO: This line of code loads data into the 'registerDBDataSet6.RDBTable' table. You can move, or remove it, as needed.
            this.rDBTableTableAdapter.Fill(this.registerDBDataSet6.RDBTable);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string donorBloodGroup = metroGrid1.SelectedRows[0].Cells[4].Value.ToString();
            string patientBloodGroup = metroGrid2.SelectedRows[0].Cells[4].Value.ToString();
            string donorId = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            string patientid = metroGrid2.SelectedRows[0].Cells[0].Value.ToString();
            string pDonated = metroGrid2.SelectedRows[0].Cells[6].Value.ToString();
            string dDonated = metroGrid1.SelectedRows[0].Cells[6].Value.ToString();
            

            if (pDonated == "No"  )
            {
                if (pDonated == "No")
                {
                    ToDonateData ToDonateDataObj = new ToDonateData(donorId, donorBloodGroup, patientid, patientBloodGroup);
                    bool Donated = ToDonateDataObj.ToDonateBlood();
                    if (Donated)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Blood Donated Successffully", "Donation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Sorry, Blood not Match", "Donation Incomplete", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry, Blood already Donated", "Donation Incomplete", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Sorry, Blood already Donated", "Donation Incomplete", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }


        }
    }
}
