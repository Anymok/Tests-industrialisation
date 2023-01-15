using OHCE;
using OHCE.Console;

var ohce = new Ohce(new SystemLangProxy(), SystemTimePériodeJournéeAdapter.PériodeActuelle());

Console.WriteLine(ohce.SaluerBonjour());

Console.WriteLine(ohce.DemandePalindrome());

Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));

Console.WriteLine(ohce.SaluerAuRevoir());