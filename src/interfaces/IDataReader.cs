namespace TopScorers.interfaces
{
    public interface IDataReader
    {
        //Read the full contents of a file from the file path and name. Returns the full contents of the file as a string
        IEnumerable<string> ReadFile(string filepath, string filename);

        //Read the full contents of a file from the file path and name. Returns the contents as a stream to be read in chunks
        IEnumerable<string> StreamFile(string filepath, string filename);
    }
}