using DesignPatterns.Structural.Proxy.Models;

namespace DesignPatterns.Structural.Proxy.Interfaces
{
    public interface IStorageService
    {
        ModelObject ReturnAnObjectOnRequest(string objectName);
    }
}