using System.Collections.Generic;
using System.Threading;
using DesignPatterns.Structural.Proxy.Models;

namespace DesignPatterns.Structural.Proxy.Services
{
    public class TimeConsumingStorageService : IStorageService
    {
        private List<ModelObject> _objects;

        public TimeConsumingStorageService()
        {
            _objects = new List<ModelObject>();
            _objects.Add(new ModelObject("A"));
            _objects.Add(new ModelObject("B"));
            _objects.Add(new ModelObject("C"));
            _objects.Add(new ModelObject("D"));
        }

        public ModelObject ReturnAnObjectOnRequest(string objName)
        {
            ModelObject returnedObj = null;
            if (_objects != null)
            {
                Thread.Sleep(3000);
                foreach (ModelObject modelObject in this._objects)
                {
                    if (modelObject.ObjName == objName)
                    {
                        returnedObj = modelObject;
                    }
                }
            }
            return returnedObj;
        }
    }
}
