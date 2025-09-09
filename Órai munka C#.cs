// See https://aka.ms/new-console-template for more information


Console.WriteLine("Annyeonghaseyo!");
Console.WriteLine("A téglalap kerülete és területe");
Console.Write("Kérem az a oldalt");
double a = double.Parse(Console.ReadLine());
Console.Write("Kérem az a oldalt:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("A kerület:" + 2 * a + 2 * b);
double ker = 2 * a + 2 * b;
double ter = a * b;
Console.WriteLine($"A terület:{ter}");
if (ker == ter)
{
    Console.WriteLine("Egyenlő");
}
else if (ker > ter)
{
    Console.WriteLine("A kerület a nagyobb!");
}
else
{
    Console.WriteLine("A terület a nagyobb!");
}
Console.ReadKey();
        