using OHCE.Langues;
using OHCE.Test.xUnit.Utilities;
using OHCE.Test.xUnit.Utilities.Builders;

namespace OHCE.Test.xUnit;

public class OhceTest
{

    private static readonly IEnumerable<ILangue> Langues = new ILangue[]
{
        new LangueAnglaise(),
        new LangueFrançaise(),
        new LangueHongroise(),
};

    private static readonly IEnumerable<PériodeJournée> Périodes = new PériodeJournée[]
    {
        PériodeJournée.Matin,
        PériodeJournée.AprèsMidi,
        PériodeJournée.Soir,
        PériodeJournée.Nuit,
        PériodeJournée.Defaut
    };

    public static IEnumerable<object[]> LanguesSeules => new CartesianData(Langues);
    public static IEnumerable<object[]> LanguesEtPériodes => new CartesianData(Langues, Périodes);

    [Fact(DisplayName = 
        "QUAND on entre une chaîne de caractères " +
        "ALORS elle est renvoyée en miroir.")]
    public void MiroirTest()
    {
        var ohce = OhceBuilder.Default;

        // QUAND on entre une chaîne de caractère
        var sortie = ohce.Palindrome("toto");

        // ALORS elle est renvoyée en miroir
        Assert.Contains("otot", sortie);
    }

    [Theory(DisplayName = 
        "ETANT DONNE un utilisateur parlant une langue" +
        "QUAND on entre un palindrome " +
        "ALORS il est renvoyé " +
        "ET le <bienDit> de cette langue est envoyé.")]
    [MemberData(nameof(LanguesSeules))]
    public void PalindromeTest(ILangue langue)
    {
        // ETANT DONNE un utilisateur parlant <langue>
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .Build();

        // QUAND on entre un palindrome
        const string palindrome = "kayak";
        var sortie = ohce.Palindrome(palindrome);

        // ALORS il est renvoyé
        // ET <bienDit> en <langue> est envoyé
        Assert.Contains(
            palindrome + langue.BienDit, 
            sortie);
    }


    [Theory(DisplayName =  
        "ETANT DONNE un utilisateur parlant une langue " + 
        "ET que la période de la journée est <période>" + 
        "QUAND on saisit une chaîne" + 
        "ALORS <salutation> de cette langue à cette période est envoyé avant tout.")]
    [MemberData(nameof(LanguesEtPériodes))]
    public void SaisiBonjourTest(ILangue langue, PériodeJournée période)
    {
        // ETANT DONNE un utilisateur parlant une langue
        // ET que la période de la journée est <période>
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .AyantPourPériodeDeLaJournée(période)
            .Build();

        // QUAND on saisit une chaîne
        var sortie = ohce.Palindrome(string.Empty);

        // ALORS <salutation> de cette langue à cette période est envoyé avant tout
        Assert.StartsWith(langue.DireBonjour(période), sortie);
    }

    [Theory(DisplayName = 
        "ETANT DONNE un utilisateur parlant une langue " +
        "ET que la période de la journée est <période> " +
        "QUAND on saisit une chaîne " +
        "ALORS <auRevoir> dans cette langue à cette période est envoyé en dernier.")]
    [MemberData(nameof(LanguesEtPériodes))]
    public void SaisiAuRevoirTest(ILangue langue, PériodeJournée période)
    {
        // ETANT DONNE un utilisateur parlant une langue
        // ET que la période de la journée est <période>
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .AyantPourPériodeDeLaJournée(période)
            .Build();

        // QUAND on saisit une chaîne
        var sortie = ohce.Palindrome(string.Empty);

        // ALORS <auRevoir> dans cette langue à cette période est envoyé en dernier
        Assert.EndsWith(langue.DireAuRevoir(période), sortie);
    }


    [Theory(DisplayName =
        "ETANT DONNE un utilisateur parlant une langue " +
        "ET que la période de la journée est <période> " +
        "QUAND l'utilisateur lance le programme " +
        "ALORS <Bonjour> dans cette langue à cette période est envoyé avant tout.")]
            [MemberData(nameof(LanguesEtPériodes))]
    public void SaluerBonjourTest(ILangue langue, PériodeJournée période)
    {
        // ETANT DONNE un utilisateur parlant une langue
        // ET que la période de la journée est <période>
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .AyantPourPériodeDeLaJournée(période)
            .Build();

        // QUAND l'utilisateur lance le programme
        var sortie = ohce.SaluerBonjour();

        // ALORS <Bonjour> dans cette langue à cette période est envoyé avant tout
        Assert.Equal(langue.DireBonjour(période), sortie);
    }

    [Theory(DisplayName =
        "ETANT DONNE un utilisateur parlant une langue " +
        "ET que la période de la journée est <période> " +
        "QUAND l'utilisateur quitte le programme " +
        "ALORS <auRevoir> dans cette langue à cette période est envoyé en dernier.")]
    [MemberData(nameof(LanguesEtPériodes))]
    public void SaluerAuRevoirTest(ILangue langue, PériodeJournée période)
    {
        // ETANT DONNE un utilisateur parlant une langue
        // ET que la période de la journée est <période>
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .AyantPourPériodeDeLaJournée(période)
            .Build();

        // QUAND on saisit une chaîne
        var sortie = ohce.SaluerAuRevoir();

        // ALORS <auRevoir> dans cette langue à cette période est envoyé en dernier
        Assert.Equal(langue.DireAuRevoir(période), sortie);
    }

    [Theory(DisplayName =
        "ETANT DONNE un utilisateur parlant une langue " +
        "QUAND l'utilisateur lance le programme, ce dernier demande de saisir un mot " +
        "ALORS <DemandePalindrome> dans cette langue est envoyé.")]
    [MemberData(nameof(LanguesSeules))]
    public void DemandePalindromeTest(ILangue langue)
    {
        // ETANT DONNE un utilisateur parlant une langue
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .Build();

        // QUAND l'utilisateur lance le programme, ce dernier demande de saisir un mot 
        var sortie = ohce.DemandePalindrome();

        // ALORS <DemandePalindrome> dans cette langue est envoyé.
        Assert.Equal(langue.DemandePalindrome, sortie);
    }

    [Theory(DisplayName =
        "ETANT DONNE un utilisateur parlant une langue " +
        "QUAND l'utilisateur lance le programme, l'utilisateur saisi un palindrome " +
        "ALORS <BienDit> dans cette langue est envoyé.")]
    [MemberData(nameof(LanguesSeules))]
    public void BienDitTest(ILangue langue)
    {
        // ETANT DONNE un utilisateur parlant une langue
        var ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .Build();

        // QUAND l'utilisateur lance le programme, l'utilisateur saisi un palindrome 
        var sortie = ohce.bienDit();

        // ALORS <BienDit> dans cette langue est envoyé.
        Assert.Equal(langue.BienDit, sortie);
    }
}