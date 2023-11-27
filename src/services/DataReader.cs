using Microsoft.Extensions.DependencyInjection;
using TopScorers.infrastructure;
using TopScorers.interfaces;

namespace TopScorers.services
{
    public class DataReader : IDataReader
    {
        readonly ILogger _logger = Container.Services.GetService<ILogger>();
        
        public DataReader() { }
        
        public DataReader(ILogger logger)
        {
            _logger = logger;
        }

        public string ReadFile(string filepath, string filename)
        {
            _logger.Log("Test logging");
            return string.Empty;
        }

        public string ReadFile(FileInfo file)
        {
            throw new NotImplementedException();
        }

        public StreamReader StreamFile(string filepath, string filename)
        {
            throw new NotImplementedException();
        }

        public StreamReader StreamFile(FileInfo file)
        {
            throw new NotImplementedException();
        }
    }
}