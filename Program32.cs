using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<object>>Sutes=new List<List<object>>();
            string sutees = "";
            foreach (string sor in File.ReadLines(sutees))
            {
                string[] hozzavalok = sor.Trim().Split('');
                List<object> hozzavalo = new List<object>();
                hozzavalo.Add(int.Parse(hozzavalok[0]));
                hozzavalo.Add(int.Parse(hozzavalok[1]));
                hozzavalo.Add(int.Parse(hozzavalok[2]));
                hozzavalo.Add(int.Parse(hozzavalok[3]));
                hozzavalo.Add(hozzavalok[4]);
                Sutes.Add(hozzavalo);
            }
        }
    }
}
