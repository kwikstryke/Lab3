using Lab1.Szachy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia.Szachy
{
    static class Pomoc
    {
        public static void Ilosc_figur(this Szachownica szachownica)
        {
            int x = 0;
            foreach (var figura in szachownica.Tablica)
            {
                if(figura!=0)
                {
                    x++;
                }
            }Console.WriteLine(x);
            Console.ReadKey();
        }
    
    }
}
