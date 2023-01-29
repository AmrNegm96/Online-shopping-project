using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Categories
{
    public class Categories
    {
        public int cat_id;
        public string cat_name;

        public Categories()
        {

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private SqlConnection Conn;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AddCategory());
            
        }

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

        public void AddCategories(string ctg_name)
        {
            // use db to add new category
            try{
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

        // update Categories
        public void UpdageCategories(string old_ctg_name , string new_ctg_name)
        {
            // use db to add new category
            try
            {
                this.Connect();
                if (this.Conn.State == System.Data.ConnectionState.Open)
                {

                    string q = "update Category set name = '" + new_ctg_name + "' where name= '" + old_ctg_name + "'";
                    SqlCommand cmd = new SqlCommand(q, this.Conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Updated Category " + old_ctg_name + " to Category " + new_ctg_name + " Successfully ❤✌");
                    }
                    else
                    {
                        throw new Exception("No Category with this name");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            this.Conn.Close();

        }

        // Delete Category 
        public void DeleteCategorie(string ctg_name)
        {
            // use db to add new category
            try
            {
                this.Connect();
                if (this.Conn.State == System.Data.ConnectionState.Open)
                {

                    string q = "Delete from Category where name = '" + ctg_name + "'";
                    SqlCommand cmd = new SqlCommand(q, this.Conn);
                    int result = cmd.ExecuteNonQuery();
                    if(result == 1)
                    {
                        MessageBox.Show("Deleted " + ctg_name + " Category Successfully ❤✌");
                    }
                    else
                    {
                        throw new Exception("No Category with this name");
                    }

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
