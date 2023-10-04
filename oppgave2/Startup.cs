using Microsoft.Extensions.DependencyInjection;
using oppgave2.Database;
using oppgave2.Repository;
using oppgave2.Service;

namespace oppgave2;

public static class Startup
{
    /* 
     * TODO:
     * Legg til PersonService når noen spør om IPersonService
     * Legg til PersonRepository når noen spør om IPersonRepository
     * Legg til BetalingsRepository når noen spør om IBetalingsRepository
     */

    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<??, ??>();
        services.AddTransient<??, ??>();
        services.AddTransient<??, ??>();
        services.AddSingleton<IDatabase, Database.Database>();
    }
}