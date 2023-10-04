using Microsoft.Extensions.DependencyInjection;
using oppgave2.løsning.Database;
using oppgave2.løsning.Repository;
using oppgave2.løsning.Service;

namespace oppgave2.løsning;

public static class Startup
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IPersonService, PersonService>();
        services.AddTransient<IPersonRepository, PersonRepository>();
        services.AddTransient<IBetalingsRepository, BetalingsRepository>();
        services.AddSingleton<IDatabase, Database.Database>();
    }
}