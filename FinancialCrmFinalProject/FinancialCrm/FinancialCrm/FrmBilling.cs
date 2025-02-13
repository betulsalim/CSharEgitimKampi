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
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmEntities db = new FinancialCrmEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            dataGridView1.ForeColor = Color.Black;
            var value = db.Bills.ToList();
            dataGridView1.DataSource = value;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var value = db.Bills.ToList();
            dataGridView1.DataSource = value;
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            string period = txtPeriod.Text;

            Bill bill = new Bill();
            bill.BillTitle = title;
            bill.BillAmount = amount;
            bill.BillPeriod = period;
            db.Bills.Add(bill);
            db.SaveChanges();
            MessageBox.Show("Fatura Eklendi","Ödemeler & Faturalar", MessageBoxButtons.OK,MessageBoxIcon.Information);

            var value = db.Bills.ToList();
            dataGridView1.DataSource = value;
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var bill = db.Bills.Find(id);
            db.Bills.Remove(bill);
            db.SaveChanges();
            MessageBox.Show("Fatura Silindi", "Ödemeler & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var value = db.Bills.ToList();
            dataGridView1.DataSource = value;
        }

        private void btnUpgradeBill_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            string period = txtPeriod.Text;
            int id = int.Parse(txtId.Text);

            var upgrade = db.Bills.Find(id);

            
            upgrade.BillTitle = title;
            upgrade.BillAmount = amount;
            upgrade.BillPeriod = period;
           
            db.SaveChanges();
            MessageBox.Show("Fatura Güncellendi", "Ödemeler & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var value = db.Bills.ToList();
            dataGridView1.DataSource = value;
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBank frmBank = new FrmBank();
            frmBank.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
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
