using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static (int ker, int ter) szamol()
        {
            Console.Write("Kérem a négyzet oldalát: ");
            int szam = int.Parse(Console.ReadLine());
            int ker = 4 * szam;
            int ter = szam * szam;
            return (ker, ter);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("a négyzet kerülete:" + szamol().ker);
            Console.WriteLine("a négyzet területe:" + szamol().ter);

        }
    }
}
