using System;
using System.Collections.Generic;

namespace smile_craft.Models;

public partial class Mark
{
    public int IdMark { get; set; }

    public int Mark1 { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<State> States { get; set; } = new List<State>();

    public virtual ICollection<ToothStateHistory> ToothStateHistoryIdNewMarkNavigations { get; set; } = new List<ToothStateHistory>();

    public virtual ICollection<ToothStateHistory> ToothStateHistoryIdOldMarkNavigations { get; set; } = new List<ToothStateHistory>();
}
