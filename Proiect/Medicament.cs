using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proiect
{
    public class Medicament
    {   
        public string numeMedicament { get; set; }
        public string tipMedicament { get; set; }
        public uint pret { get; set; }
        public DateTime dataExpirare { get; set; }

        public Medicament()
        {
            numeMedicament = tipMedicament =  String.Empty;
            pret = 0;
        }

        public Medicament(string numeMedicament,string tipMedicament, uint pret, DateTime dataExpirare)
        {
            this.numeMedicament = numeMedicament;
            this.tipMedicament = tipMedicament;
            this.pret = pret;
            this.dataExpirare = dataExpirare;
        }

        public override string ToString()
        {
            return $"Medicamentul {numeMedicament} ,de tipul {tipMedicament} are pretul de {pret} si expira la data de {dataExpirare}.";
        }
    }
}
