using System;
using System.Collections.Generic;
using TrackableEntities;

namespace TrackableClassLibrary.Entities.Service.Net45.Models
{
    public partial class Person : ITrackable, IMergeable
    {
        public Person()
        {
            this.LicenceAllocations = new List<LicenceAllocation>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<LicenceAllocation> LicenceAllocations { get; set; }

        public TrackingState TrackingState { get; set; }
        public ICollection<string> ModifiedProperties { get; set; }
        public Guid EntityIdentifier { get; set; }
    }
}
