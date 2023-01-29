using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cart
{
    public class Cart
    {
        private SqlConnection Conn;
        public void Connect()
        {
            try
            {

                String URL = "Data Source=DESKTOP-RM9R44Q;Initial Catalog=onlineShopping;Integrated Security=True";
                this.Conn = new SqlConnection(URL);
                this.Conn.Open();
                if (this.Conn.State != System.Data.ConnectionState.Open)
                {
                    throw new Exception();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public void AddCategories(string ctg_name)
        {
            // use db to add new category
            try
            {
                this.Connect();
                if (this.Conn.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into Category (name) values ( '" + ctg_name + "')";
                    SqlCommand cmd = new SqlCommand(q, this.Conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {

                        MessageBox.Show("Added New Category Successfully ❤✌");
                    }
                    else
                    {
                        throw new Exception("No Category with this name");
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            this.Conn.Close();

        }
    }
}
