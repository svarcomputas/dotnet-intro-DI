namespace FellesEntiteter;

public class BetalingsOppsummering
{
    public int SisteDager { get; set; }

    public double TotaltInnPåKontoer { get; set; }

    public double TotaltUtFraKontoer { get; set; }

    public double TotaltOverførtEgneKontoer { get; set; }

    public override string ToString()
    {
        return @$"Betlaingsoppsummering for de siste {SisteDager} dagene:
Totalt inn på kontoer:               {TotaltInnPåKontoer}
Totalt ut fra kontoer:               {TotaltUtFraKontoer}
Totalt overført mellom egne kontoer: {TotaltOverførtEgneKontoer}";
    }
}
