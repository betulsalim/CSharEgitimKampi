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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancialCrmEntities FinancialCrmEntities = new FinancialCrmEntities();
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; // Kullanıcı adı
            string password = txtPassword.Text; // Parola

            // Kullanıcıyı veritabanında sorgulama
            var user = FinancialCrmEntities.Users.FirstOrDefault(u => u.UserName == username && u.password == password);

            if (user != null)
            {
                // Giriş başarılı, ana sayfaya yönlendirme
                MessageBox.Show("Giriş başarılı!");
                // Ana formu açabiliriz (örneğin, FrmMain):
                FrmDashboard frmDashboard = new FrmDashboard();
                frmDashboard.Show();
                this.Hide(); // Login formunu gizle
            }
            else
            {
                // Kullanıcı adı veya parola hatalı
                MessageBox.Show("Kullanıcı adı veya parola hatalı. Lütfen tekrar deneyin.");
            }
        }
    }
}
