using OHCE.Langues;

namespace OHCE.Test.xUnit
{
    public class LanguesTest
    {
        [Theory]
        [InlineData(PériodeJournée.Defaut, Expressions.Français.Bonjour)]
        [InlineData(PériodeJournée.Matin, Expressions.Français.Bonjour)]
        [InlineData(PériodeJournée.AprèsMidi, Expressions.Français.Bonjour)]
        [InlineData(PériodeJournée.Soir, Expressions.Français.Bonsoir)]
        [InlineData(PériodeJournée.Nuit, Expressions.Français.Bonsoir)]
        public void DireBonjourEnFrançaisTest(PériodeJournée période, string salutationAttendue)
        {
            // ETANT DONNE la langue Française
            // ET une période de la journée <période>
            var langue = new LangueFrançaise();

            // QUAND je dis bonjour
            var salutation = langue.DireBonjour(période);

            // ALORS on me répond <salutationAttendue>
            Assert.Equal(salutationAttendue, salutation);
        }

        [Theory]
        [InlineData(PériodeJournée.Defaut, Expressions.English.Bonjour)]
        [InlineData(PériodeJournée.Matin, Expressions.English.Bonjour)]
        [InlineData(PériodeJournée.AprèsMidi, Expressions.English.Bonjour)]
        [InlineData(PériodeJournée.Soir, Expressions.English.Bonsoir)]
        [InlineData(PériodeJournée.Nuit, Expressions.English.Bonsoir)]
        public void DireBonjourEnAnglaisTest(PériodeJournée période, string salutationAttendue)
        {
            // ETANT DONNE la langue Anglaise
            // ET une période de la journée <période>
            var langue = new LangueAnglaise();

            // QUAND je dis bonjour
            var salutation = langue.DireBonjour(période);

            // ALORS on me répond <salutationAttendue>
            Assert.Equal(salutationAttendue, salutation);
        }

        [Theory]
        [InlineData(PériodeJournée.Defaut, Expressions.Hungarian.Bonjour)]
        [InlineData(PériodeJournée.Matin, Expressions.Hungarian.Bonjour)]
        [InlineData(PériodeJournée.AprèsMidi, Expressions.Hungarian.Bonjour)]
        [InlineData(PériodeJournée.Soir, Expressions.Hungarian.Bonsoir)]
        [InlineData(PériodeJournée.Nuit, Expressions.Hungarian.Bonsoir)]
        public void DireBonjourEnHongroisTest(PériodeJournée période, string salutationAttendue)
        {
            // ETANT DONNE la langue Hongroise
            // ET une période de la journée <période>
            var langue = new LangueHongroise();

            // QUAND je dis bonjour
            var salutation = langue.DireBonjour(période);

            // ALORS on me répond <salutationAttendue>
            Assert.Equal(salutationAttendue, salutation);
        }

        [Theory]
        [InlineData(PériodeJournée.Defaut, Expressions.Français.AuRevoir)]
        [InlineData(PériodeJournée.Matin, Expressions.Français.AuRevoirMatin)]
        [InlineData(PériodeJournée.AprèsMidi, Expressions.Français.AuRevoirAprèsMidi)]
        [InlineData(PériodeJournée.Soir, Expressions.Français.AuRevoirSoir)]
        [InlineData(PériodeJournée.Nuit, Expressions.Français.AuRevoirNuit)]
        public void DireAuRevoirEnFrançaisTest(PériodeJournée période, string AuRevoirAttendu)
        {
            // ETANT DONNE la langue Française
            // ET une période de la journée <période>
            var langue = new LangueFrançaise();

            // QUAND je dis au revoir
            var AuRevoir = langue.DireAuRevoir(période);

            // ALORS on me répond <AuRevoirAttendu>
            Assert.Equal(AuRevoirAttendu, AuRevoir);
        }

