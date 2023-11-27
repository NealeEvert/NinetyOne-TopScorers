using Microsoft.Extensions.DependencyInjection;
using TopScorers.interfaces;
using TopScorers.services;

namespace TopScorers.infrastructure
{
    public static class Container
    {
        private static readonly ServiceCollection? services;

        public static ServiceProvider Services
        {
            get
            {
                if (services == null)
                {
                    var services = new ServiceCollection();

                    services.AddSingleton<ILogger, Logger>();
                    services.AddSingleton<IDataReader, DataReader>();

                    return services.BuildServiceProvider();
                }

                return services.BuildServiceProvider();
            }
        }

    }
}