using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartkowka3
{
    public class Zdjecie
    {
        public string sciezka {get; set;}
        public int liczbaWyswietlen {get; set;}

        public Zdjecie(string sciezka)
        {
            this.sciezka = sciezka;
            this.liczbaWyswietlen = 0;
        }
    }
}
