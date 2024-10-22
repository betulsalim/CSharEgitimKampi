using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //geriye değer döndürmeyen metotlar Void

            //void CustomerList ()
            //{
            //    Console.WriteLine("Ali yıldız");
            //    Console.WriteLine("Ayşe yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string customerName, string customerSurname)
            //{
            //    Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region geriye değer döndürmeyen int parametreli metotlar

            //void Sum (int num1, int num2,int num3)
            //{
            //    int result = num1 + num2 + num3;
            //   Console.WriteLine(result);
            //}
            //Sum(10, 4, 7);

            #endregion

            #region geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());



            #endregion

            #region geriye değer döndüren metotlar String parametreli metotlar

            //string CountryCard (string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " Başkent: " + capital + " Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine("----------------------------------");

            #endregion

            #region geriye değer döndüren metotlar int parametreli metotlar

            //int Sum (int num1,int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));




            #endregion

            #region Exam Result Ornek

            string ExamResult(string studentName, string studentSurname,int exam1,int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;

                if (result >= 50)
                {
                    return studentName + " " + studentSurname + " Sınavı geçti. Ortalama: " + result ;
                }
                else
                {
                    return studentName + " " + studentSurname + " Sınavı geçemedi. Ortalama: " + result;
                }
            }
            Console.WriteLine(ExamResult("Ali", "Yıldız", 25, 41, 85));
            Console.WriteLine(ExamResult("Ayşe", "Yılmaz", 36, 88, 33));
            Console.WriteLine(ExamResult("Veli", "Bozkurt", 25, 41, 75));


            #endregion


            Console.Read();
        }
    }
}
