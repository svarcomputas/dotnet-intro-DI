using FellesEntiteter;

namespace oppgave1Løsning.Database;

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

    public Person HentPersonMedId(string personId)
    {
        return personer.Where(person => person.Id == personId).First();
    }
}
