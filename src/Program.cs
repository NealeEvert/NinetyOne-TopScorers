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
            var reader = Container.Services.GetService<IDataReader>();
            if (reader != null)
               reader.ReadFile(AppDomain.CurrentDomain.BaseDirectory, @"data\TestData.csv");
            

        }
    }
}
