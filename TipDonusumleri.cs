using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {// implicit Conversation(Bilinçsiz Dönüşüm)
            Console.WriteLine("************implicit Conversation*********** ");

            byte a = 5;
            sbyte b = 20;
            short c = 30;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long e = d;
            Console.WriteLine("e: " + e);

            float f = e;
            Console.WriteLine("f: " + f);

            string g = "Mehmet";
            char h = 'B';
            object i = g + " " + h + " " + e;

            Console.WriteLine(i);

            //Console.ReadLine();

            // Explicit Conversation(Bilinçli Dönüşüm)

            Console.WriteLine("************Explicit Conversation*********** ");

            int j = 9;
            byte k = (byte)j;
            Console.WriteLine("k: " + k);

            float l = 10.32f;
            byte m = (byte)l;
            Console.WriteLine("m: " + m);

            int n = j * (byte)l;
            Console.WriteLine("n: " + n);




            //************ToString Method***********
            Console.WriteLine("************ToString Method*********** ");
            int o = 66;
            string p = o.ToString();
            Console.WriteLine("p: " + p);

            string q = 35.6f.ToString();
            Console.WriteLine("q: " + q);

            //System.Convert

            Console.WriteLine("*******System.Convert*********");
            string s1 = "25", s2 = "36";
            int sayi1, sayi2;
            int toplam ;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;

            Console.WriteLine(toplam);

            //Parse.Method
            Console.WriteLine("*******Parce Method******");
            string sayi5 = "25";
            string sayi6 = "13,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(sayi5);
            double1 = Double.Parse(sayi6);

            Console.WriteLine("rakam1 :"+rakam1);
            Console.WriteLine("double1 :"+double1);

            Console.ReadLine();
            
        }
        
    }
}
