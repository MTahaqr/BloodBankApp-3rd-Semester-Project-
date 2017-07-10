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
    public partial class Change : MetroFramework.Forms.MetroForm
    {
        public Change()
        {
            InitializeComponent();
            this.changeToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changeToolStripMenuItem.BackColor = Color.Crimson;
        }
        
        //ChangeData ChangeDataObj = new ChangeData();
        ChangeData ChangeDataObj;
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

        private void changedataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            string id = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            string name = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            string fathersName = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
            string age = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();
            string address = metroGrid1.SelectedRows[0].Cells[4].Value.ToString();
            string phone = metroGrid1.SelectedRows[0].Cells[5].Value.ToString();
            string dob = metroGrid1.SelectedRows[0].Cells[6].Value.ToString();
            string gender = metroGrid1.SelectedRows[0].Cells[7].Value.ToString();
            string bloodGroup = metroGrid1.SelectedRows[0].Cells[8].Value.ToString();
            string registerAs = metroGrid1.SelectedRows[0].Cells[9].Value.ToString();

            ChangeDataObj = new ChangeData(id,name,fathersName,age ,address ,phone ,dob ,gender ,bloodGroup);

            //SqlDataAdapter SDA2 = ChangeDataObj.DonorsListRefresh();
            //DataTable Data = new DataTable();
            //SDA2.Fill(Data);
            //metroGrid1.DataSource = Data;

            SqlDataAdapter SDA2 = ChangeDataObj.updateDonors();
            DataTable Data = new DataTable();
            SDA2.Fill(Data);
            metroGrid1.DataSource = Data;
            //connection.Close();
            //MessageBox.Show("up inserted Suceessfull");
        }

        private void Change_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registerDBDataSet17.RDBTable' table. You can move, or remove it, as needed.
            this.rDBTableTableAdapter4.Fill(this.registerDBDataSet17.RDBTable);
            // TODO: This line of code loads data into the 'regPatDBDataSet8.RPDBTable' table. You can move, or remove it, as needed.
            this.rPDBTableTableAdapter2.Fill(this.regPatDBDataSet8.RPDBTable);

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //metroTextBox1.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            //metroTextBox2.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            //metroTextBox3.Text = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
            //metroTextBox4.Text = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();
            //metroTextBox5.Text = metroGrid1.SelectedRows[0].Cells[4].Value.ToString();
            //dateTimePicker1.Text = metroGrid1.SelectedRows[0].Cells[5].Value.ToString();
            //radioButton1.Text = metroGrid1.SelectedRows[0].Cells[6].Value.ToString();
            //comboBox1.Text = metroGrid1.SelectedRows[0].Cells[7].Value.ToString();
            //radioButton3.Text = metroGrid1.SelectedRows[0].Cells[8].Value.ToString();

            



        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

            metroGrid1.Visible  = true;
            metroGrid2.Visible = false;
            metroButton1.Visible = true;
            metroButton4.Visible = true;
            metroButton5.Visible = false;

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
            connection.Open();
            SqlDataAdapter SDA1 = new SqlDataAdapter("Select * from [RDBTable]", connection);


            //SqlDataAdapter SDA2 = ChangeDataObj.DonorsListRefresh();
            DataTable Data = new DataTable();
            SDA1.Fill(Data);
            metroGrid1.DataSource = Data;
            //connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
            //connection.Open();
            //SqlDataAdapter SDA1 = new SqlDataAdapter("Select * from [RDBTable]", connection);

            //SqlDataAdapter SDA1 = ChangeDataObj.updateDonors();
            //DataTable Data = new DataTable();
            //SDA1.Fill(Data);
            //metroGrid1.DataSource = Data;
            //connection.Close();


            ////metroGrid1.Visible = true;
            //SqlDataAdapter SDA2 = ChangeDataObj.showsDonors();
            //DataTable Data = new DataTable();
            //SDA2.Fill(Data);
            //metroGrid1.DataSource = Data;
            ////connection.Close();
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            metroGrid1.Visible = false ;
            metroGrid2.Visible = true;
            metroButton3.Visible = false;
            metroButton3.Visible = true;
            metroButton4.Visible = false;
            metroButton5.Visible = true;
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
            connection.Open();
            SqlDataAdapter SDA1 = new SqlDataAdapter("Select * from [RPDBTable]", connection);
            //SqlDataAdapter SDA2 = ChangeDataObj.DonorsListRefresh();
            DataTable Data = new DataTable();
            SDA1.Fill(Data);
            metroGrid2.DataSource = Data;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string id = metroGrid2.SelectedRows[0].Cells[0].Value.ToString();
            string name = metroGrid2.SelectedRows[0].Cells[1].Value.ToString();
            string fathersName = metroGrid2.SelectedRows[0].Cells[2].Value.ToString();
            string age = metroGrid2.SelectedRows[0].Cells[3].Value.ToString();
            string address = metroGrid2.SelectedRows[0].Cells[4].Value.ToString();
            string phone = metroGrid2.SelectedRows[0].Cells[5].Value.ToString();
            string dob = metroGrid2.SelectedRows[0].Cells[6].Value.ToString();
            string gender = metroGrid2.SelectedRows[0].Cells[7].Value.ToString();
            string bloodGroup = metroGrid2.SelectedRows[0].Cells[8].Value.ToString();
            string registerAs = metroGrid2.SelectedRows[0].Cells[9].Value.ToString();

            ChangeDataObj = new ChangeData(id, name, fathersName, age, address, phone, dob, gender, bloodGroup);
            SqlDataAdapter SDA2 = ChangeDataObj.updatePatients();
            DataTable Data = new DataTable();
            SDA2.Fill(Data);
            metroGrid2.DataSource = Data;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string id = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            ChangeData ChangeDataObj1 = new ChangeData(id );
            ChangeDataObj1.deleteDonor();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
            connection.Open();
            SqlDataAdapter SDA1 = new SqlDataAdapter("Select * from [RDBTable]", connection);
            DataTable Data = new DataTable();
            SDA1.Fill(Data);
            metroGrid1.DataSource = Data;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            string id = metroGrid2.SelectedRows[0].Cells[0].Value.ToString();
            ChangeData ChangeDataObj1 = new ChangeData(id);
            ChangeDataObj1.deletePatient();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
            connection.Open();
            SqlDataAdapter SDA1 = new SqlDataAdapter("Select * from [RPDBTable]", connection);
            DataTable Data = new DataTable();
            SDA1.Fill(Data);
            metroGrid2.DataSource = Data;
        }
    }
}






//string Text = "Chal yr";

//MessageBox.Show(id);
//SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");

//connection.Open();

//SqlDataAdapter SDA = new SqlDataAdapter("update [RDBTable] set name='" + name + "',fathersName='" + fathersName + "' ,age='" + age + "' ,address='" + address + "' ,phone='" + phone + "' ,dob='" + dob + "' ,gender='" + gender  + "' ,bloodGroup='" + bloodGroup + "' ,registerAs='" + registerAs + "'  where id='" + id + "'", connection);
////SqlDataAdapter SDA = new SqlDataAdapter("update [DBB1Table] set Name='" + textBox2.Text + "', Age='" + textBox3.Text + "'where Id='" + textBox1.Text + "'", connection);
//SDA.SelectCommand.ExecuteNonQuery();
////connection.Close();
////connection.Open();
//SqlDataAdapter SDA1 = new SqlDataAdapter("Select * from [RDBTable]", connection);