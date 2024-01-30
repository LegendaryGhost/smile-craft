using System;
using System.Collections.Generic;

namespace smile_craft.Models;

public partial class Price
{
    public int IdOperation { get; set; }

    public int IdCategory { get; set; }

    public int Price1 { get; set; }

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Operation IdOperationNavigation { get; set; } = null!;
}
