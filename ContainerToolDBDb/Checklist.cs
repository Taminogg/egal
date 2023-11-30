using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public partial class Checklist
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ICollection<StepChecklist> StepChecklists { get; } = new List<StepChecklist>();
}
