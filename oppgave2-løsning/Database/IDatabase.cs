using FellesEntiteter;

namespace oppgave2.løsning.Database;

public interface IDatabase
{
    public List<Person> HentAllePersoner();
    public List<Betaling> HentAlleBetalinger();
}

public class Database : IDatabase
{
    public List<Betaling> HentAlleBetalinger()
        => new List<Betaling>()
        {
            NyBetaling("1", 1000),
            NyBetaling("1", 5000, BetalingsType.UtFraKontoer, DateTime.Now.AddDays(-3)),
            NyBetaling("1", 5000, BetalingsType.OverføringEgneKontoer, DateTime.Now.AddDays(-5)),
            NyBetaling("1", 10000, BetalingsType.InnPåKontoer, DateTime.Now.AddDays(-7)),
            NyBetaling("1", 303.3, BetalingsType.UtFraKontoer, DateTime.Now.AddDays(-10)),
            NyBetaling("2", 4000.4, BetalingsType.InnPåKontoer, DateTime.Now.AddDays(-12)),
            NyBetaling("1", 1000, BetalingsType.UtFraKontoer, DateTime.Now.AddDays(-100))
        };

    public List<Person> HentAllePersoner()
    {
        return new List<Person>()
        {
            new Person() { Id = "1", Fornavn = "Roy", Etternavn = "Roysen" },
            new Person() { Id = "2", Fornavn = "Ingrid", Etternavn = "Ingridsen"}
        };
    }

    private static Betaling NyBetaling(string personId, double beløp, BetalingsType type = BetalingsType.InnPåKontoer, DateTime? dato = null)
        => new Betaling()
        {
            PersonId = personId,
            Beløp = beløp,
            BetalingsType = type,
            Dato = dato ?? DateTime.Now
        };
}
