using KycAgentPlatform.Tools;

namespace KycAgentPlatform.Agents;

public class RiskAgent
{
    private readonly RiskTool _riskTool;

    public RiskAgent(RiskTool riskTool)
    {
        _riskTool = riskTool;
    }

    public int Calculate(CustomerKycData customer)
    {
        return _riskTool.Calculate(customer.Country);
    }
}