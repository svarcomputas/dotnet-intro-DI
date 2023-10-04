using FellesEntiteter;
using oppgave2.Database;

namespace oppgave2.Repository;

public interface IBetalingsRepository
{
    // TODO: Legg til funksjonen HentBetalingerForPersonMedId(string personId) på  interfacet (hint: se på interfacet i IPersonService)
    ?? 
}

public class BetalingsRepository : IBetalingsRepository
{
    private readonly List<Betaling> _alleBetalinger;

    public BetalingsRepository(IDatabase database)
    {
        _alleBetalinger = database.HentAlleBetalinger();
    }

    public List<Betaling> HentBetalingerForPersonMedId(string personId)
    {
        return _alleBetalinger.Where(betaling => betaling.PersonId == personId).ToList();
    }
}