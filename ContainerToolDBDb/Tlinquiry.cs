using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public partial class Tlinquiry
{
    public int Id { get; set; }

    public int InquiryNumber { get; set; }

    public string Sped { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string AcceptingPort { get; set; } = null!;

    public DateTime ExpectedRetrieveWeek { get; set; }

    public int WeightInKg { get; set; }

    public DateTime InvoiceOn { get; set; }

    public DateTime RetrieveDate { get; set; }

    public bool IsContainer40 { get; set; }

    public bool IsContainerHc { get; set; }

    public string RetrieveLocation { get; set; } = null!;

    public int DebtCapitalGeneralForerunEur { get; set; }

    public int DebtCapitalMainDol { get; set; }

    public int DebtCapitalTrailingDol { get; set; }

    public string PortOfDeparture { get; set; } = null!;

    public DateTime Ets { get; set; }

    public DateTime Eta { get; set; }

    public string Boat { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
