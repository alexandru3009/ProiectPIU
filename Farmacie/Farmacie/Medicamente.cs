using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
    public class Medicamente
    {
        public string numeMedicament { get; set; }
        public string tipMedicament { get; set; }
        //flacon , tableta,plic

        public uint pret { get; set; } 

        public Medicamente()
        {
            numeMedicament = tipMedicament = string.Empty;
            pret = 0;
        }

        public Medicamente(string numeMedicament,string tipMedicament,uint pret)
        {
            this.numeMedicament = numeMedicament;
            this.tipMedicament = tipMedicament;
            this.pret = pret;
        }

        public override string ToString()
        {
            return $"Medicamentul {numeMedicament},de tip {tipMedicament} are pretul {pret}.";
        }
    }
}