        [Theory]
        [InlineData(PériodeJournée.Defaut, Expressions.English.AuRevoir)]
        [InlineData(PériodeJournée.Matin, Expressions.English.AuRevoirMatin)]
        [InlineData(PériodeJournée.AprèsMidi, Expressions.English.AuRevoirAprèsMidi)]
        [InlineData(PériodeJournée.Soir, Expressions.English.AuRevoirSoir)]
        [InlineData(PériodeJournée.Nuit, Expressions.English.AuRevoirNuit)]
        public void DireAuRevoirEnAnglaisTest(PériodeJournée période, string AuRevoirAttendu)
        {
            // ETANT DONNE la langue Anglaise
            // ET une période de la journée <période>
            var langue = new LangueAnglaise();

            // QUAND je dis au revoir
            var AuRevoir = langue.DireAuRevoir(période);

            // ALORS on me répond <AuRevoirAttendu>
            Assert.Equal(AuRevoirAttendu, AuRevoir);
        }

        [Theory]
        [InlineData(PériodeJournée.Defaut, Expressions.Hungarian.AuRevoir)]
        [InlineData(PériodeJournée.Matin, Expressions.Hungarian.AuRevoirMatin)]
        [InlineData(PériodeJournée.AprèsMidi, Expressions.Hungarian.AuRevoirAprèsMidi)]
        [InlineData(PériodeJournée.Soir, Expressions.Hungarian.AuRevoirSoir)]
        [InlineData(PériodeJournée.Nuit, Expressions.Hungarian.AuRevoirNuit)]
        public void DireAuRevoirEnHongroisTest(PériodeJournée période, string AuRevoirAttendu)
        {
            // ETANT DONNE la langue Hongroise
            // ET une période de la journée <période>
            var langue = new LangueHongroise();

            // QUAND je dis au revoir
            var AuRevoir = langue.DireAuRevoir(période);

            // ALORS on me répond <AuRevoirAttendu>
            Assert.Equal(AuRevoirAttendu, AuRevoir);
        }

        [Theory]
        [InlineData(Expressions.Français.BienDit)]
        public void BienDitEnFrançais(string BienDitAttendu)
        {
            // ETANT DONNE la langue Française
            var langue = new LangueFrançaise();

            // QUAND je saisi un palindrome 
            var BienDit = langue.BienDit;

            // ALORS on me répond <BienDit>
            Assert.Equal(BienDitAttendu, BienDit);
        }

        [Theory]
        [InlineData(Expressions.English.BienDit)]
        public void BienDitEnAnglais(string BienDitAttendu)
        {
            // ETANT DONNE la langue Anglaise
            var langue = new LangueAnglaise();

            // QUAND je saisi un palindrome 
            var BienDit = langue.BienDit;

            // ALORS on me répond <BienDit>
            Assert.Equal(BienDitAttendu, BienDit);
        }

        [Theory]
        [InlineData(Expressions.Hungarian.BienDit)]
        public void BienDitEnHongrois(string BienDitAttendu)
        {
            // ETANT DONNE la langue Hongroise
            var langue = new LangueHongroise();

            // QUAND je saisi un palindrome 
            var BienDit = langue.BienDit;

            // ALORS on me répond <BienDit>
            Assert.Equal(BienDitAttendu, BienDit);
        }

        [Theory]
        [InlineData(Expressions.Français.DemandePalindrome)]
        public void DemandePalindromeEnFrançais(string DemandePalindromeAttendu)
        {
            // ETANT DONNE la langue Française
            var langue = new LangueFrançaise();

            // QUAND je lance le programme
            var DemandePalindrome = langue.DemandePalindrome;

            // ALORS on me demande <DemandePalindrome>
            Assert.Equal(DemandePalindromeAttendu, DemandePalindrome);
        }

        [Theory]
        [InlineData(Expressions.English.DemandePalindrome)]
        public void DemandePalindromeEnAnglais(string DemandePalindromeAttendu)
        {
            // ETANT DONNE la langue Anglaise
            var langue = new LangueAnglaise();

            // QUAND je lance le programme
            var DemandePalindrome = langue.DemandePalindrome;

            // ALORS on me demande <DemandePalindrome>
            Assert.Equal(DemandePalindromeAttendu, DemandePalindrome);
        }

        [Theory]
        [InlineData(Expressions.Hungarian.DemandePalindrome)]
        public void DemandePalindromeEnHongrois(string DemandePalindromeAttendu)
        {
            // ETANT DONNE la langue Hongroise
            var langue = new LangueHongroise();

            // QUAND je lance le programme
            var DemandePalindrome = langue.DemandePalindrome;

            // ALORS on me demande <DemandePalindrome>
            Assert.Equal(DemandePalindromeAttendu, DemandePalindrome);
        }
    }
}
