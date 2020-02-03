namespace DesignPatterns.Behavioral.Visitor
{
    class InsuranceAgent : IVisitor
    {
        public void DealWithHost(IHost inputHost)
        {
            (inputHost as IInsuranceBuyer).BuyInsurance();
        }
    }
}
