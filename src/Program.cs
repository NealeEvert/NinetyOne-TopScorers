using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using TopScorers.infrastructure;
using TopScorers.interfaces;

namespace TopScorers
{
    class Program
    {

        static void Main(string[] args)
        {
            IDataProcessor processor = Container.Services.GetService<IDataProcessor>();
            try
            {
                if (processor == null)
                {
                    throw new Exception(string.Format("{0}: {1}", "Configuration Error", "Data Processor not configured in IoC"));
                }
                var studentMarks = processor.ProcessData(args[0], args[1]);
                var maxMark = studentMarks.MaxBy(m => m.Score);
                foreach (var student in studentMarks.Where(s => s.Score == maxMark.Score))
                {
                    Console.WriteLine("{0} {2}", student.FirstName, student.SecondName);
                }
                Console.WriteLine(maxMark.Score);
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            } 
        }       
    }
}
