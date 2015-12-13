using System;
using System.Collections.Generic;
using TrackableEntities;

namespace TrackableClassLibrary.Entities.Service.Net45.Models
{
    public partial class SoftwareType : ITrackable, IMergeable
    {
        public SoftwareType()
        {
            this.Softwares = new List<Software>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Software> Softwares { get; set; }

        public TrackingState TrackingState { get; set; }
        public ICollection<string> ModifiedProperties { get; set; }
        public Guid EntityIdentifier { get; set; }
    }
}
