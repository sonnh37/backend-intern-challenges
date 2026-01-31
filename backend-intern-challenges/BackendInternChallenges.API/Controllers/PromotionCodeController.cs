using BackendInternChallenges.Domain.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendInternChallenges.API.Controllers;

[ApiController]
[Route("api/promotion-codes")]
public class PromotionCodeController : ControllerBase
{
    private readonly IPromotionCodeService _checker;

    public PromotionCodeController(IPromotionCodeService checker)
    {
        _checker = checker;
    }

    [HttpGet("validate")]
    public IActionResult Validate([FromQuery] string code)
    {
        var result = _checker.IsEligible(code);
        return Ok(result);
    }
}
