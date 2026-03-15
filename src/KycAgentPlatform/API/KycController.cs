using Microsoft.AspNetCore.Mvc;
using KycAgentPlatform.Agents;

namespace KycAgentPlatform.Api;

[ApiController]
[Route("api/kyc")]
public class KycController : ControllerBase
{
    private readonly IdentityAgent _identityAgent;
    private readonly RiskAgent _riskAgent;

    public KycController(
        IdentityAgent identityAgent,
        RiskAgent riskAgent)
    {
        _identityAgent = identityAgent;
        _riskAgent = riskAgent;
    }

    [HttpPost]
    public IActionResult Verify([FromBody] string document)
    {
        var customer = _identityAgent.Extract(document);

        var risk = _riskAgent.Calculate(customer);

        if (risk > 50)
            return Ok("Manual Review");

        return Ok("Approved");
    }
}