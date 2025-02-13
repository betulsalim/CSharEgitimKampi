using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerOperations customerOperations = new CustomerOperations();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtName.Text,
                CustomerSurname = txtSurname.Text,
                CustomerCity = txtCity.Text,
                CustomerBalance = decimal.Parse(txtMoney.Text),
                CustomerShoppingCount = int.Parse(txtPrice.Text)
            };
            customerOperations.AddCustomer(customer);
            MessageBox.Show("Eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerOperations.GetAllCustomer();
            dataGridView1.DataSource = customers;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            var updateCustomer = new Customer()
            {
                CustomerName = txtName.Text,
                CustomerSurname = txtSurname.Text,
                CustomerCity = txtCity.Text,
                CustomerBalance = decimal.Parse(txtMoney.Text),
                CustomerShoppingCount = int.Parse(txtPrice.Text),
                CustomerId = id
            };
            customerOperations.UpdateCustomer(updateCustomer);
            MessageBox.Show("Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string customerId = txtId.Text;
            customerOperations.DeleteCustomer(customerId);
            MessageBox.Show("Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GetById_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            Customer customers = customerOperations.GetCustomerById(id);
            dataGridView1.DataSource = new List<Customer> { customers };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
