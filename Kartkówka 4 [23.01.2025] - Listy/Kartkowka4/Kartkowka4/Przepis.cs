using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartkowka4
{
    public class Przepis
    {
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public string Skladniki { get; set; }
        public int NaIleOsob {  get; set; }
        public bool CzyBezglutenowe { get; set; }

        public Przepis(string nazwa, string kategoria, string skladniki, int naIleOsob, bool czyBezglutenowe)
        {
            Nazwa = nazwa;
            Kategoria = kategoria;
            Skladniki = skladniki;
            NaIleOsob = naIleOsob;
            CzyBezglutenowe = czyBezglutenowe;
        }
    }
}
