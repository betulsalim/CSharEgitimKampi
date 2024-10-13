using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan Yana 10 tane yıldız

            //for (int i = 0; i <= 10;  i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region alt alta 10 tane yıldız oluştururken yan yana da 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}


            #endregion

            #region 5 satırlı bir dik üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 5 satırlı ters dik üçgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = i; j >= 1; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region düz dik üçgen ve ters dik üçgen birleştirme 5 satırlı

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = i; j >= 1; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region baklava Dilimi

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n ; j > i ; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n ; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region sola yatık dik üçgen oluşturma

            //int n = 5;

            //for (int i = 0; i <= n ; i++)
            //{
            //    for (int j = i; j <= n; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k <= i; k++)
            //    {
            //        Console.Write("*");
            //        Console.Write("");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region piramit

            //int number;

            //Console.Write("Piramit için sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j = number; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2*i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region tersPiramit

            int n = 5;

            for (int i = n; i > 0; i--)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();
        }
    }
}
