using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            string sonuc;

            if (time > 5 && time < 11)
                sonuc = "Günaydın!";

            else if (time > 11 && time < 18)
                sonuc = "İyi Günler!";

            else if (time > 18 && time < 22)
                sonuc = "İyi Akşamlar!";

            else
                sonuc = "İyi Geceler!";

            Console.WriteLine(sonuc);
            Console.ReadLine();


        }
    }
}
