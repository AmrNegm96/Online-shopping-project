using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categories
{
    public partial class DeleteCategories : Form
    {
        public DeleteCategories()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Categories c1 = new Categories();
            c1.DeleteCategorie(ctg_name.Text.ToString());
        }
    }
}
