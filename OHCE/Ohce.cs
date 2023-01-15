using System.Text;

namespace OHCE;

public class Ohce
{
    private readonly ILangue _langue;
    private readonly PériodeJournée _périodeJournée;

    public Ohce(ILangue langue, PériodeJournée périodeJournée)
    {
        _langue = langue;
        _périodeJournée = périodeJournée;
    }

    public string SaluerBonjour()
    {
        return _langue.DireBonjour(_périodeJournée);
    }

    public string SaluerAuRevoir()
    {
        return _langue.DireAuRevoir(_périodeJournée);
    }

    public string DemandePalindrome()
    {
        return _langue.DemandePalindrome;
    }
    public string bienDit()
    {
        return _langue.BienDit;
    }

    public string Palindrome(string input)
    {
        var stringBuilder = new StringBuilder();

        var reversed = new string(input.Reverse().ToArray());

        stringBuilder.Append(reversed);

        if (reversed.Equals(input))
            stringBuilder.Append(_langue.BienDit);

        return stringBuilder.ToString();
    }
}