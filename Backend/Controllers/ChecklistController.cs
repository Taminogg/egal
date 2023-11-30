using TippsBackend.Services;

namespace TippsBackend.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class ChecklistController : ControllerBase
{
    private readonly ChecklistService _checklistService;
    public ChecklistController(ChecklistService checklistService) => _checklistService = checklistService;

    [HttpGet("GetAllChecklists")]
    public List<ChecklistDto> GetAllChecklists()
    {
        return _checklistService.GetAllChecklists();
    }

    [HttpGet("GetChecklistWithId/{id}")]
    public ChecklistDto GetChecklistWithId(int id)
    {
        return _checklistService.GetChecklistWithId(id);
    }

    [HttpPost("AddNewChecklist")]
    public ChecklistDto AddNewChecklist(AddChecklistDto addChecklistDto)
    {
        return _checklistService.AddChecklist(addChecklistDto);
    }

    [HttpPut("EditChecklist")]
    public ChecklistDto EditChecklist(ChecklistDto checklistDto)
    {
        return _checklistService.EditChecklíst(checklistDto);
    }

    [HttpDelete("DeleteChecklist")]
    public ChecklistDto DeleteChecklist(int id)
    {
        return _checklistService.DeleteChecklist(id);
    }
}
