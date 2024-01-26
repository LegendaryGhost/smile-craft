using System;
using System.Collections.Generic;

namespace smile_craft.Models;

public partial class Perform
{
    public int IdPerform { get; set; }

    public int? IdPatient { get; set; }

    public int? IdTooth { get; set; }

    public int? IdOperation { get; set; }

    public DateOnly DateOperation { get; set; }

    public virtual Operation? IdOperationNavigation { get; set; }

    public virtual Patient? IdPatientNavigation { get; set; }

    public virtual Tooth? IdToothNavigation { get; set; }
}
