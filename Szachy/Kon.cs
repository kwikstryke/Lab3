using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Szachy
{
    class Kon : Figura
    { 

        public Kon() { }

        public Kon(string nazwa, string pozycja, string kolor)
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
                (((ruch.Y == aktualnaPozycja.Y - 2) || (ruch.Y == aktualnaPozycja.Y + 2)) && ((ruch.X == aktualnaPozycja.X + 1) || (ruch.X == aktualnaPozycja.X - 1))) ||
                (((ruch.X == aktualnaPozycja.X - 2) || (ruch.X == aktualnaPozycja.X + 2)) && ((ruch.Y == aktualnaPozycja.Y + 1) || (ruch.Y == aktualnaPozycja.Y - 1)))
                );
        }

       
    }
}
