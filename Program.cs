using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int i = 0;
             do
             {
                 Console.WriteLine(i);
                 i++;
             }
             while (i < 5);
            int[] szamok = {12,5,8,-3,15,0 };
            //kezdő minimum az első elem
            int min = szamok[0];
            //végig megyünk a tömbön for ciklussal
            for (int i = 1; i < szamok.Length; i++)
            {
                if (szamok[i] < min)
                { 
                    min = szamok[i];
                }
            }
            Console.WriteLine("A legkisebb szám:" + min);

            int[] szamok = { 12, 5, 8, -3, 15, 0 };
            //kezdő minimum az első elem
            int min = szamok[0];
            //foreach ciklus minden elemen végig megy
            foreach (int szam in szamok)
            {
                if (szam < min)
                { 
                    min= szam;
                }
            }
            Console.WriteLine("A legkisebb szám:"+min);

            int[] szamok = { 12, 5, 8, -3, 15, 0 };
            //kezdő minimum az első elem
            int min = szamok[0];
            int i = 1; //a 0. elemet már betettük a min-be
            while (i < szamok.Length)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
                i++;
            }
            Console.WriteLine("A legkisebb szám:"+min);
            
            int[] szamok = { 12, 5, 8, -3, 15, 0 };
            int min = szamok.Min();
            Console.WriteLine($"A legkisebb szám:{min}.");

            int[] szamok = { 12, 5, 8, -3, 15, 0 };
            int max = szamok[0];
            for (int i = 1; i < szamok.Length; i++)
            {
                if (szamok[i] > max)
                { 
                    max = szamok[i];
                }
            }
            Console.WriteLine($"A legnagyobb szám: {max}.");*/

            int[] szamok = { 12, 5, 8, -3, 15, 0 };
            int max = szamok[0];
            foreach (int szam in szamok)
            {
                if (szam > max)
                { 
                    max= szam;
                }
            }
            Console.WriteLine($"A legnagyobb szám: {max}.");
        }
    }
}
