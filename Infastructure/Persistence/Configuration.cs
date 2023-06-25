
using Microsoft.Extensions.Configuration;

namespace Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                try
                {
                    configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/MainWeb"));
                    configurationManager.AddJsonFile("appsettings.json");
                }
                catch (Exception)
                {
                    configurationManager.AddJsonFile("appsettings.Production.json");
                }
                return configurationManager.GetConnectionString("PostgreSql");
            }
        } 
    }
}
