using FellesEntiteter;
using Microsoft.Extensions.DependencyInjection;
using oppgave2.løsning.Service;

namespace oppgave2.løsning;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        Startup.ConfigureServices(services);
        // Henter ut en instans av PersonService
        var personService = services
            .BuildServiceProvider()
            .GetRequiredService<IPersonService>();

        KjørOppgave(personService);
    }

    // Fake API kall
    static void KjørOppgave(IPersonService personService){
        Oppgavebeskrivelse.PrintOppgaveBeskrivelse(2);
        var brukerId = "1";

        var personBetalingsOppsummering = personService.HentPersonBetalingsoppsummering(brukerId);
        Console.WriteLine(personBetalingsOppsummering.ToString());
    }
}