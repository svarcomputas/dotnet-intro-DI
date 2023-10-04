namespace FellesEntiteter;

public class Person
{
    public string Id { get; set; } = default!;

    public string Fornavn { get; set; } = default!;

    public string Etternavn { get; set; } = default!;

    public override string ToString()
    {
        return $"{Fornavn} {Etternavn} har personId {Id}";
    }
}
