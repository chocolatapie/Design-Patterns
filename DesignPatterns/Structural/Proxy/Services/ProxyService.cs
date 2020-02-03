using System.Collections.Generic;
using DesignPatterns.Structural.Proxy.Interfaces;
using DesignPatterns.Structural.Proxy.Models;

namespace DesignPatterns.Structural.Proxy.Services
{
    public class ProxyService : IStorageService
    {
        private List<ModelObject> _cachedObjects;
        private IStorageService _mainService;

        public ProxyService(IStorageService inputService)
        {
            _mainService = inputService;
            _cachedObjects = new List<ModelObject>();
        }

        public ModelObject ReturnAnObjectOnRequest(string objName)
        {
            foreach (ModelObject modelObj in _cachedObjects)
            {
                if (modelObj.ObjName == objName)
                {
                    return modelObj;
                }
            }

            ModelObject returningObj = this._mainService.ReturnAnObjectOnRequest(objName);
            this._cachedObjects.Add(returningObj);
            return returningObj;
        }
    }
}