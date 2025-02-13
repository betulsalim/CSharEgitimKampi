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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinancialCrmEntities db = new FinancialCrmEntities();
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            var currentUser = db.Users.FirstOrDefault(); // İlk kullanıcıyı almak için
            if (currentUser != null)
            {
                txtUsername.Text = currentUser.UserName;
                txtPassword.Text = currentUser.password;
            }
        }

        private void btnUsernameChange_Click(object sender, EventArgs e)
        {
            var currentUser = db.Users.FirstOrDefault(); // İlk kullanıcıyı almak için
            if (currentUser != null)
            {
                currentUser.UserName = txtUsername.Text; // Yeni kullanıcı adını alıyoruz
                db.SaveChanges(); // Değişiklikleri kaydediyoruz
                MessageBox.Show("Kullanıcı adı başarıyla değiştirildi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
            }
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            var currentUser = db.Users.FirstOrDefault(); // İlk kullanıcıyı almak için
            if (currentUser != null)
            {
                currentUser.password = txtPassword.Text; // Yeni parolayı alıyoruz
                db.SaveChanges(); // Değişiklikleri kaydediyoruz
                MessageBox.Show("Parola başarıyla değiştirildi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories
                = new FrmCategories();
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

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmBankProcess frmBankProcess = new FrmBankProcess();
            frmBankProcess.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
