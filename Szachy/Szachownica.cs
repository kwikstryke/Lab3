using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Szachy
{
    class Szachownica
    {
        public int[,] Tablica = new int[,]
        {
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0}
        };
        public bool CzyZajetePole(int x, int y)
        
        {
            if (Tablica[x, y] != 0)
                return false ;
            else
                return true ;

        }
        public bool ustaw(int x, int y)
        {
            if(CzyZajetePole(x,y))
            {
                Tablica[x, y] = 1;
                return true;
               
            }else
            {
                return false;
            }

            
        }
    

    }
}
