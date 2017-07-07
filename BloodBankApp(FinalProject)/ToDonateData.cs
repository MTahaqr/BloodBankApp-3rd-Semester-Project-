using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BloodBankApp_FinalProject_
{
    class ToDonateData
    {
        private string dID;
        private string dBloodGroup;
        private string pId;
        private string pBloodGroup;
        private string donated;
        public String _dID
        {
            set { dID = value; }
            get { return dID; }
        }
        public String _dBloodGroup
        {
            set { dBloodGroup = value; }
            get { return dBloodGroup; }
        }
        
        public String _pId
        {
            set { pId = value; }
            get { return pId; }
        }
        public String _pBloodGroup
        {
            set { pBloodGroup = value; }
            get { return pBloodGroup; }
        }
        public String _donated
        {
            set { donated = value; }
            get { return donated; }
        }
        public ToDonateData()
        {
            
        }
        public ToDonateData(string dIDText, string dBloodGroupText, string pIdText, string pBloodGroupText)
        {
            dID = dIDText;
            dBloodGroup = dBloodGroupText;
            pId = pIdText;
            pBloodGroup = pBloodGroupText;
            donated = "Yesss";
        }
        public bool ToDonateBlood()
        {
            if (pBloodGroup == "AB+")
            {
                if (dBloodGroup == "O-" || dBloodGroup == "O+" || dBloodGroup == "B-" || dBloodGroup == "B+" || dBloodGroup == "A-" || dBloodGroup == "A+" || dBloodGroup == "AB+" || dBloodGroup == "AB-")
                {
                    SqlConnection connectionD = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
                    connectionD.Open();
                    SqlDataAdapter SDAD = new SqlDataAdapter("update [RDBTable] set Donated='" + donated + "'  where id='" + dID + "'", connectionD);
                    SDAD.SelectCommand.ExecuteNonQuery();
                    connectionD.Close();

                    SqlConnection connectionP = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
                    connectionP.Open();
                    SqlDataAdapter SDAP = new SqlDataAdapter("update [RPDBTable] set Donated='" + donated + "'  where id='" + pId + "'", connectionP);
                    SDAP.SelectCommand.ExecuteNonQuery();
                    connectionD.Close();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else if (pBloodGroup == "AB-")
            {
                if (dBloodGroup == "O-" || dBloodGroup == "B-" || dBloodGroup == "A-" || dBloodGroup == "AB-")
                {
                    SqlConnection connectionD = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
                    connectionD.Open();
                    SqlDataAdapter SDAD = new SqlDataAdapter("update [RDBTable] set Donated='" + donated + "'  where id='" + dID + "'", connectionD);
                    SDAD.SelectCommand.ExecuteNonQuery();
                    connectionD.Close();

                    SqlConnection connectionP = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
                    connectionP.Open();
                    SqlDataAdapter SDAP = new SqlDataAdapter("update [RPDBTable] set Donated='" + donated + "'  where id='" + pId + "'", connectionP);
                    SDAP.SelectCommand.ExecuteNonQuery();
                    connectionD.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (pBloodGroup == "A+")
            {
                if (dBloodGroup == "O-" || dBloodGroup == "O+" || dBloodGroup == "A-" || dBloodGroup == "AB-")
                {
                    SqlConnection connectionD = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
                    connectionD.Open();
                    SqlDataAdapter SDAD = new SqlDataAdapter("update [RDBTable] set Donated='" + donated + "'  where id='" + dID + "'", connectionD);
                    SDAD.SelectCommand.ExecuteNonQuery();
                    connectionD.Close();

                    SqlConnection connectionP = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
                    connectionP.Open();
                    SqlDataAdapter SDAP = new SqlDataAdapter("update [RPDBTable] set Donated='" + donated + "'  where id='" + pId + "'", connectionP);
                    SDAP.SelectCommand.ExecuteNonQuery();
                    connectionD.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (pBloodGroup == "A-")
            {
                if (dBloodGroup == "O-" || dBloodGroup == "A-")
                {
                    SqlConnection connectionD = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
                    connectionD.Open();
                    SqlDataAdapter SDAD = new SqlDataAdapter("update [RDBTable] set Donated='" + donated + "'  where id='" + dID + "'", connectionD);
                    SDAD.SelectCommand.ExecuteNonQuery();
                    connectionD.Close();

                    SqlConnection connectionP = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
                    connectionP.Open();
                    SqlDataAdapter SDAP = new SqlDataAdapter("update [RPDBTable] set Donated='" + donated + "'  where id='" + pId + "'", connectionP);
                    SDAP.SelectCommand.ExecuteNonQuery();
                    connectionD.Close();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else if (pBloodGroup == "B+")
            {
                if (dBloodGroup == "O-" || dBloodGroup == "O+" || dBloodGroup == "B-" || dBloodGroup == "B+")
                {
                    SqlConnection connectionD = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
                    connectionD.Open();
                    SqlDataAdapter SDAD = new SqlDataAdapter("update [RDBTable] set Donated='" + donated + "'  where id='" + dID + "'", connectionD);
                    SDAD.SelectCommand.ExecuteNonQuery();
                    connectionD.Close();

                    SqlConnection connectionP = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
                    connectionP.Open();
                    SqlDataAdapter SDAP = new SqlDataAdapter("update [RPDBTable] set Donated='" + donated + "'  where id='" + pId + "'", connectionP);
                    SDAP.SelectCommand.ExecuteNonQuery();
                    connectionD.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }



            else if (pBloodGroup == "B-")
            {
                if (dBloodGroup == "O-" || dBloodGroup == "B-")
                {
                    SqlConnection connectionD = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
                    connectionD.Open();
                    SqlDataAdapter SDAD = new SqlDataAdapter("update [RDBTable] set Donated='" + donated + "'  where id='" + dID + "'", connectionD);
                    SDAD.SelectCommand.ExecuteNonQuery();
                    connectionD.Close();

                    SqlConnection connectionP = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
                    connectionP.Open();
                    SqlDataAdapter SDAP = new SqlDataAdapter("update [RPDBTable] set Donated='" + donated + "'  where id='" + pId + "'", connectionP);
                    SDAP.SelectCommand.ExecuteNonQuery();
                    connectionD.Close();
                    return true;
                }
                else
                {
                    return false;
                }

            }
                if (pBloodGroup == "O+")
                {
                    if (dBloodGroup == "O-" || dBloodGroup == "O+")
                    {
                        SqlConnection connectionD = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
                        connectionD.Open();
                        SqlDataAdapter SDAD = new SqlDataAdapter("update [RDBTable] set Donated='" + donated + "'  where id='" + dID + "'", connectionD);
                        SDAD.SelectCommand.ExecuteNonQuery();
                        connectionD.Close();

                        SqlConnection connectionP = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
                        connectionP.Open();
                        SqlDataAdapter SDAP = new SqlDataAdapter("update [RPDBTable] set Donated='" + donated + "'  where id='" + pId + "'", connectionP);
                        SDAP.SelectCommand.ExecuteNonQuery();
                        connectionD.Close();
                    return true;
                }
                else
                {
                    return false;
                }

            }
                if (pBloodGroup == "O-")
                {
                    if (dBloodGroup == "O-")
                    {
                        SqlConnection connectionD = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
                        connectionD.Open();
                        SqlDataAdapter SDAD = new SqlDataAdapter("update [RDBTable] set Donated='" + donated + "'  where id='" + dID + "'", connectionD);
                        SDAD.SelectCommand.ExecuteNonQuery();
                        connectionD.Close();

                        SqlConnection connectionP = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
                        connectionP.Open();
                        SqlDataAdapter SDAP = new SqlDataAdapter("update [RPDBTable] set Donated='" + donated + "'  where id='" + pId + "'", connectionP);
                        SDAP.SelectCommand.ExecuteNonQuery();
                        connectionD.Close();
                    return true;
                }
                else
                {
                    return false;
                }

            }
                else
            {
                return false;
            }
            }

        }
       
    }

