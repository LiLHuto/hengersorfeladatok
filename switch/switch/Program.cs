using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("számológép!");
            int a;
            Console.Write("ird be az első számot:");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ird be a második számot:");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("milyen műveletet akarsz elvégezni?(/,+,-,*):");
            string muvelet = Console.ReadLine();



            switch (muvelet)
            {
                case "+":
                    a = szam1 + szam2;
                    Console.WriteLine("Összeadás:" + a);



                    string valasz = Console.ReadLine();
                    if (szam1 == szam2)
                    {

                    }
                    break;
                case "-":
                    a = szam1 - szam2;
                    Console.WriteLine("Kivonás:" + a);
                    Console.Write("Akarsz még számolni?(igen v nem):");
                    break;
                case "*":
                    a = szam1 * szam2;
                    Console.WriteLine("Szorzás:" + a);
                    Console.Write("Akarsz még számolni?(igen v nem):");
                    break;
                case "/":
                    a = szam1 / szam2;
                    Console.WriteLine("Osztás:" + a);
                    Console.Write("Akarsz még számolni?(igen v nem):");
                    break;
                default:
                    Console.WriteLine("Rossz számot adtál meg!");
                    break;
            }
        }
    }
}