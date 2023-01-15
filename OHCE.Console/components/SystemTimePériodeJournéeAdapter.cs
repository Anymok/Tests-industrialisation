namespace OHCE.Console
{
    internal class SystemTimePériodeJournéeAdapter
    {
        public static PériodeJournée PériodeActuelle()
        {
            int HeureAcutelle = DateTime.Now.Hour;

            return HeureAcutelle >= 6 && HeureAcutelle <= 12 ? PériodeJournée.Matin
                : HeureAcutelle > 12 && HeureAcutelle <= 17 ? PériodeJournée.AprèsMidi
                : HeureAcutelle > 17 && HeureAcutelle <= 22 ? PériodeJournée.Soir
                : HeureAcutelle > 22 || HeureAcutelle < 6 ? PériodeJournée.Nuit
                : PériodeJournée.Defaut;

        }
    }
}