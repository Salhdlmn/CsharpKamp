using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler
            // For(x;y;z)
            // x: Başlangıç
            // y: Bitiş
            // x: artış-azalış

            //int i;
            //for(i=1; i<=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}
            //for(int i =3; i<=50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Lütfen Ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları
            //for (int i = 0; i <= 100; i++) 
            //{ if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue = 0;
            //for (int i = 0; i <= 10; i++) 
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 0; i <= 20; i++)
            //{
            //    if(i%2 == 0) 
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);

            //    }
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine(totalValue);


            //int count = 0;
            //for(int i = 1; i<=50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //        count++;
            //    }
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine(count);   


            #endregion

            #region While Döngüsü
            //While(Şart)
            //{
            //    işlemler
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //Console.WriteLine("Üç Basamaklı Sayı Giriniz: ");
            //int sayi =int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;
            //ones = sayi % 10;
            //hundreds=sayi/100;
            //tens = (sayi/10) % 10;
            //Console.WriteLine(ones+"-"+tens+"-"+hundreds);
            //sum=ones+tens+hundreds;
            //Console.WriteLine(sum);
            #endregion

            Console.Read();
        }
    }
}
