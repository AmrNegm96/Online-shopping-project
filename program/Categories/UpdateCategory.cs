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
    public partial class UpdateCategory : Form
    {
        public UpdateCategory()
        {
            InitializeComponent();
        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {

        }

        private void FName_Click(object sender, EventArgs e)
        {

        }

        private void fN_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Categories c1 = new Categories();
            c1.UpdageCategories(ctg_old.Text.ToString() , ctg_new.Text.ToString());
        }
    }
}
