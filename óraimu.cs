// See https://aka.ms/new-console-template for more information
Console.WriteLine("Annyeonghaseyo");
/*//5 elemű int tömb létrehozzás
int[] szamok = new int[5];
//értékadás
szamok[0] = 10;
szamok[1] = 20;
//inicializáció egyből
int[] szamok2 = { 1, 2, 3, 4, 5 };
Console.WriteLine(szamok2[1]);
Console.WriteLine(string.Join(",", szamok2));
Console.WriteLine(szamok.GetType());

//lista létrehozzás
List<int>szamok3=new List<int>();
szamok3.Add(10);
szamok3.Add(20);
//inicializálás elemekkel
List<int> szamok4 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine(szamok4[0]);
Console.WriteLine(string.Join(",", szamok4));
Console.WriteLine(szamok4.GetType()); //Kiirja a számokról hogy milyen típus (GetType)   
*/
/*//Legnagyobb elem kiválasztása
int[] szamok2 = { 1, 12, 3, 4, 5, 9 };
int max1 = szamok2.Max();
int max2 = szamok2[0];
foreach (int szam in szamok2)
{
    if (szam > max2)
    {
        max2 = szam;
    }
}
Console.WriteLine(max1);
Console.WriteLine(max2);
*/
//összeg kiszámolásá
int[] szamok2 = { 1, 12, 3, 4, 5, 9 };
int sum1=szamok2.Sum();
int sum2 = 0;
foreach (int szam in szamok2)
{
    sum2 +=szam;
}
Console.WriteLine(sum1);
Console.WriteLine(sum2);