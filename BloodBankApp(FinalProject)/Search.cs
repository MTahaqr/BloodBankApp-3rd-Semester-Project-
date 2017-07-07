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
    public partial class Search : MetroFramework.Forms.MetroForm 
    {
        public Search()
        {
            InitializeComponent();
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.searchToolStripMenuItem.BackColor = Color.Crimson;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.BackColor = Color.Crimson;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            menuStrip2.Visible = LoginData.checkLoginAs();
        }
        string radioBtn;

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void viewAllDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donors DonorsObj = new Donors();
            DonorsObj.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            SearchData SearchDataObj = new SearchData(radioBtn,metroComboBox1.Text ,metroTextBox1.Text );
            if (radioBtn == "Donor")
            {
                    SqlDataAdapter sda = SearchDataObj.SearchForDonor();
                    DataTable loginTable1 = new DataTable();
                    sda.Fill(loginTable1);
                    metroGrid1.DataSource = loginTable1;
            }
            else
            {
                    SqlDataAdapter sda = SearchDataObj.SearchForDonor();
                    DataTable loginTable1 = new DataTable();
                    sda.Fill(loginTable1);
                    metroGrid1.DataSource = loginTable1;
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
             radioBtn = metroRadioButton1.Text;
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioBtn = metroRadioButton2.Text;
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




//private void metroButton1_Click(object sender, EventArgs e)
//{

//    SearchData SearchDataObj = new SearchData(radioBtn, metroComboBox1.Text, metroTextBox1.Text);
//    if (radioBtn == "Donor")
//    {
//        MessageBox.Show(metroRadioButton1.Text + "   " + metroRadioButton2.Text);
//        //if (metroComboBox1.Text == "Name")
//        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//        //string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where name like '" + metroTextBox1.Text + "%'";
//        //SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//        //DataTable loginTable1 = new DataTable();
//        //sda.Fill(loginTable1);
//        //metroGrid1.DataSource = loginTable1;

//        SqlDataAdapter sda = SearchDataObj.SearchForDonor();
//        DataTable loginTable1 = new DataTable();
//        sda.Fill(loginTable1);
//        metroGrid1.DataSource = loginTable1;
//        //else if (metroComboBox1.Text == "Father'sName")
//        //{
//        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//        //    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where fathersName like '" + metroTextBox1.Text + "%'";
//        //    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//        //    DataTable loginTable1 = new DataTable();
//        //    sda.Fill(loginTable1);
//        //    metroGrid1.DataSource = loginTable1;

//        //}
//        //else if (metroComboBox1.Text == "Age")
//        //{
//        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//        //    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where age like '" + metroTextBox1.Text + "%'";
//        //    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//        //    DataTable loginTable1 = new DataTable();
//        //    sda.Fill(loginTable1);
//        //    metroGrid1.DataSource = loginTable1;
//        //}
//        //else if (metroComboBox1.Text == "Address")
//        //{
//        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//        //    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where address like '" + metroTextBox1.Text + "%'";
//        //    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//        //    DataTable loginTable1 = new DataTable();
//        //    sda.Fill(loginTable1);
//        //    metroGrid1.DataSource = loginTable1;
//        //}
//        //else if (metroComboBox1.Text == "Phone")
//        //{
//        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//        //    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where phone like '" + metroTextBox1.Text + "%'";
//        //    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//        //    DataTable loginTable1 = new DataTable();
//        //    sda.Fill(loginTable1);
//        //    metroGrid1.DataSource = loginTable1;
//        //}
//        //else if (metroComboBox1.Text == "DateOfBirth")
//        //{
//        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//        //    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where dob like '" + metroTextBox1.Text + "%'";
//        //    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//        //    DataTable loginTable1 = new DataTable();
//        //    sda.Fill(loginTable1);
//        //    metroGrid1.DataSource = loginTable1;
//        //}
//        //else if (metroComboBox1.Text == "Gender")
//        //{
//        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//        //    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where gender like '" + metroTextBox1.Text + "%'";
//        //    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//        //    DataTable loginTable1 = new DataTable();
//        //    sda.Fill(loginTable1);
//        //    metroGrid1.DataSource = loginTable1;
//        //}
//        //else if (metroComboBox1.Text == "BloodGroup")
//        //{
//        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//        //    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where bloodGroup like '" + metroTextBox1.Text + "%'";
//        //    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//        //    DataTable loginTable1 = new DataTable();
//        //    sda.Fill(loginTable1);
//        //    metroGrid1.DataSource = loginTable1;
//        //}
//        //else
//        //{
//        //    MessageBox.Show("errot");
//        //}
//    }
//    else
//    {
//        if (metroComboBox1.Text == "Name")
//        {
//            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
//            string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisterAs from [RDBTable] where Name like '" + metroTextBox1.Text + "%'";
//            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//            DataTable loginTable1 = new DataTable();
//            sda.Fill(loginTable1);
//            metroGrid1.DataSource = loginTable1;
//        }


//        else if (metroComboBox1.Text == "Father'sName")
//        {
//            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//            string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisterAs from [RDBTable] where fathersName like '" + metroTextBox1.Text + "%'";
//            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//            DataTable loginTable1 = new DataTable();
//            sda.Fill(loginTable1);
//            metroGrid1.DataSource = loginTable1;

//        }
//        else if (metroComboBox1.Text == "Age")
//        {
//            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//            string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisterAs from [RDBTable] where age like '" + metroTextBox1.Text + "%'";
//            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//            DataTable loginTable1 = new DataTable();
//            sda.Fill(loginTable1);
//            metroGrid1.DataSource = loginTable1;
//        }
//        else if (metroComboBox1.Text == "Address")
//        {
//            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//            string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisterAs from [RDBTable] where address like '" + metroTextBox1.Text + "%'";
//            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//            DataTable loginTable1 = new DataTable();
//            sda.Fill(loginTable1);
//            metroGrid1.DataSource = loginTable1;
//        }
//        else if (metroComboBox1.Text == "Phone")
//        {
//            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//            string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisterAs from [RDBTable] where phone like '" + metroTextBox1.Text + "%'";
//            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//            DataTable loginTable1 = new DataTable();
//            sda.Fill(loginTable1);
//            metroGrid1.DataSource = loginTable1;
//        }
//        else if (metroComboBox1.Text == "DateOfBirth")
//        {
//            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//            string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisterAs from [RDBTable] where dob like '" + metroTextBox1.Text + "%'";
//            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//            DataTable loginTable1 = new DataTable();
//            sda.Fill(loginTable1);
//            metroGrid1.DataSource = loginTable1;
//        }
//        else if (metroComboBox1.Text == "Gender")
//        {
//            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//            string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisterAs from [RDBTable] where gender like '" + metroTextBox1.Text + "%'";
//            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//            DataTable loginTable1 = new DataTable();
//            sda.Fill(loginTable1);
//            metroGrid1.DataSource = loginTable1;
//        }
//        else if (metroComboBox1.Text == "BloodGroup")
//        {
//            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
//            string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisterAs from [RDBTable] where bloodGroup like '" + metroTextBox1.Text + "%'";
//            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
//            DataTable loginTable1 = new DataTable();
//            sda.Fill(loginTable1);
//            metroGrid1.DataSource = loginTable1;
//        }
//        else
//        {
//            MessageBox.Show("errot");
//        }
//    }
//}
