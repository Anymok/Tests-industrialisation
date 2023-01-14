namespace OHCE
{
    public interface ILangue
    {
        string BienDit { get; }
        string DireBonjour(PériodeJournée période);
        string DireAuRevoir(PériodeJournée période);
    }
}
