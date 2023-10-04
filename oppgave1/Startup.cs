using Microsoft.Extensions.DependencyInjection;
using oppgave1.Database;

namespace oppgave1;

public static class Startup
{
    // Legger til klasser for bruk i dependency injection
    public static void ConfigureServices(IServiceCollection services)
    {
        // TODO: Legg til Database.Database når noen spør om IDatabase
        services.AddTransient<??, ??>();
    }
}