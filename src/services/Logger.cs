using TopScorers.interfaces;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

namespace TopScorers.services
{
    public class Logger : ILogger
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Log(string message)
        {
            Console.WriteLine(message);
            logger.Info(message);
        }

        public void Log(string message, Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}