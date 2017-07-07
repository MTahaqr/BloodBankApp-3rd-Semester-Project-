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
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
            
            this.registerToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registerToolStripMenuItem.BackColor = Color.Crimson;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.BackColor = Color.Crimson;

        }
        string radioBtn1;
        string radioBtn2;
        private void Register_Load(object sender, EventArgs e)
        {
            LoginData loginDataObj = new LoginData();
            menuStrip2.Visible = LoginData.checkLoginAs();
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

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (radioBtn2 == "Donor")
            {
                RegisterData RegisterDataObj = new RegisterData(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroTextBox4.Text, metroTextBox5.Text,dateTimePicker1.Text, radioBtn1 , comboBox1.Text, radioBtn2 );
                RegisterDataObj.RegisterDonors();
                MetroFramework.MetroMessageBox.Show(this, "Donor Registered SuccessFully", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                RegisterData RegisterDataObj = new RegisterData(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroTextBox4.Text, metroTextBox5.Text, dateTimePicker1.Text, radioBtn1, comboBox1.Text, radioBtn2);
                RegisterDataObj.RegisterPatients();
                MetroFramework.MetroMessageBox.Show(this, "Donor Registered SuccessFully", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //RegisterPatientData RegisterPatientDataObj = new RegisterPatientData(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroTextBox4.Text, metroTextBox5.Text,dateTimePicker1.Text, radioBtn1 , comboBox1.Text, radioBtn2 );
                //RegisterPatientDataObj.RegisterPatient();
                //MetroFramework.MetroMessageBox.Show(this, " Registered"  +radioBtn2  + "SuccessFully", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             radioBtn1 = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioBtn1 = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
             radioBtn2 = radioButton3.Text;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioBtn2 = radioButton4.Text;

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Search SearchObj = new Search();
            SearchObj.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            patients patientsObj = new patients();
            patientsObj.Show();
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
            Change ChangeDataObj = new Change();
            ChangeDataObj.Show();
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
