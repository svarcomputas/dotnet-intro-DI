namespace FellesEntiteter;

public class PersonBetalingsOppsummering
{
    public Person Person { get; set; } = default!;

    public BetalingsOppsummering BetalingsOppsummering { get; set; } = default!;

    public override string ToString()
    {
        return Person.ToString() + '\n' + BetalingsOppsummering.ToString();
    }
}
