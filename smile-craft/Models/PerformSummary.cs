using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smile_craft.Models
{
    public class PerformSummary: Perform
    {
        public string? OperationName { get; set; }
        public string? CategoryName { get; set; }
        public int? CurrentMark { get; set; }
        private int? _price;
        public int? Price
        {
            get => _price;
            set
            {
                _price = value;
                PriceString = _price?.ToString("N2");
            }
        }
        public string? PriceString { get; set; }

        public Perform ToPerform()
        {
            return new()
            {
                IdPatient = IdPatient,
                IdTooth = IdTooth,
                IdOperation = IdOperation
            };
        }
    }
}
