using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public partial class StepChecklist
{
    public int Id { get; set; }

    public int ChecklistId { get; set; }

    public int StepId { get; set; }

    public virtual Checklist Checklist { get; set; } = null!;

    public virtual Step Step { get; set; } = null!;
}
