using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public partial class Conversation
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public virtual ICollection<MessageConversation> MessageConversations { get; } = new List<MessageConversation>();

    public virtual Order Order { get; set; } = null!;
}
