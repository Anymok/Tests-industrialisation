namespace OHCE.Langues
{
    public class LangueHongroise : ILangue
    {
        /// <inheritdoc />
        public string DemandePalindrome => Expressions.Hungarian.DemandePalindrome;
        /// <inheritdoc />
        public string BienDit => Expressions.Hungarian.BienDit;

        /// <inheritdoc />
        public string DireBonjour(PériodeJournée moment)
        {
            return moment == PériodeJournée.Matin ? Expressions.Hungarian.Bonjour
                : moment == PériodeJournée.AprèsMidi ? Expressions.Hungarian.Bonjour
                : moment == PériodeJournée.Soir ? Expressions.Hungarian.Bonsoir
                : moment == PériodeJournée.Nuit ? Expressions.Hungarian.Bonsoir
                : Expressions.Hungarian.Bonjour;
        }

        /// <inheritdoc />
        public string DireAuRevoir(PériodeJournée moment)
        {
            return moment == PériodeJournée.Matin ? Expressions.Hungarian.AuRevoirMatin
                : moment == PériodeJournée.AprèsMidi ? Expressions.Hungarian.AuRevoirAprèsMidi
                : moment == PériodeJournée.Soir ? Expressions.Hungarian.AuRevoirSoir
                : moment == PériodeJournée.Nuit ? Expressions.Hungarian.AuRevoirNuit
                : Expressions.Hungarian.AuRevoir;
        }
    }
}
