using Microsoft.Extensions.DependencyInjection;
using oppgave1Løsning.Database;

namespace oppgave1Løsning;

public static class Startup
{
    // Legger til klasser for bruk i dependency injection
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IDatabase, Database.Database>();
    }
}