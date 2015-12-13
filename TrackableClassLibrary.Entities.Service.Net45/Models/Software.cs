using System;
using System.Collections.Generic;
using TrackableEntities;

namespace TrackableClassLibrary.Entities.Service.Net45.Models
{
    public partial class Software : ITrackable, IMergeable
    {
        public Software()
        {
            this.Licences = new List<Licence>();
            this.SoftwareFiles = new List<SoftwareFile>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public Nullable<int> SoftwareType_Id { get; set; }
        public List<Licence> Licences { get; set; }
        public List<SoftwareFile> SoftwareFiles { get; set; }
        public SoftwareType SoftwareType { get; set; }

        public TrackingState TrackingState { get; set; }
        public ICollection<string> ModifiedProperties { get; set; }
        public Guid EntityIdentifier { get; set; }
    }
}
