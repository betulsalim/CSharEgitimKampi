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
using System.Data.Entity.SqlServer;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;

namespace FinancialCrm
{
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }
        FinancialCrmEntities db = new FinancialCrmEntities();
        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            dataGridView1.ForeColor = Color.Black;
            dataGridView2.ForeColor = Color.Black;
            dataGridView3.ForeColor = Color.Black;
            Bills();
            Spendings();
            Incomes();
        }
        private void Bills()
        {
            var bills = db.Bills.ToList();  // Verileri çekiyoruz

            // DataGridView'a veriyi bağlayalım
            dataGridView1.DataSource = bills;

            // Koşullu biçimlendirme
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               
                row.Cells["BillAmount"].Style.ForeColor = System.Drawing.Color.Red;
                

            }
        }
        private void Spendings()
        {
            var spendings = db.Spendings.ToList();  // Verileri çekiyoruz

            // DataGridView'a veriyi bağlayalım
            dataGridView2.DataSource = spendings;

            // Koşullu biçimlendirme
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
              
                row.Cells["SpendingAmount"].Style.ForeColor = System.Drawing.Color.Red;
                

            }
        }
        private void Incomes()
        {
            var incomes = db.BankProcesses
               .Include(x => x.Bank) // Kategori bilgilerini çekiyoruz
               .Select(x => new
               {
                   x.BankProcessId, // ID'yi alabiliriz ama göstermek istemiyorsan çıkarabilirsin
                   x.Description,
                   x.ProcessDate,
                   x.ProcessType,
                   x.Amount,
                   BankName = x.Bank.BankTitle // ID yerine kategori ismi geliyor
               })
               .ToList();

            dataGridView3.DataSource = incomes;

         
            // Koşullu biçimlendirme
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                
                row.Cells["Amount"].Style.ForeColor = System.Drawing.Color.Green;
                

            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

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
