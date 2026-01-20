using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("teglalap terulet kerulet szamolas");
            Console.WriteLine("Kerem adja meg az A oldalt");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Kerem adja meg a b oldalt");
            int b = int.Parse(Console.ReadLine());
            int ter = a * b;
            int ker = 2 * (a + b);
            Console.WriteLine($"a teglalap terulete:{ter}");
            Console.WriteLine($"a teglalap kerulete: {ker}");
            if (ter > ker)
            { Console.WriteLine("a terulete nagyobb mint a kerulete"); }
            else if (ter < ker)
            {
                Console.WriteLine("a kerulete nagyobb mint a terulete");
            }
            else
            {
                Console.WriteLine("A terulete egyenlo a keruletevel");
            }
        }
    }
}
