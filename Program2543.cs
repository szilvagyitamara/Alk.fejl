// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1.Feladat:
int[] meres = {36, 48, 39, -1, 30, 43, -1, 76, 67, 82, 73, 75, 64, 73, 69, 63
};
Console.WriteLine("1. Feladat:");
Console.WriteLine("Mérési adatok beolvasása volt.");
//2.Feladat:
int osszeskerekparos = 0;
foreach (int ertek in meres)
{
    if (ertek >= 0)
    {
        osszeskerekparos +=ertek;
    }
}
Console.WriteLine($"2.Feladat:");
Console.WriteLine($"Összesen {osszeskerekparos} kerépárost számoltak.");
//3.Feladat:
Console.WriteLine("3.Feladat:");
for (int i = 0; i < meres.Length; i++)
{
    int ertek = meres[i];
    if (ertek >= 0)
    {
        Console.WriteLine($"{} órától {ertek} kerékpáros");
    }
}