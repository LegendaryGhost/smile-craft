using System;
using System.Collections.Generic;

namespace smile_craft.Models;

public partial class PersonalizedCategory
{
    public int IdPersoCategory { get; set; }

    public string PersoCategoryName { get; set; } = null!;

    public virtual ICollection<Tooth> Teeth { get; set; } = new List<Tooth>();
}
