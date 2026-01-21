using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void kiirat(string nev, int kor)
        {
            Console.WriteLine(nev + "Hello " + kor + "éves");
        }

        static void Main(string[] args)
        {
            kiirat("Timi ", 20);
            kiirat("Kati ", 32);

        }
    }
}
