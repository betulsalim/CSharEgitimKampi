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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        FinancialCrmEntities FinancialCrmEntities = new FinancialCrmEntities();
        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = FinancialCrmEntities.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastBankProcessAmount = FinancialCrmEntities.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + " ₺";


            //Chart 1 kodları
            var bankData = FinancialCrmEntities.Banks.Select(x => new
            {
                
                    x.BankTitle,
                    x.BankBalance
                
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Banks");
            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            //Chart 2 kodları
            var billData = FinancialCrmEntities.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Bills");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 5 == 1)
            {
                var electricalBill = FinancialCrmEntities.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                billingTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = electricalBill.ToString() + " ₺";
            }
            if (count % 5 == 2)
            {
                var naturalGasBill = FinancialCrmEntities.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                billingTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = naturalGasBill.ToString() + " ₺";
            }
            if (count % 5 == 3)
            {
                var waterBill = FinancialCrmEntities.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                billingTitle.Text = "Su Faturası";
                lblBillAmount.Text = waterBill.ToString() + " ₺";
            }
            if (count % 5 == 4)
            {
                var internetBill = FinancialCrmEntities.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                billingTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = internetBill.ToString() + " ₺";
            }
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
