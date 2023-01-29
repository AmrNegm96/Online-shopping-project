using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class LoginForm : Form
    {
        public SqlConnection Conn;
        public string adminName ;
        public string adminPass;


        public LoginForm(SqlConnection Conn)
        {
            this.Conn = Conn;
            InitializeComponent();
        }

        private void Reg_Label_Click(object sender, EventArgs e)
        {

        }

        private void FName_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.Conn.State == System.Data.ConnectionState.Open)
            {

                //string q = "insert into Customer (Fname, Lname,Password , Phone , Email) values ( '" + fN_text.Text.ToString()  + "','" +  lN_Text.Text.ToString() + "','" + PassText.Text.ToString() + "','" + Phone_Text.Text.ToString() + "','" + email_Text.Text.ToString() + "')" ;
                string q = "select Email,Password from Admin";
                SqlCommand cmd = new SqlCommand(q, this.Conn);
                SqlDataReader data  = cmd.ExecuteReader();

                if (data.Read()) {

                    this.adminName = (string) data.GetValue(0);
                    this.adminPass = (string) data.GetValue(1);
                    if (email_text.Text.ToString() == this.adminName && PassText.Text.ToString() == this.adminPass)
                    {
                        this.Hide();
                        var AdminRule = new AdminTasksForm();
                        AdminRule.Show();
                    }
                    else
                    {
                        MessageBox.Show("User not found");
                    }

                    data.Close();
                }
                else
                {
                    MessageBox.Show("booo");
                }


             }




        }

           
           
        
    }
}
