using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersSecond{
    public class ResourceFileAttribute : Attribute,IResourceFilter
    {
        private readonly string _name;
       

        public ResourceFileAttribute(string name)
        {
            this._name = name;
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine($"Resource Filter -After- { _name }");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine($"Resource Filter -Before- { _name }");
        }
    }
}