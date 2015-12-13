using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Licensing.Core
{
    public static class ObjectExtensions
    {
        public static bool HasMethod(this object objectToCheck, string methodName)
        {
            var type = objectToCheck.GetType();
            return !ReferenceEquals(type.GetMethod(methodName), null);
        }

        public static bool HasProperty(this object objectToCheck, string propertyName)
        {
            var type = objectToCheck.GetType();
            return !ReferenceEquals(type.GetProperty(propertyName), null);
        }

        public static string ToJsonNet(this object obj)
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

            // Date is set for Australian format. Obviously changeable.
            var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = "dd-MM-yyyy HH:mm:ss" };
            settings.Converters.Add(dateTimeConverter);

            return JsonConvert.SerializeObject(obj, Formatting.None, settings);
        }

        public static string ToJsonNet(this object obj, JsonSerializerSettings settings, Formatting formatting = Formatting.None, IsoDateTimeConverter dateTimeConverter = null)
        {
            if (dateTimeConverter != null) 
                settings.Converters.Add(dateTimeConverter);
            return JsonConvert.SerializeObject(obj, formatting, settings);
        }
    }
}