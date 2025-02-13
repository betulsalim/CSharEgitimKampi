using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmAddCategory : Form
    {
        public FrmAddCategory()
        {
            InitializeComponent();
        }
        FinancialCrmEntities db = new FinancialCrmEntities();
        private void FrmAddCategory_Load(object sender, EventArgs e)
        {
            dataGridView1.ForeColor = Color.Black;
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            Category category = new Category();
            category.CategoryName = categoryName;
            db.Categories.Add(category);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla eklendi.", "Kategoriler", MessageBoxButtons.OK,MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }
    }
}
