using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("A téglalap kerülete és területe:");
            Console.WriteLine("Kérem adja meg az A oldalt!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a B oldalt");
            int b = int.Parse(Console.ReadLine());
            int ter = a * b;
            int ker = 2 * (a + b);
            Console.WriteLine($"A téglalap terulete: {ter}");
            Console.WriteLine($"A téglalap kerulete: {ker}");
            if (ter > ker)
            {
                Console.WriteLine("A területe a nagyobb");
            }
            else if (ker > ter)
            {
                Console.WriteLine("A kerülete a nagyobb!");
            }
            else
            {
                Console.WriteLine("A területe és kerülete egyenlő");
            }
         
            Console.WriteLine("A négyzet kerülete és területe");
            Console.WriteLine("Kérem az oldalt!");
            int A = int.Parse(Console.ReadLine());
            int ker = 4 * A;
            int ter = A * A;
            Console.WriteLine($"A téglalap kerülete: {ker}");
            Console.WriteLine($"A téglalap területe: {ter}");
            if (ter > ker)
            {
                Console.WriteLine("A területe a nagyobb");
            }
            else if (ker > ter)
            {
                Console.WriteLine("A kerülete a nagyobb!");
            }
            else
            {
                Console.WriteLine("A területe és kerülete egyenlő");
            }
             */
            Console.WriteLine("A háromszög kerülete és területe!!");
            Console.WriteLine("Kérem adja meg az A oldalt!");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem adja meg a B oldalt!");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem adja meg a C oldalt!");
            int C = int.Parse(Console.ReadLine());
            int ker =A+B+C;
            int ter =(A+B+C)/2;
            Console.WriteLine($"A háromszög  kerülete: {ker}");
            Console.WriteLine($"A háromszög területe: {ter}");
            if (ter > ker)
            {
                Console.WriteLine("A területe a nagyobb");
            }
            else if (ker > ter)
            {
                Console.WriteLine("A kerülete a nagyobb!");
            }
            else
            {
                Console.WriteLine("A területe és kerülete egyenlő");
            }
        }
    }
}
