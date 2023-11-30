using TippsBackend.Services;

namespace TippsBackend.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class CsinquiryController : ControllerBase
{
    private readonly CsinquiryService _csinquiryService;
    public CsinquiryController(CsinquiryService csinquiryService) => _csinquiryService = csinquiryService;

    [HttpGet("GetAllCsinquiries")]
    public List<CsinquiryDto> GetAllCsinquiries()
    {
        return _csinquiryService.GetAllCsinquiries();
    }

    [HttpGet("GetCsinquiryWithId/{id}")]
    public CsinquiryDto GetCsinquiryWithId(int id)
    {
        return _csinquiryService.GetCsinquiryWithId(id);
    }

    [HttpPost("AddNewCsinquiry")]
    public CsinquiryDto AddNewCsinquiry(AddCsinquiryDto addCsinquiryDto)
    {
        return _csinquiryService.AddCsinquiry(addCsinquiryDto);
    }

    [HttpPut("EditCsinquiry")]
    public CsinquiryDto EditCsinquiry(CsinquiryDto editCsinquiry)
    {
        return _csinquiryService.EditCsinquiry(editCsinquiry);
    }

    [HttpDelete("DeleteCsinquiry")]
    public CsinquiryDto DeleteCsinquiry(int id)
    {
        return _csinquiryService.DeleteCsinquiry(id);
    }
}
