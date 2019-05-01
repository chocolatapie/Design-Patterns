namespace DesignPatterns.Structural.Proxy.Models
{
    public class ModelObject
    {
        public string ObjName { get; set; }

        public ModelObject(string inputName)
        {
            ObjName = inputName;
        }
    }
}