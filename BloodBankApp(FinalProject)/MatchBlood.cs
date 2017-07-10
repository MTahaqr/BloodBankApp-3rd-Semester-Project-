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
        string query;

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
            
            if (metroComboBox1.Text == "AB+")
            {
                query = " Select name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated from [RDBTable] where ABp like '" + "Yes" + "%'";

            }
            else if(metroComboBox1.Text == "AB-")
            {
                query = " Select name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated from [RDBTable] where ABn like '" + "Yes" + "%'";

            }
            else if (metroComboBox1.Text == "A+")
            {
                query = " Select name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated from [RDBTable] where Ap like '" + "Yes" + "%'";

            }
            else if (metroComboBox1.Text == "A-")
            {
                query = " Select name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated from [RDBTable] where An like '" + "Yes" + "%'";

            }
            else if (metroComboBox1.Text == "B+")
            {
                query = " Select name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated from [RDBTable] where Bp like '" + "Yes" + "%'";

            }
            else if (metroComboBox1.Text == "B-")
            {
                query = " Select name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated from [RDBTable] where Bn like '" + "Yes" + "%'";

            }
            else if (metroComboBox1.Text == "O+")
            {
                query = " Select name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated from [RDBTable] where Op like '" + "Yes" + "%'";

            }
            else if (metroComboBox1.Text == "O-")
            {
                query = " Select name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated from [RDBTable] where Onn like '" + "Yes" + "%'";

            }
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable loginTable1 = new DataTable();
            sda.Fill(loginTable1);
            metroGrid1.DataSource = loginTable1;
        }

        private void MatchBlood_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registerDBDataSet18.RDBTable' table. You can move, or remove it, as needed.
            this.rDBTableTableAdapter2.Fill(this.registerDBDataSet18.RDBTable);


        }
    }
}
