using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smile_craft.Models
{
    public class PatientSummary
    {
        public int IdPatient { get; set; }
        public string Fristname { get; set; }
        public string Lastname { get; set; }
        public DateOnly? Birthday { get; set; }

        public PatientSummary(int idPatient, string fristname, string lastname, DateOnly? birthday)
        {
            IdPatient = idPatient;
            Fristname = fristname;
            Lastname = lastname;
            Birthday = birthday;
        }
    }

}
