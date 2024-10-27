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
            #region If Else
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital =Console.ReadLine();

            //Console.Write("Şehri Giriniz: ");
            //country = Console.ReadLine();  

            //if (capital=="ankara"& country=="türkiye") 
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");  
            //}

            //int exam1, exam2, exam3, average;


            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);
            //string result="Hata";// ilk atama yapılmadığı takdirde if yapısının dışında kalan bir değer girildiğinde hata verir.
            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //Console.WriteLine(result);



            #endregion
            #region Mod İşlemleri


            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen . Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1. Sayının 2. Sayıya Bölümünden Kalan: " + result);

            #endregion
            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen bir takım sembolü giriniz: ");
            //team=char.Parse(Console.ReadLine());    

            //if(team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //} 
            //if(team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if(team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}



            #endregion
            #region Örnek Proje Uygulaması
            //Console.WriteLine("***** CSharp Eğitim Kampı Restoran*****");
            //Console.WriteLine();
            //Console.WriteLine("-----------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını Görmek istediğiniz menü Seçimi: ");
            //menuItem = Console.ReadLine();  

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("--------Ana Yemekler--------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Fırında Somon");
            //    Console.WriteLine("2-Fasulye Pilav");
            //    Console.WriteLine("3-Gözleme");
            //    Console.WriteLine("--------Ana Yemekler--------");

            //}
            // if (menuItem == "2")
            //{
            //    Console.WriteLine("--------Pizzalar--------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita");
            //    Console.WriteLine("2-Tavuklu Pizza");
            //    Console.WriteLine("3-Karışık Pizza");
            //    Console.WriteLine("--------Pizzalar--------");

            //}
            // if (menuItem == "3")
            //{
            //    Console.WriteLine("--------İçecekler--------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Şalgam");
            //    Console.WriteLine("--------İçecekler--------");

            //}
            // if (menuItem == "4")
            //{
            //    Console.WriteLine("--------Tatlılar--------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3-Künefe");
            //    Console.WriteLine("--------Tatlılar--------");

            //}
            // if (menuItem == "5")
            //{
            //    Console.WriteLine("--------Çorbalar--------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Tavuksuyu");
            //    Console.WriteLine("2-Mercimek");
            //    Console.WriteLine("3-Şehriye");
            //    Console.WriteLine("--------Çorbalar--------");

            //}



            #endregion
            #region Switch Case
            //int number1, number2, result;
            //Console.Write("1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //char symbol;
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //        case '-':
            //        result = number1 + number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //        case '*':
            //        result = number1 + number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //        case '/':
            //        result = number1 + number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //}



            #endregion

   
        }
    }
}
