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

        public IEnumerable<string> ReadFile(string filepath, string filename)
        {
            _logger.Log("Reading file");

            var fullpath = string.Format("{0}{1}", filepath, filename);
            if (File.Exists(fullpath))
            {
                return File.ReadLines(fullpath);
            }
            else {
                throw new FileNotFoundException(string.Format("File not found: {0}", fullpath));
            }
        }

        public IEnumerable<string> StreamFile(string filepath, string filename)
        {
            _logger.Log("Streaming file");

            var fullpath = string.Format("{0}{1}", filepath, filename);
            if (File.Exists(fullpath))
            {
                StreamReader reader = new("file.txt");
                string? line;
                while ((line = reader.ReadLine())
                    != null) {
                    yield return line;
                }
                reader.Close();
            }
            else {
                throw new FileNotFoundException(string.Format("File not found: {0}", fullpath));
            }
        }
    }
}