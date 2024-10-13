using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //string password;

            //Console.Write("Lütfen şifreyi giriniz: ");
            //password = Console.ReadLine();

            //if (password == "abcd") 
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;

            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if ((capital == "ankara" || capital == "Ankara") & country == "türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi");
            //}

            //int number;

            //Console.Write("Sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //Console.WriteLine(number);

            //if(number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            #region elif

            //double exam1, exam2, exam3, ortalama;

            //Console.WriteLine("İlk Sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("İkinci Sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Üçüncü Sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //ortalama = (exam1 + exam2 + exam3) / 3;

            //if (95 <= ortalama & ortalama <= 100)
            //{
            //    Console.WriteLine("A1 en yüksek Geçer not");
            //}
            //else if (90 <= ortalama & ortalama <= 94)
            //{
            //    Console.WriteLine("A2 geçer not");
            //}
            //else if (85 <= ortalama & ortalama <= 89)
            //{
            //    Console.WriteLine("A3 geçer not");
            //}
            //else if (80 <= ortalama & ortalama <= 84)
            //{
            //    Console.WriteLine("B1 geçer not");
            //}
            //else if (75 <= ortalama & ortalama <= 79)
            //{
            //    Console.WriteLine("B2 geçer not");
            //}
            //else if (70 <= ortalama & ortalama <= 74)
            //{
            //    Console.WriteLine("B3 geçer not");
            //}
            //else if (65 <= ortalama & ortalama <= 69)
            //{
            //    Console.WriteLine("C1 geçer not");
            //}
            //else if (60 <= ortalama & ortalama <= 64)
            //{
            //    Console.WriteLine("C2 geçer not");
            //}
            //else if (55 <= ortalama & ortalama <= 59)
            //{
            //    Console.WriteLine("D1 KOŞULLU GEÇER NOT.");
            //}
            //else if (50 <= ortalama & ortalama <= 54)
            //{
            //    Console.WriteLine("D2 KOŞULLU GEÇER NOT.");
            //}
            //else if (0 <= ortalama & ortalama <= 49)
            //{
            //    Console.WriteLine("F1 BAŞARISIZ.");
            //}
            //else
            //{
            //    Console.WriteLine("DEVAMSIZ");
            //}

            //if (team == 'g' | team == 'G')
            //{
            //    findTeam = "Galatasaray";
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    findTeam = "fenerbahçe";
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    findTeam = "Beşiktaş";
            //}
            //else
            //{
            //    findTeam = "Geçersiz";
            //}

            //Console.WriteLine(findTeam);



            #endregion

            //string city;

            //city = Console.ReadLine();

            //if (city == "ankara" | city == "istanbul")
            //{
            //    Console.WriteLine("doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış");
            //}

            #endregion

            #region mod

            //int number;

            //number = 26;

            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen 1.sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //int result = number % number1;

            //Console.WriteLine(result);

            //char team;
            //string findTeam;
            //Console.WriteLine("Takım Temsil harfini giriniz: ");
            //team = char.Parse(Console.ReadLine());


            #endregion

            #region ornek

            //int choice, soupChoice, startChoice, mealChoice, dessertChoice, saladChoice, drinkChoice;
            //string result = "", soupResult = "", startResult = "", mealResult = "", dessertResult = "", saladResult = "", drinkResult = "";
            //bool toContinue = true;
            //char isToContinue;

            //Console.WriteLine("****** C# EĞİTİM KAMPI RESTORAN MENÜSÜ ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("1- Çorbalar \n2- Başlangıçlar \n3- Ana Yemekler \n4-Tatlılar \n5-Salatalar \n6-İçecekler");
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine();

            //Console.WriteLine("Ne Sipariş Vermek istersiniz? ");
            //choice = int.Parse(Console.ReadLine());

            //while (toContinue)
            //{
            //    if (choice == 1)
            //    {
            //        Console.WriteLine("****** ÇORBALAR ******");
            //        Console.WriteLine("1- Domates Çorbası \n2- Mercimek Çorbası \n3- Yoğurt Çorbası");
            //        Console.WriteLine("Hangi Çorbayı Sipariş Vermek İstersiniz? ");
            //        soupChoice = int.Parse(Console.ReadLine());

            //        if (soupChoice == 1)
            //        {
            //            soupResult = "Domates Çorbası";
            //        }
            //        else if (soupChoice == 2)
            //        {
            //            soupResult = "Mercimek Çorbası";
            //        }
            //        else if (soupChoice == 3)
            //        {
            //            soupResult = "Yoğurt Çorbası";
            //        }
            //        else
            //        {
            //            soupResult = "Hatalı";
            //        }
            //    }
            //    else if (choice == 2)
            //    {
            //        Console.WriteLine("****** Başlangıçlar ******");
            //        Console.WriteLine("1- Sigara Böreği \n2- Paçanga \n3- Patates Kızartması");
            //        Console.WriteLine("Başlangıç olarak ne Sipariş Vermek İstersiniz? ");
            //        startChoice = int.Parse(Console.ReadLine());

            //        if (startChoice == 1)
            //        {
            //            startResult = "Sigara Böreği";
            //        }
            //        else if (startChoice == 2)
            //        {
            //            startResult = "Paçanga";
            //        }
            //        else if (startChoice == 3)
            //        {
            //            startResult = "Patates Kızartması";
            //        }
            //        else
            //        {
            //            startResult = "Hatalı";
            //        }
            //    }
            //    else if (choice == 3)
            //    {
            //        Console.WriteLine("****** Ana Yemekler ******");
            //        Console.WriteLine("1- İmam Bayıldı \n2- Köfteli - Pilav \n3- Makarna");
            //        Console.WriteLine("Ana Yemek Olarak ne isterdiniz? ");
            //        mealChoice = int.Parse(Console.ReadLine());

            //        if (mealChoice == 1)
            //        {
            //            mealResult = "İmam Bayıldı";
            //        }
            //        else if (mealChoice == 2)
            //        {
            //            mealResult = "Köfteli - Pilav";
            //        }
            //        else if (mealChoice == 3)
            //        {
            //            mealResult = "Makarna";
            //        }
            //        else
            //        {
            //            mealResult = "Hatalı";
            //        }
            //    }
            //    else if (choice == 4)
            //    {
            //        Console.WriteLine("****** Tatlılar ******");
            //        Console.WriteLine("1- Sütlaç \n2- Künefe \n3- Profeterol");
            //        Console.WriteLine("Tatlı ne isterdiniz? ");
            //        dessertChoice = int.Parse(Console.ReadLine());

            //        if (dessertChoice == 1)
            //        {
            //            dessertResult = "Sütlaç";
            //        }
            //        else if (dessertChoice == 2)
            //        {
            //            dessertResult = "Künefe";
            //        }
            //        else if (dessertChoice == 3)
            //        {
            //            dessertResult = "Profeterol";
            //        }
            //        else
            //        {
            //            dessertResult = "Hatalı";
            //        }
            //    }
            //    else if (choice == 5)
            //    {
            //        Console.WriteLine("****** Salatalar ******");
            //        Console.WriteLine("1- Ton Balıklı Salata \n2- Avokadolu Salata \n3- Meyve Salatası");
            //        Console.WriteLine("Salata ne isterdiniz? ");
            //        saladChoice = int.Parse(Console.ReadLine());

            //        if (saladChoice == 1)
            //        {
            //            saladResult = "Ton Balıklı Salata";
            //        }
            //        else if (saladChoice == 2)
            //        {
            //            saladResult = "Avokadolu Salata";
            //        }
            //        else if (saladChoice == 3)
            //        {
            //            saladResult = "Meyve Salatası";
            //        }
            //        else
            //        {
            //            saladResult = "Hatalı";
            //        }
            //    }
            //    else if (choice == 6)
            //    {
            //        Console.WriteLine("****** İçecekler ******");
            //        Console.WriteLine("1- Su \n2- Kola \n3- Fanta");
            //        Console.WriteLine("Ana Yemek Olarak ne isterdiniz? ");
            //        drinkChoice = int.Parse(Console.ReadLine());

            //        if (drinkChoice == 1)
            //        {
            //            drinkResult = "Su";
            //        }
            //        else if (drinkChoice == 2)
            //        {
            //            drinkResult = "Kola";
            //        }
            //        else if (drinkChoice == 3)
            //        {
            //            drinkResult = "Fanta";
            //        }
            //        else
            //        {
            //            drinkResult = "Hatalı";
            //        }
            //    }
            //    // Continue for other choices similarly...

            //    Console.Write("daha fazla sipariş vermek ister misiniz? (y/n): ");
            //    isToContinue = char.Parse(Console.ReadLine());

            //    if (isToContinue == 'y' || isToContinue == 'Y')
            //    {
            //        Console.WriteLine("****** C# EĞİTİM KAMPI RESTORAN MENÜSÜ ******");
            //        Console.WriteLine();
            //        Console.WriteLine("------------------------------------------------");
            //        Console.WriteLine("1- Çorbalar \n2- Başlangıçlar \n3- Ana Yemekler \n4-Tatlılar \n5-Salatalar \n6-İçecekler");
            //        Console.WriteLine("------------------------------------------------");
            //        Console.WriteLine();

            //        Console.WriteLine("Ne Şipariş Vermek istersiniz? ");
            //        choice = int.Parse(Console.ReadLine());
            //    }
            //    else
            //    {
            //        toContinue = false;
            //    }
            //}

            //result = "Çorba: " + soupResult + "\nBaşlangıçlar: " + startResult + "\nAna Yemekler: " + mealResult +"\nTatlıar: " + dessertResult + "\nSalatlar: " + saladResult + "\nİçecekler: " +drinkResult ;
            //Console.WriteLine(result);




            #endregion

            #region switch-case

            //Console.WriteLine("Lütfen Ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı veri girişi.");
            //        break;
            //}

            #endregion

            #region switch-case-hesapMakinesi

            double number1, number2, result;
            string isToContinue, process;
            bool isContinue = true;
            Console.WriteLine("****** HESAP MAKİNESİ ******");

            while (isContinue)
            {
                Console.WriteLine();
                Console.WriteLine("İşlem yapmak istediğiniz iki sayıyı giriniz!!!");

                Console.Write("1.sayı: ");
                number1 = double.Parse(Console.ReadLine());

                Console.Write("2.sayı: ");
                number2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Hangi İşlemi Yapmak İstiyorsunuz? ");
                Console.WriteLine("1 - '+' \n2 - '-' \n3 - '*' \n4 - '/' ");
                process = Console.ReadLine();

                Console.WriteLine();
                switch (process)
                {
                    case "+":
                        result = number1 + number2;
                        Console.WriteLine("Sonuç: " + result);
                        break;
                    case "-":
                        result = number1 - number2;
                        Console.WriteLine("Sonuç: " + result);
                        break;
                    case "*":
                        result = number1 * number2;
                        Console.WriteLine("Sonuç: " + result);
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                            Console.WriteLine("Sonuç: " + result);
                        }
                        else
                        {
                            Console.WriteLine("Bölme işlemi için 2. sayı 0 olamaz!");
                        }
                        break;
                    default:
                        Console.WriteLine("Geçersiz işlem!");
                        break;
                }

                Console.Write("Hesap yapmaya devam etmek ister misiniz? (y/n): ");
                isToContinue = Console.ReadLine();

                if (isToContinue == "y" || isToContinue == "Y")
                {
                    isContinue = true;  // Continue the loop
                }
                else if (isToContinue == "n" || isToContinue == "N")
                {
                    isContinue = false;  // Break the loop and exit
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş! Program sonlandırılıyor.");
                    isContinue = false;  // Invalid input, exit the loop
                }
            }
            Console.WriteLine("Programdan çıkılıyor...");
            #endregion


            Console.Read();
        }
    }
}