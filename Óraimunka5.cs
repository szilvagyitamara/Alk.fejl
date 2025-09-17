// See https://aka.ms/new-console-template for more information
Console.WriteLine("Annyeonghaseyo!");
/*int[] szamok = { 12, 5, 8, -3, 15, 0 };
int min = szamok[0];  //Kezdő minimum az első elem
int i = 1;  //A 0. elemet már betettük a min-be
do
{
    if (szamok[i] < min)
    {
        min = szamok[i];
    }
    i++;
}
while (i < szamok.Length);

Console.WriteLine("A legkisebb szám ami van a listában:" + min);


int[] szamok = { 12, 5, 8, -3, 15, 0 };
int max = szamok[0];
for (int i = 1; i < szamok.Length; i++)
{
    if (szamok[i] > max)
    {
        max = szamok[i];
    }
}
Console.WriteLine($"A legnagyobb szám:{max}.");


int[] szamok = { 12, 5, 34, 78, 65, 7, };
int max = szamok[0];
for (int i=1; i<szamok.Length;i++)
{
    if (szamok[i] > max)
    {
        max = szamok[i];
    }
}
Console.WriteLine($"A legnagyobb szám:{max}.");

int[] szamok = { 12, 5, 8, -3, 15, 0 };
int max = szamok[0];
foreach (int szam in szamok)
{
    if (szam > max)
    {
        max = szam; 
    }
}
Console.WriteLine($"A legnagyobb szám:{ max}.");


int[] szamok = { 12, 5, 8, -3, 15, 0 };
int max = szamok[0];
int i = 1;
while (i< szamok.Length)
{
    if (szamok[i] > max)
    {
        max = szamok[i];
    }
    i++;
}
Console.WriteLine($"A legnagyobb szám: {max}.");

int[] szamok = { 12, 5, 8, -3, 15, 0 };
int max = szamok[0];
int i=1;
do
{
    if (szamok[i] > max)
    {
        max = szamok[i];
    }
    i++;
}
while (i < szamok.Length);
Console.WriteLine($"A legnagyobb szám: {max}.");

int[] szamok = { 12, 5, 8, -3, 15, 0 };
int max = szamok.Max();
Console.WriteLine($"A legnagyobb szám: {max}");


List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
int keresett = 16;
bool megtalálva = false;
for (int i=0; i<szamok.Count;i++)
{
    if (szamok[i]==keresett)
    {
        Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z){i}.indexen.");
        megtalálva = true;
        break; //kilépünk mert megtaláltuk
    }
}
if(!megtalálva)
{
    Console.WriteLine($"A {keresett}szám nincs a listában");
}
*/
List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
int keresett = 16;
bool megtalálva = false;
int index = 0;
foreach (int szam in szamok)
{
    if (szam==keresett)
    {
        Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z){index}.indexen");
        megtalálva = true;
        break;
    }
    index++;
}
if(!megtalálva)
{
    Console.WriteLine($"A {keresett}szám nincs a listában.");
}