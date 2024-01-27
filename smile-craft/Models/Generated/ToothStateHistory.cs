using System;
using System.Collections.Generic;

namespace smile_craft.Models;

public partial class ToothStateHistory
{
    public int IdHistory { get; set; }

    public int IdPatient { get; set; }

    public int IdTooth { get; set; }

    public int IdOldMark { get; set; }

    public int IdNewMark { get; set; }

    public DateOnly DateHistory { get; set; }

    public virtual Mark IdNewMarkNavigation { get; set; } = null!;

    public virtual Mark IdOldMarkNavigation { get; set; } = null!;

    public virtual Patient IdPatientNavigation { get; set; } = null!;

    public virtual Tooth IdToothNavigation { get; set; } = null!;
}
