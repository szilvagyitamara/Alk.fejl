// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
/*
Console.WriteLine("Annyeonghaseyo!");
Random rnd = new Random();
Console.WriteLine("Tanár diák kocka játék");
int tanar = rnd.Next(1, 6);
Console.WriteLine($"A tanár {tanar} dobot!");
int diak = rnd.Next(1, 6);
Console.WriteLine($"A diák {diak} dobot!");
if (tanar==diak)
{
    Console.WriteLine("Egyenlő");

}
else if (tanar > diak)
{
    Console.WriteLine("A tanár dobot többet!");
}
else
{
    Console.WriteLine("A diák dobot többet!");
}
*/
/* for ciklus
for (int i =1; i <=5;i++)
{
    Console.WriteLine(i);
}
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Hajrá ZTE!");
}

for (int y = 1; y <= 3; y++)
{
    Console.WriteLine("Fúj Pest!");
}

string[] nevek = { "Anna", "Béla", "Csaba" };
for (int i = 0; i<nevek.Length; i++)
{
    Console.WriteLine(nevek[i]);
}

string[] nevek = { "Anna", "Béla", "Csaba" };
foreach(string nev in nevek)
{
    Console.WriteLine(nev);
}
//kiirja a számokat 5-től vissza fele
int i = 0;
while (i<5)
{
    Console.WriteLine(i);
    i++;
}

int i  = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 5);

//minimum szám keresése:
int[] szamok = { 12, 5, 8, -3, 15, 0 };
//kezdő minimum az első elem
int min = szamok[0];
//végig megyünk a tömbön for ciklussal
for (int i=1;i< szamok.Length;i++)
{
    if (szamok[i] <min)
    {
        min = szamok[i];
    }
}
Console.WriteLine("A legkisebb szám:" + min);

int[] szamok = { 12, 5, 8, -3, 15, 0 };
//Kezdő minimum az első elem
int min = szamok[0];
//foreach ciklus minden elemen végig megy
foreach (int szam in szamok)
{
    if (szam<min)
    {
        min = szam;
    }
}
Console.WriteLine("A legkisebb szám:" + min);

int[] szamok = { 12, 5, 8, -3, 15, 0 };
//Kezdő minimum az első elem
int min=szamok[0];
int i = 1;//a 0. elemet már betettük a min-be
while (i<szamok.Length)
{
    if (szamok[i]<min)
    {
        min = szamok[i];
    }
    i++;    
}
Console.WriteLine("A legkisebb szám:" + min);
*/
int[] szamok = { 12, 5, 8, -3, 15, 0 };
int min=szamok[0];  //Kezdő minimum az első elem
int i = 1;  //A 0. elemet már betettük a min-be
do 
{
    if (szamok[i]<min)
    {
        min = szamok[i];
    }
    i++;
}
while (i<szamok.Length);
Console.WriteLine("A legkisebb szám ami van a listában:" + min);