using FellesEntiteter;

namespace oppgave2.Extensions
{
    public static class BetalingExtensions
    {
        public static BetalingsOppsummering TilOppsummeringForSisteXDager(this List<Betaling> betalinger, int dager)
        {
            var betalingerSistDager = betalinger.Where(betaling => betaling.Dato > DateTime.Now.AddDays(-dager)).ToList();
            return new BetalingsOppsummering()
            {
                SisteDager = dager,
                TotaltInnPåKontoer = betalingerSistDager.SummerPåType(BetalingsType.InnPåKontoer),
                TotaltUtFraKontoer = betalingerSistDager.SummerPåType(BetalingsType.UtFraKontoer),
                TotaltOverførtEgneKontoer = betalingerSistDager.SummerPåType(BetalingsType.OverføringEgneKontoer)
            };
        }

        public static double SummerPåType(this List<Betaling> betalinger, BetalingsType type)
            => betalinger
                .Where(betaling => betaling.BetalingsType == type)
                .Select(betaling => betaling.Beløp).Sum();
    }
}
