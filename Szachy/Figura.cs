using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Szachy
{
    
    
    
    internal abstract class Figura : Pozycja
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
        public static Figura FiguraFactory(string FiguraType)
        {
            switch (FiguraType)
            {
                case "Krol":
                    return new Krol();
                case "Kon":
                    return new Kon();
                case "Pionek":
                    return new Pionek();
                case "Wieza":
                    return new Wieza();
                default:
                    break;
            }
            throw new System.NotSupportedException("nie ma takiej figury");
           
           
        }

    
        
    }
}
