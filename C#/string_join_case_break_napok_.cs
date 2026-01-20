using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Feladat
            List<int> szamok = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> parosszamok = new List<int>();
            foreach (int szam in szamok)
            {
                if (szam % 2 == 0)
                {
                    parosszamok.Add(szam);
                }
            }
            Console.WriteLine("2-vel osztható számok:" + string.Join(";", parosszamok));
            //2.Feladat
            Console.Write("Adj meg egy számot (1-7):");
            int nap = int.Parse(Console.ReadLine());
            switch (nap)
            {
                case 1:
                    Console.WriteLine("Hétfő");
                    break;
                case 2:
                    Console.WriteLine("Kedd");
                    break;
                case 3:
                    Console.WriteLine("Szerda");
                    break;
                case 4:
                    Console.WriteLine("Csütörtök");
                    break;
                case 5:
                    Console.WriteLine("Péntek");
                    break;
                case 6:
                    Console.WriteLine("Szombat");
                    break;
                case 7:
                    Console.WriteLine("Vasárnap"); //nincs befejezve...
                    break;
            }
          
           //3.Feladat
           Console.WriteLine("1.Feladat: Kérem adja meg a heti aktivitást (max 250 karakter):");
            String aktivitás = Console.ReadLine();
            int osszkm = 0;
            bool voltU = false, voltG = false, voltF = false, voltK = false;
            foreach (char c in aktivitás)
            {
                switch (c)
                {
                    case 'U': osszkm += 1; voltU = true; break;
                    case 'G': osszkm += 2; voltG = true; break;
                    case 'F': osszkm += 2; voltF = true; break;
                    case 'K': osszkm += 10; voltK = true; break;

                }
            }
            Console.WriteLine("2.Feladat: A felhasználó által megtett távolság");
        }
    }
    }

