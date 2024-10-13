using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü

            //int i;

            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Sayı: " + i);
            //}

            //for (int i = 0; i < 20; i++) 
            //{ 
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //int startNumber, endNumber;
            //Console.Write("Başlangıç Sayısını girin: ");
            //startNumber = int.Parse(Console.ReadLine());
            //Console.Write("Bitiş Sayısını girin: ");
            //endNumber = int.Parse(Console.ReadLine());

            //if (startNumber < endNumber)
            //{
            //    for (int i = startNumber; i <= endNumber; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    for (int i = startNumber; i >= endNumber; i--)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region ForDöngüsüİleKararYapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("\nTotal Value: " + totalValue);

            //int totalValue = 0;

            //for (int i = 0; i <= 20; i+=2)
            //{
            //    totalValue += i;
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("\nTotal Value: " + totalValue);

            //int totalIndex = 0;

            //for (int i = 0; i <= 50; i+= 7)
            //{
            //    totalIndex++;
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("\nTotal İndex: " + totalIndex);

            //int totalIndex = 0;

            //for (int i = 0; i<=50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        totalIndex++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("\nTotal İndex: " + totalIndex);

            #endregion

            #region BakteriOrnegi

            //int bacterium = 1;

            //for (int i = 1; i<= 24; i++)
            //{
            //    bacterium*=2;
            //    Console.WriteLine(i + " . Saat sonunda: " + bacterium + " bakteri.");
            //}

            #endregion

            #region while döngüsü

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1, totalValue = 0;

            //while (i <= 10)
            //{
            //    totalValue += i;
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine("\nTotal Value: " + totalValue);

            #endregion

            #region Örnek Sınav Sorusu

            //int number1, number2, number3, value = 0 , number;

            //Console.Write("Sayınızı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //number1 = number / 100;
            //number2 = (number / 10) / 10;
            //number3 = (number / 10) % 10;


            

            //for (int i = 0; i<= number1; i++)
            //{
            //    for (int j = 0; j<= number2; j++)
            //    {
            //        for(int k = 0; k<= number3; k++)
            //        {
            //            if (i == number1)
            //            {
            //                if(j == number2)
            //                {
            //                    if(k == number3)
            //                    {
            //                        value = i + j + k;
            //                        Console.WriteLine(value);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
