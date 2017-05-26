using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Szachy
{
    
    
    
    abstract class Figura : Pozycja
    {
       

        public string Nazwa;
        public string Pozycja;
        public string Kolor;

       

        

        public abstract bool CzyMozePrzesunac(string pozycja);
        public override string ToString()
        {
            return Nazwa;
        }

        void Przesun(bool przesun, string pozycja)
        {
            this.Pozycja = (przesun) ? pozycja : this.Pozycja;
        }

        
        

        public void przesuniecie(bool x)
        {
            if (x==true)
                Console.Write("przesunęło się");
            else Console.Write("Nie przesunęło się");
        }

    
        
    }
}
