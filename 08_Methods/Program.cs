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
            //()
            // Geriye Değer döndürmeyen metotlar
            //Customer--> Listele, ekle, sil, güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali YIldız");
            //    Console.WriteLine("Ayşe YIldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");

            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
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

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void Customer(string name, string surName)

            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //Customer("Salih", "Dilmen");
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar
            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //}

            //Sum(1, 2, 3);

            #endregion

            #region Geriye Değer Döndüren Metotlar
            //string CustomerName()

            //{
            //    return "Buse Yıldız";
            //}

            //string StudentCard() 
            //{
            //    string name = "Salih";
            //    string surName = "Dilmen";
            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCard());



            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.WriteLine("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();
            //Console.WriteLine("Başkenti Giriniz: ");
            //y = Console.ReadLine();
            //Console.WriteLine("Bayrak Rengi Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));



            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar
            //int Sum (int number1, int number2) 
            //{
            //    int result =number1+number2;    
            //    return result;
            //}

            //Console.WriteLine(Sum(90, 48));
            //Console.WriteLine(Sum(65,55 ));
            //Console.WriteLine(Sum(102, 96));
            //Console.WriteLine(Sum(75, 135));

            #endregion



            Console.Read();
        }
    }
}
