using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public partial class ArticlesInDispatchRequest
{
    public int Id { get; set; }

    public int DispachDateRequestId { get; set; }

    public DateTime DispachDate { get; set; }

    public string Articlenumber { get; set; } = null!;

    public bool MinLotSize { get; set; }

    public int AmountNeeded { get; set; }

    public DateTime Neededby { get; set; }

    public bool FixOrder { get; set; }

    public bool AskedDeal { get; set; }

    public virtual DispachDateRequest DispachDateRequest { get; set; } = null!;
}
