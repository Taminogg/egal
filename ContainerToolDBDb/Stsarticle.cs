using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public partial class Stsarticle
{
    public int Id { get; set; }

    public DateTime ArrivalDate { get; set; }

    public string Info { get; set; } = null!;

    public int PlantId { get; set; }

    public string Jet { get; set; } = null!;

    public int Productioninquiry { get; set; }

    public int Planinquiry { get; set; }

    public virtual Plant Plant { get; set; } = null!;
}
