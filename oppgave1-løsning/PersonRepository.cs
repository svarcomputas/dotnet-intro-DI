using FellesEntiteter;
using oppgave1Løsning.Database;

namespace oppgave1Løsning;

class PersonRepository
{
    IDatabase _database;

    public PersonRepository(IDatabase database){
        _database = database;
    }

    public Person HentPersonMedId(string id)
    {
        return _database.HentPersonMedId(id);
    }
}