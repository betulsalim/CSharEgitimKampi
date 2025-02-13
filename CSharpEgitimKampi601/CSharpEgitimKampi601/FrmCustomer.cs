using Npgsql;
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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;port=5432;Database=CustomerDB;user Id=postgres;Password=postgres";
        
        void getAllCustomers()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM customers";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            getAllCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerName = txtName.Text;
            string customerSurname = txtSurname.Text;
            string customerCity = txtCity.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO customers (customername, customersurname, customercity) VALUES (@name, @surname, @city)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", txtName.Text);
            command.Parameters.AddWithValue("@surname", txtSurname.Text);
            command.Parameters.AddWithValue("@city", txtCity.Text);
           
            command.ExecuteNonQuery();
            connection.Close();
            getAllCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM customers WHERE customerid = @customerid";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerid", id);
            command.ExecuteNonQuery();
            connection.Close();
            getAllCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string customerName = txtName.Text;
            string customerSurname = txtSurname.Text;
            string customerCity = txtCity.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE customers SET customername = @customername, customersurname = @customersurname, customercity = @customercity WHERE customerid = @customerid";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customername", customerName);
            command.Parameters.AddWithValue("@customersurname", customerSurname);
            command.Parameters.AddWithValue("@customercity", customerCity);
            command.Parameters.AddWithValue("@customerid", id);
            command.ExecuteNonQuery();
            connection.Close();
            getAllCustomers();
        }

        private void GetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM customers WHERE customerid = @customerid";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerid", id);
            var adapter = new NpgsqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
    }
}
