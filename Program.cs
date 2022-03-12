using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Atama ve İşlemli Atama
            Console.WriteLine("*****AtamaVeIşlemliAtama*****");

            int x = 24;
            int y = 32;
            int z = x + y;
            Console.WriteLine(z);

            x += 3;
            Console.WriteLine(x);
            x -= 3;
            Console.WriteLine(x);
            x /= 3;
            Console.WriteLine(x);
            x *= 3;
            Console.WriteLine(x);


            //2. Mantıksal Operatorler
            // || (veya/ ya da),
            // && (ve)
            // ! (Değilse)

            Console.WriteLine("******Mantıksal Operatorler*******");

            bool IsSuccess = true;
            bool IsCompleted = true;
            bool IsError = false;

            if (IsSuccess || IsCompleted)
                Console.WriteLine("Fine!");

            if (IsSuccess && IsCompleted)
                Console.WriteLine("Perfect!!");

            if (IsSuccess && !IsError)
                Console.WriteLine("Great!!!");


            //3. Ilıskısel Operatorler
            // <,>,<=,>=,==,!=(eşit değildir)
            Console.WriteLine("******IlıskıselOperatorler*******");

            int a = 4;
            int b = 5;

            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            // Aritmetik Operatorler
            Console.WriteLine("******IlıskıselOperatorler*******");
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine("Bolme Sonucu =" + sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine("Carpma Sonucu =" + sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine("Toplama Sonucu =" + sonuc1);
            sonuc1 = sayi1 - sayi2;
            Console.WriteLine("Cıkarma Sonucu =" + sonuc1);
            int sonuc2 = sayi1++;
            Console.WriteLine("Birer Arttır =" + sonuc2);
            int sonuc3 = sayi1--;
            Console.WriteLine("Birer Azalt =" + sonuc3);

            // % mod alır
            int sonuc4 = 30 % 7;
            Console.WriteLine("Mod =" + sonuc4);
            Console.ReadLine();


        }
    }
}
