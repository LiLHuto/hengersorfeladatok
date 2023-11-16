using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kocka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hányszor dobja fel a kockát? ");
            int dobszam = int.Parse(Console.ReadLine());

            Random random = new Random();
            int anninyert = 0;
            int panninyert = 0;

            for (int i = 0; i < dobszam; i++)
            { 
                int kocka1 = random.Next(1, 7);
                int kocka2 = random.Next(1, 7);
                int kocka3 = random.Next(1, 7);

                int osszeg = kocka1 + kocka2 + kocka3;
                string nyertes = (osszeg < 10) ? "Anni" : "Panni";


                Console.WriteLine($"Dobás: {kocka1} + {kocka2} + {kocka3} = {osszeg}  Nyert: {nyertes}");


                if (nyertes == "Anni")
                {
                    anninyert++;
                }
                else
                {
                    panninyert++;
                }
            }


            Console.WriteLine($"\nA játék során {anninyert} alkalommal Anni, {panninyert} alkalommal Panni nyert.");
            Console.ReadKey();
        }
    }
}