using DesignPatterns.Structural.Proxy.Models;

namespace DesignPatterns.Structural.Proxy
{
    public interface IStorageService
    {
        ModelObject ReturnAnObjectOnRequest(string objectName);
    }
}