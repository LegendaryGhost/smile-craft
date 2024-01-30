using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smile_craft.Models
{
    public class ToothStateSummary(int idTooth, int idPatient, int mark, int idMark, string firstname, string lastname, string designation)
    {

        public int IdTooth { get; set; } = idTooth;
        public int IdPatient { get; set; } = idPatient;
        public int Mark { get; set; } = mark;
        public int IdMark { get; set; } = idMark;
        public string Firstname { get; set; } = firstname;
        public string Lastname { get; set; } = lastname;
        public string Designation { get; set; } = designation;
    }

}
