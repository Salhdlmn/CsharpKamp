using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            //1:Değişken türü
            //2:Değişken Adı
            //3:In
            //4: Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities) 
            //{
            //Console.WriteLine(x);
            //}

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulanası");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("-------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------");

            //// Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentName = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentName[i] = Console.ReadLine();
            //    double totalExamResult = 0;
            //    for (int j = 0; j < 3; j++)

            //    {
            //        Console.Write($"{studentName[i]} Öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;
            //    }

            //    studentExamAvg[i] = totalExamResult / 3;
            //}

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması {studentExamAvg[i]}");
            //}


            #endregion

            Console.Read();
        }
    }
}
