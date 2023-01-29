using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {

                String URL = "Data Source=DESKTOP-RM9R44Q;Initial Catalog=onlineShopping;Integrated Security=True";
                SqlConnection Conn = new SqlConnection(URL);
                Conn.Open();
                if (Conn.State == System.Data.ConnectionState.Open)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new LoginForm(Conn));
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
            
        }

    }
}
