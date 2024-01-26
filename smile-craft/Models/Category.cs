using System;
using System.Collections.Generic;

namespace smile_craft.Models;

public partial class Category
{
    public int IdCategory { get; set; }

    public string Designation { get; set; } = null!;

    public virtual ICollection<Price> Prices { get; set; } = new List<Price>();

    public virtual ICollection<Tooth> Teeth { get; set; } = new List<Tooth>();
}
