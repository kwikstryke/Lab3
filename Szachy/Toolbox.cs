using Lab1.Szachy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia.Szachy
{

    sealed class Toolbox
    {
        private static Szachownica instance1 = new Szachownica();
        private Toolbox()
        {

        }
        static Toolbox()
        {
            
        }
        public static Szachownica SzachownicaInstancja
        {
            get
            {
                return instance1;
            }
        }
    }
}
