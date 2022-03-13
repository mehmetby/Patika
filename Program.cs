using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //try
            //{

            //    Console.WriteLine("Lütfen bir sayı giriniz :");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Girmiş olduğunuz sayi :" + sayi);

            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error :" + ex.Message.ToString());
            //}

            //finally
            //{
            //    Console.WriteLine("Mission Completed!");
            //    Console.ReadLine();
            //}

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Boş bir değer girdiniz! " + ex);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil!! " + ex);
                Console.ReadLine();
            }

            catch (OverflowException ex)
            {
                Console.WriteLine("Veri tipi uygun değil!! " + ex);
                Console.ReadLine();
            }



            finally
            {
                Console.WriteLine("İşlem tamamlandı");
                Console.ReadLine();
            }

        }
    }
}
