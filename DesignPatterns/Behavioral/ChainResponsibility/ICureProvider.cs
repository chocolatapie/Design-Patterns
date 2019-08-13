namespace DesignPatterns.Behavioral.ChainResponsibility
{
    public interface ICureProvider
    {
        ICureProvider MoreSeniorMedGuy { get; set; }

        bool TryToCure(string disease);
    }
}