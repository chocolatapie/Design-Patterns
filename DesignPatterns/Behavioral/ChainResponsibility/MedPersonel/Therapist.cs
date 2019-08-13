namespace DesignPatterns.Behavioral.ChainResponsibility.MedPersonel
{
    public class Therapist : ICureProvider
    {
        public ICureProvider MoreSeniorMedGuy { get; set; }

        public bool TryToCure(string disease)
        {
            if (disease == "flue")
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

        public Therapist(ICureProvider seniorDoctor)
        {
            MoreSeniorMedGuy = seniorDoctor;
        }
    }
}
