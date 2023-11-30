using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public partial class Plant
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Stsarticle> Stsarticles { get; } = new List<Stsarticle>();
}
