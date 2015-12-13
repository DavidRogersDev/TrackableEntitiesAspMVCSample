using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Text;
using System.Web.Mvc;

namespace Licensing.Core
{
    public class JsonNetResult : ActionResult
    {
        public Encoding ContentEncoding { get; set; }
        public string ContentType { get; set; }
        public object Data { get; set; }

        public IsoDateTimeConverter IsoDateTimeConverter { get; set; }
        public JsonSerializerSettings SerializerSettings { get; set; }
        public Formatting Formatting { get; set; }

        public JsonNetResult()
        {
            Formatting = Formatting.None;
        }

        public JsonNetResult(JsonSerializerSettings serializerSettings, Formatting formatting, IsoDateTimeConverter isoDateTimeConverter = null)
        {
            SerializerSettings = serializerSettings;
            Formatting = formatting;
            IsoDateTimeConverter = isoDateTimeConverter;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (ReferenceEquals(context, null)) throw new ArgumentNullException("context");

            var response = context.HttpContext.Response;

            response.ContentType = !string.IsNullOrWhiteSpace(ContentType)
              ? ContentType
              : "application/json";

            response.CacheControl = "no-cache";

            if (!ReferenceEquals(ContentEncoding, null))
                response.ContentEncoding = ContentEncoding;

            // Here we call the extension method Object.ToJsonNet().
            if (!ReferenceEquals(Data, null))
            {
                response.Write(!ReferenceEquals(SerializerSettings, null)
                    ? Data.ToJsonNet(SerializerSettings, Formatting, IsoDateTimeConverter)
                    : Data.ToJsonNet());
            }
        }
    }
}