using TopScorers.interfaces;
using TopScorers.infrastructure;
using Microsoft.Extensions.DependencyInjection;
using TopScorers.entities;
using System.Collections;

namespace TopScorers.services
{
    public class DataProcessor : IDataProcessor
    {
        IDataReader _reader;
        ILogger _logger;

        public DataProcessor() {
            _reader = Container.Services.GetService<IDataReader>();
            _logger = Container.Services.GetService<ILogger>();
        }

        public DataProcessor(ILogger logger, IDataReader reader) {
            _reader = reader ?? Container.Services.GetService<IDataReader>();
            _logger = logger ?? Container.Services.GetService<ILogger>();
        }

        //TODO: Check size of file to stream the data and process line by line instead of adding to memory
        public IEnumerable<StudentMarks> ProcessData(IEnumerable<string> data)
        {
            _logger.Log("Processing Data");            

            //TODO: Error handling if data is not in the correct format
            foreach (var line in data)
            {
                yield return new StudentMarks 
                { 
                    FirstName = line.Split(",")[0], 
                    SecondName = line.Split(",")[1], 
                    Score = int.Parse(line.Split(",")[2])
                };
            }
        }

        //TODO: Check size of file to stream the data and process line by line instead of adding to memory
        public IEnumerable<StudentMarks> ProcessData(string filepath, string filename)
        {
            _logger.Log("Processing Data from file name");       
            var data = _reader.ReadFile(filepath, filename);

            return ProcessData(data);
        }
    }
}