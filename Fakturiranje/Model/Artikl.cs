using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakturiranje.Model
{
    public class Artikl
    {
        public List<Artikl> ArtikliList { get; set; }

        public int IDArtikl { get; set; }
        public string Flag { get; set; }
        public string Sifra { get; set; }
        public string Barkod { get; set; }
        public string Naziv { get; set; }
        public string JM { get; set; }
        public decimal TB { get; set; }
        public decimal MPC { get; set; }
        public decimal VPC { get; set; }
        public decimal NC { get; set; }
        public decimal Zalihe { get; set; }
        public int RG { get; set; }
        public int Kalo { get; set; }
    }
}
