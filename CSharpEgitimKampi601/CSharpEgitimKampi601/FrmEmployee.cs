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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        string connectionString = "Server_localhost;port=5432;database=CustomerDB;user Id=postgres;password=postgres";
        void EmployeeList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Departments";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            EmployeeList();
            departmentList();
        }
        void departmentList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Departments";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentID";

            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EmployeeList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string employeeName = txtName.Text;
            string employeeSurname = txtSurname.Text;
            decimal employeeSalary = decimal.Parse(txtSalary.Text);
            int departmentID = int.Parse(cmbDepartment.SelectedValue.ToString());

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Insert Into Employees (EmployeeName, EmployeeSurname, EmployeeSalary, DepartmentID) Values (@p1, @p2, @p3, @p4)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", employeeName);
            command.Parameters.AddWithValue("@p2", employeeSurname);
            command.Parameters.AddWithValue("@p3", employeeSalary);
            command.Parameters.AddWithValue("@p4", departmentID);
            command.ExecuteNonQuery();
            connection.Close();
            EmployeeList();

        }
    }
}
