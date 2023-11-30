using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public partial class PlanningSt
{
    public int Id { get; set; }

    public string Information { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string Annotation { get; set; } = null!;
}
