using System.Web.Mvc;
using Licensing.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Licensing.Controllers
{
    public class CoreController : Controller
    {
        public ActionResult NewtonJson(object data)
        {
            var settings = new JsonSerializerSettings()
            {
                // Json.NET will ignore objects in reference loops and not serialize them. 
                // The first time an object is encountered it will be serialized as usual 
                // but if the object is encountered as a child object of itself the serializer 
                // will skip serializing it.
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                // maximum depth allowed when reading JSON.
                MaxDepth = 1,
                PreserveReferencesHandling = PreserveReferencesHandling.None,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            return new JsonNetResult(settings, Formatting.None) { Data = data };
        }
    }
}