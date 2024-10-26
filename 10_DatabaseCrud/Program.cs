using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Creat-->Read-->Update-->Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");

            #region Kategori Ekleme
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            ////Database e veri eklemek istiyoruz ama bunu C# üzerinden yapmak istiyoruz.
            ////Data Source : bağlantı adresini
            ////initial catalog : database adını

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1O31I5R\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            ////TblCategory tablosuna category name sütununa değerleri ekle (@p1 = parametre 1)
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            ////ekleme işlemini burdan aldık
            //command.Parameters.AddWithValue("@p1", categoryName);
            ////koşulsuz bir şekilde sorguyu çalıştır.
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");

            #endregion

            #region for döngüsü ile ürün adı ekleme (Kendim yaptım)

            //Console.Write("Eklemek istediğiniz ürün sayısını giriniz: ");
            //int stockCount = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1O31I5R\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //for (int i = 0; i< stockCount; i++)
            //{
            //    Console.Write("Eklemek istediğiniz Ürün Adı: ");
            //    string productName = Console.ReadLine();
            //    SqlCommand command = new SqlCommand("insert into TblProduct (ProductName) values (@p1)",connection);
            //    command.Parameters.AddWithValue("@p1", productName);
            //    command.ExecuteNonQuery();
            //}
            //connection.Close();
            //Console.WriteLine("Ürünler Başarılı bir şekilde eklendi");
            #endregion

            #region Ürün Ekleme // for döngüsü ile kaç tane eklemek istiyorsak ekleyelim //

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Kaç tane ürün bilgisi eklemek istiyorsunuz? ");
            //int stockCount = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1O31I5R\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //for (int i = 0; i < stockCount; i++)
            //{

            //    Console.Write("Eklemek istediğiniz ürün adı: ");
            //    productName = Console.ReadLine();

            //    Console.Write("Ürün Fiyatı: ");
            //    productPrice = decimal.Parse(Console.ReadLine());


            //    SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //    command.Parameters.AddWithValue("@productName", productName);
            //    command.Parameters.AddWithValue("@productPrice", productPrice);
            //    command.Parameters.AddWithValue("@productStatus", true);
            //    command.ExecuteNonQuery();
            //}
            //connection.Close();

            //Console.WriteLine("Ürün eklemesi başarılı");
            #endregion

            #region ürün listeleme işlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1O31I5R\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(" " + item.ToString()); 
            //    }
            //    Console.WriteLine();

            //}

            //connection.Close();
            #endregion

            #region ürün silme işlemi
            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1O31I5R\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı");

            #endregion

            #region ürün güncelleme işlemi
            Console.Write("Güncellenecek ürün id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek ürün adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek ürün fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1O31I5R\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice Where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Güncelleme Başarılı");



            #endregion

            Console.ReadLine();
        }
    }
}
