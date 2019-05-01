using DesignPatterns.Structural.Proxy.Models;

namespace DesignPatterns.Structural.Proxy.Services
{
    public class ProxyService : IStorageService
    {
        private IStorageService _mainService;

        public ProxyService(IStorageService inputService)
        {
            _mainService = inputService;
        }

        public ModelObject ReturnAnObjectOnRequest(string objName)
        {
            throw new System.NotImplementedException();
        }
    }
}