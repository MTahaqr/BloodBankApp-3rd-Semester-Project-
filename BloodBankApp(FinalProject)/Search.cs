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
        }

        private void Search_Load(object sender, EventArgs e)
        {
          
        }
        string radioBtn;

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void viewAllDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donors DonorsObj = new Donors();
            this.Hide();
            DonorsObj.Show();
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
