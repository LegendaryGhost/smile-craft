using System;
using System.Collections.Generic;

namespace smile_craft.Models;

public partial class Tooth
{
    public int IdTooth { get; set; }

    public string Location { get; set; } = null!;

    public int IdCategory { get; set; }

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual ICollection<Perform> Performs { get; set; } = new List<Perform>();

    public virtual ICollection<State> States { get; set; } = new List<State>();

    public virtual ICollection<ToothStateHistory> ToothStateHistories { get; set; } = new List<ToothStateHistory>();
}
