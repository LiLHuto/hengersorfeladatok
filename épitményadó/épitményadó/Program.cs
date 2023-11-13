using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace épitményadó
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> telekLista = Beolvas("utca.txt");

            Console.WriteLine("2. feladat. A mintában " + telekLista.Count + " telek szerepel.");

            Console.Write("3. feladat. Kérjen be egy tulajdonos adószámát: ");
            int adoszam = int.Parse(Console.ReadLine());
            string talaltTelek = KeressTelek(telekLista, adoszam);
            if (talaltTelek != null)
            {
                Console.WriteLine(talaltTelek);
            }
            else
            {
                Console.WriteLine("Nem szerepel az adatállományban.");
            }

            Console.WriteLine("5. feladat");
            Dictionary<char, int> adosavok = SzamolAdoSavok(telekLista);
            foreach (var kvp in adosavok)
            {
                Console.WriteLine(kvp.Key + " sávba " + kvp.Value + " telek esik, az adó " + SzamolAdo(kvp.Key, telekLista) + " Ft.");
            }

            Console.WriteLine("6. feladat. A több sávba sorolt utcák:");
            List<string> tobbsavosUtcak = SzamolTobbsavosUtcak(telekLista);
            foreach (var utca in tobbsavosUtcak)
            {
                Console.WriteLine(utca);
            }

            AdoMentes(telekLista);
            Console.ReadKey();
        }

        static List<string> Beolvas(string fajlnev)
        {
            List<string> telekLista = new List<string>();
            string[] sorok = File.ReadAllLines(fajlnev);
            for (int i = 1; i < sorok.Length; i++)
            {
                telekLista.Add(sorok[i]);
            }
            return telekLista;
        }

        static string KeressTelek(List<string> telekLista, int adoszam)
        {
            foreach (var sor in telekLista)
            {
                string[] adatok = sor.Split(' ');
                int sorAdoszam = int.Parse(adatok[0]);
                if (sorAdoszam == adoszam)
                {
                    return adatok[1] + " " + adatok[2];
                }
            }
            return null;
        }

        static Dictionary<char, int> SzamolAdoSavok(List<string> telekLista)
        {
            Dictionary<char, int> adoSavok = new Dictionary<char, int>();
            foreach (var sor in telekLista)
            {
                string[] adatok = sor.Split(' ');
                char adosav = char.Parse(adatok[3]);
                if (!adoSavok.ContainsKey(adosav))
                {
                    adoSavok[adosav] = 1;
                }
                else
                {
                    adoSavok[adosav]++;
                }
            }
            return adoSavok;
        }

        static int SzamolAdo(char adosav, List<string> telekLista)
        {
            int adoSavAdo = 0;
            foreach (var sor in telekLista)
            {
                string[] adatok = sor.Split(' ');
                char sorAdosav = char.Parse(adatok[3]);
                if (sorAdosav == adosav)
                {
                    int alapterulet = int.Parse(adatok[4]);
                    adoSavAdo += Ado(adosav, alapterulet);
                }
            }
            return adoSavAdo;
        }

        static List<string> SzamolTobbsavosUtcak(List<string> telekLista)
        {
            List<string> tobbsavosUtcak = new List<string>();
            Dictionary<string, List<char>> utcaAdoSavok = new Dictionary<string, List<char>>();
            foreach (var sor in telekLista)
            {
                string[] adatok = sor.Split(' ');
                string utca = adatok[1];
                char adosav = char.Parse(adatok[3]);

                if (!utcaAdoSavok.ContainsKey(utca))
                {
                    utcaAdoSavok[utca] = new List<char>();
                }

                if (!utcaAdoSavok[utca].Contains(adosav))
                {
                    utcaAdoSavok[utca].Add(adosav);
                }
            }

            foreach (var kvp in utcaAdoSavok)
            {
                if (kvp.Value.Count > 1)
                {
                    tobbsavosUtcak.Add(kvp.Key);
                }
            }
            return tobbsavosUtcak;
        }

        static int Ado(char adosav, int alapterulet)
        {
            Dictionary<char, int> adoSavok = new Dictionary<char, int>()
        {
            { 'A', 800 },
            { 'B', 600 },
            { 'C', 100 }
        };

            int ado = alapterulet * adoSavok[adosav];
            return ado > 10000 ? ado : 0;
        }

        static void AdoMentes(List<string> telekLista)
        {
            StreamWriter sw = new StreamWriter("fizetendo.txt");
            foreach (var sor in telekLista)
            {
                string[] adatok = sor.Split(' ');
                char adosav = char.Parse(adatok[3]);
                int alapterulet = int.Parse(adatok[4]);
                int ado = Ado(adosav, alapterulet);
                if (ado > 0)
                {
                    sw.WriteLine(adatok[0] + " " + ado);
                }
            }
            sw.Close();
        }
    }
}
