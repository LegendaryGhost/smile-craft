using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smile_craft.Models
{
    public class ToothStateSummary(int idTooth, int idPatient, int? idMark, int mark)
    {
        public int IdTooth { get; set; } = idTooth;
        public int IdPatient { get; set; } = idPatient;
        public int? IdMark { get; set; } = idMark;
        public int Mark { get; set; } = mark;
    }

}
