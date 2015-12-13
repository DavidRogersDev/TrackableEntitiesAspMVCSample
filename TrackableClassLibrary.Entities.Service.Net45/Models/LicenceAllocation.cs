using System;
using System.Collections.Generic;
using TrackableEntities;

namespace TrackableClassLibrary.Entities.Service.Net45.Models
{
    public partial class LicenceAllocation : ITrackable, IMergeable
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int LicenceId { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Licence Licence { get; set; }
        public Person Person { get; set; }

        public TrackingState TrackingState { get; set; }
        public ICollection<string> ModifiedProperties { get; set; }
        public Guid EntityIdentifier { get; set; }
    }
}
