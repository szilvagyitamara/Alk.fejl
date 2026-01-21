using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void kiirat(string iskola = "Premo")
        {
            Console.WriteLine("Hello " + iskola);
        }

        static void Main(string[] args)
        {
            kiirat();
            kiirat("Vajda");
            kiirat();
            kiirat("VSZK");

        }
    }
}
