using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BloodBankApp_FinalProject_
{
    class RegisterData :LoginData , RegDonorInt 
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
        }
        
        
        public void RegisterDonor()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
            connection.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("insert into [RDBTable] (name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs) values ('" + name + "','" + fathersName + "','" + age + "','" + address  + "','" + phoneNo  + "','" + dob + "','" + gender + "','" + bloodGroup + "','" + registerAs  + "')", connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            

        }
       
    }
    
}
