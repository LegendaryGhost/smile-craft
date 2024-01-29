using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smile_craft.Models
{
    public class OperationSummary(int id, string dent, string type, DateOnly date)
    {
        public int Id { get; set; } = id;
        public string Dent { get; set; } = dent;
        public string Type { get; set; } = type;
        public DateOnly Date { get; set; } = date;
    }

}
