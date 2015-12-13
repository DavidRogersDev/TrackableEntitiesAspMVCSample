using System;
using System.Collections.Generic;
using TrackableEntities;

namespace TrackableClassLibrary.Entities.Service.Net45.Models
{
    public partial class Licence : ITrackable, IMergeable
    {
        public Licence()
        {
            this.LicenceAllocations = new List<LicenceAllocation>();
        }

        public int Id { get; set; }
        public string LicenceKey { get; set; }
        public int SoftwareId { get; set; }
        public List<LicenceAllocation> LicenceAllocations { get; set; }
        public Software Software { get; set; }

        public TrackingState TrackingState { get; set; }
        public ICollection<string> ModifiedProperties { get; set; }
        public Guid EntityIdentifier { get; set; }
    }
}
