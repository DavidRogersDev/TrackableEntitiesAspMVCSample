using System;
using System.Collections.Generic;
using TrackableEntities;

namespace TrackableClassLibrary.Entities.Service.Net45.Models
{
    public partial class SoftwareFile : ITrackable, IMergeable
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int FileType { get; set; }
        public int SoftwareId { get; set; }
        public Software Software { get; set; }

        public TrackingState TrackingState { get; set; }
        public ICollection<string> ModifiedProperties { get; set; }
        public Guid EntityIdentifier { get; set; }
    }
}
