using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BloodBankApp_FinalProject_
{
    class RegisterData : DonorOrPatient 
    {
        private string name;
        private string fathersName;
        private string age;
        private string address;
        private string phoneNo;
        private string dob;
        private string gender;
        private string bloodGroup;
        private string registerAs;
        private string donated;
        private string query;
        
        
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
        public string _registerAs
        {
            set { registerAs = value; }
            get { return registerAs; }
        }
        public string _donated
        {
            set { donated = value; }
            get { return donated; }
        }

            public RegisterData()
        {

        }
        public RegisterData(string nameTxt, string fathersNameTxt, string ageTxt, string addressTxt, string phoneNoTxt, string dobTxt, string genderTxt, string bloodGroupTxt, string registerAsTxt)
        {
            name = nameTxt;
            fathersName = fathersNameTxt;
            age = ageTxt;
            address = addressTxt;
            phoneNo = phoneNoTxt;
            dob = dobTxt;
            gender = genderTxt;
            bloodGroup = bloodGroupTxt;
            registerAs = registerAsTxt;
            donated = "No";
        }
        
        
        public override void RegisterDonors()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
            connection.Open();
            if(bloodGroup == "AB+")
            {
                query = "insert into [RDBTable] (name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated,ABp) values ('" + name + "','" + fathersName + "','" + age + "','" + address + "','" + phoneNo + "','" + dob + "','" + gender + "','" + bloodGroup + "','" + registerAs + "','" + donated + "','" + "Yes" + "')";

            }
            else if(bloodGroup == "AB-")
            {
                query = "insert into [RDBTable] (name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated,ABp,ABn) values ('" + name + "','" + fathersName + "','" + age + "','" + address + "','" + phoneNo + "','" + dob + "','" + gender + "','" + bloodGroup + "','" + registerAs + "','" + donated + "','" + "Yes" + "','" + "Yes" + "')";

            }
            else if (bloodGroup == "A+")
            {
                query = "insert into [RDBTable] (name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated,ABp,Ap) values ('" + name + "','" + fathersName + "','" + age + "','" + address + "','" + phoneNo + "','" + dob + "','" + gender + "','" + bloodGroup + "','" + registerAs + "','" + donated + "','" + "Yes" + "','" + "Yes" + "')";

            }
            else if (bloodGroup == "A-")
            {
                query = "insert into [RDBTable] (name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated,ABp,ABn,Ap,An) values ('" + name + "','" + fathersName + "','" + age + "','" + address + "','" + phoneNo + "','" + dob + "','" + gender + "','" + bloodGroup + "','" + registerAs + "','" + donated + "','" + "Yes" + "','" + "Yes" + "','" + "Yes" + "','" + "Yes" + "')";

            }
            else if (bloodGroup == "B+")
            {
                query = "insert into [RDBTable] (name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated,ABp,Bp) values ('" + name + "','" + fathersName + "','" + age + "','" + address + "','" + phoneNo + "','" + dob + "','" + gender + "','" + bloodGroup + "','" + registerAs + "','" + donated + "','" + "Yes" + "','" + "Yes" + "')";

            }
            else if (bloodGroup == "B-")
            {
                query = "insert into [RDBTable] (name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated,ABp,ABn,Bp,Bn) values ('" + name + "','" + fathersName + "','" + age + "','" + address + "','" + phoneNo + "','" + dob + "','" + gender + "','" + bloodGroup + "','" + registerAs + "','" + donated + "','" + "Yes" + "','" + "Yes" + "','" + "Yes" + "','" + "Yes" + "')";

            }
            else if (bloodGroup == "O+")
            {
                query = "insert into [RDBTable] (name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated,ABp,Ap,Bp,Op) values ('" + name + "','" + fathersName + "','" + age + "','" + address + "','" + phoneNo + "','" + dob + "','" + gender + "','" + bloodGroup + "','" + registerAs + "','" + donated + "','" + "Yes" + "','" + "Yes" + "','" + "Yes" + "','" + "Yes" + "')";

            }
            else if (bloodGroup == "O-")
            {
                query = "insert into [RDBTable] (name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated,ABp,ABn,Ap,An,Bp,Bn,Op,Onn) values ('" + name + "','" + fathersName + "','" + age + "','" + address + "','" + phoneNo + "','" + dob + "','" + gender + "','" + bloodGroup + "','" + registerAs + "','" + donated + "','" + "Yes" + "','" + "Yes" + "','" + "Yes" + "','" + "Yes" + "','" + "Yes" + "','" + "Yes" + "','" + "Yes" + "','" + "Yes" + "')";

            }
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            

        }

        public override void RegisterPatients()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
            connection.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("insert into [RPDBTable] (Name,FathersName,Age,City,Phone,DateOfBirth,Gender,BloodGroup,RegisteredAs,Donated) values ('" + name + "','" + fathersName + "','" + age + "','" + address + "','" + phoneNo + "','" + dob + "','" + gender + "','" + bloodGroup + "','" + registerAs + "','" + donated + "')", connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();

        }
        public SqlDataAdapter RefreshPatients()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
            connection.Open();
            SqlDataAdapter SDAP = new SqlDataAdapter("Select * from [RPDBTable]", connection);
            return SDAP;
        }

        public SqlDataAdapter RefreshDonors()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
            connection.Open();
            SqlDataAdapter SDAD = new SqlDataAdapter("Select * from [RDBTable]", connection);
            return SDAD;
        }

    }
    
}
