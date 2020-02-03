namespace DesignPatterns.Behavioral.ChainResponsibility.MedPersonel
{
    public class Nurse : ICureProvider
    {
        public ICureProvider MoreSeniorMedGuy { get; set; }

        public bool TryToCure(string disease)
        {
            if (disease == "flue")
                return true;
            else
            {
                if (MoreSeniorMedGuy == null)
                    return false;

                MoreSeniorMedGuy.TryToCure(disease);
            }
            return false;
        }

        public Nurse(ICureProvider seniorDoctor)
        {
            MoreSeniorMedGuy = seniorDoctor;
        }
    }
}