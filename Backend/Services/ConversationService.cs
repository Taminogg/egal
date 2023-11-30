using ContainerToolDBDb;

namespace TippsBackend.Services;

public class ConversationService
{
    private readonly ContainerToolDBContext _db;

    public ConversationService(ContainerToolDBContext db) => _db = db;

    public List<ConversationDto> GetAllConversations()
    {
        return _db.Conversations
            .Select(x => new ConversationDto().CopyFrom(x))
            .ToList();
    }

    public ConversationDto GetConersationWithId(int id)
    {
        Conversation conversation = _db.Conversations
            .Single(x => x.Id == id);

        return new ConversationDto().CopyFrom(conversation);
    }

    public ConversationDto AddConversation(AddConversationDto addConversationDto)
    {
        var conversation = new Conversation().CopyFrom(addConversationDto);

        _db.Conversations.Add(conversation);
        _db.SaveChanges();

        return new ConversationDto().CopyFrom(conversation);
    }

    public ConversationDto DeleteConversaion(int id)
    {
        var conversation = _db.Conversations.Single(x => x.Id == id);

        _db.Conversations.Remove(conversation);
        _db.SaveChanges();

        return new ConversationDto().CopyFrom(conversation);
    }
}
