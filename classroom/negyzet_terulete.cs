using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void szamol()
        {
            Console.Write("Kérem a négyzet oldalát: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine("A négyzet területe: " + szam * szam);
        }

        static void Main(string[] args)
        {
            szamol();
        }
    }
}
