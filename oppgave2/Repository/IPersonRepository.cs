using FellesEntiteter;
using oppgave2.Database;

namespace oppgave2.Repository;

public interface IPersonRepository
{
    // TODO: Legg til funksjonen  HentPersonMedId(string Id) på interfacet (hint: se på interfacet i IPersonService)
    ??
}

public class PersonRepository : IPersonRepository
{
    private readonly List<Person> _allePersoner;

    public PersonRepository(IDatabase database)
    {
        _allePersoner = database.HentAllePersoner();
    }

    public Person HentPersonMedId(string Id)
    {
        var person = _allePersoner.Where(person => person.Id == Id).FirstOrDefault();
        if(person == null)
        {
            throw new ArgumentException($"Finner ingen person med {Id}");
        }

        return person;
    }
}