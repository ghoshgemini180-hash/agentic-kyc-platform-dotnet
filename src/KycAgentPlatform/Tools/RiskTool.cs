namespace KycAgentPlatform.Tools;

public class RiskTool
{
    public int Calculate(string country)
    {
        if (country == "India")
            return 10;

        return 60;
    }
}