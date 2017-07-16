using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            ToDonateData ToDonateDataObj = new ToDonateData();
            SqlDataAdapter sda = ToDonateDataObj.RefreshDonors();
            DataTable loginTable1 = new DataTable();
            sda.Fill(loginTable1);
            metroGrid1.DataSource = loginTable1;
            SqlDataAdapter sda1 = ToDonateDataObj.RefreshPatients();
            DataTable loginTable2 = new DataTable();
            sda1.Fill(loginTable2);
            metroGrid2.DataSource = loginTable2;
            //// TODO: This line of code loads data into the 'regPatDBDataSet9.RPDBTable' table. You can move, or remove it, as needed.
            //this.rPDBTableTableAdapter2.Fill(this.regPatDBDataSet9.RPDBTable);
            //// TODO: This line of code loads data into the 'registerDBDataSet19.RDBTable' table. You can move, or remove it, as needed.
            //this.rDBTableTableAdapter3.Fill(this.registerDBDataSet19.RDBTable);


            //ToDonateData ToDonateDataObj = new ToDonateData();
            //SqlDataAdapter sda = ToDonateDataObj.RemDonors();
            //DataTable loginTable1 = new DataTable();
            //sda.Fill(loginTable1);
            //metroGrid1.DataSource = loginTable1;
            //SqlDataAdapter sda1 = ToDonateDataObj.RemPatients();
            //DataTable loginTable2 = new DataTable();
            //sda1.Fill(loginTable2);
            //metroGrid2.DataSource = loginTable2;


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string donorBloodGroup = metroGrid1.SelectedRows[0].Cells[4].Value.ToString();
            string patientBloodGroup = metroGrid2.SelectedRows[0].Cells[4].Value.ToString();
            string donorId = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            string patientid = metroGrid2.SelectedRows[0].Cells[0].Value.ToString();
            string pDonated = metroGrid2.SelectedRows[0].Cells[6].Value.ToString();
            string dDonated = metroGrid1.SelectedRows[0].Cells[6].Value.ToString();
            //MessageBox.Show(donorId);
            //MessageBox.Show(patientid);
            //MessageBox.Show(dDonated);
            //MessageBox.Show(pDonated);

            if (pDonated == "No"  )
            {
                if (dDonated == "No")
                {
                    ToDonateData ToDonateDataObj = new ToDonateData(donorId, donorBloodGroup, patientid, patientBloodGroup);
                    bool Donated = ToDonateDataObj.ToDonateBlood();
                    if (Donated)
                    {
                        SqlDataAdapter sda = ToDonateDataObj.RefreshDonors();
                        DataTable loginTable1 = new DataTable();
                        sda.Fill(loginTable1);
                        metroGrid1.DataSource = loginTable1;
                        SqlDataAdapter sda1 = ToDonateDataObj.RefreshPatients();
                        DataTable loginTable2 = new DataTable();
                        sda1.Fill(loginTable2);
                        metroGrid2.DataSource = loginTable2;

                        MetroFramework.MetroMessageBox.Show(this, "Blood Donated Successffully", "Donation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Sorry, Blood not Match", "Donation Incomplete", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry, Donors Blood Is Already Donated", "Donation Incomplete", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Sorry, Blood already Donated to Patient", "Donation Incomplete", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }


        }
    }
}
