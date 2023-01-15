namespace OHCE
{
    public interface ILangue
    {
        string DemandePalindrome {  get; }
        string BienDit { get; }
        string DireBonjour(PériodeJournée période);
        string DireAuRevoir(PériodeJournée période);
    }
}
