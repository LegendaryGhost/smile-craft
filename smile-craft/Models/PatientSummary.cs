using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smile_craft.Models
{
    public class PatientSummary(int idPatient, string fristname, string lastname, DateOnly? birthday)
    {
        public int IdPatient { get; set; } = idPatient;
        public string Fristname { get; set; } = fristname;
        public string Lastname { get; set; } = lastname;
        public DateOnly? Birthday { get; set; } = birthday;
    }

}
