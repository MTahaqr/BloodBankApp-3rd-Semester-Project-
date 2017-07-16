using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BloodBankApp_FinalProject_
{
    class LoginData
    {
        public static string loginAs;
        public static string email;
        private string password;
        //public string _loginAs
        //{
        //    set { loginAs = value; }
        //    get { return loginAs; }
        //}
        //public string _email
        //{
        //    set { email = value; }
        //    get { return email; }
        //}
        public string _password
        {
            set { password = value; }
            get { return password; }
        }
        public LoginData()
        {
            
        }
        public LoginData(string emailText,string passwordText ,string loginAsText)
        {
            email = emailText;
            password = passwordText;
            loginAs = loginAsText;

        }
        
        public static bool checkLoginAs()
        {
            if(loginAs == "Admin")
            {
                return true;
            }
            else
            {
                return false;
                
            }
        }
        SqlConnection conn;
        SqlDataAdapter sda;
        public SqlDataAdapter logIn()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\signUpDB.mdf;Integrated Security=True");
            //string query = " Select count(*) from SUDBTable Where Email = '" + _email + "' and Password = '" + password + "'";
            string query = " Select count(*) from SUDBTable Where SignUpAs='"+loginAs +"' and Email = '" + email + "' and Password = '" + password + "'";

            sda = new SqlDataAdapter(query, conn);
            return sda;
        }
       


    }
}
