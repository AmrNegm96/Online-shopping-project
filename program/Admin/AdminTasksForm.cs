using Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class AdminTasksForm : Form
    {
        public Categories.Categories c;

        public AdminTasksForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminTasksForm_Load(object sender, EventArgs e)
        {

        }

        private void Reg_Label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void add_product_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddCategory addCategoryForm = new AddCategory();
            //this.Hide();
            addCategoryForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateCategory updateCategoryForm = new UpdateCategory();
            //this.Hide();
            updateCategoryForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteCategories deleteCategoryForm = new DeleteCategories();
            //this.Hide();
            deleteCategoryForm.Show();
        }
    }
}
