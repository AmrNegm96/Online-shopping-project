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

namespace myform2
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

                string prd_Name = textBox1.Text.ToString();
                int prd_id = int.Parse(textBox2.Text);

                string q1 = "delete_product " + prd_id;

                SqlCommand cmd1 = new SqlCommand(q1, this.Conn);

                cmd1.ExecuteNonQuery();

                //SqlDataReader data = cmd1.ExecuteReader();

                //if (data.Read())
                //{
                //cat_id = (int)data.GetValue(0);
                //data.Close();
                //string q2 = "insert_Product '" + details + "','" + name + "','" + salary + "','" + quantities + "','" + size + "','" + discount + "'," + cat_id;

                //SqlCommand cmd2 = new SqlCommand(q2, this.Conn);

                //cmd2.ExecuteNonQuery();

                MessageBox.Show("You deleted " + prd_Name + " Successfully ❤✌");

            }
        }
    }
}




