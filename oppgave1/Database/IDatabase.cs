using FellesEntiteter;

namespace oppgave1.Database;

public interface IDatabase
{
    public Person HentPersonMedId(string personId);
}

public class Database : IDatabase
{
    private readonly List<Person> personer = new List<Person>()
    {
        new Person(){ Id = "1", Fornavn = "Roy", Etternavn = "Roysen" },
        new Person(){ Id = "2", Fornavn = "Ingrid", Etternavn = "Ingridsen" }
    };
    
    // TODO: fullfør implementasjonen av interfacet ved å legge til HentPersonMedId
    // som skal returnere personen fra listen med personId som blir sendt inn
    // Hint: Bruk where og first
    
}
