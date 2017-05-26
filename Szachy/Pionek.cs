using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1.Szachy
{
    class Pionek : Figura
    {
        
            
        public Pionek() { }

        public Pionek(string nazwa, string pozycja, string kolor)
        {
            this.Nazwa = nazwa;
            this.Pozycja = pozycja;
            this.Kolor = kolor;
        }

       

        

        public override bool CzyMozePrzesunac(string pozycja)
        {
            var szachownica = new Szachownica();
            var ruch = new Pozycja(pozycja.ToUpper());
            var aktualnaPozycja = new Pozycja(this.Pozycja.ToUpper());

            return(
                (this.Pozycja != pozycja) &&
                ((ruch.X > 0) && (ruch.X <= 8) && (ruch.Y > 0) && (ruch.Y < 8)) &&
                (ruch.X == aktualnaPozycja.X && ruch.Y == aktualnaPozycja.Y + 1)
                );
        }

        
    }
}
