// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Annyeonghaseyo");
/*List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
int keresett = 16;
bool megtalálva = false;
int i = 0;
while (i < szamok.Count)
{
    if (szamok[i] == keresett)
    {
        Console.WriteLine($"A kerestt szám ({keresett}) megtalálva a(z) {i}.indexen");
        megtalálva = true;
        break;
    }
    i++;
}
if (megtalálva)
{
    Console.WriteLine($"A {keresett} szám nincs a listában.");
}
ez hibás....
List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
int keresett = 16;
bool megtalálva = false;
int i = 0;
if (szamok.Count>0)
{
    do
    {
        if (szamok[i])== keresett)
                {
            Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {i}.indexen");
            megtalálva = true;
            break;
        }
        i++
    }
    while (i < szamok.Count);
}
if (!megtalálva)
{ 
    Console.WriteLine($"A {keresett} szám nincs a listában.");
}

List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
int keresett = 16;
if (szamok.Contains(keresett))
{
    Console.WriteLine($"A keresett szám {keresett} megtalálva a listában.");
}
else 
{
    Console.WriteLine($"A {keresett} szám nincs a listában.");
}*/
List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
int keresett = 16;
int index =szamok.IndexOf(keresett);
if (index ! == -1)
{
    Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {index}.indexen");
}
else
{ 
    Console.WriteLine($"A {keresett} szám nincs a listában.");
}