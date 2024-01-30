using System;
using System.Collections.Generic;

namespace smile_craft.Models;

public partial class State
{
    public int IdPatient { get; set; }

    public int IdTooth { get; set; }

    public int IdMark { get; set; }

    public virtual Mark IdMarkNavigation { get; set; } = null!;

    public virtual Patient IdPatientNavigation { get; set; } = null!;

    public virtual Tooth IdToothNavigation { get; set; } = null!;
}
