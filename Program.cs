using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazırMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp";
            string degisken2 = "Dersimiz CSharp Hoşgeldiniz";
            //Length
            Console.WriteLine(degisken.Length); // Veri Sayısı

            /*ToUpper
            ToLower*/

            Console.WriteLine(degisken.ToLower()); //Tüm Harfleri Küçültür.
            Console.WriteLine(degisken.ToUpper()); //Tüm Harfleri Büyütür.

            //Concat

            Console.WriteLine(String.Concat(degisken, " Merhaba", " Nasılsın"));

            /*CompareTo 
            degisken1 ==degisken2 ise Sonuc=0
            degisken1 > degisken2 ise Sonuc = 1
            degisken1 < degisken2 ise Sonuc = -1*/

            Console.WriteLine(degisken.CompareTo(degisken2));

            /*Compare*/
            Console.WriteLine(String.Compare(degisken, degisken2, true));// True Küçük büyük Duyarsız
            Console.WriteLine(String.Compare(degisken, degisken2, false));// FAlse Büyük Küçük Duyarlı

            //Contains

            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz")); //Hoşgeldiniz ile bitiyor mu)
            Console.WriteLine(degisken.EndsWith("Merhaba"));// Merhaba İle Başlıyor mu


            // IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Mehmet"));
            Console.WriteLine(degisken.LastIndexOf("i")); //Son İndexi Getirir

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba"));

            //PadLeft, PadRight

            Console.WriteLine(degisken + degisken2.PadLeft(30)); // 30. Karaktere kadar boşluk ekledi
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2); 50.Karaktere Kadar Tİre Ekledi.
            // Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(10,3));// 10. İndexten itibaren 3 tane değişken sil.

            //Replace

            Console.WriteLine(degisken.Replace("CSharp","C#")); // degisken verisindeki CSharp yazısını C# ileDeğiştir

            // Split

            Console.WriteLine(degisken.Split(' ',[1]));// degisken isimli diziyi boşluklara  göre parçalara ayır ve bana 1. indexteki değişkeni getir
            //SubString
            Console.WriteLine(degisken.Substring(4));// 4. İndeksten başlayıp sonuna kadar yazıdırır.
            Console.WriteLine(degisken.Substring(4,6)); //4 indeksten başlayıp 6 tane harfi getirir.

            Console.ReadKey();
        }
    }
}
