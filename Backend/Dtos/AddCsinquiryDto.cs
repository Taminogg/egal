using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public class AddCsinquiryDto
{
    [Required] public string Container { get; set; } = null!;
    [Required] public string FastLine { get; set; } = null!;
    [Required] public string DirectLine { get; set; } = null!;
    [Required] public string ArticleNumber { get; set; } = null!;
    [Required] public int Palletamount { get; set; }
    [Required] public string Customer { get; set; } = null!;
    [Required] public int Abnumber { get; set; }
    [Required] public int BruttoWeightInKg { get; set; }
    [Required] public string Incoterm { get; set; } = null!;
    [Required] public int ContainersizeA { get; set; }
    [Required] public int ContainersizeB { get; set; }
    [Required] public int ContainersizeHc { get; set; }
    [Required] public bool FreeDetention { get; set; }
    [Required] public bool Thctb { get; set; }
    [Required] public DateTime ReadyToLoad { get; set; }
    [Required] public string LoadingPlattform { get; set; } = null!;
}
