namespace ContainerToolDBDb;

public class TlinquiryDto
{
    [Required] public int Id { get; set; }
    [Required] public int InquiryNumber { get; set; }
    [Required] public string Sped { get; set; } = null!;
    [Required] public string Country { get; set; } = null!;
    [Required] public string AcceptingPort { get; set; } = null!;
    [Required] public DateTime ExpectedRetrieveWeek { get; set; }
    [Required] public int WeightInKg { get; set; }
    [Required] public DateTime InvoiceOn { get; set; }
    [Required] public DateTime RetrieveDate { get; set; }
    [Required] public bool IsContainer40 { get; set; }
    [Required] public bool IsContainerHc { get; set; }
    [Required] public string RetrieveLocation { get; set; } = null!;
    [Required] public int DebtCapitalGeneralForerunEur { get; set; }
    [Required] public int DebtCapitalMainDol { get; set; }
    [Required] public int DebtCapitalTrailingDol { get; set; }
    [Required] public string PortOfDeparture { get; set; } = null!;
    [Required] public DateTime Ets { get; set; }
    [Required] public DateTime Eta { get; set; }
    [Required] public string Boat { get; set; } = null!;
}
