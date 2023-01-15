using OHCE.Langues;
using System.Globalization;

namespace OHCE.Console
{

    internal class SystemLangProxy : ILangue
    {
        private string locallangue = CultureInfo.CurrentCulture.Name;
        //private string locallangue = "en-US";
        //private string locallangue = "hu-HU";
        //private string locallangue = "fr-FR";
        public string DemandePalindrome => DemandePalindromeValue();
        public string BienDit => BienDitValue();

        /// <inheritdoc />
        public string DireBonjour(PériodeJournée PériodeActuelle)
        {
            if (locallangue == "fr-FR")
            {
                return PériodeActuelle == PériodeJournée.Soir ? Expressions.Français.Bonsoir
                    :PériodeActuelle == PériodeJournée.Nuit ? Expressions.Français.Bonsoir
                    : Expressions.Français.Bonjour;
            }
            else if (locallangue == "en-US")
            {
                return PériodeActuelle == PériodeJournée.Soir ? Expressions.English.Bonsoir
                    : PériodeActuelle == PériodeJournée.Nuit ? Expressions.English.Bonsoir
                    : Expressions.English.Bonjour;
            }
            else if (locallangue == "hu-HU")
            {
                return PériodeActuelle == PériodeJournée.Soir ? Expressions.Hungarian.Bonsoir
                    : PériodeActuelle == PériodeJournée.Nuit ? Expressions.Hungarian.Bonsoir
                    : Expressions.Hungarian.Bonjour;
            }
            else
            {
                return PériodeActuelle == PériodeJournée.Soir ? Expressions.Français.Bonsoir
                    : PériodeActuelle == PériodeJournée.Nuit ? Expressions.Français.Bonsoir
                    : Expressions.Français.Bonjour;
            }

        }

        /// <inheritdoc />
        public string DireAuRevoir(PériodeJournée PériodeActuelle)
        {
            if (locallangue == "fr-FR")
            {
                return PériodeActuelle == PériodeJournée.Soir ? Expressions.Français.Bonsoir
                    : PériodeActuelle == PériodeJournée.Nuit ? Expressions.Français.Bonsoir
                    : Expressions.Français.Bonjour;
            }
            else if (locallangue == "en-US")
            {
                return PériodeActuelle == PériodeJournée.Soir ? Expressions.English.Bonsoir
                    : PériodeActuelle == PériodeJournée.Nuit ? Expressions.English.Bonsoir
                    : Expressions.English.Bonjour;
            }
            else if (locallangue == "hu-HU")
            {
                return PériodeActuelle == PériodeJournée.Soir ? Expressions.Hungarian.Bonsoir
                    : PériodeActuelle == PériodeJournée.Nuit ? Expressions.Hungarian.Bonsoir
                    : Expressions.Hungarian.Bonjour;
            }
            else
            {
                return PériodeActuelle == PériodeJournée.Soir ? Expressions.Français.Bonsoir
                    : PériodeActuelle == PériodeJournée.Nuit ? Expressions.Français.Bonsoir
                    : Expressions.Français.Bonjour;
            }

        }

        private string BienDitValue()
        {
            if (locallangue == "fr-FR")
            {
                return Expressions.Français.BienDit;
            }
            else if (locallangue == "en-US")
            {
                return Expressions.English.BienDit;
            }
            else if (locallangue == "hu-HU")
            {
                return Expressions.Hungarian.BienDit;
            }
            else
            {
                return Expressions.Français.BienDit;
            }
        }

        private string DemandePalindromeValue()
        {
            if (locallangue == "fr-FR")
            {
                return Expressions.Français.DemandePalindrome;
            }
            else if (locallangue == "en-US")
            {
                return Expressions.English.DemandePalindrome;
            }
            else if (locallangue == "hu-HU")
            {
                return Expressions.Hungarian.DemandePalindrome;
            }
            else
            {
                return Expressions.Français.DemandePalindrome;
            }
        }

    }
}