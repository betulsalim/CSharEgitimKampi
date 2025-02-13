using CSharpEgitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        SqlConnection SqlConnection = new SqlConnection("Data Source=DESKTOP-1O31I5R\\SQLEXPRESS;Initial Catalog=EgitimKampi501Db;Integrated Security=True;");
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnList_Click(object sender, EventArgs e)
        {
            
            string query = "Select * From Product";
            var values = await SqlConnection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;
            
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into Product (ProductName,ProductStock,ProductPrice,ProductCategory) values (@productName,@productStock,@productPrice,@productCategory)";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtAd.Text);
            parameters.Add("@productStock", txtStock.Text);
            parameters.Add("@productPrice", txtPrice.Text);
            parameters.Add("@productCategory", txtCategory.Text);
            await SqlConnection.ExecuteAsync(query, parameters);
            MessageBox.Show("Eklendi");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete from Product where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", txtId.Text);
            await SqlConnection.ExecuteAsync(query, parameters);
            MessageBox.Show("Silindi");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Product Set ProductName=@productName,ProductStock=@productStock,ProductPrice=@productPrice,ProductCategory=@productCategory where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtAd.Text);
            parameters.Add("@productStock", txtStock.Text);
            parameters.Add("@productPrice", txtPrice.Text);
            parameters.Add("@productCategory", txtCategory.Text);
            parameters.Add("@productId", txtId.Text );
            await SqlConnection.ExecuteAsync(query, parameters);
            MessageBox.Show("Güncellendi");
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string queryCount = "Select Count(*) from Product";
            var count = await SqlConnection.QueryFirstOrDefaultAsync<int>(queryCount);
            lblToplam.Text = count.ToString();

            string queryPrice = "SELECT ProductName FROM Product WHERE ProductPrice = (SELECT MAX(ProductPrice) FROM Product)";
            var price = await SqlConnection.QueryFirstOrDefaultAsync<string>(queryPrice);
            lblKitap.Text = price.ToString();

            string queryCategory = "SELECT COUNT(DISTINCT ProductCategory) AS CategoryCount FROM Product";
            var categoryCount = await SqlConnection.QueryFirstOrDefaultAsync<int>(queryCategory);
            lblKategori.Text = categoryCount.ToString();
        }
    }
}
