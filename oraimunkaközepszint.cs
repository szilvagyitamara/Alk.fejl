// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1.Feladat
Console.WriteLine("Kérem adja meg a heti  aktivitást(max 250 karakter )");
    string aktivitas = Console.ReadLine();

//2. Feladat
int osszkm = 0;
bool voltU = false, voltG = false, voltF = false, voltK = false;
foreach (char c in aktivitas)
{
    switch (c)
    {
        case 'U': osszkm += 1; voltU = true;break;
        case 'G': osszkm += 1; voltG = true; break;
        case 'F': osszkm += 2; voltF = true; break;
        case 'K': osszkm += 10; voltK = true; break;
    }
}
Console.WriteLine("A felhasználó által megtett távolság: {0}km", osszkm);
//3. Feladat
int jutalom = 0;
if (voltU && voltG && voltF && voltK)
{
    jutalom = 10;
    Console.WriteLine("Bravo! Jutalma még 10km.");

}
else
{
    Console.WriteLine("Nem jár jutalom");
}
//4. feladat
int vegsokm = osszkm + jutalom;
Console.WriteLine("Összesitett teljesitmény: {0}km", vegsokm);
if (vegsokm >= 40)
{
    Console.WriteLine("Gratulálok,kihivás teljesítve!");
}
else
{
    Console.WriteLine("Legközelebb sikerül");
}