using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace BloodBankApp_FinalProject_
{
    class ChangeData 
    {
        private string id;
        private string name;
        private string fathersName;
        private string age;
        private string address;
        private string phoneNo;
        private string dob;
        private string gender;
        private string bloodGroup;

        public string _id
        {
            set { id = value; }
            get { return id; }
        }
        public string _name
        {
            set { name = value; }
            get { return name; }
        }
        public string _fathersName
        {
            set { fathersName = value; }
            get { return fathersName; }
        }
        public string _age
        {
            set { age = value; }
            get { return age; }
        }
        public string _address
        {
            set { address = value; }
            get { return address; }
        }
        public string _phoneNo
        {
            set { phoneNo = value; }
            get { return phoneNo; }
        }
        public string _dob
        {
            set { dob = value; }
            get { return dob; }
        }
        public string _gender
        {
            set { gender = value; }
            get { return gender; }
        }
        public string _bloodGroup
        {
            set { bloodGroup = value; }
            get { return bloodGroup; }
        }
       
        public ChangeData()
        {

        }
        public ChangeData(string idTxt,string nameTxt, string fathersNameTxt, string ageTxt, string addressTxt, string phoneNoTxt, string dobTxt, string genderTxt, string bloodGroupTxt)
        {
            id = idTxt;
            name = nameTxt;
            fathersName = fathersNameTxt;
            age = ageTxt;
            address = addressTxt;
            phoneNo = phoneNoTxt;
            dob = dobTxt;
            gender = genderTxt;
            bloodGroup = bloodGroupTxt;
            
        }
        public ChangeData(string idText)
        {
            id = idText;
        }
        SqlConnection connection;
        SqlDataAdapter SDA1;
        public SqlDataAdapter showsDonors()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
            connection.Open();
            SDA1 = new SqlDataAdapter("Select * from [RDBTable]", connection);
            //SDA1.SelectCommand.ExecuteNonQuery();

            return SDA1;
           
        }
        public SqlDataAdapter updateDonors()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
            connection.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("update [RDBTable] set name='" + name + "',fathersName='" + fathersName + "' ,age='" + age + "' ,City='" + address + "' ,phone='" + phoneNo + "' ,DateOfBirth='" + dob + "' ,gender='" + gender + "' ,bloodGroup='" + bloodGroup + "'  where id='" + id + "'", connection);
            //SqlDataAdapter SDA = new SqlDataAdapter("update [DBB1Table] set Name='" + textBox2.Text + "', Age='" + textBox3.Text + "'where Id='" + textBox1.Text + "'", connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            //SqlConnection connection2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");

            connection.Open();
            SqlDataAdapter SDA1 = new SqlDataAdapter("Select * from [RDBTable]", connection);
            return SDA1;
        }
        //public SqlDataAdapter DonorsListRefresh()
        //{
        //    SqlConnection connection2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");

        //    connection2.Open();
        //    SqlDataAdapter SDA1 = new SqlDataAdapter("Select * from [RDBTable]", connection);
        //    return SDA1;

        //}
        public SqlDataAdapter updatePatients()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf; Integrated Security = True");
            connection.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("update [RPDBTable] set name='" + name + "',fathersName='" + fathersName + "' ,age='" + age + "' ,City='" + address + "' ,phone='" + phoneNo + "' ,DateOfBirth='" + dob + "' ,gender='" + gender + "' ,bloodGroup='" + bloodGroup + "'  where id='" + id + "'", connection);
            //SqlDataAdapter SDA = new SqlDataAdapter("update [DBB1Table] set Name='" + textBox2.Text + "', Age='" + textBox3.Text + "'where Id='" + textBox1.Text + "'", connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            //SqlConnection connection2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");

            connection.Open();
            SqlDataAdapter SDA1 = new SqlDataAdapter("Select * from [RPDBTable]", connection);
            return SDA1;
        }
        public void deleteDonor()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
            connection.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("Delete from [RDBTable] where id='" + id  + "'", connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
        }
        public void deletePatient()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf; Integrated Security = True");
            connection.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("Delete from [RPDBTable] where id='" + id + "'", connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
