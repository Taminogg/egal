using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public partial class Order
{
    public int Id { get; set; }

    public int Status { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public bool Approved { get; set; }

    public int Amount { get; set; }

    public DateTime LastUpdated { get; set; }

    public int ChecklistId { get; set; }

    public int Csid { get; set; }

    public int Tlid { get; set; }

    public virtual Checklist Checklist { get; set; } = null!;

    public virtual ICollection<Conversation> Conversations { get; } = new List<Conversation>();

    public virtual Csinquiry Cs { get; set; } = null!;

    public virtual Tlinquiry Tl { get; set; } = null!;
}
