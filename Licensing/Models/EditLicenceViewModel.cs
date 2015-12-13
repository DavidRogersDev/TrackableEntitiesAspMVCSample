using System.Collections.Generic;
using TrackableClassLibrary.Entities.Service.Net45.Models;

namespace Licensing.Models
{
    public class EditLicenceViewModel
    {
        public Licence Licence { get; set; }
        public IEnumerable<Person> People { get; set; }

        public int LicenceId { get; set; }
    }
}
