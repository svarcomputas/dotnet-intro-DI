namespace FellesEntiteter;

public class Betaling
{
    public string? PersonId { get; set; } = default!;

    public BetalingsType BetalingsType { get; set; }

    public double Beløp { get; set; }

    public DateTime Dato { get; set; }
}

public enum BetalingsType
{
    InnPåKontoer = 1,
    UtFraKontoer = 2,
    OverføringEgneKontoer = 3
}
