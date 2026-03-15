using Microsoft.AspNetCore.Mvc;
using KycAgentPlatform.Agents;
using KycAgentPlatform.Services;

namespace KycAgentPlatform.Api;

[ApiController]
[Route("api/kyc")]
public class KycController : ControllerBase
{
    private readonly IdentityAgent _identity;
    private readonly RiskAgent _risk;
    private readonly FraudAgent _fraud;
    private readonly OcrService _ocr;

    public KycController(
        IdentityAgent identity,
        RiskAgent risk,
        FraudAgent fraud,
        OcrService ocr)
    {
        _identity = identity;
        _risk = risk;
        _fraud = fraud;
        _ocr = ocr;
    }

    [HttpPost]
    public IActionResult Verify([FromBody] string document)
    {
        // Step 1: OCR extracts text
        var text = _ocr.ExtractText(document);

        // Step 2: Identity extraction
        var customer = _identity.Extract(text);

        // Step 3: Fraud check
        if (_fraud.Check(customer))
            return Ok("Fraud detected");

        // Step 4: Risk calculation
        var risk = _risk.Calculate(customer);

        if (risk > 50)
            return Ok("Manual Review");

        return Ok("Approved");
    }
}