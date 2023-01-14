namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.English.BienDit;

        /// <inheritdoc />
        public string DireBonjour(PériodeJournée moment)
        {
            return moment == PériodeJournée.Matin ? Expressions.English.Bonjour
                : moment == PériodeJournée.AprèsMidi ? Expressions.English.Bonjour
                : moment == PériodeJournée.Soir ? Expressions.English.Bonsoir
                : moment == PériodeJournée.Nuit ? Expressions.English.Bonsoir
                : Expressions.English.Bonjour;
        }

        /// <inheritdoc />
        public string DireAuRevoir(PériodeJournée moment)
        {
            return moment == PériodeJournée.Matin ? Expressions.English.AuRevoirMatin
                : moment == PériodeJournée.AprèsMidi ? Expressions.English.AuRevoirAprèsMidi
                : moment == PériodeJournée.Soir ? Expressions.English.AuRevoirSoir
                : moment == PériodeJournée.Nuit ? Expressions.English.AuRevoirNuit
                : Expressions.English.AuRevoir;
        }
    }
}
