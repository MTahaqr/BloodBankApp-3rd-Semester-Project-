using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BloodBankApp_FinalProject_
{
    class SignUpData
    {
        private string name;
        private string email;
        private string password;
        private string signUpAs;

        public string _name
        {
            set { name = value; }
            get { return name; }
        }
        public string _email
        {
            set { email = value; }
            get { return email; }
        }
        public string _password
        {
            set { password = value; }
            get { return password; }
        }
        public string _signUpAs
        {
            set { signUpAs = value; }
            get { return signUpAs; }
        }
        public SignUpData(string nameText,string emailText,string passwordText)
        {
            name = nameText;
            email = emailText;
            password = passwordText;
            signUpAs = "user";
        }
        public void signUp()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\signUpDB.mdf;Integrated Security=True");
            connection.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("insert into [SUDBTable] (Name,Email,Password,SignUpAs) values ('" + name + "','" + email  + "','" + password  + "','" + signUpAs  + "')", connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            
        }
    }
}
