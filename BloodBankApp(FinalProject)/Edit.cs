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
    public partial class Edit : MetroFramework.Forms.MetroForm
    {
        string email;
        string Id;
        string radioBtn2;
        public Edit()
        {
            InitializeComponent();
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.BackColor = Color.Crimson;


            email = LoginData.email;
            SqlConnection conDonor = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
            string queryD = " Select Id,name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs from [RDBTable] where Email like '" + email + "%'";
            SqlDataAdapter sdaD = new SqlDataAdapter(queryD, conDonor);
            DataTable donorTab = new DataTable();
            sdaD.Fill(donorTab);
            metroGrid1.DataSource = donorTab;
            //string rowValue = metroGrid1.Rows[0].Cells[0].Value.ToString();
            if (donorTab.Rows.Count == 0 )
            {
                SqlConnection connPatient = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
                string queryP = " Select Id,name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs from [RPDBTable] where Email like '" + email + "%'";
                SqlDataAdapter sdaP = new SqlDataAdapter(queryP, connPatient);
                DataTable patientTable = new DataTable();
                sdaP.Fill(patientTable);
                metroGrid1.DataSource = patientTable;
            }
            Id = metroGrid1.Rows[0].Cells[0].Value.ToString();
            metroTextBox1.Text = metroGrid1.Rows[0].Cells[1].Value.ToString();
            metroTextBox2.Text = metroGrid1.Rows[0].Cells[2].Value.ToString();
            metroTextBox3.Text = metroGrid1.Rows[0].Cells[3].Value.ToString();
            metroTextBox4.Text = metroGrid1.Rows[0].Cells[4].Value.ToString();
            metroTextBox5.Text = metroGrid1.Rows[0].Cells[5].Value.ToString();
            dateTimePicker1.Text = metroGrid1.Rows[0].Cells[6].Value.ToString();
            if(metroGrid1.Rows[0].Cells[7].Value.ToString() == "Male")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            
            radioBtn2 = metroGrid1.Rows[0].Cells[9].Value.ToString();

        }


        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string radioBtn = null;
            if (radioButton1.Checked == true)
            {
                radioBtn = "Male";
            }
            else if (radioButton2.Checked == true)
            {
                radioBtn = "Female";
            }
            
            if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "" || metroTextBox4.Text == "" || metroTextBox5.Text == "" || dateTimePicker1.Text == "" || radioBtn == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Complete All The Fields", "Save InComplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (radioBtn2 == "Donor")
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
                    connection.Open();
                    SqlDataAdapter SDA = new SqlDataAdapter("update [RDBTable] set name='" + metroTextBox1.Text + "',fathersName='" + metroTextBox2.Text + "' ,age='" + metroTextBox3.Text + "' ,City='" + metroTextBox4.Text + "' ,phone='" + metroTextBox5.Text + "' ,DateOfBirth='" + dateTimePicker1.Text + "' ,gender='" + radioBtn + "'  where id='" + Id + "'", connection);
                    SDA.SelectCommand.ExecuteNonQuery();
                    connection.Close();
                    MetroFramework.MetroMessageBox.Show(this, "SuccessFully", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radioBtn2  == "Patient")
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
                    connection.Open();
                    SqlDataAdapter SDA = new SqlDataAdapter("update [RPDBTable] set name='" + metroTextBox1.Text + "',fathersName='" + metroTextBox2.Text + "' ,age='" + metroTextBox3.Text + "' ,City='" + metroTextBox4.Text + "' ,phone='" + metroTextBox5.Text + "' ,DateOfBirth='" + dateTimePicker1.Text + "' ,gender='" + radioBtn + "'  where id='" + Id + "'", connection);
                    SDA.SelectCommand.ExecuteNonQuery();
                    connection.Close();
                    MetroFramework.MetroMessageBox.Show(this, "SuccessFully", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Complete All The Fields", "Changes Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


        }

        private void Edit_Load(object sender, EventArgs e)
        {

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

        private void viewAllDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donors DonorsObj = new Donors();
            DonorsObj.Show();
            this.Hide();
        }

        private void matchBloodToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MatchBlood MatchBloodObj = new MatchBlood();
            MatchBloodObj.Show();
            this.Hide();
        }
    }
}
