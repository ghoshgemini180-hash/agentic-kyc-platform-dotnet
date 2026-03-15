using KycAgentPlatform.Services;

namespace KycAgentPlatform.Agents;

public class FraudAgent
{
    private readonly FraudService _fraudService;

    public FraudAgent(FraudService fraudService)
    {
        _fraudService = fraudService;
    }

    public bool Check(CustomerKycData customer)
    {
        return _fraudService.CheckFraud(customer.Pan);
    }
}