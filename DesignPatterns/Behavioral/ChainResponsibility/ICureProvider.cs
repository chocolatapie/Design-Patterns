namespace DesignPatterns.Behavioral.ChainResponsibility
{
    /// <summary>
    /// Interface for member of chain, each one tries to cure - if not calls more senior member
    /// </summary>
    public interface ICureProvider
    {
        ICureProvider MoreSeniorMedGuy { get; set; }

        bool TryToCure(string disease);
    }
}