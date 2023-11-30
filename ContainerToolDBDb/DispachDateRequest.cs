using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public partial class DispachDateRequest
{
    public int Id { get; set; }

    public string Information { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string Annotation { get; set; } = null!;

    public virtual ICollection<ArticlesInDispatchRequest> ArticlesInDispatchRequests { get; } = new List<ArticlesInDispatchRequest>();
}
