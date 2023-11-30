using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public partial class MessageConversation
{
    public int Id { get; set; }

    public int MessageId { get; set; }

    public int ConversationId { get; set; }

    public virtual Conversation Conversation { get; set; } = null!;

    public virtual Message Message { get; set; } = null!;
}
