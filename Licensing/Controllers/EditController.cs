﻿using Licensing.Core;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Licensing.Models;
using TrackableClassLibrary.Entities.Service.Net45.Contexts;
using TrackableClassLibrary.Entities.Service.Net45.Models;
using TrackableEntities.Common;
using TrackableEntities.EF6;

namespace Licensing.Controllers
{
    public class EditController : CoreController
    {
        private LicensingContext licenseContext = new LicensingContext();
        
        public EditController()
        {

        }

        [HttpGet]
        public ActionResult EditLicence(int? id)
        {
            var licence = licenseContext.Licences
                .Include(l => l.LicenceAllocations.Select(la => la.Person))
                .Single(l => l.Id == id.Value);

            var people = licenseContext.People.ToArray();

            var licenceViewModel = new EditLicenceViewModel
            {
                LicenceId = id.Value,
                Licence = licence,
                People = people
            };

            return View(licenceViewModel);
        }


        [HttpPost]
        public ActionResult EditLicence([ModelBinder(typeof(BetterDefaultModelBinder))]Licence licence)
        {

            licenseContext.ApplyChanges(licence);
            licenseContext.SaveChanges();
            licence.AcceptChanges();

            return GetLicenceById(licence.Id);
        }

        [HttpPost]
        public ActionResult GetLicenceById(int? id)
        {
            var licence = licenseContext.Licences
                .Include(l => l.LicenceAllocations.Select(la => la.Person))
                .SingleOrDefault(l => l.Id == id.Value) ?? new Licence();

            var people = licenseContext.People.ToArray();

            return NewtonJson(new { licence, people });
        }

        public ActionResult GetAllPeople()
        {
            var people = licenseContext.People;

            return NewtonJson(new {d = new { __count = people.Count(), results = people }});
        }
    }
}