using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Szachy
{
    class Wieza : Figura
    {


        public Wieza() { }

        public Wieza(string nazwa, string pozycja, string kolor)
        {
            this.Nazwa = nazwa;
            this.Pozycja = pozycja;
            this.Kolor = kolor;
        }





        public override bool CzyMozePrzesunac(string pozycja)
        {
            var ruch = new Pozycja(pozycja);
            var aktualnaPozycja = new Pozycja(this.Pozycja);

            return (
                (this.Pozycja != pozycja) &&
                ((ruch.X > 0) && (ruch.X <= 8) && (ruch.Y > 0) && (ruch.Y < 8)) &&
                ((ruch.X != aktualnaPozycja.X) && (ruch.Y == aktualnaPozycja.Y)) ||
                ((ruch.Y != aktualnaPozycja.Y) && (ruch.X == aktualnaPozycja.X))
                );
        }

    }
}
