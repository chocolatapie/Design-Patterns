using System;

namespace DesignPatterns.Behavioral.ChainResponsibility.MedPersonel
{
    public class OrthopedicTraumatologist : ICureProvider
    {
        public ICureProvider MoreSeniorMedGuy { get; set; }

        public bool TryToCure(string disease)
        {
            if (disease == "broken leg bone")
            {
                Console.WriteLine(this.ToString() + " is able to cure this!");
                return true;
            }
            else
            {
                if (MoreSeniorMedGuy == null)
                {
                    Console.WriteLine("Nobody is able to cure this!");
                    return false;
                }
                MoreSeniorMedGuy.TryToCure(disease);
            }
            return false;
        }

        public OrthopedicTraumatologist(ICureProvider seniorDoctor)
        {
            MoreSeniorMedGuy = seniorDoctor;
        }

        public override string ToString()
        {
            return "Orthopedic Traumatologist";
        }
    }
}