namespace TopScorers.interfaces
{
    public interface IDataReader
    {
        //Read the full contents of a file from the file path and name. Returns the full contents of the file as a string
        string ReadFile(string filepath, string filename);

        //Read the full contents of a file from a file. Returns the full contents of the file as a string
        string ReadFile(FileInfo file);

        //Read the full contents of a file from the file path and name. Returns the contents as a stream to be read in chunks
        StreamReader StreamFile(string filepath, string filename);

        //Read the full contents of a file from a file. eturns the contents as a stream to be read in chunks
        StreamReader StreamFile(FileInfo file);
    }
}