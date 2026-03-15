public class AgentRuntime
{
    public async Task<T> Execute<T>(Func<Task<T>> action)
    {
        try
        {
            return await action();
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Runtime error {ex.Message}");
            throw;
        }
    }
}