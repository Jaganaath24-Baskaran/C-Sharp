using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{
    public enum VaccinType
    {
        Covidshield = 1, Covaxin, Sputnic
    }
    class Vaccination
    {
        public VaccinType Vaccinationtype { get; set; }
        private static int count = 1;
        public int Dosage { get; set; }
        public DateTime VaccinatedDate { get; set; }

        public Vaccination(VaccinType vaccintype, DateTime vacinDate)
        {
            this.Vaccinationtype = vaccintype;
            this.VaccinatedDate = vacinDate;
        }

    }
}
