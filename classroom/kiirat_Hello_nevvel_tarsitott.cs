using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void kiirat(string nev)
        {
            Console.WriteLine(nev + "Hello");
        }

        static void Main(string[] args)
        {
            kiirat("Timi ");
            kiirat("Tamás ");

        }
    }
}
