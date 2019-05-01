using DesignPatterns.Structural.Facade.Interfaces;

namespace DesignPatterns.Structural.Facade
{
    public class ATM : IATM
    {
        private IATMHardvareDirector _hardvareDirector;
        private IBankMessageReciever _messageReciever;
        private IBankMessageSender _messageSender;

        public ATM(IATMHardvareDirector director, IBankMessageReciever reciever, IBankMessageSender sender)
        {
            this._hardvareDirector = director;
            this._messageReciever = reciever;
            this._messageSender = sender;
        }

        public void GiveClientMoney()
        {
            this._messageSender.SendMessage();
            this._messageReciever.RecieveMessege();
            this._hardvareDirector.GiveMoney();
        }
    }
}