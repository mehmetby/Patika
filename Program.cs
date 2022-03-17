using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Dizi Tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "Flamingo", "At", "Jaguar", "Puma" };
            int[] dizi;
            dizi = new int[5];

            // Değer Atama ve Erişim

            dizi[0] = 10;
            renkler[3] = "Mavi";

            Console.WriteLine(dizi[0]);
            Console.WriteLine(renkler[3]);
            Console.WriteLine(hayvanlar[0]);



            // Döngülerle Dizi Kullanımı
            //Klavyeden girilen n tane sayının ortalamasını almak.

            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int ElemanSayisi = int.Parse(Console.ReadLine());
            int[] SayiDizisi = new int[ElemanSayisi];

            for (int i = 0; i < ElemanSayisi; i++)
            {
                Console.Write("Lütfen dizinin {0}. elemanını giriniz: ", i + 1);
                SayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;

            foreach (var sayi in SayiDizisi)
                toplam += sayi;


            Console.WriteLine("Ortalama : " + toplam / ElemanSayisi);

        }

    }
}
