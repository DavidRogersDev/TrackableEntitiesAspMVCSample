using System.Web.Mvc;
using Licensing.Models;
using TrackableClassLibrary.Entities.Service.Net45.Contexts;

namespace Licensing.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _service;
        private LicensingContext licenseContext = new LicensingContext();

        public HomeController(IService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetLicences()
        {
            var licences = licenseContext.Licences;

            return Json(licences, JsonRequestBehavior.AllowGet);
        }
    }
}