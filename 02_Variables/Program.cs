using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDegiskenler

            //double number;
            //double applePrice = 14.85, orangePrice = 20.95, strawberryPrice = 45, potatoPrice = 9.74, tomatoprice = 6.88;
            //double appleGram = 1.245, orangeGram = 2.650, strawberryGram = 0.750, potatoGram = 4.859, tomatoGram = 3.745;
            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice, totalPrice;
            //appleTotalPrice = appleGram * applePrice;
            //orangeTotalPrice = orangeGram * orangePrice;
            //strawberryTotalPrice = strawberryPrice * strawberryGram;
            //potatoTotalPrice = potatoGram * potatoPrice;
            //tomatoTotalPrice = tomatoGram * tomatoprice;
            //totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("***** Birim Fiyat Listesi *****");
            //Console.WriteLine("-----------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fİyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoprice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------------------");
            //Console.WriteLine("***** Gramaj Listesi *****");
            //Console.WriteLine("-----------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Elma Gramaj: " + appleGram);
            //Console.WriteLine("Portakal Gramaj: " + orangeGram);
            //Console.WriteLine("Çilek Gramaj: " + strawberryGram);
            //Console.WriteLine("Patates Gramaj: " + potatoGram);
            //Console.WriteLine("Domates Gramaj: " + tomatoGram);
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine("-----------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Elmanın Toplam Fiyatı: " + appleTotalPrice + " TL");
            //Console.WriteLine("Portakalın Toplam Fiyatı: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Çileğin Toplam Fiyatı: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Patatesin Toplam Fiyatı: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Domatesin Toplam Fiyatı: " + tomatoTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Total: " + totalPrice + " TL");


            #endregion

            #region CharDegiskenler

            //char symbol;

            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region KlavyedenStringVeriGirisleri

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bigisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("İl Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("***** Yolcu Bilgi Kartı *****");
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Yolcu: " +  passengerName + " " + passengerSurname);
            //Console.WriteLine("İlçe / İl Bilgileri: " + passengerDistrict + " / " + passengerCity);
            //Console.WriteLine("Yolcu Yaşı: " + passengerAge);
            //Console.WriteLine("Yolcu TC: " + passengerIdentityNumber);
            //Console.WriteLine("--------------------------------------------------");

            #endregion

            #region KlavyedenIntVeriGirisleriVeDonusumler

            //int shoePrice = 1000, computerPrice = 20000, chairPrice = 5000, tvPrice = 12000 , totalPrice;
            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Adedini Giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine()); // dönüştürme metodu (32 bit formatı)

            //Console.Write("Lütfen Aldığınız Bilgisayar Adedini Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Adedini Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Adedini Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //totalPrice = (shoeCount * shoePrice) + (computerCount * computerPrice) + (chairCount * chairPrice) + (tvPrice * tvCount);
            //Console.WriteLine();
            //Console.WriteLine("Total: " + totalPrice);

            #endregion

            #region KlavyedenDoubleVeriGirisleri

            //double exam1, exam2, exam3, result;
            //Console.Write("1.Sınav Notu: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2.Sınav Notu: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3.Sınav Notu: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region KlavyedenCharVeriGirisleri

            //char gender;
            //Console.Write("Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion
            
            Console.Read();
        }
    }
}
