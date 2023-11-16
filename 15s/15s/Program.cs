using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Random random = new Random();
                int[] szamok = new int[28];
                int pozSzamok = 0;
                int negSzamok = 0;
                int hetesek = 0;
                int nulla = -1;

                for (int i = 0; i < szamok.Length; i++)
                {
                    szamok[i] = random.Next(-10, 11);

                    if (szamok[i] > 0)
                        pozSzamok++;
                    else if (szamok[i] < 0)
                        negSzamok++;
                    if (szamok[i] == 7)
                        hetesek++;
                    if (szamok[i] == 0)
                        nulla = i;
                }

                Console.WriteLine("Kapott számok: " + string.Join (", ", szamok));
                Console.WriteLine("Pozitív számok : " + pozSzamok);
                Console.WriteLine("Negatív számok : " + negSzamok);
                Console.WriteLine("Hetesek: " + hetesek);
                if (nulla!= -1)
                    Console.WriteLine("Van 0 és a(z) " + nulla +". szám");
                else
                    Console.WriteLine("Nincs 0.");
            }
            Console.ReadKey();
        }
    }
}

