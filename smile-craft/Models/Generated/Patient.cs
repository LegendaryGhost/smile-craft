using System;
using System.Collections.Generic;

namespace smile_craft.Models;

public partial class Patient
{
    public int IdPatient { get; set; }

    public string Fristname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public DateOnly? Birthday { get; set; }

    public virtual ICollection<Perform> Performs { get; set; } = new List<Perform>();

    public virtual ICollection<State> States { get; set; } = new List<State>();

    public virtual ICollection<ToothStateHistory> ToothStateHistories { get; set; } = new List<ToothStateHistory>();
}
