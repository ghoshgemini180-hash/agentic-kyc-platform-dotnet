using KycAgentPlatform.Tools;

namespace KycAgentPlatform.Agents;

public class IdentityAgent
{
    private readonly IdentityTool _identityTool;

    public IdentityAgent(IdentityTool identityTool)
    {
        _identityTool = identityTool;
    }

    public CustomerKycData Extract(string document)
    {
        return _identityTool.Extract(document);
    }
}