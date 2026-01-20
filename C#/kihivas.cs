using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{ 
namespace ConsoleApp14
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // Példa bemeneti adatok
                bool voltU = true;
                bool voltG = true;
                bool voltF = true;
                bool voltK = true;

                int osszkm = 30;

                // 3. Feladat
                int jutalom = 0;
                if (voltU && voltG && voltF && voltK)
                {
                    jutalom = 10;
                    Console.WriteLine("3.Feladat: Bravo! Jutalom még 10 km");
                }
                else
                {
                    Console.WriteLine("3.Feladat: Nem jár jutalom");
                }

                // 4. Feladat
                int vegsokm = osszkm + jutalom;
                Console.WriteLine($"4.feladat: Összesített teljesítmény: {vegsokm} km");

                if (vegsokm >= 40)
                {
                    Console.WriteLine("Gratulálok, kihívás teljesítve!");
                }
                else
                {
                    Console.WriteLine("Legközelebb sikerül!");
                }
            }
        }
    }
} 

