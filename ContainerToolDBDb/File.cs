using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public partial class File
{
    public int Id { get; set; }

    public string Path { get; set; } = null!;

    public virtual ICollection<Message> Messages { get; } = new List<Message>();
}
