using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //DeğişkenTürü [] DiziAdı = new DegiskenTürü[elemanSayısı]

            //string [] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[0]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] evenNumbers = new int[10];

            //evenNumbers[0] = 50;
            //evenNumbers[1] = 48;
            //evenNumbers[2] = 698;
            //evenNumbers[3] = 24;
            //evenNumbers[7] = 748;

            //Console.WriteLine(evenNumbers[7]);

            //string[] cities = { "prag", "roma", "atina", "ankara", "bursa" };
            //Console.WriteLine(cities[2]);




            #endregion

            #region dizideki tüm elemanları listeleme
            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine("Renk " +i + ": "+ colors[i]);
            //}

            //int[] numbers = new int[] { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int max = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{


            //   if (myArray[i] > max)
            //    {
            //        max = myArray[i];
            //    }

            //}
            //Console.WriteLine(max);

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region dizi metodları

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı: " +  numbers.Max() + "\nDizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region kullanıcıdan değer alma

            // string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            // {
            //     Console.Write($"Lütfen {i + 1}. Şehri giriniz: ");
            //     cities[i] = Console.ReadLine();
            // }
            // Console.WriteLine();
            // Console.WriteLine("---------------------------------------------");

            //for (int i = 0;i < cities.Length;i++)
            // {
            //     Console.WriteLine(cities[i]);
            // }

            //int[] numbers = { 10, 20, 30, 40, 50, };
            //int result = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    result += numbers[i];
            //}

            //Console.WriteLine(result);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //       Console.WriteLine(numbers[i]); 
            //    }

            //}
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}


            #endregion

            Console.Read();
        }
    }
}
