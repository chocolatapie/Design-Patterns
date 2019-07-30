namespace DesignPatterns.Behavioral.ChainResponsibility.MedPersonel
{
    public class Traumatologist : ICureProvider
    {
        public ICureProvider MoreSeniorMedGuy { get; set; }

        public bool TryToCure(string disease)
        {
            if(disease == "broken bone")
            {
                return true;
            }
            else
            {
                if (MoreSeniorMedGuy == null)
                {
                    return false;
                }
                MoreSeniorMedGuy.TryToCure(disease);
            }
            return false;
        }

        public Traumatologist(ICureProvider seniorDoctor)
        {
            MoreSeniorMedGuy = seniorDoctor;
        }
    }
}