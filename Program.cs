using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        // ekrana girilen sayıya kadar olan tek sayıları yazdır.
        {
                Console.WriteLine("Lütfen bir sayı giriniz :");
                int sayi = int.Parse(Console.ReadLine());
                for (int i = 0; i <= sayi; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }

            // 1-1000 arasındaki tek ve çift sayıları kendi içinde toplayıp yazdır.

            //int CiftToplam = 0;
            //int TekToplam = 0;

            //for (int i = 0; i <= 1000; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        TekToplam +=i;
            //    }
            //    else

            //        CiftToplam += i;
            //}

            //Console.WriteLine("Çift Toplam :"+CiftToplam);
            //Console.WriteLine("Tek Toplam :" + TekToplam);

            

            //Break ve Continue
            //Console.WriteLine("***Break****");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //        break;
            //    Console.WriteLine(i);


            //}
            //Console.WriteLine("***Continue****");
            //for (int i = 0; i <10; i++)
            //{
            //    if (i == 4)
            //        continue;
            //    Console.WriteLine(i);
            //}

            Console.ReadLine();
        }
    }
}
