using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankApp_FinalProject_
{
    public partial class signUp : MetroFramework.Forms.MetroForm
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUpData SignUpDataObj = new SignUpData(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text);
            SignUpDataObj.signUp();
            //Register RegisterObj = new Register();
            //this.Hide();
            //RegisterObj.Show();
        }
    }
}
