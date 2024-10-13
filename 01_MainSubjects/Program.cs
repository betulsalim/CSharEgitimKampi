using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects //project name
{
    internal class Program //internal -- > erişim belirleyici
    {
        static void Main(string[] args)
        {

            #region YazdirmaKomutlari

            //Console.Write("Merhaba Dünya!");
            //Console.WriteLine("Selam");
            //Console.Write("Merhaba");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region StringDegiskenler

            //Değişkenler

            //string name;
            //name = "Betül";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "ali.cinar@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Contact: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adress: " + district + " / " + city);
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine();
            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "aysegul.kaya@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Contact: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adress: " + district + " / " + city);
            //Console.WriteLine("---------------------------------------------------");
            #endregion

            #region IntDegiskenler

            // int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Patates Kızartması: " + friesPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();

            int hamburgerCount = 3, cokeCount = 3, waterCount = 3, friesCount = 1, lemonadeCount = 0, pizzaCount = 0;

            int totalPrice = 0, totalHamburgerPrice = 0, totalWaterPrice = 0, totalCokePrice = 0, totalFriesPrice = 0, totalLemonadePrice = 0, totalPizzaPrice = 0;
            totalPrice = hamburgerPrice * hamburgerCount + cokePrice * cokeCount + waterPrice * waterCount + friesPrice * friesCount + lemonadePrice * lemonadeCount + pizzaPrice * pizzaCount;
            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokePrice * cokeCount;
            totalFriesPrice = friesPrice * friesCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalWaterPrice = waterPrice * waterCount;
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("**** Alınan Yİyecekler - Miktarları - Toplam Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Hamburger Adet: " + hamburgerCount + "              Fiyat: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Adet: " + pizzaCount + "                  Fiyat: " + totalPizzaPrice + " TL");
            Console.WriteLine("Patates Kızartması Adet: " + friesCount + "     Fiyat: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Adet: " + cokeCount + "                   Fiyat: " + totalCokePrice+ " TL");
            Console.WriteLine("Limonata Adet: " + lemonadeCount + "               Fiyat: " + totalLemonadePrice+ " TL");
            Console.WriteLine("Su Adet: " + waterCount + "                     Fiyat: " + totalWaterPrice + " TL");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("**** Total ****");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Total: " + totalPrice+ " TL");
            Console.WriteLine("---------------------------------------------------------------");
            #endregion

            Console.Read();
        }
    }
}
