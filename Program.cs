using System;
using Lab1.Szachy;

namespace Lab1
{
    class Program
    {
        public delegate bool Zmiana(int x,int y);
        static void Main(string[] args)
        {
            Szachownica szachownica = new Szachownica();

            Figura pionek = new Pionek("Pionek", "B5", "Bialy");
            Console.WriteLine(pionek.ToString());
            Console.WriteLine(pionek.CzyMozePrzesunac("b5"));

            Figura krol = new Krol("Król", "C4", "Czarny");
            Console.WriteLine(krol.ToString());
            Console.WriteLine(krol.CzyMozePrzesunac("F4"));

            Figura wieza = new Wieza("Wieża", "C2", "Bialy");
            Console.WriteLine(wieza.ToString());
            Console.WriteLine(wieza.CzyMozePrzesunac("G2"));

            Figura skoczek = new Kon("Skoczek", "D4", "Czarny");
            Console.WriteLine(skoczek.ToString());
            Console.WriteLine(skoczek.CzyMozePrzesunac("H4"));
            Zmiana delegata = szachownica.ustaw;
            skoczek.przesuniecie(delegata(1,4));

        }
        

    }

}
