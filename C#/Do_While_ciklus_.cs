using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{  
namespace ConsoleApp2
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // --- DO-WHILE CIKLUS PÉLDA ---
                int i = 0; // számláló változó
                do
                {
                    Console.WriteLine(i); // kiírjuk az aktuális i értéket
                    i++; // növeljük i-t eggyel
                }
                while (i < 5); // addig fut, amíg i kisebb mint 5


                // --- MINIMUM KERESÉSE FOR CIKLUSSAL ---
                int[] szamok = { 12, 5, 8, -3, 15, 0 }; // tömb létrehozása
                int min = szamok[0]; // kezdő minimum az első elem

                for (int j = 1; j < szamok.Length; j++) // végigmegyünk a tömbön
                {
                    if (szamok[j] < min) // ha találunk kisebb számot
                    {
                        min = szamok[j]; // akkor frissítjük a minimumot
                    }
                }
                Console.WriteLine("A legkisebb szám (for): " + min);


                // --- MINIMUM KERESÉSE FOREACH CIKLUSSAL ---
                min = szamok[0]; // újraindítjuk a minimumot
                foreach (int szam in szamok) // minden elemre lefut
                {
                    if (szam < min)
                    {
                        min = szam; // ha kisebb, frissítjük
                    }
                }
                Console.WriteLine("A legkisebb szám (foreach): " + min);


                // --- MINIMUM KERESÉSE WHILE CIKLUSSAL ---
                min = szamok[0];
                int k = 1; // 0. elemet már ismerjük

                while (k < szamok.Length) // amíg van elem
                {
                    if (szamok[k] < min)
                    {
                        min = szamok[k];
                    }
                    k++; // léptetjük a számlálót
                }
                Console.WriteLine("A legkisebb szám (while): " + min);


                // --- MINIMUM KERESÉSE LINQ SEGÍTSÉGÉVEL ---
                min = szamok.Min(); // automatikusan megkeresi a legkisebbet
                Console.WriteLine($"A legkisebb szám (LINQ): {min}");


                // --- MAXIMUM KERESÉSE FOREACH CIKLUSSAL ---
                int max = szamok[0]; // kezdő maximum

                foreach (int szam in szamok)
                {
                    if (szam > max) // ha találunk nagyobbat
                    {
                        max = szam; // frissítjük a maximumot
                    }
                }
                Console.WriteLine($"A legnagyobb szám: {max}");
            }
        }
    }
}
  

