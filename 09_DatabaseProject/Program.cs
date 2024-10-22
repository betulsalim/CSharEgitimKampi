using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.net

            Console.WriteLine("***** C# Veri Tabanlı Ürün - Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1 - Kategoriler \n2 - Ürünler \n3 - Siparişler \n4 - Çıkış Yap");
            Console.Write("Lütfen Getirmek istediğiniz Tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1O31I5R\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command); // köprü görevi görecek olan sınıf
            DataTable dataTable = new DataTable(); //datatable verileri belleğe almayı sağlar geçici (RAM)
            adapter.Fill(dataTable); //bellekte açılan yeri doldurur 



            connection.Close();
            // var bütün değişkenleri alır.
            //DataRow datatable dan gelen bir sınıf türü
            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(" " + item.ToString());
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
