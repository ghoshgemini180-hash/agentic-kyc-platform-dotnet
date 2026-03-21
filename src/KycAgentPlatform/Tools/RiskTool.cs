namespace KycAgentPlatform.Tools;

public class RiskTool
{
    public int Calculate(string country)
    {
        return country == "India" ? 10 : 60;
    }
}