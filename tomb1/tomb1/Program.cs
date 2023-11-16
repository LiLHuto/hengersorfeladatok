using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("egy osztály matekátlaga");

            int[] jegyek = new int[10];
            int osszeg = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Kérem a {i + 1}. jegyeket: ");
                jegyek[i] = int.Parse(Console.ReadLine());
                osszeg += jegyek[i];
            }
            double atlag = (double)osszeg / 10;
            int darab = 0;
            for (int i = 0;i < 10;i++)
            {
                if (jegyek[i] > atlag)
                    darab++;
              
            }
            Console.WriteLine($"ennyien értek el az átlagnál jobb eredményt   {darab}");
            Console.WriteLine($"Az átlaguk: {atlag}");
            Console.ReadKey();
        }
    }
}


