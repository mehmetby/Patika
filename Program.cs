using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] SayiDizisi = { 3, 13, 5, 11, 7, 9, 17, 15 };
            Console.WriteLine("******Sırasız Dİzi******");
            foreach (int sayi in SayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("******Array Sort******");
            Array.Sort(SayiDizisi);
            foreach (int sayi in SayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("******Array Clear******");
            Array.Clear(SayiDizisi, 2, 2);
            foreach (int sayi in SayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("******Array IndexOf******");
            Console.WriteLine(Array.IndexOf(SayiDizisi, 17));

            Console.WriteLine("******Array Reverse******");
            Array.Reverse(SayiDizisi);
            foreach (int sayi in SayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("******Array ReSize******");
            Array.Resize<int>(ref SayiDizisi, 9);
            SayiDizisi[8] = 99;
            foreach (int sayi in SayiDizisi)
                Console.WriteLine(sayi);


        }
    }
}
