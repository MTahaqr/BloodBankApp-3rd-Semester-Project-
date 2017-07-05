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
    public partial class Form1 : MetroFramework.Forms.MetroForm 
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {
            signUp  signUpObj = new signUp();
            this.Hide();
            signUpObj.Show();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginData LoginDataObj = new LoginData( metroTextBox1.Text, metroTextBox2.Text, comboBox1.Text);
            LoginData.checkLoginAs();
            SqlDataAdapter sda = LoginDataObj.logIn();
            DataTable loginTable1 = new DataTable();
            sda.Fill(loginTable1);
            if (loginTable1.Rows[0][0].ToString() == "1")
            {
                Register RegisterObj = new Register();
                this.Hide();
                RegisterObj.Show();
            }
            else
            {

                MessageBox.Show("Check Your Username and Password");
            }

        }
    }
}
