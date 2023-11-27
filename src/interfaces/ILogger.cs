namespace TopScorers.interfaces
{
    public interface ILogger
    {
        //Write a message to the logs
        void Log(string message);

        //Write a, exception message to the logs
        void Log(string message, Exception ex);
    }
}