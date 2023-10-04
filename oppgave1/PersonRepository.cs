using FellesEntiteter;
using oppgave1.Database;

namespace oppgave1;

class PersonRepository
{
    // TODO: Bytt ut 'var' (skal det stå IDatabase eller Database?)
    var _database;

    public PersonRepository(var database){
        _database = database;
    }

    public Person HentPersonMedId(string id)
    {
        return _database.HentPersonMedId(id);
    }
}