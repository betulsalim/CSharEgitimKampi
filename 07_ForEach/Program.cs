using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForEach

            //Foreach(1;2;3;4)

            //1: Değişken Türü
            //2: Değişken Adı
            //3: In
            //4: Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int sum = 0;

            //foreach (int i in numbers)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}





            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //int numberOfStudents,ExamGrade,sumGrade = 0,averageGrade;
            //string studentName;

            //List<string> students = new List<string>();
            //List<int> average = new List<int>();

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Sınıfınızda Kaç Öğrenci var?");
            //numberOfStudents = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= numberOfStudents; i++)
            //{
            //    Console.WriteLine($"{i}.Öğrencinin Adı: ");
            //    studentName = Console.ReadLine();
            //    students.Add(studentName);


            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.WriteLine($"{j}.Sınav notunu giriniz: ");
            //        ExamGrade = int.Parse(Console.ReadLine());
            //        sumGrade += ExamGrade;
            //    }
            //    averageGrade = sumGrade / 3;
            //    average.Add(averageGrade);
            //    sumGrade = 0;


            //        Console.WriteLine($"{i}. Öğrencimizin ortalaması: {averageGrade}");

            //}

            int numberOfStudents, ExamGrade;
            double sumGrade = 0, averageGrade;
            string studentName;
            


            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Sınıfınızda Kaç Öğrenci var?");
            numberOfStudents = int.Parse(Console.ReadLine());

            string[] studentNames = new string[numberOfStudents];
            double[] studentExamAvg = new double[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz:  ");
                studentNames[i] = Console.ReadLine();


                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav sonucunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    sumGrade += value;
                }

                averageGrade = sumGrade / 3;
                studentExamAvg[i] = averageGrade;
                sumGrade = 0;

            }

            for (int i = 0;i < numberOfStudents;i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                if (studentExamAvg[i] < 50)
                {
                    double difference = 50 - studentExamAvg[i];
                    Console.WriteLine($"{studentNames[i]} öğrencimiz sınavdan {studentExamAvg[i]} notuyla kalmıştır. Geçmesi için {difference} kadar puana ihtiyacı vardır.");
                }
                else if (50 <= studentExamAvg[i] && studentExamAvg[i] < 70)
                {
                    double difference = 70 - studentExamAvg[i];
                    Console.WriteLine($"{studentNames[i]} öğrencimiz sınavdan {studentExamAvg[i]} notuyla geçmiştir. Teşekkür Belgesi için {difference} kadar puana ihtiyacı vardır.");
                }
                else if (70 <= studentExamAvg[i] && studentExamAvg[i] < 85)
                {
                    double difference = 85 - studentExamAvg[i];
                    Console.WriteLine($"{studentNames[i]} öğrencimiz sınavdan {studentExamAvg[i]} notuyla Geçmiştir. Takdir Belgesi için {difference} kadar puana ihtiyacı vardır.");
                }
                else if (85 <= studentExamAvg[i] && studentExamAvg[i] <= 100)
                {
                    
                    Console.WriteLine($"{studentNames[i]} öğrencimiz sınavdan {studentExamAvg[i]} notuyla Geçmiştir. Takdir Belgesi Kazanmıştır");
                }
                

            }



            #endregion



            Console.Read();
        }
    }
}
