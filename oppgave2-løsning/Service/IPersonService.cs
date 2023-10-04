using FellesEntiteter;
using oppgave2.løsning.Extensions;
using oppgave2.løsning.Repository;

namespace oppgave2.løsning.Service;

public interface IPersonService
{
    public PersonBetalingsOppsummering HentPersonBetalingsoppsummering(string personId); 
}

public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;
    private readonly IBetalingsRepository _betalingsRepository;

    public PersonService(IPersonRepository personRepository, IBetalingsRepository betalingsRepository)
    {
        _personRepository = personRepository;
        _betalingsRepository = betalingsRepository;
    }

    public PersonBetalingsOppsummering HentPersonBetalingsoppsummering(string personId)
    {
        var person = _personRepository.HentPersonMedId(personId);
        var betalinger = _betalingsRepository.HentBetalingerForPersonMedId(personId);
        var oppsummering = betalinger.TilOppsummeringForSisteXDager(30);
        return new PersonBetalingsOppsummering
        {
            Person = person,
            BetalingsOppsummering = oppsummering
        };
    }
}
