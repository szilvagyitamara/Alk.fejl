using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    internal class Program
    {
        static int szamol()
        {
            Console.Write("Kérem a négyzet oldalát: ");
            int szam = int.Parse(Console.ReadLine());
            int ter = szam * szam;
            return ter;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("a négyzet területe:" + szamol());
        }
    }
}
