using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Feladat
            int[] uvegek = { 5, 2, 2, 4, 3, 2, 4, 10, 5, 5, 3, 5, 4, 3, 3 };
            Console.WriteLine("1.Feladat: adatok beolvasva.");

            //2.Feladat
            Console.WriteLine("2.Feladat\nMari néni lekvárja (dl):");
            int L = int.Parse(Console.ReadLine());
            Console.WriteLine($"Mari néni lekvárja (dl): {L}");

            //3.Feladat
            int maxErtek = uvegek.Max();
            int elsoIndex = Array.IndexOf(uvegek, maxErtek) + 1;
            Console.WriteLine("3.Feladat");
            Console.WriteLine($"Legnagyobb üveg: {maxErtek} dl és {elsoIndex}.a sorban.");

            //4.Feladat
            int osszKapacitas = uvegek.Sum();
            Console.WriteLine("4.Feladat");
            if (osszKapacitas >= L)
            {
                Console.WriteLine("Elegendő üveg volt.");
            }
            else
            {
                Console.WriteLine("Maradt lekvár");
            }
        }
    }
}
