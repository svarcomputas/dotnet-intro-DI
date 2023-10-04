using FellesEntiteter;
using Microsoft.Extensions.DependencyInjection;

namespace oppgave1;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        // Kall til startup for å legge inn dependecy injections
        Startup.ConfigureServices(services);
        // Henter ut en instans av PersonRepository
        var personRepo = services
            .AddTransient<PersonRepository, PersonRepository>()
            .BuildServiceProvider()
            .GetRequiredService<PersonRepository>();

        KjørOppgave(personRepo);
    }

    static void KjørOppgave(PersonRepository personRepo){
        Oppgavebeskrivelse.PrintOppgaveBeskrivelse(1);
        var brukerId = "2";

        var person = personRepo.HentPersonMedId(brukerId);
        Console.WriteLine(person.ToString());
    }
}