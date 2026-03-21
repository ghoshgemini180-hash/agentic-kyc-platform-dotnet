namespace KycAgentPlatform.Tools;

public class IdentityTool
{
    public CustomerKycData Extract(string document)
    {
        return new CustomerKycData
        {
            Name = "Debangshu",
            Country = "India",
            Pan = "ABCDE1234F"
        };
    }
}