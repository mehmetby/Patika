using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikaOdev
{
    class Program
    {




        /* Ödev 1
         * Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
         */
        static void Main(string[] args)
        {
            int sayi1;


            Console.WriteLine("Bir adet pozitif sayı giriniz.");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            int[] dizi1 = new int[sayi1];

            Console.WriteLine("{0} adet pozitif sayı girmeniz gerekmektedir.", sayi1);
            for (int i = 0; i < sayi1; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                dizi1[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Girmiş olduğunuz sayılar arasındaki çift sayılar: ");
            foreach (int cift in dizi1)
            {
                if (cift % 2 == 0)
                    Console.Write("{0,3} ", cift);


            }
            Console.ReadKey();
        }





        /* 2.Ödev
           Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        */

        static void Main()
        {
            int n, m;

            Console.WriteLine("2 adet pozitif sayı girmeniz gerekmektedir");
            Console.WriteLine("Birinci Sayıyı Giriniz: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz: ");
            m = Convert.ToInt32(Console.ReadLine());


            int[] sayilar = new int[n];

            Console.WriteLine("{0} adet positif sayı girmeniz gerekmektedir.", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Girdiginiz sayılar arasındaki {0}'e eşit veya tam bölünen sayılar: ", m);
            foreach (int bolunen in sayilar)
            {
                if (bolunen % m == 0 || bolunen == m)
                    Console.Write("{0,3}  ", bolunen);
            }
            Console.ReadKey();
        }



        /*3. Ödev
         Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        */

        static void Main()
         {
             Console.WriteLine("Bir adet pozitif Sayı giriniz:");
             int n;
             n = Convert.ToInt32(Console.ReadLine());            

             string[] kelime = new string[n];

             for (int i = 0; i < n; i++)
             {
                 Console.Write("Lütfen {0}. kelimeyi giriniz: ",i+1);
                 kelime[i] = Console.ReadLine();
             }

             Console.Write("Girmiş olduğunuz kelimeler: ");
             foreach (string k in kelime) 
             {
                 Console.Write("{0,3} ", k);
             }

             Array.Reverse(kelime);

             Console.Write("\nSondan başa doğru girmiş olduğunuz kelimeler: ");
             foreach (string k in kelime) 
             {
                 Console.Write("{0,3 }", k);
             }
             Console.ReadKey();
         }




        /* 4.Ödev
            Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
         */
        public static void Main()
        {
            string cumle;
            int bosluk = 0;

            Console.Write("Bir cümle yazınız: ");
            cumle = Console.ReadLine();


            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == ' ') bosluk++;

            }
            int harf = cumle.Length - bosluk;
            int kelime = bosluk + 1;

            Console.WriteLine("Girilen Cümle: {0}. \nKelime Sayısı: {1}. \nHarf Sayısı : {2}.", cumle, kelime, harf);
            Console.ReadKey();

        }

    }
}
