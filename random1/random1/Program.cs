using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int szam1 = Convert.ToInt32(Console.ReadLine());
            int szam = rnd.Next(1, 101);
            bool talalt = false;
            Console.Write("tippelj egytől százig");
            do
            {
                szam1 = int.Parse(Console.ReadLine());

                if (szam1 == szam)
                {
                    Console.WriteLine("megtaláltad a számot");
                    talalt = true;
                }
                else if (szam < szam1)
                {
                    Console.WriteLine("A szám kisebb");
                }
                else if (szam > szam1)
                {
                    Console.WriteLine(" A szám nagyobb.");
                }
            } while (!talalt);

            Console.ReadKey();
        }
    }
}