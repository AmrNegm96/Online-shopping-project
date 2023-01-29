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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace myForm3
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

                string oldName = textBox1.Text.ToString();
                int prd_id = int.Parse(textBox2.Text);

                string newDetails = textBox3.Text.ToString();
                string newName = textBox4.Text.ToString();
                float newPrice = float.Parse(textBox5.Text);
                int newquantities = int.Parse(textBox6.Text);
                string newSize = textBox8.Text.ToString();
                float newDiscount = float.Parse(textBox9.Text);


                //update_cat 1 , 'abc' , 'abc' , 100 , 10 , 'xs' , 10

                string q1 = "update_cat " + prd_id + ",'" + newDetails + "','" + newName + "'," + newPrice + "," + newquantities + ",'" + newSize + "'," + newDiscount ;
                SqlCommand cmd1 = new SqlCommand(q1, this.Conn);

                cmd1.ExecuteNonQuery();

                MessageBox.Show("You updated product "+ oldName + " to "+ newName +" ❤✌");

                //SqlDataReader data = cmd1.ExecuteReader();

                //if (data.Read())
                //{
                //    cat_id = (int)data.GetValue(0);
                //    data.Close();
                //    string q2 = "insert_Product '" + details + "','" + name + "','" + salary + "','" + quantities + "','" + size + "','" + discount + "'," + cat_id;

                //    SqlCommand cmd2 = new SqlCommand(q2, this.Conn);

                //    cmd2.ExecuteNonQuery();

                //    MessageBox.Show("Added new Customer Successfully ❤✌");

                //}




            }
        }
    }
}
