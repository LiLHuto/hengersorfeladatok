using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodfoku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez a Program megoldja a másodfokú egyenletet");

            Console.WriteLine("adja meg a másodfokú egyenlet fő együtt hatóját");
            double a = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("adja meg az elsőfokú  tag  együtt hatóját!");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("adja meg a tiszta tag értékét");
            double c = Convert.ToDouble(Console.ReadLine());

            
            double D = b * b - 4 * a * c;
            Console.WriteLine("Disztkrimináns: {0}", D);

            if (D < 0)
            {
                Console.WriteLine("Nincs valós gyök!");
            }
            else
            {
                double Megoldas_1 = ((-1) * b + Math.Sqrt(D)) / (2 * a);
                double Megoldas_2 = ((-1) * b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Az első megoldás: x1-{0:0.00} \nA Második megoldás:x2={1:0.00}", Megoldas_1 , Megoldas_2);

            }
            Console.ReadLine();

                ;
    

        }
    }
}
