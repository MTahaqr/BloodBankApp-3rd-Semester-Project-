﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BloodBankApp_FinalProject_
{
    class ToDonateData : DonorOrPatient 
    {
        private string dID;
        private string dBloodGroup;
        private string pId;
        private string pBloodGroup;
        private string donated;
        public string _dID
        {
            set { dID = value; }
            get { return dID; }
        }
        public string _dBloodGroup
        {
            set { dBloodGroup = value; }
            get { return dBloodGroup; }
        }
        
        public string _pId
        {
            set { pId = value; }
            get { return pId; }
        }
        public string _pBloodGroup
        {
            set { pBloodGroup = value; }
            get { return pBloodGroup; }
        }
        public string _donated
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
            donated = "Yes";
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
        public override SqlDataAdapter RefreshDonors()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegisterDB.mdf;Integrated Security=True");
            string query = " Select Id,name,fathersName,age,City,phone,DateOfBirth,gender,bloodGroup,registeredAs,Donated from [RDBTable] where Donated like '" + "No" + "%'";
            SqlDataAdapter sda1 = new SqlDataAdapter(query, conn);
            return sda1;
        }

        public override SqlDataAdapter RefreshPatients()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2015\Projects\BloodBankApp(FinalProject)\BloodBankApp(FinalProject)\RegPatDB.mdf;Integrated Security=True");
            string query = " Select Id,Name,FathersName,Age,City,Phone,DateOfBirth,Gender,BloodGroup,RegisteredAs,Donated from [RPDBTable] where Donated like '" + "No" + "%'";
            SqlDataAdapter sda2 = new SqlDataAdapter(query, conn);
            return sda2;
        }

    }
       
    }

