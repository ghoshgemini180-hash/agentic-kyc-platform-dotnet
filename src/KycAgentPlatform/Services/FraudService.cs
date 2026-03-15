namespace KycAgentPlatform.Services;

public class FraudService
{
    public bool CheckFraud(string pan)
    {
        if (pan == "FAKE1234")
            return true;

        return false;
    }
}