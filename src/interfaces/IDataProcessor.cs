using TopScorers.entities;

namespace TopScorers.interfaces
{
    public interface IDataProcessor
    {
        IEnumerable<StudentMarks> ProcessData(IEnumerable<string> data);

        IEnumerable<StudentMarks> ProcessData(string filepath, string filename);
    }
}
    