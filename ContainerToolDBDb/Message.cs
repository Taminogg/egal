using System;
using System.Collections.Generic;

namespace ContainerToolDBDb;

public partial class Message
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public int AttachmentId { get; set; }

    public DateTime DateTime { get; set; }

    public virtual File Attachment { get; set; } = null!;

    public virtual ICollection<MessageConversation> MessageConversations { get; } = new List<MessageConversation>();
}
