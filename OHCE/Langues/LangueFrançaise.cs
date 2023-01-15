namespace OHCE.Langues
{
    public class LangueFrançaise : ILangue
    {
        /// <inheritdoc />
        public string DemandePalindrome => Expressions.Français.DemandePalindrome;
        /// <inheritdoc />
        public string BienDit => Expressions.Français.BienDit;

        /// <inheritdoc />
        public string DireBonjour(PériodeJournée moment)
        {
            return moment == PériodeJournée.Matin ? Expressions.Français.Bonjour
                : moment == PériodeJournée.AprèsMidi ? Expressions.Français.Bonjour
                : moment == PériodeJournée.Soir ? Expressions.Français.Bonsoir
                : moment == PériodeJournée.Nuit ? Expressions.Français.Bonsoir
                : Expressions.Français.Bonjour;
        }

        /// <inheritdoc />
        public string DireAuRevoir(PériodeJournée moment)
        {
            return moment == PériodeJournée.Matin ? Expressions.Français.AuRevoirMatin
                : moment == PériodeJournée.AprèsMidi ? Expressions.Français.AuRevoirAprèsMidi
                : moment == PériodeJournée.Soir ? Expressions.Français.AuRevoirSoir
                : moment == PériodeJournée.Nuit ? Expressions.Français.AuRevoirNuit
                : Expressions.Français.AuRevoir;
        }
    }
}
