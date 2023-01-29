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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myform
{
    public partial class Form1 : Form
    {
        private SqlConnection Conn;
        public Form1(SqlConnection Conn)
        {
            this.Conn = Conn;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.Conn.State == System.Data.ConnectionState.Open)
            {
                
                //string q = "insert into Customer (Fname, Lname,Password , Phone , Email) values ( '" + fN_text.Text.ToString()  + "','" +  lN_Text.Text.ToString() + "','" + PassText.Text.ToString() + "','" + Phone_Text.Text.ToString() + "','" + email_Text.Text.ToString() + "')" ;
                //string q = "update_cat 2,'pan'";
                //update_cat 2,'pants'


                string details = textBox1.Text.ToString();
                string name = textBox2.Text.ToString();
                float salary = float.Parse(textBox3.Text);
                int quantities = int.Parse(textBox4.Text);
                string size = textBox5.Text.ToString();
                float discount = float.Parse(textBox6.Text);
                string Cat_name = textBox7.Text.ToString();


                int cat_id;

                string q1 = "select c.ctg_id from Category c where c.name= '"+Cat_name + "'";

                SqlCommand cmd1 = new SqlCommand(q1, this.Conn);

                //cmd1.ExecuteNonQuery();

                SqlDataReader data = cmd1.ExecuteReader();

                if (data.Read())
                {
                     cat_id = (int)data.GetValue(0);
                    data.Close();
                    string q2 = "insert_Product '" + details + "','" + name + "','" + salary + "','" + quantities + "','" + size + "','" + discount + "'," + cat_id;

                    SqlCommand cmd2 = new SqlCommand(q2, this.Conn);

                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Added new Customer Successfully ❤✌");

                }

                

                
            }
        }
    }
}
