// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*List<int> szamok = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
List<int> parosszamok = new List<int>();
foreach (int szam in szamok)
{
    if (szam % 2 == 0)
    {
        parosszamok.Add(szam);
    }
}
Console.WriteLine("2-vel osztható számok:" + string.Join(",", parosszamok));
*/
Console.Write("Adj meg egy számot (1-7)-ig");
int nap = int.Parse(Console.ReadLine());
switch (nap)
{
    case 1:
        Console.WriteLine("Hétfő");
        break;
    case 2:
        Console.WriteLine("Kedd");
        break;
    case 3:
        Console.WriteLine("Szerda");
        break;
    case 4:
        Console.WriteLine("Csütörtök");
        break;
    case 5:
        Console.WriteLine("Péntek");
        break;
    case 6:
        Console.WriteLine("Szombat");
        break;
    case 7:
        Console.WriteLine("Vasárnap");
        break;
    default:
        Console.WriteLine("Nincs ilyen nap!");
        break;

}
