using FinancialCrm.Models;
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
using System.Data.Entity;

namespace FinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        FinancialCrmEntities db = new FinancialCrmEntities();
       

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBank frmBank = new FrmBank();
            frmBank.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            dataGridView1.ForeColor = Color.Black;

            var spendings = db.Spendings
                .Include(s => s.Category) // Kategori bilgilerini çekiyoruz
                .Select(s => new
                {
                    s.SpendingId, // ID'yi alabiliriz ama göstermek istemiyorsan çıkarabilirsin
                    s.SpendingTitle,
                    s.SpendingAmount,
                    s.SpendingDate,
                    CategoryName = s.Category.CategoryName // ID yerine kategori ismi geliyor
                })
                .ToList();

            dataGridView1.DataSource = spendings;
        }

        private void btnSpendingList_Click(object sender, EventArgs e)
        {
            var spendings = db.Spendings
               .Include(s => s.Category) // Kategori bilgilerini çekiyoruz
               .Select(s => new
               {
                   s.SpendingId, // ID'yi alabiliriz ama göstermek istemiyorsan çıkarabilirsin
                   s.SpendingTitle,
                   s.SpendingAmount,
                   s.SpendingDate,
                   CategoryName = s.Category.CategoryName // ID yerine kategori ismi geliyor
               })
               .ToList();

            dataGridView1.DataSource = spendings;
        }

        private void btnAddSpending_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            string period = txtPeriod.Text;
            int categoryId = int.Parse(txtCategoryId.Text);

            Spending spending = new Spending();
            spending.SpendingTitle = title;
            spending.CategoryId = categoryId;
            spending.SpendingAmount = amount;
            spending.SpendingDate = DateTime.Now;
            db.Spendings.Add(spending);
            db.SaveChanges();
            MessageBox.Show("Yeni Harcama Eklendi", "Kategoriler & Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var spendings = db.Spendings
               .Include(s => s.Category) // Kategori bilgilerini çekiyoruz
               .Select(s => new
               {
                   s.SpendingId, // ID'yi alabiliriz ama göstermek istemiyorsan çıkarabilirsin
                   s.SpendingTitle,
                   s.SpendingAmount,
                   s.SpendingDate,
                   CategoryName = s.Category.CategoryName // ID yerine kategori ismi geliyor
               })
               .ToList();

            dataGridView1.DataSource = spendings;
        }

        private void btnDeleteSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var spending = db.Spendings.Find(id);
            db.Spendings.Remove(spending);
            db.SaveChanges();
            MessageBox.Show("Harcama Silindi", "Kategoriler & Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var spendings = db.Spendings
               .Include(s => s.Category) // Kategori bilgilerini çekiyoruz
               .Select(s => new
               {
                   s.SpendingId, // ID'yi alabiliriz ama göstermek istemiyorsan çıkarabilirsin
                   s.SpendingTitle,
                   s.SpendingAmount,
                   s.SpendingDate,
                   CategoryName = s.Category.CategoryName // ID yerine kategori ismi geliyor
               })
               .ToList();

            dataGridView1.DataSource = spendings;
        }

        private void btnUpgradeSpending_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            string period = txtPeriod.Text;
            int id = int.Parse(txtId.Text);
            int categoryId = int.Parse(txtCategoryId.Text);

            var upgrade = db.Spendings.Find(id);


            upgrade.SpendingTitle = title;
            upgrade.SpendingAmount = amount;
            upgrade.CategoryId = categoryId;
            upgrade.SpendingDate = DateTime.Now;

            db.SaveChanges();
            MessageBox.Show("Harcama Güncellendi", "Kategoriler & Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var spendings = db.Spendings
               .Include(s => s.Category) // Kategori bilgilerini çekiyoruz
               .Select(s => new
               {
                   s.SpendingId, // ID'yi alabiliriz ama göstermek istemiyorsan çıkarabilirsin
                   s.SpendingTitle,
                   s.SpendingAmount,
                   s.SpendingDate,
                   CategoryName = s.Category.CategoryName // ID yerine kategori ismi geliyor
               })
               .ToList();

            dataGridView1.DataSource = spendings;
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddCategory frmAddCategory = new FrmAddCategory();
                frmAddCategory.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmBankProcess frmBankProcess = new FrmBankProcess();
            frmBankProcess.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
