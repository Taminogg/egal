using TippsBackend.Services;

namespace TippsBackend.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class ConversationController : ControllerBase
{
    private readonly ConversationService _conversationService;
    public ConversationController(ConversationService conversationService) => _conversationService = conversationService;

    [HttpGet("GetAllConversations")]
    public List<ConversationDto> GetAllConversations()
    {
        return _conversationService.GetAllConversations();
    }

    [HttpGet("GetConversationWithId/{id}")]
    public ConversationDto GetConversationWithId(int id)
    {
        return _conversationService.GetConersationWithId(id);
    }

    [HttpPost("AddNewConversation")]
    public ConversationDto AddNewConversation(AddConversationDto addConversationDto)
    {
        return _conversationService.AddConversation(addConversationDto);
    }

    [HttpDelete("DeleteConversation")]
    public ConversationDto DeleteConversation(int id)
    {
        return _conversationService.DeleteConversaion(id);
    }
}
