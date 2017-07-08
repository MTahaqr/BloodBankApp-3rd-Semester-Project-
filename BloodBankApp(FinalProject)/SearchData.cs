using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BloodBankApp_FinalProject_
{
    class SearchData :  RegDonorInt ,RegPatInt  
    {
        private string dOrPeti;
        private string searchBy;
        private string searchFor;

        public string _dOrPeti
        {
            set { dOrPeti = value; }
            get { return dOrPeti; }
        }
        public string _searchBy
        {
            set { searchBy = value; }
            get { return searchBy; }
        }
        public string _searchFor
        {
            set { searchFor = value; }
            get { return searchFor; }
        }
      
        public SearchData(string dOrPetiText, string searchByText, string searchForText)
        {
            dOrPeti = dOrPetiText;
            searchBy  = searchByText;
            searchFor  = searchForText;
        }
       
        /// <summary>
        /// //
        /// </summary>
        
        public void RegisterDonor()
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
            //connection.Open();
            //SqlDataAdapter SDA = new SqlDataAdapter("insert into [RDBTable] (name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs) values ('" + name + "','" + fathersName + "','" + age + "','" + address + "','" + phoneNo + "','" + dob + "','" + gender + "','" + bloodGroup + "','" + registerAs + "')", connection);
            //SDA.SelectCommand.ExecuteNonQuery();
            //connection.Close();


        }
        public void RegisterPatient()
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
            //connection.Open();
            //SqlDataAdapter SDA = new SqlDataAdapter("insert into [RPDBTable] (Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisteredAs) values ('" + name + "','" + fathersName + "','" + age + "','" + address + "','" + phoneNo + "','" + dob + "','" + gender + "','" + bloodGroup + "','" + registerAs + "')", connection);
            //SDA.SelectCommand.ExecuteNonQuery();
            //connection.Close();

        }
        SqlConnection conn;
        SqlDataAdapter sda;
        public SqlDataAdapter SearchForDonor()
        {
           
            if (dOrPeti == "Donor")
            {
                 conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
                if (searchBy == "Name")
                {
                    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where name like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);
                    //DataTable loginTable1 = new DataTable();
                    //sda.Fill(loginTable1);
                    //searchObj.metroGrid1.DataSource = loginTable1;
                }
                else if (searchBy == "Father'sName")
                {
                    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where fathersName like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);

                }
                else if (searchBy == "Age")
                {
                    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where age like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);

                }
                else if (searchBy == "Address")
                {
                    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where address like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);

                }
                else if (searchBy == "Phone")
                {
                    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where phone like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);

                }
                else if (searchBy == "DateOfBirth")
                {
                    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where dob like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);

                }
                else if (searchBy == "Gender")
                {
                    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where gender like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);

                }
                else if (searchBy == "BloodGroup")
                {
                    string query = " Select name,fathersName,age,address,phone,dob,gender,bloodGroup,registerAs from [RDBTable] where bloodGroup like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);

                }
            }
            else
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
                if (searchBy == "Name")
                {
                    string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisteredAs from [RPDBTable] where Name like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);
                }


                else if (searchBy == "Father'sName")
                {
                    string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisteredAs from [RPDBTable] where fathersName like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);
                }
                else if (searchBy == "Age")
                {
                    string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisteredAs from [RPDBTable] where age like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);
                }
                else if (searchBy == "Address")
                {
                    string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisteredAs from [RPDBTable] where address like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);
                }
                else if (searchBy == "Phone")
                {
                    string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisteredAs from [RPDBTable] where phone like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);
                }
                else if (searchBy == "DateOfBirth")
                {
                    string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisteredAs from [RPDBTable] where dob like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);
                }
                else if (searchBy == "Gender")
                {
                    string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisteredAs from [RPDBTable] where gender like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);
                }
                else if (searchBy == "BloodGroup")
                {
                    string query = " Select Name,FathersName,Age,Address,Phone,DateOfBirth,Gender,BloodGroup,RegisteredAs from [RPDBTable] where bloodGroup like '" + searchFor + "%'";
                    sda = new SqlDataAdapter(query, conn);
                }
            }
             return sda;
            

        }
       
    }
}
