using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakturiranje.Model
{
    public class Kupac
    {
        public List<Kupac> Kupci { get; set; }

        public int IDKupac { get; set; }
        public string Flag { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string OIB { get; set; }
        public string Mjesto { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string  Telefax { get; set; }
        public string Mobitel { get; set; }
        public string Mail { get; set; }
        public string Kontakt { get; set; }
        public int Rabat { get; set; }

        public Kupac()
        {
            
        }
    }
}
