using System;
using System.Collections.Generic;

namespace smile_craft.Models;

public partial class Operation
{
    public int IdOperation { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Perform> Performs { get; set; } = new List<Perform>();

    public virtual ICollection<Price> Prices { get; set; } = new List<Price>();
}
